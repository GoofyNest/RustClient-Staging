public class EZSoftBoneColliderCylinder : EZSoftBoneColliderBase // TypeDefIndex: 7135
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float m_Margin; // 0x18
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_InsideMode; // 0x1C

	// Properties
	public float margin { get; set; }
	public bool insideMode { get; set; }

	// Methods

	// RVA: 0x7746B0 Offset: 0x772CB0 VA: 0x1807746B0
	public float get_margin() { }

	// RVA: 0x7746F0 Offset: 0x772CF0 VA: 0x1807746F0
	public void set_margin(float value) { }

	// RVA: 0x7D0C30 Offset: 0x7CF230 VA: 0x1807D0C30
	public bool get_insideMode() { }

	// RVA: 0x7D0CA0 Offset: 0x7CF2A0 VA: 0x1807D0CA0
	public void set_insideMode(bool value) { }

	// RVA: 0x228F450 Offset: 0x228DA50 VA: 0x18228F450 Slot: 6
	public override void Collide(ref Vector3 position, float spacing) { }

	// RVA: 0x228F790 Offset: 0x228DD90 VA: 0x18228F790
	public void .ctor() { }

}

