public class RustLayout : UIBehaviour, ILayoutGroup, ILayoutController, IAutoLayout // TypeDefIndex: 7023
{	// Fields
	public RustLayout.LayoutMode Mode; // 0x18
	public bool ReverseOrder; // 0x1C
	public float Spacing; // 0x20
	public RectOffset Padding; // 0x28
	[FormerlySerializedAsAttribute] // RVA: 0x716C0 Offset: 0x70AC0 VA: 0x1800716C0
	[TooltipAttribute] // RVA: 0x716C0 Offset: 0x70AC0 VA: 0x1800716C0
	public bool ChildrenFill; // 0x30
	[FormerlySerializedAsAttribute] // RVA: 0x718C0 Offset: 0x70CC0 VA: 0x1800718C0
	[TooltipAttribute] // RVA: 0x718C0 Offset: 0x70CC0 VA: 0x1800718C0
	public bool ResizeToChildren; // 0x31
	[TooltipAttribute] // RVA: 0x71A30 Offset: 0x70E30 VA: 0x180071A30
	public bool ResizeToChildrenOpposite; // 0x32
	public RectTransform[] IgnoreLayout; // 0x38
	public int MaxHeight; // 0x40
	[TooltipAttribute] // RVA: 0x71B10 Offset: 0x70F10 VA: 0x180071B10
	public RustLayout ParentLayout; // 0x48
	private bool doingLayout; // 0x50
	private bool changedSize; // 0x51

	// Methods

	// RVA: 0xFCDEA0 Offset: 0xFCC4A0 VA: 0x180FCDEA0 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFCF430 Offset: 0xFCDA30 VA: 0x180FCF430 Slot: 20
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0xFCF430 Offset: 0xFCDA30 VA: 0x180FCF430 Slot: 21
	public virtual void SetLayoutVertical() { }

	// RVA: 0xFCE740 Offset: 0xFCCD40 VA: 0x180FCE740 Slot: 22
	public virtual void DoLayout() { }

	// RVA: 0xFCF2C0 Offset: 0xFCD8C0 VA: 0x180FCF2C0 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0xFCDEC0 Offset: 0xFCC4C0 VA: 0x180FCDEC0
	private void DoHorizontalLayout(RectTransform.Edge edge) { }

	// RVA: 0xFCE8B0 Offset: 0xFCCEB0 VA: 0x180FCE8B0
	private void DoTopLayout(RectTransform.Edge edge) { }

	// RVA: 0xFCF1C0 Offset: 0xFCD7C0 VA: 0x180FCF1C0
	private bool Ignoring(RectTransform child) { }

	// RVA: 0xFCF3A0 Offset: 0xFCD9A0 VA: 0x180FCF3A0
	protected void SetDirty() { }

	// RVA: 0xFCF290 Offset: 0xFCD890 VA: 0x180FCF290 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0xFCF2B0 Offset: 0xFCD8B0 VA: 0x180FCF2B0 Slot: 23
	protected virtual void OnTransformChildrenChanged() { }

	// RVA: 0x4BAE40 Offset: 0x4B9440 VA: 0x1804BAE40
	public void .ctor() { }

}

public enum RustLayout.LayoutMode // TypeDefIndex: 7024
{	// Fields
	public int value__; // 0x0
	public const RustLayout.LayoutMode Top = 0;
	public const RustLayout.LayoutMode Left = 1;
	public const RustLayout.LayoutMode Right = 2;
	public const RustLayout.LayoutMode Bottom = 3;

}

