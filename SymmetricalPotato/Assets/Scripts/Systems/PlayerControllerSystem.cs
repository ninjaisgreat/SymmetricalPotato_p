using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Physics;
using UnityEngine.InputSystem;

public struct Data
{
	public float moveX;
	public float moveY;
	public InputMaster actionAsset;
}

public class Player0ControllerSystem : JobComponentSystem
{
	private Data _data;

	[BurstCompile]
	struct MovementJob : IJobForEach<Player0Component, PhysicsVelocity>
	{
		public float moveX;
		public float moveY;

		public void Execute( [ReadOnly] ref Player0Component playerComponent, ref PhysicsVelocity physicsVelocity)
		{
			if (!(playerComponent.hasRockets && playerComponent.hasDash))
			{
				if (moveX > 0.4f || moveX < -0.4f)
				{
					float3 velocityL = new float3(math.sign(moveX) * playerComponent.basicMoveSpeed, physicsVelocity.Linear.y, 0f);
					physicsVelocity.Linear = velocityL;
				}
			}
		}
	}

	protected override void OnCreate()
	{
		_data.actionAsset = new InputMaster();
	}

	protected override void OnStartRunning()
	{
		_data.actionAsset.Player0.Enable();
		_data.actionAsset.Player0.MoveX.performed += ctx => _data.moveX = ctx.ReadValue<float>();
		_data.actionAsset.Player0.MoveX.canceled += ctx => _data.moveX = 0f;
		_data.actionAsset.Player0.MoveY.performed += ctx => _data.moveY = ctx.ReadValue<float>();
		_data.actionAsset.Player0.MoveY.canceled += ctx => _data.moveY = 0f;
	}

	protected override void OnStopRunning()
	{
		_data.actionAsset.Disable();
		_data.actionAsset.Player0.MoveX.performed -= ctx => _data.moveX = ctx.ReadValue<float>();
		_data.actionAsset.Player0.MoveX.canceled -= ctx => _data.moveX = 0f;
		_data.actionAsset.Player0.MoveY.performed -= ctx => _data.moveY = ctx.ReadValue<float>();
		_data.actionAsset.Player0.MoveY.canceled -= ctx => _data.moveY = 0f;
	}

	protected override JobHandle OnUpdate(JobHandle inputDeps)
	{
		var job = new MovementJob {
			moveX = _data.moveX,
			moveY = _data.moveY
			}.Schedule(this, inputDeps);
		
		return job;
	}
}
