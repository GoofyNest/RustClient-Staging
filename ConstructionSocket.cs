public class ConstructionSocket : Socket_Base // TypeDefIndex: 9060
{	// Fields
	public ConstructionSocket.Type socketType; // 0xE8
	public int rotationDegrees; // 0xEC
	public int rotationOffset; // 0xF0
	public bool restrictPlacementRotation; // 0xF4
	public bool restrictPlacementAngle; // 0xF5
	public float faceAngle; // 0xF8
	public float angleAllowed; // 0xFC
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float support; // 0x100

	// Methods

	// RVA: 0x6B2DB0 Offset: 0x6B13B0 VA: 0x1806B2DB0
	private void OnDrawGizmos() { }

	// RVA: 0x6B2CF0 Offset: 0x6B12F0 VA: 0x1806B2CF0
	private void OnDrawGizmosSelected() { }

	// RVA: 0x6B3220 Offset: 0x6B1820 VA: 0x1806B3220 Slot: 8
	public override bool TestTarget(Construction.Target target) { }

	// RVA: 0x6B2BF0 Offset: 0x6B11F0 VA: 0x1806B2BF0 Slot: 9
	public override bool IsCompatible(Socket_Base socket) { }

	// RVA: 0x6B1730 Offset: 0x6AFD30 VA: 0x1806B1730 Slot: 10
	public override bool CanConnect(Vector3 position, Quaternion rotation, Socket_Base socket, Vector3 socketPosition, Quaternion socketRotation) { }

	// RVA: 0x6B3060 Offset: 0x6B1660 VA: 0x1806B3060
	public bool TestRestrictedAngles(Vector3 suggestedPos, Quaternion suggestedAng, Construction.Target target) { }

	// RVA: 0x6B1CF0 Offset: 0x6B02F0 VA: 0x1806B1CF0 Slot: 11
	public override Construction.Placement DoPlacement(Construction.Target target) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 13
	protected virtual bool CanConnectToEntity(Construction.Target target) { }

	// RVA: 0x6B32D0 Offset: 0x6B18D0 VA: 0x1806B32D0
	public void .ctor() { }

}

public enum ConstructionSocket.Type // TypeDefIndex: 9061
{	// Fields
	public int value__; // 0x0
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
{	// Fields
	public int MaxFloor; // 0x108

	// Methods

	// RVA: 0x6B26E0 Offset: 0x6B0CE0 VA: 0x1806B26E0 Slot: 13
	protected override bool CanConnectToEntity(Construction.Target target) { }

	// RVA: 0x6B2900 Offset: 0x6B0F00 VA: 0x1806B2900 Slot: 10
	public override bool CanConnect(Vector3 position, Quaternion rotation, Socket_Base socket, Vector3 socketPosition, Quaternion socketRotation) { }

	// RVA: 0x6B2BC0 Offset: 0x6B11C0 VA: 0x1806B2BC0
	public void .ctor() { }

}

