public struct StyleLength : IStyleValue<Length>, IEquatable<StyleLength> // TypeDefIndex: 4715
{	// Fields
	private StyleKeyword m_Keyword; // 0x0
	private Length m_Value; // 0x4
	private int m_Specificity; // 0xC

	// Properties
	public Length value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x13AE80 Offset: 0x13A280 VA: 0x18013AE80 Slot: 4
	public Length get_value() { }

	// RVA: 0x13A620 Offset: 0x139A20 VA: 0x18013A620 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x13AE70 Offset: 0x13A270 VA: 0x18013AE70
	internal void .ctor(Length v, StyleKeyword keyword) { }

	// RVA: 0xEB9D80 Offset: 0xEB8380 VA: 0x180EB9D80
	public static bool op_Equality(StyleLength lhs, StyleLength rhs) { }

	// RVA: 0x13ADA0 Offset: 0x13A1A0 VA: 0x18013ADA0 Slot: 6
	public bool Equals(StyleLength other) { }

	// RVA: 0x13ACC0 Offset: 0x13A0C0 VA: 0x18013ACC0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13AE00 Offset: 0x13A200 VA: 0x18013AE00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13AE10 Offset: 0x13A210 VA: 0x18013AE10 Slot: 3
	public override string ToString() { }

}

