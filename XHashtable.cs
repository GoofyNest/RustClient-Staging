public sealed class XHashtable.ExtractKeyDelegate<TValue> : MulticastDelegate // TypeDefIndex: 5819
{
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	|-XHashtable.ExtractKeyDelegate<object>..ctor
	|-XHashtable.ExtractKeyDelegate<WeakReference>..ctor
	|-XHashtable.ExtractKeyDelegate<XName>..ctor
	*/

	public virtual string Invoke(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x133A9E0 Offset: 0x1338FE0 VA: 0x18133A9E0
	|-XHashtable.ExtractKeyDelegate<object>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(TValue value, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380
	|-XHashtable.ExtractKeyDelegate<object>.BeginInvoke
	*/

	public virtual string EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0
	|-XHashtable.ExtractKeyDelegate<object>.EndInvoke
	*/

}

private sealed class XHashtable.XHashtableState<TValue> // TypeDefIndex: 5820
{	private int[] buckets; // 0x0
	private XHashtable.XHashtableState.Entry<TValue>[] entries; // 0x0
	private int numEntries; // 0x0
	private XHashtable.ExtractKeyDelegate<TValue> extractKey; // 0x0


	public void .ctor(XHashtable.ExtractKeyDelegate<TValue> extractKey, int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A54AF0 Offset: 0x1A530F0 VA: 0x181A54AF0
	|-XHashtable.XHashtableState<object>..ctor
	*/

	public XHashtable.XHashtableState<TValue> Resize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A54430 Offset: 0x1A52A30 VA: 0x181A54430
	|-XHashtable.XHashtableState<object>.Resize
	*/

	public bool TryGetValue(string key, int index, int count, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A549F0 Offset: 0x1A52FF0 VA: 0x181A549F0
	|-XHashtable.XHashtableState<object>.TryGetValue
	*/

	public bool TryAdd(TValue value, out TValue newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A54780 Offset: 0x1A52D80 VA: 0x181A54780
	|-XHashtable.XHashtableState<object>.TryAdd
	*/

	private bool FindEntry(int hashCode, string key, int index, int count, ref int entryIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A54200 Offset: 0x1A52800 VA: 0x181A54200
	|-XHashtable.XHashtableState<object>.FindEntry
	*/

	private static int ComputeHashCode(string key, int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A54180 Offset: 0x1A52780 VA: 0x181A54180
	|-XHashtable.XHashtableState<object>.ComputeHashCode
	*/

}

private struct XHashtable.XHashtableState.Entry<TValue> // TypeDefIndex: 5821
{	public TValue Value; // 0x0
	public int HashCode; // 0x0
	public int Next; // 0x0

}

