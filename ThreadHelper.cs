internal class ThreadHelper // TypeDefIndex: 800
{	// Fields
	private Delegate _start; // 0x10
	private object _startArg; // 0x18
	private ExecutionContext _executionContext; // 0x20
	internal static ContextCallback _ccb; // 0x0

	// Methods

	// RVA: 0x15F7C50 Offset: 0x15F6250 VA: 0x1815F7C50
	private static void .cctor() { }

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	internal void .ctor(Delegate start) { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	internal void SetExecutionContextHelper(ExecutionContext ec) { }

	// RVA: 0x15F7950 Offset: 0x15F5F50 VA: 0x1815F7950
	private static void ThreadStart_Context(object state) { }

	// RVA: 0x15F7A50 Offset: 0x15F6050 VA: 0x1815F7A50
	internal void ThreadStart(object obj) { }

	// RVA: 0x15F7B60 Offset: 0x15F6160 VA: 0x1815F7B60
	internal void ThreadStart() { }

}

