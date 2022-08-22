internal struct GlyphValueRecord // TypeDefIndex: 4113
{	// Fields
	[NativeNameAttribute] // RVA: 0x88550 Offset: 0x87950 VA: 0x180088550
	[SerializeField] // RVA: 0x88550 Offset: 0x87950 VA: 0x180088550
	private float m_XPlacement; // 0x0
	[NativeNameAttribute] // RVA: 0x88830 Offset: 0x87C30 VA: 0x180088830
	[SerializeField] // RVA: 0x88830 Offset: 0x87C30 VA: 0x180088830
	private float m_YPlacement; // 0x4
	[NativeNameAttribute] // RVA: 0x88930 Offset: 0x87D30 VA: 0x180088930
	[SerializeField] // RVA: 0x88930 Offset: 0x87D30 VA: 0x180088930
	private float m_XAdvance; // 0x8
	[NativeNameAttribute] // RVA: 0x88BA0 Offset: 0x87FA0 VA: 0x180088BA0
	[SerializeField] // RVA: 0x88BA0 Offset: 0x87FA0 VA: 0x180088BA0
	private float m_YAdvance; // 0xC

	// Properties
	public float xPlacement { get; }
	public float yPlacement { get; }
	public float xAdvance { get; }
	public float yAdvance { get; }

	// Methods

	// RVA: 0x13A130 Offset: 0x139530 VA: 0x18013A130
	public float get_xPlacement() { }

	// RVA: 0x211760 Offset: 0x210B60 VA: 0x180211760
	public float get_yPlacement() { }

	// RVA: 0x211770 Offset: 0x210B70 VA: 0x180211770
	public float get_xAdvance() { }

	// RVA: 0x211780 Offset: 0x210B80 VA: 0x180211780
	public float get_yAdvance() { }

	// RVA: 0x23DF00 Offset: 0x23D300 VA: 0x18023DF00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x23DE90 Offset: 0x23D290 VA: 0x18023DE90 Slot: 0
	public override bool Equals(object obj) { }

}

public struct GlyphValueRecord_Legacy // TypeDefIndex: 6767
{	// Fields
	public float xPlacement; // 0x0
	public float yPlacement; // 0x4
	public float xAdvance; // 0x8
	public float yAdvance; // 0xC

	// Methods

	// RVA: 0x1174D0 Offset: 0x1168D0 VA: 0x1801174D0
	internal void .ctor(GlyphValueRecord valueRecord) { }

	// RVA: 0xC65FA0 Offset: 0xC645A0 VA: 0x180C65FA0
	public static GlyphValueRecord_Legacy op_Addition(GlyphValueRecord_Legacy a, GlyphValueRecord_Legacy b) { }

}

