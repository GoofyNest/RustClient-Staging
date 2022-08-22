internal sealed class LocalDataStoreMgr // TypeDefIndex: 148
{	// Fields
	private bool[] m_SlotInfoTable; // 0x10
	private int m_FirstAvailableSlot; // 0x18
	private List<LocalDataStore> m_ManagedLocalDataStores; // 0x20
	private Dictionary<string, LocalDataStoreSlot> m_KeyToSlotMap; // 0x28
	private long m_CookieGenerator; // 0x30

	// Methods

	// RVA: 0x1673BF0 Offset: 0x16721F0 VA: 0x181673BF0
	public LocalDataStoreHolder CreateLocalDataStore() { }

	// RVA: 0x1673D70 Offset: 0x1672370 VA: 0x181673D70
	public void DeleteLocalDataStore(LocalDataStore store) { }

	// RVA: 0x16738C0 Offset: 0x1671EC0 VA: 0x1816738C0
	public LocalDataStoreSlot AllocateDataSlot() { }

	// RVA: 0x1673AE0 Offset: 0x16720E0 VA: 0x181673AE0
	public LocalDataStoreSlot AllocateNamedDataSlot(string name) { }

	// RVA: 0x1674110 Offset: 0x1672710 VA: 0x181674110
	public LocalDataStoreSlot GetNamedDataSlot(string name) { }

	// RVA: 0x1674020 Offset: 0x1672620 VA: 0x181674020
	public void FreeNamedDataSlot(string name) { }

	// RVA: 0x1673E60 Offset: 0x1672460 VA: 0x181673E60
	internal void FreeDataSlot(int slot, long cookie) { }

	// RVA: 0x1674230 Offset: 0x1672830 VA: 0x181674230
	public void ValidateSlot(LocalDataStoreSlot slot) { }

	// RVA: 0x9EB840 Offset: 0x9E9E40 VA: 0x1809EB840
	internal int GetSlotTableLength() { }

	// RVA: 0x16742B0 Offset: 0x16728B0 VA: 0x1816742B0
	public void .ctor() { }

}

