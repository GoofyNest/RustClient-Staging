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
	|-RVA: 0x1773CE0 Offset: 0x17722E0 VA: 0x181773CE0
	|-Listeners.Action<object, object, Int32Enum, object, bool>.Invoke
	|
	|-RVA: 0x1774290 Offset: 0x1772890 VA: 0x181774290
	|-Listeners.Action<object, object, object, bool, bool>.Invoke
	|
	|-RVA: 0x17747D0 Offset: 0x1772DD0 VA: 0x1817747D0
	|-Listeners.Action<object, object, object, object, object>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1773B80 Offset: 0x1772180 VA: 0x181773B80
	|-Listeners.Action<object, object, Int32Enum, object, bool>.BeginInvoke
	|
	|-RVA: 0x1773C30 Offset: 0x1772230 VA: 0x181773C30
	|-Listeners.Action<object, object, object, bool, bool>.BeginInvoke
	|
	|-RVA: 0xFFA1E0 Offset: 0xFF87E0 VA: 0x180FFA1E0
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
	|-RVA: 0x1783FA0 Offset: 0x17825A0 VA: 0x181783FA0
	|-Listeners.Func<object, object, bool>.Invoke
	|
	|-RVA: 0xD5A640 Offset: 0xD58C40 VA: 0x180D5A640
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
	|-RVA: 0xFF70F0 Offset: 0xFF56F0 VA: 0x180FF70F0
	|-Listeners.Func<object, object, bool>.EndInvoke
	|
	|-RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0
	|-Listeners.Func<object, object, object>.EndInvoke
	*/

}

