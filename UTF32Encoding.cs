public sealed class UTF32Encoding : Encoding // TypeDefIndex: 467
{	// Fields
	private bool emitUTF32ByteOrderMark; // 0x38
	private bool isThrowException; // 0x39
	private bool bigEndian; // 0x3A

	// Methods

	// RVA: 0x1927260 Offset: 0x1925860 VA: 0x181927260
	public void .ctor() { }

	// RVA: 0x1927190 Offset: 0x1925790 VA: 0x181927190
	public void .ctor(bool bigEndian, bool byteOrderMark) { }

	// RVA: 0x19271E0 Offset: 0x19257E0 VA: 0x1819271E0
	public void .ctor(bool bigEndian, bool byteOrderMark, bool throwOnInvalidCharacters) { }

	// RVA: 0x19270C0 Offset: 0x19256C0 VA: 0x1819270C0 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x1924830 Offset: 0x1922E30 VA: 0x181924830 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x1924E60 Offset: 0x1923460 VA: 0x181924E60 Slot: 18
	public override int GetByteCount(string s) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x19249C0 Offset: 0x1922FC0 VA: 0x1819249C0 Slot: 20
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x19257E0 Offset: 0x1923DE0 VA: 0x1819257E0 Slot: 26
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1925580 Offset: 0x1923B80 VA: 0x181925580 Slot: 24
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x1924F00 Offset: 0x1923500 VA: 0x181924F00 Slot: 28
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x1925B40 Offset: 0x1924140 VA: 0x181925B40 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x1925A40 Offset: 0x1924040 VA: 0x181925A40 Slot: 30
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1926680 Offset: 0x1924C80 VA: 0x181926680 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x19268E0 Offset: 0x1924EE0 VA: 0x1819268E0 Slot: 34
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x1926F10 Offset: 0x1925510 VA: 0x181926F10 Slot: 43
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1924AC0 Offset: 0x19230C0 VA: 0x181924AC0 Slot: 21
	internal override int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x1925040 Offset: 0x1923640 VA: 0x181925040 Slot: 27
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x1925CD0 Offset: 0x19242D0 VA: 0x181925CD0 Slot: 31
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x19260C0 Offset: 0x19246C0 VA: 0x1819260C0 Slot: 35
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x19270A0 Offset: 0x19256A0 VA: 0x1819270A0
	private uint GetSurrogate(char cHigh, char cLow) { }

	// RVA: 0x1926BC0 Offset: 0x19251C0 VA: 0x181926BC0
	private char GetHighSurrogate(uint iChar) { }

	// RVA: 0x1926BE0 Offset: 0x19251E0 VA: 0x181926BE0
	private char GetLowSurrogate(uint iChar) { }

	// RVA: 0x1926A20 Offset: 0x1925020 VA: 0x181926A20 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x1926A80 Offset: 0x1925080 VA: 0x181926A80 Slot: 39
	public override Encoder GetEncoder() { }

	// RVA: 0x1926C00 Offset: 0x1925200 VA: 0x181926C00 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x1926D30 Offset: 0x1925330 VA: 0x181926D30 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x1926E00 Offset: 0x1925400 VA: 0x181926E00 Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x1924760 Offset: 0x1922D60 VA: 0x181924760 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1926B20 Offset: 0x1925120 VA: 0x181926B20 Slot: 2
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

	// RVA: 0x1924730 Offset: 0x1922D30 VA: 0x181924730 Slot: 4
	public override void Reset() { }

	// RVA: 0x178C6A0 Offset: 0x178ACA0 VA: 0x18178C6A0 Slot: 14
	internal override bool get_HasState() { }

}

