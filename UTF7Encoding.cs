public class UTF7Encoding : Encoding // TypeDefIndex: 469
{	// Fields
	private byte[] base64Bytes; // 0x38
	private sbyte[] base64Values; // 0x40
	private bool[] directEncode; // 0x48
	[OptionalFieldAttribute] // RVA: 0x92F70 Offset: 0x92370 VA: 0x180092F70
	private bool m_allowOptionals; // 0x50

	// Methods

	// RVA: 0x19294C0 Offset: 0x1927AC0 VA: 0x1819294C0
	public void .ctor() { }

	// RVA: 0x1929450 Offset: 0x1927A50 VA: 0x181929450
	public void .ctor(bool allowOptionals) { }

	// RVA: 0x1929040 Offset: 0x1927640 VA: 0x181929040
	private void MakeTables() { }

	// RVA: 0x19293A0 Offset: 0x19279A0 VA: 0x1819293A0 Slot: 5
	internal override void SetDefaultFallbacks() { }

	[OnDeserializingAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x191A6F0 Offset: 0x1918CF0 VA: 0x18191A6F0
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19292D0 Offset: 0x19278D0 VA: 0x1819292D0
	private void OnDeserialized(StreamingContext ctx) { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x19272A0 Offset: 0x19258A0 VA: 0x1819272A0 Slot: 0
	public override bool Equals(object value) { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x1928CC0 Offset: 0x19272C0 VA: 0x181928CC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x19274C0 Offset: 0x1925AC0 VA: 0x1819274C0 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x1927650 Offset: 0x1925C50 VA: 0x181927650 Slot: 18
	public override int GetByteCount(string s) { }

	[ComVisibleAttribute] // RVA: 0x902E0 Offset: 0x8F6E0 VA: 0x1800902E0
	[CLSCompliantAttribute] // RVA: 0x902E0 Offset: 0x8F6E0 VA: 0x1800902E0
	// RVA: 0x19273C0 Offset: 0x19259C0 VA: 0x1819273C0 Slot: 20
	public override int GetByteCount(char* chars, int count) { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x1927FC0 Offset: 0x19265C0 VA: 0x181927FC0 Slot: 26
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x19276F0 Offset: 0x1925CF0 VA: 0x1819276F0 Slot: 24
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[ComVisibleAttribute] // RVA: 0x902E0 Offset: 0x8F6E0 VA: 0x1800902E0
	[CLSCompliantAttribute] // RVA: 0x902E0 Offset: 0x8F6E0 VA: 0x1800902E0
	// RVA: 0x1927E80 Offset: 0x1926480 VA: 0x181927E80 Slot: 28
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x1928320 Offset: 0x1926920 VA: 0x181928320 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0x90730 Offset: 0x8FB30 VA: 0x180090730
	[ComVisibleAttribute] // RVA: 0x90730 Offset: 0x8FB30 VA: 0x180090730
	// RVA: 0x1928220 Offset: 0x1926820 VA: 0x181928220 Slot: 30
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1928960 Offset: 0x1926F60 VA: 0x181928960 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0x90730 Offset: 0x8FB30 VA: 0x180090730
	[ComVisibleAttribute] // RVA: 0x90730 Offset: 0x8FB30 VA: 0x180090730
	// RVA: 0x1928820 Offset: 0x1926E20 VA: 0x181928820 Slot: 34
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x1928EB0 Offset: 0x19274B0 VA: 0x181928EB0 Slot: 43
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1927390 Offset: 0x1925990 VA: 0x181927390 Slot: 21
	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	// RVA: 0x1927950 Offset: 0x1925F50 VA: 0x181927950 Slot: 27
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	// RVA: 0x19284B0 Offset: 0x1926AB0 VA: 0x1819284B0 Slot: 31
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x19284E0 Offset: 0x1926AE0 VA: 0x1819284E0 Slot: 35
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x1928BC0 Offset: 0x19271C0 VA: 0x181928BC0 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x1928C20 Offset: 0x1927220 VA: 0x181928C20 Slot: 39
	public override Encoder GetEncoder() { }

	// RVA: 0x1928D40 Offset: 0x1927340 VA: 0x181928D40 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x1928E20 Offset: 0x1927420 VA: 0x181928E20 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

}

private class UTF7Encoding.Decoder : DecoderNLS, ISerializable // TypeDefIndex: 470
{	// Fields
	internal int bits; // 0x30
	internal int bitCount; // 0x34
	internal bool firstByte; // 0x38

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x14A4BE0 Offset: 0x14A31E0 VA: 0x1814A4BE0
	public void .ctor(UTF7Encoding encoding) { }

	// RVA: 0x1912780 Offset: 0x1910D80 VA: 0x181912780
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x19126B0 Offset: 0x1910CB0 VA: 0x1819126B0 Slot: 13
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1912680 Offset: 0x1910C80 VA: 0x181912680 Slot: 4
	public override void Reset() { }

	// RVA: 0x19129C0 Offset: 0x1910FC0 VA: 0x1819129C0 Slot: 14
	internal override bool get_HasState() { }

}

private class UTF7Encoding.Encoder : EncoderNLS, ISerializable // TypeDefIndex: 471
{	// Fields
	internal int bits; // 0x38
	internal int bitCount; // 0x3C

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x1914960 Offset: 0x1912F60 VA: 0x181914960
	public void .ctor(UTF7Encoding encoding) { }

	// RVA: 0x19153E0 Offset: 0x19139E0 VA: 0x1819153E0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1915330 Offset: 0x1913930 VA: 0x181915330 Slot: 11
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1915300 Offset: 0x1913900 VA: 0x181915300 Slot: 4
	public override void Reset() { }

	// RVA: 0x1915600 Offset: 0x1913C00 VA: 0x181915600 Slot: 12
	internal override bool get_HasState() { }

}

internal sealed class UTF7Encoding.DecoderUTF7Fallback : DecoderFallback // TypeDefIndex: 472
{	// Properties
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0x19125D0 Offset: 0x1910BD0 VA: 0x1819125D0 Slot: 4
	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x1912620 Offset: 0x1910C20 VA: 0x181912620 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1912670 Offset: 0x1910C70 VA: 0x181912670 Slot: 2
	public override int GetHashCode() { }

}

internal sealed class UTF7Encoding.DecoderUTF7FallbackBuffer : DecoderFallbackBuffer // TypeDefIndex: 473
{	// Fields
	private char cFallback; // 0x20
	private int iCount; // 0x24
	private int iSize; // 0x28

	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x19125B0 Offset: 0x1910BB0 VA: 0x1819125B0
	public void .ctor(UTF7Encoding.DecoderUTF7Fallback fallback) { }

	// RVA: 0x19124A0 Offset: 0x1910AA0 VA: 0x1819124A0 Slot: 4
	public override bool Fallback(byte[] bytesUnknown, int index) { }

	// RVA: 0x19124F0 Offset: 0x1910AF0 VA: 0x1819124F0 Slot: 5
	public override char GetNextChar() { }

	// RVA: 0x19125C0 Offset: 0x1910BC0 VA: 0x1819125C0 Slot: 6
	public override int get_Remaining() { }

	// RVA: 0x19125A0 Offset: 0x1910BA0 VA: 0x1819125A0 Slot: 7
	public override void Reset() { }

	// RVA: 0x1912510 Offset: 0x1910B10 VA: 0x181912510 Slot: 9
	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }

}

