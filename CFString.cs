internal class CFString : CFObject // TypeDefIndex: 2518
{	// Fields
	private string str; // 0x18

	// Methods

	// RVA: 0x1210490 Offset: 0x120EA90 VA: 0x181210490
	public void .ctor(IntPtr handle, bool own) { }

	// RVA: 0x1214470 Offset: 0x1212A70 VA: 0x181214470
	private static extern IntPtr CFStringCreateWithCharacters(IntPtr alloc, IntPtr chars, IntPtr length) { }

	// RVA: 0x12146B0 Offset: 0x1212CB0 VA: 0x1812146B0
	public static CFString Create(string value) { }

	// RVA: 0x1214630 Offset: 0x1212C30 VA: 0x181214630
	private static extern IntPtr CFStringGetLength(IntPtr handle) { }

	// RVA: 0x1214510 Offset: 0x1212B10 VA: 0x181214510
	private static extern IntPtr CFStringGetCharactersPtr(IntPtr handle) { }

	// RVA: 0x1214590 Offset: 0x1212B90 VA: 0x181214590
	private static extern IntPtr CFStringGetCharacters(IntPtr handle, CFRange range, IntPtr buffer) { }

	// RVA: 0x12141D0 Offset: 0x12127D0 VA: 0x1812141D0
	public static string AsString(IntPtr handle) { }

	// RVA: 0x12147D0 Offset: 0x1212DD0 VA: 0x1812147D0 Slot: 3
	public override string ToString() { }

}

