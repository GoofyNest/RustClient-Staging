public sealed class RegisteredWaitHandle : MarshalByRefObject // TypeDefIndex: 830
{	private WaitHandle _waitObject; // 0x18
	private WaitOrTimerCallback _callback; // 0x20
	private object _state; // 0x28
	private WaitHandle _finalEvent; // 0x30
	private ManualResetEvent _cancelEvent; // 0x38
	private TimeSpan _timeout; // 0x40
	private int _callsInProcess; // 0x48
	private bool _executeOnlyOnce; // 0x4C
	private bool _unregistered; // 0x4D


	internal void .ctor(WaitHandle waitObject, WaitOrTimerCallback callback, object state, TimeSpan timeout, bool executeOnlyOnce) { }

	internal void Wait(object state) { }

	private void DoCallBack(object timedOut) { }

	[ComVisibleAttribute] // RVA: 0x760F0 Offset: 0x754F0 VA: 0x1800760F0
	public bool Unregister(WaitHandle waitObject) { }

}

