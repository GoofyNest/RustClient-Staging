public struct RaycastHit2D // TypeDefIndex: 4084
{	[NativeNameAttribute] // RVA: 0x72000 Offset: 0x71400 VA: 0x180072000
	private Vector2 m_Centroid; // 0x0
	[NativeNameAttribute] // RVA: 0x71090 Offset: 0x70490 VA: 0x180071090
	private Vector2 m_Point; // 0x8
	[NativeNameAttribute] // RVA: 0x71180 Offset: 0x70580 VA: 0x180071180
	private Vector2 m_Normal; // 0x10
	[NativeNameAttribute] // RVA: 0x72440 Offset: 0x71840 VA: 0x180072440
	private float m_Distance; // 0x18
	[NativeNameAttribute] // RVA: 0x725C0 Offset: 0x719C0 VA: 0x1800725C0
	private float m_Fraction; // 0x1C
	[NativeNameAttribute] // RVA: 0x71800 Offset: 0x70C00 VA: 0x180071800
	private int m_Collider; // 0x20

	public Vector2 point { get; }
	public Vector2 normal { get; }
	public float distance { get; }
	public Collider2D collider { get; }


	public Vector2 get_point() { }

	public Vector2 get_normal() { }

	public float get_distance() { }

	public Collider2D get_collider() { }

}

