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

	// RVA: 0x17356C0 Offset: 0x1733CC0 VA: 0x1817356C0
	internal void .ctor() { }

	// RVA: 0xB197D0 Offset: 0xB17DD0 VA: 0x180B197D0 Slot: 16
	public int get_Count() { }

	// RVA: 0x17348D0 Offset: 0x1732ED0 VA: 0x1817348D0
	public int Add(TraceListener listener) { }

	// RVA: 0x1734A10 Offset: 0x1733010 VA: 0x181734A10 Slot: 8
	public void Clear() { }

	// RVA: 0xBC8BA0 Offset: 0xBC71A0 VA: 0x180BC8BA0 Slot: 18
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1734A70 Offset: 0x1733070 VA: 0x181734A70
	internal void InitializeListener(TraceListener listener) { }

	// RVA: 0x1734BC0 Offset: 0x17331C0 VA: 0x181734BC0 Slot: 14
	public void RemoveAt(int index) { }

	// RVA: 0xBC8A20 Offset: 0xBC7020 VA: 0x180BC8A20 Slot: 4
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x17354C0 Offset: 0x1733AC0 VA: 0x1817354C0 Slot: 5
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 9
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 10
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x1734E20 Offset: 0x1733420 VA: 0x181734E20 Slot: 6
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x146CD20 Offset: 0x146B320 VA: 0x18146CD20 Slot: 7
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x15D6580 Offset: 0x15D4B80 VA: 0x1815D6580 Slot: 11
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x17350E0 Offset: 0x17336E0 VA: 0x1817350E0 Slot: 12
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x1735390 Offset: 0x1733990 VA: 0x181735390 Slot: 13
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 17
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1734CF0 Offset: 0x17332F0 VA: 0x181734CF0 Slot: 15
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

}

