public class UTF7Encoding : Encoding // TypeDefIndex: 469
{	// Fields
	private byte[] base64Bytes; // 0x38
	private sbyte[] base64Values; // 0x40
	private bool[] directEncode; // 0x48
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	private bool m_allowOptionals; // 0x50

	// Methods

	// RVA: 0x1929740 Offset: 0x1927D40 VA: 0x181929740
	public void .ctor() { }

	// RVA: 0x19296D0 Offset: 0x1927CD0 VA: 0x1819296D0
	public void .ctor(bool allowOptionals) { }

	// RVA: 0x19292C0 Offset: 0x19278C0 VA: 0x1819292C0
	private void MakeTables() { }

	// RVA: 0x1929620 Offset: 0x1927C20 VA: 0x181929620 Slot: 5
	internal override void SetDefaultFallbacks() { }

	[OnDeserializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x191A970 Offset: 0x1918F70 VA: 0x18191A970
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1929550 Offset: 0x1927B50 VA: 0x181929550
	private void OnDeserialized(StreamingContext ctx) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1927520 Offset: 0x1925B20 VA: 0x181927520 Slot: 0
	public override bool Equals(object value) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1928F40 Offset: 0x1927540 VA: 0x181928F40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1927740 Offset: 0x1925D40 VA: 0x181927740 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x19278D0 Offset: 0x1925ED0 VA: 0x1819278D0 Slot: 18
	public override int GetByteCount(string s) { }

	[ComVisibleAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	[CLSCompliantAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	// RVA: 0x1927640 Offset: 0x1925C40 VA: 0x181927640 Slot: 20
	public override int GetByteCount(char* chars, int count) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1928240 Offset: 0x1926840 VA: 0x181928240 Slot: 26
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1927970 Offset: 0x1925F70 VA: 0x181927970 Slot: 24
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[ComVisibleAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	[CLSCompliantAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	// RVA: 0x1928100 Offset: 0x1926700 VA: 0x181928100 Slot: 28
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x19285A0 Offset: 0x1926BA0 VA: 0x1819285A0 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x19284A0 Offset: 0x1926AA0 VA: 0x1819284A0 Slot: 30
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1928BE0 Offset: 0x19271E0 VA: 0x181928BE0 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x1928AA0 Offset: 0x19270A0 VA: 0x181928AA0 Slot: 34
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1929130 Offset: 0x1927730 VA: 0x181929130 Slot: 43
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1927610 Offset: 0x1925C10 VA: 0x181927610 Slot: 21
	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	// RVA: 0x1927BD0 Offset: 0x19261D0 VA: 0x181927BD0 Slot: 27
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	// RVA: 0x1928730 Offset: 0x1926D30 VA: 0x181928730 Slot: 31
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x1928760 Offset: 0x1926D60 VA: 0x181928760 Slot: 35
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x1928E40 Offset: 0x1927440 VA: 0x181928E40 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x1928EA0 Offset: 0x19274A0 VA: 0x181928EA0 Slot: 39
	public override Encoder GetEncoder() { }

	// RVA: 0x1928FC0 Offset: 0x19275C0 VA: 0x181928FC0 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x19290A0 Offset: 0x19276A0 VA: 0x1819290A0 Slot: 41
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

	// RVA: 0x14A4EA0 Offset: 0x14A34A0 VA: 0x1814A4EA0
	public void .ctor(UTF7Encoding encoding) { }

	// RVA: 0x1912A00 Offset: 0x1911000 VA: 0x181912A00
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1912930 Offset: 0x1910F30 VA: 0x181912930 Slot: 13
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1912900 Offset: 0x1910F00 VA: 0x181912900 Slot: 4
	public override void Reset() { }

	// RVA: 0x1912C40 Offset: 0x1911240 VA: 0x181912C40 Slot: 14
	internal override bool get_HasState() { }

}

private class UTF7Encoding.Encoder : EncoderNLS, ISerializable // TypeDefIndex: 471
{	// Fields
	internal int bits; // 0x38
	internal int bitCount; // 0x3C

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x1914BE0 Offset: 0x19131E0 VA: 0x181914BE0
	public void .ctor(UTF7Encoding encoding) { }

	// RVA: 0x1915660 Offset: 0x1913C60 VA: 0x181915660
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x19155B0 Offset: 0x1913BB0 VA: 0x1819155B0 Slot: 11
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1915580 Offset: 0x1913B80 VA: 0x181915580 Slot: 4
	public override void Reset() { }

	// RVA: 0x1915880 Offset: 0x1913E80 VA: 0x181915880 Slot: 12
	internal override bool get_HasState() { }

}

internal sealed class UTF7Encoding.DecoderUTF7Fallback : DecoderFallback // TypeDefIndex: 472
{	// Properties
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0x1912850 Offset: 0x1910E50 VA: 0x181912850 Slot: 4
	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x19128A0 Offset: 0x1910EA0 VA: 0x1819128A0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x19128F0 Offset: 0x1910EF0 VA: 0x1819128F0 Slot: 2
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

	// RVA: 0x1912830 Offset: 0x1910E30 VA: 0x181912830
	public void .ctor(UTF7Encoding.DecoderUTF7Fallback fallback) { }

	// RVA: 0x1912720 Offset: 0x1910D20 VA: 0x181912720 Slot: 4
	public override bool Fallback(byte[] bytesUnknown, int index) { }

	// RVA: 0x1912770 Offset: 0x1910D70 VA: 0x181912770 Slot: 5
	public override char GetNextChar() { }

	// RVA: 0x1912840 Offset: 0x1910E40 VA: 0x181912840 Slot: 6
	public override int get_Remaining() { }

	// RVA: 0x1912820 Offset: 0x1910E20 VA: 0x181912820 Slot: 7
	public override void Reset() { }

	// RVA: 0x1912790 Offset: 0x1910D90 VA: 0x181912790 Slot: 9
	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }

}

