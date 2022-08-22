public sealed class ConditionalWeakTable.CreateValueCallback<TKey, TValue> : MulticastDelegate // TypeDefIndex: 1316
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	|-ConditionalWeakTable.CreateValueCallback<HttpWebRequest, NtlmSession>..ctor
	|-ConditionalWeakTable.CreateValueCallback<object, object>..ctor
	|-ConditionalWeakTable.CreateValueCallback<object, OSSpecificSynchronizationContext>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual TValue Invoke(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x133A9A0 Offset: 0x1338FA0 VA: 0x18133A9A0
	|-ConditionalWeakTable.CreateValueCallback<object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(TKey key, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380
	|-ConditionalWeakTable.CreateValueCallback<object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual TValue EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0
	|-ConditionalWeakTable.CreateValueCallback<object, object>.EndInvoke
	*/

}

