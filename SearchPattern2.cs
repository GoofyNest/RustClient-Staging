internal class SearchPattern2 // TypeDefIndex: 2855
{	// Fields
	private SearchPattern2.Op ops; // 0x10
	private bool ignore; // 0x18
	private bool hasWildcard; // 0x19
	private string pattern; // 0x20
	internal static readonly char[] WildcardChars; // 0x0
	internal static readonly char[] InvalidChars; // 0x8

	// Properties
	public bool HasWildcard { get; }

	// Methods

	// RVA: 0x1537520 Offset: 0x1535B20 VA: 0x181537520
	public void .ctor(string pattern) { }

	// RVA: 0x1537570 Offset: 0x1535B70 VA: 0x181537570
	public void .ctor(string pattern, bool ignore) { }

	// RVA: 0xFA7460 Offset: 0xFA5A60 VA: 0x180FA7460
	public bool get_HasWildcard() { }

	// RVA: 0x15370B0 Offset: 0x15356B0 VA: 0x1815370B0
	private void Compile(string pattern) { }

	// RVA: 0x15373C0 Offset: 0x15359C0 VA: 0x1815373C0
	private static void .cctor() { }

}

private class SearchPattern2.Op // TypeDefIndex: 2856
{	// Fields
	public SearchPattern2.OpCode Code; // 0x10
	public string Argument; // 0x18
	public SearchPattern2.Op Next; // 0x20

	// Methods

	// RVA: 0x1536C50 Offset: 0x1535250 VA: 0x181536C50
	public void .ctor(SearchPattern2.OpCode code) { }

}

private enum SearchPattern2.OpCode // TypeDefIndex: 2857
{	// Fields
	public int value__; // 0x0
	public const SearchPattern2.OpCode ExactString = 0;
	public const SearchPattern2.OpCode AnyChar = 1;
	public const SearchPattern2.OpCode AnyString = 2;
	public const SearchPattern2.OpCode End = 3;
	public const SearchPattern2.OpCode True = 4;

}

