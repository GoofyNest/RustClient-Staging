public class UnicodeEncoding : Encoding // TypeDefIndex: 465
{	// Fields
	[OptionalFieldAttribute] // RVA: 0x92F70 Offset: 0x92370 VA: 0x180092F70
	internal bool isThrowException; // 0x38
	internal bool bigEndian; // 0x39
	internal bool byteOrderMark; // 0x3A
	private static readonly ulong highLowPatternMask; // 0x0

	// Methods

	// RVA: 0x14A8F40 Offset: 0x14A7540 VA: 0x1814A8F40
	public void .ctor() { }

	// RVA: 0x14A8E80 Offset: 0x14A7480 VA: 0x1814A8E80
	public void .ctor(bool bigEndian, bool byteOrderMark) { }

	// RVA: 0x14A8ED0 Offset: 0x14A74D0 VA: 0x1814A8ED0
	public void .ctor(bool bigEndian, bool byteOrderMark, bool throwOnInvalidBytes) { }

	[OnDeserializingAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x14A8D20 Offset: 0x14A7320 VA: 0x1814A8D20
	private void OnDeserializing(StreamingContext ctx) { }

	// RVA: 0x14A8D30 Offset: 0x14A7330 VA: 0x1814A8D30 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x14A5BE0 Offset: 0x14A41E0 VA: 0x1814A5BE0 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x14A5300 Offset: 0x14A3900 VA: 0x1814A5300 Slot: 18
	public override int GetByteCount(string s) { }

	[ComVisibleAttribute] // RVA: 0x902E0 Offset: 0x8F6E0 VA: 0x1800902E0
	[CLSCompliantAttribute] // RVA: 0x902E0 Offset: 0x8F6E0 VA: 0x1800902E0
	// RVA: 0x14A53A0 Offset: 0x14A39A0 VA: 0x1814A53A0 Slot: 20
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x14A66D0 Offset: 0x14A4CD0 VA: 0x1814A66D0 Slot: 26
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x14A6A70 Offset: 0x14A5070 VA: 0x1814A6A70 Slot: 24
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[ComVisibleAttribute] // RVA: 0x902E0 Offset: 0x8F6E0 VA: 0x1800902E0
	[CLSCompliantAttribute] // RVA: 0x902E0 Offset: 0x8F6E0 VA: 0x1800902E0
	// RVA: 0x14A6930 Offset: 0x14A4F30 VA: 0x1814A6930 Slot: 28
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x14A76E0 Offset: 0x14A5CE0 VA: 0x1814A76E0 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0x90730 Offset: 0x8FB30 VA: 0x180090730
	[ComVisibleAttribute] // RVA: 0x90730 Offset: 0x8FB30 VA: 0x180090730
	// RVA: 0x14A6CD0 Offset: 0x14A52D0 VA: 0x1814A6CD0 Slot: 30
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x14A7870 Offset: 0x14A5E70 VA: 0x1814A7870 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0x90730 Offset: 0x8FB30 VA: 0x180090730
	[ComVisibleAttribute] // RVA: 0x90730 Offset: 0x8FB30 VA: 0x180090730
	// RVA: 0x14A7AD0 Offset: 0x14A60D0 VA: 0x1814A7AD0 Slot: 34
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x14A8B90 Offset: 0x14A7190 VA: 0x1814A8B90 Slot: 43
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x14A54A0 Offset: 0x14A3AA0 VA: 0x1814A54A0 Slot: 21
	internal override int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x14A5D70 Offset: 0x14A4370 VA: 0x1814A5D70 Slot: 27
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x14A6DD0 Offset: 0x14A53D0 VA: 0x1814A6DD0 Slot: 31
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x14A7C10 Offset: 0x14A6210 VA: 0x1814A7C10 Slot: 35
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x14A8720 Offset: 0x14A6D20 VA: 0x1814A8720 Slot: 39
	public override Encoder GetEncoder() { }

	// RVA: 0x14A86C0 Offset: 0x14A6CC0 VA: 0x1814A86C0 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x14A8A80 Offset: 0x14A7080 VA: 0x1814A8A80 Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x14A8820 Offset: 0x14A6E20 VA: 0x1814A8820 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x14A8950 Offset: 0x14A6F50 VA: 0x1814A8950 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x14A51E0 Offset: 0x14A37E0 VA: 0x1814A51E0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x14A8780 Offset: 0x14A6D80 VA: 0x1814A8780 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x14A8E00 Offset: 0x14A7400 VA: 0x1814A8E00
	private static void .cctor() { }

}

private class UnicodeEncoding.Decoder : DecoderNLS, ISerializable // TypeDefIndex: 466
{	// Fields
	internal int lastByte; // 0x30
	internal char lastChar; // 0x34

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x1492A10 Offset: 0x1491010 VA: 0x181492A10
	public void .ctor(UnicodeEncoding encoding) { }

	// RVA: 0x1492A20 Offset: 0x1491020 VA: 0x181492A20
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1492890 Offset: 0x1490E90 VA: 0x181492890 Slot: 13
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1492860 Offset: 0x1490E60 VA: 0x181492860 Slot: 4
	public override void Reset() { }

	// RVA: 0x1492D80 Offset: 0x1491380 VA: 0x181492D80 Slot: 14
	internal override bool get_HasState() { }

}

