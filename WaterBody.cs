public class WaterBody : MonoBehaviour // TypeDefIndex: 10597
{	// Fields
	public WaterBodyType Type; // 0x18
	public Renderer Renderer; // 0x20
	public Collider[] Triggers; // 0x28
	public bool IsOcean; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform <Transform>k__BackingField; // 0x38
	public WaterBody.FishingTag FishingType; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MeshFilter <MeshFilter>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Mesh <SharedMesh>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Material <Material>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <DepthPass>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <DepthDisplacementPass>k__BackingField; // 0x64
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <OcclusionPass>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <CausticsPass>k__BackingField; // 0x6C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6AD650 Offset: 0x6ABC50 VA: 0x1806AD650
	private void set_Transform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public Transform get_Transform() { }

	// RVA: 0x803C90 Offset: 0x802290 VA: 0x180803C90
	private void Awake() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5DD7A0 Offset: 0x5DBDA0 VA: 0x1805DD7A0
	private void set_MeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	public MeshFilter get_MeshFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF820 Offset: 0x4CDE20 VA: 0x1804CF820
	private void set_SharedMesh(Mesh value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public Mesh get_SharedMesh() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF810 Offset: 0x4CDE10 VA: 0x1804CF810
	private void set_Material(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	public Material get_Material() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	private void set_DepthPass(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574340 Offset: 0x572940 VA: 0x180574340
	public int get_DepthPass() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743B0 Offset: 0x5729B0 VA: 0x1805743B0
	private void set_DepthDisplacementPass(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574320 Offset: 0x572920 VA: 0x180574320
	public int get_DepthDisplacementPass() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x804150 Offset: 0x802750 VA: 0x180804150
	private void set_OcclusionPass(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x804120 Offset: 0x802720 VA: 0x180804120
	public int get_OcclusionPass() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x804130 Offset: 0x802730 VA: 0x180804130
	private void set_CausticsPass(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x804100 Offset: 0x802700 VA: 0x180804100
	public int get_CausticsPass() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x804140 Offset: 0x802740 VA: 0x180804140
	private void set_OcclusionCausticsPass(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x804110 Offset: 0x802710 VA: 0x180804110
	public int get_OcclusionCausticsPass() { }

	// RVA: 0x803D20 Offset: 0x802320 VA: 0x180803D20
	private void OnEnable() { }

	// RVA: 0x803CC0 Offset: 0x8022C0 VA: 0x180803CC0
	private void OnDisable() { }

	// RVA: 0x803FE0 Offset: 0x8025E0 VA: 0x180803FE0
	public void OnOceanLevelChanged(float newLevel) { }

	// RVA: 0x8040F0 Offset: 0x8026F0 VA: 0x1808040F0
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

