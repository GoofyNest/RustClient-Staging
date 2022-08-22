public sealed class MemberFilter : MulticastDelegate // TypeDefIndex: 534
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1769480 Offset: 0x1767A80 VA: 0x181769480 Slot: 12
	public virtual bool Invoke(MemberInfo m, object filterCriteria) { }

	// RVA: 0xAE4D10 Offset: 0xAE3310 VA: 0x180AE4D10 Slot: 13
	public virtual IAsyncResult BeginInvoke(MemberInfo m, object filterCriteria, AsyncCallback callback, object object) { }

	// RVA: 0xFF6FB0 Offset: 0xFF55B0 VA: 0x180FF6FB0 Slot: 14
	public virtual bool EndInvoke(IAsyncResult result) { }

}

