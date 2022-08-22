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

	// RVA: 0x17C6B00 Offset: 0x17C5100 VA: 0x1817C6B00
	internal void BasicInitialization() { }

	// RVA: 0x17C7850 Offset: 0x17C5E50 VA: 0x1817C7850
	public void Recycle() { }

	// RVA: 0x17C78B0 Offset: 0x17C5EB0 VA: 0x1817C78B0
	internal void .ctor(string input) { }

	// RVA: 0x17C6B80 Offset: 0x17C5180 VA: 0x1817C6B80
	internal void ChangeFormat(Encoding encoding) { }

	// RVA: 0x17C6E10 Offset: 0x17C5410 VA: 0x1817C6E10
	internal void GetTokens(TokenizerStream stream, int maxNum, bool endAfterKet) { }

	// RVA: 0x17C6DF0 Offset: 0x17C53F0 VA: 0x1817C6DF0
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

	// RVA: 0x18B0A90 Offset: 0x18AF090 VA: 0x1818B0A90
	private static uint HashString(string str) { }

	// RVA: 0x18B0A30 Offset: 0x18AF030 VA: 0x1818B0A30
	private static uint HashCharArray(char[] a, int l) { }

	// RVA: 0x18B0FA0 Offset: 0x18AF5A0 VA: 0x1818B0FA0
	public void .ctor() { }

	// RVA: 0x18B0930 Offset: 0x18AEF30 VA: 0x1818B0930
	private bool CompareStringAndChars(string str, char[] a, int l) { }

	// RVA: 0x18B0B60 Offset: 0x18AF160 VA: 0x1818B0B60
	public string MakeString() { }

}

internal class Tokenizer.StreamTokenReader : Tokenizer.ITokenReader // TypeDefIndex: 924
{	// Fields
	internal StreamReader _in; // 0x10
	internal int _numCharRead; // 0x18

	// Properties
	internal int NumCharEncountered { get; }

	// Methods

	// RVA: 0x18B0210 Offset: 0x18AE810 VA: 0x1818B0210
	internal void .ctor(StreamReader input) { }

	// RVA: 0x18B01D0 Offset: 0x18AE7D0 VA: 0x1818B01D0 Slot: 5
	public virtual int Read() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	internal int get_NumCharEncountered() { }

}

