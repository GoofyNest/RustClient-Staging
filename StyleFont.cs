public struct StyleFont : IStyleValue<Font>, IEquatable<StyleFont> // TypeDefIndex: 4713
{	// Fields
	private StyleKeyword m_Keyword; // 0x0
	private Font m_Value; // 0x8
	private int m_Specificity; // 0x10

	// Properties
	public Font value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x13AA40 Offset: 0x139E40 VA: 0x18013AA40 Slot: 4
	public Font get_value() { }

	// RVA: 0x13A620 Offset: 0x139A20 VA: 0x18013A620 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0xEB9BF0 Offset: 0xEB81F0 VA: 0x180EB9BF0
	public static bool op_Equality(StyleFont lhs, StyleFont rhs) { }

	// RVA: 0x13A950 Offset: 0x139D50 VA: 0x18013A950 Slot: 6
	public bool Equals(StyleFont other) { }

	// RVA: 0x13A860 Offset: 0x139C60 VA: 0x18013A860 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13A9D0 Offset: 0x139DD0 VA: 0x18013A9D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13A9E0 Offset: 0x139DE0 VA: 0x18013A9E0 Slot: 3
	public override string ToString() { }

}

