public class ASCIIEncoding : Encoding // TypeDefIndex: 432
{	[ComVisibleAttribute] // RVA: 0x75DE0 Offset: 0x751E0 VA: 0x180075DE0
	public override bool IsSingleByte { get; }


	public void .ctor() { }

	internal override void SetDefaultFallbacks() { }

	public override int GetByteCount(char[] chars, int index, int count) { }

	public override int GetByteCount(string chars) { }

	[ComVisibleAttribute] // RVA: 0x90410 Offset: 0x8F810 VA: 0x180090410
	[CLSCompliantAttribute] // RVA: 0x90410 Offset: 0x8F810 VA: 0x180090410
	public override int GetByteCount(char* chars, int count) { }

	public override int GetBytes(string chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[ComVisibleAttribute] // RVA: 0x90410 Offset: 0x8F810 VA: 0x180090410
	[CLSCompliantAttribute] // RVA: 0x90410 Offset: 0x8F810 VA: 0x180090410
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[ComVisibleAttribute] // RVA: 0x90410 Offset: 0x8F810 VA: 0x180090410
	[CLSCompliantAttribute] // RVA: 0x90410 Offset: 0x8F810 VA: 0x180090410
	public override int GetCharCount(byte* bytes, int count) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0x90840 Offset: 0x8FC40 VA: 0x180090840
	[ComVisibleAttribute] // RVA: 0x90840 Offset: 0x8FC40 VA: 0x180090840
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	public override string GetString(byte[] bytes, int byteIndex, int byteCount) { }

	internal override int GetByteCount(char* chars, int charCount, EncoderNLS encoder) { }

	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	internal override int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	public override int GetMaxByteCount(int charCount) { }

	public override int GetMaxCharCount(int byteCount) { }

	public override bool get_IsSingleByte() { }

	[ComVisibleAttribute] // RVA: 0x75DE0 Offset: 0x751E0 VA: 0x180075DE0
	public override Decoder GetDecoder() { }

	[ComVisibleAttribute] // RVA: 0x75DE0 Offset: 0x751E0 VA: 0x180075DE0
	public override Encoder GetEncoder() { }

}

