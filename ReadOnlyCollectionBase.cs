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

	// RVA: 0x1468B70 Offset: 0x1467170 VA: 0x181468B70
	protected ArrayList get_InnerList() { }

	// RVA: 0x1468AE0 Offset: 0x14670E0 VA: 0x181468AE0 Slot: 8
	public virtual int get_Count() { }

	// RVA: 0x1468A50 Offset: 0x1467050 VA: 0x181468A50 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x14689A0 Offset: 0x1466FA0 VA: 0x1814689A0 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1468910 Offset: 0x1466F10 VA: 0x181468910 Slot: 9
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

