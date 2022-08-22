public sealed class WaitOrTimerCallback : MulticastDelegate // TypeDefIndex: 807
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x161D700 Offset: 0x161BD00 VA: 0x18161D700 Slot: 12
	public virtual void Invoke(object state, bool timedOut) { }

	// RVA: 0x161D670 Offset: 0x161BC70 VA: 0x18161D670 Slot: 13
	public virtual IAsyncResult BeginInvoke(object state, bool timedOut, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

