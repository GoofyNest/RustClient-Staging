public struct StyleColor : IStyleValue<Color>, IEquatable<StyleColor> // TypeDefIndex: 4710
{	// Fields
	private StyleKeyword m_Keyword; // 0x0
	private Color m_Value; // 0x4
	private int m_Specificity; // 0x14

	// Properties
	public Color value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x13A5B0 Offset: 0x1399B0 VA: 0x18013A5B0 Slot: 4
	public Color get_value() { }

	// RVA: 0x13A5A0 Offset: 0x1399A0 VA: 0x18013A5A0 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x13A570 Offset: 0x139970 VA: 0x18013A570
	public void .ctor(Color v) { }

	// RVA: 0x13A580 Offset: 0x139980 VA: 0x18013A580
	internal void .ctor(Color v, StyleKeyword keyword) { }

	// RVA: 0xEB9A60 Offset: 0xEB8060 VA: 0x180EB9A60
	public static bool op_Equality(StyleColor lhs, StyleColor rhs) { }

	// RVA: 0xEB9AE0 Offset: 0xEB80E0 VA: 0x180EB9AE0
	public static StyleColor op_Implicit(Color v) { }

	// RVA: 0x13A420 Offset: 0x139820 VA: 0x18013A420 Slot: 6
	public bool Equals(StyleColor other) { }

	// RVA: 0x13A320 Offset: 0x139720 VA: 0x18013A320 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13A4B0 Offset: 0x1398B0 VA: 0x18013A4B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13A510 Offset: 0x139910 VA: 0x18013A510 Slot: 3
	public override string ToString() { }

}

