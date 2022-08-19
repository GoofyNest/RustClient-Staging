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

	// RVA: 0x1737840 Offset: 0x1735E40 VA: 0x181737840
	internal void .ctor() { }

	// RVA: 0xB19040 Offset: 0xB17640 VA: 0x180B19040 Slot: 16
	public int get_Count() { }

	// RVA: 0x1736A50 Offset: 0x1735050 VA: 0x181736A50
	public int Add(TraceListener listener) { }

	// RVA: 0x1736B90 Offset: 0x1735190 VA: 0x181736B90 Slot: 8
	public void Clear() { }

	// RVA: 0xBC8410 Offset: 0xBC6A10 VA: 0x180BC8410 Slot: 18
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1736BF0 Offset: 0x17351F0 VA: 0x181736BF0
	internal void InitializeListener(TraceListener listener) { }

	// RVA: 0x1736D40 Offset: 0x1735340 VA: 0x181736D40 Slot: 14
	public void RemoveAt(int index) { }

	// RVA: 0xBC8290 Offset: 0xBC6890 VA: 0x180BC8290 Slot: 4
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x1737640 Offset: 0x1735C40 VA: 0x181737640 Slot: 5
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 9
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 10
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x1736FA0 Offset: 0x17355A0 VA: 0x181736FA0 Slot: 6
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x146D990 Offset: 0x146BF90 VA: 0x18146D990 Slot: 7
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x15D71F0 Offset: 0x15D57F0 VA: 0x1815D71F0 Slot: 11
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x1737260 Offset: 0x1735860 VA: 0x181737260 Slot: 12
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x1737510 Offset: 0x1735B10 VA: 0x181737510 Slot: 13
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 17
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1736E70 Offset: 0x1735470 VA: 0x181736E70 Slot: 15
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

}

