﻿using UnityEngine;
using Unity.Entities;

[RequiresEntityConversion]
public class PlayerAuthoring : MonoBehaviour, IConvertGameObjectToEntity
{
	[SerializeField] private int index;

	public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
	{
		if (index == 0)
		{
			Player0Component componentData = new Player0Component { basicMoveSpeed = 8f, hasRockets = false, hasDash = false };
			dstManager.AddComponentData(entity, componentData);
		}
	}
}
