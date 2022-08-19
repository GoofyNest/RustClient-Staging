public class MonumentBenchmarkScene : BenchmarkScene // TypeDefIndex: 8257
{	// Fields
	public string[] monumentPrefabs; // 0x40
	public Transform[] vantagePoints; // 0x48
	private bool isFinished; // 0x50

	// Properties
	public override bool SubmitsOwnResults { get; }

	// Methods

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 4
	public override bool get_SubmitsOwnResults() { }

	// RVA: 0x77B0F0 Offset: 0x7796F0 VA: 0x18077B0F0 Slot: 7
	public override void StartBenchmark() { }

	[IteratorStateMachineAttribute] // RVA: 0xA26F0 Offset: 0xA1AF0 VA: 0x1800A26F0
	// RVA: 0x77B070 Offset: 0x779670 VA: 0x18077B070
	private IEnumerator DoMonumentBenchmark() { }

	// RVA: 0x77B0E0 Offset: 0x7796E0 VA: 0x18077B0E0 Slot: 5
	public override bool ShouldEnd() { }

	// RVA: 0x77B170 Offset: 0x779770 VA: 0x18077B170
	public void .ctor() { }

}

private sealed class MonumentBenchmarkScene.<DoMonumentBenchmark>d__6 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 8258
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MonumentBenchmarkScene <>4__this; // 0x20
	private int <prefabNum>5__2; // 0x28
	private string <monumentName>5__3; // 0x30
	private GameObject <monument>5__4; // 0x38
	private Transform[] <>7__wrap4; // 0x40
	private int <>7__wrap5; // 0x48
	private Transform <vantage>5__7; // 0x50
	private int <i>5__8; // 0x58
	private double <frameTimes>5__9; // 0x60
	private string <ident>5__10; // 0x68
	private Stopwatch <sw>5__11; // 0x70
	private int <i>5__12; // 0x78

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x77EAC0 Offset: 0x77D0C0 VA: 0x18077EAC0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x77F470 Offset: 0x77DA70 VA: 0x18077F470 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

