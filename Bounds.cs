public struct Bounds : IEquatable<Bounds> // TypeDefIndex: 3372
{	private Vector3 m_Center; // 0x0
	[NativeNameAttribute] // RVA: 0x7D930 Offset: 0x7CD30 VA: 0x18007D930
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

	[NativeMethodAttribute] // RVA: 0x7D960 Offset: 0x7CD60 VA: 0x18007D960
	public bool Contains(Vector3 point) { }

	[FreeFunctionAttribute] // RVA: 0x7DAB0 Offset: 0x7CEB0 VA: 0x18007DAB0
	public float SqrDistance(Vector3 point) { }

	[FreeFunctionAttribute] // RVA: 0x7DB70 Offset: 0x7CF70 VA: 0x18007DB70
	private static bool IntersectRayAABB(Ray ray, Bounds bounds, out float dist) { }

	[FreeFunctionAttribute] // RVA: 0x7DD10 Offset: 0x7D110 VA: 0x18007DD10
	public Vector3 ClosestPoint(Vector3 point) { }

	private static bool Contains_Injected(ref Bounds _unity_self, ref Vector3 point) { }

	private static float SqrDistance_Injected(ref Bounds _unity_self, ref Vector3 point) { }

	private static bool IntersectRayAABB_Injected(ref Ray ray, ref Bounds bounds, out float dist) { }

	private static void ClosestPoint_Injected(ref Bounds _unity_self, ref Vector3 point, out Vector3 ret) { }

}

