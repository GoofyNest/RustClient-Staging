public class WaterBody : MonoBehaviour // TypeDefIndex: 10597
{	// Fields
	public WaterBodyType Type; // 0x18
	public Renderer Renderer; // 0x20
	public Collider[] Triggers; // 0x28
	public bool IsOcean; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform <Transform>k__BackingField; // 0x38
	public WaterBody.FishingTag FishingType; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private MeshFilter <MeshFilter>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Mesh <SharedMesh>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Material <Material>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int <DepthPass>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int <DepthDisplacementPass>k__BackingField; // 0x64
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int <OcclusionPass>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int <CausticsPass>k__BackingField; // 0x6C
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int <OcclusionCausticsPass>k__BackingField; // 0x70

	// Properties
	public Transform Transform { get; set; }
	public MeshFilter MeshFilter { get; set; }
	public Mesh SharedMesh { get; set; }
	public Material Material { get; set; }
	public int DepthPass { get; set; }
	public int DepthDisplacementPass { get; set; }
	public int OcclusionPass { get; set; }
	public int CausticsPass { get; set; }
	public int OcclusionCausticsPass { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x6AD5B0 Offset: 0x6ABBB0 VA: 0x1806AD5B0
	private void set_Transform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public Transform get_Transform() { }

	// RVA: 0x8035F0 Offset: 0x801BF0 VA: 0x1808035F0
	private void Awake() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x5DD810 Offset: 0x5DBE10 VA: 0x1805DD810
	private void set_MeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public MeshFilter get_MeshFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890
	private void set_SharedMesh(Mesh value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public Mesh get_SharedMesh() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880
	private void set_Material(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public Material get_Material() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x574440 Offset: 0x572A40 VA: 0x180574440
	private void set_DepthPass(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x5743B0 Offset: 0x5729B0 VA: 0x1805743B0
	public int get_DepthPass() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x574420 Offset: 0x572A20 VA: 0x180574420
	private void set_DepthDisplacementPass(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x574390 Offset: 0x572990 VA: 0x180574390
	public int get_DepthDisplacementPass() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x803AB0 Offset: 0x8020B0 VA: 0x180803AB0
	private void set_OcclusionPass(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x803A80 Offset: 0x802080 VA: 0x180803A80
	public int get_OcclusionPass() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x803A90 Offset: 0x802090 VA: 0x180803A90
	private void set_CausticsPass(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x803A60 Offset: 0x802060 VA: 0x180803A60
	public int get_CausticsPass() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x803AA0 Offset: 0x8020A0 VA: 0x180803AA0
	private void set_OcclusionCausticsPass(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x803A70 Offset: 0x802070 VA: 0x180803A70
	public int get_OcclusionCausticsPass() { }

	// RVA: 0x803680 Offset: 0x801C80 VA: 0x180803680
	private void OnEnable() { }

	// RVA: 0x803620 Offset: 0x801C20 VA: 0x180803620
	private void OnDisable() { }

	// RVA: 0x803940 Offset: 0x801F40 VA: 0x180803940
	public void OnOceanLevelChanged(float newLevel) { }

	// RVA: 0x803A50 Offset: 0x802050 VA: 0x180803A50
	public void .ctor() { }

}

public enum WaterBody.FishingTag // TypeDefIndex: 10598
{	// Fields
	public int value__; // 0x0
	public const WaterBody.FishingTag MoonPool = 1;
	public const WaterBody.FishingTag River = 2;
	public const WaterBody.FishingTag Ocean = 4;
	public const WaterBody.FishingTag Swamp = 8;

}

