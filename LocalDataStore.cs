internal sealed class LocalDataStore // TypeDefIndex: 146
{	// Fields
	private LocalDataStoreElement[] m_DataTable; // 0x10
	private LocalDataStoreMgr m_Manager; // 0x18

	// Methods

	// RVA: 0x1672630 Offset: 0x1670C30 VA: 0x181672630
	public void .ctor(LocalDataStoreMgr mgr, int InitialCapacity) { }

	// RVA: 0x1672030 Offset: 0x1670630 VA: 0x181672030
	internal void Dispose() { }

	// RVA: 0x16720C0 Offset: 0x16706C0 VA: 0x1816720C0
	public object GetData(LocalDataStoreSlot slot) { }

	// RVA: 0x16724C0 Offset: 0x1670AC0 VA: 0x1816724C0
	public void SetData(LocalDataStoreSlot slot, object data) { }

	// RVA: 0x1672060 Offset: 0x1670660 VA: 0x181672060
	internal void FreeData(int slot, long cookie) { }

	// RVA: 0x1672210 Offset: 0x1670810 VA: 0x181672210
	private LocalDataStoreElement PopulateElement(LocalDataStoreSlot slot) { }

}

