public class MatchCollection : ICollection, IEnumerable // TypeDefIndex: 2622
{	// Fields
	internal Regex _regex; // 0x10
	internal ArrayList _matches; // 0x18
	internal bool _done; // 0x20
	internal string _input; // 0x28
	internal int _beginning; // 0x30
	internal int _length; // 0x34
	internal int _startat; // 0x38
	internal int _prevlen; // 0x3C
	private static int infinite; // 0x0

	// Properties
	public int Count { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x14C0850 Offset: 0x14BEE50 VA: 0x1814C0850
	internal void .ctor(Regex regex, string input, int beginning, int length, int startat) { }

	// RVA: 0x14C0660 Offset: 0x14BEC60 VA: 0x1814C0660
	internal Match GetMatch(int i) { }

	// RVA: 0x14C09B0 Offset: 0x14BEFB0 VA: 0x1814C09B0 Slot: 5
	public int get_Count() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x14C0460 Offset: 0x14BEA60 VA: 0x1814C0460 Slot: 4
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x14C0600 Offset: 0x14BEC00 VA: 0x1814C0600 Slot: 7
	public IEnumerator GetEnumerator() { }

	// RVA: 0x14C0810 Offset: 0x14BEE10 VA: 0x1814C0810
	private static void .cctor() { }

	// RVA: 0x14C0980 Offset: 0x14BEF80 VA: 0x1814C0980
	internal void .ctor() { }

}

