public class UnicodeEncoding : Encoding // TypeDefIndex: 465
{	[OptionalFieldAttribute] // RVA: 0x92FF0 Offset: 0x923F0 VA: 0x180092FF0
	internal bool isThrowException; // 0x38
	internal bool bigEndian; // 0x39
	internal bool byteOrderMark; // 0x3A
	private static readonly ulong highLowPatternMask; // 0x0


	public void .ctor() { }

	public void .ctor(bool bigEndian, bool byteOrderMark) { }

	public void .ctor(bool bigEndian, bool byteOrderMark, bool throwOnInvalidBytes) { }

	[OnDeserializingAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void OnDeserializing(StreamingContext ctx) { }

	internal override void SetDefaultFallbacks() { }

	public override int GetByteCount(char[] chars, int index, int count) { }

	public override int GetByteCount(string s) { }

	[ComVisibleAttribute] // RVA: 0x90410 Offset: 0x8F810 VA: 0x180090410
	[CLSCompliantAttribute] // RVA: 0x90410 Offset: 0x8F810 VA: 0x180090410
	public override int GetByteCount(char* chars, int count) { }

	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[ComVisibleAttribute] // RVA: 0x90410 Offset: 0x8F810 VA: 0x180090410
	[CLSCompliantAttribute] // RVA: 0x90410 Offset: 0x8F810 VA: 0x180090410
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0x90840 Offset: 0x8FC40 VA: 0x180090840
	[ComVisibleAttribute] // RVA: 0x90840 Offset: 0x8FC40 VA: 0x180090840
	public override int GetCharCount(byte* bytes, int count) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0x90840 Offset: 0x8FC40 VA: 0x180090840
	[ComVisibleAttribute] // RVA: 0x90840 Offset: 0x8FC40 VA: 0x180090840
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	[ComVisibleAttribute] // RVA: 0x75DE0 Offset: 0x751E0 VA: 0x180075DE0
	public override string GetString(byte[] bytes, int index, int count) { }

	internal override int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	[ComVisibleAttribute] // RVA: 0x75DE0 Offset: 0x751E0 VA: 0x180075DE0
	public override Encoder GetEncoder() { }

	public override Decoder GetDecoder() { }

	public override byte[] GetPreamble() { }

	public override int GetMaxByteCount(int charCount) { }

	public override int GetMaxCharCount(int byteCount) { }

	public override bool Equals(object value) { }

	public override int GetHashCode() { }

	private static void .cctor() { }

}

private class UnicodeEncoding.Decoder : DecoderNLS, ISerializable // TypeDefIndex: 466
{	internal int lastByte; // 0x30
	internal char lastChar; // 0x34

	internal override bool HasState { get; }


	public void .ctor(UnicodeEncoding encoding) { }

	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	public override void Reset() { }

	internal override bool get_HasState() { }

}

