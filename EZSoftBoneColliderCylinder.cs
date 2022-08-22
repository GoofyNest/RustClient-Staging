public class EZSoftBoneColliderCylinder : EZSoftBoneColliderBase // TypeDefIndex: 7135
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_Margin; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_InsideMode; // 0x1C

	// Properties
	public float margin { get; set; }
	public bool insideMode { get; set; }

	// Methods

	// RVA: 0x774710 Offset: 0x772D10 VA: 0x180774710
	public float get_margin() { }

	// RVA: 0x774750 Offset: 0x772D50 VA: 0x180774750
	public void set_margin(float value) { }

	// RVA: 0x79C660 Offset: 0x79AC60 VA: 0x18079C660
	public bool get_insideMode() { }

	// RVA: 0x79C6D0 Offset: 0x79ACD0 VA: 0x18079C6D0
	public void set_insideMode(bool value) { }

	// RVA: 0x228FD70 Offset: 0x228E370 VA: 0x18228FD70 Slot: 6
	public override void Collide(ref Vector3 position, float spacing) { }

	// RVA: 0x22900B0 Offset: 0x228E6B0 VA: 0x1822900B0
	public void .ctor() { }

}

