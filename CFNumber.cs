internal class CFNumber : CFObject // TypeDefIndex: 2515
{	// Methods

	// RVA: 0x1212E20 Offset: 0x1211420 VA: 0x181212E20
	private static extern bool CFNumberGetValue(IntPtr handle, IntPtr type, out int value) { }

	// RVA: 0x1212D40 Offset: 0x1211340 VA: 0x181212D40
	public static int AsInt32(IntPtr handle) { }

}

