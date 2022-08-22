internal class CFNumber : CFObject // TypeDefIndex: 2515
{	// Methods

	// RVA: 0x1212780 Offset: 0x1210D80 VA: 0x181212780
	private static extern bool CFNumberGetValue(IntPtr handle, IntPtr type, out int value) { }

	// RVA: 0x12126A0 Offset: 0x1210CA0 VA: 0x1812126A0
	public static int AsInt32(IntPtr handle) { }

}

