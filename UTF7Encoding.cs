public class UTF7Encoding : Encoding // TypeDefIndex: 469
{	// Fields
	private byte[] base64Bytes; // 0x38
	private sbyte[] base64Values; // 0x40
	private bool[] directEncode; // 0x48
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	private bool m_allowOptionals; // 0x50

	// Methods

	// RVA: 0x1929480 Offset: 0x1927A80 VA: 0x181929480
	public void .ctor() { }

	// RVA: 0x1929410 Offset: 0x1927A10 VA: 0x181929410
	public void .ctor(bool allowOptionals) { }

	// RVA: 0x1929000 Offset: 0x1927600 VA: 0x181929000
	private void MakeTables() { }

	// RVA: 0x1929360 Offset: 0x1927960 VA: 0x181929360 Slot: 5
	internal override void SetDefaultFallbacks() { }

	[OnDeserializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x191A6B0 Offset: 0x1918CB0 VA: 0x18191A6B0
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1929290 Offset: 0x1927890 VA: 0x181929290
	private void OnDeserialized(StreamingContext ctx) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1927260 Offset: 0x1925860 VA: 0x181927260 Slot: 0
	public override bool Equals(object value) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1928C80 Offset: 0x1927280 VA: 0x181928C80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1927480 Offset: 0x1925A80 VA: 0x181927480 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1927610 Offset: 0x1925C10 VA: 0x181927610 Slot: 18
	public override int GetByteCount(string s) { }

	[ComVisibleAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	[CLSCompliantAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	// RVA: 0x1927380 Offset: 0x1925980 VA: 0x181927380 Slot: 20
	public override int GetByteCount(char* chars, int count) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1927F80 Offset: 0x1926580 VA: 0x181927F80 Slot: 26
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x19276B0 Offset: 0x1925CB0 VA: 0x1819276B0 Slot: 24
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[ComVisibleAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	[CLSCompliantAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	// RVA: 0x1927E40 Offset: 0x1926440 VA: 0x181927E40 Slot: 28
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x19282E0 Offset: 0x19268E0 VA: 0x1819282E0 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x19281E0 Offset: 0x19267E0 VA: 0x1819281E0 Slot: 30
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1928920 Offset: 0x1926F20 VA: 0x181928920 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x19287E0 Offset: 0x1926DE0 VA: 0x1819287E0 Slot: 34
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1928E70 Offset: 0x1927470 VA: 0x181928E70 Slot: 43
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1927350 Offset: 0x1925950 VA: 0x181927350 Slot: 21
	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	// RVA: 0x1927910 Offset: 0x1925F10 VA: 0x181927910 Slot: 27
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	// RVA: 0x1928470 Offset: 0x1926A70 VA: 0x181928470 Slot: 31
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x19284A0 Offset: 0x1926AA0 VA: 0x1819284A0 Slot: 35
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x1928B80 Offset: 0x1927180 VA: 0x181928B80 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x1928BE0 Offset: 0x19271E0 VA: 0x181928BE0 Slot: 39
	public override Encoder GetEncoder() { }

	// RVA: 0x1928D00 Offset: 0x1927300 VA: 0x181928D00 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x1928DE0 Offset: 0x19273E0 VA: 0x181928DE0 Slot: 41
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

	// RVA: 0x1912740 Offset: 0x1910D40 VA: 0x181912740
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1912670 Offset: 0x1910C70 VA: 0x181912670 Slot: 13
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1912640 Offset: 0x1910C40 VA: 0x181912640 Slot: 4
	public override void Reset() { }

	// RVA: 0x1912980 Offset: 0x1910F80 VA: 0x181912980 Slot: 14
	internal override bool get_HasState() { }

}

private class UTF7Encoding.Encoder : EncoderNLS, ISerializable // TypeDefIndex: 471
{	// Fields
	internal int bits; // 0x38
	internal int bitCount; // 0x3C

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x1914920 Offset: 0x1912F20 VA: 0x181914920
	public void .ctor(UTF7Encoding encoding) { }

	// RVA: 0x19153A0 Offset: 0x19139A0 VA: 0x1819153A0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x19152F0 Offset: 0x19138F0 VA: 0x1819152F0 Slot: 11
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x19152C0 Offset: 0x19138C0 VA: 0x1819152C0 Slot: 4
	public override void Reset() { }

	// RVA: 0x19155C0 Offset: 0x1913BC0 VA: 0x1819155C0 Slot: 12
	internal override bool get_HasState() { }

}

internal sealed class UTF7Encoding.DecoderUTF7Fallback : DecoderFallback // TypeDefIndex: 472
{	// Properties
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0x1912590 Offset: 0x1910B90 VA: 0x181912590 Slot: 4
	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x19125E0 Offset: 0x1910BE0 VA: 0x1819125E0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1912630 Offset: 0x1910C30 VA: 0x181912630 Slot: 2
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

	// RVA: 0x1912570 Offset: 0x1910B70 VA: 0x181912570
	public void .ctor(UTF7Encoding.DecoderUTF7Fallback fallback) { }

	// RVA: 0x1912460 Offset: 0x1910A60 VA: 0x181912460 Slot: 4
	public override bool Fallback(byte[] bytesUnknown, int index) { }

	// RVA: 0x19124B0 Offset: 0x1910AB0 VA: 0x1819124B0 Slot: 5
	public override char GetNextChar() { }

	// RVA: 0x1912580 Offset: 0x1910B80 VA: 0x181912580 Slot: 6
	public override int get_Remaining() { }

	// RVA: 0x1912560 Offset: 0x1910B60 VA: 0x181912560 Slot: 7
	public override void Reset() { }

	// RVA: 0x19124D0 Offset: 0x1910AD0 VA: 0x1819124D0 Slot: 9
	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }

}

