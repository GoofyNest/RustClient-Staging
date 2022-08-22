public class LayoutElement : UIBehaviour, ILayoutElement, ILayoutIgnorer // TypeDefIndex: 4976
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_IgnoreLayout; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_MinWidth; // 0x1C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_MinHeight; // 0x20
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_PreferredWidth; // 0x24
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_PreferredHeight; // 0x28
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_FlexibleWidth; // 0x2C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_FlexibleHeight; // 0x30
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int m_LayoutPriority; // 0x34

	// Properties
	public virtual bool ignoreLayout { get; set; }
	public virtual float minWidth { get; set; }
	public virtual float minHeight { get; set; }
	public virtual float preferredWidth { get; set; }
	public virtual float preferredHeight { get; set; }
	public virtual float flexibleWidth { get; set; }
	public virtual float flexibleHeight { get; set; }
	public virtual int layoutPriority { get; set; }

	// Methods

	// RVA: 0x95F9E0 Offset: 0x95DFE0 VA: 0x18095F9E0 Slot: 27
	public virtual bool get_ignoreLayout() { }

	// RVA: 0x17109D0 Offset: 0x170EFD0 VA: 0x1817109D0 Slot: 28
	public virtual void set_ignoreLayout(bool value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 29
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 30
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x774680 Offset: 0x772C80 VA: 0x180774680 Slot: 31
	public virtual float get_minWidth() { }

	// RVA: 0x1710AF0 Offset: 0x170F0F0 VA: 0x181710AF0 Slot: 32
	public virtual void set_minWidth(float value) { }

	// RVA: 0x7746A0 Offset: 0x772CA0 VA: 0x1807746A0 Slot: 33
	public virtual float get_minHeight() { }

	// RVA: 0x1710A90 Offset: 0x170F090 VA: 0x181710A90 Slot: 34
	public virtual void set_minHeight(float value) { }

	// RVA: 0x7D0460 Offset: 0x7CEA60 VA: 0x1807D0460 Slot: 35
	public virtual float get_preferredWidth() { }

	// RVA: 0x1710BB0 Offset: 0x170F1B0 VA: 0x181710BB0 Slot: 36
	public virtual void set_preferredWidth(float value) { }

	// RVA: 0x862A20 Offset: 0x861020 VA: 0x180862A20 Slot: 37
	public virtual float get_preferredHeight() { }

	// RVA: 0x1710B50 Offset: 0x170F150 VA: 0x181710B50 Slot: 38
	public virtual void set_preferredHeight(float value) { }

	// RVA: 0x862A80 Offset: 0x861080 VA: 0x180862A80 Slot: 39
	public virtual float get_flexibleWidth() { }

	// RVA: 0x1710970 Offset: 0x170EF70 VA: 0x181710970 Slot: 40
	public virtual void set_flexibleWidth(float value) { }

	// RVA: 0x6BB930 Offset: 0x6B9F30 VA: 0x1806BB930 Slot: 41
	public virtual float get_flexibleHeight() { }

	// RVA: 0x1710910 Offset: 0x170EF10 VA: 0x181710910 Slot: 42
	public virtual void set_flexibleHeight(float value) { }

	// RVA: 0x5E2F40 Offset: 0x5E1540 VA: 0x1805E2F40 Slot: 43
	public virtual int get_layoutPriority() { }

	// RVA: 0x1710A30 Offset: 0x170F030 VA: 0x181710A30 Slot: 44
	public virtual void set_layoutPriority(int value) { }

	// RVA: 0x17108D0 Offset: 0x170EED0 VA: 0x1817108D0
	protected void .ctor() { }

	// RVA: 0x1710820 Offset: 0x170EE20 VA: 0x181710820 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x17107F0 Offset: 0x170EDF0 VA: 0x1817107F0 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1710800 Offset: 0x170EE00 VA: 0x181710800 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x17107F0 Offset: 0x170EDF0 VA: 0x1817107F0 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x17107F0 Offset: 0x170EDF0 VA: 0x1817107F0 Slot: 11
	protected override void OnBeforeTransformParentChanged() { }

	// RVA: 0x1710840 Offset: 0x170EE40 VA: 0x181710840
	protected void SetDirty() { }

}

