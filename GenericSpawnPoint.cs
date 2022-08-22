public class GenericSpawnPoint : BaseSpawnPoint // TypeDefIndex: 9999
{	// Fields
	public bool dropToGround; // 0x18
	public bool randomRot; // 0x19
	[RangeAttribute] // RVA: 0xACEB0 Offset: 0xAC2B0 VA: 0x1800ACEB0
	public float randomRotSnapDegrees; // 0x1C
	public GameObjectRef spawnEffect; // 0x20
	public UnityEvent OnObjectSpawnedEvent; // 0x28
	public UnityEvent OnObjectRetiredEvent; // 0x30

	// Methods

	// RVA: 0xC98B10 Offset: 0xC97110 VA: 0x180C98B10
	public Quaternion GetRandomRotation() { }

	// RVA: 0xC98C30 Offset: 0xC97230 VA: 0x180C98C30
	public void .ctor() { }

}

