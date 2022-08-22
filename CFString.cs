internal class CFString : CFObject // TypeDefIndex: 2518
{	// Fields
	private string str; // 0x18

	// Methods

	// RVA: 0x1210750 Offset: 0x120ED50 VA: 0x181210750
	public void .ctor(IntPtr handle, bool own) { }

	// RVA: 0x1214730 Offset: 0x1212D30 VA: 0x181214730
	private static extern IntPtr CFStringCreateWithCharacters(IntPtr alloc, IntPtr chars, IntPtr length) { }

	// RVA: 0x1214970 Offset: 0x1212F70 VA: 0x181214970
	public static CFString Create(string value) { }

	// RVA: 0x12148F0 Offset: 0x1212EF0 VA: 0x1812148F0
	private static extern IntPtr CFStringGetLength(IntPtr handle) { }

	// RVA: 0x12147D0 Offset: 0x1212DD0 VA: 0x1812147D0
	private static extern IntPtr CFStringGetCharactersPtr(IntPtr handle) { }

	// RVA: 0x1214850 Offset: 0x1212E50 VA: 0x181214850
	private static extern IntPtr CFStringGetCharacters(IntPtr handle, CFRange range, IntPtr buffer) { }

	// RVA: 0x1214490 Offset: 0x1212A90 VA: 0x181214490
	public static string AsString(IntPtr handle) { }

	// RVA: 0x1214A90 Offset: 0x1213090 VA: 0x181214A90 Slot: 3
	public override string ToString() { }

}

