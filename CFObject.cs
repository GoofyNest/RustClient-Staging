internal class CFObject : IDisposable // TypeDefIndex: 2513
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IntPtr <Handle>k__BackingField; // 0x10

	// Properties
	public IntPtr Handle { get; set; }

	// Methods

	// RVA: 0x1212A60 Offset: 0x1211060 VA: 0x181212A60
	public static extern IntPtr dlopen(string path, int mode) { }

	// RVA: 0x1212B00 Offset: 0x1211100 VA: 0x181212B00
	private static extern IntPtr dlsym(IntPtr handle, string symbol) { }

	// RVA: 0x12129E0 Offset: 0x1210FE0 VA: 0x1812129E0
	public static extern void dlclose(IntPtr handle) { }

	// RVA: 0x1212820 Offset: 0x1210E20 VA: 0x181212820
	public static IntPtr GetIndirect(IntPtr handle, string symbol) { }

	// RVA: 0x1212790 Offset: 0x1210D90 VA: 0x181212790
	public static IntPtr GetCFObjectHandle(IntPtr handle, string symbol) { }

	// RVA: 0x1212930 Offset: 0x1210F30 VA: 0x181212930
	public void .ctor(IntPtr handle, bool own) { }

	// RVA: 0xD7D250 Offset: 0xD7B850 VA: 0x180D7D250 Slot: 1
	protected override void Finalize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 5
	public IntPtr get_Handle() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1080 Offset: 0x8BF680 VA: 0x1808C1080
	private void set_Handle(IntPtr value) { }

	// RVA: 0x12125E0 Offset: 0x1210BE0 VA: 0x1812125E0
	internal static extern IntPtr CFRetain(IntPtr handle) { }

	// RVA: 0x12128B0 Offset: 0x1210EB0 VA: 0x1812128B0
	private void Retain() { }

	// RVA: 0x1212560 Offset: 0x1210B60 VA: 0x181212560
	internal static extern void CFRelease(IntPtr handle) { }

	// RVA: 0x1212830 Offset: 0x1210E30 VA: 0x181212830
	private void Release() { }

	// RVA: 0x12126D0 Offset: 0x1210CD0 VA: 0x1812126D0 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1212660 Offset: 0x1210C60 VA: 0x181212660 Slot: 4
	public void Dispose() { }

}

