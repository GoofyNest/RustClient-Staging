internal class CFUrl : CFObject // TypeDefIndex: 2520
{	// Methods

	// RVA: 0x1210490 Offset: 0x120EA90 VA: 0x181210490
	public void .ctor(IntPtr handle, bool own) { }

	// RVA: 0x1214810 Offset: 0x1212E10 VA: 0x181214810
	private static extern IntPtr CFURLCreateWithString(IntPtr allocator, IntPtr str, IntPtr baseURL) { }

	// RVA: 0x12148B0 Offset: 0x1212EB0 VA: 0x1812148B0
	public static CFUrl Create(string absolute) { }

}

