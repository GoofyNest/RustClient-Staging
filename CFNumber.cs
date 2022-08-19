internal class CFNumber : CFObject // TypeDefIndex: 2515
{	// Methods

	// RVA: 0x12124C0 Offset: 0x1210AC0 VA: 0x1812124C0
	private static extern bool CFNumberGetValue(IntPtr handle, IntPtr type, out int value) { }

	// RVA: 0x12123E0 Offset: 0x12109E0 VA: 0x1812123E0
	public static int AsInt32(IntPtr handle) { }

}

