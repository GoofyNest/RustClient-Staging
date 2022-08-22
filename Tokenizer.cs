internal sealed class Tokenizer // TypeDefIndex: 920
{	// Fields
	public int LineNo; // 0x10
	private int _inProcessingTag; // 0x14
	private byte[] _inBytes; // 0x18
	private char[] _inChars; // 0x20
	private string _inString; // 0x28
	private int _inIndex; // 0x30
	private int _inSize; // 0x34
	private int _inSavedCharacter; // 0x38
	private Tokenizer.TokenSource _inTokenSource; // 0x3C
	private Tokenizer.ITokenReader _inTokenReader; // 0x40
	private Tokenizer.StringMaker _maker; // 0x48
	private string[] _searchStrings; // 0x50
	private string[] _replaceStrings; // 0x58
	private int _inNestedIndex; // 0x60
	private int _inNestedSize; // 0x64
	private string _inNestedString; // 0x68

	// Methods

	// RVA: 0x17C6840 Offset: 0x17C4E40 VA: 0x1817C6840
	internal void BasicInitialization() { }

	// RVA: 0x17C7590 Offset: 0x17C5B90 VA: 0x1817C7590
	public void Recycle() { }

	// RVA: 0x17C75F0 Offset: 0x17C5BF0 VA: 0x1817C75F0
	internal void .ctor(string input) { }

	// RVA: 0x17C68C0 Offset: 0x17C4EC0 VA: 0x1817C68C0
	internal void ChangeFormat(Encoding encoding) { }

	// RVA: 0x17C6B50 Offset: 0x17C5150 VA: 0x1817C6B50
	internal void GetTokens(TokenizerStream stream, int maxNum, bool endAfterKet) { }

	// RVA: 0x17C6B30 Offset: 0x17C5130 VA: 0x1817C6B30
	private string GetStringToken() { }

}

private enum Tokenizer.TokenSource // TypeDefIndex: 921
{	// Fields
	public int value__; // 0x0
	public const Tokenizer.TokenSource UnicodeByteArray = 0;
	public const Tokenizer.TokenSource UTF8ByteArray = 1;
	public const Tokenizer.TokenSource ASCIIByteArray = 2;
	public const Tokenizer.TokenSource CharArray = 3;
	public const Tokenizer.TokenSource String = 4;
	public const Tokenizer.TokenSource NestedStrings = 5;
	public const Tokenizer.TokenSource Other = 6;

}

internal sealed class Tokenizer.StringMaker // TypeDefIndex: 922
{	// Fields
	private string[] aStrings; // 0x10
	private uint cStringsMax; // 0x18
	private uint cStringsUsed; // 0x1C
	public StringBuilder _outStringBuilder; // 0x20
	public char[] _outChars; // 0x28
	public int _outIndex; // 0x30

	// Methods

	// RVA: 0x18B07D0 Offset: 0x18AEDD0 VA: 0x1818B07D0
	private static uint HashString(string str) { }

	// RVA: 0x18B0770 Offset: 0x18AED70 VA: 0x1818B0770
	private static uint HashCharArray(char[] a, int l) { }

	// RVA: 0x18B0CE0 Offset: 0x18AF2E0 VA: 0x1818B0CE0
	public void .ctor() { }

	// RVA: 0x18B0670 Offset: 0x18AEC70 VA: 0x1818B0670
	private bool CompareStringAndChars(string str, char[] a, int l) { }

	// RVA: 0x18B08A0 Offset: 0x18AEEA0 VA: 0x1818B08A0
	public string MakeString() { }

}

internal class Tokenizer.StreamTokenReader : Tokenizer.ITokenReader // TypeDefIndex: 924
{	// Fields
	internal StreamReader _in; // 0x10
	internal int _numCharRead; // 0x18

	// Properties
	internal int NumCharEncountered { get; }

	// Methods

	// RVA: 0x18AFF50 Offset: 0x18AE550 VA: 0x1818AFF50
	internal void .ctor(StreamReader input) { }

	// RVA: 0x18AFF10 Offset: 0x18AE510 VA: 0x1818AFF10 Slot: 5
	public virtual int Read() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	internal int get_NumCharEncountered() { }

}

