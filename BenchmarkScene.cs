public class BenchmarkScene : MonoBehaviour // TypeDefIndex: 8259
{	// Fields
	public string BenchmarkTitle; // 0x18
	public string BenchmarkIdent; // 0x20
	public int MaxNumberOfFrames; // 0x28
	public int MaxNumberOfSeconds; // 0x2C
	protected int FrameCount; // 0x30
	protected TimeSince TimeSinceStarted; // 0x34
	protected TimeSince TimeSinceFrame; // 0x38
	protected float FrameTimes; // 0x3C
	public static bool IsRunningInEditor; // 0x0

	// Properties
	public virtual bool SubmitsOwnResults { get; }

	// Methods

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 4
	public virtual bool get_SubmitsOwnResults() { }

	// RVA: 0x50F100 Offset: 0x50D700 VA: 0x18050F100 Slot: 5
	public virtual bool ShouldEnd() { }

	// RVA: 0x50F150 Offset: 0x50D750 VA: 0x18050F150
	public void Start() { }

	[IteratorStateMachineAttribute] // RVA: 0xA2A60 Offset: 0xA1E60 VA: 0x1800A2A60
	// RVA: 0x50F090 Offset: 0x50D690 VA: 0x18050F090
	public IEnumerator RunBenchmark() { }

	// RVA: 0x50F070 Offset: 0x50D670 VA: 0x18050F070 Slot: 6
	public virtual float GetResult() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	public virtual void StartBenchmark() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public virtual void BenchmarkUpdate() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	public virtual void StopBenchmark() { }

	// RVA: 0x50F350 Offset: 0x50D950 VA: 0x18050F350
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

private sealed class BenchmarkScene.<RunBenchmark>d__13 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 8260
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public BenchmarkScene <>4__this; // 0x20
	private Stopwatch <sw>5__2; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x5263F0 Offset: 0x5249F0 VA: 0x1805263F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5268D0 Offset: 0x524ED0 VA: 0x1805268D0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

