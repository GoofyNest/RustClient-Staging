public class CH47HelicopterAIController : CH47Helicopter // TypeDefIndex: 9716
{	// Fields
	public GameObjectRef scientistPrefab; // 0x4D8
	public GameObjectRef dismountablePrefab; // 0x4E0
	public GameObjectRef weakDismountablePrefab; // 0x4E8
	public float maxTiltAngle; // 0x4F0
	public float AiAltitudeForce; // 0x4F4
	public GameObjectRef lockedCratePrefab; // 0x4F8
	public const BaseEntity.Flags Flag_Damaged = 32768;
	public const BaseEntity.Flags Flag_NearDeath = 4;
	public const BaseEntity.Flags Flag_DropDoorOpen = 65536;
	public GameObject triggerHurt; // 0x500
	public Vector3 landingTarget; // 0x508

	// Methods

	// RVA: 0x6F5990 Offset: 0x6F3F90 VA: 0x1806F5990 Slot: 184
	public override bool MountMenuVisible(BasePlayer player) { }

	// RVA: 0x6D32B0 Offset: 0x6D18B0 VA: 0x1806D32B0 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x6F59D0 Offset: 0x6F3FD0 VA: 0x1806F59D0
	public void .ctor() { }

}

