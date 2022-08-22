internal class Latin1Encoding : EncodingNLS, ISerializable // TypeDefIndex: 462
{	// Fields
	private static readonly char[] arrayCharBestFit; // 0x2B11334

	// Properties
	public override bool IsSingleByte { get; }

	// Methods

	// RVA: 0x191D5E0 Offset: 0x191BBE0 VA: 0x18191D5E0
	public void .ctor() { }

	// RVA: 0x191D550 Offset: 0x191BB50 VA: 0x18191D550
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x191D360 Offset: 0x191B960 VA: 0x18191D360 Slot: 46
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x191C980 Offset: 0x191AF80 VA: 0x18191C980 Slot: 21
	internal override int GetByteCount(char* chars, int charCount, EncoderNLS encoder) { }

	// RVA: 0x191CB70 Offset: 0x191B170 VA: 0x18191CB70 Slot: 27
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x191D000 Offset: 0x191B600 VA: 0x18191D000 Slot: 31
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x191D010 Offset: 0x191B610 VA: 0x18191D010 Slot: 35
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	// RVA: 0x191D110 Offset: 0x191B710 VA: 0x18191D110 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x191D230 Offset: 0x191B830 VA: 0x18191D230 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 16
	public override bool get_IsSingleByte() { }

	// RVA: 0x191D350 Offset: 0x191B950 VA: 0x18191D350 Slot: 37
	public override bool IsAlwaysNormalized(NormalizationForm form) { }

	// RVA: 0x191C920 Offset: 0x191AF20 VA: 0x18191C920 Slot: 44
	internal override char[] GetBestFitUnicodeToBytesData() { }

	// RVA: 0x191D4E0 Offset: 0x191BAE0 VA: 0x18191D4E0
	private static void .cctor() { }

}

