internal class CFString : CFObject // TypeDefIndex: 2518
{	// Fields
	private string str; // 0x18

	// Methods

	// RVA: 0x1210DF0 Offset: 0x120F3F0 VA: 0x181210DF0
	public void .ctor(IntPtr handle, bool own) { }

	// RVA: 0x1214DD0 Offset: 0x12133D0 VA: 0x181214DD0
	private static extern IntPtr CFStringCreateWithCharacters(IntPtr alloc, IntPtr chars, IntPtr length) { }

	// RVA: 0x1215010 Offset: 0x1213610 VA: 0x181215010
	public static CFString Create(string value) { }

	// RVA: 0x1214F90 Offset: 0x1213590 VA: 0x181214F90
	private static extern IntPtr CFStringGetLength(IntPtr handle) { }

	// RVA: 0x1214E70 Offset: 0x1213470 VA: 0x181214E70
	private static extern IntPtr CFStringGetCharactersPtr(IntPtr handle) { }

	// RVA: 0x1214EF0 Offset: 0x12134F0 VA: 0x181214EF0
	private static extern IntPtr CFStringGetCharacters(IntPtr handle, CFRange range, IntPtr buffer) { }

	// RVA: 0x1214B30 Offset: 0x1213130 VA: 0x181214B30
	public static string AsString(IntPtr handle) { }

	// RVA: 0x1215130 Offset: 0x1213730 VA: 0x181215130 Slot: 3
	public override string ToString() { }

}

