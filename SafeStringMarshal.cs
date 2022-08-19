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

	// RVA: 0x1F6C10 Offset: 0x1F6010 VA: 0x1801F6C10
	public void .ctor(string str) { }

	// RVA: 0x1F6C60 Offset: 0x1F6060 VA: 0x1801F6C60
	public IntPtr get_Value() { }

	// RVA: 0x1F6BC0 Offset: 0x1F5FC0 VA: 0x1801F6BC0 Slot: 4
	public void Dispose() { }

}

