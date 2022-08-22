internal class CFObject : IDisposable // TypeDefIndex: 2513
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IntPtr <Handle>k__BackingField; // 0x10

	// Properties
	public IntPtr Handle { get; set; }

	// Methods

	// RVA: 0x12133C0 Offset: 0x12119C0 VA: 0x1812133C0
	public static extern IntPtr dlopen(string path, int mode) { }

	// RVA: 0x1213460 Offset: 0x1211A60 VA: 0x181213460
	private static extern IntPtr dlsym(IntPtr handle, string symbol) { }

	// RVA: 0x1213340 Offset: 0x1211940 VA: 0x181213340
	public static extern void dlclose(IntPtr handle) { }

	// RVA: 0x1213180 Offset: 0x1211780 VA: 0x181213180
	public static IntPtr GetIndirect(IntPtr handle, string symbol) { }

	// RVA: 0x12130F0 Offset: 0x12116F0 VA: 0x1812130F0
	public static IntPtr GetCFObjectHandle(IntPtr handle, string symbol) { }

	// RVA: 0x1213290 Offset: 0x1211890 VA: 0x181213290
	public void .ctor(IntPtr handle, bool own) { }

	// RVA: 0xD7DFC0 Offset: 0xD7C5C0 VA: 0x180D7DFC0 Slot: 1
	protected override void Finalize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 5
	public IntPtr get_Handle() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C16A0 Offset: 0x8BFCA0 VA: 0x1808C16A0
	private void set_Handle(IntPtr value) { }

	// RVA: 0x1212F40 Offset: 0x1211540 VA: 0x181212F40
	internal static extern IntPtr CFRetain(IntPtr handle) { }

	// RVA: 0x1213210 Offset: 0x1211810 VA: 0x181213210
	private void Retain() { }

	// RVA: 0x1212EC0 Offset: 0x12114C0 VA: 0x181212EC0
	internal static extern void CFRelease(IntPtr handle) { }

	// RVA: 0x1213190 Offset: 0x1211790 VA: 0x181213190
	private void Release() { }

	// RVA: 0x1213030 Offset: 0x1211630 VA: 0x181213030 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1212FC0 Offset: 0x12115C0 VA: 0x181212FC0 Slot: 4
	public void Dispose() { }

}

