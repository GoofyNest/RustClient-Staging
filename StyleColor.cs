public struct StyleColor : IStyleValue<Color>, IEquatable<StyleColor> // TypeDefIndex: 4710
{	// Fields
	private StyleKeyword m_Keyword; // 0x0
	private Color m_Value; // 0x4
	private int m_Specificity; // 0x14

	// Properties
	public Color value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x13A630 Offset: 0x139A30 VA: 0x18013A630 Slot: 4
	public Color get_value() { }

	// RVA: 0x13A620 Offset: 0x139A20 VA: 0x18013A620 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x13A5F0 Offset: 0x1399F0 VA: 0x18013A5F0
	public void .ctor(Color v) { }

	// RVA: 0x13A600 Offset: 0x139A00 VA: 0x18013A600
	internal void .ctor(Color v, StyleKeyword keyword) { }

	// RVA: 0xEB9A60 Offset: 0xEB8060 VA: 0x180EB9A60
	public static bool op_Equality(StyleColor lhs, StyleColor rhs) { }

	// RVA: 0xEB9AE0 Offset: 0xEB80E0 VA: 0x180EB9AE0
	public static StyleColor op_Implicit(Color v) { }

	// RVA: 0x13A4A0 Offset: 0x1398A0 VA: 0x18013A4A0 Slot: 6
	public bool Equals(StyleColor other) { }

	// RVA: 0x13A3A0 Offset: 0x1397A0 VA: 0x18013A3A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13A530 Offset: 0x139930 VA: 0x18013A530 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13A590 Offset: 0x139990 VA: 0x18013A590 Slot: 3
	public override string ToString() { }

}

