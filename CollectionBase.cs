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

	// RVA: 0x14516D0 Offset: 0x144FCD0 VA: 0x1814516D0
	protected void .ctor() { }

	// RVA: 0x1451760 Offset: 0x144FD60 VA: 0x181451760
	protected ArrayList get_InnerList() { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80
	protected IList get_List() { }

	// RVA: 0x1451740 Offset: 0x144FD40 VA: 0x181451740 Slot: 16
	public int get_Count() { }

	// RVA: 0x1450840 Offset: 0x144EE40 VA: 0x181450840 Slot: 8
	public void Clear() { }

	// RVA: 0x14509F0 Offset: 0x144EFF0 VA: 0x1814509F0 Slot: 14
	public void RemoveAt(int index) { }

	// RVA: 0x14513A0 Offset: 0x144F9A0 VA: 0x1814513A0 Slot: 9
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x1451310 Offset: 0x144F910 VA: 0x181451310 Slot: 10
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x1450C50 Offset: 0x144F250 VA: 0x181450C50 Slot: 17
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1450BA0 Offset: 0x144F1A0 VA: 0x181450BA0 Slot: 15
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1451430 Offset: 0x144FA30 VA: 0x181451430 Slot: 4
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x1451500 Offset: 0x144FB00 VA: 0x181451500 Slot: 5
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x1450E90 Offset: 0x144F490 VA: 0x181450E90 Slot: 7
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x1450CE0 Offset: 0x144F2E0 VA: 0x181450CE0 Slot: 6
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x1451150 Offset: 0x144F750 VA: 0x181451150 Slot: 13
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x1450F30 Offset: 0x144F530 VA: 0x181450F30 Slot: 11
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x1450FD0 Offset: 0x144F5D0 VA: 0x181450FD0 Slot: 12
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x1450900 Offset: 0x144EF00 VA: 0x181450900 Slot: 18
	public IEnumerator GetEnumerator() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 19
	protected virtual void OnSet(int index, object oldValue, object newValue) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 20
	protected virtual void OnInsert(int index, object value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 21
	protected virtual void OnClear() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 22
	protected virtual void OnRemove(int index, object value) { }

	// RVA: 0x1450990 Offset: 0x144EF90 VA: 0x181450990 Slot: 23
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

