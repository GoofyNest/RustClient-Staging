internal sealed class LocalDataStoreMgr // TypeDefIndex: 148
{	// Fields
	private bool[] m_SlotInfoTable; // 0x10
	private int m_FirstAvailableSlot; // 0x18
	private List<LocalDataStore> m_ManagedLocalDataStores; // 0x20
	private Dictionary<string, LocalDataStoreSlot> m_KeyToSlotMap; // 0x28
	private long m_CookieGenerator; // 0x30

	// Methods

	// RVA: 0x1673930 Offset: 0x1671F30 VA: 0x181673930
	public LocalDataStoreHolder CreateLocalDataStore() { }

	// RVA: 0x1673AB0 Offset: 0x16720B0 VA: 0x181673AB0
	public void DeleteLocalDataStore(LocalDataStore store) { }

	// RVA: 0x1673600 Offset: 0x1671C00 VA: 0x181673600
	public LocalDataStoreSlot AllocateDataSlot() { }

	// RVA: 0x1673820 Offset: 0x1671E20 VA: 0x181673820
	public LocalDataStoreSlot AllocateNamedDataSlot(string name) { }

	// RVA: 0x1673E50 Offset: 0x1672450 VA: 0x181673E50
	public LocalDataStoreSlot GetNamedDataSlot(string name) { }

	// RVA: 0x1673D60 Offset: 0x1672360 VA: 0x181673D60
	public void FreeNamedDataSlot(string name) { }

	// RVA: 0x1673BA0 Offset: 0x16721A0 VA: 0x181673BA0
	internal void FreeDataSlot(int slot, long cookie) { }

	// RVA: 0x1673F70 Offset: 0x1672570 VA: 0x181673F70
	public void ValidateSlot(LocalDataStoreSlot slot) { }

	// RVA: 0x9EB580 Offset: 0x9E9B80 VA: 0x1809EB580
	internal int GetSlotTableLength() { }

	// RVA: 0x1673FF0 Offset: 0x16725F0 VA: 0x181673FF0
	public void .ctor() { }

}

