public class InternalDataCollectionBase : ICollection, IEnumerable // TypeDefIndex: 4167
{	// Fields
	internal static readonly CollectionChangeEventArgs s_refreshEventArgs; // 0x2B113B0

	// Properties
	[BrowsableAttribute] // RVA: 0x9A900 Offset: 0x99D00 VA: 0x18009A900
	public virtual int Count { get; }
	[BrowsableAttribute] // RVA: 0x9A900 Offset: 0x99D00 VA: 0x18009A900
	public object SyncRoot { get; }
	protected virtual ArrayList List { get; }

	// Methods

	// RVA: 0xE8C630 Offset: 0xE8AC30 VA: 0x180E8C630 Slot: 8
	public virtual int get_Count() { }

	// RVA: 0xE8C450 Offset: 0xE8AA50 VA: 0x180E8C450 Slot: 9
	public virtual void CopyTo(Array ar, int index) { }

	// RVA: 0xE8C4A0 Offset: 0xE8AAA0 VA: 0x180E8C4A0 Slot: 10
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0xE8C4E0 Offset: 0xE8AAE0 VA: 0x180E8C4E0
	internal int NamesEqual(string s1, string s2, bool fCaseSensitive, CultureInfo locale) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 11
	protected virtual ArrayList get_List() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xE8C5D0 Offset: 0xE8ABD0 VA: 0x180E8C5D0
	private static void .cctor() { }

}

