public class UnicodeEncoding : Encoding // TypeDefIndex: 465
{	// Fields
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	internal bool isThrowException; // 0x38
	internal bool bigEndian; // 0x39
	internal bool byteOrderMark; // 0x3A
	private static readonly ulong highLowPatternMask; // 0x0

	// Methods

	// RVA: 0x14A82D0 Offset: 0x14A68D0 VA: 0x1814A82D0
	public void .ctor() { }

	// RVA: 0x14A8210 Offset: 0x14A6810 VA: 0x1814A8210
	public void .ctor(bool bigEndian, bool byteOrderMark) { }

	// RVA: 0x14A8260 Offset: 0x14A6860 VA: 0x1814A8260
	public void .ctor(bool bigEndian, bool byteOrderMark, bool throwOnInvalidBytes) { }

	[OnDeserializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14A80B0 Offset: 0x14A66B0 VA: 0x1814A80B0
	private void OnDeserializing(StreamingContext ctx) { }

	// RVA: 0x14A80C0 Offset: 0x14A66C0 VA: 0x1814A80C0 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x14A4F70 Offset: 0x14A3570 VA: 0x1814A4F70 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x14A4690 Offset: 0x14A2C90 VA: 0x1814A4690 Slot: 18
	public override int GetByteCount(string s) { }

	[ComVisibleAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	[CLSCompliantAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	// RVA: 0x14A4730 Offset: 0x14A2D30 VA: 0x1814A4730 Slot: 20
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x14A5A60 Offset: 0x14A4060 VA: 0x1814A5A60 Slot: 26
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x14A5E00 Offset: 0x14A4400 VA: 0x1814A5E00 Slot: 24
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[ComVisibleAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	[CLSCompliantAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	// RVA: 0x14A5CC0 Offset: 0x14A42C0 VA: 0x1814A5CC0 Slot: 28
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x14A6A70 Offset: 0x14A5070 VA: 0x1814A6A70 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x14A6060 Offset: 0x14A4660 VA: 0x1814A6060 Slot: 30
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x14A6C00 Offset: 0x14A5200 VA: 0x1814A6C00 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x14A6E60 Offset: 0x14A5460 VA: 0x1814A6E60 Slot: 34
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x14A7F20 Offset: 0x14A6520 VA: 0x1814A7F20 Slot: 43
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x14A4830 Offset: 0x14A2E30 VA: 0x1814A4830 Slot: 21
	internal override int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x14A5100 Offset: 0x14A3700 VA: 0x1814A5100 Slot: 27
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x14A6160 Offset: 0x14A4760 VA: 0x1814A6160 Slot: 31
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x14A6FA0 Offset: 0x14A55A0 VA: 0x1814A6FA0 Slot: 35
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x14A7AB0 Offset: 0x14A60B0 VA: 0x1814A7AB0 Slot: 39
	public override Encoder GetEncoder() { }

	// RVA: 0x14A7A50 Offset: 0x14A6050 VA: 0x1814A7A50 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x14A7E10 Offset: 0x14A6410 VA: 0x1814A7E10 Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x14A7BB0 Offset: 0x14A61B0 VA: 0x1814A7BB0 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x14A7CE0 Offset: 0x14A62E0 VA: 0x1814A7CE0 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x14A4570 Offset: 0x14A2B70 VA: 0x1814A4570 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x14A7B10 Offset: 0x14A6110 VA: 0x1814A7B10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x14A8190 Offset: 0x14A6790 VA: 0x1814A8190
	private static void .cctor() { }

}

private class UnicodeEncoding.Decoder : DecoderNLS, ISerializable // TypeDefIndex: 466
{	// Fields
	internal int lastByte; // 0x30
	internal char lastChar; // 0x34

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x1491DA0 Offset: 0x14903A0 VA: 0x181491DA0
	public void .ctor(UnicodeEncoding encoding) { }

	// RVA: 0x1491DB0 Offset: 0x14903B0 VA: 0x181491DB0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1491C20 Offset: 0x1490220 VA: 0x181491C20 Slot: 13
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1491BF0 Offset: 0x14901F0 VA: 0x181491BF0 Slot: 4
	public override void Reset() { }

	// RVA: 0x1492110 Offset: 0x1490710 VA: 0x181492110 Slot: 14
	internal override bool get_HasState() { }

}

