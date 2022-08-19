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

	// RVA: 0x14C0590 Offset: 0x14BEB90 VA: 0x1814C0590
	internal void .ctor(Regex regex, string input, int beginning, int length, int startat) { }

	// RVA: 0x14C03A0 Offset: 0x14BE9A0 VA: 0x1814C03A0
	internal Match GetMatch(int i) { }

	// RVA: 0x14C06F0 Offset: 0x14BECF0 VA: 0x1814C06F0 Slot: 5
	public int get_Count() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x14C01A0 Offset: 0x14BE7A0 VA: 0x1814C01A0 Slot: 4
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x14C0340 Offset: 0x14BE940 VA: 0x1814C0340 Slot: 7
	public IEnumerator GetEnumerator() { }

	// RVA: 0x14C0550 Offset: 0x14BEB50 VA: 0x1814C0550
	private static void .cctor() { }

	// RVA: 0x14C06C0 Offset: 0x14BECC0 VA: 0x1814C06C0
	internal void .ctor() { }

}

