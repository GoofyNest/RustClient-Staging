internal class KoreanEncoding : DbcsEncoding // TypeDefIndex: 7817
{	// Fields
	private bool useUHC; // 0x40

	// Methods

	// RVA: 0x2253BA0 Offset: 0x22521A0 VA: 0x182253BA0
	public void .ctor(int codepage, bool useUHC) { }

	// RVA: 0x2253AB0 Offset: 0x22520B0 VA: 0x182253AB0 Slot: 48
	internal override DbcsConvert GetConvert() { }

	// RVA: 0x22537E0 Offset: 0x2251DE0 VA: 0x1822537E0 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x22538E0 Offset: 0x2251EE0 VA: 0x1822538E0 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x224CFE0 Offset: 0x224B5E0 VA: 0x18224CFE0 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x224D050 Offset: 0x224B650 VA: 0x18224D050 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x2253B10 Offset: 0x2252110 VA: 0x182253B10 Slot: 38
	public override Decoder GetDecoder() { }

}

private sealed class KoreanEncoding.KoreanDecoder : DbcsEncoding.DbcsDecoder // TypeDefIndex: 7818
{	// Fields
	private bool useUHC; // 0x28
	private int last_byte_count; // 0x2C
	private int last_byte_conv; // 0x30

	// Methods

	// RVA: 0x2253790 Offset: 0x2251D90 VA: 0x182253790
	public void .ctor(DbcsConvert convert, bool useUHC) { }

	// RVA: 0x2253340 Offset: 0x2251940 VA: 0x182253340 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x2253080 Offset: 0x2251680 VA: 0x182253080 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool refresh) { }

	// RVA: 0x2253360 Offset: 0x2251960 VA: 0x182253360 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x2253390 Offset: 0x2251990 VA: 0x182253390 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool refresh) { }

}

