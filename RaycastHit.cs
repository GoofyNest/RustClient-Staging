public struct RaycastHit // TypeDefIndex: 3919
{	[NativeNameAttribute] // RVA: 0x71090 Offset: 0x70490 VA: 0x180071090
	internal Vector3 m_Point; // 0x0
	[NativeNameAttribute] // RVA: 0x71180 Offset: 0x70580 VA: 0x180071180
	internal Vector3 m_Normal; // 0xC
	[NativeNameAttribute] // RVA: 0x8D870 Offset: 0x8CC70 VA: 0x18008D870
	internal uint m_FaceID; // 0x18
	[NativeNameAttribute] // RVA: 0x72440 Offset: 0x71840 VA: 0x180072440
	internal float m_Distance; // 0x1C
	[NativeNameAttribute] // RVA: 0x8DAE0 Offset: 0x8CEE0 VA: 0x18008DAE0
	internal Vector2 m_UV; // 0x20
	[NativeNameAttribute] // RVA: 0x71800 Offset: 0x70C00 VA: 0x180071800
	internal int m_Collider; // 0x28

	public Collider collider { get; }
	public Vector3 point { get; set; }
	public Vector3 normal { get; set; }
	public float distance { get; set; }
	public int triangleIndex { get; }
	public Vector2 textureCoord { get; }
	public Vector2 textureCoord2 { get; }
	public Transform transform { get; }
	public Rigidbody rigidbody { get; }


	public Collider get_collider() { }

	public Vector3 get_point() { }

	public void set_point(Vector3 value) { }

	public Vector3 get_normal() { }

	public void set_normal(Vector3 value) { }

	public float get_distance() { }

	public void set_distance(float value) { }

	public int get_triangleIndex() { }

	[FreeFunctionAttribute] // RVA: 0x7A500 Offset: 0x79900 VA: 0x18007A500
	private static Vector2 CalculateRaycastTexCoord(Collider collider, Vector2 uv, Vector3 pos, uint face, int textcoord) { }

	public Vector2 get_textureCoord() { }

	public Vector2 get_textureCoord2() { }

	public Transform get_transform() { }

	public Rigidbody get_rigidbody() { }

	private static void CalculateRaycastTexCoord_Injected(Collider collider, ref Vector2 uv, ref Vector3 pos, uint face, int textcoord, out Vector2 ret) { }

}

