public struct RaycastHit2D // TypeDefIndex: 4084
{	[NativeNameAttribute] // RVA: 0x71FA0 Offset: 0x713A0 VA: 0x180071FA0
	private Vector2 m_Centroid; // 0x0
	[NativeNameAttribute] // RVA: 0x71040 Offset: 0x70440 VA: 0x180071040
	private Vector2 m_Point; // 0x8
	[NativeNameAttribute] // RVA: 0x71150 Offset: 0x70550 VA: 0x180071150
	private Vector2 m_Normal; // 0x10
	[NativeNameAttribute] // RVA: 0x723E0 Offset: 0x717E0 VA: 0x1800723E0
	private float m_Distance; // 0x18
	[NativeNameAttribute] // RVA: 0x72500 Offset: 0x71900 VA: 0x180072500
	private float m_Fraction; // 0x1C
	[NativeNameAttribute] // RVA: 0x717B0 Offset: 0x70BB0 VA: 0x1800717B0
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

