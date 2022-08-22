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

	// RVA: 0x14696D0 Offset: 0x1467CD0 VA: 0x1814696D0
	public void .ctor() { }

	// RVA: 0x1468E60 Offset: 0x1467460 VA: 0x181468E60
	private void Init() { }

	// RVA: 0x1469530 Offset: 0x1467B30 VA: 0x181469530
	public void .ctor(int initialCapacity) { }

	// RVA: 0x1469840 Offset: 0x1467E40 VA: 0x181469840
	public void .ctor(IComparer comparer) { }

	// RVA: 0x1469880 Offset: 0x1467E80 VA: 0x181469880
	public void .ctor(IComparer comparer, int capacity) { }

	// RVA: 0x14682E0 Offset: 0x14668E0 VA: 0x1814682E0 Slot: 19
	public virtual void Add(object key, object value) { }

	// RVA: 0x9EBD30 Offset: 0x9EA330 VA: 0x1809EBD30 Slot: 20
	public virtual int get_Capacity() { }

	// RVA: 0x14699F0 Offset: 0x1467FF0 VA: 0x1814699F0 Slot: 21
	public virtual void set_Capacity(int value) { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760 Slot: 22
	public virtual int get_Count() { }

	// RVA: 0x1469940 Offset: 0x1467F40 VA: 0x181469940 Slot: 23
	public virtual ICollection get_Keys() { }

	// RVA: 0x14699D0 Offset: 0x1467FD0 VA: 0x1814699D0 Slot: 24
	public virtual ICollection get_Values() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 25
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x1469960 Offset: 0x1467F60 VA: 0x181469960 Slot: 26
	public virtual object get_SyncRoot() { }

	// RVA: 0x1468470 Offset: 0x1466A70 VA: 0x181468470 Slot: 27
	public virtual void Clear() { }

	// RVA: 0x14684B0 Offset: 0x1466AB0 VA: 0x1814684B0 Slot: 28
	public virtual object Clone() { }

	// RVA: 0x14686F0 Offset: 0x1466CF0 VA: 0x1814686F0 Slot: 29
	public virtual bool Contains(object key) { }

	// RVA: 0x14686F0 Offset: 0x1466CF0 VA: 0x1814686F0 Slot: 30
	public virtual bool ContainsKey(object key) { }

	// RVA: 0x1468710 Offset: 0x1466D10 VA: 0x181468710 Slot: 31
	public virtual bool ContainsValue(object value) { }

	// RVA: 0x1468730 Offset: 0x1466D30 VA: 0x181468730 Slot: 32
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x14689D0 Offset: 0x1466FD0 VA: 0x1814689D0
	private void EnsureCapacity(int min) { }

	// RVA: 0x1468A20 Offset: 0x1467020 VA: 0x181468A20 Slot: 33
	public virtual object GetByIndex(int index) { }

	// RVA: 0x1469430 Offset: 0x1467A30 VA: 0x181469430 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1468AE0 Offset: 0x14670E0 VA: 0x181468AE0 Slot: 34
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x1468C00 Offset: 0x1467200 VA: 0x181468C00 Slot: 35
	public virtual object GetKey(int index) { }

	// RVA: 0x1468B70 Offset: 0x1467170 VA: 0x181468B70 Slot: 36
	public virtual IList GetKeyList() { }

	// RVA: 0x1468CC0 Offset: 0x14672C0 VA: 0x181468CC0 Slot: 37
	public virtual IList GetValueList() { }

	// RVA: 0x14698E0 Offset: 0x1467EE0 VA: 0x1814698E0 Slot: 38
	public virtual object get_Item(object key) { }

	// RVA: 0x1469BB0 Offset: 0x14681B0 VA: 0x181469BB0 Slot: 39
	public virtual void set_Item(object key, object value) { }

	// RVA: 0x1468D50 Offset: 0x1467350 VA: 0x181468D50 Slot: 40
	public virtual int IndexOfKey(object key) { }

	// RVA: 0x1468E00 Offset: 0x1467400 VA: 0x181468E00 Slot: 41
	public virtual int IndexOfValue(object value) { }

	// RVA: 0x1468FD0 Offset: 0x14675D0 VA: 0x181468FD0
	private void Insert(int index, object key, object value) { }

	// RVA: 0x1469170 Offset: 0x1467770 VA: 0x181469170 Slot: 42
	public virtual void RemoveAt(int index) { }

	// RVA: 0x14692F0 Offset: 0x14678F0 VA: 0x1814692F0 Slot: 43
	public virtual void Remove(object key) { }

	// RVA: 0x1469330 Offset: 0x1467930 VA: 0x181469330
	public static SortedList Synchronized(SortedList list) { }

	// RVA: 0x14694C0 Offset: 0x1467AC0 VA: 0x1814694C0
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

	// RVA: 0x146C550 Offset: 0x146AB50 VA: 0x18146C550
	internal void .ctor(SortedList list) { }

	// RVA: 0x146C6D0 Offset: 0x146ACD0 VA: 0x18146C6D0 Slot: 22
	public override int get_Count() { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800 Slot: 26
	public override object get_SyncRoot() { }

	// RVA: 0x146C7B0 Offset: 0x146ADB0 VA: 0x18146C7B0 Slot: 25
	public override bool get_IsReadOnly() { }

	// RVA: 0x146C7E0 Offset: 0x146ADE0 VA: 0x18146C7E0 Slot: 38
	public override object get_Item(object key) { }

	// RVA: 0x146C8C0 Offset: 0x146AEC0 VA: 0x18146C8C0 Slot: 39
	public override void set_Item(object key, object value) { }

	// RVA: 0x146B6F0 Offset: 0x1469CF0 VA: 0x18146B6F0 Slot: 19
	public override void Add(object key, object value) { }

	// RVA: 0x146C5F0 Offset: 0x146ABF0 VA: 0x18146C5F0 Slot: 20
	public override int get_Capacity() { }

	// RVA: 0x146B7D0 Offset: 0x1469DD0 VA: 0x18146B7D0 Slot: 27
	public override void Clear() { }

	// RVA: 0x146B890 Offset: 0x1469E90 VA: 0x18146B890 Slot: 28
	public override object Clone() { }

	// RVA: 0x146BB50 Offset: 0x146A150 VA: 0x18146BB50 Slot: 29
	public override bool Contains(object key) { }

	// RVA: 0x146B970 Offset: 0x1469F70 VA: 0x18146B970 Slot: 30
	public override bool ContainsKey(object key) { }

	// RVA: 0x146BA60 Offset: 0x146A060 VA: 0x18146BA60 Slot: 31
	public override bool ContainsValue(object key) { }

	// RVA: 0x146BC40 Offset: 0x146A240 VA: 0x18146BC40 Slot: 32
	public override void CopyTo(Array array, int index) { }

	// RVA: 0x146BD20 Offset: 0x146A320 VA: 0x18146BD20 Slot: 33
	public override object GetByIndex(int index) { }

	// RVA: 0x146BE00 Offset: 0x146A400 VA: 0x18146BE00 Slot: 34
	public override IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x146BFC0 Offset: 0x146A5C0 VA: 0x18146BFC0 Slot: 35
	public override object GetKey(int index) { }

	// RVA: 0x146BEE0 Offset: 0x146A4E0 VA: 0x18146BEE0 Slot: 36
	public override IList GetKeyList() { }

	// RVA: 0x146C0A0 Offset: 0x146A6A0 VA: 0x18146C0A0 Slot: 37
	public override IList GetValueList() { }

	// RVA: 0x146C180 Offset: 0x146A780 VA: 0x18146C180 Slot: 40
	public override int IndexOfKey(object key) { }

	// RVA: 0x146C2D0 Offset: 0x146A8D0 VA: 0x18146C2D0 Slot: 41
	public override int IndexOfValue(object value) { }

	// RVA: 0x146C3B0 Offset: 0x146A9B0 VA: 0x18146C3B0 Slot: 42
	public override void RemoveAt(int index) { }

	// RVA: 0x146C480 Offset: 0x146AA80 VA: 0x18146C480 Slot: 43
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

	// RVA: 0x1467EA0 Offset: 0x14664A0 VA: 0x181467EA0
	internal void .ctor(SortedList sortedList, int index, int count, int getObjRetType) { }

	// RVA: 0xD71D90 Offset: 0xD70390 VA: 0x180D71D90 Slot: 10
	public object Clone() { }

	// RVA: 0x1468120 Offset: 0x1466720 VA: 0x181468120 Slot: 11
	public virtual object get_Key() { }

	// RVA: 0x1467CB0 Offset: 0x14662B0 VA: 0x181467CB0 Slot: 12
	public virtual bool MoveNext() { }

	// RVA: 0x1468020 Offset: 0x1466620 VA: 0x181468020 Slot: 13
	public virtual DictionaryEntry get_Entry() { }

	// RVA: 0x1467F20 Offset: 0x1466520 VA: 0x181467F20 Slot: 14
	public virtual object get_Current() { }

	// RVA: 0x1468200 Offset: 0x1466800 VA: 0x181468200 Slot: 15
	public virtual object get_Value() { }

	// RVA: 0x1467DF0 Offset: 0x14663F0 VA: 0x181467DF0 Slot: 16
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

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	internal void .ctor(SortedList sortedList) { }

	// RVA: 0x1343DE0 Offset: 0x13423E0 VA: 0x181343DE0 Slot: 19
	public virtual int get_Count() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 20
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 21
	public virtual bool get_IsFixedSize() { }

	// RVA: 0x13480A0 Offset: 0x13466A0 VA: 0x1813480A0 Slot: 22
	public virtual object get_SyncRoot() { }

	// RVA: 0x1463EF0 Offset: 0x14624F0 VA: 0x181463EF0 Slot: 23
	public virtual int Add(object key) { }

	// RVA: 0x1463F60 Offset: 0x1462560 VA: 0x181463F60 Slot: 24
	public virtual void Clear() { }

	// RVA: 0x1463FD0 Offset: 0x14625D0 VA: 0x181463FD0 Slot: 25
	public virtual bool Contains(object key) { }

	// RVA: 0x1464000 Offset: 0x1462600 VA: 0x181464000 Slot: 26
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1464280 Offset: 0x1462880 VA: 0x181464280 Slot: 27
	public virtual void Insert(int index, object value) { }

	// RVA: 0x14643D0 Offset: 0x14629D0 VA: 0x1814643D0 Slot: 28
	public virtual object get_Item(int index) { }

	// RVA: 0x1464400 Offset: 0x1462A00 VA: 0x181464400 Slot: 29
	public virtual void set_Item(int index, object value) { }

	// RVA: 0x14640E0 Offset: 0x14626E0 VA: 0x1814640E0 Slot: 30
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x1464190 Offset: 0x1462790 VA: 0x181464190 Slot: 31
	public virtual int IndexOf(object key) { }

	// RVA: 0x1464360 Offset: 0x1462960 VA: 0x181464360 Slot: 32
	public virtual void Remove(object key) { }

	// RVA: 0x14642F0 Offset: 0x14628F0 VA: 0x1814642F0 Slot: 33
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

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	internal void .ctor(SortedList sortedList) { }

	// RVA: 0x1343DE0 Offset: 0x13423E0 VA: 0x181343DE0 Slot: 19
	public virtual int get_Count() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 20
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 21
	public virtual bool get_IsFixedSize() { }

	// RVA: 0x13480A0 Offset: 0x13466A0 VA: 0x1813480A0 Slot: 22
	public virtual object get_SyncRoot() { }

	// RVA: 0x146CC40 Offset: 0x146B240 VA: 0x18146CC40 Slot: 23
	public virtual int Add(object key) { }

	// RVA: 0x146CCB0 Offset: 0x146B2B0 VA: 0x18146CCB0 Slot: 24
	public virtual void Clear() { }

	// RVA: 0x146CD20 Offset: 0x146B320 VA: 0x18146CD20 Slot: 25
	public virtual bool Contains(object value) { }

	// RVA: 0x146CD50 Offset: 0x146B350 VA: 0x18146CD50 Slot: 26
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x146CF60 Offset: 0x146B560 VA: 0x18146CF60 Slot: 27
	public virtual void Insert(int index, object value) { }

	// RVA: 0x146D0B0 Offset: 0x146B6B0 VA: 0x18146D0B0 Slot: 28
	public virtual object get_Item(int index) { }

	// RVA: 0x146D0E0 Offset: 0x146B6E0 VA: 0x18146D0E0 Slot: 29
	public virtual void set_Item(int index, object value) { }

	// RVA: 0x146CE30 Offset: 0x146B430 VA: 0x18146CE30 Slot: 30
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x146CEE0 Offset: 0x146B4E0 VA: 0x18146CEE0 Slot: 31
	public virtual int IndexOf(object value) { }

	// RVA: 0x146D040 Offset: 0x146B640 VA: 0x18146D040 Slot: 32
	public virtual void Remove(object value) { }

	// RVA: 0x146CFD0 Offset: 0x146B5D0 VA: 0x18146CFD0 Slot: 33
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
	|-RVA: 0x1E31E20 Offset: 0x1E30420 VA: 0x181E31E20
	|-SortedList.SortedListKeyEnumerator<long, object>..ctor
	|-SortedList.SortedListKeyEnumerator<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E31940 Offset: 0x1E2FF40 VA: 0x181E31940
	|-SortedList.SortedListKeyEnumerator<long, object>.Dispose
	|-SortedList.SortedListKeyEnumerator<object, object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E31A70 Offset: 0x1E30070 VA: 0x181E31A70
	|-SortedList.SortedListKeyEnumerator<long, object>.MoveNext
	|
	|-RVA: 0x1E31950 Offset: 0x1E2FF50 VA: 0x181E31950
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
	|-RVA: 0x1E31D40 Offset: 0x1E30340 VA: 0x181E31D40
	|-SortedList.SortedListKeyEnumerator<long, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1E31C90 Offset: 0x1E30290 VA: 0x181E31C90
	|-SortedList.SortedListKeyEnumerator<object, object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E31B90 Offset: 0x1E30190 VA: 0x181E31B90
	|-SortedList.SortedListKeyEnumerator<long, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1E31C10 Offset: 0x1E30210 VA: 0x181E31C10
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
	|-RVA: 0x1E31E20 Offset: 0x1E30420 VA: 0x181E31E20
	|-SortedList.SortedListValueEnumerator<long, object>..ctor
	|-SortedList.SortedListValueEnumerator<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E31940 Offset: 0x1E2FF40 VA: 0x181E31940
	|-SortedList.SortedListValueEnumerator<long, object>.Dispose
	|-SortedList.SortedListValueEnumerator<object, object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E31E70 Offset: 0x1E30470 VA: 0x181E31E70
	|-SortedList.SortedListValueEnumerator<long, object>.MoveNext
	|
	|-RVA: 0x1E31F90 Offset: 0x1E30590 VA: 0x181E31F90
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
	|-RVA: 0x1E32260 Offset: 0x1E30860 VA: 0x181E32260
	|-SortedList.SortedListValueEnumerator<long, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1E321B0 Offset: 0x1E307B0 VA: 0x181E321B0
	|-SortedList.SortedListValueEnumerator<object, object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E32130 Offset: 0x1E30730 VA: 0x181E32130
	|-SortedList.SortedListValueEnumerator<long, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1E320B0 Offset: 0x1E306B0 VA: 0x181E320B0
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
	|-RVA: 0x13592D0 Offset: 0x13578D0 VA: 0x1813592D0
	|-SortedList.KeyList<long, object>..ctor
	|-SortedList.KeyList<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1343DE0 Offset: 0x13423E0 VA: 0x181343DE0
	|-SortedList.KeyList<long, object>.get_Count
	|-SortedList.KeyList<object, object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0
	|-SortedList.KeyList<long, object>.get_IsReadOnly
	|-SortedList.KeyList<object, object>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2E210 Offset: 0x1E2C810 VA: 0x181E2E210
	|-SortedList.KeyList<long, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1E2E1C0 Offset: 0x1E2C7C0 VA: 0x181E2E1C0
	|-SortedList.KeyList<object, object>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2D910 Offset: 0x1E2BF10 VA: 0x181E2D910
	|-SortedList.KeyList<long, object>.Add
	|
	|-RVA: 0x1E2D970 Offset: 0x1E2BF70 VA: 0x181E2D970
	|-SortedList.KeyList<object, object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2D9D0 Offset: 0x1E2BFD0 VA: 0x181E2D9D0
	|-SortedList.KeyList<long, object>.Clear
	|
	|-RVA: 0x1E2DA30 Offset: 0x1E2C030 VA: 0x181E2DA30
	|-SortedList.KeyList<object, object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5A390 Offset: 0xD58990 VA: 0x180D5A390
	|-SortedList.KeyList<long, object>.Contains
	|-SortedList.KeyList<object, object>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(TKey[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2DA90 Offset: 0x1E2C090 VA: 0x181E2DA90
	|-SortedList.KeyList<long, object>.CopyTo
	|-SortedList.KeyList<object, object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2E090 Offset: 0x1E2C690 VA: 0x181E2E090
	|-SortedList.KeyList<long, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1E2DF60 Offset: 0x1E2C560 VA: 0x181E2DF60
	|-SortedList.KeyList<object, object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, TKey value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2DD20 Offset: 0x1E2C320 VA: 0x181E2DD20
	|-SortedList.KeyList<long, object>.Insert
	|
	|-RVA: 0x1E2DD80 Offset: 0x1E2C380 VA: 0x181E2DD80
	|-SortedList.KeyList<object, object>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TKey get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2E260 Offset: 0x1E2C860 VA: 0x181E2E260
	|-SortedList.KeyList<long, object>.get_Item
	|-SortedList.KeyList<object, object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, TKey value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2E290 Offset: 0x1E2C890 VA: 0x181E2E290
	|-SortedList.KeyList<long, object>.set_Item
	|
	|-RVA: 0x1E2E2F0 Offset: 0x1E2C8F0 VA: 0x181E2E2F0
	|-SortedList.KeyList<object, object>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<TKey> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2DB00 Offset: 0x1E2C100 VA: 0x181E2DB00
	|-SortedList.KeyList<long, object>.GetEnumerator
	|-SortedList.KeyList<object, object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2DB00 Offset: 0x1E2C100 VA: 0x181E2DB00
	|-SortedList.KeyList<long, object>.System.Collections.IEnumerable.GetEnumerator
	|-SortedList.KeyList<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2DC60 Offset: 0x1E2C260 VA: 0x181E2DC60
	|-SortedList.KeyList<long, object>.IndexOf
	|
	|-RVA: 0x1E2DB70 Offset: 0x1E2C170 VA: 0x181E2DB70
	|-SortedList.KeyList<object, object>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2DEA0 Offset: 0x1E2C4A0 VA: 0x181E2DEA0
	|-SortedList.KeyList<long, object>.Remove
	|
	|-RVA: 0x1E2DF00 Offset: 0x1E2C500 VA: 0x181E2DF00
	|-SortedList.KeyList<object, object>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2DE40 Offset: 0x1E2C440 VA: 0x181E2DE40
	|-SortedList.KeyList<long, object>.RemoveAt
	|
	|-RVA: 0x1E2DDE0 Offset: 0x1E2C3E0 VA: 0x181E2DDE0
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
	|-RVA: 0x13592D0 Offset: 0x13578D0 VA: 0x1813592D0
	|-SortedList.ValueList<long, object>..ctor
	|-SortedList.ValueList<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1343DE0 Offset: 0x13423E0 VA: 0x181343DE0
	|-SortedList.ValueList<long, object>.get_Count
	|-SortedList.ValueList<object, object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0
	|-SortedList.ValueList<long, object>.get_IsReadOnly
	|-SortedList.ValueList<object, object>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E387D0 Offset: 0x1E36DD0 VA: 0x181E387D0
	|-SortedList.ValueList<long, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1E38780 Offset: 0x1E36D80 VA: 0x181E38780
	|-SortedList.ValueList<object, object>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(TValue key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E380E0 Offset: 0x1E366E0 VA: 0x181E380E0
	|-SortedList.ValueList<long, object>.Add
	|
	|-RVA: 0x1E38080 Offset: 0x1E36680 VA: 0x181E38080
	|-SortedList.ValueList<object, object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E38140 Offset: 0x1E36740 VA: 0x181E38140
	|-SortedList.ValueList<long, object>.Clear
	|
	|-RVA: 0x1E381A0 Offset: 0x1E367A0 VA: 0x181E381A0
	|-SortedList.ValueList<object, object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5A390 Offset: 0xD58990 VA: 0x180D5A390
	|-SortedList.ValueList<long, object>.Contains
	|-SortedList.ValueList<object, object>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(TValue[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E38200 Offset: 0x1E36800 VA: 0x181E38200
	|-SortedList.ValueList<long, object>.CopyTo
	|-SortedList.ValueList<object, object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E38520 Offset: 0x1E36B20 VA: 0x181E38520
	|-SortedList.ValueList<long, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1E38650 Offset: 0x1E36C50 VA: 0x181E38650
	|-SortedList.ValueList<object, object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E382E0 Offset: 0x1E368E0 VA: 0x181E382E0
	|-SortedList.ValueList<long, object>.Insert
	|
	|-RVA: 0x1E38340 Offset: 0x1E36940 VA: 0x181E38340
	|-SortedList.ValueList<object, object>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TValue get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2E260 Offset: 0x1E2C860 VA: 0x181E2E260
	|-SortedList.ValueList<long, object>.get_Item
	|-SortedList.ValueList<object, object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E38820 Offset: 0x1E36E20 VA: 0x181E38820
	|-SortedList.ValueList<long, object>.set_Item
	|
	|-RVA: 0x1E38880 Offset: 0x1E36E80 VA: 0x181E38880
	|-SortedList.ValueList<object, object>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2DB00 Offset: 0x1E2C100 VA: 0x181E2DB00
	|-SortedList.ValueList<long, object>.GetEnumerator
	|-SortedList.ValueList<object, object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2DB00 Offset: 0x1E2C100 VA: 0x181E2DB00
	|-SortedList.ValueList<long, object>.System.Collections.IEnumerable.GetEnumerator
	|-SortedList.ValueList<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E38270 Offset: 0x1E36870 VA: 0x181E38270
	|-SortedList.ValueList<long, object>.IndexOf
	|-SortedList.ValueList<object, object>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E38460 Offset: 0x1E36A60 VA: 0x181E38460
	|-SortedList.ValueList<long, object>.Remove
	|
	|-RVA: 0x1E384C0 Offset: 0x1E36AC0 VA: 0x181E384C0
	|-SortedList.ValueList<object, object>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E38400 Offset: 0x1E36A00 VA: 0x181E38400
	|-SortedList.ValueList<long, object>.RemoveAt
	|
	|-RVA: 0x1E383A0 Offset: 0x1E369A0 VA: 0x181E383A0
	|-SortedList.ValueList<object, object>.RemoveAt
	*/

}

