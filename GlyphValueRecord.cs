internal struct GlyphValueRecord // TypeDefIndex: 4113
{	// Fields
	[NativeNameAttribute] // RVA: 0x884E0 Offset: 0x878E0 VA: 0x1800884E0
	[SerializeField] // RVA: 0x884E0 Offset: 0x878E0 VA: 0x1800884E0
	private float m_XPlacement; // 0x0
	[NativeNameAttribute] // RVA: 0x887C0 Offset: 0x87BC0 VA: 0x1800887C0
	[SerializeField] // RVA: 0x887C0 Offset: 0x87BC0 VA: 0x1800887C0
	private float m_YPlacement; // 0x4
	[NativeNameAttribute] // RVA: 0x888C0 Offset: 0x87CC0 VA: 0x1800888C0
	[SerializeField] // RVA: 0x888C0 Offset: 0x87CC0 VA: 0x1800888C0
	private float m_XAdvance; // 0x8
	[NativeNameAttribute] // RVA: 0x88B30 Offset: 0x87F30 VA: 0x180088B30
	[SerializeField] // RVA: 0x88B30 Offset: 0x87F30 VA: 0x180088B30
	private float m_YAdvance; // 0xC

	// Properties
	public float xPlacement { get; }
	public float yPlacement { get; }
	public float xAdvance { get; }
	public float yAdvance { get; }

	// Methods

	// RVA: 0x13A390 Offset: 0x139790 VA: 0x18013A390
	public float get_xPlacement() { }

	// RVA: 0x2123B0 Offset: 0x2117B0 VA: 0x1802123B0
	public float get_yPlacement() { }

	// RVA: 0x2123C0 Offset: 0x2117C0 VA: 0x1802123C0
	public float get_xAdvance() { }

	// RVA: 0x2123D0 Offset: 0x2117D0 VA: 0x1802123D0
	public float get_yAdvance() { }

	// RVA: 0x23DF80 Offset: 0x23D380 VA: 0x18023DF80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x23DF10 Offset: 0x23D310 VA: 0x18023DF10 Slot: 0
	public override bool Equals(object obj) { }

}

public struct GlyphValueRecord_Legacy // TypeDefIndex: 6767
{	// Fields
	public float xPlacement; // 0x0
	public float yPlacement; // 0x4
	public float xAdvance; // 0x8
	public float yAdvance; // 0xC

	// Methods

	// RVA: 0x117550 Offset: 0x116950 VA: 0x180117550
	internal void .ctor(GlyphValueRecord valueRecord) { }

	// RVA: 0xC65810 Offset: 0xC63E10 VA: 0x180C65810
	public static GlyphValueRecord_Legacy op_Addition(GlyphValueRecord_Legacy a, GlyphValueRecord_Legacy b) { }

}

