public class VisualStorageContainer : LootContainer // TypeDefIndex: 9615
{	// Fields
	public VisualStorageContainerNode[] displayNodes; // 0x418
	public VisualStorageContainer.DisplayModel[] displayModels; // 0x420
	public Transform nodeParent; // 0x428
	public GameObject defaultDisplayModel; // 0x430

	// Methods

	// RVA: 0x7FDB40 Offset: 0x7FC140 VA: 0x1807FDB40
	public void ClearRigidBodies() { }

	// RVA: 0x7FDCF0 Offset: 0x7FC2F0 VA: 0x1807FDCF0
	public void SetItemsVisible(bool vis) { }

	// RVA: 0x7FDC10 Offset: 0x7FC210 VA: 0x1807FDC10
	public void ItemUpdateComplete() { }

	// RVA: 0x7FDF10 Offset: 0x7FC510 VA: 0x1807FDF10
	public void UpdateVisibleItems(ItemContainer msg) { }

	// RVA: 0x754E80 Offset: 0x753480 VA: 0x180754E80
	public void .ctor() { }

}

public class VisualStorageContainer.DisplayModel // TypeDefIndex: 9616
{	// Fields
	public GameObject displayModel; // 0x10
	public ItemDefinition def; // 0x18
	public int slot; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

