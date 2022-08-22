public class ASCIIEncoding : Encoding // TypeDefIndex: 432
{	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public override bool IsSingleByte { get; }


	public void .ctor() { }

	internal override void SetDefaultFallbacks() { }

	public override int GetByteCount(char[] chars, int index, int count) { }

	public override int GetByteCount(string chars) { }

	[ComVisibleAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	[CLSCompliantAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	public override int GetByteCount(char* chars, int count) { }

	public override int GetBytes(string chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[ComVisibleAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	[CLSCompliantAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[ComVisibleAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	[CLSCompliantAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	public override int GetCharCount(byte* bytes, int count) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	public override string GetString(byte[] bytes, int byteIndex, int byteCount) { }

	internal override int GetByteCount(char* chars, int charCount, EncoderNLS encoder) { }

	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	internal override int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	public override int GetMaxByteCount(int charCount) { }

	public override int GetMaxCharCount(int byteCount) { }

	public override bool get_IsSingleByte() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public override Decoder GetDecoder() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public override Encoder GetEncoder() { }

}

