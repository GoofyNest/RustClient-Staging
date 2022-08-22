public class InstancingContainer // TypeDefIndex: 11361
{	// Fields
	private int capacity; // 0x10
	private ListDictionary<InstancingKey, InstancingBuffer> buffers; // 0x18

	// Methods

	// RVA: 0x814BD0 Offset: 0x8131D0 VA: 0x180814BD0
	public void .ctor(int capacity = 128) { }

	// RVA: 0x8149D0 Offset: 0x812FD0 VA: 0x1808149D0
	public void Free() { }

	// RVA: 0x814900 Offset: 0x812F00 VA: 0x180814900
	public void Clear() { }

	// RVA: 0x814A20 Offset: 0x813020 VA: 0x180814A20
	public InstancingBuffer Get(Mesh mesh, Material material, int submeshIndex = 0, int shaderPass = -1) { }

	// RVA: 0x814430 Offset: 0x812A30 VA: 0x180814430
	public void Add(Mesh mesh, Material material, Matrix4x4 matrix, int submeshIndex = 0, int shaderPass = -1) { }

	// RVA: 0x814650 Offset: 0x812C50 VA: 0x180814650
	public void Apply(CommandBuffer buf, bool instancing, MaterialPropertyBlock block) { }

}

