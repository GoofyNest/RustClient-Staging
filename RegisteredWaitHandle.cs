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

	// RVA: 0x1498370 Offset: 0x1496970 VA: 0x181498370
	internal void .ctor(WaitHandle waitObject, WaitOrTimerCallback callback, object state, TimeSpan timeout, bool executeOnlyOnce) { }

	// RVA: 0x1497EB0 Offset: 0x14964B0 VA: 0x181497EB0
	internal void Wait(object state) { }

	// RVA: 0x1497B80 Offset: 0x1496180 VA: 0x181497B80
	private void DoCallBack(object timedOut) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x1497D40 Offset: 0x1496340 VA: 0x181497D40
	public bool Unregister(WaitHandle waitObject) { }

}

