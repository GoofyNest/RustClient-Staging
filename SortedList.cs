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
	|-RVA: 0x1E31E60 Offset: 0x1E30460 VA: 0x181E31E60
	|-SortedList.SortedListKeyEnumerator<long, object>..ctor
	|-SortedList.SortedListKeyEnumerator<object, object>..ctor
	*/

	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E31980 Offset: 0x1E2FF80 VA: 0x181E31980
	|-SortedList.SortedListKeyEnumerator<long, object>.Dispose
	|-SortedList.SortedListKeyEnumerator<object, object>.Dispose
	*/

	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E31AB0 Offset: 0x1E300B0 VA: 0x181E31AB0
	|-SortedList.SortedListKeyEnumerator<long, object>.MoveNext
	|
	|-RVA: 0x1E31990 Offset: 0x1E2FF90 VA: 0x181E31990
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
	|-RVA: 0x1E31D80 Offset: 0x1E30380 VA: 0x181E31D80
	|-SortedList.SortedListKeyEnumerator<long, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1E31CD0 Offset: 0x1E302D0 VA: 0x181E31CD0
	|-SortedList.SortedListKeyEnumerator<object, object>.System.Collections.IEnumerator.get_Current
	*/

	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E31BD0 Offset: 0x1E301D0 VA: 0x181E31BD0
	|-SortedList.SortedListKeyEnumerator<long, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1E31C50 Offset: 0x1E30250 VA: 0x181E31C50
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
	|-RVA: 0x1E31E60 Offset: 0x1E30460 VA: 0x181E31E60
	|-SortedList.SortedListValueEnumerator<long, object>..ctor
	|-SortedList.SortedListValueEnumerator<object, object>..ctor
	*/

	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E31980 Offset: 0x1E2FF80 VA: 0x181E31980
	|-SortedList.SortedListValueEnumerator<long, object>.Dispose
	|-SortedList.SortedListValueEnumerator<object, object>.Dispose
	*/

	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E31EB0 Offset: 0x1E304B0 VA: 0x181E31EB0
	|-SortedList.SortedListValueEnumerator<long, object>.MoveNext
	|
	|-RVA: 0x1E31FD0 Offset: 0x1E305D0 VA: 0x181E31FD0
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
	|-RVA: 0x1E322A0 Offset: 0x1E308A0 VA: 0x181E322A0
	|-SortedList.SortedListValueEnumerator<long, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1E321F0 Offset: 0x1E307F0 VA: 0x181E321F0
	|-SortedList.SortedListValueEnumerator<object, object>.System.Collections.IEnumerator.get_Current
	*/

	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E32170 Offset: 0x1E30770 VA: 0x181E32170
	|-SortedList.SortedListValueEnumerator<long, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1E320F0 Offset: 0x1E306F0 VA: 0x181E320F0
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
	|-RVA: 0x1359310 Offset: 0x1357910 VA: 0x181359310
	|-SortedList.KeyList<long, object>..ctor
	|-SortedList.KeyList<object, object>..ctor
	*/

	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1343E20 Offset: 0x1342420 VA: 0x181343E20
	|-SortedList.KeyList<long, object>.get_Count
	|-SortedList.KeyList<object, object>.get_Count
	*/

	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4D7D00 Offset: 0x4D6300 VA: 0x1804D7D00
	|-SortedList.KeyList<long, object>.get_IsReadOnly
	|-SortedList.KeyList<object, object>.get_IsReadOnly
	*/

	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2E250 Offset: 0x1E2C850 VA: 0x181E2E250
	|-SortedList.KeyList<long, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1E2E200 Offset: 0x1E2C800 VA: 0x181E2E200
	|-SortedList.KeyList<object, object>.System.Collections.ICollection.get_SyncRoot
	*/

	public void Add(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2D950 Offset: 0x1E2BF50 VA: 0x181E2D950
	|-SortedList.KeyList<long, object>.Add
	|
	|-RVA: 0x1E2D9B0 Offset: 0x1E2BFB0 VA: 0x181E2D9B0
	|-SortedList.KeyList<object, object>.Add
	*/

	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2DA10 Offset: 0x1E2C010 VA: 0x181E2DA10
	|-SortedList.KeyList<long, object>.Clear
	|
	|-RVA: 0x1E2DA70 Offset: 0x1E2C070 VA: 0x181E2DA70
	|-SortedList.KeyList<object, object>.Clear
	*/

	public bool Contains(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5A4D0 Offset: 0xD58AD0 VA: 0x180D5A4D0
	|-SortedList.KeyList<long, object>.Contains
	|-SortedList.KeyList<object, object>.Contains
	*/

	public void CopyTo(TKey[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2DAD0 Offset: 0x1E2C0D0 VA: 0x181E2DAD0
	|-SortedList.KeyList<long, object>.CopyTo
	|-SortedList.KeyList<object, object>.CopyTo
	*/

	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2E0D0 Offset: 0x1E2C6D0 VA: 0x181E2E0D0
	|-SortedList.KeyList<long, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1E2DFA0 Offset: 0x1E2C5A0 VA: 0x181E2DFA0
	|-SortedList.KeyList<object, object>.System.Collections.ICollection.CopyTo
	*/

	public void Insert(int index, TKey value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2DD60 Offset: 0x1E2C360 VA: 0x181E2DD60
	|-SortedList.KeyList<long, object>.Insert
	|
	|-RVA: 0x1E2DDC0 Offset: 0x1E2C3C0 VA: 0x181E2DDC0
	|-SortedList.KeyList<object, object>.Insert
	*/

	public TKey get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2E2A0 Offset: 0x1E2C8A0 VA: 0x181E2E2A0
	|-SortedList.KeyList<long, object>.get_Item
	|-SortedList.KeyList<object, object>.get_Item
	*/

	public void set_Item(int index, TKey value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2E2D0 Offset: 0x1E2C8D0 VA: 0x181E2E2D0
	|-SortedList.KeyList<long, object>.set_Item
	|
	|-RVA: 0x1E2E330 Offset: 0x1E2C930 VA: 0x181E2E330
	|-SortedList.KeyList<object, object>.set_Item
	*/

	public IEnumerator<TKey> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2DB40 Offset: 0x1E2C140 VA: 0x181E2DB40
	|-SortedList.KeyList<long, object>.GetEnumerator
	|-SortedList.KeyList<object, object>.GetEnumerator
	*/

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2DB40 Offset: 0x1E2C140 VA: 0x181E2DB40
	|-SortedList.KeyList<long, object>.System.Collections.IEnumerable.GetEnumerator
	|-SortedList.KeyList<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/

	public int IndexOf(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2DCA0 Offset: 0x1E2C2A0 VA: 0x181E2DCA0
	|-SortedList.KeyList<long, object>.IndexOf
	|
	|-RVA: 0x1E2DBB0 Offset: 0x1E2C1B0 VA: 0x181E2DBB0
	|-SortedList.KeyList<object, object>.IndexOf
	*/

	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2DEE0 Offset: 0x1E2C4E0 VA: 0x181E2DEE0
	|-SortedList.KeyList<long, object>.Remove
	|
	|-RVA: 0x1E2DF40 Offset: 0x1E2C540 VA: 0x181E2DF40
	|-SortedList.KeyList<object, object>.Remove
	*/

	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2DE80 Offset: 0x1E2C480 VA: 0x181E2DE80
	|-SortedList.KeyList<long, object>.RemoveAt
	|
	|-RVA: 0x1E2DE20 Offset: 0x1E2C420 VA: 0x181E2DE20
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
	|-RVA: 0x1359310 Offset: 0x1357910 VA: 0x181359310
	|-SortedList.ValueList<long, object>..ctor
	|-SortedList.ValueList<object, object>..ctor
	*/

	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1343E20 Offset: 0x1342420 VA: 0x181343E20
	|-SortedList.ValueList<long, object>.get_Count
	|-SortedList.ValueList<object, object>.get_Count
	*/

	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4D7D00 Offset: 0x4D6300 VA: 0x1804D7D00
	|-SortedList.ValueList<long, object>.get_IsReadOnly
	|-SortedList.ValueList<object, object>.get_IsReadOnly
	*/

	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E38810 Offset: 0x1E36E10 VA: 0x181E38810
	|-SortedList.ValueList<long, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1E387C0 Offset: 0x1E36DC0 VA: 0x181E387C0
	|-SortedList.ValueList<object, object>.System.Collections.ICollection.get_SyncRoot
	*/

	public void Add(TValue key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E38120 Offset: 0x1E36720 VA: 0x181E38120
	|-SortedList.ValueList<long, object>.Add
	|
	|-RVA: 0x1E380C0 Offset: 0x1E366C0 VA: 0x181E380C0
	|-SortedList.ValueList<object, object>.Add
	*/

	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E38180 Offset: 0x1E36780 VA: 0x181E38180
	|-SortedList.ValueList<long, object>.Clear
	|
	|-RVA: 0x1E381E0 Offset: 0x1E367E0 VA: 0x181E381E0
	|-SortedList.ValueList<object, object>.Clear
	*/

	public bool Contains(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5A4D0 Offset: 0xD58AD0 VA: 0x180D5A4D0
	|-SortedList.ValueList<long, object>.Contains
	|-SortedList.ValueList<object, object>.Contains
	*/

	public void CopyTo(TValue[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E38240 Offset: 0x1E36840 VA: 0x181E38240
	|-SortedList.ValueList<long, object>.CopyTo
	|-SortedList.ValueList<object, object>.CopyTo
	*/

	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E38560 Offset: 0x1E36B60 VA: 0x181E38560
	|-SortedList.ValueList<long, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1E38690 Offset: 0x1E36C90 VA: 0x181E38690
	|-SortedList.ValueList<object, object>.System.Collections.ICollection.CopyTo
	*/

	public void Insert(int index, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E38320 Offset: 0x1E36920 VA: 0x181E38320
	|-SortedList.ValueList<long, object>.Insert
	|
	|-RVA: 0x1E38380 Offset: 0x1E36980 VA: 0x181E38380
	|-SortedList.ValueList<object, object>.Insert
	*/

	public TValue get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2E2A0 Offset: 0x1E2C8A0 VA: 0x181E2E2A0
	|-SortedList.ValueList<long, object>.get_Item
	|-SortedList.ValueList<object, object>.get_Item
	*/

	public void set_Item(int index, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E38860 Offset: 0x1E36E60 VA: 0x181E38860
	|-SortedList.ValueList<long, object>.set_Item
	|
	|-RVA: 0x1E388C0 Offset: 0x1E36EC0 VA: 0x181E388C0
	|-SortedList.ValueList<object, object>.set_Item
	*/

	public IEnumerator<TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2DB40 Offset: 0x1E2C140 VA: 0x181E2DB40
	|-SortedList.ValueList<long, object>.GetEnumerator
	|-SortedList.ValueList<object, object>.GetEnumerator
	*/

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2DB40 Offset: 0x1E2C140 VA: 0x181E2DB40
	|-SortedList.ValueList<long, object>.System.Collections.IEnumerable.GetEnumerator
	|-SortedList.ValueList<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/

	public int IndexOf(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E382B0 Offset: 0x1E368B0 VA: 0x181E382B0
	|-SortedList.ValueList<long, object>.IndexOf
	|-SortedList.ValueList<object, object>.IndexOf
	*/

	public bool Remove(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E384A0 Offset: 0x1E36AA0 VA: 0x181E384A0
	|-SortedList.ValueList<long, object>.Remove
	|
	|-RVA: 0x1E38500 Offset: 0x1E36B00 VA: 0x181E38500
	|-SortedList.ValueList<object, object>.Remove
	*/

	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E38440 Offset: 0x1E36A40 VA: 0x181E38440
	|-SortedList.ValueList<long, object>.RemoveAt
	|
	|-RVA: 0x1E383E0 Offset: 0x1E369E0 VA: 0x181E383E0
	|-SortedList.ValueList<object, object>.RemoveAt
	*/

}

