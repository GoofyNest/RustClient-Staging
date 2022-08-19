internal class KoreanEncoding : DbcsEncoding // TypeDefIndex: 7817
{	// Fields
	private bool useUHC; // 0x40

	// Methods

	// RVA: 0x2253AA0 Offset: 0x22520A0 VA: 0x182253AA0
	public void .ctor(int codepage, bool useUHC) { }

	// RVA: 0x22539B0 Offset: 0x2251FB0 VA: 0x1822539B0 Slot: 48
	internal override DbcsConvert GetConvert() { }

	// RVA: 0x22536E0 Offset: 0x2251CE0 VA: 0x1822536E0 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x22537E0 Offset: 0x2251DE0 VA: 0x1822537E0 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x224CEE0 Offset: 0x224B4E0 VA: 0x18224CEE0 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x224CF50 Offset: 0x224B550 VA: 0x18224CF50 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x2253A10 Offset: 0x2252010 VA: 0x182253A10 Slot: 38
	public override Decoder GetDecoder() { }

}

private sealed class KoreanEncoding.KoreanDecoder : DbcsEncoding.DbcsDecoder // TypeDefIndex: 7818
{	// Fields
	private bool useUHC; // 0x28
	private int last_byte_count; // 0x2C
	private int last_byte_conv; // 0x30

	// Methods

	// RVA: 0x2253690 Offset: 0x2251C90 VA: 0x182253690
	public void .ctor(DbcsConvert convert, bool useUHC) { }

	// RVA: 0x2253240 Offset: 0x2251840 VA: 0x182253240 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x2252F80 Offset: 0x2251580 VA: 0x182252F80 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool refresh) { }

	// RVA: 0x2253260 Offset: 0x2251860 VA: 0x182253260 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x2253290 Offset: 0x2251890 VA: 0x182253290 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool refresh) { }

}

