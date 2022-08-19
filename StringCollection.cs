public class StringCollection : IList, ICollection, IEnumerable // TypeDefIndex: 3110
{	// Fields
	private ArrayList data; // 0x10

	// Properties
	public string Item { get; set; }
	public int Count { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	public object SyncRoot { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x15D7540 Offset: 0x15D5B40 VA: 0x1815D7540
	public string get_Item(int index) { }

	// RVA: 0x15D76C0 Offset: 0x15D5CC0 VA: 0x1815D76C0
	public void set_Item(int index, string value) { }

	// RVA: 0xB19040 Offset: 0xB17640 VA: 0x180B19040 Slot: 16
	public int get_Count() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 9
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 10
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x117BFC0 Offset: 0x117A5C0 VA: 0x18117BFC0
	public int Add(string value) { }

	// RVA: 0xBC82C0 Offset: 0xBC68C0 VA: 0x180BC82C0 Slot: 8
	public void Clear() { }

	// RVA: 0x146D990 Offset: 0x146BF90 VA: 0x18146D990
	public bool Contains(string value) { }

	// RVA: 0x14D2B20 Offset: 0x14D1120 VA: 0x1814D2B20
	public void CopyTo(string[] array, int index) { }

	// RVA: 0x15D71F0 Offset: 0x15D57F0 VA: 0x1815D71F0
	public int IndexOf(string value) { }

	// RVA: 0x15D7220 Offset: 0x15D5820 VA: 0x1815D7220
	public void Insert(int index, string value) { }

	// RVA: 0x15D7280 Offset: 0x15D5880 VA: 0x1815D7280
	public void Remove(string value) { }

	// RVA: 0x15D7250 Offset: 0x15D5850 VA: 0x1815D7250 Slot: 14
	public void RemoveAt(int index) { }

	// RVA: 0x1348D10 Offset: 0x1347310 VA: 0x181348D10 Slot: 17
	public object get_SyncRoot() { }

	// RVA: 0x15D7540 Offset: 0x15D5B40 VA: 0x1815D7540 Slot: 4
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x15D75C0 Offset: 0x15D5BC0 VA: 0x1815D75C0 Slot: 5
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x15D72B0 Offset: 0x15D58B0 VA: 0x1815D72B0 Slot: 6
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x15D7330 Offset: 0x15D5930 VA: 0x1815D7330 Slot: 7
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x15D73B0 Offset: 0x15D59B0 VA: 0x1815D73B0 Slot: 11
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x15D7430 Offset: 0x15D5A30 VA: 0x1815D7430 Slot: 12
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x15D74C0 Offset: 0x15D5AC0 VA: 0x1815D74C0 Slot: 13
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x14D2B20 Offset: 0x14D1120 VA: 0x1814D2B20 Slot: 15
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0xBC8410 Offset: 0xBC6A10 VA: 0x180BC8410 Slot: 18
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x15D7650 Offset: 0x15D5C50 VA: 0x1815D7650
	public void .ctor() { }

}

