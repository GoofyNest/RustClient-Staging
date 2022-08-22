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

	// RVA: 0x1496EE0 Offset: 0x14954E0 VA: 0x181496EE0
	public WaitHandle get_WaitHandle() { }

	// RVA: 0x1496E20 Offset: 0x1495420 VA: 0x181496E20
	public bool get_IsSet() { }

	// RVA: 0x1496F90 Offset: 0x1495590 VA: 0x181496F90
	private void set_IsSet(bool value) { }

	// RVA: 0x1496E80 Offset: 0x1495480 VA: 0x181496E80
	public int get_SpinCount() { }

	// RVA: 0x1496FC0 Offset: 0x14955C0 VA: 0x181496FC0
	private void set_SpinCount(int value) { }

	// RVA: 0x1496F30 Offset: 0x1495530 VA: 0x181496F30
	private int get_Waiters() { }

	// RVA: 0x1497000 Offset: 0x1495600 VA: 0x181497000
	private void set_Waiters(int value) { }

	// RVA: 0x1496C50 Offset: 0x1495250 VA: 0x181496C50
	public void .ctor(bool initialState) { }

	// RVA: 0x1496CD0 Offset: 0x14952D0 VA: 0x181496CD0
	public void .ctor(bool initialState, int spinCount) { }

	// RVA: 0x1495CB0 Offset: 0x14942B0 VA: 0x181495CB0
	private void Initialize(bool initialState, int spinCount) { }

	// RVA: 0x1495C20 Offset: 0x1494220 VA: 0x181495C20
	private void EnsureLockObjectCreated() { }

	// RVA: 0x1495D30 Offset: 0x1494330 VA: 0x181495D30
	private bool LazyInitializeEvent() { }

	// RVA: 0x1495F80 Offset: 0x1494580 VA: 0x181495F80
	public void Set() { }

	// RVA: 0x1495F90 Offset: 0x1494590 VA: 0x181495F90
	private void Set(bool duringCancellation) { }

	// RVA: 0x1496B50 Offset: 0x1495150 VA: 0x181496B50
	public bool Wait(TimeSpan timeout) { }

	// RVA: 0x14964C0 Offset: 0x1494AC0 VA: 0x1814964C0
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1495BB0 Offset: 0x14941B0 VA: 0x181495BB0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1495A70 Offset: 0x1494070 VA: 0x181495A70 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1496310 Offset: 0x1494910 VA: 0x181496310
	private void ThrowIfDisposed() { }

	// RVA: 0x1495830 Offset: 0x1493E30 VA: 0x181495830
	private static void CancellationTokenCallback(object obj) { }

	// RVA: 0x1496390 Offset: 0x1494990 VA: 0x181496390
	private void UpdateStateAtomically(int newBits, int updateBitsMask) { }

	// RVA: 0x1495C90 Offset: 0x1494290 VA: 0x181495C90
	private static int ExtractStatePortionAndShiftRight(int state, int mask, int rightBitShiftCount) { }

	// RVA: 0x1495CA0 Offset: 0x14942A0 VA: 0x181495CA0
	private static int ExtractStatePortion(int state, int mask) { }

	// RVA: 0x1496BE0 Offset: 0x14951E0 VA: 0x181496BE0
	private static void .cctor() { }

}

