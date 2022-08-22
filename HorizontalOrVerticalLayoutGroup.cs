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

	// RVA: 0x5743C0 Offset: 0x5729C0 VA: 0x1805743C0
	public float get_spacing() { }

	// RVA: 0x15F2330 Offset: 0x15F0930 VA: 0x1815F2330
	public void set_spacing(float value) { }

	// RVA: 0x15F2140 Offset: 0x15F0740 VA: 0x1815F2140
	public bool get_childForceExpandWidth() { }

	// RVA: 0x15F2240 Offset: 0x15F0840 VA: 0x1815F2240
	public void set_childForceExpandWidth(bool value) { }

	// RVA: 0x15F2130 Offset: 0x15F0730 VA: 0x1815F2130
	public bool get_childForceExpandHeight() { }

	// RVA: 0x15F21F0 Offset: 0x15F07F0 VA: 0x1815F21F0
	public void set_childForceExpandHeight(bool value) { }

	// RVA: 0x15F2120 Offset: 0x15F0720 VA: 0x1815F2120
	public bool get_childControlWidth() { }

	// RVA: 0x15F21A0 Offset: 0x15F07A0 VA: 0x1815F21A0
	public void set_childControlWidth(bool value) { }

	// RVA: 0x15F2110 Offset: 0x15F0710 VA: 0x1815F2110
	public bool get_childControlHeight() { }

	// RVA: 0x15F2150 Offset: 0x15F0750 VA: 0x1815F2150
	public void set_childControlHeight(bool value) { }

	// RVA: 0xA4F2B0 Offset: 0xA4D8B0 VA: 0x180A4F2B0
	public bool get_childScaleWidth() { }

	// RVA: 0x15F22E0 Offset: 0x15F08E0 VA: 0x1815F22E0
	public void set_childScaleWidth(bool value) { }

	// RVA: 0x10867B0 Offset: 0x1084DB0 VA: 0x1810867B0
	public bool get_childScaleHeight() { }

	// RVA: 0x15F2290 Offset: 0x15F0890 VA: 0x1815F2290
	public void set_childScaleHeight(bool value) { }

	// RVA: 0x15F1360 Offset: 0x15EF960 VA: 0x1815F1360
	protected void CalcAlongAxis(int axis, bool isVertical) { }

	// RVA: 0x15F18B0 Offset: 0x15EFEB0 VA: 0x1815F18B0
	protected void SetChildrenAlongAxis(int axis, bool isVertical) { }

	// RVA: 0x15F1780 Offset: 0x15EFD80 VA: 0x1815F1780
	private void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible) { }

	// RVA: 0x15F1350 Offset: 0x15EF950 VA: 0x1815F1350
	protected void .ctor() { }

}

