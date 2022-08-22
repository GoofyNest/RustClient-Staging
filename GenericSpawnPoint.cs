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

	// RVA: 0xC98850 Offset: 0xC96E50 VA: 0x180C98850
	public Quaternion GetRandomRotation() { }

	// RVA: 0xC98970 Offset: 0xC96F70 VA: 0x180C98970
	public void .ctor() { }

}

