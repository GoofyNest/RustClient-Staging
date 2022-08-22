internal class KoreanEncoding : DbcsEncoding // TypeDefIndex: 7817
{	// Fields
	private bool useUHC; // 0x40

	// Methods

	// RVA: 0x22543C0 Offset: 0x22529C0 VA: 0x1822543C0
	public void .ctor(int codepage, bool useUHC) { }

	// RVA: 0x22542D0 Offset: 0x22528D0 VA: 0x1822542D0 Slot: 48
	internal override DbcsConvert GetConvert() { }

	// RVA: 0x2254000 Offset: 0x2252600 VA: 0x182254000 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x2254100 Offset: 0x2252700 VA: 0x182254100 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x224D800 Offset: 0x224BE00 VA: 0x18224D800 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x224D870 Offset: 0x224BE70 VA: 0x18224D870 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x2254330 Offset: 0x2252930 VA: 0x182254330 Slot: 38
	public override Decoder GetDecoder() { }

}

private sealed class KoreanEncoding.KoreanDecoder : DbcsEncoding.DbcsDecoder // TypeDefIndex: 7818
{	// Fields
	private bool useUHC; // 0x28
	private int last_byte_count; // 0x2C
	private int last_byte_conv; // 0x30

	// Methods

	// RVA: 0x2253FB0 Offset: 0x22525B0 VA: 0x182253FB0
	public void .ctor(DbcsConvert convert, bool useUHC) { }

	// RVA: 0x2253B60 Offset: 0x2252160 VA: 0x182253B60 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x22538A0 Offset: 0x2251EA0 VA: 0x1822538A0 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool refresh) { }

	// RVA: 0x2253B80 Offset: 0x2252180 VA: 0x182253B80 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x2253BB0 Offset: 0x22521B0 VA: 0x182253BB0 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool refresh) { }

}

