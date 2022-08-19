public struct RaycastHit // TypeDefIndex: 3919
{	// Fields
	[NativeNameAttribute] // RVA: 0x70F40 Offset: 0x70340 VA: 0x180070F40
	internal Vector3 m_Point; // 0x0
	[NativeNameAttribute] // RVA: 0x710A0 Offset: 0x704A0 VA: 0x1800710A0
	internal Vector3 m_Normal; // 0xC
	[NativeNameAttribute] // RVA: 0x8D630 Offset: 0x8CA30 VA: 0x18008D630
	internal uint m_FaceID; // 0x18
	[NativeNameAttribute] // RVA: 0x722E0 Offset: 0x716E0 VA: 0x1800722E0
	internal float m_Distance; // 0x1C
	[NativeNameAttribute] // RVA: 0x8D8F0 Offset: 0x8CCF0 VA: 0x18008D8F0
	internal Vector2 m_UV; // 0x20
	[NativeNameAttribute] // RVA: 0x716B0 Offset: 0x70AB0 VA: 0x1800716B0
	internal int m_Collider; // 0x28

	// Properties
	public Collider collider { get; }
	public Vector3 point { get; set; }
	public Vector3 normal { get; set; }
	public float distance { get; set; }
	public int triangleIndex { get; }
	public Vector2 textureCoord { get; }
	public Vector2 textureCoord2 { get; }
	public Transform transform { get; }
	public Rigidbody rigidbody { get; }

	// Methods

	// RVA: 0x239640 Offset: 0x238A40 VA: 0x180239640
	public Collider get_collider() { }

	// RVA: 0x212C10 Offset: 0x212010 VA: 0x180212C10
	public Vector3 get_point() { }

	// RVA: 0x204FB0 Offset: 0x2043B0 VA: 0x180204FB0
	public void set_point(Vector3 value) { }

	// RVA: 0x212C30 Offset: 0x212030 VA: 0x180212C30
	public Vector3 get_normal() { }

	// RVA: 0x212D40 Offset: 0x212140 VA: 0x180212D40
	public void set_normal(Vector3 value) { }

	// RVA: 0x239650 Offset: 0x238A50 VA: 0x180239650
	public float get_distance() { }

	// RVA: 0x2398B0 Offset: 0x238CB0 VA: 0x1802398B0
	public void set_distance(float value) { }

	// RVA: 0x212390 Offset: 0x211790 VA: 0x180212390
	public int get_triangleIndex() { }

	[FreeFunctionAttribute] // RVA: 0x7A300 Offset: 0x79700 VA: 0x18007A300
	// RVA: 0x229DEE0 Offset: 0x229C4E0 VA: 0x18229DEE0
	private static Vector2 CalculateRaycastTexCoord(Collider collider, Vector2 uv, Vector3 pos, uint face, int textcoord) { }

	// RVA: 0x239710 Offset: 0x238B10 VA: 0x180239710
	public Vector2 get_textureCoord() { }

	// RVA: 0x239670 Offset: 0x238A70 VA: 0x180239670
	public Vector2 get_textureCoord2() { }

	// RVA: 0x2397B0 Offset: 0x238BB0 VA: 0x1802397B0
	public Transform get_transform() { }

	// RVA: 0x239660 Offset: 0x238A60 VA: 0x180239660
	public Rigidbody get_rigidbody() { }

	// RVA: 0x229DE70 Offset: 0x229C470 VA: 0x18229DE70
	private static void CalculateRaycastTexCoord_Injected(Collider collider, ref Vector2 uv, ref Vector3 pos, uint face, int textcoord, out Vector2 ret) { }

}

