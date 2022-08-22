internal class CFRunLoop : CFObject // TypeDefIndex: 2521
{	// Properties
	public static CFRunLoop CurrentRunLoop { get; }

	// Methods

	// RVA: 0x1213EC0 Offset: 0x12124C0 VA: 0x181213EC0
	private static extern void CFRunLoopAddSource(IntPtr rl, IntPtr source, IntPtr mode) { }

	// RVA: 0x1213FD0 Offset: 0x12125D0 VA: 0x181213FD0
	private static extern void CFRunLoopRemoveSource(IntPtr rl, IntPtr source, IntPtr mode) { }

	// RVA: 0x1214070 Offset: 0x1212670 VA: 0x181214070
	private static extern int CFRunLoopRunInMode(IntPtr mode, double seconds, bool returnAfterSourceHandled) { }

	// RVA: 0x1213F60 Offset: 0x1212560 VA: 0x181213F60
	private static extern IntPtr CFRunLoopGetCurrent() { }

	// RVA: 0x1214110 Offset: 0x1212710 VA: 0x181214110
	private static extern void CFRunLoopStop(IntPtr rl) { }

	// RVA: 0x1210750 Offset: 0x120ED50 VA: 0x181210750
	public void .ctor(IntPtr handle, bool own) { }

	// RVA: 0x1214370 Offset: 0x1212970 VA: 0x181214370
	public static CFRunLoop get_CurrentRunLoop() { }

	// RVA: 0x1213E10 Offset: 0x1212410 VA: 0x181213E10
	public void AddSource(IntPtr source, CFString mode) { }

	// RVA: 0x1214190 Offset: 0x1212790 VA: 0x181214190
	public void RemoveSource(IntPtr source, CFString mode) { }

	// RVA: 0x1214240 Offset: 0x1212840 VA: 0x181214240
	public int RunInMode(CFString mode, double seconds, bool returnAfterSourceHandled) { }

	// RVA: 0x12142F0 Offset: 0x12128F0 VA: 0x1812142F0
	public void Stop() { }

}

