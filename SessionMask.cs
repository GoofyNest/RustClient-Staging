internal struct SessionMask // TypeDefIndex: 1621
{	// Fields
	private uint m_mask; // 0x0

	// Properties
	public static SessionMask All { get; }
	public bool Item { get; set; }

	// Methods

	// RVA: 0x19F710 Offset: 0x19EB10 VA: 0x18019F710
	public void .ctor(uint mask = 0) { }

	// RVA: 0x19F6F0 Offset: 0x19EAF0 VA: 0x18019F6F0
	public bool IsEqualOrSupersetOf(SessionMask m) { }

	// RVA: 0x10E4BC0 Offset: 0x10E31C0 VA: 0x1810E4BC0
	public static SessionMask get_All() { }

	// RVA: 0x10E4B80 Offset: 0x10E3180 VA: 0x1810E4B80
	public static SessionMask FromId(int perEventSourceSessionId) { }

	// RVA: 0x19F700 Offset: 0x19EB00 VA: 0x18019F700
	public ulong ToEventKeywords() { }

	// RVA: 0x10E4B70 Offset: 0x10E3170 VA: 0x1810E4B70
	public static SessionMask FromEventKeywords(ulong m) { }

	// RVA: 0x19F720 Offset: 0x19EB20 VA: 0x18019F720
	public bool get_Item(int perEventSourceSessionId) { }

	// RVA: 0x19F740 Offset: 0x19EB40 VA: 0x18019F740
	public void set_Item(int perEventSourceSessionId, bool value) { }

	// RVA: 0x68A6C0 Offset: 0x688CC0 VA: 0x18068A6C0
	public static ulong op_Explicit(SessionMask m) { }

	// RVA: 0x68A6C0 Offset: 0x688CC0 VA: 0x18068A6C0
	public static uint op_Explicit(SessionMask m) { }

}

