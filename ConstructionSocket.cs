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

	// RVA: 0x6B2D40 Offset: 0x6B1340 VA: 0x1806B2D40
	private void OnDrawGizmos() { }

	// RVA: 0x6B2C80 Offset: 0x6B1280 VA: 0x1806B2C80
	private void OnDrawGizmosSelected() { }

	// RVA: 0x6B31B0 Offset: 0x6B17B0 VA: 0x1806B31B0 Slot: 8
	public override bool TestTarget(Construction.Target target) { }

	// RVA: 0x6B2B80 Offset: 0x6B1180 VA: 0x1806B2B80 Slot: 9
	public override bool IsCompatible(Socket_Base socket) { }

	// RVA: 0x6B16C0 Offset: 0x6AFCC0 VA: 0x1806B16C0 Slot: 10
	public override bool CanConnect(Vector3 position, Quaternion rotation, Socket_Base socket, Vector3 socketPosition, Quaternion socketRotation) { }

	// RVA: 0x6B2FF0 Offset: 0x6B15F0 VA: 0x1806B2FF0
	public bool TestRestrictedAngles(Vector3 suggestedPos, Quaternion suggestedAng, Construction.Target target) { }

	// RVA: 0x6B1C80 Offset: 0x6B0280 VA: 0x1806B1C80 Slot: 11
	public override Construction.Placement DoPlacement(Construction.Target target) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 13
	protected virtual bool CanConnectToEntity(Construction.Target target) { }

	// RVA: 0x6B3260 Offset: 0x6B1860 VA: 0x1806B3260
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

	// RVA: 0x6B2670 Offset: 0x6B0C70 VA: 0x1806B2670 Slot: 13
	protected override bool CanConnectToEntity(Construction.Target target) { }

	// RVA: 0x6B2890 Offset: 0x6B0E90 VA: 0x1806B2890 Slot: 10
	public override bool CanConnect(Vector3 position, Quaternion rotation, Socket_Base socket, Vector3 socketPosition, Quaternion socketRotation) { }

	// RVA: 0x6B2B50 Offset: 0x6B1150 VA: 0x1806B2B50
	public void .ctor() { }

}

