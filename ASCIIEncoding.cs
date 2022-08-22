public class ASCIIEncoding : Encoding // TypeDefIndex: 432
{	// Properties
	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public override bool IsSingleByte { get; }

	// Methods

	// RVA: 0x18AAC70 Offset: 0x18A9270 VA: 0x1818AAC70
	public void .ctor() { }

	// RVA: 0x18AAC30 Offset: 0x18A9230 VA: 0x1818AAC30 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x18A8ED0 Offset: 0x18A74D0 VA: 0x1818A8ED0 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x18A8E30 Offset: 0x18A7430 VA: 0x1818A8E30 Slot: 18
	public override int GetByteCount(string chars) { }

	[ComVisibleAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	[CLSCompliantAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	// RVA: 0x18A89E0 Offset: 0x18A6FE0 VA: 0x1818A89E0 Slot: 20
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x18A9060 Offset: 0x18A7660 VA: 0x1818A9060 Slot: 26
	public override int GetBytes(string chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x18A92C0 Offset: 0x18A78C0 VA: 0x1818A92C0 Slot: 24
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[ComVisibleAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	[CLSCompliantAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	// RVA: 0x18A9520 Offset: 0x18A7B20 VA: 0x1818A9520 Slot: 28
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x18A9CA0 Offset: 0x18A82A0 VA: 0x1818A9CA0 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[ComVisibleAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	[CLSCompliantAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	// RVA: 0x18A9BA0 Offset: 0x18A81A0 VA: 0x1818A9BA0 Slot: 30
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x18AA0F0 Offset: 0x18A86F0 VA: 0x1818AA0F0 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x18A9FB0 Offset: 0x18A85B0 VA: 0x1818A9FB0 Slot: 34
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x18AA9F0 Offset: 0x18A8FF0 VA: 0x1818AA9F0 Slot: 43
	public override string GetString(byte[] bytes, int byteIndex, int byteCount) { }

	// RVA: 0x18A8AE0 Offset: 0x18A70E0 VA: 0x1818A8AE0 Slot: 21
	internal override int GetByteCount(char* chars, int charCount, EncoderNLS encoder) { }

	// RVA: 0x18A9660 Offset: 0x18A7C60 VA: 0x1818A9660 Slot: 27
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x18A9E30 Offset: 0x18A8430 VA: 0x1818A9E30 Slot: 31
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x18AA350 Offset: 0x18A8950 VA: 0x1818AA350 Slot: 35
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	// RVA: 0x18AA7B0 Offset: 0x18A8DB0 VA: 0x1818AA7B0 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x18AA8D0 Offset: 0x18A8ED0 VA: 0x1818AA8D0 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 16
	public override bool get_IsSingleByte() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18AA6B0 Offset: 0x18A8CB0 VA: 0x1818AA6B0 Slot: 38
	public override Decoder GetDecoder() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18AA750 Offset: 0x18A8D50 VA: 0x1818AA750 Slot: 39
	public override Encoder GetEncoder() { }

}

