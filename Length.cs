public struct Length : IEquatable<Length> // TypeDefIndex: 4709
{	// Fields
	private float m_Value; // 0x0
	private LengthUnit m_Unit; // 0x4

	// Properties
	public float value { get; }
	public LengthUnit unit { get; }

	// Methods

	// RVA: 0x13A390 Offset: 0x139790 VA: 0x18013A390
	public float get_value() { }

	// RVA: 0x13A380 Offset: 0x139780 VA: 0x18013A380
	public LengthUnit get_unit() { }

	// RVA: 0x13A360 Offset: 0x139760 VA: 0x18013A360
	public void .ctor(float value) { }

	// RVA: 0x13A370 Offset: 0x139770 VA: 0x18013A370
	public void .ctor(float value, LengthUnit unit) { }

	// RVA: 0xEB2D10 Offset: 0xEB1310 VA: 0x180EB2D10
	public static bool op_Equality(Length lhs, Length rhs) { }

	// RVA: 0x13A120 Offset: 0x139520 VA: 0x18013A120 Slot: 4
	public bool Equals(Length other) { }

	// RVA: 0x13A150 Offset: 0x139550 VA: 0x18013A150 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13A210 Offset: 0x139610 VA: 0x18013A210 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13A250 Offset: 0x139650 VA: 0x18013A250 Slot: 3
	public override string ToString() { }

}

