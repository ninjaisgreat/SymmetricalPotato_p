using System;
using Unity.Entities;

[Serializable]
public struct PlayerComponent : IComponentData
{
	public int playerIndex;
}