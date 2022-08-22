public class LightGroupAtTime : FacepunchBehaviour // TypeDefIndex: 9197
{	// Fields
	public float IntensityOverride; // 0x18
	public AnimationCurve IntensityScaleOverTime; // 0x20
	public Transform SearchRoot; // 0x28
	[HeaderAttribute] // RVA: 0xD8FA0 Offset: 0xD83A0 VA: 0x1800D8FA0
	public bool requiresPower; // 0x30
	[TooltipAttribute] // RVA: 0xD9200 Offset: 0xD8600 VA: 0x1800D9200
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

	// RVA: 0x4EFD60 Offset: 0x4EE360 VA: 0x1804EFD60
	private void Clear() { }

	// RVA: 0x4EFCF0 Offset: 0x4EE2F0 VA: 0x1804EFCF0
	private void Awake() { }

	// RVA: 0x4F0270 Offset: 0x4EE870 VA: 0x1804F0270
	private void OnEnable() { }

	// RVA: 0x4F01F0 Offset: 0x4EE7F0 VA: 0x1804F01F0
	private void OnDisable() { }

	// RVA: 0x4EFE10 Offset: 0x4EE410 VA: 0x1804EFE10 Slot: 4
	public virtual float GetIntensity() { }

	// RVA: 0x4EFF30 Offset: 0x4EE530 VA: 0x1804EFF30 Slot: 5
	public virtual float GetPowerScale() { }

	// RVA: 0x4F0750 Offset: 0x4EED50 VA: 0x1804F0750
	private void UpdateLights() { }

	// RVA: 0x4F1040 Offset: 0x4EF640 VA: 0x1804F1040
	public void .ctor() { }

	// RVA: 0x4F0FC0 Offset: 0x4EF5C0 VA: 0x1804F0FC0
	private static void .cctor() { }

}

public class LightGroupAtTime.LightGroupWorkQueue : PersistentObjectWorkQueue<LightGroupAtTime> // TypeDefIndex: 9198
{	// Methods

	// RVA: 0x4F1450 Offset: 0x4EFA50 VA: 0x1804F1450 Slot: 5
	protected override void RunJob(LightGroupAtTime entity) { }

	// RVA: 0x4F1470 Offset: 0x4EFA70 VA: 0x1804F1470
	public void .ctor() { }

}

