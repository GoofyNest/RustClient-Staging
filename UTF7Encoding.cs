public class UTF7Encoding : Encoding // TypeDefIndex: 469
{	private byte[] base64Bytes; // 0x38
	private sbyte[] base64Values; // 0x40
	private bool[] directEncode; // 0x48
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	private bool m_allowOptionals; // 0x50


	public void .ctor() { }

	public void .ctor(bool allowOptionals) { }

	private void MakeTables() { }

	internal override void SetDefaultFallbacks() { }

	[OnDeserializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void OnDeserialized(StreamingContext ctx) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public override bool Equals(object value) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public override int GetHashCode() { }

	public override int GetByteCount(char[] chars, int index, int count) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public override int GetByteCount(string s) { }

	[ComVisibleAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	[CLSCompliantAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	public override int GetByteCount(char* chars, int count) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[ComVisibleAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	[CLSCompliantAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	public override int GetCharCount(byte* bytes, int count) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public override string GetString(byte[] bytes, int index, int count) { }

	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	public override Decoder GetDecoder() { }

	public override Encoder GetEncoder() { }

	public override int GetMaxByteCount(int charCount) { }

	public override int GetMaxCharCount(int byteCount) { }

}

private class UTF7Encoding.Decoder : DecoderNLS, ISerializable // TypeDefIndex: 470
{	internal int bits; // 0x30
	internal int bitCount; // 0x34
	internal bool firstByte; // 0x38

	internal override bool HasState { get; }


	public void .ctor(UTF7Encoding encoding) { }

	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	public override void Reset() { }

	internal override bool get_HasState() { }

}

private class UTF7Encoding.Encoder : EncoderNLS, ISerializable // TypeDefIndex: 471
{	internal int bits; // 0x38
	internal int bitCount; // 0x3C

	internal override bool HasState { get; }


	public void .ctor(UTF7Encoding encoding) { }

	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	public override void Reset() { }

	internal override bool get_HasState() { }

}

internal sealed class UTF7Encoding.DecoderUTF7Fallback : DecoderFallback // TypeDefIndex: 472
{	public override int MaxCharCount { get; }


	public void .ctor() { }

	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	public override int get_MaxCharCount() { }

	public override bool Equals(object value) { }

	public override int GetHashCode() { }

}

internal sealed class UTF7Encoding.DecoderUTF7FallbackBuffer : DecoderFallbackBuffer // TypeDefIndex: 473
{	private char cFallback; // 0x20
	private int iCount; // 0x24
	private int iSize; // 0x28

	public override int Remaining { get; }


	public void .ctor(UTF7Encoding.DecoderUTF7Fallback fallback) { }

	public override bool Fallback(byte[] bytesUnknown, int index) { }

	public override char GetNextChar() { }

	public override int get_Remaining() { }

	public override void Reset() { }

	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }

}

