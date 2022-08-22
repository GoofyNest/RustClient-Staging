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
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	private void set_Renderer(Renderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public Renderer get_Renderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
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

	// RVA: 0x8104C0 Offset: 0x80EAC0 VA: 0x1808104C0
	public void .ctor(Renderer renderer, Mesh mesh, Material material) { }

	// RVA: 0x810370 Offset: 0x80E970 VA: 0x180810370
	public void .ctor(Vector3 position, Vector3 scale, Mesh mesh, Material material) { }

	// RVA: 0x810130 Offset: 0x80E730 VA: 0x180810130
	private int GenerateHashCode() { }

	// RVA: 0x810010 Offset: 0x80E610 VA: 0x180810010 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x5E2F40 Offset: 0x5E1540 VA: 0x1805E2F40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x810190 Offset: 0x80E790 VA: 0x180810190
	public Vector4 PositionAndScale() { }

	// RVA: 0x8102D0 Offset: 0x80E8D0 VA: 0x1808102D0
	public void Update() { }

}

