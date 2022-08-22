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

	// RVA: 0x22A5730 Offset: 0x22A3D30 VA: 0x1822A5730
	protected void .ctor(int codePage, char[] toChars, string encodingName, string bodyName, string headerName, string webName, bool isBrowserDisplay, bool isBrowserSave, bool isMailNewsDisplay, bool isMailNewsSave, int windowsCodePage) { }

	// RVA: 0x22A51F0 Offset: 0x22A37F0 VA: 0x1822A51F0 Slot: 37
	public override bool IsAlwaysNormalized(NormalizationForm form) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 16
	public override bool get_IsSingleByte() { }

	// RVA: 0x22A4A00 Offset: 0x22A3000 VA: 0x1822A4A00 Slot: 18
	public override int GetByteCount(string s) { }

	// RVA: 0x191CD40 Offset: 0x191B340 VA: 0x18191CD40 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: -1 Offset: -1 Slot: 48
	protected abstract void ToBytes(char* chars, int charCount, byte* bytes, int byteCount);

	// RVA: 0x22A5680 Offset: 0x22A3C80 VA: 0x1822A5680 Slot: 49
	protected virtual void ToBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x22A4A70 Offset: 0x22A3070 VA: 0x1822A4A70 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x22A4AA0 Offset: 0x22A30A0 VA: 0x1822A4AA0 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x22A4BD0 Offset: 0x22A31D0 VA: 0x1822A4BD0 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x22A4E90 Offset: 0x22A3490 VA: 0x1822A4E90 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x22A4F10 Offset: 0x22A3510 VA: 0x1822A4F10 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x22A5020 Offset: 0x22A3620 VA: 0x1822A5020 Slot: 43
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x22A4F90 Offset: 0x22A3590 VA: 0x1822A4F90 Slot: 42
	public override string GetString(byte[] bytes) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x82CA00 Offset: 0x82B000 VA: 0x18082CA00 Slot: 12
	public override bool get_IsBrowserDisplay() { }

	// RVA: 0x22A5860 Offset: 0x22A3E60 VA: 0x1822A5860 Slot: 13
	public override bool get_IsBrowserSave() { }

	// RVA: 0xBA1AB0 Offset: 0xBA00B0 VA: 0x180BA1AB0 Slot: 14
	public override bool get_IsMailNewsDisplay() { }

	// RVA: 0xE6B440 Offset: 0xE69A40 VA: 0x180E6B440 Slot: 15
	public override bool get_IsMailNewsSave() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320 Slot: 10
	public override string get_WebName() { }

	// RVA: 0x803A60 Offset: 0x802060 VA: 0x180803A60 Slot: 11
	public override int get_WindowsCodePage() { }

}

