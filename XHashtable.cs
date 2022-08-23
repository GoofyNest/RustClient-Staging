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
	|-RVA: 0x133AAE0 Offset: 0x13390E0 VA: 0x18133AAE0
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
	|-RVA: 0x1A54BF0 Offset: 0x1A531F0 VA: 0x181A54BF0
	|-XHashtable.XHashtableState<object>..ctor
	*/

	public XHashtable.XHashtableState<TValue> Resize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A54530 Offset: 0x1A52B30 VA: 0x181A54530
	|-XHashtable.XHashtableState<object>.Resize
	*/

	public bool TryGetValue(string key, int index, int count, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A54AF0 Offset: 0x1A530F0 VA: 0x181A54AF0
	|-XHashtable.XHashtableState<object>.TryGetValue
	*/

	public bool TryAdd(TValue value, out TValue newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A54880 Offset: 0x1A52E80 VA: 0x181A54880
	|-XHashtable.XHashtableState<object>.TryAdd
	*/

	private bool FindEntry(int hashCode, string key, int index, int count, ref int entryIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A54300 Offset: 0x1A52900 VA: 0x181A54300
	|-XHashtable.XHashtableState<object>.FindEntry
	*/

	private static int ComputeHashCode(string key, int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A54280 Offset: 0x1A52880 VA: 0x181A54280
	|-XHashtable.XHashtableState<object>.ComputeHashCode
	*/

}

private struct XHashtable.XHashtableState.Entry<TValue> // TypeDefIndex: 5821
{	public TValue Value; // 0x0
	public int HashCode; // 0x0
	public int Next; // 0x0

}

