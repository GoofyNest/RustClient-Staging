public class InternalDataCollectionBase : ICollection, IEnumerable // TypeDefIndex: 4167
{	// Fields
	internal static readonly CollectionChangeEventArgs s_refreshEventArgs; // 0x13332

	// Properties
	[BrowsableAttribute] // RVA: 0x9A900 Offset: 0x99D00 VA: 0x18009A900
	public virtual int Count { get; }
	[BrowsableAttribute] // RVA: 0x9A900 Offset: 0x99D00 VA: 0x18009A900
	public object SyncRoot { get; }
	protected virtual ArrayList List { get; }

	// Methods

	// RVA: 0xE8D0E0 Offset: 0xE8B6E0 VA: 0x180E8D0E0 Slot: 8
	public virtual int get_Count() { }

	// RVA: 0xE8CF00 Offset: 0xE8B500 VA: 0x180E8CF00 Slot: 9
	public virtual void CopyTo(Array ar, int index) { }

	// RVA: 0xE8CF50 Offset: 0xE8B550 VA: 0x180E8CF50 Slot: 10
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0xE8CF90 Offset: 0xE8B590 VA: 0x180E8CF90
	internal int NamesEqual(string s1, string s2, bool fCaseSensitive, CultureInfo locale) { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 11
	protected virtual ArrayList get_List() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xE8D080 Offset: 0xE8B680 VA: 0x180E8D080
	private static void .cctor() { }

}

