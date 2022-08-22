public class PropertyDescriptorCollection : ICollection, IEnumerable, IList, IDictionary // TypeDefIndex: 2735
{	// Fields
	public static readonly PropertyDescriptorCollection Empty; // 0x0
	private IDictionary cachedFoundProperties; // 0x10
	private bool cachedIgnoreCase; // 0x18
	private PropertyDescriptor[] properties; // 0x20
	private int propCount; // 0x28
	private string[] namedSort; // 0x30
	private IComparer comparer; // 0x38
	private bool propsOwned; // 0x40
	private bool needSort; // 0x41
	private bool readOnly; // 0x42

	// Properties
	public int Count { get; }
	public virtual PropertyDescriptor Item { get; }
	public virtual PropertyDescriptor Item { get; }
	private int System.Collections.ICollection.Count { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private object System.Collections.IDictionary.Item { get; set; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x15D2670 Offset: 0x15D0C70 VA: 0x1815D2670
	public void .ctor(PropertyDescriptor[] properties) { }

	// RVA: 0x15D2710 Offset: 0x15D0D10 VA: 0x1815D2710
	public void .ctor(PropertyDescriptor[] properties, bool readOnly) { }

	// RVA: 0x15D2590 Offset: 0x15D0B90 VA: 0x1815D2590
	private void .ctor(PropertyDescriptor[] properties, int propCount, string[] namedSort, IComparer comparer) { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	public int get_Count() { }

	// RVA: 0x15D27E0 Offset: 0x15D0DE0 VA: 0x1815D27E0 Slot: 29
	public virtual PropertyDescriptor get_Item(int index) { }

	// RVA: 0x15D27C0 Offset: 0x15D0DC0 VA: 0x1815D27C0 Slot: 30
	public virtual PropertyDescriptor get_Item(string name) { }

	// RVA: 0x15D0300 Offset: 0x15CE900 VA: 0x1815D0300
	public int Add(PropertyDescriptor value) { }

	// RVA: 0x15D0400 Offset: 0x15CEA00 VA: 0x1815D0400
	public void Clear() { }

	// RVA: 0x15D0470 Offset: 0x15CEA70 VA: 0x1815D0470
	public bool Contains(PropertyDescriptor value) { }

	// RVA: 0x15D04D0 Offset: 0x15CEAD0 VA: 0x1815D04D0 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x15D0520 Offset: 0x15CEB20 VA: 0x1815D0520
	private void EnsurePropsOwned() { }

	// RVA: 0x15D05D0 Offset: 0x15CEBD0 VA: 0x1815D05D0
	private void EnsureSize(int sizeNeeded) { }

	// RVA: 0x15D06F0 Offset: 0x15CECF0 VA: 0x1815D06F0 Slot: 31
	public virtual PropertyDescriptor Find(string name, bool ignoreCase) { }

	// RVA: 0x15D0BE0 Offset: 0x15CF1E0 VA: 0x1815D0BE0
	public int IndexOf(PropertyDescriptor value) { }

	// RVA: 0x15D0C40 Offset: 0x15CF240 VA: 0x1815D0C40
	public void Insert(int index, PropertyDescriptor value) { }

	// RVA: 0x15D12D0 Offset: 0x15CF8D0 VA: 0x1815D12D0
	public void Remove(PropertyDescriptor value) { }

	// RVA: 0x15D11F0 Offset: 0x15CF7F0 VA: 0x1815D11F0
	public void RemoveAt(int index) { }

	// RVA: 0x15D1390 Offset: 0x15CF990 VA: 0x1815D1390 Slot: 32
	public virtual PropertyDescriptorCollection Sort(string[] names) { }

	// RVA: 0x15D0DE0 Offset: 0x15CF3E0 VA: 0x1815D0DE0
	protected void InternalSort(string[] names) { }

	// RVA: 0x15D0D60 Offset: 0x15CF360 VA: 0x1815D0D60
	protected void InternalSort(IComparer sorter) { }

	// RVA: 0x15D0B30 Offset: 0x15CF130 VA: 0x1815D0B30 Slot: 33
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x15D14A0 Offset: 0x15CFAA0 VA: 0x1815D14A0 Slot: 24
	private void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0x15D0400 Offset: 0x15CEA00 VA: 0x1815D0400 Slot: 25
	private void System.Collections.IDictionary.Clear() { }

	// RVA: 0x15D1550 Offset: 0x15CFB50 VA: 0x1815D1550 Slot: 23
	private bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0x15D15F0 Offset: 0x15CFBF0 VA: 0x1815D15F0 Slot: 27
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: 0xEE72D0 Offset: 0xEE58D0 VA: 0x180EE72D0 Slot: 26
	private bool System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: 0x15D1700 Offset: 0x15CFD00 VA: 0x1815D1700 Slot: 19
	private object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0x15D1970 Offset: 0x15CFF70 VA: 0x1815D1970 Slot: 20
	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0x15D1790 Offset: 0x15CFD90 VA: 0x1815D1790 Slot: 21
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0x15D18B0 Offset: 0x15CFEB0 VA: 0x1815D18B0 Slot: 22
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0x15D1660 Offset: 0x15CFC60 VA: 0x1815D1660 Slot: 28
	private void System.Collections.IDictionary.Remove(object key) { }

	// RVA: 0x15D1D60 Offset: 0x15D0360 VA: 0x1815D1D60 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x15D1D80 Offset: 0x15D0380 VA: 0x1815D1D80 Slot: 10
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x15D0400 Offset: 0x15CEA00 VA: 0x1815D0400 Slot: 12
	private void System.Collections.IList.Clear() { }

	// RVA: 0x15D1E10 Offset: 0x15D0410 VA: 0x1815D1E10 Slot: 11
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x15D1EE0 Offset: 0x15D04E0 VA: 0x1815D1EE0 Slot: 15
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x15D1FB0 Offset: 0x15D05B0 VA: 0x1815D1FB0 Slot: 16
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0xEE72D0 Offset: 0xEE58D0 VA: 0x180EE72D0 Slot: 13
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0xEE72D0 Offset: 0xEE58D0 VA: 0x180EE72D0 Slot: 14
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x15D2150 Offset: 0x15D0750 VA: 0x1815D2150 Slot: 17
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x15D2140 Offset: 0x15D0740 VA: 0x1815D2140 Slot: 18
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x15D2280 Offset: 0x15D0880 VA: 0x1815D2280 Slot: 8
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x15D22A0 Offset: 0x15D08A0 VA: 0x1815D22A0 Slot: 9
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x15D24D0 Offset: 0x15D0AD0 VA: 0x1815D24D0
	private static void .cctor() { }

}

private class PropertyDescriptorCollection.PropertyDescriptorEnumerator : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 2736
{	// Fields
	private PropertyDescriptorCollection owner; // 0x10
	private int index; // 0x18

	// Properties
	public object Current { get; }
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x11B9D20 Offset: 0x11B8320 VA: 0x1811B9D20
	public void .ctor(PropertyDescriptorCollection owner) { }

	// RVA: 0x15D28C0 Offset: 0x15D0EC0 VA: 0x1815D28C0 Slot: 8
	public object get_Current() { }

	// RVA: 0x15D2960 Offset: 0x15D0F60 VA: 0x1815D2960 Slot: 6
	public DictionaryEntry get_Entry() { }

	// RVA: 0x15D29D0 Offset: 0x15D0FD0 VA: 0x1815D29D0 Slot: 4
	public object get_Key() { }

	// RVA: 0x15D29D0 Offset: 0x15D0FD0 VA: 0x1815D29D0 Slot: 5
	public object get_Value() { }

	// RVA: 0x15D2880 Offset: 0x15D0E80 VA: 0x1815D2880 Slot: 7
	public bool MoveNext() { }

	// RVA: 0x117C6D0 Offset: 0x117ACD0 VA: 0x18117C6D0 Slot: 9
	public void Reset() { }

}

