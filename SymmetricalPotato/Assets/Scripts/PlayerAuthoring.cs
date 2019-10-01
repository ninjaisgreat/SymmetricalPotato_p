using UnityEngine;
using Unity.Entities;

[RequiresEntityConversion]
public class PlayerAuthoring : MonoBehaviour, IConvertGameObjectToEntity
{
	[SerializeField] private int index;

	public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
	{
		PlayerComponent componentData = new PlayerComponent { playerIndex = index };
		dstManager.AddComponentData(entity, componentData);
	}
}
