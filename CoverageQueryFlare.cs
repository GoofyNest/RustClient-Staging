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

	// RVA: 0x6C0AE0 Offset: 0x6BF0E0 VA: 0x1806C0AE0
	public float get_CurrentDistance() { }

	// RVA: 0x6BF930 Offset: 0x6BDF30 VA: 0x1806BF930
	private float GetDistance() { }

	// RVA: 0x6BF640 Offset: 0x6BDC40 VA: 0x1806BF640
	private void Awake() { }

	// RVA: 0x6BFD00 Offset: 0x6BE300 VA: 0x1806BFD00
	private void OnEnable() { }

	// RVA: 0x6BF790 Offset: 0x6BDD90 VA: 0x1806BF790 Slot: 7
	public void ChangeLOD() { }

	// RVA: 0x6BFEE0 Offset: 0x6BE4E0 VA: 0x1806BFEE0 Slot: 8
	public void RefreshLOD() { }

	// RVA: 0x6BFA00 Offset: 0x6BE000 VA: 0x1806BFA00
	private int GetLOD(float distance) { }

	// RVA: 0x6C0380 Offset: 0x6BE980 VA: 0x1806C0380
	private void SetLOD(int newlod) { }

	// RVA: 0x6C04D0 Offset: 0x6BEAD0 VA: 0x1806C04D0
	private void Show() { }

	// RVA: 0x6BFB50 Offset: 0x6BE150 VA: 0x1806BFB50
	private void Hide() { }

	// RVA: 0x6C0400 Offset: 0x6BEA00 VA: 0x1806C0400
	private void ShowRenderers() { }

	// RVA: 0x6BFA80 Offset: 0x6BE080 VA: 0x1806BFA80
	private void HideRenderers() { }

	// RVA: 0x6BFEB0 Offset: 0x6BE4B0 VA: 0x1806BFEB0 Slot: 6
	public void OnParentDestroying() { }

	// RVA: 0x6C05B0 Offset: 0x6BEBB0 VA: 0x1806C05B0
	public void Tick() { }

	// RVA: 0x6C0760 Offset: 0x6BED60 VA: 0x1806C0760
	private void UpdateMaterialProperties() { }

	// RVA: 0x6BFFE0 Offset: 0x6BE5E0 VA: 0x1806BFFE0
	public float SampleVisibility() { }

	// RVA: 0x5C35A0 Offset: 0x5C1BA0 VA: 0x1805C35A0
	public void SetFlareIntensity(float intensity) { }

	// RVA: 0x6BFF70 Offset: 0x6BE570 VA: 0x1806BFF70
	private void RegisterCoverageQuery() { }

	// RVA: 0x6C0640 Offset: 0x6BEC40 VA: 0x1806C0640
	private void UnRegisterCoverageQuery() { }

	// RVA: 0x6BFBD0 Offset: 0x6BE1D0 VA: 0x1806BFBD0
	private void OnDisable() { }

	// RVA: 0x6C0A40 Offset: 0x6BF040 VA: 0x1806C0A40
	public void .ctor() { }

}

