internal class Latin1Encoding : EncodingNLS, ISerializable // TypeDefIndex: 462
{	// Fields
	private static readonly char[] arrayCharBestFit; // 0x2B102F4

	// Properties
	public override bool IsSingleByte { get; }

	// Methods

	// RVA: 0x191D320 Offset: 0x191B920 VA: 0x18191D320
	public void .ctor() { }

	// RVA: 0x191D290 Offset: 0x191B890 VA: 0x18191D290
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x191D0A0 Offset: 0x191B6A0 VA: 0x18191D0A0 Slot: 46
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x191C6C0 Offset: 0x191ACC0 VA: 0x18191C6C0 Slot: 21
	internal override int GetByteCount(char* chars, int charCount, EncoderNLS encoder) { }

	// RVA: 0x191C8B0 Offset: 0x191AEB0 VA: 0x18191C8B0 Slot: 27
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x191CD40 Offset: 0x191B340 VA: 0x18191CD40 Slot: 31
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x191CD50 Offset: 0x191B350 VA: 0x18191CD50 Slot: 35
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	// RVA: 0x191CE50 Offset: 0x191B450 VA: 0x18191CE50 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x191CF70 Offset: 0x191B570 VA: 0x18191CF70 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 16
	public override bool get_IsSingleByte() { }

	// RVA: 0x191D090 Offset: 0x191B690 VA: 0x18191D090 Slot: 37
	public override bool IsAlwaysNormalized(NormalizationForm form) { }

	// RVA: 0x191C660 Offset: 0x191AC60 VA: 0x18191C660 Slot: 44
	internal override char[] GetBestFitUnicodeToBytesData() { }

	// RVA: 0x191D220 Offset: 0x191B820 VA: 0x18191D220
	private static void .cctor() { }

}

