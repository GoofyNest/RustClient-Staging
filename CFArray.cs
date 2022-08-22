internal class CFArray : CFObject // TypeDefIndex: 2514
{	// Fields
	private static readonly IntPtr kCFTypeArrayCallbacks; // 0x2B10380

	// Properties
	public int Count { get; }
	public IntPtr Item { get; }

	// Methods

	// RVA: 0x1210DF0 Offset: 0x120F3F0 VA: 0x181210DF0
	public void .ctor(IntPtr handle, bool own) { }

	// RVA: 0x1210D00 Offset: 0x120F300 VA: 0x181210D00
	private static void .cctor() { }

	// RVA: 0x1210BF0 Offset: 0x120F1F0 VA: 0x181210BF0
	private static extern IntPtr CFArrayGetCount(IntPtr handle) { }

	// RVA: 0x1210E00 Offset: 0x120F400 VA: 0x181210E00
	public int get_Count() { }

	// RVA: 0x1210C70 Offset: 0x120F270 VA: 0x181210C70
	private static extern IntPtr CFArrayGetValueAtIndex(IntPtr handle, IntPtr index) { }

	// RVA: 0x1210EC0 Offset: 0x120F4C0 VA: 0x181210EC0
	public IntPtr get_Item(int index) { }

}

