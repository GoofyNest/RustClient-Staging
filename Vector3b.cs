public struct Vector3b : IEquatable<Vector3b> // TypeDefIndex: 4822
{	// Fields
	public static readonly Vector3b alltrue; // 0x0
	public static readonly Vector3b allfalse; // 0x3
	public bool x; // 0x0
	public bool y; // 0x1
	public bool z; // 0x2

	// Methods

	// RVA: 0x2389C0 Offset: 0x237DC0 VA: 0x1802389C0
	public void .ctor(bool x, bool y, bool z) { }

	// RVA: 0x22725E0 Offset: 0x2270BE0 VA: 0x1822725E0
	public static bool op_Equality(Vector3b a, Vector3b b) { }

	// RVA: 0x2272610 Offset: 0x2270C10 VA: 0x182272610
	public static bool op_Inequality(Vector3b a, Vector3b b) { }

	// RVA: 0x238800 Offset: 0x237C00 VA: 0x180238800 Slot: 4
	public bool Equals(Vector3b o) { }

	// RVA: 0x2388D0 Offset: 0x237CD0 VA: 0x1802388D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x238830 Offset: 0x237C30 VA: 0x180238830 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x238920 Offset: 0x237D20 VA: 0x180238920 Slot: 3
	public override string ToString() { }

	// RVA: 0x2272570 Offset: 0x2270B70 VA: 0x182272570
	private static void .cctor() { }

}

