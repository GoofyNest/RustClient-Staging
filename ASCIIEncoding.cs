public class ASCIIEncoding : Encoding // TypeDefIndex: 432
{	// Properties
	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	public override bool IsSingleByte { get; }

	// Methods

	// RVA: 0x18AB2D0 Offset: 0x18A98D0 VA: 0x1818AB2D0
	public void .ctor() { }

	// RVA: 0x18AB290 Offset: 0x18A9890 VA: 0x1818AB290 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x18A9530 Offset: 0x18A7B30 VA: 0x1818A9530 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x18A9490 Offset: 0x18A7A90 VA: 0x1818A9490 Slot: 18
	public override int GetByteCount(string chars) { }

	[ComVisibleAttribute] // RVA: 0x902E0 Offset: 0x8F6E0 VA: 0x1800902E0
	[CLSCompliantAttribute] // RVA: 0x902E0 Offset: 0x8F6E0 VA: 0x1800902E0
	// RVA: 0x18A9040 Offset: 0x18A7640 VA: 0x1818A9040 Slot: 20
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x18A96C0 Offset: 0x18A7CC0 VA: 0x1818A96C0 Slot: 26
	public override int GetBytes(string chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x18A9920 Offset: 0x18A7F20 VA: 0x1818A9920 Slot: 24
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[ComVisibleAttribute] // RVA: 0x902E0 Offset: 0x8F6E0 VA: 0x1800902E0
	[CLSCompliantAttribute] // RVA: 0x902E0 Offset: 0x8F6E0 VA: 0x1800902E0
	// RVA: 0x18A9B80 Offset: 0x18A8180 VA: 0x1818A9B80 Slot: 28
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x18AA300 Offset: 0x18A8900 VA: 0x1818AA300 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[ComVisibleAttribute] // RVA: 0x902E0 Offset: 0x8F6E0 VA: 0x1800902E0
	[CLSCompliantAttribute] // RVA: 0x902E0 Offset: 0x8F6E0 VA: 0x1800902E0
	// RVA: 0x18AA200 Offset: 0x18A8800 VA: 0x1818AA200 Slot: 30
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x18AA750 Offset: 0x18A8D50 VA: 0x1818AA750 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0x90730 Offset: 0x8FB30 VA: 0x180090730
	[ComVisibleAttribute] // RVA: 0x90730 Offset: 0x8FB30 VA: 0x180090730
	// RVA: 0x18AA610 Offset: 0x18A8C10 VA: 0x1818AA610 Slot: 34
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x18AB050 Offset: 0x18A9650 VA: 0x1818AB050 Slot: 43
	public override string GetString(byte[] bytes, int byteIndex, int byteCount) { }

	// RVA: 0x18A9140 Offset: 0x18A7740 VA: 0x1818A9140 Slot: 21
	internal override int GetByteCount(char* chars, int charCount, EncoderNLS encoder) { }

	// RVA: 0x18A9CC0 Offset: 0x18A82C0 VA: 0x1818A9CC0 Slot: 27
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x18AA490 Offset: 0x18A8A90 VA: 0x1818AA490 Slot: 31
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x18AA9B0 Offset: 0x18A8FB0 VA: 0x1818AA9B0 Slot: 35
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	// RVA: 0x18AAE10 Offset: 0x18A9410 VA: 0x1818AAE10 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x18AAF30 Offset: 0x18A9530 VA: 0x1818AAF30 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 16
	public override bool get_IsSingleByte() { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x18AAD10 Offset: 0x18A9310 VA: 0x1818AAD10 Slot: 38
	public override Decoder GetDecoder() { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x18AADB0 Offset: 0x18A93B0 VA: 0x1818AADB0 Slot: 39
	public override Encoder GetEncoder() { }

}

