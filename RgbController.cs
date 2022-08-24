public class RgbController : IDisposable // TypeDefIndex: 7687
{	private readonly IReadOnlyList<IRgbService> _services; // 0x10
	private readonly CancellationTokenSource _cts; // 0x18
	private readonly ManualResetEventSlim _shutdown; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private readonly IRgbService <SteelSeries>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private readonly IRgbService <Razer>k__BackingField; // 0x30

	public IRgbService SteelSeries { get; }
	public IRgbService Razer { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public IRgbService get_SteelSeries() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public IRgbService get_Razer() { }

	public void .ctor() { }

	public void Dispose() { }

	public void StaticColor(Color color) { }

	public void PulseColor(Color color, float duration = 1) { }

	public void Event(RgbEventType type) { }

	[AsyncStateMachineAttribute] // RVA: 0xB97C0 Offset: 0xB8BC0 VA: 0x1800B97C0
	private void Worker() { }

	[AsyncStateMachineAttribute] // RVA: 0xB9980 Offset: 0xB8D80 VA: 0x1800B9980
	private ValueTask StartServices() { }

	[AsyncStateMachineAttribute] // RVA: 0xB9AF0 Offset: 0xB8EF0 VA: 0x1800B9AF0
	private ValueTask StopServices() { }

	[AsyncStateMachineAttribute] // RVA: 0xB9C40 Offset: 0xB9040 VA: 0x1800B9C40
	private ValueTask UpdateServices() { }

	public static void LogError(string message) { }

	public static void LogError(Exception exception, string message) { }

}

private struct RgbController.<Worker>d__14 : IAsyncStateMachine // TypeDefIndex: 7688
{	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public RgbController <>4__this; // 0x28
	private CancellationToken <ct>5__2; // 0x30
	private ValueTaskAwaiter <>u__1; // 0x38


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RgbController.<StartServices>d__15 : IAsyncStateMachine // TypeDefIndex: 7689
{	public int <>1__state; // 0x0
	public AsyncValueTaskMethodBuilder <>t__builder; // 0x8
	public RgbController <>4__this; // 0x28
	private IEnumerator<IRgbService> <>7__wrap1; // 0x30
	private IRgbService <service>5__3; // 0x38
	private ValueTaskAwaiter <>u__1; // 0x40


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RgbController.<StopServices>d__16 : IAsyncStateMachine // TypeDefIndex: 7690
{	public int <>1__state; // 0x0
	public AsyncValueTaskMethodBuilder <>t__builder; // 0x8
	public RgbController <>4__this; // 0x28
	private IEnumerator<IRgbService> <>7__wrap1; // 0x30
	private IRgbService <service>5__3; // 0x38
	private ValueTaskAwaiter <>u__1; // 0x40


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RgbController.<UpdateServices>d__17 : IAsyncStateMachine // TypeDefIndex: 7691
{	public int <>1__state; // 0x0
	public AsyncValueTaskMethodBuilder <>t__builder; // 0x8
	public RgbController <>4__this; // 0x28
	private IEnumerator<IRgbService> <>7__wrap1; // 0x30
	private IRgbService <service>5__3; // 0x38
	private ValueTaskAwaiter <>u__1; // 0x40


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

