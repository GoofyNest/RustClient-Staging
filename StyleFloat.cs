public struct StyleFloat : IStyleValue<float>, IEquatable<StyleFloat> // TypeDefIndex: 4712
{	// Fields
	private StyleKeyword m_Keyword; // 0x0
	private float m_Value; // 0x4
	private int m_Specificity; // 0x8

	// Properties
	public float value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x13A850 Offset: 0x139C50 VA: 0x18013A850 Slot: 4
	public float get_value() { }

	// RVA: 0x13A620 Offset: 0x139A20 VA: 0x18013A620 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x13A820 Offset: 0x139C20 VA: 0x18013A820
	public void .ctor(float v) { }

	// RVA: 0x13A830 Offset: 0x139C30 VA: 0x18013A830
	internal void .ctor(float v, StyleKeyword keyword) { }

	// RVA: 0xEB9B10 Offset: 0xEB8110 VA: 0x180EB9B10
	public static bool op_Equality(StyleFloat lhs, StyleFloat rhs) { }

	// RVA: 0xEB9B40 Offset: 0xEB8140 VA: 0x180EB9B40
	public static StyleFloat op_Implicit(float v) { }

	// RVA: 0x13A670 Offset: 0x139A70 VA: 0x18013A670 Slot: 6
	public bool Equals(StyleFloat other) { }

	// RVA: 0x13A6B0 Offset: 0x139AB0 VA: 0x18013A6B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13A760 Offset: 0x139B60 VA: 0x18013A760 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13A7C0 Offset: 0x139BC0 VA: 0x18013A7C0 Slot: 3
	public override string ToString() { }

}

