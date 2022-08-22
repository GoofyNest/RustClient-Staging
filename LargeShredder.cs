public class LargeShredder : BaseEntity // TypeDefIndex: 9634
{	// Fields
	public Transform shredRail; // 0x168
	public Transform shredRailStartPos; // 0x170
	public Transform shredRailEndPos; // 0x178
	public Vector3 shredRailStartRotation; // 0x180
	public Vector3 shredRailEndRotation; // 0x18C
	public LargeShredderTrigger trigger; // 0x198
	public float shredDurationRotation; // 0x1A0
	public float shredDurationPosition; // 0x1A4
	public float shredSwayAmount; // 0x1A8
	public float shredSwaySpeed; // 0x1AC
	public BaseEntity currentlyShredding; // 0x1B0
	public GameObject[] shreddingWheels; // 0x1B8
	public float shredRotorSpeed; // 0x1C0
	public GameObjectRef shredSoundEffect; // 0x1C8
	public Transform resourceSpawnPoint; // 0x1D0
	private Quaternion entryRotation; // 0x1D8
	public const string SHRED_STAT = "cars_shredded";

	// Methods

	// RVA: 0x5B1260 Offset: 0x5AF860 VA: 0x1805B1260 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x687690 Offset: 0x685C90 VA: 0x180687690
	public void ClientUpdate() { }

	// RVA: 0x687690 Offset: 0x685C90 VA: 0x180687690
	private void Update() { }

	// RVA: 0x687820 Offset: 0x685E20 VA: 0x180687820
	public void .ctor() { }

}

