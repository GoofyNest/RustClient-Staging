public class ConstructionSocket : Socket_Base // TypeDefIndex: 9060
{	// Fields
	public ConstructionSocket.Type socketType; // 0xE8
	public int rotationDegrees; // 0xEC
	public int rotationOffset; // 0xF0
	public bool restrictPlacementRotation; // 0xF4
	public bool restrictPlacementAngle; // 0xF5
	public float faceAngle; // 0xF8
	public float angleAllowed; // 0xFC
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
	public float support; // 0x100

	// Methods

	// RVA: 0x6B2CA0 Offset: 0x6B12A0 VA: 0x1806B2CA0
	private void OnDrawGizmos() { }

	// RVA: 0x6B2BE0 Offset: 0x6B11E0 VA: 0x1806B2BE0
	private void OnDrawGizmosSelected() { }

	// RVA: 0x6B3110 Offset: 0x6B1710 VA: 0x1806B3110 Slot: 8
	public override bool TestTarget(Construction.Target target) { }

	// RVA: 0x6B2AE0 Offset: 0x6B10E0 VA: 0x1806B2AE0 Slot: 9
	public override bool IsCompatible(Socket_Base socket) { }

	// RVA: 0x6B1620 Offset: 0x6AFC20 VA: 0x1806B1620 Slot: 10
	public override bool CanConnect(Vector3 position, Quaternion rotation, Socket_Base socket, Vector3 socketPosition, Quaternion socketRotation) { }

	// RVA: 0x6B2F50 Offset: 0x6B1550 VA: 0x1806B2F50
	public bool TestRestrictedAngles(Vector3 suggestedPos, Quaternion suggestedAng, Construction.Target target) { }

	// RVA: 0x6B1BE0 Offset: 0x6B01E0 VA: 0x1806B1BE0 Slot: 11
	public override Construction.Placement DoPlacement(Construction.Target target) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 13
	protected virtual bool CanConnectToEntity(Construction.Target target) { }

	// RVA: 0x6B31C0 Offset: 0x6B17C0 VA: 0x1806B31C0
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

	// RVA: 0x6B25D0 Offset: 0x6B0BD0 VA: 0x1806B25D0 Slot: 13
	protected override bool CanConnectToEntity(Construction.Target target) { }

	// RVA: 0x6B27F0 Offset: 0x6B0DF0 VA: 0x1806B27F0 Slot: 10
	public override bool CanConnect(Vector3 position, Quaternion rotation, Socket_Base socket, Vector3 socketPosition, Quaternion socketRotation) { }

	// RVA: 0x6B2AB0 Offset: 0x6B10B0 VA: 0x1806B2AB0
	public void .ctor() { }

}

