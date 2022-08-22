internal sealed class LocalDataStore // TypeDefIndex: 146
{	// Fields
	private LocalDataStoreElement[] m_DataTable; // 0x10
	private LocalDataStoreMgr m_Manager; // 0x18

	// Methods

	// RVA: 0x1674A40 Offset: 0x1673040 VA: 0x181674A40
	public void .ctor(LocalDataStoreMgr mgr, int InitialCapacity) { }

	// RVA: 0x1674440 Offset: 0x1672A40 VA: 0x181674440
	internal void Dispose() { }

	// RVA: 0x16744D0 Offset: 0x1672AD0 VA: 0x1816744D0
	public object GetData(LocalDataStoreSlot slot) { }

	// RVA: 0x16748D0 Offset: 0x1672ED0 VA: 0x1816748D0
	public void SetData(LocalDataStoreSlot slot, object data) { }

	// RVA: 0x1674470 Offset: 0x1672A70 VA: 0x181674470
	internal void FreeData(int slot, long cookie) { }

	// RVA: 0x1674620 Offset: 0x1672C20 VA: 0x181674620
	private LocalDataStoreElement PopulateElement(LocalDataStoreSlot slot) { }

}

