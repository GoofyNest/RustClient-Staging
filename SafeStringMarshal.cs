internal struct SafeStringMarshal : IDisposable // TypeDefIndex: 22
{	// Fields
	private readonly string str; // 0x0
	private IntPtr marshaled_string; // 0x8

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x164A8A0 Offset: 0x1648EA0 VA: 0x18164A8A0
	public static IntPtr StringToUtf8(string str) { }

	// RVA: 0x164A890 Offset: 0x1648E90 VA: 0x18164A890
	public static void GFree(IntPtr ptr) { }

	// RVA: 0x1F6B90 Offset: 0x1F5F90 VA: 0x1801F6B90
	public void .ctor(string str) { }

	// RVA: 0x1F6BE0 Offset: 0x1F5FE0 VA: 0x1801F6BE0
	public IntPtr get_Value() { }

	// RVA: 0x1F6B40 Offset: 0x1F5F40 VA: 0x1801F6B40 Slot: 4
	public void Dispose() { }

}

