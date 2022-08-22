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

	// RVA: 0x15D7800 Offset: 0x15D5E00 VA: 0x1815D7800
	public string get_Item(int index) { }

	// RVA: 0x15D7980 Offset: 0x15D5F80 VA: 0x1815D7980
	public void set_Item(int index, string value) { }

	// RVA: 0xB19300 Offset: 0xB17900 VA: 0x180B19300 Slot: 16
	public int get_Count() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 9
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 10
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x117C280 Offset: 0x117A880 VA: 0x18117C280
	public int Add(string value) { }

	// RVA: 0xBC8580 Offset: 0xBC6B80 VA: 0x180BC8580 Slot: 8
	public void Clear() { }

	// RVA: 0x146DC50 Offset: 0x146C250 VA: 0x18146DC50
	public bool Contains(string value) { }

	// RVA: 0x14D2DE0 Offset: 0x14D13E0 VA: 0x1814D2DE0
	public void CopyTo(string[] array, int index) { }

	// RVA: 0x15D74B0 Offset: 0x15D5AB0 VA: 0x1815D74B0
	public int IndexOf(string value) { }

	// RVA: 0x15D74E0 Offset: 0x15D5AE0 VA: 0x1815D74E0
	public void Insert(int index, string value) { }

	// RVA: 0x15D7540 Offset: 0x15D5B40 VA: 0x1815D7540
	public void Remove(string value) { }

	// RVA: 0x15D7510 Offset: 0x15D5B10 VA: 0x1815D7510 Slot: 14
	public void RemoveAt(int index) { }

	// RVA: 0x1348FD0 Offset: 0x13475D0 VA: 0x181348FD0 Slot: 17
	public object get_SyncRoot() { }

	// RVA: 0x15D7800 Offset: 0x15D5E00 VA: 0x1815D7800 Slot: 4
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x15D7880 Offset: 0x15D5E80 VA: 0x1815D7880 Slot: 5
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x15D7570 Offset: 0x15D5B70 VA: 0x1815D7570 Slot: 6
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x15D75F0 Offset: 0x15D5BF0 VA: 0x1815D75F0 Slot: 7
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x15D7670 Offset: 0x15D5C70 VA: 0x1815D7670 Slot: 11
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x15D76F0 Offset: 0x15D5CF0 VA: 0x1815D76F0 Slot: 12
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x15D7780 Offset: 0x15D5D80 VA: 0x1815D7780 Slot: 13
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x14D2DE0 Offset: 0x14D13E0 VA: 0x1814D2DE0 Slot: 15
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0xBC86D0 Offset: 0xBC6CD0 VA: 0x180BC86D0 Slot: 18
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x15D7910 Offset: 0x15D5F10 VA: 0x1815D7910
	public void .ctor() { }

}

