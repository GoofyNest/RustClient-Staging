public struct InstancingKey : IEquatable<InstancingKey> // TypeDefIndex: 11363
{	// Fields
	public Mesh mesh; // 0x0
	public int submeshIndex; // 0x8
	public Material material; // 0x10
	public int shaderPass; // 0x18

	// Methods

	// RVA: 0xF8D00 Offset: 0xF8100 VA: 0x1800F8D00
	public void .ctor(Mesh mesh, int submeshIndex, Material material, int shaderPass) { }

	// RVA: 0xF8C00 Offset: 0xF8000 VA: 0x1800F8C00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xF8B30 Offset: 0xF7F30 VA: 0x1800F8B30 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xF8BD0 Offset: 0xF7FD0 VA: 0x1800F8BD0 Slot: 4
	public bool Equals(InstancingKey other) { }

}

