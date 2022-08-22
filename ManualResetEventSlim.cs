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

	// RVA: 0x1495FB0 Offset: 0x14945B0 VA: 0x181495FB0
	public WaitHandle get_WaitHandle() { }

	// RVA: 0x1495EF0 Offset: 0x14944F0 VA: 0x181495EF0
	public bool get_IsSet() { }

	// RVA: 0x1496060 Offset: 0x1494660 VA: 0x181496060
	private void set_IsSet(bool value) { }

	// RVA: 0x1495F50 Offset: 0x1494550 VA: 0x181495F50
	public int get_SpinCount() { }

	// RVA: 0x1496090 Offset: 0x1494690 VA: 0x181496090
	private void set_SpinCount(int value) { }

	// RVA: 0x1496000 Offset: 0x1494600 VA: 0x181496000
	private int get_Waiters() { }

	// RVA: 0x14960D0 Offset: 0x14946D0 VA: 0x1814960D0
	private void set_Waiters(int value) { }

	// RVA: 0x1495D20 Offset: 0x1494320 VA: 0x181495D20
	public void .ctor(bool initialState) { }

	// RVA: 0x1495DA0 Offset: 0x14943A0 VA: 0x181495DA0
	public void .ctor(bool initialState, int spinCount) { }

	// RVA: 0x1494D80 Offset: 0x1493380 VA: 0x181494D80
	private void Initialize(bool initialState, int spinCount) { }

	// RVA: 0x1494CF0 Offset: 0x14932F0 VA: 0x181494CF0
	private void EnsureLockObjectCreated() { }

	// RVA: 0x1494E00 Offset: 0x1493400 VA: 0x181494E00
	private bool LazyInitializeEvent() { }

	// RVA: 0x1495050 Offset: 0x1493650 VA: 0x181495050
	public void Set() { }

	// RVA: 0x1495060 Offset: 0x1493660 VA: 0x181495060
	private void Set(bool duringCancellation) { }

	// RVA: 0x1495C20 Offset: 0x1494220 VA: 0x181495C20
	public bool Wait(TimeSpan timeout) { }

	// RVA: 0x1495590 Offset: 0x1493B90 VA: 0x181495590
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1494C80 Offset: 0x1493280 VA: 0x181494C80 Slot: 4
	public void Dispose() { }

	// RVA: 0x1494B40 Offset: 0x1493140 VA: 0x181494B40 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x14953E0 Offset: 0x14939E0 VA: 0x1814953E0
	private void ThrowIfDisposed() { }

	// RVA: 0x1494900 Offset: 0x1492F00 VA: 0x181494900
	private static void CancellationTokenCallback(object obj) { }

	// RVA: 0x1495460 Offset: 0x1493A60 VA: 0x181495460
	private void UpdateStateAtomically(int newBits, int updateBitsMask) { }

	// RVA: 0x1494D60 Offset: 0x1493360 VA: 0x181494D60
	private static int ExtractStatePortionAndShiftRight(int state, int mask, int rightBitShiftCount) { }

	// RVA: 0x1494D70 Offset: 0x1493370 VA: 0x181494D70
	private static int ExtractStatePortion(int state, int mask) { }

	// RVA: 0x1495CB0 Offset: 0x14942B0 VA: 0x181495CB0
	private static void .cctor() { }

}

