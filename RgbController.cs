public class RgbController : IDisposable // TypeDefIndex: 7687
{	// Fields
	private readonly IReadOnlyList<IRgbService> _services; // 0x10
	private readonly CancellationTokenSource _cts; // 0x18
	private readonly ManualResetEventSlim _shutdown; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly IRgbService <SteelSeries>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly IRgbService <Razer>k__BackingField; // 0x30

	// Properties
	public IRgbService SteelSeries { get; }
	public IRgbService Razer { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public IRgbService get_SteelSeries() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public IRgbService get_Razer() { }

	// RVA: 0x21C1970 Offset: 0x21BFF70 VA: 0x1821C1970
	public void .ctor() { }

	// RVA: 0x21C0E50 Offset: 0x21BF450 VA: 0x1821C0E50 Slot: 4
	public void Dispose() { }

	// RVA: 0x21C14D0 Offset: 0x21BFAD0 VA: 0x1821C14D0
	public void StaticColor(Color color) { }

	// RVA: 0x21C11D0 Offset: 0x21BF7D0 VA: 0x1821C11D0
	public void PulseColor(Color color, float duration = 1) { }

	// RVA: 0x21C0F30 Offset: 0x21BF530 VA: 0x1821C0F30
	public void Event(RgbEventType type) { }

	[AsyncStateMachineAttribute] // RVA: 0xB95A0 Offset: 0xB89A0 VA: 0x1800B95A0
	// RVA: 0x21C18A0 Offset: 0x21BFEA0 VA: 0x1821C18A0
	private void Worker() { }

	[AsyncStateMachineAttribute] // RVA: 0xB97D0 Offset: 0xB8BD0 VA: 0x1800B97D0
	// RVA: 0x21C13D0 Offset: 0x21BF9D0 VA: 0x1821C13D0
	private ValueTask StartServices() { }

	[AsyncStateMachineAttribute] // RVA: 0xB9910 Offset: 0xB8D10 VA: 0x1800B9910
	// RVA: 0x21C16A0 Offset: 0x21BFCA0 VA: 0x1821C16A0
	private ValueTask StopServices() { }

	[AsyncStateMachineAttribute] // RVA: 0xB9A70 Offset: 0xB8E70 VA: 0x1800B9A70
	// RVA: 0x21C17A0 Offset: 0x21BFDA0 VA: 0x1821C17A0
	private ValueTask UpdateServices() { }

	// RVA: 0x21C10E0 Offset: 0x21BF6E0 VA: 0x1821C10E0
	public static void LogError(string message) { }

	// RVA: 0x21C1140 Offset: 0x21BF740 VA: 0x1821C1140
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

	// RVA: 0x237070 Offset: 0x236470 VA: 0x180237070 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF15B0 Offset: 0xF09B0 VA: 0x1800F15B0 Slot: 5
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

	// RVA: 0x237000 Offset: 0x236400 VA: 0x180237000 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x236FF0 Offset: 0x2363F0 VA: 0x180236FF0 Slot: 5
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

	// RVA: 0x237030 Offset: 0x236430 VA: 0x180237030 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x236FF0 Offset: 0x2363F0 VA: 0x180236FF0 Slot: 5
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

	// RVA: 0x237050 Offset: 0x236450 VA: 0x180237050 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x236FF0 Offset: 0x2363F0 VA: 0x180236FF0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

