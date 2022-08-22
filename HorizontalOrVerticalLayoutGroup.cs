public abstract class HorizontalOrVerticalLayoutGroup : LayoutGroup // TypeDefIndex: 4970
{	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	public float spacing { get; set; }
	public bool childForceExpandWidth { get; set; }
	public bool childForceExpandHeight { get; set; }
	public bool childControlWidth { get; set; }
	public bool childControlHeight { get; set; }
	public bool childScaleWidth { get; set; }
	public bool childScaleHeight { get; set; }


	public float get_spacing() { }

	public void set_spacing(float value) { }

	public bool get_childForceExpandWidth() { }

	public void set_childForceExpandWidth(bool value) { }

	public bool get_childForceExpandHeight() { }

	public void set_childForceExpandHeight(bool value) { }

	public bool get_childControlWidth() { }

	public void set_childControlWidth(bool value) { }

	public bool get_childControlHeight() { }

	public void set_childControlHeight(bool value) { }

	public bool get_childScaleWidth() { }

	public void set_childScaleWidth(bool value) { }

	public bool get_childScaleHeight() { }

	public void set_childScaleHeight(bool value) { }

	protected void CalcAlongAxis(int axis, bool isVertical) { }

	protected void SetChildrenAlongAxis(int axis, bool isVertical) { }

	private void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible) { }

	protected void .ctor() { }

}

