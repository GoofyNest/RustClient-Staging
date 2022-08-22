public sealed class LocalDataStoreSlot // TypeDefIndex: 147
{	// Fields
	private LocalDataStoreMgr m_mgr; // 0x10
	private int m_slot; // 0x18
	private long m_cookie; // 0x20

	// Properties
	internal LocalDataStoreMgr Manager { get; }
	internal int Slot { get; }
	internal long Cookie { get; }

	// Methods

	// RVA: 0x1674400 Offset: 0x1672A00 VA: 0x181674400
	internal void .ctor(LocalDataStoreMgr mgr, int slot, long cookie) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal LocalDataStoreMgr get_Manager() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	internal int get_Slot() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal long get_Cookie() { }

	// RVA: 0x1674360 Offset: 0x1672960 VA: 0x181674360 Slot: 1
	protected override void Finalize() { }

}

