public class TraceListenerCollection : IList, ICollection, IEnumerable // TypeDefIndex: 2644
{	// Fields
	private ArrayList list; // 0x10

	// Properties
	public int Count { get; }
	private object System.Collections.IList.Item { get; set; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: 0x1737B00 Offset: 0x1736100 VA: 0x181737B00
	internal void .ctor() { }

	// RVA: 0xB19300 Offset: 0xB17900 VA: 0x180B19300 Slot: 16
	public int get_Count() { }

	// RVA: 0x1736D10 Offset: 0x1735310 VA: 0x181736D10
	public int Add(TraceListener listener) { }

	// RVA: 0x1736E50 Offset: 0x1735450 VA: 0x181736E50 Slot: 8
	public void Clear() { }

	// RVA: 0xBC86D0 Offset: 0xBC6CD0 VA: 0x180BC86D0 Slot: 18
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1736EB0 Offset: 0x17354B0 VA: 0x181736EB0
	internal void InitializeListener(TraceListener listener) { }

	// RVA: 0x1737000 Offset: 0x1735600 VA: 0x181737000 Slot: 14
	public void RemoveAt(int index) { }

	// RVA: 0xBC8550 Offset: 0xBC6B50 VA: 0x180BC8550 Slot: 4
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x1737900 Offset: 0x1735F00 VA: 0x181737900 Slot: 5
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 9
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 10
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x1737260 Offset: 0x1735860 VA: 0x181737260 Slot: 6
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x146DC50 Offset: 0x146C250 VA: 0x18146DC50 Slot: 7
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x15D74B0 Offset: 0x15D5AB0 VA: 0x1815D74B0 Slot: 11
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x1737520 Offset: 0x1735B20 VA: 0x181737520 Slot: 12
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x17377D0 Offset: 0x1735DD0 VA: 0x1817377D0 Slot: 13
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 17
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1737130 Offset: 0x1735730 VA: 0x181737130 Slot: 15
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

}

