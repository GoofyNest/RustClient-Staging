public sealed class CustomForce : MulticastDelegate // TypeDefIndex: 7127
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x228F7F0 Offset: 0x228DDF0 VA: 0x18228F7F0 Slot: 12
	public virtual Vector3 Invoke(float normalizedLength, Transform forceSpace) { }

	// RVA: 0x228F760 Offset: 0x228DD60 VA: 0x18228F760 Slot: 13
	public virtual IAsyncResult BeginInvoke(float normalizedLength, Transform forceSpace, AsyncCallback callback, object object) { }

	// RVA: 0x1977DD0 Offset: 0x19763D0 VA: 0x181977DD0 Slot: 14
	public virtual Vector3 EndInvoke(IAsyncResult result) { }

}

