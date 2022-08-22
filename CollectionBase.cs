public abstract class CollectionBase : IList, ICollection, IEnumerable // TypeDefIndex: 1384
{	// Fields
	private ArrayList list; // 0x10

	// Properties
	protected ArrayList InnerList { get; }
	protected IList List { get; }
	public int Count { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x1452600 Offset: 0x1450C00 VA: 0x181452600
	protected void .ctor() { }

	// RVA: 0x1452690 Offset: 0x1450C90 VA: 0x181452690
	protected ArrayList get_InnerList() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0
	protected IList get_List() { }

	// RVA: 0x1452670 Offset: 0x1450C70 VA: 0x181452670 Slot: 16
	public int get_Count() { }

	// RVA: 0x1451770 Offset: 0x144FD70 VA: 0x181451770 Slot: 8
	public void Clear() { }

	// RVA: 0x1451920 Offset: 0x144FF20 VA: 0x181451920 Slot: 14
	public void RemoveAt(int index) { }

	// RVA: 0x14522D0 Offset: 0x14508D0 VA: 0x1814522D0 Slot: 9
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x1452240 Offset: 0x1450840 VA: 0x181452240 Slot: 10
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x1451B80 Offset: 0x1450180 VA: 0x181451B80 Slot: 17
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1451AD0 Offset: 0x14500D0 VA: 0x181451AD0 Slot: 15
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1452360 Offset: 0x1450960 VA: 0x181452360 Slot: 4
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x1452430 Offset: 0x1450A30 VA: 0x181452430 Slot: 5
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x1451DC0 Offset: 0x14503C0 VA: 0x181451DC0 Slot: 7
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x1451C10 Offset: 0x1450210 VA: 0x181451C10 Slot: 6
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x1452080 Offset: 0x1450680 VA: 0x181452080 Slot: 13
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x1451E60 Offset: 0x1450460 VA: 0x181451E60 Slot: 11
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x1451F00 Offset: 0x1450500 VA: 0x181451F00 Slot: 12
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x1451830 Offset: 0x144FE30 VA: 0x181451830 Slot: 18
	public IEnumerator GetEnumerator() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 19
	protected virtual void OnSet(int index, object oldValue, object newValue) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 20
	protected virtual void OnInsert(int index, object value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 21
	protected virtual void OnClear() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 22
	protected virtual void OnRemove(int index, object value) { }

	// RVA: 0x14518C0 Offset: 0x144FEC0 VA: 0x1814518C0 Slot: 23
	protected virtual void OnValidate(object value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 24
	protected virtual void OnSetComplete(int index, object oldValue, object newValue) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 25
	protected virtual void OnInsertComplete(int index, object value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 26
	protected virtual void OnClearComplete() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 27
	protected virtual void OnRemoveComplete(int index, object value) { }

}

