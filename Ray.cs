public struct Ray // TypeDefIndex: 3375
{	// Fields
	private Vector3 m_Origin; // 0x0
	private Vector3 m_Direction; // 0xC

	// Properties
	public Vector3 origin { get; set; }
	public Vector3 direction { get; set; }

	// Methods

	// RVA: 0x218460 Offset: 0x217860 VA: 0x180218460
	public void .ctor(Vector3 origin, Vector3 direction) { }

	// RVA: 0x211FC0 Offset: 0x2113C0 VA: 0x180211FC0
	public Vector3 get_origin() { }

	// RVA: 0x204B60 Offset: 0x203F60 VA: 0x180204B60
	public void set_origin(Vector3 value) { }

	// RVA: 0x211FE0 Offset: 0x2113E0 VA: 0x180211FE0
	public Vector3 get_direction() { }

	// RVA: 0x2184C0 Offset: 0x2178C0 VA: 0x1802184C0
	public void set_direction(Vector3 value) { }

	// RVA: 0x2181E0 Offset: 0x2175E0 VA: 0x1802181E0
	public Vector3 GetPoint(float distance) { }

	// RVA: 0x2182F0 Offset: 0x2176F0 VA: 0x1802182F0 Slot: 3
	public override string ToString() { }

}

