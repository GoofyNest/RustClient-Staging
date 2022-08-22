internal struct SessionMask // TypeDefIndex: 1621
{	// Fields
	private uint m_mask; // 0x0

	// Properties
	public static SessionMask All { get; }
	public bool Item { get; set; }

	// Methods

	// RVA: 0x19F690 Offset: 0x19EA90 VA: 0x18019F690
	public void .ctor(uint mask = 0) { }

	// RVA: 0x19F670 Offset: 0x19EA70 VA: 0x18019F670
	public bool IsEqualOrSupersetOf(SessionMask m) { }

	// RVA: 0x10E4E80 Offset: 0x10E3480 VA: 0x1810E4E80
	public static SessionMask get_All() { }

	// RVA: 0x10E4E40 Offset: 0x10E3440 VA: 0x1810E4E40
	public static SessionMask FromId(int perEventSourceSessionId) { }

	// RVA: 0x19F680 Offset: 0x19EA80 VA: 0x18019F680
	public ulong ToEventKeywords() { }

	// RVA: 0x10E4E30 Offset: 0x10E3430 VA: 0x1810E4E30
	public static SessionMask FromEventKeywords(ulong m) { }

	// RVA: 0x19F6A0 Offset: 0x19EAA0 VA: 0x18019F6A0
	public bool get_Item(int perEventSourceSessionId) { }

	// RVA: 0x19F6C0 Offset: 0x19EAC0 VA: 0x18019F6C0
	public void set_Item(int perEventSourceSessionId, bool value) { }

	// RVA: 0x68A6C0 Offset: 0x688CC0 VA: 0x18068A6C0
	public static ulong op_Explicit(SessionMask m) { }

	// RVA: 0x68A6C0 Offset: 0x688CC0 VA: 0x18068A6C0
	public static uint op_Explicit(SessionMask m) { }

}

