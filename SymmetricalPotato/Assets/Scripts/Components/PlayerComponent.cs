using System;
using Unity.Entities;

public struct Player0Component : IComponentData
{
	public float basicMoveSpeed;
	public bool hasRockets;
	public bool hasDash;
}