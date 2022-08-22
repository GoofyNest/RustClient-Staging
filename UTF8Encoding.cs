public class UTF8Encoding : Encoding // TypeDefIndex: 474
{	// Fields
	private bool emitUTF8Identifier; // 0x38
	private bool isThrowException; // 0x39

	// Methods

	// RVA: 0x192CF40 Offset: 0x192B540 VA: 0x18192CF40
	public void .ctor() { }

	// RVA: 0x192CED0 Offset: 0x192B4D0 VA: 0x18192CED0
	public void .ctor(bool encoderShouldEmitUTF8Identifier) { }

	// RVA: 0x192CE40 Offset: 0x192B440 VA: 0x18192CE40
	public void .ctor(bool encoderShouldEmitUTF8Identifier, bool throwOnInvalidBytes) { }

	// RVA: 0x192CD70 Offset: 0x192B370 VA: 0x18192CD70 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x1929E30 Offset: 0x1928430 VA: 0x181929E30 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x1929FC0 Offset: 0x19285C0 VA: 0x181929FC0 Slot: 18
	public override int GetByteCount(string chars) { }

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x19296A0 Offset: 0x1927CA0 VA: 0x1819296A0 Slot: 20
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x192AE90 Offset: 0x1929490 VA: 0x18192AE90 Slot: 26
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x192AC30 Offset: 0x1929230 VA: 0x18192AC30 Slot: 24
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[ComVisibleAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	[CLSCompliantAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	// RVA: 0x192B0F0 Offset: 0x19296F0 VA: 0x18192B0F0 Slot: 28
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x192B820 Offset: 0x1929E20 VA: 0x18192B820 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x192B720 Offset: 0x1929D20 VA: 0x18192B720 Slot: 30
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x192BAF0 Offset: 0x192A0F0 VA: 0x18192BAF0 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x192B9B0 Offset: 0x1929FB0 VA: 0x18192B9B0 Slot: 34
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x192CBC0 Offset: 0x192B1C0 VA: 0x18192CBC0 Slot: 43
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x19297A0 Offset: 0x1927DA0 VA: 0x1819297A0 Slot: 21
	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	// RVA: 0x192CD50 Offset: 0x192B350 VA: 0x18192CD50
	private static int PtrDiff(char* a, char* b) { }

	// RVA: 0x192CD60 Offset: 0x192B360 VA: 0x18192CD60
	private static int PtrDiff(byte* a, byte* b) { }

	// RVA: 0xE58640 Offset: 0xE56C40 VA: 0x180E58640
	private static bool InRange(int ch, int start, int end) { }

	// RVA: 0x192A390 Offset: 0x1928990 VA: 0x18192A390 Slot: 27
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	// RVA: 0x192B230 Offset: 0x1929830 VA: 0x18192B230 Slot: 31
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x192BD50 Offset: 0x192A350 VA: 0x18192BD50 Slot: 35
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x19295D0 Offset: 0x1927BD0 VA: 0x1819295D0
	private bool FallbackInvalidByteSequence(ref byte* pSrc, int ch, DecoderFallbackBuffer fallback, ref char* pTarget) { }

	// RVA: 0x1929650 Offset: 0x1927C50 VA: 0x181929650
	private int FallbackInvalidByteSequence(byte* pSrc, int ch, DecoderFallbackBuffer fallback) { }

	// RVA: 0x192A060 Offset: 0x1928660 VA: 0x18192A060
	private byte[] GetBytesUnknown(ref byte* pSrc, int ch) { }

	// RVA: 0x192C7B0 Offset: 0x192ADB0 VA: 0x18192C7B0 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x192C810 Offset: 0x192AE10 VA: 0x18192C810 Slot: 39
	public override Encoder GetEncoder() { }

	// RVA: 0x192C8E0 Offset: 0x192AEE0 VA: 0x18192C8E0 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x192CA00 Offset: 0x192B000 VA: 0x18192CA00 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x192CB20 Offset: 0x192B120 VA: 0x18192CB20 Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x19294E0 Offset: 0x1927AE0 VA: 0x1819294E0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x192C870 Offset: 0x192AE70 VA: 0x18192C870 Slot: 2
	public override int GetHashCode() { }

}

internal class UTF8Encoding.UTF8Encoder : EncoderNLS, ISerializable // TypeDefIndex: 475
{	// Fields
	internal int surrogateChar; // 0x38

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x14A51C0 Offset: 0x14A37C0 VA: 0x1814A51C0
	public void .ctor(UTF8Encoding encoding) { }

	// RVA: 0x14A4F60 Offset: 0x14A3560 VA: 0x1814A4F60
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x14A4E80 Offset: 0x14A3480 VA: 0x1814A4E80 Slot: 11
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x14A4E50 Offset: 0x14A3450 VA: 0x1814A4E50 Slot: 4
	public override void Reset() { }

	// RVA: 0x14A51D0 Offset: 0x14A37D0 VA: 0x1814A51D0 Slot: 12
	internal override bool get_HasState() { }

}

internal class UTF8Encoding.UTF8Decoder : DecoderNLS, ISerializable // TypeDefIndex: 476
{	// Fields
	internal int bits; // 0x30

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x14A4BE0 Offset: 0x14A31E0 VA: 0x1814A4BE0
	public void .ctor(UTF8Encoding encoding) { }

	// RVA: 0x14A4BF0 Offset: 0x14A31F0 VA: 0x1814A4BF0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x14A4AD0 Offset: 0x14A30D0 VA: 0x1814A4AD0 Slot: 13
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x14A4AA0 Offset: 0x14A30A0 VA: 0x1814A4AA0 Slot: 4
	public override void Reset() { }

	// RVA: 0xF44F20 Offset: 0xF43520 VA: 0x180F44F20 Slot: 14
	internal override bool get_HasState() { }

}

