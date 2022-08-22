public struct StyleLength : IStyleValue<Length>, IEquatable<StyleLength> // TypeDefIndex: 4715
{	// Fields
	private StyleKeyword m_Keyword; // 0x0
	private Length m_Value; // 0x4
	private int m_Specificity; // 0xC

	// Properties
	public Length value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x13AC20 Offset: 0x13A020 VA: 0x18013AC20 Slot: 4
	public Length get_value() { }

	// RVA: 0x13A3C0 Offset: 0x1397C0 VA: 0x18013A3C0 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x13AC10 Offset: 0x13A010 VA: 0x18013AC10
	internal void .ctor(Length v, StyleKeyword keyword) { }

	// RVA: 0xEBAAF0 Offset: 0xEB90F0 VA: 0x180EBAAF0
	public static bool op_Equality(StyleLength lhs, StyleLength rhs) { }

	// RVA: 0x13AB40 Offset: 0x139F40 VA: 0x18013AB40 Slot: 6
	public bool Equals(StyleLength other) { }

	// RVA: 0x13AA60 Offset: 0x139E60 VA: 0x18013AA60 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13ABA0 Offset: 0x139FA0 VA: 0x18013ABA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13ABB0 Offset: 0x139FB0 VA: 0x18013ABB0 Slot: 3
	public override string ToString() { }

}

