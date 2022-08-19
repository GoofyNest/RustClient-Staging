public class UTF8Encoding : Encoding // TypeDefIndex: 474
{	// Fields
	private bool emitUTF8Identifier; // 0x38
	private bool isThrowException; // 0x39

	// Methods

	// RVA: 0x192CF80 Offset: 0x192B580 VA: 0x18192CF80
	public void .ctor() { }

	// RVA: 0x192CF10 Offset: 0x192B510 VA: 0x18192CF10
	public void .ctor(bool encoderShouldEmitUTF8Identifier) { }

	// RVA: 0x192CE80 Offset: 0x192B480 VA: 0x18192CE80
	public void .ctor(bool encoderShouldEmitUTF8Identifier, bool throwOnInvalidBytes) { }

	// RVA: 0x192CDB0 Offset: 0x192B3B0 VA: 0x18192CDB0 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x1929E70 Offset: 0x1928470 VA: 0x181929E70 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x192A000 Offset: 0x1928600 VA: 0x18192A000 Slot: 18
	public override int GetByteCount(string chars) { }

	[CLSCompliantAttribute] // RVA: 0x90730 Offset: 0x8FB30 VA: 0x180090730
	[ComVisibleAttribute] // RVA: 0x90730 Offset: 0x8FB30 VA: 0x180090730
	// RVA: 0x19296E0 Offset: 0x1927CE0 VA: 0x1819296E0 Slot: 20
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x192AED0 Offset: 0x19294D0 VA: 0x18192AED0 Slot: 26
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x192AC70 Offset: 0x1929270 VA: 0x18192AC70 Slot: 24
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[ComVisibleAttribute] // RVA: 0x902E0 Offset: 0x8F6E0 VA: 0x1800902E0
	[CLSCompliantAttribute] // RVA: 0x902E0 Offset: 0x8F6E0 VA: 0x1800902E0
	// RVA: 0x192B130 Offset: 0x1929730 VA: 0x18192B130 Slot: 28
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x192B860 Offset: 0x1929E60 VA: 0x18192B860 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0x90730 Offset: 0x8FB30 VA: 0x180090730
	[ComVisibleAttribute] // RVA: 0x90730 Offset: 0x8FB30 VA: 0x180090730
	// RVA: 0x192B760 Offset: 0x1929D60 VA: 0x18192B760 Slot: 30
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x192BB30 Offset: 0x192A130 VA: 0x18192BB30 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0x90730 Offset: 0x8FB30 VA: 0x180090730
	[ComVisibleAttribute] // RVA: 0x90730 Offset: 0x8FB30 VA: 0x180090730
	// RVA: 0x192B9F0 Offset: 0x1929FF0 VA: 0x18192B9F0 Slot: 34
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x192CC00 Offset: 0x192B200 VA: 0x18192CC00 Slot: 43
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x19297E0 Offset: 0x1927DE0 VA: 0x1819297E0 Slot: 21
	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	// RVA: 0x192CD90 Offset: 0x192B390 VA: 0x18192CD90
	private static int PtrDiff(char* a, char* b) { }

	// RVA: 0x192CDA0 Offset: 0x192B3A0 VA: 0x18192CDA0
	private static int PtrDiff(byte* a, byte* b) { }

	// RVA: 0xE58640 Offset: 0xE56C40 VA: 0x180E58640
	private static bool InRange(int ch, int start, int end) { }

	// RVA: 0x192A3D0 Offset: 0x19289D0 VA: 0x18192A3D0 Slot: 27
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	// RVA: 0x192B270 Offset: 0x1929870 VA: 0x18192B270 Slot: 31
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x192BD90 Offset: 0x192A390 VA: 0x18192BD90 Slot: 35
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x1929610 Offset: 0x1927C10 VA: 0x181929610
	private bool FallbackInvalidByteSequence(ref byte* pSrc, int ch, DecoderFallbackBuffer fallback, ref char* pTarget) { }

	// RVA: 0x1929690 Offset: 0x1927C90 VA: 0x181929690
	private int FallbackInvalidByteSequence(byte* pSrc, int ch, DecoderFallbackBuffer fallback) { }

	// RVA: 0x192A0A0 Offset: 0x19286A0 VA: 0x18192A0A0
	private byte[] GetBytesUnknown(ref byte* pSrc, int ch) { }

	// RVA: 0x192C7F0 Offset: 0x192ADF0 VA: 0x18192C7F0 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x192C850 Offset: 0x192AE50 VA: 0x18192C850 Slot: 39
	public override Encoder GetEncoder() { }

	// RVA: 0x192C920 Offset: 0x192AF20 VA: 0x18192C920 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x192CA40 Offset: 0x192B040 VA: 0x18192CA40 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x192CB60 Offset: 0x192B160 VA: 0x18192CB60 Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x1929520 Offset: 0x1927B20 VA: 0x181929520 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x192C8B0 Offset: 0x192AEB0 VA: 0x18192C8B0 Slot: 2
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

