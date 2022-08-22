public class DragMeCustomParent : DragMe // TypeDefIndex: 11273
{	// Fields
	public Canvas OverrideCanvas; // 0x20
	public bool ShouldCancelOnDrop; // 0x28

	// Properties
	protected override Canvas TopCanvas { get; }
	public override bool CancelOnDrop { get; }

	// Methods

	// RVA: 0xAB0130 Offset: 0xAAE730 VA: 0x180AB0130 Slot: 9
	protected override Canvas get_TopCanvas() { }

	// RVA: 0xAAFF40 Offset: 0xAAE540 VA: 0x180AAFF40 Slot: 8
	protected override GameObject CreateDragObject(Canvas topCanvas, IDraggable dragInfo) { }

	// RVA: 0x997AE0 Offset: 0x9960E0 VA: 0x180997AE0 Slot: 12
	public override bool get_CancelOnDrop() { }

	// RVA: 0xAB00E0 Offset: 0xAAE6E0 VA: 0x180AB00E0
	public void .ctor() { }

}

