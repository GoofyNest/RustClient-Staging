public class InstancingBuffer // TypeDefIndex: 11362
{	// Fields
	private BufferList<Matrix4x4> matrices; // 0x10
	private Mesh mesh; // 0x18
	private Material material; // 0x20
	private int submeshIndex; // 0x28
	private int shaderPass; // 0x2C

	// Methods

	// RVA: 0x814370 Offset: 0x812970 VA: 0x180814370
	public void .ctor(InstancingKey key, int capacity) { }

	// RVA: 0x8142B0 Offset: 0x8128B0 VA: 0x1808142B0
	public void .ctor(Mesh mesh, Material material, int submeshIndex, int shaderPass, int capacity) { }

	// RVA: 0x814080 Offset: 0x812680 VA: 0x180814080
	public void Apply(CommandBuffer buf, bool instancing, MaterialPropertyBlock block) { }

	// RVA: 0x814260 Offset: 0x812860 VA: 0x180814260
	public void Clear() { }

	// RVA: 0x814000 Offset: 0x812600 VA: 0x180814000
	public void Add(Matrix4x4 matrix) { }

}

