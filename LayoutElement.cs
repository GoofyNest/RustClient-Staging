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

	// RVA: 0x95FAF0 Offset: 0x95E0F0 VA: 0x18095FAF0 Slot: 27
	public virtual bool get_ignoreLayout() { }

	// RVA: 0x1710C90 Offset: 0x170F290 VA: 0x181710C90 Slot: 28
	public virtual void set_ignoreLayout(bool value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 29
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 30
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x774790 Offset: 0x772D90 VA: 0x180774790 Slot: 31
	public virtual float get_minWidth() { }

	// RVA: 0x1710DB0 Offset: 0x170F3B0 VA: 0x181710DB0 Slot: 32
	public virtual void set_minWidth(float value) { }

	// RVA: 0x7747B0 Offset: 0x772DB0 VA: 0x1807747B0 Slot: 33
	public virtual float get_minHeight() { }

	// RVA: 0x1710D50 Offset: 0x170F350 VA: 0x181710D50 Slot: 34
	public virtual void set_minHeight(float value) { }

	// RVA: 0x7D0570 Offset: 0x7CEB70 VA: 0x1807D0570 Slot: 35
	public virtual float get_preferredWidth() { }

	// RVA: 0x1710E70 Offset: 0x170F470 VA: 0x181710E70 Slot: 36
	public virtual void set_preferredWidth(float value) { }

	// RVA: 0x862B30 Offset: 0x861130 VA: 0x180862B30 Slot: 37
	public virtual float get_preferredHeight() { }

	// RVA: 0x1710E10 Offset: 0x170F410 VA: 0x181710E10 Slot: 38
	public virtual void set_preferredHeight(float value) { }

	// RVA: 0x862B90 Offset: 0x861190 VA: 0x180862B90 Slot: 39
	public virtual float get_flexibleWidth() { }

	// RVA: 0x1710C30 Offset: 0x170F230 VA: 0x181710C30 Slot: 40
	public virtual void set_flexibleWidth(float value) { }

	// RVA: 0x6BBA40 Offset: 0x6BA040 VA: 0x1806BBA40 Slot: 41
	public virtual float get_flexibleHeight() { }

	// RVA: 0x1710BD0 Offset: 0x170F1D0 VA: 0x181710BD0 Slot: 42
	public virtual void set_flexibleHeight(float value) { }

	// RVA: 0x5E2F40 Offset: 0x5E1540 VA: 0x1805E2F40 Slot: 43
	public virtual int get_layoutPriority() { }

	// RVA: 0x1710CF0 Offset: 0x170F2F0 VA: 0x181710CF0 Slot: 44
	public virtual void set_layoutPriority(int value) { }

	// RVA: 0x1710B90 Offset: 0x170F190 VA: 0x181710B90
	protected void .ctor() { }

	// RVA: 0x1710AE0 Offset: 0x170F0E0 VA: 0x181710AE0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1710AB0 Offset: 0x170F0B0 VA: 0x181710AB0 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1710AC0 Offset: 0x170F0C0 VA: 0x181710AC0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1710AB0 Offset: 0x170F0B0 VA: 0x181710AB0 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1710AB0 Offset: 0x170F0B0 VA: 0x181710AB0 Slot: 11
	protected override void OnBeforeTransformParentChanged() { }

	// RVA: 0x1710B00 Offset: 0x170F100 VA: 0x181710B00
	protected void SetDirty() { }

}

