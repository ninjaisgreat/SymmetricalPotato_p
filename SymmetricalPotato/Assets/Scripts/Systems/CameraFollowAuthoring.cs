using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

public class CameraFollowAuthoring : MonoBehaviour, IConvertGameObjectToEntity
{
	public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
	{
		dstManager.AddComponentData(entity, new CameraComponent());
		dstManager.AddComponentData(entity, new CopyTransformToGameObject());
	}
}

public class ChangeCameraPositionSystem : JobComponentSystem
{
	private EntityQuery _entityQuery;

	protected override void OnCreate()
	{
		_entityQuery = GetEntityQuery(ComponentType.ReadOnly<Player0Component>(), ComponentType.ReadOnly<Translation>());
	}

	[BurstCompile]
	struct SetCameraPositionJob : IJobForEach<CameraComponent, Translation>
	{
		[ReadOnly] [DeallocateOnJobCompletion] public NativeArray<Translation> playerTranslationArray;
		public float dt;

		public void Execute( [ReadOnly] ref CameraComponent camera, ref Translation cameraPosition)
		{
			float3 targetPosition = new float3(playerTranslationArray[0].Value.x, playerTranslationArray[0].Value.y, -10f);
			float3 smoothedPosition = math.lerp(cameraPosition.Value, targetPosition, 2f * dt);
			cameraPosition.Value = smoothedPosition;
		}
	}

	protected override JobHandle OnUpdate(JobHandle inputDeps)
	{
		var job = new SetCameraPositionJob
		{
			playerTranslationArray = _entityQuery.ToComponentDataArray<Translation>(Allocator.TempJob),
			dt = Time.deltaTime
		}.Schedule(this, inputDeps);

		return job;
	}
}