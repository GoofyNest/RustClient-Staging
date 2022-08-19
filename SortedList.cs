public class SortedList : IDictionary, ICollection, IEnumerable, ICloneable // TypeDefIndex: 1417
{	// Fields
	private object[] keys; // 0x10
	private object[] values; // 0x18
	private int _size; // 0x20
	private int version; // 0x24
	private IComparer comparer; // 0x28
	private SortedList.KeyList keyList; // 0x30
	private SortedList.ValueList valueList; // 0x38
	private object _syncRoot; // 0x40
	private const int _defaultCapacity = 16;
	private static object[] emptyArray; // 0x0

	// Properties
	public virtual int Capacity { get; set; }
	public virtual int Count { get; }
	public virtual ICollection Keys { get; }
	public virtual ICollection Values { get; }
	public virtual bool IsReadOnly { get; }
	public virtual object SyncRoot { get; }
	public virtual object Item { get; set; }

	// Methods

	// RVA: 0x146A340 Offset: 0x1468940 VA: 0x18146A340
	public void .ctor() { }

	// RVA: 0x1469AD0 Offset: 0x14680D0 VA: 0x181469AD0
	private void Init() { }

	// RVA: 0x146A1A0 Offset: 0x14687A0 VA: 0x18146A1A0
	public void .ctor(int initialCapacity) { }

	// RVA: 0x146A4B0 Offset: 0x1468AB0 VA: 0x18146A4B0
	public void .ctor(IComparer comparer) { }

	// RVA: 0x146A4F0 Offset: 0x1468AF0 VA: 0x18146A4F0
	public void .ctor(IComparer comparer, int capacity) { }

	// RVA: 0x1468F50 Offset: 0x1467550 VA: 0x181468F50 Slot: 19
	public virtual void Add(object key, object value) { }

	// RVA: 0x9EB580 Offset: 0x9E9B80 VA: 0x1809EB580 Slot: 20
	public virtual int get_Capacity() { }

	// RVA: 0x146A660 Offset: 0x1468C60 VA: 0x18146A660 Slot: 21
	public virtual void set_Capacity(int value) { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0 Slot: 22
	public virtual int get_Count() { }

	// RVA: 0x146A5B0 Offset: 0x1468BB0 VA: 0x18146A5B0 Slot: 23
	public virtual ICollection get_Keys() { }

	// RVA: 0x146A640 Offset: 0x1468C40 VA: 0x18146A640 Slot: 24
	public virtual ICollection get_Values() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 25
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x146A5D0 Offset: 0x1468BD0 VA: 0x18146A5D0 Slot: 26
	public virtual object get_SyncRoot() { }

	// RVA: 0x14690E0 Offset: 0x14676E0 VA: 0x1814690E0 Slot: 27
	public virtual void Clear() { }

	// RVA: 0x1469120 Offset: 0x1467720 VA: 0x181469120 Slot: 28
	public virtual object Clone() { }

	// RVA: 0x1469360 Offset: 0x1467960 VA: 0x181469360 Slot: 29
	public virtual bool Contains(object key) { }

	// RVA: 0x1469360 Offset: 0x1467960 VA: 0x181469360 Slot: 30
	public virtual bool ContainsKey(object key) { }

	// RVA: 0x1469380 Offset: 0x1467980 VA: 0x181469380 Slot: 31
	public virtual bool ContainsValue(object value) { }

	// RVA: 0x14693A0 Offset: 0x14679A0 VA: 0x1814693A0 Slot: 32
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1469640 Offset: 0x1467C40 VA: 0x181469640
	private void EnsureCapacity(int min) { }

	// RVA: 0x1469690 Offset: 0x1467C90 VA: 0x181469690 Slot: 33
	public virtual object GetByIndex(int index) { }

	// RVA: 0x146A0A0 Offset: 0x14686A0 VA: 0x18146A0A0 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1469750 Offset: 0x1467D50 VA: 0x181469750 Slot: 34
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x1469870 Offset: 0x1467E70 VA: 0x181469870 Slot: 35
	public virtual object GetKey(int index) { }

	// RVA: 0x14697E0 Offset: 0x1467DE0 VA: 0x1814697E0 Slot: 36
	public virtual IList GetKeyList() { }

	// RVA: 0x1469930 Offset: 0x1467F30 VA: 0x181469930 Slot: 37
	public virtual IList GetValueList() { }

	// RVA: 0x146A550 Offset: 0x1468B50 VA: 0x18146A550 Slot: 38
	public virtual object get_Item(object key) { }

	// RVA: 0x146A820 Offset: 0x1468E20 VA: 0x18146A820 Slot: 39
	public virtual void set_Item(object key, object value) { }

	// RVA: 0x14699C0 Offset: 0x1467FC0 VA: 0x1814699C0 Slot: 40
	public virtual int IndexOfKey(object key) { }

	// RVA: 0x1469A70 Offset: 0x1468070 VA: 0x181469A70 Slot: 41
	public virtual int IndexOfValue(object value) { }

	// RVA: 0x1469C40 Offset: 0x1468240 VA: 0x181469C40
	private void Insert(int index, object key, object value) { }

	// RVA: 0x1469DE0 Offset: 0x14683E0 VA: 0x181469DE0 Slot: 42
	public virtual void RemoveAt(int index) { }

	// RVA: 0x1469F60 Offset: 0x1468560 VA: 0x181469F60 Slot: 43
	public virtual void Remove(object key) { }

	// RVA: 0x1469FA0 Offset: 0x14685A0 VA: 0x181469FA0
	public static SortedList Synchronized(SortedList list) { }

	// RVA: 0x146A130 Offset: 0x1468730 VA: 0x18146A130
	private static void .cctor() { }

}

private class SortedList.SyncSortedList : SortedList // TypeDefIndex: 1418
{	// Fields
	private SortedList _list; // 0x48
	private object _root; // 0x50

	// Properties
	public override int Count { get; }
	public override object SyncRoot { get; }
	public override bool IsReadOnly { get; }
	public override object Item { get; set; }
	public override int Capacity { get; }

	// Methods

	// RVA: 0x146D1C0 Offset: 0x146B7C0 VA: 0x18146D1C0
	internal void .ctor(SortedList list) { }

	// RVA: 0x146D340 Offset: 0x146B940 VA: 0x18146D340 Slot: 22
	public override int get_Count() { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870 Slot: 26
	public override object get_SyncRoot() { }

	// RVA: 0x146D420 Offset: 0x146BA20 VA: 0x18146D420 Slot: 25
	public override bool get_IsReadOnly() { }

	// RVA: 0x146D450 Offset: 0x146BA50 VA: 0x18146D450 Slot: 38
	public override object get_Item(object key) { }

	// RVA: 0x146D530 Offset: 0x146BB30 VA: 0x18146D530 Slot: 39
	public override void set_Item(object key, object value) { }

	// RVA: 0x146C360 Offset: 0x146A960 VA: 0x18146C360 Slot: 19
	public override void Add(object key, object value) { }

	// RVA: 0x146D260 Offset: 0x146B860 VA: 0x18146D260 Slot: 20
	public override int get_Capacity() { }

	// RVA: 0x146C440 Offset: 0x146AA40 VA: 0x18146C440 Slot: 27
	public override void Clear() { }

	// RVA: 0x146C500 Offset: 0x146AB00 VA: 0x18146C500 Slot: 28
	public override object Clone() { }

	// RVA: 0x146C7C0 Offset: 0x146ADC0 VA: 0x18146C7C0 Slot: 29
	public override bool Contains(object key) { }

	// RVA: 0x146C5E0 Offset: 0x146ABE0 VA: 0x18146C5E0 Slot: 30
	public override bool ContainsKey(object key) { }

	// RVA: 0x146C6D0 Offset: 0x146ACD0 VA: 0x18146C6D0 Slot: 31
	public override bool ContainsValue(object key) { }

	// RVA: 0x146C8B0 Offset: 0x146AEB0 VA: 0x18146C8B0 Slot: 32
	public override void CopyTo(Array array, int index) { }

	// RVA: 0x146C990 Offset: 0x146AF90 VA: 0x18146C990 Slot: 33
	public override object GetByIndex(int index) { }

	// RVA: 0x146CA70 Offset: 0x146B070 VA: 0x18146CA70 Slot: 34
	public override IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x146CC30 Offset: 0x146B230 VA: 0x18146CC30 Slot: 35
	public override object GetKey(int index) { }

	// RVA: 0x146CB50 Offset: 0x146B150 VA: 0x18146CB50 Slot: 36
	public override IList GetKeyList() { }

	// RVA: 0x146CD10 Offset: 0x146B310 VA: 0x18146CD10 Slot: 37
	public override IList GetValueList() { }

	// RVA: 0x146CDF0 Offset: 0x146B3F0 VA: 0x18146CDF0 Slot: 40
	public override int IndexOfKey(object key) { }

	// RVA: 0x146CF40 Offset: 0x146B540 VA: 0x18146CF40 Slot: 41
	public override int IndexOfValue(object value) { }

	// RVA: 0x146D020 Offset: 0x146B620 VA: 0x18146D020 Slot: 42
	public override void RemoveAt(int index) { }

	// RVA: 0x146D0F0 Offset: 0x146B6F0 VA: 0x18146D0F0 Slot: 43
	public override void Remove(object key) { }

}

private class SortedList.SortedListEnumerator : IDictionaryEnumerator, IEnumerator, ICloneable // TypeDefIndex: 1419
{	// Fields
	private SortedList sortedList; // 0x10
	private object key; // 0x18
	private object value; // 0x20
	private int index; // 0x28
	private int startIndex; // 0x2C
	private int endIndex; // 0x30
	private int version; // 0x34
	private bool current; // 0x38
	private int getObjectRetType; // 0x3C

	// Properties
	public virtual object Key { get; }
	public virtual DictionaryEntry Entry { get; }
	public virtual object Current { get; }
	public virtual object Value { get; }

	// Methods

	// RVA: 0x1468B10 Offset: 0x1467110 VA: 0x181468B10
	internal void .ctor(SortedList sortedList, int index, int count, int getObjRetType) { }

	// RVA: 0xD71020 Offset: 0xD6F620 VA: 0x180D71020 Slot: 10
	public object Clone() { }

	// RVA: 0x1468D90 Offset: 0x1467390 VA: 0x181468D90 Slot: 11
	public virtual object get_Key() { }

	// RVA: 0x1468920 Offset: 0x1466F20 VA: 0x181468920 Slot: 12
	public virtual bool MoveNext() { }

	// RVA: 0x1468C90 Offset: 0x1467290 VA: 0x181468C90 Slot: 13
	public virtual DictionaryEntry get_Entry() { }

	// RVA: 0x1468B90 Offset: 0x1467190 VA: 0x181468B90 Slot: 14
	public virtual object get_Current() { }

	// RVA: 0x1468E70 Offset: 0x1467470 VA: 0x181468E70 Slot: 15
	public virtual object get_Value() { }

	// RVA: 0x1468A60 Offset: 0x1467060 VA: 0x181468A60 Slot: 16
	public virtual void Reset() { }

}

private class SortedList.KeyList : IList, ICollection, IEnumerable // TypeDefIndex: 1420
{	// Fields
	private SortedList sortedList; // 0x10

	// Properties
	public virtual int Count { get; }
	public virtual bool IsReadOnly { get; }
	public virtual bool IsFixedSize { get; }
	public virtual object SyncRoot { get; }
	public virtual object Item { get; set; }

	// Methods

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	internal void .ctor(SortedList sortedList) { }

	// RVA: 0x1344A20 Offset: 0x1343020 VA: 0x181344A20 Slot: 19
	public virtual int get_Count() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 20
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 21
	public virtual bool get_IsFixedSize() { }

	// RVA: 0x1348CE0 Offset: 0x13472E0 VA: 0x181348CE0 Slot: 22
	public virtual object get_SyncRoot() { }

	// RVA: 0x1464B60 Offset: 0x1463160 VA: 0x181464B60 Slot: 23
	public virtual int Add(object key) { }

	// RVA: 0x1464BD0 Offset: 0x14631D0 VA: 0x181464BD0 Slot: 24
	public virtual void Clear() { }

	// RVA: 0x1464C40 Offset: 0x1463240 VA: 0x181464C40 Slot: 25
	public virtual bool Contains(object key) { }

	// RVA: 0x1464C70 Offset: 0x1463270 VA: 0x181464C70 Slot: 26
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1464EF0 Offset: 0x14634F0 VA: 0x181464EF0 Slot: 27
	public virtual void Insert(int index, object value) { }

	// RVA: 0x1465040 Offset: 0x1463640 VA: 0x181465040 Slot: 28
	public virtual object get_Item(int index) { }

	// RVA: 0x1465070 Offset: 0x1463670 VA: 0x181465070 Slot: 29
	public virtual void set_Item(int index, object value) { }

	// RVA: 0x1464D50 Offset: 0x1463350 VA: 0x181464D50 Slot: 30
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x1464E00 Offset: 0x1463400 VA: 0x181464E00 Slot: 31
	public virtual int IndexOf(object key) { }

	// RVA: 0x1464FD0 Offset: 0x14635D0 VA: 0x181464FD0 Slot: 32
	public virtual void Remove(object key) { }

	// RVA: 0x1464F60 Offset: 0x1463560 VA: 0x181464F60 Slot: 33
	public virtual void RemoveAt(int index) { }

}

private class SortedList.ValueList : IList, ICollection, IEnumerable // TypeDefIndex: 1421
{	// Fields
	private SortedList sortedList; // 0x10

	// Properties
	public virtual int Count { get; }
	public virtual bool IsReadOnly { get; }
	public virtual bool IsFixedSize { get; }
	public virtual object SyncRoot { get; }
	public virtual object Item { get; set; }

	// Methods

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	internal void .ctor(SortedList sortedList) { }

	// RVA: 0x1344A20 Offset: 0x1343020 VA: 0x181344A20 Slot: 19
	public virtual int get_Count() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 20
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 21
	public virtual bool get_IsFixedSize() { }

	// RVA: 0x1348CE0 Offset: 0x13472E0 VA: 0x181348CE0 Slot: 22
	public virtual object get_SyncRoot() { }

	// RVA: 0x146D8B0 Offset: 0x146BEB0 VA: 0x18146D8B0 Slot: 23
	public virtual int Add(object key) { }

	// RVA: 0x146D920 Offset: 0x146BF20 VA: 0x18146D920 Slot: 24
	public virtual void Clear() { }

	// RVA: 0x146D990 Offset: 0x146BF90 VA: 0x18146D990 Slot: 25
	public virtual bool Contains(object value) { }

	// RVA: 0x146D9C0 Offset: 0x146BFC0 VA: 0x18146D9C0 Slot: 26
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x146DBD0 Offset: 0x146C1D0 VA: 0x18146DBD0 Slot: 27
	public virtual void Insert(int index, object value) { }

	// RVA: 0x146DD20 Offset: 0x146C320 VA: 0x18146DD20 Slot: 28
	public virtual object get_Item(int index) { }

	// RVA: 0x146DD50 Offset: 0x146C350 VA: 0x18146DD50 Slot: 29
	public virtual void set_Item(int index, object value) { }

	// RVA: 0x146DAA0 Offset: 0x146C0A0 VA: 0x18146DAA0 Slot: 30
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x146DB50 Offset: 0x146C150 VA: 0x18146DB50 Slot: 31
	public virtual int IndexOf(object value) { }

	// RVA: 0x146DCB0 Offset: 0x146C2B0 VA: 0x18146DCB0 Slot: 32
	public virtual void Remove(object value) { }

	// RVA: 0x146DC40 Offset: 0x146C240 VA: 0x18146DC40 Slot: 33
	public virtual void RemoveAt(int index) { }

}

private struct SortedList.Enumerator<TKey, TValue> : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator, IDictionaryEnumerator // TypeDefIndex: 3138
{	// Fields
	private SortedList<TKey, TValue> _sortedList; // 0x0
	private TKey _key; // 0x0
	private TValue _value; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private int _getEnumeratorRetType; // 0x0

	// Properties
	private object System.Collections.IDictionaryEnumerator.Key { get; }
	private DictionaryEntry System.Collections.IDictionaryEnumerator.Entry { get; }
	public KeyValuePair<TKey, TValue> Current { get; }
	private object System.Collections.IEnumerator.Current { get; }
	private object System.Collections.IDictionaryEnumerator.Value { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SortedList<TKey, TValue> sortedList, int getEnumeratorRetType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x231150 Offset: 0x230550 VA: 0x180231150
	|-SortedList.Enumerator<long, object>..ctor
	|-SortedList.Enumerator<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2300B0 Offset: 0x22F4B0 VA: 0x1802300B0
	|-SortedList.Enumerator<long, object>.Dispose
	|-SortedList.Enumerator<object, object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IDictionaryEnumerator.get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x230560 Offset: 0x22F960 VA: 0x180230560
	|-SortedList.Enumerator<long, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x230460 Offset: 0x22F860 VA: 0x180230460
	|-SortedList.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Key
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2301A0 Offset: 0x22F5A0 VA: 0x1802301A0
	|-SortedList.Enumerator<long, object>.MoveNext
	|
	|-RVA: 0x2300E0 Offset: 0x22F4E0 VA: 0x1802300E0
	|-SortedList.Enumerator<object, object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2301E0 Offset: 0x22F5E0 VA: 0x1802301E0
	|-SortedList.Enumerator<long, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x230340 Offset: 0x22F740 VA: 0x180230340
	|-SortedList.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Entry
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public KeyValuePair<TKey, TValue> get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x231260 Offset: 0x230660 VA: 0x180231260
	|-SortedList.Enumerator<long, object>.get_Current
	|
	|-RVA: 0x231370 Offset: 0x230770 VA: 0x180231370
	|-SortedList.Enumerator<object, object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x230D00 Offset: 0x230100 VA: 0x180230D00
	|-SortedList.Enumerator<long, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x230D10 Offset: 0x230110 VA: 0x180230D10
	|-SortedList.Enumerator<object, object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private object System.Collections.IDictionaryEnumerator.get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2307A0 Offset: 0x22FBA0 VA: 0x1802307A0
	|-SortedList.Enumerator<long, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x2306A0 Offset: 0x22FAA0 VA: 0x1802306A0
	|-SortedList.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x230930 Offset: 0x22FD30 VA: 0x180230930
	|-SortedList.Enumerator<long, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x230A40 Offset: 0x22FE40 VA: 0x180230A40
	|-SortedList.Enumerator<object, object>.System.Collections.IEnumerator.Reset
	*/

}

private sealed class SortedList.SortedListKeyEnumerator<TKey, TValue> : IEnumerator<TKey>, IDisposable, IEnumerator // TypeDefIndex: 3139
{	// Fields
	private SortedList<TKey, TValue> _sortedList; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private TKey _currentKey; // 0x0

	// Properties
	public TKey Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SortedList<TKey, TValue> sortedList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E31500 Offset: 0x1E2FB00 VA: 0x181E31500
	|-SortedList.SortedListKeyEnumerator<long, object>..ctor
	|-SortedList.SortedListKeyEnumerator<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E31020 Offset: 0x1E2F620 VA: 0x181E31020
	|-SortedList.SortedListKeyEnumerator<long, object>.Dispose
	|-SortedList.SortedListKeyEnumerator<object, object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E31150 Offset: 0x1E2F750 VA: 0x181E31150
	|-SortedList.SortedListKeyEnumerator<long, object>.MoveNext
	|
	|-RVA: 0x1E31030 Offset: 0x1E2F630 VA: 0x181E31030
	|-SortedList.SortedListKeyEnumerator<object, object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TKey get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	|-SortedList.SortedListKeyEnumerator<long, object>.get_Current
	|-SortedList.SortedListKeyEnumerator<object, object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E31420 Offset: 0x1E2FA20 VA: 0x181E31420
	|-SortedList.SortedListKeyEnumerator<long, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1E31370 Offset: 0x1E2F970 VA: 0x181E31370
	|-SortedList.SortedListKeyEnumerator<object, object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E31270 Offset: 0x1E2F870 VA: 0x181E31270
	|-SortedList.SortedListKeyEnumerator<long, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1E312F0 Offset: 0x1E2F8F0 VA: 0x181E312F0
	|-SortedList.SortedListKeyEnumerator<object, object>.System.Collections.IEnumerator.Reset
	*/

}

private sealed class SortedList.SortedListValueEnumerator<TKey, TValue> : IEnumerator<TValue>, IDisposable, IEnumerator // TypeDefIndex: 3140
{	// Fields
	private SortedList<TKey, TValue> _sortedList; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private TValue _currentValue; // 0x0

	// Properties
	public TValue Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SortedList<TKey, TValue> sortedList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E31500 Offset: 0x1E2FB00 VA: 0x181E31500
	|-SortedList.SortedListValueEnumerator<long, object>..ctor
	|-SortedList.SortedListValueEnumerator<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E31020 Offset: 0x1E2F620 VA: 0x181E31020
	|-SortedList.SortedListValueEnumerator<long, object>.Dispose
	|-SortedList.SortedListValueEnumerator<object, object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E31550 Offset: 0x1E2FB50 VA: 0x181E31550
	|-SortedList.SortedListValueEnumerator<long, object>.MoveNext
	|
	|-RVA: 0x1E31670 Offset: 0x1E2FC70 VA: 0x181E31670
	|-SortedList.SortedListValueEnumerator<object, object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TValue get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	|-SortedList.SortedListValueEnumerator<long, object>.get_Current
	|-SortedList.SortedListValueEnumerator<object, object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E31940 Offset: 0x1E2FF40 VA: 0x181E31940
	|-SortedList.SortedListValueEnumerator<long, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1E31890 Offset: 0x1E2FE90 VA: 0x181E31890
	|-SortedList.SortedListValueEnumerator<object, object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E31810 Offset: 0x1E2FE10 VA: 0x181E31810
	|-SortedList.SortedListValueEnumerator<long, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1E31790 Offset: 0x1E2FD90 VA: 0x181E31790
	|-SortedList.SortedListValueEnumerator<object, object>.System.Collections.IEnumerator.Reset
	*/

}

private sealed class SortedList.KeyList<TKey, TValue> : IList<TKey>, ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection // TypeDefIndex: 3141
{	// Fields
	private SortedList<TKey, TValue> _dict; // 0x0

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public TKey Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SortedList<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1359F10 Offset: 0x1358510 VA: 0x181359F10
	|-SortedList.KeyList<long, object>..ctor
	|-SortedList.KeyList<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1344A20 Offset: 0x1343020 VA: 0x181344A20
	|-SortedList.KeyList<long, object>.get_Count
	|-SortedList.KeyList<object, object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250
	|-SortedList.KeyList<long, object>.get_IsReadOnly
	|-SortedList.KeyList<object, object>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2D8F0 Offset: 0x1E2BEF0 VA: 0x181E2D8F0
	|-SortedList.KeyList<long, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1E2D8A0 Offset: 0x1E2BEA0 VA: 0x181E2D8A0
	|-SortedList.KeyList<object, object>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2CFF0 Offset: 0x1E2B5F0 VA: 0x181E2CFF0
	|-SortedList.KeyList<long, object>.Add
	|
	|-RVA: 0x1E2D050 Offset: 0x1E2B650 VA: 0x181E2D050
	|-SortedList.KeyList<object, object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2D0B0 Offset: 0x1E2B6B0 VA: 0x181E2D0B0
	|-SortedList.KeyList<long, object>.Clear
	|
	|-RVA: 0x1E2D110 Offset: 0x1E2B710 VA: 0x181E2D110
	|-SortedList.KeyList<object, object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E7D60 Offset: 0x15E6360 VA: 0x1815E7D60
	|-SortedList.KeyList<long, object>.Contains
	|-SortedList.KeyList<object, object>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(TKey[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2D170 Offset: 0x1E2B770 VA: 0x181E2D170
	|-SortedList.KeyList<long, object>.CopyTo
	|-SortedList.KeyList<object, object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2D770 Offset: 0x1E2BD70 VA: 0x181E2D770
	|-SortedList.KeyList<long, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1E2D640 Offset: 0x1E2BC40 VA: 0x181E2D640
	|-SortedList.KeyList<object, object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, TKey value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2D400 Offset: 0x1E2BA00 VA: 0x181E2D400
	|-SortedList.KeyList<long, object>.Insert
	|
	|-RVA: 0x1E2D460 Offset: 0x1E2BA60 VA: 0x181E2D460
	|-SortedList.KeyList<object, object>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TKey get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2D940 Offset: 0x1E2BF40 VA: 0x181E2D940
	|-SortedList.KeyList<long, object>.get_Item
	|-SortedList.KeyList<object, object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, TKey value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2D970 Offset: 0x1E2BF70 VA: 0x181E2D970
	|-SortedList.KeyList<long, object>.set_Item
	|
	|-RVA: 0x1E2D9D0 Offset: 0x1E2BFD0 VA: 0x181E2D9D0
	|-SortedList.KeyList<object, object>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<TKey> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2D1E0 Offset: 0x1E2B7E0 VA: 0x181E2D1E0
	|-SortedList.KeyList<long, object>.GetEnumerator
	|-SortedList.KeyList<object, object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2D1E0 Offset: 0x1E2B7E0 VA: 0x181E2D1E0
	|-SortedList.KeyList<long, object>.System.Collections.IEnumerable.GetEnumerator
	|-SortedList.KeyList<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2D340 Offset: 0x1E2B940 VA: 0x181E2D340
	|-SortedList.KeyList<long, object>.IndexOf
	|
	|-RVA: 0x1E2D250 Offset: 0x1E2B850 VA: 0x181E2D250
	|-SortedList.KeyList<object, object>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2D580 Offset: 0x1E2BB80 VA: 0x181E2D580
	|-SortedList.KeyList<long, object>.Remove
	|
	|-RVA: 0x1E2D5E0 Offset: 0x1E2BBE0 VA: 0x181E2D5E0
	|-SortedList.KeyList<object, object>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2D520 Offset: 0x1E2BB20 VA: 0x181E2D520
	|-SortedList.KeyList<long, object>.RemoveAt
	|
	|-RVA: 0x1E2D4C0 Offset: 0x1E2BAC0 VA: 0x181E2D4C0
	|-SortedList.KeyList<object, object>.RemoveAt
	*/

}

private sealed class SortedList.ValueList<TKey, TValue> : IList<TValue>, ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection // TypeDefIndex: 3142
{	// Fields
	private SortedList<TKey, TValue> _dict; // 0x0

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public TValue Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SortedList<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1359F10 Offset: 0x1358510 VA: 0x181359F10
	|-SortedList.ValueList<long, object>..ctor
	|-SortedList.ValueList<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1344A20 Offset: 0x1343020 VA: 0x181344A20
	|-SortedList.ValueList<long, object>.get_Count
	|-SortedList.ValueList<object, object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250
	|-SortedList.ValueList<long, object>.get_IsReadOnly
	|-SortedList.ValueList<object, object>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E37EB0 Offset: 0x1E364B0 VA: 0x181E37EB0
	|-SortedList.ValueList<long, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1E37E60 Offset: 0x1E36460 VA: 0x181E37E60
	|-SortedList.ValueList<object, object>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(TValue key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E377C0 Offset: 0x1E35DC0 VA: 0x181E377C0
	|-SortedList.ValueList<long, object>.Add
	|
	|-RVA: 0x1E37760 Offset: 0x1E35D60 VA: 0x181E37760
	|-SortedList.ValueList<object, object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E37820 Offset: 0x1E35E20 VA: 0x181E37820
	|-SortedList.ValueList<long, object>.Clear
	|
	|-RVA: 0x1E37880 Offset: 0x1E35E80 VA: 0x181E37880
	|-SortedList.ValueList<object, object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E7D60 Offset: 0x15E6360 VA: 0x1815E7D60
	|-SortedList.ValueList<long, object>.Contains
	|-SortedList.ValueList<object, object>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(TValue[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E378E0 Offset: 0x1E35EE0 VA: 0x181E378E0
	|-SortedList.ValueList<long, object>.CopyTo
	|-SortedList.ValueList<object, object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E37C00 Offset: 0x1E36200 VA: 0x181E37C00
	|-SortedList.ValueList<long, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1E37D30 Offset: 0x1E36330 VA: 0x181E37D30
	|-SortedList.ValueList<object, object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E379C0 Offset: 0x1E35FC0 VA: 0x181E379C0
	|-SortedList.ValueList<long, object>.Insert
	|
	|-RVA: 0x1E37A20 Offset: 0x1E36020 VA: 0x181E37A20
	|-SortedList.ValueList<object, object>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TValue get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2D940 Offset: 0x1E2BF40 VA: 0x181E2D940
	|-SortedList.ValueList<long, object>.get_Item
	|-SortedList.ValueList<object, object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E37F00 Offset: 0x1E36500 VA: 0x181E37F00
	|-SortedList.ValueList<long, object>.set_Item
	|
	|-RVA: 0x1E37F60 Offset: 0x1E36560 VA: 0x181E37F60
	|-SortedList.ValueList<object, object>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2D1E0 Offset: 0x1E2B7E0 VA: 0x181E2D1E0
	|-SortedList.ValueList<long, object>.GetEnumerator
	|-SortedList.ValueList<object, object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2D1E0 Offset: 0x1E2B7E0 VA: 0x181E2D1E0
	|-SortedList.ValueList<long, object>.System.Collections.IEnumerable.GetEnumerator
	|-SortedList.ValueList<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E37950 Offset: 0x1E35F50 VA: 0x181E37950
	|-SortedList.ValueList<long, object>.IndexOf
	|-SortedList.ValueList<object, object>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E37B40 Offset: 0x1E36140 VA: 0x181E37B40
	|-SortedList.ValueList<long, object>.Remove
	|
	|-RVA: 0x1E37BA0 Offset: 0x1E361A0 VA: 0x181E37BA0
	|-SortedList.ValueList<object, object>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E37AE0 Offset: 0x1E360E0 VA: 0x181E37AE0
	|-SortedList.ValueList<long, object>.RemoveAt
	|
	|-RVA: 0x1E37A80 Offset: 0x1E36080 VA: 0x181E37A80
	|-SortedList.ValueList<object, object>.RemoveAt
	*/

}

