public struct RaycastHit // TypeDefIndex: 3919
{	// Fields
	[NativeNameAttribute] // RVA: 0x71040 Offset: 0x70440 VA: 0x180071040
	internal Vector3 m_Point; // 0x0
	[NativeNameAttribute] // RVA: 0x71150 Offset: 0x70550 VA: 0x180071150
	internal Vector3 m_Normal; // 0xC
	[NativeNameAttribute] // RVA: 0x8D760 Offset: 0x8CB60 VA: 0x18008D760
	internal uint m_FaceID; // 0x18
	[NativeNameAttribute] // RVA: 0x723E0 Offset: 0x717E0 VA: 0x1800723E0
	internal float m_Distance; // 0x1C
	[NativeNameAttribute] // RVA: 0x8D9A0 Offset: 0x8CDA0 VA: 0x18008D9A0
	internal Vector2 m_UV; // 0x20
	[NativeNameAttribute] // RVA: 0x717B0 Offset: 0x70BB0 VA: 0x1800717B0
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

	// RVA: 0x2395C0 Offset: 0x2389C0 VA: 0x1802395C0
	public Collider get_collider() { }

	// RVA: 0x211FC0 Offset: 0x2113C0 VA: 0x180211FC0
	public Vector3 get_point() { }

	// RVA: 0x204B60 Offset: 0x203F60 VA: 0x180204B60
	public void set_point(Vector3 value) { }

	// RVA: 0x211FE0 Offset: 0x2113E0 VA: 0x180211FE0
	public Vector3 get_normal() { }

	// RVA: 0x2120F0 Offset: 0x2114F0 VA: 0x1802120F0
	public void set_normal(Vector3 value) { }

	// RVA: 0x2395D0 Offset: 0x2389D0 VA: 0x1802395D0
	public float get_distance() { }

	// RVA: 0x239830 Offset: 0x238C30 VA: 0x180239830
	public void set_distance(float value) { }

	// RVA: 0x211740 Offset: 0x210B40 VA: 0x180211740
	public int get_triangleIndex() { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x229E800 Offset: 0x229CE00 VA: 0x18229E800
	private static Vector2 CalculateRaycastTexCoord(Collider collider, Vector2 uv, Vector3 pos, uint face, int textcoord) { }

	// RVA: 0x239690 Offset: 0x238A90 VA: 0x180239690
	public Vector2 get_textureCoord() { }

	// RVA: 0x2395F0 Offset: 0x2389F0 VA: 0x1802395F0
	public Vector2 get_textureCoord2() { }

	// RVA: 0x239730 Offset: 0x238B30 VA: 0x180239730
	public Transform get_transform() { }

	// RVA: 0x2395E0 Offset: 0x2389E0 VA: 0x1802395E0
	public Rigidbody get_rigidbody() { }

	// RVA: 0x229E790 Offset: 0x229CD90 VA: 0x18229E790
	private static void CalculateRaycastTexCoord_Injected(Collider collider, ref Vector2 uv, ref Vector3 pos, uint face, int textcoord, out Vector2 ret) { }

}

