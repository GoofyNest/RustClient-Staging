internal class CFRunLoop : CFObject // TypeDefIndex: 2521
{	// Properties
	public static CFRunLoop CurrentRunLoop { get; }

	// Methods

	// RVA: 0x1214560 Offset: 0x1212B60 VA: 0x181214560
	private static extern void CFRunLoopAddSource(IntPtr rl, IntPtr source, IntPtr mode) { }

	// RVA: 0x1214670 Offset: 0x1212C70 VA: 0x181214670
	private static extern void CFRunLoopRemoveSource(IntPtr rl, IntPtr source, IntPtr mode) { }

	// RVA: 0x1214710 Offset: 0x1212D10 VA: 0x181214710
	private static extern int CFRunLoopRunInMode(IntPtr mode, double seconds, bool returnAfterSourceHandled) { }

	// RVA: 0x1214600 Offset: 0x1212C00 VA: 0x181214600
	private static extern IntPtr CFRunLoopGetCurrent() { }

	// RVA: 0x12147B0 Offset: 0x1212DB0 VA: 0x1812147B0
	private static extern void CFRunLoopStop(IntPtr rl) { }

	// RVA: 0x1210DF0 Offset: 0x120F3F0 VA: 0x181210DF0
	public void .ctor(IntPtr handle, bool own) { }

	// RVA: 0x1214A10 Offset: 0x1213010 VA: 0x181214A10
	public static CFRunLoop get_CurrentRunLoop() { }

	// RVA: 0x12144B0 Offset: 0x1212AB0 VA: 0x1812144B0
	public void AddSource(IntPtr source, CFString mode) { }

	// RVA: 0x1214830 Offset: 0x1212E30 VA: 0x181214830
	public void RemoveSource(IntPtr source, CFString mode) { }

	// RVA: 0x12148E0 Offset: 0x1212EE0 VA: 0x1812148E0
	public int RunInMode(CFString mode, double seconds, bool returnAfterSourceHandled) { }

	// RVA: 0x1214990 Offset: 0x1212F90 VA: 0x181214990
	public void Stop() { }

}

