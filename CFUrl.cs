internal class CFUrl : CFObject // TypeDefIndex: 2520
{	// Methods

	// RVA: 0x1210750 Offset: 0x120ED50 VA: 0x181210750
	public void .ctor(IntPtr handle, bool own) { }

	// RVA: 0x1214AD0 Offset: 0x12130D0 VA: 0x181214AD0
	private static extern IntPtr CFURLCreateWithString(IntPtr allocator, IntPtr str, IntPtr baseURL) { }

	// RVA: 0x1214B70 Offset: 0x1213170 VA: 0x181214B70
	public static CFUrl Create(string absolute) { }

}

