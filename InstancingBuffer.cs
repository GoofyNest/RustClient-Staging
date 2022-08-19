public class InstancingBuffer // TypeDefIndex: 11362
{	// Fields
	private BufferList<Matrix4x4> matrices; // 0x10
	private Mesh mesh; // 0x18
	private Material material; // 0x20
	private int submeshIndex; // 0x28
	private int shaderPass; // 0x2C

	// Methods

	// RVA: 0x814260 Offset: 0x812860 VA: 0x180814260
	public void .ctor(InstancingKey key, int capacity) { }

	// RVA: 0x8141A0 Offset: 0x8127A0 VA: 0x1808141A0
	public void .ctor(Mesh mesh, Material material, int submeshIndex, int shaderPass, int capacity) { }

	// RVA: 0x813F70 Offset: 0x812570 VA: 0x180813F70
	public void Apply(CommandBuffer buf, bool instancing, MaterialPropertyBlock block) { }

	// RVA: 0x814150 Offset: 0x812750 VA: 0x180814150
	public void Clear() { }

	// RVA: 0x813EF0 Offset: 0x8124F0 VA: 0x180813EF0
	public void Add(Matrix4x4 matrix) { }

}

