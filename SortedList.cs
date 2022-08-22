public class SortedList : IDictionary, ICollection, IEnumerable, ICloneable // TypeDefIndex: 1417
{	private object[] keys; // 0x10
	private object[] values; // 0x18
	private int _size; // 0x20
	private int version; // 0x24
	private IComparer comparer; // 0x28
	private SortedList.KeyList keyList; // 0x30
	private SortedList.ValueList valueList; // 0x38
	private object _syncRoot; // 0x40
	private const int _defaultCapacity = 16;
	private static object[] emptyArray; // 0x0

	public virtual int Capacity { get; set; }
	public virtual int Count { get; }
	public virtual ICollection Keys { get; }
	public virtual ICollection Values { get; }
	public virtual bool IsReadOnly { get; }
	public virtual object SyncRoot { get; }
	public virtual object Item { get; set; }


	public void .ctor() { }

	private void Init() { }

	public void .ctor(int initialCapacity) { }

	public void .ctor(IComparer comparer) { }

	public void .ctor(IComparer comparer, int capacity) { }

	public virtual void Add(object key, object value) { }

	public virtual int get_Capacity() { }

	public virtual void set_Capacity(int value) { }

	public virtual int get_Count() { }

	public virtual ICollection get_Keys() { }

	public virtual ICollection get_Values() { }

	public virtual bool get_IsReadOnly() { }

	public virtual object get_SyncRoot() { }

	public virtual void Clear() { }

	public virtual object Clone() { }

	public virtual bool Contains(object key) { }

	public virtual bool ContainsKey(object key) { }

	public virtual bool ContainsValue(object value) { }

	public virtual void CopyTo(Array array, int arrayIndex) { }

	private void EnsureCapacity(int min) { }

	public virtual object GetByIndex(int index) { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public virtual IDictionaryEnumerator GetEnumerator() { }

	public virtual object GetKey(int index) { }

	public virtual IList GetKeyList() { }

	public virtual IList GetValueList() { }

	public virtual object get_Item(object key) { }

	public virtual void set_Item(object key, object value) { }

	public virtual int IndexOfKey(object key) { }

	public virtual int IndexOfValue(object value) { }

	private void Insert(int index, object key, object value) { }

	public virtual void RemoveAt(int index) { }

	public virtual void Remove(object key) { }

	public static SortedList Synchronized(SortedList list) { }

	private static void .cctor() { }

}

private class SortedList.SyncSortedList : SortedList // TypeDefIndex: 1418
{	private SortedList _list; // 0x48
	private object _root; // 0x50

	public override int Count { get; }
	public override object SyncRoot { get; }
	public override bool IsReadOnly { get; }
	public override object Item { get; set; }
	public override int Capacity { get; }


	internal void .ctor(SortedList list) { }

	public override int get_Count() { }

	public override object get_SyncRoot() { }

	public override bool get_IsReadOnly() { }

	public override object get_Item(object key) { }

	public override void set_Item(object key, object value) { }

	public override void Add(object key, object value) { }

	public override int get_Capacity() { }

	public override void Clear() { }

	public override object Clone() { }

	public override bool Contains(object key) { }

	public override bool ContainsKey(object key) { }

	public override bool ContainsValue(object key) { }

	public override void CopyTo(Array array, int index) { }

	public override object GetByIndex(int index) { }

	public override IDictionaryEnumerator GetEnumerator() { }

	public override object GetKey(int index) { }

	public override IList GetKeyList() { }

	public override IList GetValueList() { }

	public override int IndexOfKey(object key) { }

	public override int IndexOfValue(object value) { }

	public override void RemoveAt(int index) { }

	public override void Remove(object key) { }

}

private class SortedList.SortedListEnumerator : IDictionaryEnumerator, IEnumerator, ICloneable // TypeDefIndex: 1419
{	private SortedList sortedList; // 0x10
	private object key; // 0x18
	private object value; // 0x20
	private int index; // 0x28
	private int startIndex; // 0x2C
	private int endIndex; // 0x30
	private int version; // 0x34
	private bool current; // 0x38
	private int getObjectRetType; // 0x3C

	public virtual object Key { get; }
	public virtual DictionaryEntry Entry { get; }
	public virtual object Current { get; }
	public virtual object Value { get; }


	internal void .ctor(SortedList sortedList, int index, int count, int getObjRetType) { }

	public object Clone() { }

	public virtual object get_Key() { }

	public virtual bool MoveNext() { }

	public virtual DictionaryEntry get_Entry() { }

	public virtual object get_Current() { }

	public virtual object get_Value() { }

	public virtual void Reset() { }

}

private class SortedList.KeyList : IList, ICollection, IEnumerable // TypeDefIndex: 1420
{	private SortedList sortedList; // 0x10

	public virtual int Count { get; }
	public virtual bool IsReadOnly { get; }
	public virtual bool IsFixedSize { get; }
	public virtual object SyncRoot { get; }
	public virtual object Item { get; set; }


	internal void .ctor(SortedList sortedList) { }

	public virtual int get_Count() { }

	public virtual bool get_IsReadOnly() { }

	public virtual bool get_IsFixedSize() { }

	public virtual object get_SyncRoot() { }

	public virtual int Add(object key) { }

	public virtual void Clear() { }

	public virtual bool Contains(object key) { }

	public virtual void CopyTo(Array array, int arrayIndex) { }

	public virtual void Insert(int index, object value) { }

	public virtual object get_Item(int index) { }

	public virtual void set_Item(int index, object value) { }

	public virtual IEnumerator GetEnumerator() { }

	public virtual int IndexOf(object key) { }

	public virtual void Remove(object key) { }

	public virtual void RemoveAt(int index) { }

}

private class SortedList.ValueList : IList, ICollection, IEnumerable // TypeDefIndex: 1421
{	private SortedList sortedList; // 0x10

	public virtual int Count { get; }
	public virtual bool IsReadOnly { get; }
	public virtual bool IsFixedSize { get; }
	public virtual object SyncRoot { get; }
	public virtual object Item { get; set; }


	internal void .ctor(SortedList sortedList) { }

	public virtual int get_Count() { }

	public virtual bool get_IsReadOnly() { }

	public virtual bool get_IsFixedSize() { }

	public virtual object get_SyncRoot() { }

	public virtual int Add(object key) { }

	public virtual void Clear() { }

	public virtual bool Contains(object value) { }

	public virtual void CopyTo(Array array, int arrayIndex) { }

	public virtual void Insert(int index, object value) { }

	public virtual object get_Item(int index) { }

	public virtual void set_Item(int index, object value) { }

	public virtual IEnumerator GetEnumerator() { }

	public virtual int IndexOf(object value) { }

	public virtual void Remove(object value) { }

	public virtual void RemoveAt(int index) { }

}

private struct SortedList.Enumerator<TKey, TValue> : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator, IDictionaryEnumerator // TypeDefIndex: 3138
{	private SortedList<TKey, TValue> _sortedList; // 0x0
	private TKey _key; // 0x0
	private TValue _value; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private int _getEnumeratorRetType; // 0x0

	private object System.Collections.IDictionaryEnumerator.Key { get; }
	private DictionaryEntry System.Collections.IDictionaryEnumerator.Entry { get; }
	public KeyValuePair<TKey, TValue> Current { get; }
	private object System.Collections.IEnumerator.Current { get; }
	private object System.Collections.IDictionaryEnumerator.Value { get; }


	internal void .ctor(SortedList<TKey, TValue> sortedList, int getEnumeratorRetType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2310D0 Offset: 0x2304D0 VA: 0x1802310D0
	|-SortedList.Enumerator<long, object>..ctor
	|-SortedList.Enumerator<object, object>..ctor
	*/

	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x230030 Offset: 0x22F430 VA: 0x180230030
	|-SortedList.Enumerator<long, object>.Dispose
	|-SortedList.Enumerator<object, object>.Dispose
	*/

	private object System.Collections.IDictionaryEnumerator.get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2304E0 Offset: 0x22F8E0 VA: 0x1802304E0
	|-SortedList.Enumerator<long, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x2303E0 Offset: 0x22F7E0 VA: 0x1802303E0
	|-SortedList.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Key
	*/

	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x230120 Offset: 0x22F520 VA: 0x180230120
	|-SortedList.Enumerator<long, object>.MoveNext
	|
	|-RVA: 0x230060 Offset: 0x22F460 VA: 0x180230060
	|-SortedList.Enumerator<object, object>.MoveNext
	*/

	private DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x230160 Offset: 0x22F560 VA: 0x180230160
	|-SortedList.Enumerator<long, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x2302C0 Offset: 0x22F6C0 VA: 0x1802302C0
	|-SortedList.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Entry
	*/

	public KeyValuePair<TKey, TValue> get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2311E0 Offset: 0x2305E0 VA: 0x1802311E0
	|-SortedList.Enumerator<long, object>.get_Current
	|
	|-RVA: 0x2312F0 Offset: 0x2306F0 VA: 0x1802312F0
	|-SortedList.Enumerator<object, object>.get_Current
	*/

	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x230C80 Offset: 0x230080 VA: 0x180230C80
	|-SortedList.Enumerator<long, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x230C90 Offset: 0x230090 VA: 0x180230C90
	|-SortedList.Enumerator<object, object>.System.Collections.IEnumerator.get_Current
	*/

	private object System.Collections.IDictionaryEnumerator.get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x230720 Offset: 0x22FB20 VA: 0x180230720
	|-SortedList.Enumerator<long, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x230620 Offset: 0x22FA20 VA: 0x180230620
	|-SortedList.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Value
	*/

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
{	private SortedList<TKey, TValue> _sortedList; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private TKey _currentKey; // 0x0

	public TKey Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	internal void .ctor(SortedList<TKey, TValue> sortedList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E31E20 Offset: 0x1E30420 VA: 0x181E31E20
	|-SortedList.SortedListKeyEnumerator<long, object>..ctor
	|-SortedList.SortedListKeyEnumerator<object, object>..ctor
	*/

	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E31940 Offset: 0x1E2FF40 VA: 0x181E31940
	|-SortedList.SortedListKeyEnumerator<long, object>.Dispose
	|-SortedList.SortedListKeyEnumerator<object, object>.Dispose
	*/

	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E31A70 Offset: 0x1E30070 VA: 0x181E31A70
	|-SortedList.SortedListKeyEnumerator<long, object>.MoveNext
	|
	|-RVA: 0x1E31950 Offset: 0x1E2FF50 VA: 0x181E31950
	|-SortedList.SortedListKeyEnumerator<object, object>.MoveNext
	*/

	public TKey get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	|-SortedList.SortedListKeyEnumerator<long, object>.get_Current
	|-SortedList.SortedListKeyEnumerator<object, object>.get_Current
	*/

	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E31D40 Offset: 0x1E30340 VA: 0x181E31D40
	|-SortedList.SortedListKeyEnumerator<long, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1E31C90 Offset: 0x1E30290 VA: 0x181E31C90
	|-SortedList.SortedListKeyEnumerator<object, object>.System.Collections.IEnumerator.get_Current
	*/

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
{	private SortedList<TKey, TValue> _sortedList; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private TValue _currentValue; // 0x0

	public TValue Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	internal void .ctor(SortedList<TKey, TValue> sortedList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E31E20 Offset: 0x1E30420 VA: 0x181E31E20
	|-SortedList.SortedListValueEnumerator<long, object>..ctor
	|-SortedList.SortedListValueEnumerator<object, object>..ctor
	*/

	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E31940 Offset: 0x1E2FF40 VA: 0x181E31940
	|-SortedList.SortedListValueEnumerator<long, object>.Dispose
	|-SortedList.SortedListValueEnumerator<object, object>.Dispose
	*/

	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E31E70 Offset: 0x1E30470 VA: 0x181E31E70
	|-SortedList.SortedListValueEnumerator<long, object>.MoveNext
	|
	|-RVA: 0x1E31F90 Offset: 0x1E30590 VA: 0x181E31F90
	|-SortedList.SortedListValueEnumerator<object, object>.MoveNext
	*/

	public TValue get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	|-SortedList.SortedListValueEnumerator<long, object>.get_Current
	|-SortedList.SortedListValueEnumerator<object, object>.get_Current
	*/

	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E32260 Offset: 0x1E30860 VA: 0x181E32260
	|-SortedList.SortedListValueEnumerator<long, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1E321B0 Offset: 0x1E307B0 VA: 0x181E321B0
	|-SortedList.SortedListValueEnumerator<object, object>.System.Collections.IEnumerator.get_Current
	*/

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
{	private SortedList<TKey, TValue> _dict; // 0x0

	public int Count { get; }
	public bool IsReadOnly { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public TKey Item { get; set; }


	internal void .ctor(SortedList<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13592D0 Offset: 0x13578D0 VA: 0x1813592D0
	|-SortedList.KeyList<long, object>..ctor
	|-SortedList.KeyList<object, object>..ctor
	*/

	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1343DE0 Offset: 0x13423E0 VA: 0x181343DE0
	|-SortedList.KeyList<long, object>.get_Count
	|-SortedList.KeyList<object, object>.get_Count
	*/

	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0
	|-SortedList.KeyList<long, object>.get_IsReadOnly
	|-SortedList.KeyList<object, object>.get_IsReadOnly
	*/

	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2E210 Offset: 0x1E2C810 VA: 0x181E2E210
	|-SortedList.KeyList<long, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1E2E1C0 Offset: 0x1E2C7C0 VA: 0x181E2E1C0
	|-SortedList.KeyList<object, object>.System.Collections.ICollection.get_SyncRoot
	*/

	public void Add(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2D910 Offset: 0x1E2BF10 VA: 0x181E2D910
	|-SortedList.KeyList<long, object>.Add
	|
	|-RVA: 0x1E2D970 Offset: 0x1E2BF70 VA: 0x181E2D970
	|-SortedList.KeyList<object, object>.Add
	*/

	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2D9D0 Offset: 0x1E2BFD0 VA: 0x181E2D9D0
	|-SortedList.KeyList<long, object>.Clear
	|
	|-RVA: 0x1E2DA30 Offset: 0x1E2C030 VA: 0x181E2DA30
	|-SortedList.KeyList<object, object>.Clear
	*/

	public bool Contains(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5A390 Offset: 0xD58990 VA: 0x180D5A390
	|-SortedList.KeyList<long, object>.Contains
	|-SortedList.KeyList<object, object>.Contains
	*/

	public void CopyTo(TKey[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2DA90 Offset: 0x1E2C090 VA: 0x181E2DA90
	|-SortedList.KeyList<long, object>.CopyTo
	|-SortedList.KeyList<object, object>.CopyTo
	*/

	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2E090 Offset: 0x1E2C690 VA: 0x181E2E090
	|-SortedList.KeyList<long, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1E2DF60 Offset: 0x1E2C560 VA: 0x181E2DF60
	|-SortedList.KeyList<object, object>.System.Collections.ICollection.CopyTo
	*/

	public void Insert(int index, TKey value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2DD20 Offset: 0x1E2C320 VA: 0x181E2DD20
	|-SortedList.KeyList<long, object>.Insert
	|
	|-RVA: 0x1E2DD80 Offset: 0x1E2C380 VA: 0x181E2DD80
	|-SortedList.KeyList<object, object>.Insert
	*/

	public TKey get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2E260 Offset: 0x1E2C860 VA: 0x181E2E260
	|-SortedList.KeyList<long, object>.get_Item
	|-SortedList.KeyList<object, object>.get_Item
	*/

	public void set_Item(int index, TKey value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2E290 Offset: 0x1E2C890 VA: 0x181E2E290
	|-SortedList.KeyList<long, object>.set_Item
	|
	|-RVA: 0x1E2E2F0 Offset: 0x1E2C8F0 VA: 0x181E2E2F0
	|-SortedList.KeyList<object, object>.set_Item
	*/

	public IEnumerator<TKey> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2DB00 Offset: 0x1E2C100 VA: 0x181E2DB00
	|-SortedList.KeyList<long, object>.GetEnumerator
	|-SortedList.KeyList<object, object>.GetEnumerator
	*/

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2DB00 Offset: 0x1E2C100 VA: 0x181E2DB00
	|-SortedList.KeyList<long, object>.System.Collections.IEnumerable.GetEnumerator
	|-SortedList.KeyList<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/

	public int IndexOf(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2DC60 Offset: 0x1E2C260 VA: 0x181E2DC60
	|-SortedList.KeyList<long, object>.IndexOf
	|
	|-RVA: 0x1E2DB70 Offset: 0x1E2C170 VA: 0x181E2DB70
	|-SortedList.KeyList<object, object>.IndexOf
	*/

	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2DEA0 Offset: 0x1E2C4A0 VA: 0x181E2DEA0
	|-SortedList.KeyList<long, object>.Remove
	|
	|-RVA: 0x1E2DF00 Offset: 0x1E2C500 VA: 0x181E2DF00
	|-SortedList.KeyList<object, object>.Remove
	*/

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
{	private SortedList<TKey, TValue> _dict; // 0x0

	public int Count { get; }
	public bool IsReadOnly { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public TValue Item { get; set; }


	internal void .ctor(SortedList<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13592D0 Offset: 0x13578D0 VA: 0x1813592D0
	|-SortedList.ValueList<long, object>..ctor
	|-SortedList.ValueList<object, object>..ctor
	*/

	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1343DE0 Offset: 0x13423E0 VA: 0x181343DE0
	|-SortedList.ValueList<long, object>.get_Count
	|-SortedList.ValueList<object, object>.get_Count
	*/

	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0
	|-SortedList.ValueList<long, object>.get_IsReadOnly
	|-SortedList.ValueList<object, object>.get_IsReadOnly
	*/

	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E387D0 Offset: 0x1E36DD0 VA: 0x181E387D0
	|-SortedList.ValueList<long, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1E38780 Offset: 0x1E36D80 VA: 0x181E38780
	|-SortedList.ValueList<object, object>.System.Collections.ICollection.get_SyncRoot
	*/

	public void Add(TValue key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E380E0 Offset: 0x1E366E0 VA: 0x181E380E0
	|-SortedList.ValueList<long, object>.Add
	|
	|-RVA: 0x1E38080 Offset: 0x1E36680 VA: 0x181E38080
	|-SortedList.ValueList<object, object>.Add
	*/

	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E38140 Offset: 0x1E36740 VA: 0x181E38140
	|-SortedList.ValueList<long, object>.Clear
	|
	|-RVA: 0x1E381A0 Offset: 0x1E367A0 VA: 0x181E381A0
	|-SortedList.ValueList<object, object>.Clear
	*/

	public bool Contains(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5A390 Offset: 0xD58990 VA: 0x180D5A390
	|-SortedList.ValueList<long, object>.Contains
	|-SortedList.ValueList<object, object>.Contains
	*/

	public void CopyTo(TValue[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E38200 Offset: 0x1E36800 VA: 0x181E38200
	|-SortedList.ValueList<long, object>.CopyTo
	|-SortedList.ValueList<object, object>.CopyTo
	*/

	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E38520 Offset: 0x1E36B20 VA: 0x181E38520
	|-SortedList.ValueList<long, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1E38650 Offset: 0x1E36C50 VA: 0x181E38650
	|-SortedList.ValueList<object, object>.System.Collections.ICollection.CopyTo
	*/

	public void Insert(int index, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E382E0 Offset: 0x1E368E0 VA: 0x181E382E0
	|-SortedList.ValueList<long, object>.Insert
	|
	|-RVA: 0x1E38340 Offset: 0x1E36940 VA: 0x181E38340
	|-SortedList.ValueList<object, object>.Insert
	*/

	public TValue get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2E260 Offset: 0x1E2C860 VA: 0x181E2E260
	|-SortedList.ValueList<long, object>.get_Item
	|-SortedList.ValueList<object, object>.get_Item
	*/

	public void set_Item(int index, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E38820 Offset: 0x1E36E20 VA: 0x181E38820
	|-SortedList.ValueList<long, object>.set_Item
	|
	|-RVA: 0x1E38880 Offset: 0x1E36E80 VA: 0x181E38880
	|-SortedList.ValueList<object, object>.set_Item
	*/

	public IEnumerator<TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2DB00 Offset: 0x1E2C100 VA: 0x181E2DB00
	|-SortedList.ValueList<long, object>.GetEnumerator
	|-SortedList.ValueList<object, object>.GetEnumerator
	*/

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2DB00 Offset: 0x1E2C100 VA: 0x181E2DB00
	|-SortedList.ValueList<long, object>.System.Collections.IEnumerable.GetEnumerator
	|-SortedList.ValueList<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/

	public int IndexOf(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E38270 Offset: 0x1E36870 VA: 0x181E38270
	|-SortedList.ValueList<long, object>.IndexOf
	|-SortedList.ValueList<object, object>.IndexOf
	*/

	public bool Remove(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E38460 Offset: 0x1E36A60 VA: 0x181E38460
	|-SortedList.ValueList<long, object>.Remove
	|
	|-RVA: 0x1E384C0 Offset: 0x1E36AC0 VA: 0x181E384C0
	|-SortedList.ValueList<object, object>.Remove
	*/

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

