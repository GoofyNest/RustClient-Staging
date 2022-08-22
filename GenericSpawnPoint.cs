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

	// RVA: 0xC98FB0 Offset: 0xC975B0 VA: 0x180C98FB0
	public Quaternion GetRandomRotation() { }

	// RVA: 0xC990D0 Offset: 0xC976D0 VA: 0x180C990D0
	public void .ctor() { }

}

