public class UnicodeEncoding : Encoding // TypeDefIndex: 465
{	// Fields
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	internal bool isThrowException; // 0x38
	internal bool bigEndian; // 0x39
	internal bool byteOrderMark; // 0x3A
	private static readonly ulong highLowPatternMask; // 0x0

	// Methods

	// RVA: 0x14A9200 Offset: 0x14A7800 VA: 0x1814A9200
	public void .ctor() { }

	// RVA: 0x14A9140 Offset: 0x14A7740 VA: 0x1814A9140
	public void .ctor(bool bigEndian, bool byteOrderMark) { }

	// RVA: 0x14A9190 Offset: 0x14A7790 VA: 0x1814A9190
	public void .ctor(bool bigEndian, bool byteOrderMark, bool throwOnInvalidBytes) { }

	[OnDeserializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14A8FE0 Offset: 0x14A75E0 VA: 0x1814A8FE0
	private void OnDeserializing(StreamingContext ctx) { }

	// RVA: 0x14A8FF0 Offset: 0x14A75F0 VA: 0x1814A8FF0 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x14A5EA0 Offset: 0x14A44A0 VA: 0x1814A5EA0 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x14A55C0 Offset: 0x14A3BC0 VA: 0x1814A55C0 Slot: 18
	public override int GetByteCount(string s) { }

	[ComVisibleAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	[CLSCompliantAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	// RVA: 0x14A5660 Offset: 0x14A3C60 VA: 0x1814A5660 Slot: 20
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x14A6990 Offset: 0x14A4F90 VA: 0x1814A6990 Slot: 26
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x14A6D30 Offset: 0x14A5330 VA: 0x1814A6D30 Slot: 24
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[ComVisibleAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	[CLSCompliantAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	// RVA: 0x14A6BF0 Offset: 0x14A51F0 VA: 0x1814A6BF0 Slot: 28
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x14A79A0 Offset: 0x14A5FA0 VA: 0x1814A79A0 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x14A6F90 Offset: 0x14A5590 VA: 0x1814A6F90 Slot: 30
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x14A7B30 Offset: 0x14A6130 VA: 0x1814A7B30 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x14A7D90 Offset: 0x14A6390 VA: 0x1814A7D90 Slot: 34
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x14A8E50 Offset: 0x14A7450 VA: 0x1814A8E50 Slot: 43
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x14A5760 Offset: 0x14A3D60 VA: 0x1814A5760 Slot: 21
	internal override int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x14A6030 Offset: 0x14A4630 VA: 0x1814A6030 Slot: 27
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x14A7090 Offset: 0x14A5690 VA: 0x1814A7090 Slot: 31
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x14A7ED0 Offset: 0x14A64D0 VA: 0x1814A7ED0 Slot: 35
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x14A89E0 Offset: 0x14A6FE0 VA: 0x1814A89E0 Slot: 39
	public override Encoder GetEncoder() { }

	// RVA: 0x14A8980 Offset: 0x14A6F80 VA: 0x1814A8980 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x14A8D40 Offset: 0x14A7340 VA: 0x1814A8D40 Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x14A8AE0 Offset: 0x14A70E0 VA: 0x1814A8AE0 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x14A8C10 Offset: 0x14A7210 VA: 0x1814A8C10 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x14A54A0 Offset: 0x14A3AA0 VA: 0x1814A54A0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x14A8A40 Offset: 0x14A7040 VA: 0x1814A8A40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x14A90C0 Offset: 0x14A76C0 VA: 0x1814A90C0
	private static void .cctor() { }

}

private class UnicodeEncoding.Decoder : DecoderNLS, ISerializable // TypeDefIndex: 466
{	// Fields
	internal int lastByte; // 0x30
	internal char lastChar; // 0x34

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x1492CD0 Offset: 0x14912D0 VA: 0x181492CD0
	public void .ctor(UnicodeEncoding encoding) { }

	// RVA: 0x1492CE0 Offset: 0x14912E0 VA: 0x181492CE0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1492B50 Offset: 0x1491150 VA: 0x181492B50 Slot: 13
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1492B20 Offset: 0x1491120 VA: 0x181492B20 Slot: 4
	public override void Reset() { }

	// RVA: 0x1493040 Offset: 0x1491640 VA: 0x181493040 Slot: 14
	internal override bool get_HasState() { }

}

