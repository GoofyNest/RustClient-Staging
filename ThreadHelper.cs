internal class ThreadHelper // TypeDefIndex: 800
{	// Fields
	private Delegate _start; // 0x10
	private object _startArg; // 0x18
	private ExecutionContext _executionContext; // 0x20
	internal static ContextCallback _ccb; // 0x0

	// Methods

	// RVA: 0x160A670 Offset: 0x1608C70 VA: 0x18160A670
	private static void .cctor() { }

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	internal void .ctor(Delegate start) { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	internal void SetExecutionContextHelper(ExecutionContext ec) { }

	// RVA: 0x160A370 Offset: 0x1608970 VA: 0x18160A370
	private static void ThreadStart_Context(object state) { }

	// RVA: 0x160A470 Offset: 0x1608A70 VA: 0x18160A470
	internal void ThreadStart(object obj) { }

	// RVA: 0x160A580 Offset: 0x1608B80 VA: 0x18160A580
	internal void ThreadStart() { }

}

