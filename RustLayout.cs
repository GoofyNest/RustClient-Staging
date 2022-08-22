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

	// RVA: 0xFCD400 Offset: 0xFCBA00 VA: 0x180FCD400 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFCE990 Offset: 0xFCCF90 VA: 0x180FCE990 Slot: 20
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0xFCE990 Offset: 0xFCCF90 VA: 0x180FCE990 Slot: 21
	public virtual void SetLayoutVertical() { }

	// RVA: 0xFCDCA0 Offset: 0xFCC2A0 VA: 0x180FCDCA0 Slot: 22
	public virtual void DoLayout() { }

	// RVA: 0xFCE820 Offset: 0xFCCE20 VA: 0x180FCE820 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0xFCD420 Offset: 0xFCBA20 VA: 0x180FCD420
	private void DoHorizontalLayout(RectTransform.Edge edge) { }

	// RVA: 0xFCDE10 Offset: 0xFCC410 VA: 0x180FCDE10
	private void DoTopLayout(RectTransform.Edge edge) { }

	// RVA: 0xFCE720 Offset: 0xFCCD20 VA: 0x180FCE720
	private bool Ignoring(RectTransform child) { }

	// RVA: 0xFCE900 Offset: 0xFCCF00 VA: 0x180FCE900
	protected void SetDirty() { }

	// RVA: 0xFCE7F0 Offset: 0xFCCDF0 VA: 0x180FCE7F0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0xFCE810 Offset: 0xFCCE10 VA: 0x180FCE810 Slot: 23
	protected virtual void OnTransformChildrenChanged() { }

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
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

