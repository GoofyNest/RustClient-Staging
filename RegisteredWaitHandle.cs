public sealed class RegisteredWaitHandle : MarshalByRefObject // TypeDefIndex: 830
{	// Fields
	private WaitHandle _waitObject; // 0x18
	private WaitOrTimerCallback _callback; // 0x20
	private object _state; // 0x28
	private WaitHandle _finalEvent; // 0x30
	private ManualResetEvent _cancelEvent; // 0x38
	private TimeSpan _timeout; // 0x40
	private int _callsInProcess; // 0x48
	private bool _executeOnlyOnce; // 0x4C
	private bool _unregistered; // 0x4D

	// Methods

	// RVA: 0x1498FE0 Offset: 0x14975E0 VA: 0x181498FE0
	internal void .ctor(WaitHandle waitObject, WaitOrTimerCallback callback, object state, TimeSpan timeout, bool executeOnlyOnce) { }

	// RVA: 0x1498B20 Offset: 0x1497120 VA: 0x181498B20
	internal void Wait(object state) { }

	// RVA: 0x14987F0 Offset: 0x1496DF0 VA: 0x1814987F0
	private void DoCallBack(object timedOut) { }

	[ComVisibleAttribute] // RVA: 0x75F80 Offset: 0x75380 VA: 0x180075F80
	// RVA: 0x14989B0 Offset: 0x1496FB0 VA: 0x1814989B0
	public bool Unregister(WaitHandle waitObject) { }

}

