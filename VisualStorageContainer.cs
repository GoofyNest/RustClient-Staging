public class VisualStorageContainer : LootContainer // TypeDefIndex: 9615
{	// Fields
	public VisualStorageContainerNode[] displayNodes; // 0x418
	public VisualStorageContainer.DisplayModel[] displayModels; // 0x420
	public Transform nodeParent; // 0x428
	public GameObject defaultDisplayModel; // 0x430

	// Methods

	// RVA: 0x7FDA30 Offset: 0x7FC030 VA: 0x1807FDA30
	public void ClearRigidBodies() { }

	// RVA: 0x7FDBE0 Offset: 0x7FC1E0 VA: 0x1807FDBE0
	public void SetItemsVisible(bool vis) { }

	// RVA: 0x7FDB00 Offset: 0x7FC100 VA: 0x1807FDB00
	public void ItemUpdateComplete() { }

	// RVA: 0x7FDE00 Offset: 0x7FC400 VA: 0x1807FDE00
	public void UpdateVisibleItems(ItemContainer msg) { }

	// RVA: 0x754D70 Offset: 0x753370 VA: 0x180754D70
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

