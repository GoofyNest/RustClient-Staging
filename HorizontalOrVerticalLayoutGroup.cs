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

	// RVA: 0x15F2070 Offset: 0x15F0670 VA: 0x1815F2070
	public void set_spacing(float value) { }

	// RVA: 0x15F1E80 Offset: 0x15F0480 VA: 0x1815F1E80
	public bool get_childForceExpandWidth() { }

	// RVA: 0x15F1F80 Offset: 0x15F0580 VA: 0x1815F1F80
	public void set_childForceExpandWidth(bool value) { }

	// RVA: 0x15F1E70 Offset: 0x15F0470 VA: 0x1815F1E70
	public bool get_childForceExpandHeight() { }

	// RVA: 0x15F1F30 Offset: 0x15F0530 VA: 0x1815F1F30
	public void set_childForceExpandHeight(bool value) { }

	// RVA: 0x15F1E60 Offset: 0x15F0460 VA: 0x1815F1E60
	public bool get_childControlWidth() { }

	// RVA: 0x15F1EE0 Offset: 0x15F04E0 VA: 0x1815F1EE0
	public void set_childControlWidth(bool value) { }

	// RVA: 0x15F1E50 Offset: 0x15F0450 VA: 0x1815F1E50
	public bool get_childControlHeight() { }

	// RVA: 0x15F1E90 Offset: 0x15F0490 VA: 0x1815F1E90
	public void set_childControlHeight(bool value) { }

	// RVA: 0xA4EFF0 Offset: 0xA4D5F0 VA: 0x180A4EFF0
	public bool get_childScaleWidth() { }

	// RVA: 0x15F2020 Offset: 0x15F0620 VA: 0x1815F2020
	public void set_childScaleWidth(bool value) { }

	// RVA: 0x10864F0 Offset: 0x1084AF0 VA: 0x1810864F0
	public bool get_childScaleHeight() { }

	// RVA: 0x15F1FD0 Offset: 0x15F05D0 VA: 0x1815F1FD0
	public void set_childScaleHeight(bool value) { }

	// RVA: 0x15F10A0 Offset: 0x15EF6A0 VA: 0x1815F10A0
	protected void CalcAlongAxis(int axis, bool isVertical) { }

	// RVA: 0x15F15F0 Offset: 0x15EFBF0 VA: 0x1815F15F0
	protected void SetChildrenAlongAxis(int axis, bool isVertical) { }

	// RVA: 0x15F14C0 Offset: 0x15EFAC0 VA: 0x1815F14C0
	private void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible) { }

	// RVA: 0x15F1090 Offset: 0x15EF690 VA: 0x1815F1090
	protected void .ctor() { }

}

