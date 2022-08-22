public class InstancingBuffer // TypeDefIndex: 11362
{	// Fields
	private BufferList<Matrix4x4> matrices; // 0x10
	private Mesh mesh; // 0x18
	private Material material; // 0x20
	private int submeshIndex; // 0x28
	private int shaderPass; // 0x2C

	// Methods

	// RVA: 0x814900 Offset: 0x812F00 VA: 0x180814900
	public void .ctor(InstancingKey key, int capacity) { }

	// RVA: 0x814840 Offset: 0x812E40 VA: 0x180814840
	public void .ctor(Mesh mesh, Material material, int submeshIndex, int shaderPass, int capacity) { }

	// RVA: 0x814610 Offset: 0x812C10 VA: 0x180814610
	public void Apply(CommandBuffer buf, bool instancing, MaterialPropertyBlock block) { }

	// RVA: 0x8147F0 Offset: 0x812DF0 VA: 0x1808147F0
	public void Clear() { }

	// RVA: 0x814590 Offset: 0x812B90 VA: 0x180814590
	public void Add(Matrix4x4 matrix) { }

}

