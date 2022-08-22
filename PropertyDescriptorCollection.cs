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

	// RVA: 0x15D1740 Offset: 0x15CFD40 VA: 0x1815D1740
	public void .ctor(PropertyDescriptor[] properties) { }

	// RVA: 0x15D17E0 Offset: 0x15CFDE0 VA: 0x1815D17E0
	public void .ctor(PropertyDescriptor[] properties, bool readOnly) { }

	// RVA: 0x15D1660 Offset: 0x15CFC60 VA: 0x1815D1660
	private void .ctor(PropertyDescriptor[] properties, int propCount, string[] namedSort, IComparer comparer) { }

	// RVA: 0x4BE590 Offset: 0x4BCB90 VA: 0x1804BE590
	public int get_Count() { }

	// RVA: 0x15D18B0 Offset: 0x15CFEB0 VA: 0x1815D18B0 Slot: 29
	public virtual PropertyDescriptor get_Item(int index) { }

	// RVA: 0x15D1890 Offset: 0x15CFE90 VA: 0x1815D1890 Slot: 30
	public virtual PropertyDescriptor get_Item(string name) { }

	// RVA: 0x15CF3D0 Offset: 0x15CD9D0 VA: 0x1815CF3D0
	public int Add(PropertyDescriptor value) { }

	// RVA: 0x15CF4D0 Offset: 0x15CDAD0 VA: 0x1815CF4D0
	public void Clear() { }

	// RVA: 0x15CF540 Offset: 0x15CDB40 VA: 0x1815CF540
	public bool Contains(PropertyDescriptor value) { }

	// RVA: 0x15CF5A0 Offset: 0x15CDBA0 VA: 0x1815CF5A0 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x15CF5F0 Offset: 0x15CDBF0 VA: 0x1815CF5F0
	private void EnsurePropsOwned() { }

	// RVA: 0x15CF6A0 Offset: 0x15CDCA0 VA: 0x1815CF6A0
	private void EnsureSize(int sizeNeeded) { }

	// RVA: 0x15CF7C0 Offset: 0x15CDDC0 VA: 0x1815CF7C0 Slot: 31
	public virtual PropertyDescriptor Find(string name, bool ignoreCase) { }

	// RVA: 0x15CFCB0 Offset: 0x15CE2B0 VA: 0x1815CFCB0
	public int IndexOf(PropertyDescriptor value) { }

	// RVA: 0x15CFD10 Offset: 0x15CE310 VA: 0x1815CFD10
	public void Insert(int index, PropertyDescriptor value) { }

	// RVA: 0x15D03A0 Offset: 0x15CE9A0 VA: 0x1815D03A0
	public void Remove(PropertyDescriptor value) { }

	// RVA: 0x15D02C0 Offset: 0x15CE8C0 VA: 0x1815D02C0
	public void RemoveAt(int index) { }

	// RVA: 0x15D0460 Offset: 0x15CEA60 VA: 0x1815D0460 Slot: 32
	public virtual PropertyDescriptorCollection Sort(string[] names) { }

	// RVA: 0x15CFEB0 Offset: 0x15CE4B0 VA: 0x1815CFEB0
	protected void InternalSort(string[] names) { }

	// RVA: 0x15CFE30 Offset: 0x15CE430 VA: 0x1815CFE30
	protected void InternalSort(IComparer sorter) { }

	// RVA: 0x15CFC00 Offset: 0x15CE200 VA: 0x1815CFC00 Slot: 33
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x4BE590 Offset: 0x4BCB90 VA: 0x1804BE590 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x15D0570 Offset: 0x15CEB70 VA: 0x1815D0570 Slot: 24
	private void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0x15CF4D0 Offset: 0x15CDAD0 VA: 0x1815CF4D0 Slot: 25
	private void System.Collections.IDictionary.Clear() { }

	// RVA: 0x15D0620 Offset: 0x15CEC20 VA: 0x1815D0620 Slot: 23
	private bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0x15D06C0 Offset: 0x15CECC0 VA: 0x1815D06C0 Slot: 27
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: 0xEE7D80 Offset: 0xEE6380 VA: 0x180EE7D80 Slot: 26
	private bool System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: 0x15D07D0 Offset: 0x15CEDD0 VA: 0x1815D07D0 Slot: 19
	private object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0x15D0A40 Offset: 0x15CF040 VA: 0x1815D0A40 Slot: 20
	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0x15D0860 Offset: 0x15CEE60 VA: 0x1815D0860 Slot: 21
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0x15D0980 Offset: 0x15CEF80 VA: 0x1815D0980 Slot: 22
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0x15D0730 Offset: 0x15CED30 VA: 0x1815D0730 Slot: 28
	private void System.Collections.IDictionary.Remove(object key) { }

	// RVA: 0x15D0E30 Offset: 0x15CF430 VA: 0x1815D0E30 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x15D0E50 Offset: 0x15CF450 VA: 0x1815D0E50 Slot: 10
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x15CF4D0 Offset: 0x15CDAD0 VA: 0x1815CF4D0 Slot: 12
	private void System.Collections.IList.Clear() { }

	// RVA: 0x15D0EE0 Offset: 0x15CF4E0 VA: 0x1815D0EE0 Slot: 11
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x15D0FB0 Offset: 0x15CF5B0 VA: 0x1815D0FB0 Slot: 15
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x15D1080 Offset: 0x15CF680 VA: 0x1815D1080 Slot: 16
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0xEE7D80 Offset: 0xEE6380 VA: 0x180EE7D80 Slot: 13
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0xEE7D80 Offset: 0xEE6380 VA: 0x180EE7D80 Slot: 14
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x15D1220 Offset: 0x15CF820 VA: 0x1815D1220 Slot: 17
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x15D1210 Offset: 0x15CF810 VA: 0x1815D1210 Slot: 18
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x15D1350 Offset: 0x15CF950 VA: 0x1815D1350 Slot: 8
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x15D1370 Offset: 0x15CF970 VA: 0x1815D1370 Slot: 9
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x15D15A0 Offset: 0x15CFBA0 VA: 0x1815D15A0
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

	// RVA: 0x11BA3C0 Offset: 0x11B89C0 VA: 0x1811BA3C0
	public void .ctor(PropertyDescriptorCollection owner) { }

	// RVA: 0x15D1990 Offset: 0x15CFF90 VA: 0x1815D1990 Slot: 8
	public object get_Current() { }

	// RVA: 0x15D1A30 Offset: 0x15D0030 VA: 0x1815D1A30 Slot: 6
	public DictionaryEntry get_Entry() { }

	// RVA: 0x15D1AA0 Offset: 0x15D00A0 VA: 0x1815D1AA0 Slot: 4
	public object get_Key() { }

	// RVA: 0x15D1AA0 Offset: 0x15D00A0 VA: 0x1815D1AA0 Slot: 5
	public object get_Value() { }

	// RVA: 0x15D1950 Offset: 0x15CFF50 VA: 0x1815D1950 Slot: 7
	public bool MoveNext() { }

	// RVA: 0x1180FF0 Offset: 0x117F5F0 VA: 0x181180FF0 Slot: 9
	public void Reset() { }

}

