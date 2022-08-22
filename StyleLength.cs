public struct StyleLength : IStyleValue<Length>, IEquatable<StyleLength> // TypeDefIndex: 4715
{	// Fields
	private StyleKeyword m_Keyword; // 0x0
	private Length m_Value; // 0x4
	private int m_Specificity; // 0xC

	// Properties
	public Length value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x13AE00 Offset: 0x13A200 VA: 0x18013AE00 Slot: 4
	public Length get_value() { }

	// RVA: 0x13A5A0 Offset: 0x1399A0 VA: 0x18013A5A0 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x13ADF0 Offset: 0x13A1F0 VA: 0x18013ADF0
	internal void .ctor(Length v, StyleKeyword keyword) { }

	// RVA: 0xEB9D80 Offset: 0xEB8380 VA: 0x180EB9D80
	public static bool op_Equality(StyleLength lhs, StyleLength rhs) { }

	// RVA: 0x13AD20 Offset: 0x13A120 VA: 0x18013AD20 Slot: 6
	public bool Equals(StyleLength other) { }

	// RVA: 0x13AC40 Offset: 0x13A040 VA: 0x18013AC40 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13AD80 Offset: 0x13A180 VA: 0x18013AD80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13AD90 Offset: 0x13A190 VA: 0x18013AD90 Slot: 3
	public override string ToString() { }

}

