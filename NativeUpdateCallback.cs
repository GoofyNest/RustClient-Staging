internal sealed class NativeUpdateCallback : MulticastDelegate // TypeDefIndex: 4520
{
// Namespace: UnityEngineInternal.Input
internal sealed class NativeUpdateCallback : MulticastDelegate // TypeDefIndex: 4520
	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xDE2860 Offset: 0xDE0E60 VA: 0x180DE2860 Slot: 12
	public virtual void Invoke(NativeInputUpdateType updateType, NativeInputEventBuffer* buffer) { }

	// RVA: 0x2321F20 Offset: 0x2320520 VA: 0x182321F20 Slot: 13
	public virtual IAsyncResult BeginInvoke(NativeInputUpdateType updateType, NativeInputEventBuffer* buffer, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

