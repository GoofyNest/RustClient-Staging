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

	// RVA: 0x8784C0 Offset: 0x876AC0 VA: 0x1808784C0
	public void DestroyInstances() { }

	// RVA: 0x878290 Offset: 0x876890 VA: 0x180878290
	public void CreateInstances() { }

	// RVA: 0x878C00 Offset: 0x877200 VA: 0x180878C00
	public void UpdateInstances() { }

	// RVA: 0x878D40 Offset: 0x877340 VA: 0x180878D40
	public void .ctor(ParticleSpawn particleSpawn, int i, int j) { }

	// RVA: 0x8785F0 Offset: 0x876BF0 VA: 0x1808785F0
	public bool Shift() { }

	// RVA: 0x878BA0 Offset: 0x8771A0 VA: 0x180878BA0
	public void Spawn() { }

}

