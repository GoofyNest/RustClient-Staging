public struct StyleFont : IStyleValue<Font>, IEquatable<StyleFont> // TypeDefIndex: 4713
{	// Fields
	private StyleKeyword m_Keyword; // 0x0
	private Font m_Value; // 0x8
	private int m_Specificity; // 0x10

	// Properties
	public Font value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x13A7E0 Offset: 0x139BE0 VA: 0x18013A7E0 Slot: 4
	public Font get_value() { }

	// RVA: 0x13A3C0 Offset: 0x1397C0 VA: 0x18013A3C0 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0xEBA960 Offset: 0xEB8F60 VA: 0x180EBA960
	public static bool op_Equality(StyleFont lhs, StyleFont rhs) { }

	// RVA: 0x13A6F0 Offset: 0x139AF0 VA: 0x18013A6F0 Slot: 6
	public bool Equals(StyleFont other) { }

	// RVA: 0x13A600 Offset: 0x139A00 VA: 0x18013A600 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13A770 Offset: 0x139B70 VA: 0x18013A770 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13A780 Offset: 0x139B80 VA: 0x18013A780 Slot: 3
	public override string ToString() { }

}

