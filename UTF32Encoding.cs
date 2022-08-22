public sealed class UTF32Encoding : Encoding // TypeDefIndex: 467
{	// Fields
	private bool emitUTF32ByteOrderMark; // 0x38
	private bool isThrowException; // 0x39
	private bool bigEndian; // 0x3A

	// Methods

	// RVA: 0x19274E0 Offset: 0x1925AE0 VA: 0x1819274E0
	public void .ctor() { }

	// RVA: 0x1927410 Offset: 0x1925A10 VA: 0x181927410
	public void .ctor(bool bigEndian, bool byteOrderMark) { }

	// RVA: 0x1927460 Offset: 0x1925A60 VA: 0x181927460
	public void .ctor(bool bigEndian, bool byteOrderMark, bool throwOnInvalidCharacters) { }

	// RVA: 0x1927340 Offset: 0x1925940 VA: 0x181927340 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x1924AB0 Offset: 0x19230B0 VA: 0x181924AB0 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x19250E0 Offset: 0x19236E0 VA: 0x1819250E0 Slot: 18
	public override int GetByteCount(string s) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1924C40 Offset: 0x1923240 VA: 0x181924C40 Slot: 20
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x1925A60 Offset: 0x1924060 VA: 0x181925A60 Slot: 26
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1925800 Offset: 0x1923E00 VA: 0x181925800 Slot: 24
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1925180 Offset: 0x1923780 VA: 0x181925180 Slot: 28
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x1925DC0 Offset: 0x19243C0 VA: 0x181925DC0 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1925CC0 Offset: 0x19242C0 VA: 0x181925CC0 Slot: 30
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1926900 Offset: 0x1924F00 VA: 0x181926900 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1926B60 Offset: 0x1925160 VA: 0x181926B60 Slot: 34
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x1927190 Offset: 0x1925790 VA: 0x181927190 Slot: 43
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1924D40 Offset: 0x1923340 VA: 0x181924D40 Slot: 21
	internal override int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x19252C0 Offset: 0x19238C0 VA: 0x1819252C0 Slot: 27
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x1925F50 Offset: 0x1924550 VA: 0x181925F50 Slot: 31
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x1926340 Offset: 0x1924940 VA: 0x181926340 Slot: 35
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x1927320 Offset: 0x1925920 VA: 0x181927320
	private uint GetSurrogate(char cHigh, char cLow) { }

	// RVA: 0x1926E40 Offset: 0x1925440 VA: 0x181926E40
	private char GetHighSurrogate(uint iChar) { }

	// RVA: 0x1926E60 Offset: 0x1925460 VA: 0x181926E60
	private char GetLowSurrogate(uint iChar) { }

	// RVA: 0x1926CA0 Offset: 0x19252A0 VA: 0x181926CA0 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x1926D00 Offset: 0x1925300 VA: 0x181926D00 Slot: 39
	public override Encoder GetEncoder() { }

	// RVA: 0x1926E80 Offset: 0x1925480 VA: 0x181926E80 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x1926FB0 Offset: 0x19255B0 VA: 0x181926FB0 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x1927080 Offset: 0x1925680 VA: 0x181927080 Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x19249E0 Offset: 0x1922FE0 VA: 0x1819249E0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1926DA0 Offset: 0x19253A0 VA: 0x181926DA0 Slot: 2
	public override int GetHashCode() { }

}

internal class UTF32Encoding.UTF32Decoder : DecoderNLS // TypeDefIndex: 468
{	// Fields
	internal int iChar; // 0x30
	internal int readByteCount; // 0x34

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x14A4EA0 Offset: 0x14A34A0 VA: 0x1814A4EA0
	public void .ctor(UTF32Encoding encoding) { }

	// RVA: 0x19249B0 Offset: 0x1922FB0 VA: 0x1819249B0 Slot: 4
	public override void Reset() { }

	// RVA: 0x178C960 Offset: 0x178AF60 VA: 0x18178C960 Slot: 14
	internal override bool get_HasState() { }

}

