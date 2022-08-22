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
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	private void set_Mesh(Mesh value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public Mesh get_Mesh() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
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
	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	private void set_ArgsBuffer(ComputeBuffer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public ComputeBuffer get_ArgsBuffer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8054F0 Offset: 0x803AF0 VA: 0x1808054F0
	public bool get_IsDirty() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x80FEF0 Offset: 0x80E4F0 VA: 0x18080FEF0
	public void set_IsDirty(bool value) { }

	// RVA: 0x80FE60 Offset: 0x80E460 VA: 0x18080FE60
	public int get_Count() { }

	// RVA: 0x80FEA0 Offset: 0x80E4A0 VA: 0x18080FEA0
	public bool get_Visible() { }

	// RVA: 0x7EE710 Offset: 0x7ECD10 VA: 0x1807EE710
	private ComputeBuffer SafeRelease(ComputeBuffer buffer) { }

	// RVA: 0x80F860 Offset: 0x80DE60 VA: 0x18080F860
	public void Initialize(Mesh mesh, Material material) { }

	// RVA: 0x80FA70 Offset: 0x80E070 VA: 0x18080FA70
	public void Release() { }

	// RVA: 0x80F740 Offset: 0x80DD40 VA: 0x18080F740
	public void AddInstance(ImpostorInstanceData data) { }

	// RVA: 0x80FB50 Offset: 0x80E150 VA: 0x18080FB50
	public void RemoveInstance(ImpostorInstanceData data) { }

	// RVA: 0x80FC40 Offset: 0x80E240 VA: 0x18080FC40
	public void UpdateBuffers() { }

	// RVA: 0x80FDF0 Offset: 0x80E3F0 VA: 0x18080FDF0
	public void .ctor() { }

}

