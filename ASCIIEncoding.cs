public class ASCIIEncoding : Encoding // TypeDefIndex: 432
{	// Properties
	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public override bool IsSingleByte { get; }

	// Methods

	// RVA: 0x18AB290 Offset: 0x18A9890 VA: 0x1818AB290
	public void .ctor() { }

	// RVA: 0x18AB250 Offset: 0x18A9850 VA: 0x1818AB250 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x18A94F0 Offset: 0x18A7AF0 VA: 0x1818A94F0 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x18A9450 Offset: 0x18A7A50 VA: 0x1818A9450 Slot: 18
	public override int GetByteCount(string chars) { }

	[ComVisibleAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	[CLSCompliantAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	// RVA: 0x18A9000 Offset: 0x18A7600 VA: 0x1818A9000 Slot: 20
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x18A9680 Offset: 0x18A7C80 VA: 0x1818A9680 Slot: 26
	public override int GetBytes(string chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x18A98E0 Offset: 0x18A7EE0 VA: 0x1818A98E0 Slot: 24
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[ComVisibleAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	[CLSCompliantAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	// RVA: 0x18A9B40 Offset: 0x18A8140 VA: 0x1818A9B40 Slot: 28
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x18AA2C0 Offset: 0x18A88C0 VA: 0x1818AA2C0 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[ComVisibleAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	[CLSCompliantAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	// RVA: 0x18AA1C0 Offset: 0x18A87C0 VA: 0x1818AA1C0 Slot: 30
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x18AA710 Offset: 0x18A8D10 VA: 0x1818AA710 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x18AA5D0 Offset: 0x18A8BD0 VA: 0x1818AA5D0 Slot: 34
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x18AB010 Offset: 0x18A9610 VA: 0x1818AB010 Slot: 43
	public override string GetString(byte[] bytes, int byteIndex, int byteCount) { }

	// RVA: 0x18A9100 Offset: 0x18A7700 VA: 0x1818A9100 Slot: 21
	internal override int GetByteCount(char* chars, int charCount, EncoderNLS encoder) { }

	// RVA: 0x18A9C80 Offset: 0x18A8280 VA: 0x1818A9C80 Slot: 27
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x18AA450 Offset: 0x18A8A50 VA: 0x1818AA450 Slot: 31
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x18AA970 Offset: 0x18A8F70 VA: 0x1818AA970 Slot: 35
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	// RVA: 0x18AADD0 Offset: 0x18A93D0 VA: 0x1818AADD0 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x18AAEF0 Offset: 0x18A94F0 VA: 0x1818AAEF0 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 16
	public override bool get_IsSingleByte() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18AACD0 Offset: 0x18A92D0 VA: 0x1818AACD0 Slot: 38
	public override Decoder GetDecoder() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18AAD70 Offset: 0x18A9370 VA: 0x1818AAD70 Slot: 39
	public override Encoder GetEncoder() { }

}

