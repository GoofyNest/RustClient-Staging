public class GenericSpawnPoint : BaseSpawnPoint // TypeDefIndex: 9999
{	public bool dropToGround; // 0x18
	public bool randomRot; // 0x19
	[RangeAttribute] // RVA: 0xACF90 Offset: 0xAC390 VA: 0x1800ACF90
	public float randomRotSnapDegrees; // 0x1C
	public GameObjectRef spawnEffect; // 0x20
	public UnityEvent OnObjectSpawnedEvent; // 0x28
	public UnityEvent OnObjectRetiredEvent; // 0x30


	public Quaternion GetRandomRotation() { }

	public void .ctor() { }

}

