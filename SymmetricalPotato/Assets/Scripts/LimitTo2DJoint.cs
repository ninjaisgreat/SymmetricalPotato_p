using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Physics.Authoring;
using UnityEngine;

// This joint limits the PhysicsBody to the xy plane and only allows for rotation about the z-axis
public class LimitTo2DJoint : MonoBehaviour
{
	private RigidTransform worldFromA => new RigidTransform(gameObject.transform.rotation, gameObject.transform.position);
	
	private Entity m_entityA = Entity.Null;
	public Entity entityA { get => m_entityA; set => m_entityA = value; }

	public void CreateJointEntity(EntityManager entityManager)
	{
		Constraint[] constraints = new Constraint[2];
		constraints[0] = new Constraint
		{
			ConstrainedAxes = new bool3(false, false, true),
			Type = ConstraintType.Linear,
			SpringDamping = Constraint.DefaultSpringDamping,
			SpringFrequency = Constraint.DefaultSpringFrequency,
			Min = 0,
			Max = 0
		};
		constraints[1] = new Constraint
		{
			ConstrainedAxes = new bool3(true, true, false),
			Type = ConstraintType.Angular,
			SpringDamping = Constraint.DefaultSpringDamping,
			SpringFrequency = Constraint.DefaultSpringFrequency,
			Min = 0,
			Max = 0
		};

		BlobAssetReference<JointData> jointData = JointData.Create(
			new Math.MTransform(float3x3.identity, float3.zero),
			new Math.MTransform(worldFromA),
			constraints
		);

		var componentData = new PhysicsJoint
		{
			EnableCollision = 0,
			EntityA = entityA,
			EntityB = Entity.Null,
			JointData = jointData
		};

		ComponentType[] componentTypes = new ComponentType[1];
		componentTypes[0] = typeof(PhysicsJoint);
		Entity jointEntity = entityManager.CreateEntity(componentTypes);

		if (!entityManager.HasComponent<PhysicsJoint>(jointEntity))
		{
			entityManager.AddComponentData(jointEntity, componentData);
		}
		else
		{
			entityManager.SetComponentData(jointEntity, componentData);
		}
	}
}

[UpdateAfter(typeof(PhysicsBodyConversionSystem))]
[UpdateAfter(typeof(LegacyRigidbodyConversionSystem))]
public class PhysicsJointConversionSystem : GameObjectConversionSystem
{
	private void CreateJoint(LimitTo2DJoint joint)
	{
		if (!joint.enabled) return;

		joint.entityA = GetPrimaryEntity(joint.gameObject);
		joint.CreateJointEntity(DstEntityManager);
	}

	protected override void OnUpdate()
	{
		Entities.ForEach((LimitTo2DJoint joint) => { CreateJoint(joint); });
	}
}