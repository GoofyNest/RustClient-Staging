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

	// RVA: 0x2368F0 Offset: 0x235CF0 VA: 0x1802368F0
	public float get_Item(int index) { }

	// RVA: 0x236AD0 Offset: 0x235ED0 VA: 0x180236AD0
	public void set_Item(int index, float value) { }

	// RVA: 0xF2B40 Offset: 0xF1F40 VA: 0x1800F2B40
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x2368D0 Offset: 0x235CD0 VA: 0x1802368D0
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x21856A0 Offset: 0x2183CA0 VA: 0x1821856A0
	public static Vector4 Lerp(Vector4 a, Vector4 b, float t) { }

	// RVA: 0x2179D0 Offset: 0x216DD0 VA: 0x1802179D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2367B0 Offset: 0x235BB0 VA: 0x1802367B0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x236870 Offset: 0x235C70 VA: 0x180236870 Slot: 4
	public bool Equals(Vector4 other) { }

	// RVA: 0x2185890 Offset: 0x2183E90 VA: 0x182185890
	public static Vector4 Normalize(Vector4 a) { }

	// RVA: 0x2369A0 Offset: 0x235DA0 VA: 0x1802369A0
	public Vector4 get_normalized() { }

	// RVA: 0x18FDD50 Offset: 0x18FC350 VA: 0x1818FDD50
	public static float Dot(Vector4 a, Vector4 b) { }

	// RVA: 0x21857C0 Offset: 0x2183DC0 VA: 0x1821857C0
	public static float Magnitude(Vector4 a) { }

	// RVA: 0x236A30 Offset: 0x235E30 VA: 0x180236A30
	public float get_sqrMagnitude() { }

	// RVA: 0x2185FF0 Offset: 0x21845F0 VA: 0x182185FF0
	public static Vector4 get_zero() { }

	// RVA: 0x2185EE0 Offset: 0x21844E0 VA: 0x182185EE0
	public static Vector4 get_one() { }

	// RVA: 0x1824A60 Offset: 0x1823060 VA: 0x181824A60
	public static Vector4 op_Addition(Vector4 a, Vector4 b) { }

	// RVA: 0x1824E10 Offset: 0x1823410 VA: 0x181824E10
	public static Vector4 op_Multiply(Vector4 a, float d) { }

	// RVA: 0x1824D80 Offset: 0x1823380 VA: 0x181824D80
	public static Vector4 op_Multiply(float d, Vector4 a) { }

	// RVA: 0x1824AB0 Offset: 0x18230B0 VA: 0x181824AB0
	public static Vector4 op_Division(Vector4 a, float d) { }

	// RVA: 0x2186060 Offset: 0x2184660 VA: 0x182186060
	public static bool op_Equality(Vector4 lhs, Vector4 rhs) { }

	// RVA: 0x21861A0 Offset: 0x21847A0 VA: 0x1821861A0
	public static bool op_Inequality(Vector4 lhs, Vector4 rhs) { }

	// RVA: 0x2186100 Offset: 0x2184700 VA: 0x182186100
	public static Vector4 op_Implicit(Vector3 v) { }

	// RVA: 0x2186170 Offset: 0x2184770 VA: 0x182186170
	public static Vector3 op_Implicit(Vector4 v) { }

	// RVA: 0x21860C0 Offset: 0x21846C0 VA: 0x1821860C0
	public static Vector4 op_Implicit(Vector2 v) { }

	// RVA: 0x2186150 Offset: 0x2184750 VA: 0x182186150
	public static Vector2 op_Implicit(Vector4 v) { }

	// RVA: 0x2368C0 Offset: 0x235CC0 VA: 0x1802368C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2185CF0 Offset: 0x21842F0 VA: 0x182185CF0
	private static void .cctor() { }

}

