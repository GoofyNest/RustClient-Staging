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
	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public IRgbService get_SteelSeries() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public IRgbService get_Razer() { }

	// RVA: 0x21C2290 Offset: 0x21C0890 VA: 0x1821C2290
	public void .ctor() { }

	// RVA: 0x21C1770 Offset: 0x21BFD70 VA: 0x1821C1770 Slot: 4
	public void Dispose() { }

	// RVA: 0x21C1DF0 Offset: 0x21C03F0 VA: 0x1821C1DF0
	public void StaticColor(Color color) { }

	// RVA: 0x21C1AF0 Offset: 0x21C00F0 VA: 0x1821C1AF0
	public void PulseColor(Color color, float duration = 1) { }

	// RVA: 0x21C1850 Offset: 0x21BFE50 VA: 0x1821C1850
	public void Event(RgbEventType type) { }

	[AsyncStateMachineAttribute] // RVA: 0xB9640 Offset: 0xB8A40 VA: 0x1800B9640
	// RVA: 0x21C21C0 Offset: 0x21C07C0 VA: 0x1821C21C0
	private void Worker() { }

	[AsyncStateMachineAttribute] // RVA: 0xB9870 Offset: 0xB8C70 VA: 0x1800B9870
	// RVA: 0x21C1CF0 Offset: 0x21C02F0 VA: 0x1821C1CF0
	private ValueTask StartServices() { }

	[AsyncStateMachineAttribute] // RVA: 0xB99E0 Offset: 0xB8DE0 VA: 0x1800B99E0
	// RVA: 0x21C1FC0 Offset: 0x21C05C0 VA: 0x1821C1FC0
	private ValueTask StopServices() { }

	[AsyncStateMachineAttribute] // RVA: 0xB9B10 Offset: 0xB8F10 VA: 0x1800B9B10
	// RVA: 0x21C20C0 Offset: 0x21C06C0 VA: 0x1821C20C0
	private ValueTask UpdateServices() { }

	// RVA: 0x21C1A00 Offset: 0x21C0000 VA: 0x1821C1A00
	public static void LogError(string message) { }

	// RVA: 0x21C1A60 Offset: 0x21C0060 VA: 0x1821C1A60
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

