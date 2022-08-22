public abstract class ByteEncoding : MonoEncoding // TypeDefIndex: 7370
{	// Fields
	protected char[] toChars; // 0x40
	protected string encodingName; // 0x48
	protected string bodyName; // 0x50
	protected string headerName; // 0x58
	protected string webName; // 0x60
	protected bool isBrowserDisplay; // 0x68
	protected bool isBrowserSave; // 0x69
	protected bool isMailNewsDisplay; // 0x6A
	protected bool isMailNewsSave; // 0x6B
	protected int windowsCodePage; // 0x6C
	private static byte[] isNormalized; // 0x0
	private static byte[] isNormalizedComputed; // 0x8
	private static byte[] normalization_bytes; // 0x10

	// Properties
	public override bool IsSingleByte { get; }
	public override string BodyName { get; }
	public override string EncodingName { get; }
	public override string HeaderName { get; }
	public override bool IsBrowserDisplay { get; }
	public override bool IsBrowserSave { get; }
	public override bool IsMailNewsDisplay { get; }
	public override bool IsMailNewsSave { get; }
	public override string WebName { get; }
	public override int WindowsCodePage { get; }

	// Methods

	// RVA: 0x22A6210 Offset: 0x22A4810 VA: 0x1822A6210
	protected void .ctor(int codePage, char[] toChars, string encodingName, string bodyName, string headerName, string webName, bool isBrowserDisplay, bool isBrowserSave, bool isMailNewsDisplay, bool isMailNewsSave, int windowsCodePage) { }

	// RVA: 0x22A5CD0 Offset: 0x22A42D0 VA: 0x1822A5CD0 Slot: 37
	public override bool IsAlwaysNormalized(NormalizationForm form) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 16
	public override bool get_IsSingleByte() { }

	// RVA: 0x22A54E0 Offset: 0x22A3AE0 VA: 0x1822A54E0 Slot: 18
	public override int GetByteCount(string s) { }

	// RVA: 0x191C720 Offset: 0x191AD20 VA: 0x18191C720 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: -1 Offset: -1 Slot: 48
	protected abstract void ToBytes(char* chars, int charCount, byte* bytes, int byteCount);

	// RVA: 0x22A6160 Offset: 0x22A4760 VA: 0x1822A6160 Slot: 49
	protected virtual void ToBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x22A5550 Offset: 0x22A3B50 VA: 0x1822A5550 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x22A5580 Offset: 0x22A3B80 VA: 0x1822A5580 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x22A56B0 Offset: 0x22A3CB0 VA: 0x1822A56B0 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x22A5970 Offset: 0x22A3F70 VA: 0x1822A5970 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x22A59F0 Offset: 0x22A3FF0 VA: 0x1822A59F0 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x22A5B00 Offset: 0x22A4100 VA: 0x1822A5B00 Slot: 43
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x22A5A70 Offset: 0x22A4070 VA: 0x1822A5A70 Slot: 42
	public override string GetString(byte[] bytes) { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x82D060 Offset: 0x82B660 VA: 0x18082D060 Slot: 12
	public override bool get_IsBrowserDisplay() { }

	// RVA: 0x22A6340 Offset: 0x22A4940 VA: 0x1822A6340 Slot: 13
	public override bool get_IsBrowserSave() { }

	// RVA: 0xBA2240 Offset: 0xBA0840 VA: 0x180BA2240 Slot: 14
	public override bool get_IsMailNewsDisplay() { }

	// RVA: 0xE6C1B0 Offset: 0xE6A7B0 VA: 0x180E6C1B0 Slot: 15
	public override bool get_IsMailNewsSave() { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0 Slot: 10
	public override string get_WebName() { }

	// RVA: 0x804100 Offset: 0x802700 VA: 0x180804100 Slot: 11
	public override int get_WindowsCodePage() { }

}

