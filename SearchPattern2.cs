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

	// RVA: 0x15365F0 Offset: 0x1534BF0 VA: 0x1815365F0
	public void .ctor(string pattern) { }

	// RVA: 0x1536640 Offset: 0x1534C40 VA: 0x181536640
	public void .ctor(string pattern, bool ignore) { }

	// RVA: 0xFA7F00 Offset: 0xFA6500 VA: 0x180FA7F00
	public bool get_HasWildcard() { }

	// RVA: 0x1536180 Offset: 0x1534780 VA: 0x181536180
	private void Compile(string pattern) { }

	// RVA: 0x1536490 Offset: 0x1534A90 VA: 0x181536490
	private static void .cctor() { }

}

private class SearchPattern2.Op // TypeDefIndex: 2856
{	// Fields
	public SearchPattern2.OpCode Code; // 0x10
	public string Argument; // 0x18
	public SearchPattern2.Op Next; // 0x20

	// Methods

	// RVA: 0x1535D20 Offset: 0x1534320 VA: 0x181535D20
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

