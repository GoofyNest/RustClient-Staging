internal class Ucs4Encoding : Encoding // TypeDefIndex: 2014
{	// Fields
	internal Ucs4Decoder ucs4Decoder; // 0x38

	// Properties
	public override string WebName { get; }
	public override int CodePage { get; }
	internal static Encoding UCS4_Littleendian { get; }
	internal static Encoding UCS4_Bigendian { get; }
	internal static Encoding UCS4_2143 { get; }
	internal static Encoding UCS4_3412 { get; }

	// Methods

	// RVA: 0x4C2860 Offset: 0x4C0E60 VA: 0x1804C2860 Slot: 10
	public override string get_WebName() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0xE4F0E0 Offset: 0xE4D6E0 VA: 0x180E4F0E0 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 25
	public override byte[] GetBytes(string s) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 24
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0xE4F140 Offset: 0xE4D740 VA: 0x180E4F140 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0xE4F170 Offset: 0xE4D770 VA: 0x180E4F170 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0xE4F1A0 Offset: 0xE4D7A0 VA: 0x180E4F1A0 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 36
	public override int get_CodePage() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 39
	public override Encoder GetEncoder() { }

	// RVA: 0xE4F430 Offset: 0xE4DA30 VA: 0x180E4F430
	internal static Encoding get_UCS4_Littleendian() { }

	// RVA: 0xE4F360 Offset: 0xE4D960 VA: 0x180E4F360
	internal static Encoding get_UCS4_Bigendian() { }

	// RVA: 0xE4F1C0 Offset: 0xE4D7C0 VA: 0x180E4F1C0
	internal static Encoding get_UCS4_2143() { }

	// RVA: 0xE4F290 Offset: 0xE4D890 VA: 0x180E4F290
	internal static Encoding get_UCS4_3412() { }

	// RVA: 0xE4F1B0 Offset: 0xE4D7B0 VA: 0x180E4F1B0
	public void .ctor() { }

}

