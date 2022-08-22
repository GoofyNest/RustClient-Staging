public struct RendererKey : IEquatable<RendererKey> // TypeDefIndex: 9922
{	// Fields
	public Material material; // 0x0
	public ShadowCastingMode shadows; // 0x8
	public int layer; // 0xC

	// Methods

	// RVA: 0xF9120 Offset: 0xF8520 VA: 0x1800F9120
	public void .ctor(Material material, ShadowCastingMode shadows, int layer) { }

	// RVA: 0xFA570 Offset: 0xF9970 VA: 0x1800FA570
	public void .ctor(MeshRenderer renderer) { }

	// RVA: 0xFA5E0 Offset: 0xF99E0 VA: 0x1800FA5E0
	public void .ctor(RendererBatch batch) { }

	// RVA: 0xFA500 Offset: 0xF9900 VA: 0x1800FA500 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xFA440 Offset: 0xF9840 VA: 0x1800FA440 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xFA4E0 Offset: 0xF98E0 VA: 0x1800FA4E0 Slot: 4
	public bool Equals(RendererKey other) { }

}

