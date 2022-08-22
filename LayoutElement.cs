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

	// RVA: 0x95FFF0 Offset: 0x95E5F0 VA: 0x18095FFF0 Slot: 27
	public virtual bool get_ignoreLayout() { }

	// RVA: 0x170A0E0 Offset: 0x17086E0 VA: 0x18170A0E0 Slot: 28
	public virtual void set_ignoreLayout(bool value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 29
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 30
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x7746E0 Offset: 0x772CE0 VA: 0x1807746E0 Slot: 31
	public virtual float get_minWidth() { }

	// RVA: 0x170A200 Offset: 0x1708800 VA: 0x18170A200 Slot: 32
	public virtual void set_minWidth(float value) { }

	// RVA: 0x774700 Offset: 0x772D00 VA: 0x180774700 Slot: 33
	public virtual float get_minHeight() { }

	// RVA: 0x170A1A0 Offset: 0x17087A0 VA: 0x18170A1A0 Slot: 34
	public virtual void set_minHeight(float value) { }

	// RVA: 0x79B800 Offset: 0x799E00 VA: 0x18079B800 Slot: 35
	public virtual float get_preferredWidth() { }

	// RVA: 0x170A2C0 Offset: 0x17088C0 VA: 0x18170A2C0 Slot: 36
	public virtual void set_preferredWidth(float value) { }

	// RVA: 0x87E290 Offset: 0x87C890 VA: 0x18087E290 Slot: 37
	public virtual float get_preferredHeight() { }

	// RVA: 0x170A260 Offset: 0x1708860 VA: 0x18170A260 Slot: 38
	public virtual void set_preferredHeight(float value) { }

	// RVA: 0x87E2F0 Offset: 0x87C8F0 VA: 0x18087E2F0 Slot: 39
	public virtual float get_flexibleWidth() { }

	// RVA: 0x170A080 Offset: 0x1708680 VA: 0x18170A080 Slot: 40
	public virtual void set_flexibleWidth(float value) { }

	// RVA: 0x6BB9D0 Offset: 0x6B9FD0 VA: 0x1806BB9D0 Slot: 41
	public virtual float get_flexibleHeight() { }

	// RVA: 0x170A020 Offset: 0x1708620 VA: 0x18170A020 Slot: 42
	public virtual void set_flexibleHeight(float value) { }

	// RVA: 0x5E2ED0 Offset: 0x5E14D0 VA: 0x1805E2ED0 Slot: 43
	public virtual int get_layoutPriority() { }

	// RVA: 0x170A140 Offset: 0x1708740 VA: 0x18170A140 Slot: 44
	public virtual void set_layoutPriority(int value) { }

	// RVA: 0x1709FE0 Offset: 0x17085E0 VA: 0x181709FE0
	protected void .ctor() { }

	// RVA: 0x1709F30 Offset: 0x1708530 VA: 0x181709F30 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1709F00 Offset: 0x1708500 VA: 0x181709F00 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1709F10 Offset: 0x1708510 VA: 0x181709F10 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1709F00 Offset: 0x1708500 VA: 0x181709F00 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1709F00 Offset: 0x1708500 VA: 0x181709F00 Slot: 11
	protected override void OnBeforeTransformParentChanged() { }

	// RVA: 0x1709F50 Offset: 0x1708550 VA: 0x181709F50
	protected void SetDirty() { }

}

