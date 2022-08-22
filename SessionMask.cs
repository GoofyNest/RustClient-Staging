internal struct SessionMask // TypeDefIndex: 1621
{	// Fields
	private uint m_mask; // 0x0

	// Properties
	public static SessionMask All { get; }
	public bool Item { get; set; }

	// Methods

	// RVA: 0x1AD520 Offset: 0x1AC920 VA: 0x1801AD520
	public void .ctor(uint mask = 0) { }

	// RVA: 0x1AD500 Offset: 0x1AC900 VA: 0x1801AD500
	public bool IsEqualOrSupersetOf(SessionMask m) { }

	// RVA: 0x10E58F0 Offset: 0x10E3EF0 VA: 0x1810E58F0
	public static SessionMask get_All() { }

	// RVA: 0x10E58B0 Offset: 0x10E3EB0 VA: 0x1810E58B0
	public static SessionMask FromId(int perEventSourceSessionId) { }

	// RVA: 0x1AD510 Offset: 0x1AC910 VA: 0x1801AD510
	public ulong ToEventKeywords() { }

	// RVA: 0x10E58A0 Offset: 0x10E3EA0 VA: 0x1810E58A0
	public static SessionMask FromEventKeywords(ulong m) { }

	// RVA: 0x1AD530 Offset: 0x1AC930 VA: 0x1801AD530
	public bool get_Item(int perEventSourceSessionId) { }

	// RVA: 0x1AD550 Offset: 0x1AC950 VA: 0x1801AD550
	public void set_Item(int perEventSourceSessionId, bool value) { }

	// RVA: 0x68A650 Offset: 0x688C50 VA: 0x18068A650
	public static ulong op_Explicit(SessionMask m) { }

	// RVA: 0x68A650 Offset: 0x688C50 VA: 0x18068A650
	public static uint op_Explicit(SessionMask m) { }

}

