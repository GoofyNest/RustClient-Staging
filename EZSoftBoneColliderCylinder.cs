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

	// RVA: 0x7747C0 Offset: 0x772DC0 VA: 0x1807747C0
	public float get_margin() { }

	// RVA: 0x774800 Offset: 0x772E00 VA: 0x180774800
	public void set_margin(float value) { }

	// RVA: 0x7D0D40 Offset: 0x7CF340 VA: 0x1807D0D40
	public bool get_insideMode() { }

	// RVA: 0x7D0DB0 Offset: 0x7CF3B0 VA: 0x1807D0DB0
	public void set_insideMode(bool value) { }

	// RVA: 0x228F550 Offset: 0x228DB50 VA: 0x18228F550 Slot: 6
	public override void Collide(ref Vector3 position, float spacing) { }

	// RVA: 0x228F890 Offset: 0x228DE90 VA: 0x18228F890
	public void .ctor() { }

}

