internal sealed class LocalDataStore // TypeDefIndex: 146
{	// Fields
	private LocalDataStoreElement[] m_DataTable; // 0x10
	private LocalDataStoreMgr m_Manager; // 0x18

	// Methods

	// RVA: 0x1674780 Offset: 0x1672D80 VA: 0x181674780
	public void .ctor(LocalDataStoreMgr mgr, int InitialCapacity) { }

	// RVA: 0x1674180 Offset: 0x1672780 VA: 0x181674180
	internal void Dispose() { }

	// RVA: 0x1674210 Offset: 0x1672810 VA: 0x181674210
	public object GetData(LocalDataStoreSlot slot) { }

	// RVA: 0x1674610 Offset: 0x1672C10 VA: 0x181674610
	public void SetData(LocalDataStoreSlot slot, object data) { }

	// RVA: 0x16741B0 Offset: 0x16727B0 VA: 0x1816741B0
	internal void FreeData(int slot, long cookie) { }

	// RVA: 0x1674360 Offset: 0x1672960 VA: 0x181674360
	private LocalDataStoreElement PopulateElement(LocalDataStoreSlot slot) { }

}

