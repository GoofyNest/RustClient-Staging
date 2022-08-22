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

	// RVA: 0x13AC30 Offset: 0x13A030 VA: 0x18013AC30 Slot: 4
	public int get_value() { }

	// RVA: 0x13AC20 Offset: 0x13A020 VA: 0x18013AC20
	internal int get_specificity() { }

	// RVA: 0x13A5A0 Offset: 0x1399A0 VA: 0x18013A5A0 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x13AC00 Offset: 0x13A000 VA: 0x18013AC00
	public void .ctor(int v) { }

	// RVA: 0x13AC10 Offset: 0x13A010 VA: 0x18013AC10
	internal void .ctor(int v, StyleKeyword keyword) { }

	// RVA: 0xEB9F60 Offset: 0xEB8560 VA: 0x180EB9F60
	public static bool op_Equality(StyleInt lhs, StyleInt rhs) { }

	// RVA: 0xEB9FB0 Offset: 0xEB85B0 VA: 0x180EB9FB0
	public static StyleInt op_Implicit(int v) { }

	// RVA: 0x13A9F0 Offset: 0x139DF0 VA: 0x18013A9F0 Slot: 6
	public bool Equals(StyleInt other) { }

	// RVA: 0x13AA50 Offset: 0x139E50 VA: 0x18013AA50 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13AB40 Offset: 0x139F40 VA: 0x18013AB40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13ABA0 Offset: 0x139FA0 VA: 0x18013ABA0 Slot: 3
	public override string ToString() { }

}

