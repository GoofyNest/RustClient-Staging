internal class CFUrl : CFObject // TypeDefIndex: 2520
{	// Methods

	// RVA: 0x1210DF0 Offset: 0x120F3F0 VA: 0x181210DF0
	public void .ctor(IntPtr handle, bool own) { }

	// RVA: 0x1215170 Offset: 0x1213770 VA: 0x181215170
	private static extern IntPtr CFURLCreateWithString(IntPtr allocator, IntPtr str, IntPtr baseURL) { }

	// RVA: 0x1215210 Offset: 0x1213810 VA: 0x181215210
	public static CFUrl Create(string absolute) { }

}

