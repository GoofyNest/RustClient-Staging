internal class CancellationCallbackInfo // TypeDefIndex: 753
{	// Fields
	internal readonly Action<object> Callback; // 0x10
	internal readonly object StateForCallback; // 0x18
	internal readonly SynchronizationContext TargetSyncContext; // 0x20
	internal readonly ExecutionContext TargetExecutionContext; // 0x28
	internal readonly CancellationTokenSource CancellationTokenSource; // 0x30
	private static ContextCallback s_executionContextCallback; // 0x0

	// Methods

	// RVA: 0x148F4A0 Offset: 0x148DAA0 VA: 0x18148F4A0
	internal void .ctor(Action<object> callback, object stateForCallback, SynchronizationContext targetSyncContext, ExecutionContext targetExecutionContext, CancellationTokenSource cancellationTokenSource) { }

	// RVA: 0x148F1D0 Offset: 0x148D7D0 VA: 0x18148F1D0
	internal void ExecuteCallback() { }

	// RVA: 0x148F410 Offset: 0x148DA10 VA: 0x18148F410
	private static void ExecutionContextCallback(object obj) { }

}

