public class RustLayout : UIBehaviour, ILayoutGroup, ILayoutController, IAutoLayout // TypeDefIndex: 7023
{	// Fields
	public RustLayout.LayoutMode Mode; // 0x18
	public bool ReverseOrder; // 0x1C
	public float Spacing; // 0x20
	public RectOffset Padding; // 0x28
	[FormerlySerializedAsAttribute] // RVA: 0x715F0 Offset: 0x709F0 VA: 0x1800715F0
	[TooltipAttribute] // RVA: 0x715F0 Offset: 0x709F0 VA: 0x1800715F0
	public bool ChildrenFill; // 0x30
	[FormerlySerializedAsAttribute] // RVA: 0x717C0 Offset: 0x70BC0 VA: 0x1800717C0
	[TooltipAttribute] // RVA: 0x717C0 Offset: 0x70BC0 VA: 0x1800717C0
	public bool ResizeToChildren; // 0x31
	[TooltipAttribute] // RVA: 0x71960 Offset: 0x70D60 VA: 0x180071960
	public bool ResizeToChildrenOpposite; // 0x32
	public RectTransform[] IgnoreLayout; // 0x38
	public int MaxHeight; // 0x40
	[TooltipAttribute] // RVA: 0x71AC0 Offset: 0x70EC0 VA: 0x180071AC0
	public RustLayout ParentLayout; // 0x48
	private bool doingLayout; // 0x50
	private bool changedSize; // 0x51

	// Methods

	// RVA: 0xFCD140 Offset: 0xFCB740 VA: 0x180FCD140 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFCE6D0 Offset: 0xFCCCD0 VA: 0x180FCE6D0 Slot: 20
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0xFCE6D0 Offset: 0xFCCCD0 VA: 0x180FCE6D0 Slot: 21
	public virtual void SetLayoutVertical() { }

	// RVA: 0xFCD9E0 Offset: 0xFCBFE0 VA: 0x180FCD9E0 Slot: 22
	public virtual void DoLayout() { }

	// RVA: 0xFCE560 Offset: 0xFCCB60 VA: 0x180FCE560 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0xFCD160 Offset: 0xFCB760 VA: 0x180FCD160
	private void DoHorizontalLayout(RectTransform.Edge edge) { }

	// RVA: 0xFCDB50 Offset: 0xFCC150 VA: 0x180FCDB50
	private void DoTopLayout(RectTransform.Edge edge) { }

	// RVA: 0xFCE460 Offset: 0xFCCA60 VA: 0x180FCE460
	private bool Ignoring(RectTransform child) { }

	// RVA: 0xFCE640 Offset: 0xFCCC40 VA: 0x180FCE640
	protected void SetDirty() { }

	// RVA: 0xFCE530 Offset: 0xFCCB30 VA: 0x180FCE530 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0xFCE550 Offset: 0xFCCB50 VA: 0x180FCE550 Slot: 23
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

