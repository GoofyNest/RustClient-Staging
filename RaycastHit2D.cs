public struct RaycastHit2D // TypeDefIndex: 4084
{	// Fields
	[NativeNameAttribute] // RVA: 0x71EA0 Offset: 0x712A0 VA: 0x180071EA0
	private Vector2 m_Centroid; // 0x0
	[NativeNameAttribute] // RVA: 0x70F40 Offset: 0x70340 VA: 0x180070F40
	private Vector2 m_Point; // 0x8
	[NativeNameAttribute] // RVA: 0x710A0 Offset: 0x704A0 VA: 0x1800710A0
	private Vector2 m_Normal; // 0x10
	[NativeNameAttribute] // RVA: 0x722E0 Offset: 0x716E0 VA: 0x1800722E0
	private float m_Distance; // 0x18
	[NativeNameAttribute] // RVA: 0x723F0 Offset: 0x717F0 VA: 0x1800723F0
	private float m_Fraction; // 0x1C
	[NativeNameAttribute] // RVA: 0x716B0 Offset: 0x70AB0 VA: 0x1800716B0
	private int m_Collider; // 0x20

	// Properties
	public Vector2 point { get; }
	public Vector2 normal { get; }
	public float distance { get; }
	public Collider2D collider { get; }

	// Methods

	// RVA: 0x240600 Offset: 0x23FA00 VA: 0x180240600
	public Vector2 get_point() { }

	// RVA: 0x11FDD0 Offset: 0x11F1D0 VA: 0x18011FDD0
	public Vector2 get_normal() { }

	// RVA: 0x23D8D0 Offset: 0x23CCD0 VA: 0x18023D8D0
	public float get_distance() { }

	// RVA: 0x240550 Offset: 0x23F950 VA: 0x180240550
	public Collider2D get_collider() { }

}

