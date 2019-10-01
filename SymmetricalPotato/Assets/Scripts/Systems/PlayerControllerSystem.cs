using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Physics;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerSystem : JobComponentSystem
{
	[BurstCompile]
	struct MovementJob : IJobForEach<PlayerComponent, PhysicsVelocity>
	{
		public bool3 pressed;
		
		public void Execute( [ReadOnly] ref PlayerComponent playerComponent, ref PhysicsVelocity physicsVelocity)
		{
			if (pressed.x) physicsVelocity.Linear.y = 5;
			if (pressed.y) physicsVelocity.Linear.x = -5;
			if (pressed.z) physicsVelocity.Linear.x = 5;
		}
	}

	protected override JobHandle OnUpdate(JobHandle inputDeps)
	{
		bool3 _pressed;
		_pressed.x = Keyboard.current.wKey.wasPressedThisFrame;
		_pressed.y = Keyboard.current.aKey.isPressed;
		_pressed.z = Keyboard.current.dKey.isPressed;

		var job = new MovementJob {
			pressed = _pressed
			}.Schedule(this, inputDeps);
		return job;
	}
}
