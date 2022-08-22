public struct Vector4 : IEquatable<Vector4> // TypeDefIndex: 3473
{	// Fields
	public const float kEpsilon = 1E-05;
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public float w; // 0xC
	private static readonly Vector4 zeroVector; // 0x0
	private static readonly Vector4 oneVector; // 0x10
	private static readonly Vector4 positiveInfinityVector; // 0x20
	private static readonly Vector4 negativeInfinityVector; // 0x30

	// Properties
	public float Item { get; set; }
	public Vector4 normalized { get; }
	public float sqrMagnitude { get; }
	public static Vector4 zero { get; }
	public static Vector4 one { get; }

	// Methods

	// RVA: 0x236870 Offset: 0x235C70 VA: 0x180236870
	public float get_Item(int index) { }

	// RVA: 0x236A50 Offset: 0x235E50 VA: 0x180236A50
	public void set_Item(int index, float value) { }

	// RVA: 0xF2AC0 Offset: 0xF1EC0 VA: 0x1800F2AC0
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x236850 Offset: 0x235C50 VA: 0x180236850
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x2185FC0 Offset: 0x21845C0 VA: 0x182185FC0
	public static Vector4 Lerp(Vector4 a, Vector4 b, float t) { }

	// RVA: 0x218020 Offset: 0x217420 VA: 0x180218020 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x236730 Offset: 0x235B30 VA: 0x180236730 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2367F0 Offset: 0x235BF0 VA: 0x1802367F0 Slot: 4
	public bool Equals(Vector4 other) { }

	// RVA: 0x21861B0 Offset: 0x21847B0 VA: 0x1821861B0
	public static Vector4 Normalize(Vector4 a) { }

	// RVA: 0x236920 Offset: 0x235D20 VA: 0x180236920
	public Vector4 get_normalized() { }

	// RVA: 0x18FD6F0 Offset: 0x18FBCF0 VA: 0x1818FD6F0
	public static float Dot(Vector4 a, Vector4 b) { }

	// RVA: 0x21860E0 Offset: 0x21846E0 VA: 0x1821860E0
	public static float Magnitude(Vector4 a) { }

	// RVA: 0x2369B0 Offset: 0x235DB0 VA: 0x1802369B0
	public float get_sqrMagnitude() { }

	// RVA: 0x2186910 Offset: 0x2184F10 VA: 0x182186910
	public static Vector4 get_zero() { }

	// RVA: 0x2186800 Offset: 0x2184E00 VA: 0x182186800
	public static Vector4 get_one() { }

	// RVA: 0x1812160 Offset: 0x1810760 VA: 0x181812160
	public static Vector4 op_Addition(Vector4 a, Vector4 b) { }

	// RVA: 0x1812510 Offset: 0x1810B10 VA: 0x181812510
	public static Vector4 op_Multiply(Vector4 a, float d) { }

	// RVA: 0x1812480 Offset: 0x1810A80 VA: 0x181812480
	public static Vector4 op_Multiply(float d, Vector4 a) { }

	// RVA: 0x18121B0 Offset: 0x18107B0 VA: 0x1818121B0
	public static Vector4 op_Division(Vector4 a, float d) { }

	// RVA: 0x2186980 Offset: 0x2184F80 VA: 0x182186980
	public static bool op_Equality(Vector4 lhs, Vector4 rhs) { }

	// RVA: 0x2186AC0 Offset: 0x21850C0 VA: 0x182186AC0
	public static bool op_Inequality(Vector4 lhs, Vector4 rhs) { }

	// RVA: 0x2186A20 Offset: 0x2185020 VA: 0x182186A20
	public static Vector4 op_Implicit(Vector3 v) { }

	// RVA: 0x2186A90 Offset: 0x2185090 VA: 0x182186A90
	public static Vector3 op_Implicit(Vector4 v) { }

	// RVA: 0x21869E0 Offset: 0x2184FE0 VA: 0x1821869E0
	public static Vector4 op_Implicit(Vector2 v) { }

	// RVA: 0x2186A70 Offset: 0x2185070 VA: 0x182186A70
	public static Vector2 op_Implicit(Vector4 v) { }

	// RVA: 0x236840 Offset: 0x235C40 VA: 0x180236840 Slot: 3
	public override string ToString() { }

	// RVA: 0x2186610 Offset: 0x2184C10 VA: 0x182186610
	private static void .cctor() { }

}

