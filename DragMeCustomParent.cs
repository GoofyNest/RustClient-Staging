public class DragMeCustomParent : DragMe // TypeDefIndex: 11273
{	// Fields
	public Canvas OverrideCanvas; // 0x20
	public bool ShouldCancelOnDrop; // 0x28

	// Properties
	protected override Canvas TopCanvas { get; }
	public override bool CancelOnDrop { get; }

	// Methods

	// RVA: 0xAAF9A0 Offset: 0xAADFA0 VA: 0x180AAF9A0 Slot: 9
	protected override Canvas get_TopCanvas() { }

	// RVA: 0xAAF7B0 Offset: 0xAADDB0 VA: 0x180AAF7B0 Slot: 8
	protected override GameObject CreateDragObject(Canvas topCanvas, IDraggable dragInfo) { }

	// RVA: 0x9974E0 Offset: 0x995AE0 VA: 0x1809974E0 Slot: 12
	public override bool get_CancelOnDrop() { }

	// RVA: 0xAAF950 Offset: 0xAADF50 VA: 0x180AAF950
	public void .ctor() { }

}

