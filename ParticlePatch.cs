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

	// RVA: 0x85CC50 Offset: 0x85B250 VA: 0x18085CC50
	public void DestroyInstances() { }

	// RVA: 0x85CA20 Offset: 0x85B020 VA: 0x18085CA20
	public void CreateInstances() { }

	// RVA: 0x85D390 Offset: 0x85B990 VA: 0x18085D390
	public void UpdateInstances() { }

	// RVA: 0x85D4D0 Offset: 0x85BAD0 VA: 0x18085D4D0
	public void .ctor(ParticleSpawn particleSpawn, int i, int j) { }

	// RVA: 0x85CD80 Offset: 0x85B380 VA: 0x18085CD80
	public bool Shift() { }

	// RVA: 0x85D330 Offset: 0x85B930 VA: 0x18085D330
	public void Spawn() { }

}

