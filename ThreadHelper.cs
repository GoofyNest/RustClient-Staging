internal class ThreadHelper // TypeDefIndex: 800
{	// Fields
	private Delegate _start; // 0x10
	private object _startArg; // 0x18
	private ExecutionContext _executionContext; // 0x20
	internal static ContextCallback _ccb; // 0x0

	// Methods

	// RVA: 0x160A930 Offset: 0x1608F30 VA: 0x18160A930
	private static void .cctor() { }

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	internal void .ctor(Delegate start) { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	internal void SetExecutionContextHelper(ExecutionContext ec) { }

	// RVA: 0x160A630 Offset: 0x1608C30 VA: 0x18160A630
	private static void ThreadStart_Context(object state) { }

	// RVA: 0x160A730 Offset: 0x1608D30 VA: 0x18160A730
	internal void ThreadStart(object obj) { }

	// RVA: 0x160A840 Offset: 0x1608E40 VA: 0x18160A840
	internal void ThreadStart() { }

}

