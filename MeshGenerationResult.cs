public struct MeshGenerationResult : IEquatable<MeshGenerationResult> // TypeDefIndex: 4159
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private readonly MeshId <MeshId>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private readonly Mesh <Mesh>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private readonly MeshCollider <MeshCollider>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private readonly MeshGenerationStatus <Status>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private readonly MeshVertexAttributes <Attributes>k__BackingField; // 0x24

	// Properties
	public MeshId MeshId { get; }
	public Mesh Mesh { get; }
	public MeshCollider MeshCollider { get; }
	public MeshGenerationStatus Status { get; }
	public MeshVertexAttributes Attributes { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B770 Offset: 0x14AB70 VA: 0x18014B770
	public MeshId get_MeshId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3EE0 Offset: 0xF32E0 VA: 0x1800F3EE0
	public Mesh get_Mesh() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3EF0 Offset: 0xF32F0 VA: 0x1800F3EF0
	public MeshCollider get_MeshCollider() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12C1C0 Offset: 0x12B5C0 VA: 0x18012C1C0
	public MeshGenerationStatus get_Status() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1E4C20 Offset: 0x1E4020 VA: 0x1801E4C20
	public MeshVertexAttributes get_Attributes() { }

	// RVA: 0x23E840 Offset: 0x23DC40 VA: 0x18023E840 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x23E8F0 Offset: 0x23DCF0 VA: 0x18023E8F0 Slot: 4
	public bool Equals(MeshGenerationResult other) { }

	// RVA: 0x23E930 Offset: 0x23DD30 VA: 0x18023E930 Slot: 2
	public override int GetHashCode() { }

}

