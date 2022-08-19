public class CoverageQueryFlare : BaseMonoBehaviour, IClientComponent, IOnParentDestroying, ILOD // TypeDefIndex: 8810
{	// Fields
	public bool isDynamic; // 0x18
	public bool timeShimmer; // 0x19
	public bool positionalShimmer; // 0x1A
	public bool rotate; // 0x1B
	public float maxVisibleDistance; // 0x1C
	public bool lightScaled; // 0x20
	public float dotMin; // 0x24
	public float dotMax; // 0x28
	public CoverageQueries.RadiusSpace coverageRadiusSpace; // 0x2C
	public float coverageRadius; // 0x30
	public LODDistanceMode DistanceMode; // 0x34
	private const float tickRate = 0,03030303;
	private static MaterialPropertyBlock block; // 0x0
	private bool isCulled; // 0x38
	private bool isOccluded; // 0x39
	private int curlod; // 0x3C
	private CoverageQueries.Query query; // 0x40
	private bool queryRegistered; // 0x48
	private float privateRand; // 0x4C
	private bool force; // 0x50
	private LODCell cell; // 0x58
	private float currentDistance; // 0x60
	private Renderer flareRenderer; // 0x68
	private Renderer orbRenderer; // 0x70
	private float startColorMultiplier; // 0x78
	private float flareIntensity; // 0x7C
	private float visibleFraction; // 0x80
	private bool destroying; // 0x84
	private readonly int VisibleFraction_DotMin_DotMax_Rotate; // 0x88
	private readonly int PShimmer_TShimmer_Seed_LightScale; // 0x8C
	private readonly int ColorMultID; // 0x90
	private LODEnvironmentMode EnvironmentMode; // 0x94

	// Properties
	public float CurrentDistance { get; }

	// Methods

	// RVA: 0x6C0A40 Offset: 0x6BF040 VA: 0x1806C0A40
	public float get_CurrentDistance() { }

	// RVA: 0x6BF890 Offset: 0x6BDE90 VA: 0x1806BF890
	private float GetDistance() { }

	// RVA: 0x6BF5A0 Offset: 0x6BDBA0 VA: 0x1806BF5A0
	private void Awake() { }

	// RVA: 0x6BFC60 Offset: 0x6BE260 VA: 0x1806BFC60
	private void OnEnable() { }

	// RVA: 0x6BF6F0 Offset: 0x6BDCF0 VA: 0x1806BF6F0 Slot: 7
	public void ChangeLOD() { }

	// RVA: 0x6BFE40 Offset: 0x6BE440 VA: 0x1806BFE40 Slot: 8
	public void RefreshLOD() { }

	// RVA: 0x6BF960 Offset: 0x6BDF60 VA: 0x1806BF960
	private int GetLOD(float distance) { }

	// RVA: 0x6C02E0 Offset: 0x6BE8E0 VA: 0x1806C02E0
	private void SetLOD(int newlod) { }

	// RVA: 0x6C0430 Offset: 0x6BEA30 VA: 0x1806C0430
	private void Show() { }

	// RVA: 0x6BFAB0 Offset: 0x6BE0B0 VA: 0x1806BFAB0
	private void Hide() { }

	// RVA: 0x6C0360 Offset: 0x6BE960 VA: 0x1806C0360
	private void ShowRenderers() { }

	// RVA: 0x6BF9E0 Offset: 0x6BDFE0 VA: 0x1806BF9E0
	private void HideRenderers() { }

	// RVA: 0x6BFE10 Offset: 0x6BE410 VA: 0x1806BFE10 Slot: 6
	public void OnParentDestroying() { }

	// RVA: 0x6C0510 Offset: 0x6BEB10 VA: 0x1806C0510
	public void Tick() { }

	// RVA: 0x6C06C0 Offset: 0x6BECC0 VA: 0x1806C06C0
	private void UpdateMaterialProperties() { }

	// RVA: 0x6BFF40 Offset: 0x6BE540 VA: 0x1806BFF40
	public float SampleVisibility() { }

	// RVA: 0x5C3610 Offset: 0x5C1C10 VA: 0x1805C3610
	public void SetFlareIntensity(float intensity) { }

	// RVA: 0x6BFED0 Offset: 0x6BE4D0 VA: 0x1806BFED0
	private void RegisterCoverageQuery() { }

	// RVA: 0x6C05A0 Offset: 0x6BEBA0 VA: 0x1806C05A0
	private void UnRegisterCoverageQuery() { }

	// RVA: 0x6BFB30 Offset: 0x6BE130 VA: 0x1806BFB30
	private void OnDisable() { }

	// RVA: 0x6C09A0 Offset: 0x6BEFA0 VA: 0x1806C09A0
	public void .ctor() { }

}

