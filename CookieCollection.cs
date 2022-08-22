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

	// RVA: 0x15209C0 Offset: 0x151EFC0 VA: 0x1815209C0
	public void .ctor() { }

	// RVA: 0x1520A90 Offset: 0x151F090 VA: 0x181520A90
	public Cookie get_Item(int index) { }

	// RVA: 0x1520180 Offset: 0x151E780 VA: 0x181520180
	public void Add(Cookie cookie) { }

	// RVA: 0x151FE80 Offset: 0x151E480 VA: 0x18151FE80
	public void Add(CookieCollection cookies) { }

	// RVA: 0x1520A60 Offset: 0x151F060 VA: 0x181520A60 Slot: 5
	public int get_Count() { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x1520250 Offset: 0x151E850 VA: 0x181520250 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x15208B0 Offset: 0x151EEB0 VA: 0x1815208B0
	internal DateTime TimeStamp(CookieCollection.Stamp how) { }

	// RVA: 0x997AE0 Offset: 0x9960E0 VA: 0x180997AE0
	internal bool get_IsOtherVersionSeen() { }

	// RVA: 0x1520550 Offset: 0x151EB50 VA: 0x181520550
	internal int InternalAdd(Cookie cookie, bool isStrict) { }

	// RVA: 0x1520320 Offset: 0x151E920 VA: 0x181520320
	internal int IndexOf(Cookie cookie) { }

	// RVA: 0x1520880 Offset: 0x151EE80 VA: 0x181520880
	internal void RemoveAt(int idx) { }

	// RVA: 0x1520280 Offset: 0x151E880 VA: 0x181520280 Slot: 7
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

	// RVA: 0x151FE10 Offset: 0x151E410 VA: 0x18151FE10
	internal void .ctor(CookieCollection cookies) { }

	// RVA: 0x151FD30 Offset: 0x151E330 VA: 0x18151FD30 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x151FC70 Offset: 0x151E270 VA: 0x18151FC70 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x151FD20 Offset: 0x151E320 VA: 0x18151FD20 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

}

