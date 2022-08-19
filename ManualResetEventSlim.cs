public class ManualResetEventSlim : IDisposable // TypeDefIndex: 758
{	// Fields
	private const int DEFAULT_SPIN_SP = 1;
	private const int DEFAULT_SPIN_MP = 10;
	private object m_lock; // 0x10
	private ManualResetEvent m_eventObj; // 0x18
	private int m_combinedState; // 0x20
	private const int SignalledState_BitMask = -2147483648;
	private const int SignalledState_ShiftCount = 31;
	private const int Dispose_BitMask = 1073741824;
	private const int SpinCountState_BitMask = 1073217536;
	private const int SpinCountState_ShiftCount = 19;
	private const int SpinCountState_MaxValue = 2047;
	private const int NumWaitersState_BitMask = 524287;
	private const int NumWaitersState_ShiftCount = 0;
	private const int NumWaitersState_MaxValue = 524287;
	private static Action<object> s_cancellationTokenCallback; // 0x0

	// Properties
	public WaitHandle WaitHandle { get; }
	public bool IsSet { get; set; }
	public int SpinCount { get; set; }
	private int Waiters { get; set; }

	// Methods

	// RVA: 0x1496C20 Offset: 0x1495220 VA: 0x181496C20
	public WaitHandle get_WaitHandle() { }

	// RVA: 0x1496B60 Offset: 0x1495160 VA: 0x181496B60
	public bool get_IsSet() { }

	// RVA: 0x1496CD0 Offset: 0x14952D0 VA: 0x181496CD0
	private void set_IsSet(bool value) { }

	// RVA: 0x1496BC0 Offset: 0x14951C0 VA: 0x181496BC0
	public int get_SpinCount() { }

	// RVA: 0x1496D00 Offset: 0x1495300 VA: 0x181496D00
	private void set_SpinCount(int value) { }

	// RVA: 0x1496C70 Offset: 0x1495270 VA: 0x181496C70
	private int get_Waiters() { }

	// RVA: 0x1496D40 Offset: 0x1495340 VA: 0x181496D40
	private void set_Waiters(int value) { }

	// RVA: 0x1496990 Offset: 0x1494F90 VA: 0x181496990
	public void .ctor(bool initialState) { }

	// RVA: 0x1496A10 Offset: 0x1495010 VA: 0x181496A10
	public void .ctor(bool initialState, int spinCount) { }

	// RVA: 0x14959F0 Offset: 0x1493FF0 VA: 0x1814959F0
	private void Initialize(bool initialState, int spinCount) { }

	// RVA: 0x1495960 Offset: 0x1493F60 VA: 0x181495960
	private void EnsureLockObjectCreated() { }

	// RVA: 0x1495A70 Offset: 0x1494070 VA: 0x181495A70
	private bool LazyInitializeEvent() { }

	// RVA: 0x1495CC0 Offset: 0x14942C0 VA: 0x181495CC0
	public void Set() { }

	// RVA: 0x1495CD0 Offset: 0x14942D0 VA: 0x181495CD0
	private void Set(bool duringCancellation) { }

	// RVA: 0x1496890 Offset: 0x1494E90 VA: 0x181496890
	public bool Wait(TimeSpan timeout) { }

	// RVA: 0x1496200 Offset: 0x1494800 VA: 0x181496200
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x14958F0 Offset: 0x1493EF0 VA: 0x1814958F0 Slot: 4
	public void Dispose() { }

	// RVA: 0x14957B0 Offset: 0x1493DB0 VA: 0x1814957B0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1496050 Offset: 0x1494650 VA: 0x181496050
	private void ThrowIfDisposed() { }

	// RVA: 0x1495570 Offset: 0x1493B70 VA: 0x181495570
	private static void CancellationTokenCallback(object obj) { }

	// RVA: 0x14960D0 Offset: 0x14946D0 VA: 0x1814960D0
	private void UpdateStateAtomically(int newBits, int updateBitsMask) { }

	// RVA: 0x14959D0 Offset: 0x1493FD0 VA: 0x1814959D0
	private static int ExtractStatePortionAndShiftRight(int state, int mask, int rightBitShiftCount) { }

	// RVA: 0x14959E0 Offset: 0x1493FE0 VA: 0x1814959E0
	private static int ExtractStatePortion(int state, int mask) { }

	// RVA: 0x1496920 Offset: 0x1494F20 VA: 0x181496920
	private static void .cctor() { }

}

