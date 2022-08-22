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
	// RVA: 0x805600 Offset: 0x803C00 VA: 0x180805600
	public bool get_IsDirty() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x810000 Offset: 0x80E600 VA: 0x180810000
	public void set_IsDirty(bool value) { }

	// RVA: 0x80FF70 Offset: 0x80E570 VA: 0x18080FF70
	public int get_Count() { }

	// RVA: 0x80FFB0 Offset: 0x80E5B0 VA: 0x18080FFB0
	public bool get_Visible() { }

	// RVA: 0x7EE820 Offset: 0x7ECE20 VA: 0x1807EE820
	private ComputeBuffer SafeRelease(ComputeBuffer buffer) { }

	// RVA: 0x80F970 Offset: 0x80DF70 VA: 0x18080F970
	public void Initialize(Mesh mesh, Material material) { }

	// RVA: 0x80FB80 Offset: 0x80E180 VA: 0x18080FB80
	public void Release() { }

	// RVA: 0x80F850 Offset: 0x80DE50 VA: 0x18080F850
	public void AddInstance(ImpostorInstanceData data) { }

	// RVA: 0x80FC60 Offset: 0x80E260 VA: 0x18080FC60
	public void RemoveInstance(ImpostorInstanceData data) { }

	// RVA: 0x80FD50 Offset: 0x80E350 VA: 0x18080FD50
	public void UpdateBuffers() { }

	// RVA: 0x80FF00 Offset: 0x80E500 VA: 0x18080FF00
	public void .ctor() { }

}

