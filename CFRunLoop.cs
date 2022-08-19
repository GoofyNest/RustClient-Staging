internal class CFRunLoop : CFObject // TypeDefIndex: 2521
{	// Properties
	public static CFRunLoop CurrentRunLoop { get; }

	// Methods

	// RVA: 0x1213C00 Offset: 0x1212200 VA: 0x181213C00
	private static extern void CFRunLoopAddSource(IntPtr rl, IntPtr source, IntPtr mode) { }

	// RVA: 0x1213D10 Offset: 0x1212310 VA: 0x181213D10
	private static extern void CFRunLoopRemoveSource(IntPtr rl, IntPtr source, IntPtr mode) { }

	// RVA: 0x1213DB0 Offset: 0x12123B0 VA: 0x181213DB0
	private static extern int CFRunLoopRunInMode(IntPtr mode, double seconds, bool returnAfterSourceHandled) { }

	// RVA: 0x1213CA0 Offset: 0x12122A0 VA: 0x181213CA0
	private static extern IntPtr CFRunLoopGetCurrent() { }

	// RVA: 0x1213E50 Offset: 0x1212450 VA: 0x181213E50
	private static extern void CFRunLoopStop(IntPtr rl) { }

	// RVA: 0x1210490 Offset: 0x120EA90 VA: 0x181210490
	public void .ctor(IntPtr handle, bool own) { }

	// RVA: 0x12140B0 Offset: 0x12126B0 VA: 0x1812140B0
	public static CFRunLoop get_CurrentRunLoop() { }

	// RVA: 0x1213B50 Offset: 0x1212150 VA: 0x181213B50
	public void AddSource(IntPtr source, CFString mode) { }

	// RVA: 0x1213ED0 Offset: 0x12124D0 VA: 0x181213ED0
	public void RemoveSource(IntPtr source, CFString mode) { }

	// RVA: 0x1213F80 Offset: 0x1212580 VA: 0x181213F80
	public int RunInMode(CFString mode, double seconds, bool returnAfterSourceHandled) { }

	// RVA: 0x1214030 Offset: 0x1212630 VA: 0x181214030
	public void Stop() { }

}

