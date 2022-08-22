public class RainSurfaceAmbience : SingletonComponent<RainSurfaceAmbience>, IClientComponent // TypeDefIndex: 8979
{	// Fields
	public List<RainSurfaceAmbience.SurfaceSound> surfaces; // 0x18
	public GameObjectRef emitterPrefab; // 0x20
	public Dictionary<ParticlePatch, AmbienceEmitter> spawnedEmitters; // 0x28
	private Dictionary<PhysicMaterial, RainSurfaceAmbience.SurfaceSound> surfaceSoundsByMaterial; // 0x30

	// Methods

	// RVA: 0x6A6250 Offset: 0x6A4850 VA: 0x1806A6250 Slot: 6
	protected override void Awake() { }

	// RVA: 0x6A6660 Offset: 0x6A4C60 VA: 0x1806A6660
	public void ReadParticlePatchRaycastHit(bool didHit, RaycastHit raycastHit, ParticlePatch particlePatch) { }

	// RVA: 0x6A6650 Offset: 0x6A4C50 VA: 0x1806A6650
	public void ParticlePatchDestroyingInstances(ParticlePatch particlePatch) { }

	// RVA: 0x6A6480 Offset: 0x6A4A80 VA: 0x1806A6480
	private void DespawnEmitter(ParticlePatch particlePatch) { }

	// RVA: 0x6A65A0 Offset: 0x6A4BA0 VA: 0x1806A65A0
	private RainSurfaceAmbience.SurfaceSound FindSurfaceSound(PhysicMaterial physicMaterial) { }

	// RVA: 0x6A6A70 Offset: 0x6A5070 VA: 0x1806A6A70
	public void .ctor() { }

}

public class RainSurfaceAmbience.SurfaceSound // TypeDefIndex: 8980
{	// Fields
	public AmbienceDefinitionList baseAmbience; // 0x10
	public List<PhysicMaterial> materials; // 0x18

	// Methods

	// RVA: 0x6ACDF0 Offset: 0x6AB3F0 VA: 0x1806ACDF0
	public void .ctor() { }

}

