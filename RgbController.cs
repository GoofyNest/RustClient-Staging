public class RgbController : IDisposable // TypeDefIndex: 7687
{	// Fields
	private readonly IReadOnlyList<IRgbService> _services; // 0x10
	private readonly CancellationTokenSource _cts; // 0x18
	private readonly ManualResetEventSlim _shutdown; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly IRgbService <SteelSeries>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly IRgbService <Razer>k__BackingField; // 0x30

	// Properties
	public IRgbService SteelSeries { get; }
	public IRgbService Razer { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public IRgbService get_SteelSeries() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public IRgbService get_Razer() { }

	// RVA: 0x21C17B0 Offset: 0x21BFDB0 VA: 0x1821C17B0
	public void .ctor() { }

	// RVA: 0x21C0C90 Offset: 0x21BF290 VA: 0x1821C0C90 Slot: 4
	public void Dispose() { }

	// RVA: 0x21C1310 Offset: 0x21BF910 VA: 0x1821C1310
	public void StaticColor(Color color) { }

	// RVA: 0x21C1010 Offset: 0x21BF610 VA: 0x1821C1010
	public void PulseColor(Color color, float duration = 1) { }

	// RVA: 0x21C0D70 Offset: 0x21BF370 VA: 0x1821C0D70
	public void Event(RgbEventType type) { }

	[AsyncStateMachineAttribute] // RVA: 0xB9640 Offset: 0xB8A40 VA: 0x1800B9640
	// RVA: 0x21C16E0 Offset: 0x21BFCE0 VA: 0x1821C16E0
	private void Worker() { }

	[AsyncStateMachineAttribute] // RVA: 0xB9870 Offset: 0xB8C70 VA: 0x1800B9870
	// RVA: 0x21C1210 Offset: 0x21BF810 VA: 0x1821C1210
	private ValueTask StartServices() { }

	[AsyncStateMachineAttribute] // RVA: 0xB99E0 Offset: 0xB8DE0 VA: 0x1800B99E0
	// RVA: 0x21C14E0 Offset: 0x21BFAE0 VA: 0x1821C14E0
	private ValueTask StopServices() { }

	[AsyncStateMachineAttribute] // RVA: 0xB9B10 Offset: 0xB8F10 VA: 0x1800B9B10
	// RVA: 0x21C15E0 Offset: 0x21BFBE0 VA: 0x1821C15E0
	private ValueTask UpdateServices() { }

	// RVA: 0x21C0F20 Offset: 0x21BF520 VA: 0x1821C0F20
	public static void LogError(string message) { }

	// RVA: 0x21C0F80 Offset: 0x21BF580 VA: 0x1821C0F80
	public static void LogError(Exception exception, string message) { }

}

private struct RgbController.<Worker>d__14 : IAsyncStateMachine // TypeDefIndex: 7688
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public RgbController <>4__this; // 0x28
	private CancellationToken <ct>5__2; // 0x30
	private ValueTaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x236FF0 Offset: 0x2363F0 VA: 0x180236FF0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF1530 Offset: 0xF0930 VA: 0x1800F1530 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RgbController.<StartServices>d__15 : IAsyncStateMachine // TypeDefIndex: 7689
{	// Fields
	public int <>1__state; // 0x0
	public AsyncValueTaskMethodBuilder <>t__builder; // 0x8
	public RgbController <>4__this; // 0x28
	private IEnumerator<IRgbService> <>7__wrap1; // 0x30
	private IRgbService <service>5__3; // 0x38
	private ValueTaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x236F80 Offset: 0x236380 VA: 0x180236F80 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x236F70 Offset: 0x236370 VA: 0x180236F70 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RgbController.<StopServices>d__16 : IAsyncStateMachine // TypeDefIndex: 7690
{	// Fields
	public int <>1__state; // 0x0
	public AsyncValueTaskMethodBuilder <>t__builder; // 0x8
	public RgbController <>4__this; // 0x28
	private IEnumerator<IRgbService> <>7__wrap1; // 0x30
	private IRgbService <service>5__3; // 0x38
	private ValueTaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x236FB0 Offset: 0x2363B0 VA: 0x180236FB0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x236F70 Offset: 0x236370 VA: 0x180236F70 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RgbController.<UpdateServices>d__17 : IAsyncStateMachine // TypeDefIndex: 7691
{	// Fields
	public int <>1__state; // 0x0
	public AsyncValueTaskMethodBuilder <>t__builder; // 0x8
	public RgbController <>4__this; // 0x28
	private IEnumerator<IRgbService> <>7__wrap1; // 0x30
	private IRgbService <service>5__3; // 0x38
	private ValueTaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x236FD0 Offset: 0x2363D0 VA: 0x180236FD0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x236F70 Offset: 0x236370 VA: 0x180236F70 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

