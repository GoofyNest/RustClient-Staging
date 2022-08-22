public struct Bounds : IEquatable<Bounds> // TypeDefIndex: 3372
{	// Fields
	private Vector3 m_Center; // 0x0
	[NativeNameAttribute] // RVA: 0x7D950 Offset: 0x7CD50 VA: 0x18007D950
	private Vector3 m_Extents; // 0xC

	// Properties
	public Vector3 center { get; set; }
	public Vector3 size { get; set; }
	public Vector3 extents { get; set; }
	public Vector3 min { get; set; }
	public Vector3 max { get; set; }

	// Methods

	// RVA: 0x212AE0 Offset: 0x211EE0 VA: 0x180212AE0
	public void .ctor(Vector3 center, Vector3 size) { }

	// RVA: 0x212810 Offset: 0x211C10 VA: 0x180212810 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x212570 Offset: 0x211970 VA: 0x180212570 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x212680 Offset: 0x211A80 VA: 0x180212680 Slot: 4
	public bool Equals(Bounds other) { }

	// RVA: 0x212B90 Offset: 0x211F90 VA: 0x180212B90
	public Vector3 get_center() { }

	// RVA: 0x204F30 Offset: 0x204330 VA: 0x180204F30
	public void set_center(Vector3 value) { }

	// RVA: 0x212C10 Offset: 0x212010 VA: 0x180212C10
	public Vector3 get_size() { }

	// RVA: 0x212DA0 Offset: 0x2121A0 VA: 0x180212DA0
	public void set_size(Vector3 value) { }

	// RVA: 0x212BB0 Offset: 0x211FB0 VA: 0x180212BB0
	public Vector3 get_extents() { }

	// RVA: 0x212CC0 Offset: 0x2120C0 VA: 0x180212CC0
	public void set_extents(Vector3 value) { }

	// RVA: 0x212BF0 Offset: 0x211FF0 VA: 0x180212BF0
	public Vector3 get_min() { }

	// RVA: 0x212D30 Offset: 0x212130 VA: 0x180212D30
	public void set_min(Vector3 value) { }

	// RVA: 0x212BD0 Offset: 0x211FD0 VA: 0x180212BD0
	public Vector3 get_max() { }

	// RVA: 0x212CD0 Offset: 0x2120D0 VA: 0x180212CD0
	public void set_max(Vector3 value) { }

	// RVA: 0x18208D0 Offset: 0x181EED0 VA: 0x1818208D0
	public static bool op_Equality(Bounds lhs, Bounds rhs) { }

	// RVA: 0x18209C0 Offset: 0x181EFC0 VA: 0x1818209C0
	public static bool op_Inequality(Bounds lhs, Bounds rhs) { }

	// RVA: 0x2128E0 Offset: 0x211CE0 VA: 0x1802128E0
	public void SetMinMax(Vector3 min, Vector3 max) { }

	// RVA: 0x212540 Offset: 0x211940 VA: 0x180212540
	public void Encapsulate(Vector3 point) { }

	// RVA: 0x212420 Offset: 0x211820 VA: 0x180212420
	public void Encapsulate(Bounds bounds) { }

	// RVA: 0x212720 Offset: 0x211B20 VA: 0x180212720
	public void Expand(float amount) { }

	// RVA: 0x212870 Offset: 0x211C70 VA: 0x180212870
	public bool IntersectRay(Ray ray) { }

	// RVA: 0x212970 Offset: 0x211D70 VA: 0x180212970 Slot: 3
	public override string ToString() { }

	[NativeMethodAttribute] // RVA: 0x7D980 Offset: 0x7CD80 VA: 0x18007D980
	// RVA: 0x2123D0 Offset: 0x2117D0 VA: 0x1802123D0
	public bool Contains(Vector3 point) { }

	[FreeFunctionAttribute] // RVA: 0x7DAD0 Offset: 0x7CED0 VA: 0x18007DAD0
	// RVA: 0x212920 Offset: 0x211D20 VA: 0x180212920
	public float SqrDistance(Vector3 point) { }

	[FreeFunctionAttribute] // RVA: 0x7DBE0 Offset: 0x7CFE0 VA: 0x18007DBE0
	// RVA: 0x1820300 Offset: 0x181E900 VA: 0x181820300
	private static bool IntersectRayAABB(Ray ray, Bounds bounds, out float dist) { }

	[FreeFunctionAttribute] // RVA: 0x7DD30 Offset: 0x7D130 VA: 0x18007DD30
	// RVA: 0x212360 Offset: 0x211760 VA: 0x180212360
	public Vector3 ClosestPoint(Vector3 point) { }

	// RVA: 0x181FEC0 Offset: 0x181E4C0 VA: 0x18181FEC0
	private static bool Contains_Injected(ref Bounds _unity_self, ref Vector3 point) { }

	// RVA: 0x18204F0 Offset: 0x181EAF0 VA: 0x1818204F0
	private static float SqrDistance_Injected(ref Bounds _unity_self, ref Vector3 point) { }

	// RVA: 0x18202A0 Offset: 0x181E8A0 VA: 0x1818202A0
	private static bool IntersectRayAABB_Injected(ref Ray ray, ref Bounds bounds, out float dist) { }

	// RVA: 0x181FE00 Offset: 0x181E400 VA: 0x18181FE00
	private static void ClosestPoint_Injected(ref Bounds _unity_self, ref Vector3 point, out Vector3 ret) { }

}

