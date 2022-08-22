public class UTF8Encoding : Encoding // TypeDefIndex: 474
{	// Fields
	private bool emitUTF8Identifier; // 0x38
	private bool isThrowException; // 0x39

	// Methods

	// RVA: 0x192D200 Offset: 0x192B800 VA: 0x18192D200
	public void .ctor() { }

	// RVA: 0x192D190 Offset: 0x192B790 VA: 0x18192D190
	public void .ctor(bool encoderShouldEmitUTF8Identifier) { }

	// RVA: 0x192D100 Offset: 0x192B700 VA: 0x18192D100
	public void .ctor(bool encoderShouldEmitUTF8Identifier, bool throwOnInvalidBytes) { }

	// RVA: 0x192D030 Offset: 0x192B630 VA: 0x18192D030 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x192A0F0 Offset: 0x19286F0 VA: 0x18192A0F0 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x192A280 Offset: 0x1928880 VA: 0x18192A280 Slot: 18
	public override int GetByteCount(string chars) { }

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x1929960 Offset: 0x1927F60 VA: 0x181929960 Slot: 20
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x192B150 Offset: 0x1929750 VA: 0x18192B150 Slot: 26
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x192AEF0 Offset: 0x19294F0 VA: 0x18192AEF0 Slot: 24
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[ComVisibleAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	[CLSCompliantAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	// RVA: 0x192B3B0 Offset: 0x19299B0 VA: 0x18192B3B0 Slot: 28
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x192BAE0 Offset: 0x192A0E0 VA: 0x18192BAE0 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x192B9E0 Offset: 0x1929FE0 VA: 0x18192B9E0 Slot: 30
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x192BDB0 Offset: 0x192A3B0 VA: 0x18192BDB0 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x192BC70 Offset: 0x192A270 VA: 0x18192BC70 Slot: 34
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x192CE80 Offset: 0x192B480 VA: 0x18192CE80 Slot: 43
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1929A60 Offset: 0x1928060 VA: 0x181929A60 Slot: 21
	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	// RVA: 0x192D010 Offset: 0x192B610 VA: 0x18192D010
	private static int PtrDiff(char* a, char* b) { }

	// RVA: 0x192D020 Offset: 0x192B620 VA: 0x18192D020
	private static int PtrDiff(byte* a, byte* b) { }

	// RVA: 0xE58900 Offset: 0xE56F00 VA: 0x180E58900
	private static bool InRange(int ch, int start, int end) { }

	// RVA: 0x192A650 Offset: 0x1928C50 VA: 0x18192A650 Slot: 27
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	// RVA: 0x192B4F0 Offset: 0x1929AF0 VA: 0x18192B4F0 Slot: 31
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x192C010 Offset: 0x192A610 VA: 0x18192C010 Slot: 35
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x1929890 Offset: 0x1927E90 VA: 0x181929890
	private bool FallbackInvalidByteSequence(ref byte* pSrc, int ch, DecoderFallbackBuffer fallback, ref char* pTarget) { }

	// RVA: 0x1929910 Offset: 0x1927F10 VA: 0x181929910
	private int FallbackInvalidByteSequence(byte* pSrc, int ch, DecoderFallbackBuffer fallback) { }

	// RVA: 0x192A320 Offset: 0x1928920 VA: 0x18192A320
	private byte[] GetBytesUnknown(ref byte* pSrc, int ch) { }

	// RVA: 0x192CA70 Offset: 0x192B070 VA: 0x18192CA70 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x192CAD0 Offset: 0x192B0D0 VA: 0x18192CAD0 Slot: 39
	public override Encoder GetEncoder() { }

	// RVA: 0x192CBA0 Offset: 0x192B1A0 VA: 0x18192CBA0 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x192CCC0 Offset: 0x192B2C0 VA: 0x18192CCC0 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x192CDE0 Offset: 0x192B3E0 VA: 0x18192CDE0 Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x19297A0 Offset: 0x1927DA0 VA: 0x1819297A0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x192CB30 Offset: 0x192B130 VA: 0x18192CB30 Slot: 2
	public override int GetHashCode() { }

}

internal class UTF8Encoding.UTF8Encoder : EncoderNLS, ISerializable // TypeDefIndex: 475
{	// Fields
	internal int surrogateChar; // 0x38

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x14A5480 Offset: 0x14A3A80 VA: 0x1814A5480
	public void .ctor(UTF8Encoding encoding) { }

	// RVA: 0x14A5220 Offset: 0x14A3820 VA: 0x1814A5220
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x14A5140 Offset: 0x14A3740 VA: 0x1814A5140 Slot: 11
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x14A5110 Offset: 0x14A3710 VA: 0x1814A5110 Slot: 4
	public override void Reset() { }

	// RVA: 0x14A5490 Offset: 0x14A3A90 VA: 0x1814A5490 Slot: 12
	internal override bool get_HasState() { }

}

internal class UTF8Encoding.UTF8Decoder : DecoderNLS, ISerializable // TypeDefIndex: 476
{	// Fields
	internal int bits; // 0x30

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x14A4EA0 Offset: 0x14A34A0 VA: 0x1814A4EA0
	public void .ctor(UTF8Encoding encoding) { }

	// RVA: 0x14A4EB0 Offset: 0x14A34B0 VA: 0x1814A4EB0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x14A4D90 Offset: 0x14A3390 VA: 0x1814A4D90 Slot: 13
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x14A4D60 Offset: 0x14A3360 VA: 0x1814A4D60 Slot: 4
	public override void Reset() { }

	// RVA: 0xF451E0 Offset: 0xF437E0 VA: 0x180F451E0 Slot: 14
	internal override bool get_HasState() { }

}

