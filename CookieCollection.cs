public class CookieCollection : ICollection, IEnumerable // TypeDefIndex: 2940
{	// Fields
	internal int m_version; // 0x10
	private ArrayList m_list; // 0x18
	private DateTime m_TimeStamp; // 0x20
	private bool m_has_other_versions; // 0x28
	[OptionalFieldAttribute] // RVA: 0x7B570 Offset: 0x7A970 VA: 0x18007B570
	private bool m_IsReadOnly; // 0x29

	// Properties
	public Cookie Item { get; }
	public int Count { get; }
	public object SyncRoot { get; }
	internal bool IsOtherVersionSeen { get; }

	// Methods

	// RVA: 0x15218F0 Offset: 0x151FEF0 VA: 0x1815218F0
	public void .ctor() { }

	// RVA: 0x15219C0 Offset: 0x151FFC0 VA: 0x1815219C0
	public Cookie get_Item(int index) { }

	// RVA: 0x15210B0 Offset: 0x151F6B0 VA: 0x1815210B0
	public void Add(Cookie cookie) { }

	// RVA: 0x1520DB0 Offset: 0x151F3B0 VA: 0x181520DB0
	public void Add(CookieCollection cookies) { }

	// RVA: 0x1521990 Offset: 0x151FF90 VA: 0x181521990 Slot: 5
	public int get_Count() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x1521180 Offset: 0x151F780 VA: 0x181521180 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x15217E0 Offset: 0x151FDE0 VA: 0x1815217E0
	internal DateTime TimeStamp(CookieCollection.Stamp how) { }

	// RVA: 0x9975F0 Offset: 0x995BF0 VA: 0x1809975F0
	internal bool get_IsOtherVersionSeen() { }

	// RVA: 0x1521480 Offset: 0x151FA80 VA: 0x181521480
	internal int InternalAdd(Cookie cookie, bool isStrict) { }

	// RVA: 0x1521250 Offset: 0x151F850 VA: 0x181521250
	internal int IndexOf(Cookie cookie) { }

	// RVA: 0x15217B0 Offset: 0x151FDB0 VA: 0x1815217B0
	internal void RemoveAt(int idx) { }

	// RVA: 0x15211B0 Offset: 0x151F7B0 VA: 0x1815211B0 Slot: 7
	public IEnumerator GetEnumerator() { }

}

internal enum CookieCollection.Stamp // TypeDefIndex: 2941
{	// Fields
	public int value__; // 0x0
	public const CookieCollection.Stamp Check = 0;
	public const CookieCollection.Stamp Set = 1;
	public const CookieCollection.Stamp SetToUnused = 2;
	public const CookieCollection.Stamp SetToMaxUsed = 3;

}

private class CookieCollection.CookieCollectionEnumerator : IEnumerator // TypeDefIndex: 2942
{	// Fields
	private CookieCollection m_cookies; // 0x10
	private int m_count; // 0x18
	private int m_index; // 0x1C
	private int m_version; // 0x20

	// Properties
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x1520D40 Offset: 0x151F340 VA: 0x181520D40
	internal void .ctor(CookieCollection cookies) { }

	// RVA: 0x1520C60 Offset: 0x151F260 VA: 0x181520C60 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1520BA0 Offset: 0x151F1A0 VA: 0x181520BA0 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x1520C50 Offset: 0x151F250 VA: 0x181520C50 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

}

