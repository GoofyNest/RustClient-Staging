internal class CFObject : IDisposable // TypeDefIndex: 2513
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IntPtr <Handle>k__BackingField; // 0x10

	// Properties
	public IntPtr Handle { get; set; }

	// Methods

	// RVA: 0x1212D20 Offset: 0x1211320 VA: 0x181212D20
	public static extern IntPtr dlopen(string path, int mode) { }

	// RVA: 0x1212DC0 Offset: 0x12113C0 VA: 0x181212DC0
	private static extern IntPtr dlsym(IntPtr handle, string symbol) { }

	// RVA: 0x1212CA0 Offset: 0x12112A0 VA: 0x181212CA0
	public static extern void dlclose(IntPtr handle) { }

	// RVA: 0x1212AE0 Offset: 0x12110E0 VA: 0x181212AE0
	public static IntPtr GetIndirect(IntPtr handle, string symbol) { }

	// RVA: 0x1212A50 Offset: 0x1211050 VA: 0x181212A50
	public static IntPtr GetCFObjectHandle(IntPtr handle, string symbol) { }

	// RVA: 0x1212BF0 Offset: 0x12111F0 VA: 0x181212BF0
	public void .ctor(IntPtr handle, bool own) { }

	// RVA: 0xD7D510 Offset: 0xD7BB10 VA: 0x180D7D510 Slot: 1
	protected override void Finalize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 5
	public IntPtr get_Handle() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1190 Offset: 0x8BF790 VA: 0x1808C1190
	private void set_Handle(IntPtr value) { }

	// RVA: 0x12128A0 Offset: 0x1210EA0 VA: 0x1812128A0
	internal static extern IntPtr CFRetain(IntPtr handle) { }

	// RVA: 0x1212B70 Offset: 0x1211170 VA: 0x181212B70
	private void Retain() { }

	// RVA: 0x1212820 Offset: 0x1210E20 VA: 0x181212820
	internal static extern void CFRelease(IntPtr handle) { }

	// RVA: 0x1212AF0 Offset: 0x12110F0 VA: 0x181212AF0
	private void Release() { }

	// RVA: 0x1212990 Offset: 0x1210F90 VA: 0x181212990 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1212920 Offset: 0x1210F20 VA: 0x181212920 Slot: 4
	public void Dispose() { }

}

