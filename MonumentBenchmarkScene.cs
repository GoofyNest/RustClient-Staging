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

	// RVA: 0x77B200 Offset: 0x779800 VA: 0x18077B200 Slot: 7
	public override void StartBenchmark() { }

	[IteratorStateMachineAttribute] // RVA: 0xA2780 Offset: 0xA1B80 VA: 0x1800A2780
	// RVA: 0x77B180 Offset: 0x779780 VA: 0x18077B180
	private IEnumerator DoMonumentBenchmark() { }

	// RVA: 0x77B1F0 Offset: 0x7797F0 VA: 0x18077B1F0 Slot: 5
	public override bool ShouldEnd() { }

	// RVA: 0x77B280 Offset: 0x779880 VA: 0x18077B280
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x77EBD0 Offset: 0x77D1D0 VA: 0x18077EBD0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x77F580 Offset: 0x77DB80 VA: 0x18077F580 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

