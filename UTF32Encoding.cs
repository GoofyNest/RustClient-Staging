public sealed class UTF32Encoding : Encoding // TypeDefIndex: 467
{	// Fields
	private bool emitUTF32ByteOrderMark; // 0x38
	private bool isThrowException; // 0x39
	private bool bigEndian; // 0x3A

	// Methods

	// RVA: 0x1927220 Offset: 0x1925820 VA: 0x181927220
	public void .ctor() { }

	// RVA: 0x1927150 Offset: 0x1925750 VA: 0x181927150
	public void .ctor(bool bigEndian, bool byteOrderMark) { }

	// RVA: 0x19271A0 Offset: 0x19257A0 VA: 0x1819271A0
	public void .ctor(bool bigEndian, bool byteOrderMark, bool throwOnInvalidCharacters) { }

	// RVA: 0x1927080 Offset: 0x1925680 VA: 0x181927080 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x19247F0 Offset: 0x1922DF0 VA: 0x1819247F0 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x1924E20 Offset: 0x1923420 VA: 0x181924E20 Slot: 18
	public override int GetByteCount(string s) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1924980 Offset: 0x1922F80 VA: 0x181924980 Slot: 20
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x19257A0 Offset: 0x1923DA0 VA: 0x1819257A0 Slot: 26
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1925540 Offset: 0x1923B40 VA: 0x181925540 Slot: 24
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1924EC0 Offset: 0x19234C0 VA: 0x181924EC0 Slot: 28
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x1925B00 Offset: 0x1924100 VA: 0x181925B00 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1925A00 Offset: 0x1924000 VA: 0x181925A00 Slot: 30
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1926640 Offset: 0x1924C40 VA: 0x181926640 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x19268A0 Offset: 0x1924EA0 VA: 0x1819268A0 Slot: 34
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x1926ED0 Offset: 0x19254D0 VA: 0x181926ED0 Slot: 43
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1924A80 Offset: 0x1923080 VA: 0x181924A80 Slot: 21
	internal override int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x1925000 Offset: 0x1923600 VA: 0x181925000 Slot: 27
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x1925C90 Offset: 0x1924290 VA: 0x181925C90 Slot: 31
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x1926080 Offset: 0x1924680 VA: 0x181926080 Slot: 35
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x1927060 Offset: 0x1925660 VA: 0x181927060
	private uint GetSurrogate(char cHigh, char cLow) { }

	// RVA: 0x1926B80 Offset: 0x1925180 VA: 0x181926B80
	private char GetHighSurrogate(uint iChar) { }

	// RVA: 0x1926BA0 Offset: 0x19251A0 VA: 0x181926BA0
	private char GetLowSurrogate(uint iChar) { }

	// RVA: 0x19269E0 Offset: 0x1924FE0 VA: 0x1819269E0 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x1926A40 Offset: 0x1925040 VA: 0x181926A40 Slot: 39
	public override Encoder GetEncoder() { }

	// RVA: 0x1926BC0 Offset: 0x19251C0 VA: 0x181926BC0 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x1926CF0 Offset: 0x19252F0 VA: 0x181926CF0 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x1926DC0 Offset: 0x19253C0 VA: 0x181926DC0 Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x1924720 Offset: 0x1922D20 VA: 0x181924720 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1926AE0 Offset: 0x19250E0 VA: 0x181926AE0 Slot: 2
	public override int GetHashCode() { }

}

internal class UTF32Encoding.UTF32Decoder : DecoderNLS // TypeDefIndex: 468
{	// Fields
	internal int iChar; // 0x30
	internal int readByteCount; // 0x34

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x14A4BE0 Offset: 0x14A31E0 VA: 0x1814A4BE0
	public void .ctor(UTF32Encoding encoding) { }

	// RVA: 0x19246F0 Offset: 0x1922CF0 VA: 0x1819246F0 Slot: 4
	public override void Reset() { }

	// RVA: 0x178C6A0 Offset: 0x178ACA0 VA: 0x18178C6A0 Slot: 14
	internal override bool get_HasState() { }

}

