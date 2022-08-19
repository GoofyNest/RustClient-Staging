public struct Ray // TypeDefIndex: 3375
{	// Fields
	private Vector3 m_Origin; // 0x0
	private Vector3 m_Direction; // 0xC

	// Properties
	public Vector3 origin { get; set; }
	public Vector3 direction { get; set; }

	// Methods

	// RVA: 0x217E10 Offset: 0x217210 VA: 0x180217E10
	public void .ctor(Vector3 origin, Vector3 direction) { }

	// RVA: 0x212C10 Offset: 0x212010 VA: 0x180212C10
	public Vector3 get_origin() { }

	// RVA: 0x204FB0 Offset: 0x2043B0 VA: 0x180204FB0
	public void set_origin(Vector3 value) { }

	// RVA: 0x212C30 Offset: 0x212030 VA: 0x180212C30
	public Vector3 get_direction() { }

	// RVA: 0x217E70 Offset: 0x217270 VA: 0x180217E70
	public void set_direction(Vector3 value) { }

	// RVA: 0x217B90 Offset: 0x216F90 VA: 0x180217B90
	public Vector3 GetPoint(float distance) { }

	// RVA: 0x217CA0 Offset: 0x2170A0 VA: 0x180217CA0 Slot: 3
	public override string ToString() { }

}

