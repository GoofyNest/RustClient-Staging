public struct StyleInt : IStyleValue<int>, IEquatable<StyleInt> // TypeDefIndex: 4714
{	// Fields
	private StyleKeyword m_Keyword; // 0x0
	private int m_Value; // 0x4
	private int m_Specificity; // 0x8

	// Properties
	public int value { get; }
	internal int specificity { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x13AA50 Offset: 0x139E50 VA: 0x18013AA50 Slot: 4
	public int get_value() { }

	// RVA: 0x13AA40 Offset: 0x139E40 VA: 0x18013AA40
	internal int get_specificity() { }

	// RVA: 0x13A3C0 Offset: 0x1397C0 VA: 0x18013A3C0 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x13AA20 Offset: 0x139E20 VA: 0x18013AA20
	public void .ctor(int v) { }

	// RVA: 0x13AA30 Offset: 0x139E30 VA: 0x18013AA30
	internal void .ctor(int v, StyleKeyword keyword) { }

	// RVA: 0xEBAA10 Offset: 0xEB9010 VA: 0x180EBAA10
	public static bool op_Equality(StyleInt lhs, StyleInt rhs) { }

	// RVA: 0xEBAA60 Offset: 0xEB9060 VA: 0x180EBAA60
	public static StyleInt op_Implicit(int v) { }

	// RVA: 0x13A810 Offset: 0x139C10 VA: 0x18013A810 Slot: 6
	public bool Equals(StyleInt other) { }

	// RVA: 0x13A870 Offset: 0x139C70 VA: 0x18013A870 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13A960 Offset: 0x139D60 VA: 0x18013A960 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13A9C0 Offset: 0x139DC0 VA: 0x18013A9C0 Slot: 3
	public override string ToString() { }

}

