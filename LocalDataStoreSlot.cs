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

	// RVA: 0x1671FF0 Offset: 0x16705F0 VA: 0x181671FF0
	internal void .ctor(LocalDataStoreMgr mgr, int slot, long cookie) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	internal LocalDataStoreMgr get_Manager() { }

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	internal int get_Slot() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal long get_Cookie() { }

	// RVA: 0x1671F50 Offset: 0x1670550 VA: 0x181671F50 Slot: 1
	protected override void Finalize() { }

}

