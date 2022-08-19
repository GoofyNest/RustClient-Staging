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

	// RVA: 0x1537260 Offset: 0x1535860 VA: 0x181537260
	public void .ctor(string pattern) { }

	// RVA: 0x15372B0 Offset: 0x15358B0 VA: 0x1815372B0
	public void .ctor(string pattern, bool ignore) { }

	// RVA: 0xFA71A0 Offset: 0xFA57A0 VA: 0x180FA71A0
	public bool get_HasWildcard() { }

	// RVA: 0x1536DF0 Offset: 0x15353F0 VA: 0x181536DF0
	private void Compile(string pattern) { }

	// RVA: 0x1537100 Offset: 0x1535700 VA: 0x181537100
	private static void .cctor() { }

}

private class SearchPattern2.Op // TypeDefIndex: 2856
{	// Fields
	public SearchPattern2.OpCode Code; // 0x10
	public string Argument; // 0x18
	public SearchPattern2.Op Next; // 0x20

	// Methods

	// RVA: 0x1536990 Offset: 0x1534F90 VA: 0x181536990
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

