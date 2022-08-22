internal class CFArray : CFObject // TypeDefIndex: 2514
{	// Fields
	private static readonly IntPtr kCFTypeArrayCallbacks; // 0x14330

	// Properties
	public int Count { get; }
	public IntPtr Item { get; }

	// Methods

	// RVA: 0x1210750 Offset: 0x120ED50 VA: 0x181210750
	public void .ctor(IntPtr handle, bool own) { }

	// RVA: 0x1210660 Offset: 0x120EC60 VA: 0x181210660
	private static void .cctor() { }

	// RVA: 0x1210550 Offset: 0x120EB50 VA: 0x181210550
	private static extern IntPtr CFArrayGetCount(IntPtr handle) { }

	// RVA: 0x1210760 Offset: 0x120ED60 VA: 0x181210760
	public int get_Count() { }

	// RVA: 0x12105D0 Offset: 0x120EBD0 VA: 0x1812105D0
	private static extern IntPtr CFArrayGetValueAtIndex(IntPtr handle, IntPtr index) { }

	// RVA: 0x1210820 Offset: 0x120EE20 VA: 0x181210820
	public IntPtr get_Item(int index) { }

}

