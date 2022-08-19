public struct Bounds : IEquatable<Bounds> // TypeDefIndex: 3372
{	// Fields
	private Vector3 m_Center; // 0x0
	[NativeNameAttribute] // RVA: 0x7D880 Offset: 0x7CC80 VA: 0x18007D880
	private Vector3 m_Extents; // 0xC

	// Properties
	public Vector3 center { get; set; }
	public Vector3 size { get; set; }
	public Vector3 extents { get; set; }
	public Vector3 min { get; set; }
	public Vector3 max { get; set; }

	// Methods

	// RVA: 0x212B60 Offset: 0x211F60 VA: 0x180212B60
	public void .ctor(Vector3 center, Vector3 size) { }

	// RVA: 0x212890 Offset: 0x211C90 VA: 0x180212890 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2125F0 Offset: 0x2119F0 VA: 0x1802125F0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x212700 Offset: 0x211B00 VA: 0x180212700 Slot: 4
	public bool Equals(Bounds other) { }

	// RVA: 0x212C10 Offset: 0x212010 VA: 0x180212C10
	public Vector3 get_center() { }

	// RVA: 0x204FB0 Offset: 0x2043B0 VA: 0x180204FB0
	public void set_center(Vector3 value) { }

	// RVA: 0x212C90 Offset: 0x212090 VA: 0x180212C90
	public Vector3 get_size() { }

	// RVA: 0x212E20 Offset: 0x212220 VA: 0x180212E20
	public void set_size(Vector3 value) { }

	// RVA: 0x212C30 Offset: 0x212030 VA: 0x180212C30
	public Vector3 get_extents() { }

	// RVA: 0x212D40 Offset: 0x212140 VA: 0x180212D40
	public void set_extents(Vector3 value) { }

	// RVA: 0x212C70 Offset: 0x212070 VA: 0x180212C70
	public Vector3 get_min() { }

	// RVA: 0x212DB0 Offset: 0x2121B0 VA: 0x180212DB0
	public void set_min(Vector3 value) { }

	// RVA: 0x212C50 Offset: 0x212050 VA: 0x180212C50
	public Vector3 get_max() { }

	// RVA: 0x212D50 Offset: 0x212150 VA: 0x180212D50
	public void set_max(Vector3 value) { }

	// RVA: 0x18208D0 Offset: 0x181EED0 VA: 0x1818208D0
	public static bool op_Equality(Bounds lhs, Bounds rhs) { }

	// RVA: 0x18209C0 Offset: 0x181EFC0 VA: 0x1818209C0
	public static bool op_Inequality(Bounds lhs, Bounds rhs) { }

	// RVA: 0x212960 Offset: 0x211D60 VA: 0x180212960
	public void SetMinMax(Vector3 min, Vector3 max) { }

	// RVA: 0x2125C0 Offset: 0x2119C0 VA: 0x1802125C0
	public void Encapsulate(Vector3 point) { }

	// RVA: 0x2124A0 Offset: 0x2118A0 VA: 0x1802124A0
	public void Encapsulate(Bounds bounds) { }

	// RVA: 0x2127A0 Offset: 0x211BA0 VA: 0x1802127A0
	public void Expand(float amount) { }

	// RVA: 0x2128F0 Offset: 0x211CF0 VA: 0x1802128F0
	public bool IntersectRay(Ray ray) { }

	// RVA: 0x2129F0 Offset: 0x211DF0 VA: 0x1802129F0 Slot: 3
	public override string ToString() { }

	[NativeMethodAttribute] // RVA: 0x7D8B0 Offset: 0x7CCB0 VA: 0x18007D8B0
	// RVA: 0x212450 Offset: 0x211850 VA: 0x180212450
	public bool Contains(Vector3 point) { }

	[FreeFunctionAttribute] // RVA: 0x7DA00 Offset: 0x7CE00 VA: 0x18007DA00
	// RVA: 0x2129A0 Offset: 0x211DA0 VA: 0x1802129A0
	public float SqrDistance(Vector3 point) { }

	[FreeFunctionAttribute] // RVA: 0x7DB10 Offset: 0x7CF10 VA: 0x18007DB10
	// RVA: 0x1820300 Offset: 0x181E900 VA: 0x181820300
	private static bool IntersectRayAABB(Ray ray, Bounds bounds, out float dist) { }

	[FreeFunctionAttribute] // RVA: 0x7DC50 Offset: 0x7D050 VA: 0x18007DC50
	// RVA: 0x2123E0 Offset: 0x2117E0 VA: 0x1802123E0
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

