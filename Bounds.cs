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

	// RVA: 0x211F10 Offset: 0x211310 VA: 0x180211F10
	public void .ctor(Vector3 center, Vector3 size) { }

	// RVA: 0x211C40 Offset: 0x211040 VA: 0x180211C40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2119A0 Offset: 0x210DA0 VA: 0x1802119A0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x211AB0 Offset: 0x210EB0 VA: 0x180211AB0 Slot: 4
	public bool Equals(Bounds other) { }

	// RVA: 0x211FC0 Offset: 0x2113C0 VA: 0x180211FC0
	public Vector3 get_center() { }

	// RVA: 0x204B60 Offset: 0x203F60 VA: 0x180204B60
	public void set_center(Vector3 value) { }

	// RVA: 0x212040 Offset: 0x211440 VA: 0x180212040
	public Vector3 get_size() { }

	// RVA: 0x2121D0 Offset: 0x2115D0 VA: 0x1802121D0
	public void set_size(Vector3 value) { }

	// RVA: 0x211FE0 Offset: 0x2113E0 VA: 0x180211FE0
	public Vector3 get_extents() { }

	// RVA: 0x2120F0 Offset: 0x2114F0 VA: 0x1802120F0
	public void set_extents(Vector3 value) { }

	// RVA: 0x212020 Offset: 0x211420 VA: 0x180212020
	public Vector3 get_min() { }

	// RVA: 0x212160 Offset: 0x211560 VA: 0x180212160
	public void set_min(Vector3 value) { }

	// RVA: 0x212000 Offset: 0x211400 VA: 0x180212000
	public Vector3 get_max() { }

	// RVA: 0x212100 Offset: 0x211500 VA: 0x180212100
	public void set_max(Vector3 value) { }

	// RVA: 0x180DFD0 Offset: 0x180C5D0 VA: 0x18180DFD0
	public static bool op_Equality(Bounds lhs, Bounds rhs) { }

	// RVA: 0x180E0C0 Offset: 0x180C6C0 VA: 0x18180E0C0
	public static bool op_Inequality(Bounds lhs, Bounds rhs) { }

	// RVA: 0x211D10 Offset: 0x211110 VA: 0x180211D10
	public void SetMinMax(Vector3 min, Vector3 max) { }

	// RVA: 0x211970 Offset: 0x210D70 VA: 0x180211970
	public void Encapsulate(Vector3 point) { }

	// RVA: 0x211850 Offset: 0x210C50 VA: 0x180211850
	public void Encapsulate(Bounds bounds) { }

	// RVA: 0x211B50 Offset: 0x210F50 VA: 0x180211B50
	public void Expand(float amount) { }

	// RVA: 0x211CA0 Offset: 0x2110A0 VA: 0x180211CA0
	public bool IntersectRay(Ray ray) { }

	// RVA: 0x211DA0 Offset: 0x2111A0 VA: 0x180211DA0 Slot: 3
	public override string ToString() { }

	[NativeMethodAttribute] // RVA: 0x7D980 Offset: 0x7CD80 VA: 0x18007D980
	// RVA: 0x211800 Offset: 0x210C00 VA: 0x180211800
	public bool Contains(Vector3 point) { }

	[FreeFunctionAttribute] // RVA: 0x7DAD0 Offset: 0x7CED0 VA: 0x18007DAD0
	// RVA: 0x211D50 Offset: 0x211150 VA: 0x180211D50
	public float SqrDistance(Vector3 point) { }

	[FreeFunctionAttribute] // RVA: 0x7DBE0 Offset: 0x7CFE0 VA: 0x18007DBE0
	// RVA: 0x180DA00 Offset: 0x180C000 VA: 0x18180DA00
	private static bool IntersectRayAABB(Ray ray, Bounds bounds, out float dist) { }

	[FreeFunctionAttribute] // RVA: 0x7DD30 Offset: 0x7D130 VA: 0x18007DD30
	// RVA: 0x211790 Offset: 0x210B90 VA: 0x180211790
	public Vector3 ClosestPoint(Vector3 point) { }

	// RVA: 0x180D5C0 Offset: 0x180BBC0 VA: 0x18180D5C0
	private static bool Contains_Injected(ref Bounds _unity_self, ref Vector3 point) { }

	// RVA: 0x180DBF0 Offset: 0x180C1F0 VA: 0x18180DBF0
	private static float SqrDistance_Injected(ref Bounds _unity_self, ref Vector3 point) { }

	// RVA: 0x180D9A0 Offset: 0x180BFA0 VA: 0x18180D9A0
	private static bool IntersectRayAABB_Injected(ref Ray ray, ref Bounds bounds, out float dist) { }

	// RVA: 0x180D500 Offset: 0x180BB00 VA: 0x18180D500
	private static void ClosestPoint_Injected(ref Bounds _unity_self, ref Vector3 point, out Vector3 ret) { }

}

