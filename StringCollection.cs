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

	// RVA: 0x15D68D0 Offset: 0x15D4ED0 VA: 0x1815D68D0
	public string get_Item(int index) { }

	// RVA: 0x15D6A50 Offset: 0x15D5050 VA: 0x1815D6A50
	public void set_Item(int index, string value) { }

	// RVA: 0xB197D0 Offset: 0xB17DD0 VA: 0x180B197D0 Slot: 16
	public int get_Count() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 9
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 10
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x1180BA0 Offset: 0x117F1A0 VA: 0x181180BA0
	public int Add(string value) { }

	// RVA: 0xBC8A50 Offset: 0xBC7050 VA: 0x180BC8A50 Slot: 8
	public void Clear() { }

	// RVA: 0x146CD20 Offset: 0x146B320 VA: 0x18146CD20
	public bool Contains(string value) { }

	// RVA: 0x14D1EB0 Offset: 0x14D04B0 VA: 0x1814D1EB0
	public void CopyTo(string[] array, int index) { }

	// RVA: 0x15D6580 Offset: 0x15D4B80 VA: 0x1815D6580
	public int IndexOf(string value) { }

	// RVA: 0x15D65B0 Offset: 0x15D4BB0 VA: 0x1815D65B0
	public void Insert(int index, string value) { }

	// RVA: 0x15D6610 Offset: 0x15D4C10 VA: 0x1815D6610
	public void Remove(string value) { }

	// RVA: 0x15D65E0 Offset: 0x15D4BE0 VA: 0x1815D65E0 Slot: 14
	public void RemoveAt(int index) { }

	// RVA: 0x13480D0 Offset: 0x13466D0 VA: 0x1813480D0 Slot: 17
	public object get_SyncRoot() { }

	// RVA: 0x15D68D0 Offset: 0x15D4ED0 VA: 0x1815D68D0 Slot: 4
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x15D6950 Offset: 0x15D4F50 VA: 0x1815D6950 Slot: 5
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x15D6640 Offset: 0x15D4C40 VA: 0x1815D6640 Slot: 6
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x15D66C0 Offset: 0x15D4CC0 VA: 0x1815D66C0 Slot: 7
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x15D6740 Offset: 0x15D4D40 VA: 0x1815D6740 Slot: 11
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x15D67C0 Offset: 0x15D4DC0 VA: 0x1815D67C0 Slot: 12
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x15D6850 Offset: 0x15D4E50 VA: 0x1815D6850 Slot: 13
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x14D1EB0 Offset: 0x14D04B0 VA: 0x1814D1EB0 Slot: 15
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0xBC8BA0 Offset: 0xBC71A0 VA: 0x180BC8BA0 Slot: 18
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x15D69E0 Offset: 0x15D4FE0 VA: 0x1815D69E0
	public void .ctor() { }

}

