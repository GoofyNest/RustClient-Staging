public class InternalDataCollectionBase : ICollection, IEnumerable // TypeDefIndex: 4167
{	internal static readonly CollectionChangeEventArgs s_refreshEventArgs; // 0x2B11ADC

	[BrowsableAttribute] // RVA: 0x9AA30 Offset: 0x99E30 VA: 0x18009AA30
	public virtual int Count { get; }
	[BrowsableAttribute] // RVA: 0x9AA30 Offset: 0x99E30 VA: 0x18009AA30
	public object SyncRoot { get; }
	protected virtual ArrayList List { get; }


	public virtual int get_Count() { }

	public virtual void CopyTo(Array ar, int index) { }

	public virtual IEnumerator GetEnumerator() { }

	internal int NamesEqual(string s1, string s2, bool fCaseSensitive, CultureInfo locale) { }

	public object get_SyncRoot() { }

	protected virtual ArrayList get_List() { }

	public void .ctor() { }

	private static void .cctor() { }

}

