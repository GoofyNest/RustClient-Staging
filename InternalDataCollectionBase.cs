public class InternalDataCollectionBase : ICollection, IEnumerable // TypeDefIndex: 4167
{	// Fields
	internal static readonly CollectionChangeEventArgs s_refreshEventArgs; // 0x2B11350

	// Properties
	[BrowsableAttribute] // RVA: 0x9A8A0 Offset: 0x99CA0 VA: 0x18009A8A0
	public virtual int Count { get; }
	[BrowsableAttribute] // RVA: 0x9A8A0 Offset: 0x99CA0 VA: 0x18009A8A0
	public object SyncRoot { get; }
	protected virtual ArrayList List { get; }

	// Methods

	// RVA: 0xE8C370 Offset: 0xE8A970 VA: 0x180E8C370 Slot: 8
	public virtual int get_Count() { }

	// RVA: 0xE8C190 Offset: 0xE8A790 VA: 0x180E8C190 Slot: 9
	public virtual void CopyTo(Array ar, int index) { }

	// RVA: 0xE8C1E0 Offset: 0xE8A7E0 VA: 0x180E8C1E0 Slot: 10
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0xE8C220 Offset: 0xE8A820 VA: 0x180E8C220
	internal int NamesEqual(string s1, string s2, bool fCaseSensitive, CultureInfo locale) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 11
	protected virtual ArrayList get_List() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xE8C310 Offset: 0xE8A910 VA: 0x180E8C310
	private static void .cctor() { }

}

