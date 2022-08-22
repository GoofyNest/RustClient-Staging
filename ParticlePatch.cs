public class ParticlePatch // TypeDefIndex: 10358
{	// Fields
	private bool initialized; // 0x10
	private float LOD; // 0x14
	private float shift; // 0x18
	private float extent; // 0x1C
	private Vector3 offset; // 0x20
	private Vector3 position; // 0x2C
	private bool didHit; // 0x38
	private float hitRefreshTime; // 0x3C
	private RaycastHit raycastHit; // 0x40
	private ParticleSpawn particleSpawn; // 0x70
	private List<GameObject> spawns; // 0x78

	// Methods

	// RVA: 0x85CD60 Offset: 0x85B360 VA: 0x18085CD60
	public void DestroyInstances() { }

	// RVA: 0x85CB30 Offset: 0x85B130 VA: 0x18085CB30
	public void CreateInstances() { }

	// RVA: 0x85D4A0 Offset: 0x85BAA0 VA: 0x18085D4A0
	public void UpdateInstances() { }

	// RVA: 0x85D5E0 Offset: 0x85BBE0 VA: 0x18085D5E0
	public void .ctor(ParticleSpawn particleSpawn, int i, int j) { }

	// RVA: 0x85CE90 Offset: 0x85B490 VA: 0x18085CE90
	public bool Shift() { }

	// RVA: 0x85D440 Offset: 0x85BA40 VA: 0x18085D440
	public void Spawn() { }

}

