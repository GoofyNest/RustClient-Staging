public struct Bounds : IEquatable<Bounds> // TypeDefIndex: 3372
{	private Vector3 m_Center; // 0x0
	[NativeNameAttribute] // RVA: 0x7DA30 Offset: 0x7CE30 VA: 0x18007DA30
	private Vector3 m_Extents; // 0xC

	public Vector3 center { get; set; }
	public Vector3 size { get; set; }
	public Vector3 extents { get; set; }
	public Vector3 min { get; set; }
	public Vector3 max { get; set; }


	public void .ctor(Vector3 center, Vector3 size) { }

	public override int GetHashCode() { }

	public override bool Equals(object other) { }

	public bool Equals(Bounds other) { }

	public Vector3 get_center() { }

	public void set_center(Vector3 value) { }

	public Vector3 get_size() { }

	public void set_size(Vector3 value) { }

	public Vector3 get_extents() { }

	public void set_extents(Vector3 value) { }

	public Vector3 get_min() { }

	public void set_min(Vector3 value) { }

	public Vector3 get_max() { }

	public void set_max(Vector3 value) { }

	public static bool op_Equality(Bounds lhs, Bounds rhs) { }

	public static bool op_Inequality(Bounds lhs, Bounds rhs) { }

	public void SetMinMax(Vector3 min, Vector3 max) { }

	public void Encapsulate(Vector3 point) { }

	public void Encapsulate(Bounds bounds) { }

	public void Expand(float amount) { }

	public bool IntersectRay(Ray ray) { }

	public override string ToString() { }

	[NativeMethodAttribute] // RVA: 0x7DA60 Offset: 0x7CE60 VA: 0x18007DA60
	public bool Contains(Vector3 point) { }

	[FreeFunctionAttribute] // RVA: 0x7DBB0 Offset: 0x7CFB0 VA: 0x18007DBB0
	public float SqrDistance(Vector3 point) { }

	[FreeFunctionAttribute] // RVA: 0x7DC70 Offset: 0x7D070 VA: 0x18007DC70
	private static bool IntersectRayAABB(Ray ray, Bounds bounds, out float dist) { }

	[FreeFunctionAttribute] // RVA: 0x7DDC0 Offset: 0x7D1C0 VA: 0x18007DDC0
	public Vector3 ClosestPoint(Vector3 point) { }

	private static bool Contains_Injected(ref Bounds _unity_self, ref Vector3 point) { }

	private static float SqrDistance_Injected(ref Bounds _unity_self, ref Vector3 point) { }

	private static bool IntersectRayAABB_Injected(ref Ray ray, ref Bounds bounds, out float dist) { }

	private static void ClosestPoint_Injected(ref Bounds _unity_self, ref Vector3 point, out Vector3 ret) { }

}

