public struct StyleColor : IStyleValue<Color>, IEquatable<StyleColor> // TypeDefIndex: 4710
{	// Fields
	private StyleKeyword m_Keyword; // 0x0
	private Color m_Value; // 0x4
	private int m_Specificity; // 0x14

	// Properties
	public Color value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x13A3D0 Offset: 0x1397D0 VA: 0x18013A3D0 Slot: 4
	public Color get_value() { }

	// RVA: 0x13A3C0 Offset: 0x1397C0 VA: 0x18013A3C0 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x13A390 Offset: 0x139790 VA: 0x18013A390
	public void .ctor(Color v) { }

	// RVA: 0x13A3A0 Offset: 0x1397A0 VA: 0x18013A3A0
	internal void .ctor(Color v, StyleKeyword keyword) { }

	// RVA: 0xEBA7D0 Offset: 0xEB8DD0 VA: 0x180EBA7D0
	public static bool op_Equality(StyleColor lhs, StyleColor rhs) { }

	// RVA: 0xEBA850 Offset: 0xEB8E50 VA: 0x180EBA850
	public static StyleColor op_Implicit(Color v) { }

	// RVA: 0x13A240 Offset: 0x139640 VA: 0x18013A240 Slot: 6
	public bool Equals(StyleColor other) { }

	// RVA: 0x13A140 Offset: 0x139540 VA: 0x18013A140 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13A2D0 Offset: 0x1396D0 VA: 0x18013A2D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13A330 Offset: 0x139730 VA: 0x18013A330 Slot: 3
	public override string ToString() { }

}

