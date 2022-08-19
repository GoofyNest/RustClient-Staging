public class InstancingContainer // TypeDefIndex: 11361
{	// Fields
	private int capacity; // 0x10
	private ListDictionary<InstancingKey, InstancingBuffer> buffers; // 0x18

	// Methods

	// RVA: 0x814AC0 Offset: 0x8130C0 VA: 0x180814AC0
	public void .ctor(int capacity = 128) { }

	// RVA: 0x8148C0 Offset: 0x812EC0 VA: 0x1808148C0
	public void Free() { }

	// RVA: 0x8147F0 Offset: 0x812DF0 VA: 0x1808147F0
	public void Clear() { }

	// RVA: 0x814910 Offset: 0x812F10 VA: 0x180814910
	public InstancingBuffer Get(Mesh mesh, Material material, int submeshIndex = 0, int shaderPass = -1) { }

	// RVA: 0x814320 Offset: 0x812920 VA: 0x180814320
	public void Add(Mesh mesh, Material material, Matrix4x4 matrix, int submeshIndex = 0, int shaderPass = -1) { }

	// RVA: 0x814540 Offset: 0x812B40 VA: 0x180814540
	public void Apply(CommandBuffer buf, bool instancing, MaterialPropertyBlock block) { }

}

