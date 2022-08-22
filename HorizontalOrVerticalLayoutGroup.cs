public abstract class HorizontalOrVerticalLayoutGroup : LayoutGroup // TypeDefIndex: 4970
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected float m_Spacing; // 0x58
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected bool m_ChildForceExpandWidth; // 0x5C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected bool m_ChildForceExpandHeight; // 0x5D
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected bool m_ChildControlWidth; // 0x5E
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected bool m_ChildControlHeight; // 0x5F
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected bool m_ChildScaleWidth; // 0x60
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected bool m_ChildScaleHeight; // 0x61

	// Properties
	public float spacing { get; set; }
	public bool childForceExpandWidth { get; set; }
	public bool childForceExpandHeight { get; set; }
	public bool childControlWidth { get; set; }
	public bool childControlHeight { get; set; }
	public bool childScaleWidth { get; set; }
	public bool childScaleHeight { get; set; }

	// Methods

	// RVA: 0x574350 Offset: 0x572950 VA: 0x180574350
	public float get_spacing() { }

	// RVA: 0x15DF650 Offset: 0x15DDC50 VA: 0x1815DF650
	public void set_spacing(float value) { }

	// RVA: 0x15DF460 Offset: 0x15DDA60 VA: 0x1815DF460
	public bool get_childForceExpandWidth() { }

	// RVA: 0x15DF560 Offset: 0x15DDB60 VA: 0x1815DF560
	public void set_childForceExpandWidth(bool value) { }

	// RVA: 0x15DF450 Offset: 0x15DDA50 VA: 0x1815DF450
	public bool get_childForceExpandHeight() { }

	// RVA: 0x15DF510 Offset: 0x15DDB10 VA: 0x1815DF510
	public void set_childForceExpandHeight(bool value) { }

	// RVA: 0x15DF440 Offset: 0x15DDA40 VA: 0x1815DF440
	public bool get_childControlWidth() { }

	// RVA: 0x15DF4C0 Offset: 0x15DDAC0 VA: 0x1815DF4C0
	public void set_childControlWidth(bool value) { }

	// RVA: 0x15DF430 Offset: 0x15DDA30 VA: 0x1815DF430
	public bool get_childControlHeight() { }

	// RVA: 0x15DF470 Offset: 0x15DDA70 VA: 0x1815DF470
	public void set_childControlHeight(bool value) { }

	// RVA: 0xA4F780 Offset: 0xA4DD80 VA: 0x180A4F780
	public bool get_childScaleWidth() { }

	// RVA: 0x15DF600 Offset: 0x15DDC00 VA: 0x1815DF600
	public void set_childScaleWidth(bool value) { }

	// RVA: 0x1087220 Offset: 0x1085820 VA: 0x181087220
	public bool get_childScaleHeight() { }

	// RVA: 0x15DF5B0 Offset: 0x15DDBB0 VA: 0x1815DF5B0
	public void set_childScaleHeight(bool value) { }

	// RVA: 0x15DE680 Offset: 0x15DCC80 VA: 0x1815DE680
	protected void CalcAlongAxis(int axis, bool isVertical) { }

	// RVA: 0x15DEBD0 Offset: 0x15DD1D0 VA: 0x1815DEBD0
	protected void SetChildrenAlongAxis(int axis, bool isVertical) { }

	// RVA: 0x15DEAA0 Offset: 0x15DD0A0 VA: 0x1815DEAA0
	private void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible) { }

	// RVA: 0x15DE670 Offset: 0x15DCC70 VA: 0x1815DE670
	protected void .ctor() { }

}

