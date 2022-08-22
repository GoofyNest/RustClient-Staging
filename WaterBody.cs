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
	// RVA: 0x6AD6C0 Offset: 0x6ABCC0 VA: 0x1806AD6C0
	private void set_Transform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public Transform get_Transform() { }

	// RVA: 0x803700 Offset: 0x801D00 VA: 0x180803700
	private void Awake() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5DD810 Offset: 0x5DBE10 VA: 0x1805DD810
	private void set_MeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public MeshFilter get_MeshFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890
	private void set_SharedMesh(Mesh value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public Mesh get_SharedMesh() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880
	private void set_Material(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public Material get_Material() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574440 Offset: 0x572A40 VA: 0x180574440
	private void set_DepthPass(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743B0 Offset: 0x5729B0 VA: 0x1805743B0
	public int get_DepthPass() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574420 Offset: 0x572A20 VA: 0x180574420
	private void set_DepthDisplacementPass(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574390 Offset: 0x572990 VA: 0x180574390
	public int get_DepthDisplacementPass() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x803BC0 Offset: 0x8021C0 VA: 0x180803BC0
	private void set_OcclusionPass(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x803B90 Offset: 0x802190 VA: 0x180803B90
	public int get_OcclusionPass() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x803BA0 Offset: 0x8021A0 VA: 0x180803BA0
	private void set_CausticsPass(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x803B70 Offset: 0x802170 VA: 0x180803B70
	public int get_CausticsPass() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x803BB0 Offset: 0x8021B0 VA: 0x180803BB0
	private void set_OcclusionCausticsPass(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x803B80 Offset: 0x802180 VA: 0x180803B80
	public int get_OcclusionCausticsPass() { }

	// RVA: 0x803790 Offset: 0x801D90 VA: 0x180803790
	private void OnEnable() { }

	// RVA: 0x803730 Offset: 0x801D30 VA: 0x180803730
	private void OnDisable() { }

	// RVA: 0x803A50 Offset: 0x802050 VA: 0x180803A50
	public void OnOceanLevelChanged(float newLevel) { }

	// RVA: 0x803B60 Offset: 0x802160 VA: 0x180803B60
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

