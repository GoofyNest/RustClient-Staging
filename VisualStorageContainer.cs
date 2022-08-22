public class VisualStorageContainer : LootContainer // TypeDefIndex: 9615
{	// Fields
	public VisualStorageContainerNode[] displayNodes; // 0x418
	public VisualStorageContainer.DisplayModel[] displayModels; // 0x420
	public Transform nodeParent; // 0x428
	public GameObject defaultDisplayModel; // 0x430

	// Methods

	// RVA: 0x7FE0D0 Offset: 0x7FC6D0 VA: 0x1807FE0D0
	public void ClearRigidBodies() { }

	// RVA: 0x7FE280 Offset: 0x7FC880 VA: 0x1807FE280
	public void SetItemsVisible(bool vis) { }

	// RVA: 0x7FE1A0 Offset: 0x7FC7A0 VA: 0x1807FE1A0
	public void ItemUpdateComplete() { }

	// RVA: 0x7FE4A0 Offset: 0x7FCAA0 VA: 0x1807FE4A0
	public void UpdateVisibleItems(ItemContainer msg) { }

	// RVA: 0x754DD0 Offset: 0x7533D0 VA: 0x180754DD0
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

