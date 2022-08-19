public class LightGroupAtTime : FacepunchBehaviour // TypeDefIndex: 9197
{	// Fields
	public float IntensityOverride; // 0x18
	public AnimationCurve IntensityScaleOverTime; // 0x20
	public Transform SearchRoot; // 0x28
	[HeaderAttribute] // RVA: 0xD8F00 Offset: 0xD8300 VA: 0x1800D8F00
	public bool requiresPower; // 0x30
	[TooltipAttribute] // RVA: 0xD9140 Offset: 0xD8540 VA: 0x1800D9140
	public Transform powerOverrideTransform; // 0x38
	private List<KeyValuePair<Light, float>> lights; // 0x40
	private List<KeyValuePair<AmbientLightLOD, float>> lightLODs; // 0x48
	private List<KeyValuePair<Renderer, Color>> renderers; // 0x50
	private List<VolumetricLightBeam> beams; // 0x58
	private List<CoverageQueryFlare> coverageQueryFlares; // 0x60
	private List<DistanceFlareLOD> distanceFlares; // 0x68
	private MaterialPropertyBlock block; // 0x70
	private float intensityOverride; // 0x78
	private int lightIndex; // 0x7C
	private int lightLODIndex; // 0x80
	private int beamIndex; // 0x84
	private int rendererIndex; // 0x88
	private int simpleFlareIndex; // 0x8C
	private int distanceFlareIndex; // 0x90
	private readonly int EmissionPropertyID; // 0x94
	private readonly int ColorFlatPropertyID; // 0x98
	private readonly int LightsPerFrame; // 0x9C
	private readonly int LightLODsPerFrame; // 0xA0
	private readonly int BeamsPerFrame; // 0xA4
	private readonly int RenderersPerFrame; // 0xA8
	private readonly int SimpleFlaresPerFrame; // 0xAC
	private readonly int DistanceFlaresPerFrame; // 0xB0
	public static LightGroupAtTime.LightGroupWorkQueue WorkQueue; // 0x0
	private IOEntity cachedPowerEnt; // 0xB8

	// Methods

	// RVA: 0x4EFDD0 Offset: 0x4EE3D0 VA: 0x1804EFDD0
	private void Clear() { }

	// RVA: 0x4EFD60 Offset: 0x4EE360 VA: 0x1804EFD60
	private void Awake() { }

	// RVA: 0x4F02E0 Offset: 0x4EE8E0 VA: 0x1804F02E0
	private void OnEnable() { }

	// RVA: 0x4F0260 Offset: 0x4EE860 VA: 0x1804F0260
	private void OnDisable() { }

	// RVA: 0x4EFE80 Offset: 0x4EE480 VA: 0x1804EFE80 Slot: 4
	public virtual float GetIntensity() { }

	// RVA: 0x4EFFA0 Offset: 0x4EE5A0 VA: 0x1804EFFA0 Slot: 5
	public virtual float GetPowerScale() { }

	// RVA: 0x4F07C0 Offset: 0x4EEDC0 VA: 0x1804F07C0
	private void UpdateLights() { }

	// RVA: 0x4F10B0 Offset: 0x4EF6B0 VA: 0x1804F10B0
	public void .ctor() { }

	// RVA: 0x4F1030 Offset: 0x4EF630 VA: 0x1804F1030
	private static void .cctor() { }

}

public class LightGroupAtTime.LightGroupWorkQueue : PersistentObjectWorkQueue<LightGroupAtTime> // TypeDefIndex: 9198
{	// Methods

	// RVA: 0x4F14C0 Offset: 0x4EFAC0 VA: 0x1804F14C0 Slot: 5
	protected override void RunJob(LightGroupAtTime entity) { }

	// RVA: 0x4F14E0 Offset: 0x4EFAE0 VA: 0x1804F14E0
	public void .ctor() { }

}

