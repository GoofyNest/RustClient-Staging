internal struct SafeStringMarshal : IDisposable // TypeDefIndex: 22
{	// Fields
	private readonly string str; // 0x0
	private IntPtr marshaled_string; // 0x8

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x1637E80 Offset: 0x1636480 VA: 0x181637E80
	public static IntPtr StringToUtf8(string str) { }

	// RVA: 0x1637E70 Offset: 0x1636470 VA: 0x181637E70
	public static void GFree(IntPtr ptr) { }

	// RVA: 0x1F59E0 Offset: 0x1F4DE0 VA: 0x1801F59E0
	public void .ctor(string str) { }

	// RVA: 0x1F5A30 Offset: 0x1F4E30 VA: 0x1801F5A30
	public IntPtr get_Value() { }

	// RVA: 0x1F5990 Offset: 0x1F4D90 VA: 0x1801F5990 Slot: 4
	public void Dispose() { }

}

