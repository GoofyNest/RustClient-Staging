public class ImpostorInstanceData // TypeDefIndex: 10680
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Renderer <Renderer>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Mesh <Mesh>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Material <Material>k__BackingField; // 0x20
	public ImpostorBatch Batch; // 0x28
	public int BatchIndex; // 0x30
	private int hash; // 0x34
	private Vector4 positionAndScale; // 0x38

	// Properties
	public Renderer Renderer { get; set; }
	public Mesh Mesh { get; set; }
	public Material Material { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	private void set_Renderer(Renderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public Renderer get_Renderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	private void set_Mesh(Mesh value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Mesh get_Mesh() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	private void set_Material(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public Material get_Material() { }

	// RVA: 0x810A50 Offset: 0x80F050 VA: 0x180810A50
	public void .ctor(Renderer renderer, Mesh mesh, Material material) { }

	// RVA: 0x810900 Offset: 0x80EF00 VA: 0x180810900
	public void .ctor(Vector3 position, Vector3 scale, Mesh mesh, Material material) { }

	// RVA: 0x8106C0 Offset: 0x80ECC0 VA: 0x1808106C0
	private int GenerateHashCode() { }

	// RVA: 0x8105A0 Offset: 0x80EBA0 VA: 0x1808105A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x5E2ED0 Offset: 0x5E14D0 VA: 0x1805E2ED0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x810720 Offset: 0x80ED20 VA: 0x180810720
	public Vector4 PositionAndScale() { }

	// RVA: 0x810860 Offset: 0x80EE60 VA: 0x180810860
	public void Update() { }

}

