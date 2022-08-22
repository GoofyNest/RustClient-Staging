public class UTF7Encoding : Encoding // TypeDefIndex: 469
{	// Fields
	private byte[] base64Bytes; // 0x38
	private sbyte[] base64Values; // 0x40
	private bool[] directEncode; // 0x48
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	private bool m_allowOptionals; // 0x50

	// Methods

	// RVA: 0x1928E60 Offset: 0x1927460 VA: 0x181928E60
	public void .ctor() { }

	// RVA: 0x1928DF0 Offset: 0x19273F0 VA: 0x181928DF0
	public void .ctor(bool allowOptionals) { }

	// RVA: 0x19289E0 Offset: 0x1926FE0 VA: 0x1819289E0
	private void MakeTables() { }

	// RVA: 0x1928D40 Offset: 0x1927340 VA: 0x181928D40 Slot: 5
	internal override void SetDefaultFallbacks() { }

	[OnDeserializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x191A090 Offset: 0x1918690 VA: 0x18191A090
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1928C70 Offset: 0x1927270 VA: 0x181928C70
	private void OnDeserialized(StreamingContext ctx) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1926C40 Offset: 0x1925240 VA: 0x181926C40 Slot: 0
	public override bool Equals(object value) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1928660 Offset: 0x1926C60 VA: 0x181928660 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1926E60 Offset: 0x1925460 VA: 0x181926E60 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1926FF0 Offset: 0x19255F0 VA: 0x181926FF0 Slot: 18
	public override int GetByteCount(string s) { }

	[ComVisibleAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	[CLSCompliantAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	// RVA: 0x1926D60 Offset: 0x1925360 VA: 0x181926D60 Slot: 20
	public override int GetByteCount(char* chars, int count) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1927960 Offset: 0x1925F60 VA: 0x181927960 Slot: 26
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1927090 Offset: 0x1925690 VA: 0x181927090 Slot: 24
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[ComVisibleAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	[CLSCompliantAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	// RVA: 0x1927820 Offset: 0x1925E20 VA: 0x181927820 Slot: 28
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x1927CC0 Offset: 0x19262C0 VA: 0x181927CC0 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x1927BC0 Offset: 0x19261C0 VA: 0x181927BC0 Slot: 30
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1928300 Offset: 0x1926900 VA: 0x181928300 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x19281C0 Offset: 0x19267C0 VA: 0x1819281C0 Slot: 34
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1928850 Offset: 0x1926E50 VA: 0x181928850 Slot: 43
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1926D30 Offset: 0x1925330 VA: 0x181926D30 Slot: 21
	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	// RVA: 0x19272F0 Offset: 0x19258F0 VA: 0x1819272F0 Slot: 27
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	// RVA: 0x1927E50 Offset: 0x1926450 VA: 0x181927E50 Slot: 31
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x1927E80 Offset: 0x1926480 VA: 0x181927E80 Slot: 35
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x1928560 Offset: 0x1926B60 VA: 0x181928560 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x19285C0 Offset: 0x1926BC0 VA: 0x1819285C0 Slot: 39
	public override Encoder GetEncoder() { }

	// RVA: 0x19286E0 Offset: 0x1926CE0 VA: 0x1819286E0 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x19287C0 Offset: 0x1926DC0 VA: 0x1819287C0 Slot: 41
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

	// RVA: 0x14A3F70 Offset: 0x14A2570 VA: 0x1814A3F70
	public void .ctor(UTF7Encoding encoding) { }

	// RVA: 0x1912120 Offset: 0x1910720 VA: 0x181912120
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1912050 Offset: 0x1910650 VA: 0x181912050 Slot: 13
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1912020 Offset: 0x1910620 VA: 0x181912020 Slot: 4
	public override void Reset() { }

	// RVA: 0x1912360 Offset: 0x1910960 VA: 0x181912360 Slot: 14
	internal override bool get_HasState() { }

}

private class UTF7Encoding.Encoder : EncoderNLS, ISerializable // TypeDefIndex: 471
{	// Fields
	internal int bits; // 0x38
	internal int bitCount; // 0x3C

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x1914300 Offset: 0x1912900 VA: 0x181914300
	public void .ctor(UTF7Encoding encoding) { }

	// RVA: 0x1914D80 Offset: 0x1913380 VA: 0x181914D80
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1914CD0 Offset: 0x19132D0 VA: 0x181914CD0 Slot: 11
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1914CA0 Offset: 0x19132A0 VA: 0x181914CA0 Slot: 4
	public override void Reset() { }

	// RVA: 0x1914FA0 Offset: 0x19135A0 VA: 0x181914FA0 Slot: 12
	internal override bool get_HasState() { }

}

internal sealed class UTF7Encoding.DecoderUTF7Fallback : DecoderFallback // TypeDefIndex: 472
{	// Properties
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0x1911F70 Offset: 0x1910570 VA: 0x181911F70 Slot: 4
	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x5B1870 Offset: 0x5AFE70 VA: 0x1805B1870 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x1911FC0 Offset: 0x19105C0 VA: 0x181911FC0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1912010 Offset: 0x1910610 VA: 0x181912010 Slot: 2
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

	// RVA: 0x1911F50 Offset: 0x1910550 VA: 0x181911F50
	public void .ctor(UTF7Encoding.DecoderUTF7Fallback fallback) { }

	// RVA: 0x1911E40 Offset: 0x1910440 VA: 0x181911E40 Slot: 4
	public override bool Fallback(byte[] bytesUnknown, int index) { }

	// RVA: 0x1911E90 Offset: 0x1910490 VA: 0x181911E90 Slot: 5
	public override char GetNextChar() { }

	// RVA: 0x1911F60 Offset: 0x1910560 VA: 0x181911F60 Slot: 6
	public override int get_Remaining() { }

	// RVA: 0x1911F40 Offset: 0x1910540 VA: 0x181911F40 Slot: 7
	public override void Reset() { }

	// RVA: 0x1911EB0 Offset: 0x19104B0 VA: 0x181911EB0 Slot: 9
	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }

}

