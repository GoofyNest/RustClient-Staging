public abstract class ReadOnlyCollectionBase : ICollection, IEnumerable // TypeDefIndex: 1416
{
// Namespace: System.Collections
[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
[Serializable]
public abstract class ReadOnlyCollectionBase : ICollection, IEnumerable // TypeDefIndex: 1416
	// Fields
	private ArrayList list; // 0x10

	// Properties
	protected ArrayList InnerList { get; }
	public virtual int Count { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: 0x1467C40 Offset: 0x1466240 VA: 0x181467C40
	protected ArrayList get_InnerList() { }

	// RVA: 0x1467BB0 Offset: 0x14661B0 VA: 0x181467BB0 Slot: 8
	public virtual int get_Count() { }

	// RVA: 0x1467B20 Offset: 0x1466120 VA: 0x181467B20 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1467A70 Offset: 0x1466070 VA: 0x181467A70 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x14679E0 Offset: 0x1465FE0 VA: 0x1814679E0 Slot: 9
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

