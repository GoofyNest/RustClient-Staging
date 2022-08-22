public struct StyleFloat : IStyleValue<float>, IEquatable<StyleFloat> // TypeDefIndex: 4712
{	// Fields
	private StyleKeyword m_Keyword; // 0x0
	private float m_Value; // 0x4
	private int m_Specificity; // 0x8

	// Properties
	public float value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x13A5F0 Offset: 0x1399F0 VA: 0x18013A5F0 Slot: 4
	public float get_value() { }

	// RVA: 0x13A3C0 Offset: 0x1397C0 VA: 0x18013A3C0 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x13A5C0 Offset: 0x1399C0 VA: 0x18013A5C0
	public void .ctor(float v) { }

	// RVA: 0x13A5D0 Offset: 0x1399D0 VA: 0x18013A5D0
	internal void .ctor(float v, StyleKeyword keyword) { }

	// RVA: 0xEBA880 Offset: 0xEB8E80 VA: 0x180EBA880
	public static bool op_Equality(StyleFloat lhs, StyleFloat rhs) { }

	// RVA: 0xEBA8B0 Offset: 0xEB8EB0 VA: 0x180EBA8B0
	public static StyleFloat op_Implicit(float v) { }

	// RVA: 0x13A410 Offset: 0x139810 VA: 0x18013A410 Slot: 6
	public bool Equals(StyleFloat other) { }

	// RVA: 0x13A450 Offset: 0x139850 VA: 0x18013A450 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13A500 Offset: 0x139900 VA: 0x18013A500 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13A560 Offset: 0x139960 VA: 0x18013A560 Slot: 3
	public override string ToString() { }

}

