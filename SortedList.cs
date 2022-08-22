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

	// RVA: 0x146A600 Offset: 0x1468C00 VA: 0x18146A600
	public void .ctor() { }

	// RVA: 0x1469D90 Offset: 0x1468390 VA: 0x181469D90
	private void Init() { }

	// RVA: 0x146A460 Offset: 0x1468A60 VA: 0x18146A460
	public void .ctor(int initialCapacity) { }

	// RVA: 0x146A770 Offset: 0x1468D70 VA: 0x18146A770
	public void .ctor(IComparer comparer) { }

	// RVA: 0x146A7B0 Offset: 0x1468DB0 VA: 0x18146A7B0
	public void .ctor(IComparer comparer, int capacity) { }

	// RVA: 0x1469210 Offset: 0x1467810 VA: 0x181469210 Slot: 19
	public virtual void Add(object key, object value) { }

	// RVA: 0x9EB840 Offset: 0x9E9E40 VA: 0x1809EB840 Slot: 20
	public virtual int get_Capacity() { }

	// RVA: 0x146A920 Offset: 0x1468F20 VA: 0x18146A920 Slot: 21
	public virtual void set_Capacity(int value) { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0 Slot: 22
	public virtual int get_Count() { }

	// RVA: 0x146A870 Offset: 0x1468E70 VA: 0x18146A870 Slot: 23
	public virtual ICollection get_Keys() { }

	// RVA: 0x146A900 Offset: 0x1468F00 VA: 0x18146A900 Slot: 24
	public virtual ICollection get_Values() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 25
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x146A890 Offset: 0x1468E90 VA: 0x18146A890 Slot: 26
	public virtual object get_SyncRoot() { }

	// RVA: 0x14693A0 Offset: 0x14679A0 VA: 0x1814693A0 Slot: 27
	public virtual void Clear() { }

	// RVA: 0x14693E0 Offset: 0x14679E0 VA: 0x1814693E0 Slot: 28
	public virtual object Clone() { }

	// RVA: 0x1469620 Offset: 0x1467C20 VA: 0x181469620 Slot: 29
	public virtual bool Contains(object key) { }

	// RVA: 0x1469620 Offset: 0x1467C20 VA: 0x181469620 Slot: 30
	public virtual bool ContainsKey(object key) { }

	// RVA: 0x1469640 Offset: 0x1467C40 VA: 0x181469640 Slot: 31
	public virtual bool ContainsValue(object value) { }

	// RVA: 0x1469660 Offset: 0x1467C60 VA: 0x181469660 Slot: 32
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1469900 Offset: 0x1467F00 VA: 0x181469900
	private void EnsureCapacity(int min) { }

	// RVA: 0x1469950 Offset: 0x1467F50 VA: 0x181469950 Slot: 33
	public virtual object GetByIndex(int index) { }

	// RVA: 0x146A360 Offset: 0x1468960 VA: 0x18146A360 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1469A10 Offset: 0x1468010 VA: 0x181469A10 Slot: 34
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x1469B30 Offset: 0x1468130 VA: 0x181469B30 Slot: 35
	public virtual object GetKey(int index) { }

	// RVA: 0x1469AA0 Offset: 0x14680A0 VA: 0x181469AA0 Slot: 36
	public virtual IList GetKeyList() { }

	// RVA: 0x1469BF0 Offset: 0x14681F0 VA: 0x181469BF0 Slot: 37
	public virtual IList GetValueList() { }

	// RVA: 0x146A810 Offset: 0x1468E10 VA: 0x18146A810 Slot: 38
	public virtual object get_Item(object key) { }

	// RVA: 0x146AAE0 Offset: 0x14690E0 VA: 0x18146AAE0 Slot: 39
	public virtual void set_Item(object key, object value) { }

	// RVA: 0x1469C80 Offset: 0x1468280 VA: 0x181469C80 Slot: 40
	public virtual int IndexOfKey(object key) { }

	// RVA: 0x1469D30 Offset: 0x1468330 VA: 0x181469D30 Slot: 41
	public virtual int IndexOfValue(object value) { }

	// RVA: 0x1469F00 Offset: 0x1468500 VA: 0x181469F00
	private void Insert(int index, object key, object value) { }

	// RVA: 0x146A0A0 Offset: 0x14686A0 VA: 0x18146A0A0 Slot: 42
	public virtual void RemoveAt(int index) { }

	// RVA: 0x146A220 Offset: 0x1468820 VA: 0x18146A220 Slot: 43
	public virtual void Remove(object key) { }

	// RVA: 0x146A260 Offset: 0x1468860 VA: 0x18146A260
	public static SortedList Synchronized(SortedList list) { }

	// RVA: 0x146A3F0 Offset: 0x14689F0 VA: 0x18146A3F0
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

	// RVA: 0x146D480 Offset: 0x146BA80 VA: 0x18146D480
	internal void .ctor(SortedList list) { }

	// RVA: 0x146D600 Offset: 0x146BC00 VA: 0x18146D600 Slot: 22
	public override int get_Count() { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870 Slot: 26
	public override object get_SyncRoot() { }

	// RVA: 0x146D6E0 Offset: 0x146BCE0 VA: 0x18146D6E0 Slot: 25
	public override bool get_IsReadOnly() { }

	// RVA: 0x146D710 Offset: 0x146BD10 VA: 0x18146D710 Slot: 38
	public override object get_Item(object key) { }

	// RVA: 0x146D7F0 Offset: 0x146BDF0 VA: 0x18146D7F0 Slot: 39
	public override void set_Item(object key, object value) { }

	// RVA: 0x146C620 Offset: 0x146AC20 VA: 0x18146C620 Slot: 19
	public override void Add(object key, object value) { }

	// RVA: 0x146D520 Offset: 0x146BB20 VA: 0x18146D520 Slot: 20
	public override int get_Capacity() { }

	// RVA: 0x146C700 Offset: 0x146AD00 VA: 0x18146C700 Slot: 27
	public override void Clear() { }

	// RVA: 0x146C7C0 Offset: 0x146ADC0 VA: 0x18146C7C0 Slot: 28
	public override object Clone() { }

	// RVA: 0x146CA80 Offset: 0x146B080 VA: 0x18146CA80 Slot: 29
	public override bool Contains(object key) { }

	// RVA: 0x146C8A0 Offset: 0x146AEA0 VA: 0x18146C8A0 Slot: 30
	public override bool ContainsKey(object key) { }

	// RVA: 0x146C990 Offset: 0x146AF90 VA: 0x18146C990 Slot: 31
	public override bool ContainsValue(object key) { }

	// RVA: 0x146CB70 Offset: 0x146B170 VA: 0x18146CB70 Slot: 32
	public override void CopyTo(Array array, int index) { }

	// RVA: 0x146CC50 Offset: 0x146B250 VA: 0x18146CC50 Slot: 33
	public override object GetByIndex(int index) { }

	// RVA: 0x146CD30 Offset: 0x146B330 VA: 0x18146CD30 Slot: 34
	public override IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x146CEF0 Offset: 0x146B4F0 VA: 0x18146CEF0 Slot: 35
	public override object GetKey(int index) { }

	// RVA: 0x146CE10 Offset: 0x146B410 VA: 0x18146CE10 Slot: 36
	public override IList GetKeyList() { }

	// RVA: 0x146CFD0 Offset: 0x146B5D0 VA: 0x18146CFD0 Slot: 37
	public override IList GetValueList() { }

	// RVA: 0x146D0B0 Offset: 0x146B6B0 VA: 0x18146D0B0 Slot: 40
	public override int IndexOfKey(object key) { }

	// RVA: 0x146D200 Offset: 0x146B800 VA: 0x18146D200 Slot: 41
	public override int IndexOfValue(object value) { }

	// RVA: 0x146D2E0 Offset: 0x146B8E0 VA: 0x18146D2E0 Slot: 42
	public override void RemoveAt(int index) { }

	// RVA: 0x146D3B0 Offset: 0x146B9B0 VA: 0x18146D3B0 Slot: 43
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

	// RVA: 0x1468DD0 Offset: 0x14673D0 VA: 0x181468DD0
	internal void .ctor(SortedList sortedList, int index, int count, int getObjRetType) { }

	// RVA: 0xD712E0 Offset: 0xD6F8E0 VA: 0x180D712E0 Slot: 10
	public object Clone() { }

	// RVA: 0x1469050 Offset: 0x1467650 VA: 0x181469050 Slot: 11
	public virtual object get_Key() { }

	// RVA: 0x1468BE0 Offset: 0x14671E0 VA: 0x181468BE0 Slot: 12
	public virtual bool MoveNext() { }

	// RVA: 0x1468F50 Offset: 0x1467550 VA: 0x181468F50 Slot: 13
	public virtual DictionaryEntry get_Entry() { }

	// RVA: 0x1468E50 Offset: 0x1467450 VA: 0x181468E50 Slot: 14
	public virtual object get_Current() { }

	// RVA: 0x1469130 Offset: 0x1467730 VA: 0x181469130 Slot: 15
	public virtual object get_Value() { }

	// RVA: 0x1468D20 Offset: 0x1467320 VA: 0x181468D20 Slot: 16
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

	// RVA: 0x1344CE0 Offset: 0x13432E0 VA: 0x181344CE0 Slot: 19
	public virtual int get_Count() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 20
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 21
	public virtual bool get_IsFixedSize() { }

	// RVA: 0x1348FA0 Offset: 0x13475A0 VA: 0x181348FA0 Slot: 22
	public virtual object get_SyncRoot() { }

	// RVA: 0x1464E20 Offset: 0x1463420 VA: 0x181464E20 Slot: 23
	public virtual int Add(object key) { }

	// RVA: 0x1464E90 Offset: 0x1463490 VA: 0x181464E90 Slot: 24
	public virtual void Clear() { }

	// RVA: 0x1464F00 Offset: 0x1463500 VA: 0x181464F00 Slot: 25
	public virtual bool Contains(object key) { }

	// RVA: 0x1464F30 Offset: 0x1463530 VA: 0x181464F30 Slot: 26
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x14651B0 Offset: 0x14637B0 VA: 0x1814651B0 Slot: 27
	public virtual void Insert(int index, object value) { }

	// RVA: 0x1465300 Offset: 0x1463900 VA: 0x181465300 Slot: 28
	public virtual object get_Item(int index) { }

	// RVA: 0x1465330 Offset: 0x1463930 VA: 0x181465330 Slot: 29
	public virtual void set_Item(int index, object value) { }

	// RVA: 0x1465010 Offset: 0x1463610 VA: 0x181465010 Slot: 30
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x14650C0 Offset: 0x14636C0 VA: 0x1814650C0 Slot: 31
	public virtual int IndexOf(object key) { }

	// RVA: 0x1465290 Offset: 0x1463890 VA: 0x181465290 Slot: 32
	public virtual void Remove(object key) { }

	// RVA: 0x1465220 Offset: 0x1463820 VA: 0x181465220 Slot: 33
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

	// RVA: 0x1344CE0 Offset: 0x13432E0 VA: 0x181344CE0 Slot: 19
	public virtual int get_Count() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 20
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 21
	public virtual bool get_IsFixedSize() { }

	// RVA: 0x1348FA0 Offset: 0x13475A0 VA: 0x181348FA0 Slot: 22
	public virtual object get_SyncRoot() { }

	// RVA: 0x146DB70 Offset: 0x146C170 VA: 0x18146DB70 Slot: 23
	public virtual int Add(object key) { }

	// RVA: 0x146DBE0 Offset: 0x146C1E0 VA: 0x18146DBE0 Slot: 24
	public virtual void Clear() { }

	// RVA: 0x146DC50 Offset: 0x146C250 VA: 0x18146DC50 Slot: 25
	public virtual bool Contains(object value) { }

	// RVA: 0x146DC80 Offset: 0x146C280 VA: 0x18146DC80 Slot: 26
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x146DE90 Offset: 0x146C490 VA: 0x18146DE90 Slot: 27
	public virtual void Insert(int index, object value) { }

	// RVA: 0x146DFE0 Offset: 0x146C5E0 VA: 0x18146DFE0 Slot: 28
	public virtual object get_Item(int index) { }

	// RVA: 0x146E010 Offset: 0x146C610 VA: 0x18146E010 Slot: 29
	public virtual void set_Item(int index, object value) { }

	// RVA: 0x146DD60 Offset: 0x146C360 VA: 0x18146DD60 Slot: 30
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x146DE10 Offset: 0x146C410 VA: 0x18146DE10 Slot: 31
	public virtual int IndexOf(object value) { }

	// RVA: 0x146DF70 Offset: 0x146C570 VA: 0x18146DF70 Slot: 32
	public virtual void Remove(object value) { }

	// RVA: 0x146DF00 Offset: 0x146C500 VA: 0x18146DF00 Slot: 33
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
	|-RVA: 0x2310D0 Offset: 0x2304D0 VA: 0x1802310D0
	|-SortedList.Enumerator<long, object>..ctor
	|-SortedList.Enumerator<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x230030 Offset: 0x22F430 VA: 0x180230030
	|-SortedList.Enumerator<long, object>.Dispose
	|-SortedList.Enumerator<object, object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IDictionaryEnumerator.get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2304E0 Offset: 0x22F8E0 VA: 0x1802304E0
	|-SortedList.Enumerator<long, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x2303E0 Offset: 0x22F7E0 VA: 0x1802303E0
	|-SortedList.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Key
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x230120 Offset: 0x22F520 VA: 0x180230120
	|-SortedList.Enumerator<long, object>.MoveNext
	|
	|-RVA: 0x230060 Offset: 0x22F460 VA: 0x180230060
	|-SortedList.Enumerator<object, object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x230160 Offset: 0x22F560 VA: 0x180230160
	|-SortedList.Enumerator<long, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x2302C0 Offset: 0x22F6C0 VA: 0x1802302C0
	|-SortedList.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Entry
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public KeyValuePair<TKey, TValue> get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2311E0 Offset: 0x2305E0 VA: 0x1802311E0
	|-SortedList.Enumerator<long, object>.get_Current
	|
	|-RVA: 0x2312F0 Offset: 0x2306F0 VA: 0x1802312F0
	|-SortedList.Enumerator<object, object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x230C80 Offset: 0x230080 VA: 0x180230C80
	|-SortedList.Enumerator<long, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x230C90 Offset: 0x230090 VA: 0x180230C90
	|-SortedList.Enumerator<object, object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private object System.Collections.IDictionaryEnumerator.get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x230720 Offset: 0x22FB20 VA: 0x180230720
	|-SortedList.Enumerator<long, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x230620 Offset: 0x22FA20 VA: 0x180230620
	|-SortedList.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2308B0 Offset: 0x22FCB0 VA: 0x1802308B0
	|-SortedList.Enumerator<long, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2309C0 Offset: 0x22FDC0 VA: 0x1802309C0
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
	|-RVA: 0x1E31600 Offset: 0x1E2FC00 VA: 0x181E31600
	|-SortedList.SortedListKeyEnumerator<long, object>..ctor
	|-SortedList.SortedListKeyEnumerator<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E31120 Offset: 0x1E2F720 VA: 0x181E31120
	|-SortedList.SortedListKeyEnumerator<long, object>.Dispose
	|-SortedList.SortedListKeyEnumerator<object, object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E31250 Offset: 0x1E2F850 VA: 0x181E31250
	|-SortedList.SortedListKeyEnumerator<long, object>.MoveNext
	|
	|-RVA: 0x1E31130 Offset: 0x1E2F730 VA: 0x181E31130
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
	|-RVA: 0x1E31520 Offset: 0x1E2FB20 VA: 0x181E31520
	|-SortedList.SortedListKeyEnumerator<long, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1E31470 Offset: 0x1E2FA70 VA: 0x181E31470
	|-SortedList.SortedListKeyEnumerator<object, object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E31370 Offset: 0x1E2F970 VA: 0x181E31370
	|-SortedList.SortedListKeyEnumerator<long, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1E313F0 Offset: 0x1E2F9F0 VA: 0x181E313F0
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
	|-RVA: 0x1E31600 Offset: 0x1E2FC00 VA: 0x181E31600
	|-SortedList.SortedListValueEnumerator<long, object>..ctor
	|-SortedList.SortedListValueEnumerator<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E31120 Offset: 0x1E2F720 VA: 0x181E31120
	|-SortedList.SortedListValueEnumerator<long, object>.Dispose
	|-SortedList.SortedListValueEnumerator<object, object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E31650 Offset: 0x1E2FC50 VA: 0x181E31650
	|-SortedList.SortedListValueEnumerator<long, object>.MoveNext
	|
	|-RVA: 0x1E31770 Offset: 0x1E2FD70 VA: 0x181E31770
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
	|-RVA: 0x1E31A40 Offset: 0x1E30040 VA: 0x181E31A40
	|-SortedList.SortedListValueEnumerator<long, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1E31990 Offset: 0x1E2FF90 VA: 0x181E31990
	|-SortedList.SortedListValueEnumerator<object, object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E31910 Offset: 0x1E2FF10 VA: 0x181E31910
	|-SortedList.SortedListValueEnumerator<long, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1E31890 Offset: 0x1E2FE90 VA: 0x181E31890
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
	|-RVA: 0x135A1D0 Offset: 0x13587D0 VA: 0x18135A1D0
	|-SortedList.KeyList<long, object>..ctor
	|-SortedList.KeyList<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1344CE0 Offset: 0x13432E0 VA: 0x181344CE0
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
	|-RVA: 0x1E2D9F0 Offset: 0x1E2BFF0 VA: 0x181E2D9F0
	|-SortedList.KeyList<long, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1E2D9A0 Offset: 0x1E2BFA0 VA: 0x181E2D9A0
	|-SortedList.KeyList<object, object>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2D0F0 Offset: 0x1E2B6F0 VA: 0x181E2D0F0
	|-SortedList.KeyList<long, object>.Add
	|
	|-RVA: 0x1E2D150 Offset: 0x1E2B750 VA: 0x181E2D150
	|-SortedList.KeyList<object, object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2D1B0 Offset: 0x1E2B7B0 VA: 0x181E2D1B0
	|-SortedList.KeyList<long, object>.Clear
	|
	|-RVA: 0x1E2D210 Offset: 0x1E2B810 VA: 0x181E2D210
	|-SortedList.KeyList<object, object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E8020 Offset: 0x15E6620 VA: 0x1815E8020
	|-SortedList.KeyList<long, object>.Contains
	|-SortedList.KeyList<object, object>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(TKey[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2D270 Offset: 0x1E2B870 VA: 0x181E2D270
	|-SortedList.KeyList<long, object>.CopyTo
	|-SortedList.KeyList<object, object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2D870 Offset: 0x1E2BE70 VA: 0x181E2D870
	|-SortedList.KeyList<long, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1E2D740 Offset: 0x1E2BD40 VA: 0x181E2D740
	|-SortedList.KeyList<object, object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, TKey value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2D500 Offset: 0x1E2BB00 VA: 0x181E2D500
	|-SortedList.KeyList<long, object>.Insert
	|
	|-RVA: 0x1E2D560 Offset: 0x1E2BB60 VA: 0x181E2D560
	|-SortedList.KeyList<object, object>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TKey get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2DA40 Offset: 0x1E2C040 VA: 0x181E2DA40
	|-SortedList.KeyList<long, object>.get_Item
	|-SortedList.KeyList<object, object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, TKey value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2DA70 Offset: 0x1E2C070 VA: 0x181E2DA70
	|-SortedList.KeyList<long, object>.set_Item
	|
	|-RVA: 0x1E2DAD0 Offset: 0x1E2C0D0 VA: 0x181E2DAD0
	|-SortedList.KeyList<object, object>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<TKey> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2D2E0 Offset: 0x1E2B8E0 VA: 0x181E2D2E0
	|-SortedList.KeyList<long, object>.GetEnumerator
	|-SortedList.KeyList<object, object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2D2E0 Offset: 0x1E2B8E0 VA: 0x181E2D2E0
	|-SortedList.KeyList<long, object>.System.Collections.IEnumerable.GetEnumerator
	|-SortedList.KeyList<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2D440 Offset: 0x1E2BA40 VA: 0x181E2D440
	|-SortedList.KeyList<long, object>.IndexOf
	|
	|-RVA: 0x1E2D350 Offset: 0x1E2B950 VA: 0x181E2D350
	|-SortedList.KeyList<object, object>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2D680 Offset: 0x1E2BC80 VA: 0x181E2D680
	|-SortedList.KeyList<long, object>.Remove
	|
	|-RVA: 0x1E2D6E0 Offset: 0x1E2BCE0 VA: 0x181E2D6E0
	|-SortedList.KeyList<object, object>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2D620 Offset: 0x1E2BC20 VA: 0x181E2D620
	|-SortedList.KeyList<long, object>.RemoveAt
	|
	|-RVA: 0x1E2D5C0 Offset: 0x1E2BBC0 VA: 0x181E2D5C0
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
	|-RVA: 0x135A1D0 Offset: 0x13587D0 VA: 0x18135A1D0
	|-SortedList.ValueList<long, object>..ctor
	|-SortedList.ValueList<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1344CE0 Offset: 0x13432E0 VA: 0x181344CE0
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
	|-RVA: 0x1E37FB0 Offset: 0x1E365B0 VA: 0x181E37FB0
	|-SortedList.ValueList<long, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1E37F60 Offset: 0x1E36560 VA: 0x181E37F60
	|-SortedList.ValueList<object, object>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(TValue key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E378C0 Offset: 0x1E35EC0 VA: 0x181E378C0
	|-SortedList.ValueList<long, object>.Add
	|
	|-RVA: 0x1E37860 Offset: 0x1E35E60 VA: 0x181E37860
	|-SortedList.ValueList<object, object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E37920 Offset: 0x1E35F20 VA: 0x181E37920
	|-SortedList.ValueList<long, object>.Clear
	|
	|-RVA: 0x1E37980 Offset: 0x1E35F80 VA: 0x181E37980
	|-SortedList.ValueList<object, object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E8020 Offset: 0x15E6620 VA: 0x1815E8020
	|-SortedList.ValueList<long, object>.Contains
	|-SortedList.ValueList<object, object>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(TValue[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E379E0 Offset: 0x1E35FE0 VA: 0x181E379E0
	|-SortedList.ValueList<long, object>.CopyTo
	|-SortedList.ValueList<object, object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E37D00 Offset: 0x1E36300 VA: 0x181E37D00
	|-SortedList.ValueList<long, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1E37E30 Offset: 0x1E36430 VA: 0x181E37E30
	|-SortedList.ValueList<object, object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E37AC0 Offset: 0x1E360C0 VA: 0x181E37AC0
	|-SortedList.ValueList<long, object>.Insert
	|
	|-RVA: 0x1E37B20 Offset: 0x1E36120 VA: 0x181E37B20
	|-SortedList.ValueList<object, object>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TValue get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2DA40 Offset: 0x1E2C040 VA: 0x181E2DA40
	|-SortedList.ValueList<long, object>.get_Item
	|-SortedList.ValueList<object, object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E38000 Offset: 0x1E36600 VA: 0x181E38000
	|-SortedList.ValueList<long, object>.set_Item
	|
	|-RVA: 0x1E38060 Offset: 0x1E36660 VA: 0x181E38060
	|-SortedList.ValueList<object, object>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2D2E0 Offset: 0x1E2B8E0 VA: 0x181E2D2E0
	|-SortedList.ValueList<long, object>.GetEnumerator
	|-SortedList.ValueList<object, object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2D2E0 Offset: 0x1E2B8E0 VA: 0x181E2D2E0
	|-SortedList.ValueList<long, object>.System.Collections.IEnumerable.GetEnumerator
	|-SortedList.ValueList<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E37A50 Offset: 0x1E36050 VA: 0x181E37A50
	|-SortedList.ValueList<long, object>.IndexOf
	|-SortedList.ValueList<object, object>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E37C40 Offset: 0x1E36240 VA: 0x181E37C40
	|-SortedList.ValueList<long, object>.Remove
	|
	|-RVA: 0x1E37CA0 Offset: 0x1E362A0 VA: 0x181E37CA0
	|-SortedList.ValueList<object, object>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E37BE0 Offset: 0x1E361E0 VA: 0x181E37BE0
	|-SortedList.ValueList<long, object>.RemoveAt
	|
	|-RVA: 0x1E37B80 Offset: 0x1E36180 VA: 0x181E37B80
	|-SortedList.ValueList<object, object>.RemoveAt
	*/

}

