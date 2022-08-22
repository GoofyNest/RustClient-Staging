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

	// RVA: 0x6C0B50 Offset: 0x6BF150 VA: 0x1806C0B50
	public float get_CurrentDistance() { }

	// RVA: 0x6BF9A0 Offset: 0x6BDFA0 VA: 0x1806BF9A0
	private float GetDistance() { }

	// RVA: 0x6BF6B0 Offset: 0x6BDCB0 VA: 0x1806BF6B0
	private void Awake() { }

	// RVA: 0x6BFD70 Offset: 0x6BE370 VA: 0x1806BFD70
	private void OnEnable() { }

	// RVA: 0x6BF800 Offset: 0x6BDE00 VA: 0x1806BF800 Slot: 7
	public void ChangeLOD() { }

	// RVA: 0x6BFF50 Offset: 0x6BE550 VA: 0x1806BFF50 Slot: 8
	public void RefreshLOD() { }

	// RVA: 0x6BFA70 Offset: 0x6BE070 VA: 0x1806BFA70
	private int GetLOD(float distance) { }

	// RVA: 0x6C03F0 Offset: 0x6BE9F0 VA: 0x1806C03F0
	private void SetLOD(int newlod) { }

	// RVA: 0x6C0540 Offset: 0x6BEB40 VA: 0x1806C0540
	private void Show() { }

	// RVA: 0x6BFBC0 Offset: 0x6BE1C0 VA: 0x1806BFBC0
	private void Hide() { }

	// RVA: 0x6C0470 Offset: 0x6BEA70 VA: 0x1806C0470
	private void ShowRenderers() { }

	// RVA: 0x6BFAF0 Offset: 0x6BE0F0 VA: 0x1806BFAF0
	private void HideRenderers() { }

	// RVA: 0x6BFF20 Offset: 0x6BE520 VA: 0x1806BFF20 Slot: 6
	public void OnParentDestroying() { }

	// RVA: 0x6C0620 Offset: 0x6BEC20 VA: 0x1806C0620
	public void Tick() { }

	// RVA: 0x6C07D0 Offset: 0x6BEDD0 VA: 0x1806C07D0
	private void UpdateMaterialProperties() { }

	// RVA: 0x6C0050 Offset: 0x6BE650 VA: 0x1806C0050
	public float SampleVisibility() { }

	// RVA: 0x5C3610 Offset: 0x5C1C10 VA: 0x1805C3610
	public void SetFlareIntensity(float intensity) { }

	// RVA: 0x6BFFE0 Offset: 0x6BE5E0 VA: 0x1806BFFE0
	private void RegisterCoverageQuery() { }

	// RVA: 0x6C06B0 Offset: 0x6BECB0 VA: 0x1806C06B0
	private void UnRegisterCoverageQuery() { }

	// RVA: 0x6BFC40 Offset: 0x6BE240 VA: 0x1806BFC40
	private void OnDisable() { }

	// RVA: 0x6C0AB0 Offset: 0x6BF0B0 VA: 0x1806C0AB0
	public void .ctor() { }

}

