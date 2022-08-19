internal class CancellationCallbackInfo // TypeDefIndex: 753
{	// Fields
	internal readonly Action<object> Callback; // 0x10
	internal readonly object StateForCallback; // 0x18
	internal readonly SynchronizationContext TargetSyncContext; // 0x20
	internal readonly ExecutionContext TargetExecutionContext; // 0x28
	internal readonly CancellationTokenSource CancellationTokenSource; // 0x30
	private static ContextCallback s_executionContextCallback; // 0x0

	// Methods

	// RVA: 0x1490110 Offset: 0x148E710 VA: 0x181490110
	internal void .ctor(Action<object> callback, object stateForCallback, SynchronizationContext targetSyncContext, ExecutionContext targetExecutionContext, CancellationTokenSource cancellationTokenSource) { }

	// RVA: 0x148FE40 Offset: 0x148E440 VA: 0x18148FE40
	internal void ExecuteCallback() { }

	// RVA: 0x1490080 Offset: 0x148E680 VA: 0x181490080
	private static void ExecutionContextCallback(object obj) { }

}

