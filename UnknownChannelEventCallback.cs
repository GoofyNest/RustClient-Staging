public sealed class UnknownChannelEventCallback : MulticastDelegate // TypeDefIndex: 7605
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13AAE40 Offset: 0x13A9440 VA: 0x1813AAE40 Slot: 12
	public virtual UnknownChannelEventAction Invoke(FourBitNumber statusByte, FourBitNumber channel) { }

	// RVA: 0x13AADB0 Offset: 0x13A93B0 VA: 0x1813AADB0 Slot: 13
	public virtual IAsyncResult BeginInvoke(FourBitNumber statusByte, FourBitNumber channel, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual UnknownChannelEventAction EndInvoke(IAsyncResult result) { }

}

