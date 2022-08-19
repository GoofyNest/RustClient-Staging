internal class Latin1Encoding : EncodingNLS, ISerializable // TypeDefIndex: 462
{	// Fields
	private static readonly char[] arrayCharBestFit; // 0x2B112D4

	// Properties
	public override bool IsSingleByte { get; }

	// Methods

	// RVA: 0x191D360 Offset: 0x191B960 VA: 0x18191D360
	public void .ctor() { }

	// RVA: 0x191D2D0 Offset: 0x191B8D0 VA: 0x18191D2D0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x191D0E0 Offset: 0x191B6E0 VA: 0x18191D0E0 Slot: 46
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x191C700 Offset: 0x191AD00 VA: 0x18191C700 Slot: 21
	internal override int GetByteCount(char* chars, int charCount, EncoderNLS encoder) { }

	// RVA: 0x191C8F0 Offset: 0x191AEF0 VA: 0x18191C8F0 Slot: 27
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x191CD80 Offset: 0x191B380 VA: 0x18191CD80 Slot: 31
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x191CD90 Offset: 0x191B390 VA: 0x18191CD90 Slot: 35
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	// RVA: 0x191CE90 Offset: 0x191B490 VA: 0x18191CE90 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x191CFB0 Offset: 0x191B5B0 VA: 0x18191CFB0 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 16
	public override bool get_IsSingleByte() { }

	// RVA: 0x191D0D0 Offset: 0x191B6D0 VA: 0x18191D0D0 Slot: 37
	public override bool IsAlwaysNormalized(NormalizationForm form) { }

	// RVA: 0x191C6A0 Offset: 0x191ACA0 VA: 0x18191C6A0 Slot: 44
	internal override char[] GetBestFitUnicodeToBytesData() { }

	// RVA: 0x191D260 Offset: 0x191B860 VA: 0x18191D260
	private static void .cctor() { }

}

