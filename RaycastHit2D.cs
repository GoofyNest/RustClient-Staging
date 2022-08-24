public struct RaycastHit2D // TypeDefIndex: 4084
{	[NativeNameAttribute] // RVA: 0x72140 Offset: 0x71540 VA: 0x180072140
	private Vector2 m_Centroid; // 0x0
	[NativeNameAttribute] // RVA: 0x71210 Offset: 0x70610 VA: 0x180071210
	private Vector2 m_Point; // 0x8
	[NativeNameAttribute] // RVA: 0x712D0 Offset: 0x706D0 VA: 0x1800712D0
	private Vector2 m_Normal; // 0x10
	[NativeNameAttribute] // RVA: 0x72590 Offset: 0x71990 VA: 0x180072590
	private float m_Distance; // 0x18
	[NativeNameAttribute] // RVA: 0x72710 Offset: 0x71B10 VA: 0x180072710
	private float m_Fraction; // 0x1C
	[NativeNameAttribute] // RVA: 0x718D0 Offset: 0x70CD0 VA: 0x1800718D0
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

