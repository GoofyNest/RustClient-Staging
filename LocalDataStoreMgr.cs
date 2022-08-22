internal sealed class LocalDataStoreMgr // TypeDefIndex: 148
{	// Fields
	private bool[] m_SlotInfoTable; // 0x10
	private int m_FirstAvailableSlot; // 0x18
	private List<LocalDataStore> m_ManagedLocalDataStores; // 0x20
	private Dictionary<string, LocalDataStoreSlot> m_KeyToSlotMap; // 0x28
	private long m_CookieGenerator; // 0x30

	// Methods

	// RVA: 0x16717E0 Offset: 0x166FDE0 VA: 0x1816717E0
	public LocalDataStoreHolder CreateLocalDataStore() { }

	// RVA: 0x1671960 Offset: 0x166FF60 VA: 0x181671960
	public void DeleteLocalDataStore(LocalDataStore store) { }

	// RVA: 0x16714B0 Offset: 0x166FAB0 VA: 0x1816714B0
	public LocalDataStoreSlot AllocateDataSlot() { }

	// RVA: 0x16716D0 Offset: 0x166FCD0 VA: 0x1816716D0
	public LocalDataStoreSlot AllocateNamedDataSlot(string name) { }

	// RVA: 0x1671D00 Offset: 0x1670300 VA: 0x181671D00
	public LocalDataStoreSlot GetNamedDataSlot(string name) { }

	// RVA: 0x1671C10 Offset: 0x1670210 VA: 0x181671C10
	public void FreeNamedDataSlot(string name) { }

	// RVA: 0x1671A50 Offset: 0x1670050 VA: 0x181671A50
	internal void FreeDataSlot(int slot, long cookie) { }

	// RVA: 0x1671E20 Offset: 0x1670420 VA: 0x181671E20
	public void ValidateSlot(LocalDataStoreSlot slot) { }

	// RVA: 0x9EBD30 Offset: 0x9EA330 VA: 0x1809EBD30
	internal int GetSlotTableLength() { }

	// RVA: 0x1671EA0 Offset: 0x16704A0 VA: 0x181671EA0
	public void .ctor() { }

}

