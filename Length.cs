public struct Length : IEquatable<Length> // TypeDefIndex: 4709
{	// Fields
	private float m_Value; // 0x0
	private LengthUnit m_Unit; // 0x4

	// Properties
	public float value { get; }
	public LengthUnit unit { get; }

	// Methods

	// RVA: 0x13A310 Offset: 0x139710 VA: 0x18013A310
	public float get_value() { }

	// RVA: 0x13A300 Offset: 0x139700 VA: 0x18013A300
	public LengthUnit get_unit() { }

	// RVA: 0x13A2E0 Offset: 0x1396E0 VA: 0x18013A2E0
	public void .ctor(float value) { }

	// RVA: 0x13A2F0 Offset: 0x1396F0 VA: 0x18013A2F0
	public void .ctor(float value, LengthUnit unit) { }

	// RVA: 0xEB2D10 Offset: 0xEB1310 VA: 0x180EB2D10
	public static bool op_Equality(Length lhs, Length rhs) { }

	// RVA: 0x13A0A0 Offset: 0x1394A0 VA: 0x18013A0A0 Slot: 4
	public bool Equals(Length other) { }

	// RVA: 0x13A0D0 Offset: 0x1394D0 VA: 0x18013A0D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13A190 Offset: 0x139590 VA: 0x18013A190 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13A1D0 Offset: 0x1395D0 VA: 0x18013A1D0 Slot: 3
	public override string ToString() { }

}

