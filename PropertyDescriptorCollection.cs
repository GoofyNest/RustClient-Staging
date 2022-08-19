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

	// RVA: 0x15D23B0 Offset: 0x15D09B0 VA: 0x1815D23B0
	public void .ctor(PropertyDescriptor[] properties) { }

	// RVA: 0x15D2450 Offset: 0x15D0A50 VA: 0x1815D2450
	public void .ctor(PropertyDescriptor[] properties, bool readOnly) { }

	// RVA: 0x15D22D0 Offset: 0x15D08D0 VA: 0x1815D22D0
	private void .ctor(PropertyDescriptor[] properties, int propCount, string[] namedSort, IComparer comparer) { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	public int get_Count() { }

	// RVA: 0x15D2520 Offset: 0x15D0B20 VA: 0x1815D2520 Slot: 29
	public virtual PropertyDescriptor get_Item(int index) { }

	// RVA: 0x15D2500 Offset: 0x15D0B00 VA: 0x1815D2500 Slot: 30
	public virtual PropertyDescriptor get_Item(string name) { }

	// RVA: 0x15D0040 Offset: 0x15CE640 VA: 0x1815D0040
	public int Add(PropertyDescriptor value) { }

	// RVA: 0x15D0140 Offset: 0x15CE740 VA: 0x1815D0140
	public void Clear() { }

	// RVA: 0x15D01B0 Offset: 0x15CE7B0 VA: 0x1815D01B0
	public bool Contains(PropertyDescriptor value) { }

	// RVA: 0x15D0210 Offset: 0x15CE810 VA: 0x1815D0210 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x15D0260 Offset: 0x15CE860 VA: 0x1815D0260
	private void EnsurePropsOwned() { }

	// RVA: 0x15D0310 Offset: 0x15CE910 VA: 0x1815D0310
	private void EnsureSize(int sizeNeeded) { }

	// RVA: 0x15D0430 Offset: 0x15CEA30 VA: 0x1815D0430 Slot: 31
	public virtual PropertyDescriptor Find(string name, bool ignoreCase) { }

	// RVA: 0x15D0920 Offset: 0x15CEF20 VA: 0x1815D0920
	public int IndexOf(PropertyDescriptor value) { }

	// RVA: 0x15D0980 Offset: 0x15CEF80 VA: 0x1815D0980
	public void Insert(int index, PropertyDescriptor value) { }

	// RVA: 0x15D1010 Offset: 0x15CF610 VA: 0x1815D1010
	public void Remove(PropertyDescriptor value) { }

	// RVA: 0x15D0F30 Offset: 0x15CF530 VA: 0x1815D0F30
	public void RemoveAt(int index) { }

	// RVA: 0x15D10D0 Offset: 0x15CF6D0 VA: 0x1815D10D0 Slot: 32
	public virtual PropertyDescriptorCollection Sort(string[] names) { }

	// RVA: 0x15D0B20 Offset: 0x15CF120 VA: 0x1815D0B20
	protected void InternalSort(string[] names) { }

	// RVA: 0x15D0AA0 Offset: 0x15CF0A0 VA: 0x1815D0AA0
	protected void InternalSort(IComparer sorter) { }

	// RVA: 0x15D0870 Offset: 0x15CEE70 VA: 0x1815D0870 Slot: 33
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x15D11E0 Offset: 0x15CF7E0 VA: 0x1815D11E0 Slot: 24
	private void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0x15D0140 Offset: 0x15CE740 VA: 0x1815D0140 Slot: 25
	private void System.Collections.IDictionary.Clear() { }

	// RVA: 0x15D1290 Offset: 0x15CF890 VA: 0x1815D1290 Slot: 23
	private bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0x15D1330 Offset: 0x15CF930 VA: 0x1815D1330 Slot: 27
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: 0xEE7010 Offset: 0xEE5610 VA: 0x180EE7010 Slot: 26
	private bool System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: 0x15D1440 Offset: 0x15CFA40 VA: 0x1815D1440 Slot: 19
	private object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0x15D16B0 Offset: 0x15CFCB0 VA: 0x1815D16B0 Slot: 20
	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0x15D14D0 Offset: 0x15CFAD0 VA: 0x1815D14D0 Slot: 21
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0x15D15F0 Offset: 0x15CFBF0 VA: 0x1815D15F0 Slot: 22
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0x15D13A0 Offset: 0x15CF9A0 VA: 0x1815D13A0 Slot: 28
	private void System.Collections.IDictionary.Remove(object key) { }

	// RVA: 0x15D1AA0 Offset: 0x15D00A0 VA: 0x1815D1AA0 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x15D1AC0 Offset: 0x15D00C0 VA: 0x1815D1AC0 Slot: 10
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x15D0140 Offset: 0x15CE740 VA: 0x1815D0140 Slot: 12
	private void System.Collections.IList.Clear() { }

	// RVA: 0x15D1B50 Offset: 0x15D0150 VA: 0x1815D1B50 Slot: 11
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x15D1C20 Offset: 0x15D0220 VA: 0x1815D1C20 Slot: 15
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x15D1CF0 Offset: 0x15D02F0 VA: 0x1815D1CF0 Slot: 16
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0xEE7010 Offset: 0xEE5610 VA: 0x180EE7010 Slot: 13
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0xEE7010 Offset: 0xEE5610 VA: 0x180EE7010 Slot: 14
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x15D1E90 Offset: 0x15D0490 VA: 0x1815D1E90 Slot: 17
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x15D1E80 Offset: 0x15D0480 VA: 0x1815D1E80 Slot: 18
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x15D1FC0 Offset: 0x15D05C0 VA: 0x1815D1FC0 Slot: 8
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x15D1FE0 Offset: 0x15D05E0 VA: 0x1815D1FE0 Slot: 9
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x15D2210 Offset: 0x15D0810 VA: 0x1815D2210
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

	// RVA: 0x11B9A60 Offset: 0x11B8060 VA: 0x1811B9A60
	public void .ctor(PropertyDescriptorCollection owner) { }

	// RVA: 0x15D2600 Offset: 0x15D0C00 VA: 0x1815D2600 Slot: 8
	public object get_Current() { }

	// RVA: 0x15D26A0 Offset: 0x15D0CA0 VA: 0x1815D26A0 Slot: 6
	public DictionaryEntry get_Entry() { }

	// RVA: 0x15D2710 Offset: 0x15D0D10 VA: 0x1815D2710 Slot: 4
	public object get_Key() { }

	// RVA: 0x15D2710 Offset: 0x15D0D10 VA: 0x1815D2710 Slot: 5
	public object get_Value() { }

	// RVA: 0x15D25C0 Offset: 0x15D0BC0 VA: 0x1815D25C0 Slot: 7
	public bool MoveNext() { }

	// RVA: 0x117C410 Offset: 0x117AA10 VA: 0x18117C410 Slot: 9
	public void Reset() { }

}

