public struct RendererKey : IEquatable<RendererKey> // TypeDefIndex: 9922
{	// Fields
	public Material material; // 0x0
	public ShadowCastingMode shadows; // 0x8
	public int layer; // 0xC

	// Methods

	// RVA: 0xF91A0 Offset: 0xF85A0 VA: 0x1800F91A0
	public void .ctor(Material material, ShadowCastingMode shadows, int layer) { }

	// RVA: 0xFA5F0 Offset: 0xF99F0 VA: 0x1800FA5F0
	public void .ctor(MeshRenderer renderer) { }

	// RVA: 0xFA660 Offset: 0xF9A60 VA: 0x1800FA660
	public void .ctor(RendererBatch batch) { }

	// RVA: 0xFA580 Offset: 0xF9980 VA: 0x1800FA580 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xFA4C0 Offset: 0xF98C0 VA: 0x1800FA4C0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xFA560 Offset: 0xF9960 VA: 0x1800FA560 Slot: 4
	public bool Equals(RendererKey other) { }

}

