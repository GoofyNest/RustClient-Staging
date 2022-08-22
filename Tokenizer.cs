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

	// RVA: 0x17C4650 Offset: 0x17C2C50 VA: 0x1817C4650
	internal void BasicInitialization() { }

	// RVA: 0x17C53A0 Offset: 0x17C39A0 VA: 0x1817C53A0
	public void Recycle() { }

	// RVA: 0x17C5400 Offset: 0x17C3A00 VA: 0x1817C5400
	internal void .ctor(string input) { }

	// RVA: 0x17C46D0 Offset: 0x17C2CD0 VA: 0x1817C46D0
	internal void ChangeFormat(Encoding encoding) { }

	// RVA: 0x17C4960 Offset: 0x17C2F60 VA: 0x1817C4960
	internal void GetTokens(TokenizerStream stream, int maxNum, bool endAfterKet) { }

	// RVA: 0x17C4940 Offset: 0x17C2F40 VA: 0x1817C4940
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

	// RVA: 0x18B01B0 Offset: 0x18AE7B0 VA: 0x1818B01B0
	private static uint HashString(string str) { }

	// RVA: 0x18B0150 Offset: 0x18AE750 VA: 0x1818B0150
	private static uint HashCharArray(char[] a, int l) { }

	// RVA: 0x18B06C0 Offset: 0x18AECC0 VA: 0x1818B06C0
	public void .ctor() { }

	// RVA: 0x18B0050 Offset: 0x18AE650 VA: 0x1818B0050
	private bool CompareStringAndChars(string str, char[] a, int l) { }

	// RVA: 0x18B0280 Offset: 0x18AE880 VA: 0x1818B0280
	public string MakeString() { }

}

internal class Tokenizer.StreamTokenReader : Tokenizer.ITokenReader // TypeDefIndex: 924
{	// Fields
	internal StreamReader _in; // 0x10
	internal int _numCharRead; // 0x18

	// Properties
	internal int NumCharEncountered { get; }

	// Methods

	// RVA: 0x18AF930 Offset: 0x18ADF30 VA: 0x1818AF930
	internal void .ctor(StreamReader input) { }

	// RVA: 0x18AF8F0 Offset: 0x18ADEF0 VA: 0x1818AF8F0 Slot: 5
	public virtual int Read() { }

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	internal int get_NumCharEncountered() { }

}

