public class RainSurfaceAmbience : SingletonComponent<RainSurfaceAmbience>, IClientComponent // TypeDefIndex: 8979
{	// Fields
	public List<RainSurfaceAmbience.SurfaceSound> surfaces; // 0x18
	public GameObjectRef emitterPrefab; // 0x20
	public Dictionary<ParticlePatch, AmbienceEmitter> spawnedEmitters; // 0x28
	private Dictionary<PhysicMaterial, RainSurfaceAmbience.SurfaceSound> surfaceSoundsByMaterial; // 0x30

	// Methods

	// RVA: 0x6A61B0 Offset: 0x6A47B0 VA: 0x1806A61B0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x6A65C0 Offset: 0x6A4BC0 VA: 0x1806A65C0
	public void ReadParticlePatchRaycastHit(bool didHit, RaycastHit raycastHit, ParticlePatch particlePatch) { }

	// RVA: 0x6A65B0 Offset: 0x6A4BB0 VA: 0x1806A65B0
	public void ParticlePatchDestroyingInstances(ParticlePatch particlePatch) { }

	// RVA: 0x6A63E0 Offset: 0x6A49E0 VA: 0x1806A63E0
	private void DespawnEmitter(ParticlePatch particlePatch) { }

	// RVA: 0x6A6500 Offset: 0x6A4B00 VA: 0x1806A6500
	private RainSurfaceAmbience.SurfaceSound FindSurfaceSound(PhysicMaterial physicMaterial) { }

	// RVA: 0x6A69D0 Offset: 0x6A4FD0 VA: 0x1806A69D0
	public void .ctor() { }

}

public class RainSurfaceAmbience.SurfaceSound // TypeDefIndex: 8980
{	// Fields
	public AmbienceDefinitionList baseAmbience; // 0x10
	public List<PhysicMaterial> materials; // 0x18

	// Methods

	// RVA: 0x6ACD50 Offset: 0x6AB350 VA: 0x1806ACD50
	public void .ctor() { }

}

