internal class CancellationCallbackInfo // TypeDefIndex: 753
{	// Fields
	internal readonly Action<object> Callback; // 0x10
	internal readonly object StateForCallback; // 0x18
	internal readonly SynchronizationContext TargetSyncContext; // 0x20
	internal readonly ExecutionContext TargetExecutionContext; // 0x28
	internal readonly CancellationTokenSource CancellationTokenSource; // 0x30
	private static ContextCallback s_executionContextCallback; // 0x0

	// Methods

	// RVA: 0x14903D0 Offset: 0x148E9D0 VA: 0x1814903D0
	internal void .ctor(Action<object> callback, object stateForCallback, SynchronizationContext targetSyncContext, ExecutionContext targetExecutionContext, CancellationTokenSource cancellationTokenSource) { }

	// RVA: 0x1490100 Offset: 0x148E700 VA: 0x181490100
	internal void ExecuteCallback() { }

	// RVA: 0x1490340 Offset: 0x148E940 VA: 0x181490340
	private static void ExecutionContextCallback(object obj) { }

}

