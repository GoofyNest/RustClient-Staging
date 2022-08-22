public class InstancingContainer // TypeDefIndex: 11361
{	// Fields
	private int capacity; // 0x10
	private ListDictionary<InstancingKey, InstancingBuffer> buffers; // 0x18

	// Methods

	// RVA: 0x815160 Offset: 0x813760 VA: 0x180815160
	public void .ctor(int capacity = 128) { }

	// RVA: 0x814F60 Offset: 0x813560 VA: 0x180814F60
	public void Free() { }

	// RVA: 0x814E90 Offset: 0x813490 VA: 0x180814E90
	public void Clear() { }

	// RVA: 0x814FB0 Offset: 0x8135B0 VA: 0x180814FB0
	public InstancingBuffer Get(Mesh mesh, Material material, int submeshIndex = 0, int shaderPass = -1) { }

	// RVA: 0x8149C0 Offset: 0x812FC0 VA: 0x1808149C0
	public void Add(Mesh mesh, Material material, Matrix4x4 matrix, int submeshIndex = 0, int shaderPass = -1) { }

	// RVA: 0x814BE0 Offset: 0x8131E0 VA: 0x180814BE0
	public void Apply(CommandBuffer buf, bool instancing, MaterialPropertyBlock block) { }

}

