internal class KoreanEncoding : DbcsEncoding // TypeDefIndex: 7817
{	// Fields
	private bool useUHC; // 0x40

	// Methods

	// RVA: 0x22538E0 Offset: 0x2251EE0 VA: 0x1822538E0
	public void .ctor(int codepage, bool useUHC) { }

	// RVA: 0x22537F0 Offset: 0x2251DF0 VA: 0x1822537F0 Slot: 48
	internal override DbcsConvert GetConvert() { }

	// RVA: 0x2253520 Offset: 0x2251B20 VA: 0x182253520 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x2253620 Offset: 0x2251C20 VA: 0x182253620 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x224CD20 Offset: 0x224B320 VA: 0x18224CD20 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x224CD90 Offset: 0x224B390 VA: 0x18224CD90 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x2253850 Offset: 0x2251E50 VA: 0x182253850 Slot: 38
	public override Decoder GetDecoder() { }

}

private sealed class KoreanEncoding.KoreanDecoder : DbcsEncoding.DbcsDecoder // TypeDefIndex: 7818
{	// Fields
	private bool useUHC; // 0x28
	private int last_byte_count; // 0x2C
	private int last_byte_conv; // 0x30

	// Methods

	// RVA: 0x22534D0 Offset: 0x2251AD0 VA: 0x1822534D0
	public void .ctor(DbcsConvert convert, bool useUHC) { }

	// RVA: 0x2253080 Offset: 0x2251680 VA: 0x182253080 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x2252DC0 Offset: 0x22513C0 VA: 0x182252DC0 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool refresh) { }

	// RVA: 0x22530A0 Offset: 0x22516A0 VA: 0x1822530A0 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x22530D0 Offset: 0x22516D0 VA: 0x1822530D0 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool refresh) { }

}

