public class DragMeCustomParent : DragMe // TypeDefIndex: 11273
{	// Fields
	public Canvas OverrideCanvas; // 0x20
	public bool ShouldCancelOnDrop; // 0x28

	// Properties
	protected override Canvas TopCanvas { get; }
	public override bool CancelOnDrop { get; }

	// Methods

	// RVA: 0xAAFC60 Offset: 0xAAE260 VA: 0x180AAFC60 Slot: 9
	protected override Canvas get_TopCanvas() { }

	// RVA: 0xAAFA70 Offset: 0xAAE070 VA: 0x180AAFA70 Slot: 8
	protected override GameObject CreateDragObject(Canvas topCanvas, IDraggable dragInfo) { }

	// RVA: 0x9975F0 Offset: 0x995BF0 VA: 0x1809975F0 Slot: 12
	public override bool get_CancelOnDrop() { }

	// RVA: 0xAAFC10 Offset: 0xAAE210 VA: 0x180AAFC10
	public void .ctor() { }

}

