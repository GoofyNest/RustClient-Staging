public sealed class XHashtable.ExtractKeyDelegate<TValue> : MulticastDelegate // TypeDefIndex: 5819
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	|-XHashtable.ExtractKeyDelegate<object>..ctor
	|-XHashtable.ExtractKeyDelegate<WeakReference>..ctor
	|-XHashtable.ExtractKeyDelegate<XName>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual string Invoke(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x133B8A0 Offset: 0x1339EA0 VA: 0x18133B8A0
	|-XHashtable.ExtractKeyDelegate<object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(TValue value, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380
	|-XHashtable.ExtractKeyDelegate<object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual string EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0
	|-XHashtable.ExtractKeyDelegate<object>.EndInvoke
	*/

}

private sealed class XHashtable.XHashtableState<TValue> // TypeDefIndex: 5820
{	// Fields
	private int[] buckets; // 0x0
	private XHashtable.XHashtableState.Entry<TValue>[] entries; // 0x0
	private int numEntries; // 0x0
	private XHashtable.ExtractKeyDelegate<TValue> extractKey; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(XHashtable.ExtractKeyDelegate<TValue> extractKey, int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A68580 Offset: 0x1A66B80 VA: 0x181A68580
	|-XHashtable.XHashtableState<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public XHashtable.XHashtableState<TValue> Resize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A67EC0 Offset: 0x1A664C0 VA: 0x181A67EC0
	|-XHashtable.XHashtableState<object>.Resize
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(string key, int index, int count, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A68480 Offset: 0x1A66A80 VA: 0x181A68480
	|-XHashtable.XHashtableState<object>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public bool TryAdd(TValue value, out TValue newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A68210 Offset: 0x1A66810 VA: 0x181A68210
	|-XHashtable.XHashtableState<object>.TryAdd
	*/

	// RVA: -1 Offset: -1
	private bool FindEntry(int hashCode, string key, int index, int count, ref int entryIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A67C90 Offset: 0x1A66290 VA: 0x181A67C90
	|-XHashtable.XHashtableState<object>.FindEntry
	*/

	// RVA: -1 Offset: -1
	private static int ComputeHashCode(string key, int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A67C10 Offset: 0x1A66210 VA: 0x181A67C10
	|-XHashtable.XHashtableState<object>.ComputeHashCode
	*/

}

private struct XHashtable.XHashtableState.Entry<TValue> // TypeDefIndex: 5821
{	// Fields
	public TValue Value; // 0x0
	public int HashCode; // 0x0
	public int Next; // 0x0

}

