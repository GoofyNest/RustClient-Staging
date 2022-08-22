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

	// RVA: 0x14992A0 Offset: 0x14978A0 VA: 0x1814992A0
	internal void .ctor(WaitHandle waitObject, WaitOrTimerCallback callback, object state, TimeSpan timeout, bool executeOnlyOnce) { }

	// RVA: 0x1498DE0 Offset: 0x14973E0 VA: 0x181498DE0
	internal void Wait(object state) { }

	// RVA: 0x1498AB0 Offset: 0x14970B0 VA: 0x181498AB0
	private void DoCallBack(object timedOut) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x1498C70 Offset: 0x1497270 VA: 0x181498C70
	public bool Unregister(WaitHandle waitObject) { }

}

