public class ImpostorBatch // TypeDefIndex: 10681
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Mesh <Mesh>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Material <Material>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ComputeBuffer <PositionBuffer>k__BackingField; // 0x20
	public NativeList<Vector4> Positions; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ComputeBuffer <ArgsBuffer>k__BackingField; // 0x30
	private NativeList<uint> args; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <IsDirty>k__BackingField; // 0x40
	private Queue<int> recycle; // 0x48

	// Properties
	public Mesh Mesh { get; set; }
	public Material Material { get; set; }
	public ComputeBuffer PositionBuffer { get; set; }
	public ComputeBuffer ArgsBuffer { get; set; }
	public bool IsDirty { get; set; }
	public int Count { get; }
	public bool Visible { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	private void set_Mesh(Mesh value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public Mesh get_Mesh() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	private void set_Material(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Material get_Material() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	private void set_PositionBuffer(ComputeBuffer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public ComputeBuffer get_PositionBuffer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	private void set_ArgsBuffer(ComputeBuffer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public ComputeBuffer get_ArgsBuffer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x805B90 Offset: 0x804190 VA: 0x180805B90
	public bool get_IsDirty() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x810590 Offset: 0x80EB90 VA: 0x180810590
	public void set_IsDirty(bool value) { }

	// RVA: 0x810500 Offset: 0x80EB00 VA: 0x180810500
	public int get_Count() { }

	// RVA: 0x810540 Offset: 0x80EB40 VA: 0x180810540
	public bool get_Visible() { }

	// RVA: 0x7EEDB0 Offset: 0x7ED3B0 VA: 0x1807EEDB0
	private ComputeBuffer SafeRelease(ComputeBuffer buffer) { }

	// RVA: 0x80FF00 Offset: 0x80E500 VA: 0x18080FF00
	public void Initialize(Mesh mesh, Material material) { }

	// RVA: 0x810110 Offset: 0x80E710 VA: 0x180810110
	public void Release() { }

	// RVA: 0x80FDE0 Offset: 0x80E3E0 VA: 0x18080FDE0
	public void AddInstance(ImpostorInstanceData data) { }

	// RVA: 0x8101F0 Offset: 0x80E7F0 VA: 0x1808101F0
	public void RemoveInstance(ImpostorInstanceData data) { }

	// RVA: 0x8102E0 Offset: 0x80E8E0 VA: 0x1808102E0
	public void UpdateBuffers() { }

	// RVA: 0x810490 Offset: 0x80EA90 VA: 0x180810490
	public void .ctor() { }

}

