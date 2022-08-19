internal class CFArray : CFObject // TypeDefIndex: 2514
{	// Fields
	private static readonly IntPtr kCFTypeArrayCallbacks; // 0x14330

	// Properties
	public int Count { get; }
	public IntPtr Item { get; }

	// Methods

	// RVA: 0x1210490 Offset: 0x120EA90 VA: 0x181210490
	public void .ctor(IntPtr handle, bool own) { }

	// RVA: 0x12103A0 Offset: 0x120E9A0 VA: 0x1812103A0
	private static void .cctor() { }

	// RVA: 0x1210290 Offset: 0x120E890 VA: 0x181210290
	private static extern IntPtr CFArrayGetCount(IntPtr handle) { }

	// RVA: 0x12104A0 Offset: 0x120EAA0 VA: 0x1812104A0
	public int get_Count() { }

	// RVA: 0x1210310 Offset: 0x120E910 VA: 0x181210310
	private static extern IntPtr CFArrayGetValueAtIndex(IntPtr handle, IntPtr index) { }

	// RVA: 0x1210560 Offset: 0x120EB60 VA: 0x181210560
	public IntPtr get_Item(int index) { }

}

