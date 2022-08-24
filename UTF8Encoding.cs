public class UTF8Encoding : Encoding // TypeDefIndex: 474
{	private bool emitUTF8Identifier; // 0x38
	private bool isThrowException; // 0x39


	public void .ctor() { }

	public void .ctor(bool encoderShouldEmitUTF8Identifier) { }

	public void .ctor(bool encoderShouldEmitUTF8Identifier, bool throwOnInvalidBytes) { }

	internal override void SetDefaultFallbacks() { }

	public override int GetByteCount(char[] chars, int index, int count) { }

	public override int GetByteCount(string chars) { }

	[CLSCompliantAttribute] // RVA: 0x90790 Offset: 0x8FB90 VA: 0x180090790
	[ComVisibleAttribute] // RVA: 0x90790 Offset: 0x8FB90 VA: 0x180090790
	public override int GetByteCount(char* chars, int count) { }

	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[ComVisibleAttribute] // RVA: 0x90290 Offset: 0x8F690 VA: 0x180090290
	[CLSCompliantAttribute] // RVA: 0x90290 Offset: 0x8F690 VA: 0x180090290
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0x90790 Offset: 0x8FB90 VA: 0x180090790
	[ComVisibleAttribute] // RVA: 0x90790 Offset: 0x8FB90 VA: 0x180090790
	public override int GetCharCount(byte* bytes, int count) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0x90790 Offset: 0x8FB90 VA: 0x180090790
	[ComVisibleAttribute] // RVA: 0x90790 Offset: 0x8FB90 VA: 0x180090790
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	[ComVisibleAttribute] // RVA: 0x75DF0 Offset: 0x751F0 VA: 0x180075DF0
	public override string GetString(byte[] bytes, int index, int count) { }

	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	private static int PtrDiff(char* a, char* b) { }

	private static int PtrDiff(byte* a, byte* b) { }

	private static bool InRange(int ch, int start, int end) { }

	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	private bool FallbackInvalidByteSequence(ref byte* pSrc, int ch, DecoderFallbackBuffer fallback, ref char* pTarget) { }

	private int FallbackInvalidByteSequence(byte* pSrc, int ch, DecoderFallbackBuffer fallback) { }

	private byte[] GetBytesUnknown(ref byte* pSrc, int ch) { }

	public override Decoder GetDecoder() { }

	public override Encoder GetEncoder() { }

	public override int GetMaxByteCount(int charCount) { }

	public override int GetMaxCharCount(int byteCount) { }

	public override byte[] GetPreamble() { }

	public override bool Equals(object value) { }

	public override int GetHashCode() { }

}

internal class UTF8Encoding.UTF8Encoder : EncoderNLS, ISerializable // TypeDefIndex: 475
{	internal int surrogateChar; // 0x38

	internal override bool HasState { get; }


	public void .ctor(UTF8Encoding encoding) { }

	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	public override void Reset() { }

	internal override bool get_HasState() { }

}

internal class UTF8Encoding.UTF8Decoder : DecoderNLS, ISerializable // TypeDefIndex: 476
{	internal int bits; // 0x30

	internal override bool HasState { get; }


	public void .ctor(UTF8Encoding encoding) { }

	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	public override void Reset() { }

	internal override bool get_HasState() { }

}

