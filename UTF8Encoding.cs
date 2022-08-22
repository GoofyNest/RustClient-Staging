public class UTF8Encoding : Encoding // TypeDefIndex: 474
{	// Fields
	private bool emitUTF8Identifier; // 0x38
	private bool isThrowException; // 0x39

	// Methods

	// RVA: 0x192C920 Offset: 0x192AF20 VA: 0x18192C920
	public void .ctor() { }

	// RVA: 0x192C8B0 Offset: 0x192AEB0 VA: 0x18192C8B0
	public void .ctor(bool encoderShouldEmitUTF8Identifier) { }

	// RVA: 0x192C820 Offset: 0x192AE20 VA: 0x18192C820
	public void .ctor(bool encoderShouldEmitUTF8Identifier, bool throwOnInvalidBytes) { }

	// RVA: 0x192C750 Offset: 0x192AD50 VA: 0x18192C750 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x1929810 Offset: 0x1927E10 VA: 0x181929810 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x19299A0 Offset: 0x1927FA0 VA: 0x1819299A0 Slot: 18
	public override int GetByteCount(string chars) { }

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x1929080 Offset: 0x1927680 VA: 0x181929080 Slot: 20
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x192A870 Offset: 0x1928E70 VA: 0x18192A870 Slot: 26
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x192A610 Offset: 0x1928C10 VA: 0x18192A610 Slot: 24
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[ComVisibleAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	[CLSCompliantAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	// RVA: 0x192AAD0 Offset: 0x19290D0 VA: 0x18192AAD0 Slot: 28
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x192B200 Offset: 0x1929800 VA: 0x18192B200 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x192B100 Offset: 0x1929700 VA: 0x18192B100 Slot: 30
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x192B4D0 Offset: 0x1929AD0 VA: 0x18192B4D0 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x192B390 Offset: 0x1929990 VA: 0x18192B390 Slot: 34
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x192C5A0 Offset: 0x192ABA0 VA: 0x18192C5A0 Slot: 43
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1929180 Offset: 0x1927780 VA: 0x181929180 Slot: 21
	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	// RVA: 0x192C730 Offset: 0x192AD30 VA: 0x18192C730
	private static int PtrDiff(char* a, char* b) { }

	// RVA: 0x192C740 Offset: 0x192AD40 VA: 0x18192C740
	private static int PtrDiff(byte* a, byte* b) { }

	// RVA: 0xE593B0 Offset: 0xE579B0 VA: 0x180E593B0
	private static bool InRange(int ch, int start, int end) { }

	// RVA: 0x1929D70 Offset: 0x1928370 VA: 0x181929D70 Slot: 27
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	// RVA: 0x192AC10 Offset: 0x1929210 VA: 0x18192AC10 Slot: 31
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x192B730 Offset: 0x1929D30 VA: 0x18192B730 Slot: 35
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x1928FB0 Offset: 0x19275B0 VA: 0x181928FB0
	private bool FallbackInvalidByteSequence(ref byte* pSrc, int ch, DecoderFallbackBuffer fallback, ref char* pTarget) { }

	// RVA: 0x1929030 Offset: 0x1927630 VA: 0x181929030
	private int FallbackInvalidByteSequence(byte* pSrc, int ch, DecoderFallbackBuffer fallback) { }

	// RVA: 0x1929A40 Offset: 0x1928040 VA: 0x181929A40
	private byte[] GetBytesUnknown(ref byte* pSrc, int ch) { }

	// RVA: 0x192C190 Offset: 0x192A790 VA: 0x18192C190 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x192C1F0 Offset: 0x192A7F0 VA: 0x18192C1F0 Slot: 39
	public override Encoder GetEncoder() { }

	// RVA: 0x192C2C0 Offset: 0x192A8C0 VA: 0x18192C2C0 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x192C3E0 Offset: 0x192A9E0 VA: 0x18192C3E0 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x192C500 Offset: 0x192AB00 VA: 0x18192C500 Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x1928EC0 Offset: 0x19274C0 VA: 0x181928EC0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x192C250 Offset: 0x192A850 VA: 0x18192C250 Slot: 2
	public override int GetHashCode() { }

}

internal class UTF8Encoding.UTF8Encoder : EncoderNLS, ISerializable // TypeDefIndex: 475
{	// Fields
	internal int surrogateChar; // 0x38

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x14A4550 Offset: 0x14A2B50 VA: 0x1814A4550
	public void .ctor(UTF8Encoding encoding) { }

	// RVA: 0x14A42F0 Offset: 0x14A28F0 VA: 0x1814A42F0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x14A4210 Offset: 0x14A2810 VA: 0x1814A4210 Slot: 11
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x14A41E0 Offset: 0x14A27E0 VA: 0x1814A41E0 Slot: 4
	public override void Reset() { }

	// RVA: 0x14A4560 Offset: 0x14A2B60 VA: 0x1814A4560 Slot: 12
	internal override bool get_HasState() { }

}

internal class UTF8Encoding.UTF8Decoder : DecoderNLS, ISerializable // TypeDefIndex: 476
{	// Fields
	internal int bits; // 0x30

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x14A3F70 Offset: 0x14A2570 VA: 0x1814A3F70
	public void .ctor(UTF8Encoding encoding) { }

	// RVA: 0x14A3F80 Offset: 0x14A2580 VA: 0x1814A3F80
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x14A3E60 Offset: 0x14A2460 VA: 0x1814A3E60 Slot: 13
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x14A3E30 Offset: 0x14A2430 VA: 0x1814A3E30 Slot: 4
	public override void Reset() { }

	// RVA: 0xF45C80 Offset: 0xF44280 VA: 0x180F45C80 Slot: 14
	internal override bool get_HasState() { }

}

