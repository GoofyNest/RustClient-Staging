internal sealed class NativeUpdateCallback : MulticastDelegate // TypeDefIndex: 4520
{
// Namespace: UnityEngineInternal.Input
internal sealed class NativeUpdateCallback : MulticastDelegate // TypeDefIndex: 4520
	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xDE35D0 Offset: 0xDE1BD0 VA: 0x180DE35D0 Slot: 12
	public virtual void Invoke(NativeInputUpdateType updateType, NativeInputEventBuffer* buffer) { }

	// RVA: 0x2322A00 Offset: 0x2321000 VA: 0x182322A00 Slot: 13
	public virtual IAsyncResult BeginInvoke(NativeInputUpdateType updateType, NativeInputEventBuffer* buffer, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

