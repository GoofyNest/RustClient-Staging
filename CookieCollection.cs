public class CookieCollection : ICollection, IEnumerable // TypeDefIndex: 2940
{	// Fields
	internal int m_version; // 0x10
	private ArrayList m_list; // 0x18
	private DateTime m_TimeStamp; // 0x20
	private bool m_has_other_versions; // 0x28
	[OptionalFieldAttribute] // RVA: 0x7B620 Offset: 0x7AA20 VA: 0x18007B620
	private bool m_IsReadOnly; // 0x29

	// Properties
	public Cookie Item { get; }
	public int Count { get; }
	public object SyncRoot { get; }
	internal bool IsOtherVersionSeen { get; }

	// Methods

	// RVA: 0x1521630 Offset: 0x151FC30 VA: 0x181521630
	public void .ctor() { }

	// RVA: 0x1521700 Offset: 0x151FD00 VA: 0x181521700
	public Cookie get_Item(int index) { }

	// RVA: 0x1520DF0 Offset: 0x151F3F0 VA: 0x181520DF0
	public void Add(Cookie cookie) { }

	// RVA: 0x1520AF0 Offset: 0x151F0F0 VA: 0x181520AF0
	public void Add(CookieCollection cookies) { }

	// RVA: 0x15216D0 Offset: 0x151FCD0 VA: 0x1815216D0 Slot: 5
	public int get_Count() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x1520EC0 Offset: 0x151F4C0 VA: 0x181520EC0 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1521520 Offset: 0x151FB20 VA: 0x181521520
	internal DateTime TimeStamp(CookieCollection.Stamp how) { }

	// RVA: 0x9974E0 Offset: 0x995AE0 VA: 0x1809974E0
	internal bool get_IsOtherVersionSeen() { }

	// RVA: 0x15211C0 Offset: 0x151F7C0 VA: 0x1815211C0
	internal int InternalAdd(Cookie cookie, bool isStrict) { }

	// RVA: 0x1520F90 Offset: 0x151F590 VA: 0x181520F90
	internal int IndexOf(Cookie cookie) { }

	// RVA: 0x15214F0 Offset: 0x151FAF0 VA: 0x1815214F0
	internal void RemoveAt(int idx) { }

	// RVA: 0x1520EF0 Offset: 0x151F4F0 VA: 0x181520EF0 Slot: 7
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

	// RVA: 0x1520A80 Offset: 0x151F080 VA: 0x181520A80
	internal void .ctor(CookieCollection cookies) { }

	// RVA: 0x15209A0 Offset: 0x151EFA0 VA: 0x1815209A0 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x15208E0 Offset: 0x151EEE0 VA: 0x1815208E0 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x1520990 Offset: 0x151EF90 VA: 0x181520990 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

}

