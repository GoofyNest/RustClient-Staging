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

	// RVA: 0x4C27F0 Offset: 0x4C0DF0 VA: 0x1804C27F0 Slot: 10
	public override string get_WebName() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0xE4FB90 Offset: 0xE4E190 VA: 0x180E4FB90 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 25
	public override byte[] GetBytes(string s) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 24
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0xE4FBF0 Offset: 0xE4E1F0 VA: 0x180E4FBF0 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0xE4FC20 Offset: 0xE4E220 VA: 0x180E4FC20 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0xE4FC50 Offset: 0xE4E250 VA: 0x180E4FC50 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 36
	public override int get_CodePage() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 39
	public override Encoder GetEncoder() { }

	// RVA: 0xE4FEE0 Offset: 0xE4E4E0 VA: 0x180E4FEE0
	internal static Encoding get_UCS4_Littleendian() { }

	// RVA: 0xE4FE10 Offset: 0xE4E410 VA: 0x180E4FE10
	internal static Encoding get_UCS4_Bigendian() { }

	// RVA: 0xE4FC70 Offset: 0xE4E270 VA: 0x180E4FC70
	internal static Encoding get_UCS4_2143() { }

	// RVA: 0xE4FD40 Offset: 0xE4E340 VA: 0x180E4FD40
	internal static Encoding get_UCS4_3412() { }

	// RVA: 0xE4FC60 Offset: 0xE4E260 VA: 0x180E4FC60
	public void .ctor() { }

}

