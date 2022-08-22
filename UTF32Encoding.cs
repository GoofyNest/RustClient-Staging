public sealed class UTF32Encoding : Encoding // TypeDefIndex: 467
{	// Fields
	private bool emitUTF32ByteOrderMark; // 0x38
	private bool isThrowException; // 0x39
	private bool bigEndian; // 0x3A

	// Methods

	// RVA: 0x1926C00 Offset: 0x1925200 VA: 0x181926C00
	public void .ctor() { }

	// RVA: 0x1926B30 Offset: 0x1925130 VA: 0x181926B30
	public void .ctor(bool bigEndian, bool byteOrderMark) { }

	// RVA: 0x1926B80 Offset: 0x1925180 VA: 0x181926B80
	public void .ctor(bool bigEndian, bool byteOrderMark, bool throwOnInvalidCharacters) { }

	// RVA: 0x1926A60 Offset: 0x1925060 VA: 0x181926A60 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x19241D0 Offset: 0x19227D0 VA: 0x1819241D0 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x1924800 Offset: 0x1922E00 VA: 0x181924800 Slot: 18
	public override int GetByteCount(string s) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1924360 Offset: 0x1922960 VA: 0x181924360 Slot: 20
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x1925180 Offset: 0x1923780 VA: 0x181925180 Slot: 26
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1924F20 Offset: 0x1923520 VA: 0x181924F20 Slot: 24
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x19248A0 Offset: 0x1922EA0 VA: 0x1819248A0 Slot: 28
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x19254E0 Offset: 0x1923AE0 VA: 0x1819254E0 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x19253E0 Offset: 0x19239E0 VA: 0x1819253E0 Slot: 30
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1926020 Offset: 0x1924620 VA: 0x181926020 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1926280 Offset: 0x1924880 VA: 0x181926280 Slot: 34
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x19268B0 Offset: 0x1924EB0 VA: 0x1819268B0 Slot: 43
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1924460 Offset: 0x1922A60 VA: 0x181924460 Slot: 21
	internal override int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x19249E0 Offset: 0x1922FE0 VA: 0x1819249E0 Slot: 27
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x1925670 Offset: 0x1923C70 VA: 0x181925670 Slot: 31
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x1925A60 Offset: 0x1924060 VA: 0x181925A60 Slot: 35
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x1926A40 Offset: 0x1925040 VA: 0x181926A40
	private uint GetSurrogate(char cHigh, char cLow) { }

	// RVA: 0x1926560 Offset: 0x1924B60 VA: 0x181926560
	private char GetHighSurrogate(uint iChar) { }

	// RVA: 0x1926580 Offset: 0x1924B80 VA: 0x181926580
	private char GetLowSurrogate(uint iChar) { }

	// RVA: 0x19263C0 Offset: 0x19249C0 VA: 0x1819263C0 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x1926420 Offset: 0x1924A20 VA: 0x181926420 Slot: 39
	public override Encoder GetEncoder() { }

	// RVA: 0x19265A0 Offset: 0x1924BA0 VA: 0x1819265A0 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x19266D0 Offset: 0x1924CD0 VA: 0x1819266D0 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x19267A0 Offset: 0x1924DA0 VA: 0x1819267A0 Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x1924100 Offset: 0x1922700 VA: 0x181924100 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x19264C0 Offset: 0x1924AC0 VA: 0x1819264C0 Slot: 2
	public override int GetHashCode() { }

}

internal class UTF32Encoding.UTF32Decoder : DecoderNLS // TypeDefIndex: 468
{	// Fields
	internal int iChar; // 0x30
	internal int readByteCount; // 0x34

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x14A3F70 Offset: 0x14A2570 VA: 0x1814A3F70
	public void .ctor(UTF32Encoding encoding) { }

	// RVA: 0x19240D0 Offset: 0x19226D0 VA: 0x1819240D0 Slot: 4
	public override void Reset() { }

	// RVA: 0x178A4B0 Offset: 0x1788AB0 VA: 0x18178A4B0 Slot: 14
	internal override bool get_HasState() { }

}

