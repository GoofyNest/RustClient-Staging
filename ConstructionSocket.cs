public class ConstructionSocket : Socket_Base // TypeDefIndex: 9060
{	public ConstructionSocket.Type socketType; // 0xE8
	public int rotationDegrees; // 0xEC
	public int rotationOffset; // 0xF0
	public bool restrictPlacementRotation; // 0xF4
	public bool restrictPlacementAngle; // 0xF5
	public float faceAngle; // 0xF8
	public float angleAllowed; // 0xFC
	[RangeAttribute] // RVA: 0x717B0 Offset: 0x70BB0 VA: 0x1800717B0
	public float support; // 0x100


	private void OnDrawGizmos() { }

	private void OnDrawGizmosSelected() { }

	public override bool TestTarget(Construction.Target target) { }

	public override bool IsCompatible(Socket_Base socket) { }

	public override bool CanConnect(Vector3 position, Quaternion rotation, Socket_Base socket, Vector3 socketPosition, Quaternion socketRotation) { }

	public bool TestRestrictedAngles(Vector3 suggestedPos, Quaternion suggestedAng, Construction.Target target) { }

	public override Construction.Placement DoPlacement(Construction.Target target) { }

	protected virtual bool CanConnectToEntity(Construction.Target target) { }

	public void .ctor() { }

}

public enum ConstructionSocket.Type // TypeDefIndex: 9061
{	public int value__; // 0x0
	public const ConstructionSocket.Type None = 0;
	public const ConstructionSocket.Type Foundation = 1;
	public const ConstructionSocket.Type Floor = 2;
	public const ConstructionSocket.Type Misc = 3;
	public const ConstructionSocket.Type Doorway = 4;
	public const ConstructionSocket.Type Wall = 5;
	public const ConstructionSocket.Type Block = 6;
	public const ConstructionSocket.Type Ramp = 7;
	public const ConstructionSocket.Type StairsTriangle = 8;
	public const ConstructionSocket.Type Stairs = 9;
	public const ConstructionSocket.Type FloorFrameTriangle = 10;
	public const ConstructionSocket.Type Window = 11;
	public const ConstructionSocket.Type Shutters = 12;
	public const ConstructionSocket.Type WallFrame = 13;
	public const ConstructionSocket.Type FloorFrame = 14;
	public const ConstructionSocket.Type WindowDressing = 15;
	public const ConstructionSocket.Type DoorDressing = 16;
	public const ConstructionSocket.Type Elevator = 17;
	public const ConstructionSocket.Type DoubleDoorDressing = 18;

}

public class ConstructionSocket_Elevator : ConstructionSocket // TypeDefIndex: 9062
{	public int MaxFloor; // 0x108


	protected override bool CanConnectToEntity(Construction.Target target) { }

	public override bool CanConnect(Vector3 position, Quaternion rotation, Socket_Base socket, Vector3 socketPosition, Quaternion socketRotation) { }

	public void .ctor() { }

}

