public struct StyleFloat : IStyleValue<float>, IEquatable<StyleFloat> // TypeDefIndex: 4712
{	// Fields
	private StyleKeyword m_Keyword; // 0x0
	private float m_Value; // 0x4
	private int m_Specificity; // 0x8

	// Properties
	public float value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x13A7D0 Offset: 0x139BD0 VA: 0x18013A7D0 Slot: 4
	public float get_value() { }

	// RVA: 0x13A5A0 Offset: 0x1399A0 VA: 0x18013A5A0 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x13A7A0 Offset: 0x139BA0 VA: 0x18013A7A0
	public void .ctor(float v) { }

	// RVA: 0x13A7B0 Offset: 0x139BB0 VA: 0x18013A7B0
	internal void .ctor(float v, StyleKeyword keyword) { }

	// RVA: 0xEB9B10 Offset: 0xEB8110 VA: 0x180EB9B10
	public static bool op_Equality(StyleFloat lhs, StyleFloat rhs) { }

	// RVA: 0xEB9B40 Offset: 0xEB8140 VA: 0x180EB9B40
	public static StyleFloat op_Implicit(float v) { }

	// RVA: 0x13A5F0 Offset: 0x1399F0 VA: 0x18013A5F0 Slot: 6
	public bool Equals(StyleFloat other) { }

	// RVA: 0x13A630 Offset: 0x139A30 VA: 0x18013A630 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13A6E0 Offset: 0x139AE0 VA: 0x18013A6E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13A740 Offset: 0x139B40 VA: 0x18013A740 Slot: 3
	public override string ToString() { }

}

