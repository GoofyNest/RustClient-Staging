internal sealed class Listeners.Action<TElem, T1, T2, T3, T4> : MulticastDelegate // TypeDefIndex: 4305
{
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	|-Listeners.Action<DataViewListener, DataViewListener, ListChangedEventArgs, bool, bool>..ctor
	|-Listeners.Action<DataViewListener, DataViewListener, ListChangedType, DataRow, bool>..ctor
	|-Listeners.Action<object, object, Int32Enum, object, bool>..ctor
	|-Listeners.Action<object, object, object, bool, bool>..ctor
	|-Listeners.Action<object, object, object, object, object>..ctor
	*/

	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1773CA0 Offset: 0x17722A0 VA: 0x181773CA0
	|-Listeners.Action<object, object, Int32Enum, object, bool>.Invoke
	|
	|-RVA: 0x1774250 Offset: 0x1772850 VA: 0x181774250
	|-Listeners.Action<object, object, object, bool, bool>.Invoke
	|
	|-RVA: 0x1774790 Offset: 0x1772D90 VA: 0x181774790
	|-Listeners.Action<object, object, object, object, object>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1773B40 Offset: 0x1772140 VA: 0x181773B40
	|-Listeners.Action<object, object, Int32Enum, object, bool>.BeginInvoke
	|
	|-RVA: 0x1773BF0 Offset: 0x17721F0 VA: 0x181773BF0
	|-Listeners.Action<object, object, object, bool, bool>.BeginInvoke
	|
	|-RVA: 0xFFA1A0 Offset: 0xFF87A0 VA: 0x180FFA1A0
	|-Listeners.Action<object, object, object, object, object>.BeginInvoke
	*/

	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0
	|-Listeners.Action<object, object, Int32Enum, object, bool>.EndInvoke
	|-Listeners.Action<object, object, object, bool, bool>.EndInvoke
	|-Listeners.Action<object, object, object, object, object>.EndInvoke
	*/

}

internal sealed class Listeners.Func<TElem, T1, TResult> : MulticastDelegate // TypeDefIndex: 4306
{
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	|-Listeners.Func<DataViewListener, DataViewListener, bool>..ctor
	|-Listeners.Func<object, object, bool>..ctor
	|-Listeners.Func<object, object, object>..ctor
	*/

	public virtual TResult Invoke(T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1783F60 Offset: 0x1782560 VA: 0x181783F60
	|-Listeners.Func<object, object, bool>.Invoke
	|
	|-RVA: 0xD5A600 Offset: 0xD58C00 VA: 0x180D5A600
	|-Listeners.Func<object, object, object>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(T1 arg1, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380
	|-Listeners.Func<object, object, bool>.BeginInvoke
	|-Listeners.Func<object, object, object>.BeginInvoke
	*/

	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFF70B0 Offset: 0xFF56B0 VA: 0x180FF70B0
	|-Listeners.Func<object, object, bool>.EndInvoke
	|
	|-RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0
	|-Listeners.Func<object, object, object>.EndInvoke
	*/

}

