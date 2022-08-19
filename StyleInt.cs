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

	// RVA: 0x13ACB0 Offset: 0x13A0B0 VA: 0x18013ACB0 Slot: 4
	public int get_value() { }

	// RVA: 0x13ACA0 Offset: 0x13A0A0 VA: 0x18013ACA0
	internal int get_specificity() { }

	// RVA: 0x13A620 Offset: 0x139A20 VA: 0x18013A620 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x13AC80 Offset: 0x13A080 VA: 0x18013AC80
	public void .ctor(int v) { }

	// RVA: 0x13AC90 Offset: 0x13A090 VA: 0x18013AC90
	internal void .ctor(int v, StyleKeyword keyword) { }

	// RVA: 0xEB9CA0 Offset: 0xEB82A0 VA: 0x180EB9CA0
	public static bool op_Equality(StyleInt lhs, StyleInt rhs) { }

	// RVA: 0xEB9CF0 Offset: 0xEB82F0 VA: 0x180EB9CF0
	public static StyleInt op_Implicit(int v) { }

	// RVA: 0x13AA70 Offset: 0x139E70 VA: 0x18013AA70 Slot: 6
	public bool Equals(StyleInt other) { }

	// RVA: 0x13AAD0 Offset: 0x139ED0 VA: 0x18013AAD0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13ABC0 Offset: 0x139FC0 VA: 0x18013ABC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13AC20 Offset: 0x13A020 VA: 0x18013AC20 Slot: 3
	public override string ToString() { }

}

