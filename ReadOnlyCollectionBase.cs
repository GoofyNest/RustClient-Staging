public abstract class ReadOnlyCollectionBase : ICollection, IEnumerable // TypeDefIndex: 1416
{
// Namespace: System.Collections
[ComVisibleAttribute] // RVA: 0x75F80 Offset: 0x75380 VA: 0x180075F80
[Serializable]
public abstract class ReadOnlyCollectionBase : ICollection, IEnumerable // TypeDefIndex: 1416
	// Fields
	private ArrayList list; // 0x10

	// Properties
	protected ArrayList InnerList { get; }
	public virtual int Count { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: 0x14688B0 Offset: 0x1466EB0 VA: 0x1814688B0
	protected ArrayList get_InnerList() { }

	// RVA: 0x1468820 Offset: 0x1466E20 VA: 0x181468820 Slot: 8
	public virtual int get_Count() { }

	// RVA: 0x1468790 Offset: 0x1466D90 VA: 0x181468790 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x14686E0 Offset: 0x1466CE0 VA: 0x1814686E0 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1468650 Offset: 0x1466C50 VA: 0x181468650 Slot: 9
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

