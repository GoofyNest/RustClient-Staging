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

	// RVA: 0x1452340 Offset: 0x1450940 VA: 0x181452340
	protected void .ctor() { }

	// RVA: 0x14523D0 Offset: 0x14509D0 VA: 0x1814523D0
	protected ArrayList get_InnerList() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0
	protected IList get_List() { }

	// RVA: 0x14523B0 Offset: 0x14509B0 VA: 0x1814523B0 Slot: 16
	public int get_Count() { }

	// RVA: 0x14514B0 Offset: 0x144FAB0 VA: 0x1814514B0 Slot: 8
	public void Clear() { }

	// RVA: 0x1451660 Offset: 0x144FC60 VA: 0x181451660 Slot: 14
	public void RemoveAt(int index) { }

	// RVA: 0x1452010 Offset: 0x1450610 VA: 0x181452010 Slot: 9
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x1451F80 Offset: 0x1450580 VA: 0x181451F80 Slot: 10
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x14518C0 Offset: 0x144FEC0 VA: 0x1814518C0 Slot: 17
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1451810 Offset: 0x144FE10 VA: 0x181451810 Slot: 15
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x14520A0 Offset: 0x14506A0 VA: 0x1814520A0 Slot: 4
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x1452170 Offset: 0x1450770 VA: 0x181452170 Slot: 5
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x1451B00 Offset: 0x1450100 VA: 0x181451B00 Slot: 7
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x1451950 Offset: 0x144FF50 VA: 0x181451950 Slot: 6
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x1451DC0 Offset: 0x14503C0 VA: 0x181451DC0 Slot: 13
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x1451BA0 Offset: 0x14501A0 VA: 0x181451BA0 Slot: 11
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x1451C40 Offset: 0x1450240 VA: 0x181451C40 Slot: 12
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x1451570 Offset: 0x144FB70 VA: 0x181451570 Slot: 18
	public IEnumerator GetEnumerator() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 19
	protected virtual void OnSet(int index, object oldValue, object newValue) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 20
	protected virtual void OnInsert(int index, object value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 21
	protected virtual void OnClear() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 22
	protected virtual void OnRemove(int index, object value) { }

	// RVA: 0x1451600 Offset: 0x144FC00 VA: 0x181451600 Slot: 23
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

