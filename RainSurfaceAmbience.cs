public class RainSurfaceAmbience : SingletonComponent<RainSurfaceAmbience>, IClientComponent // TypeDefIndex: 8979
{	// Fields
	public List<RainSurfaceAmbience.SurfaceSound> surfaces; // 0x18
	public GameObjectRef emitterPrefab; // 0x20
	public Dictionary<ParticlePatch, AmbienceEmitter> spawnedEmitters; // 0x28
	private Dictionary<PhysicMaterial, RainSurfaceAmbience.SurfaceSound> surfaceSoundsByMaterial; // 0x30

	// Methods

	// RVA: 0x6A62C0 Offset: 0x6A48C0 VA: 0x1806A62C0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x6A66D0 Offset: 0x6A4CD0 VA: 0x1806A66D0
	public void ReadParticlePatchRaycastHit(bool didHit, RaycastHit raycastHit, ParticlePatch particlePatch) { }

	// RVA: 0x6A66C0 Offset: 0x6A4CC0 VA: 0x1806A66C0
	public void ParticlePatchDestroyingInstances(ParticlePatch particlePatch) { }

	// RVA: 0x6A64F0 Offset: 0x6A4AF0 VA: 0x1806A64F0
	private void DespawnEmitter(ParticlePatch particlePatch) { }

	// RVA: 0x6A6610 Offset: 0x6A4C10 VA: 0x1806A6610
	private RainSurfaceAmbience.SurfaceSound FindSurfaceSound(PhysicMaterial physicMaterial) { }

	// RVA: 0x6A6AE0 Offset: 0x6A50E0 VA: 0x1806A6AE0
	public void .ctor() { }

}

public class RainSurfaceAmbience.SurfaceSound // TypeDefIndex: 8980
{	// Fields
	public AmbienceDefinitionList baseAmbience; // 0x10
	public List<PhysicMaterial> materials; // 0x18

	// Methods

	// RVA: 0x6ACE60 Offset: 0x6AB460 VA: 0x1806ACE60
	public void .ctor() { }

}

