internal class Latin1Encoding : EncodingNLS, ISerializable // TypeDefIndex: 462
{	// Fields
	private static readonly char[] arrayCharBestFit; // 0x13B64

	// Properties
	public override bool IsSingleByte { get; }

	// Methods

	// RVA: 0x191CD00 Offset: 0x191B300 VA: 0x18191CD00
	public void .ctor() { }

	// RVA: 0x191CC70 Offset: 0x191B270 VA: 0x18191CC70
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x191CA80 Offset: 0x191B080 VA: 0x18191CA80 Slot: 46
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x191C0A0 Offset: 0x191A6A0 VA: 0x18191C0A0 Slot: 21
	internal override int GetByteCount(char* chars, int charCount, EncoderNLS encoder) { }

	// RVA: 0x191C290 Offset: 0x191A890 VA: 0x18191C290 Slot: 27
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x191C720 Offset: 0x191AD20 VA: 0x18191C720 Slot: 31
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x191C730 Offset: 0x191AD30 VA: 0x18191C730 Slot: 35
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	// RVA: 0x191C830 Offset: 0x191AE30 VA: 0x18191C830 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x191C950 Offset: 0x191AF50 VA: 0x18191C950 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 16
	public override bool get_IsSingleByte() { }

	// RVA: 0x191CA70 Offset: 0x191B070 VA: 0x18191CA70 Slot: 37
	public override bool IsAlwaysNormalized(NormalizationForm form) { }

	// RVA: 0x191C040 Offset: 0x191A640 VA: 0x18191C040 Slot: 44
	internal override char[] GetBestFitUnicodeToBytesData() { }

	// RVA: 0x191CC00 Offset: 0x191B200 VA: 0x18191CC00
	private static void .cctor() { }

}

