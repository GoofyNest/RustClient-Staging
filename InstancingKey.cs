public struct InstancingKey : IEquatable<InstancingKey> // TypeDefIndex: 11363
{	// Fields
	public Mesh mesh; // 0x0
	public int submeshIndex; // 0x8
	public Material material; // 0x10
	public int shaderPass; // 0x18

	// Methods

	// RVA: 0xF8D80 Offset: 0xF8180 VA: 0x1800F8D80
	public void .ctor(Mesh mesh, int submeshIndex, Material material, int shaderPass) { }

	// RVA: 0xF8C80 Offset: 0xF8080 VA: 0x1800F8C80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xF8BB0 Offset: 0xF7FB0 VA: 0x1800F8BB0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xF8C50 Offset: 0xF8050 VA: 0x1800F8C50 Slot: 4
	public bool Equals(InstancingKey other) { }

}

