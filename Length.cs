public struct Length : IEquatable<Length> // TypeDefIndex: 4709
{	// Fields
	private float m_Value; // 0x0
	private LengthUnit m_Unit; // 0x4

	// Properties
	public float value { get; }
	public LengthUnit unit { get; }

	// Methods

	// RVA: 0x13A130 Offset: 0x139530 VA: 0x18013A130
	public float get_value() { }

	// RVA: 0x13A120 Offset: 0x139520 VA: 0x18013A120
	public LengthUnit get_unit() { }

	// RVA: 0x13A100 Offset: 0x139500 VA: 0x18013A100
	public void .ctor(float value) { }

	// RVA: 0x13A110 Offset: 0x139510 VA: 0x18013A110
	public void .ctor(float value, LengthUnit unit) { }

	// RVA: 0xEB3A80 Offset: 0xEB2080 VA: 0x180EB3A80
	public static bool op_Equality(Length lhs, Length rhs) { }

	// RVA: 0x139EC0 Offset: 0x1392C0 VA: 0x180139EC0 Slot: 4
	public bool Equals(Length other) { }

	// RVA: 0x139EF0 Offset: 0x1392F0 VA: 0x180139EF0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x139FB0 Offset: 0x1393B0 VA: 0x180139FB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x139FF0 Offset: 0x1393F0 VA: 0x180139FF0 Slot: 3
	public override string ToString() { }

}

