public struct Ray // TypeDefIndex: 3375
{	// Fields
	private Vector3 m_Origin; // 0x0
	private Vector3 m_Direction; // 0xC

	// Properties
	public Vector3 origin { get; set; }
	public Vector3 direction { get; set; }

	// Methods

	// RVA: 0x217D90 Offset: 0x217190 VA: 0x180217D90
	public void .ctor(Vector3 origin, Vector3 direction) { }

	// RVA: 0x212B90 Offset: 0x211F90 VA: 0x180212B90
	public Vector3 get_origin() { }

	// RVA: 0x204F30 Offset: 0x204330 VA: 0x180204F30
	public void set_origin(Vector3 value) { }

	// RVA: 0x212BB0 Offset: 0x211FB0 VA: 0x180212BB0
	public Vector3 get_direction() { }

	// RVA: 0x217DF0 Offset: 0x2171F0 VA: 0x180217DF0
	public void set_direction(Vector3 value) { }

	// RVA: 0x217B10 Offset: 0x216F10 VA: 0x180217B10
	public Vector3 GetPoint(float distance) { }

	// RVA: 0x217C20 Offset: 0x217020 VA: 0x180217C20 Slot: 3
	public override string ToString() { }

}

