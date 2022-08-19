internal sealed class Listeners.Action<TElem, T1, T2, T3, T4> : MulticastDelegate // TypeDefIndex: 4305
{	// Methods

	// RVA: -1 Offset: -1
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

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1775D90 Offset: 0x1774390 VA: 0x181775D90
	|-Listeners.Action<object, object, Int32Enum, object, bool>.Invoke
	|
	|-RVA: 0x1776340 Offset: 0x1774940 VA: 0x181776340
	|-Listeners.Action<object, object, object, bool, bool>.Invoke
	|
	|-RVA: 0x1776880 Offset: 0x1774E80 VA: 0x181776880
	|-Listeners.Action<object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1775C30 Offset: 0x1774230 VA: 0x181775C30
	|-Listeners.Action<object, object, Int32Enum, object, bool>.BeginInvoke
	|
	|-RVA: 0x1775CE0 Offset: 0x17742E0 VA: 0x181775CE0
	|-Listeners.Action<object, object, object, bool, bool>.BeginInvoke
	|
	|-RVA: 0xFF9340 Offset: 0xFF7940 VA: 0x180FF9340
	|-Listeners.Action<object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
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
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	|-Listeners.Func<DataViewListener, DataViewListener, bool>..ctor
	|-Listeners.Func<object, object, bool>..ctor
	|-Listeners.Func<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual TResult Invoke(T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1786050 Offset: 0x1784650 VA: 0x181786050
	|-Listeners.Func<object, object, bool>.Invoke
	|
	|-RVA: 0xD59790 Offset: 0xD57D90 VA: 0x180D59790
	|-Listeners.Func<object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(T1 arg1, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380
	|-Listeners.Func<object, object, bool>.BeginInvoke
	|-Listeners.Func<object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFF6250 Offset: 0xFF4850 VA: 0x180FF6250
	|-Listeners.Func<object, object, bool>.EndInvoke
	|
	|-RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0
	|-Listeners.Func<object, object, object>.EndInvoke
	*/

}
