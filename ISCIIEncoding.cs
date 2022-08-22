public abstract class ISCIIEncoding : MonoEncoding // TypeDefIndex: 7872
{	// Fields
	private int shift; // 0x40
	private string encodingName; // 0x48
	private string webName; // 0x50

	// Properties
	public override string BodyName { get; }
	public override string EncodingName { get; }
	public override string HeaderName { get; }
	public override string WebName { get; }

	// Methods

	// RVA: 0x22F6220 Offset: 0x22F4820 VA: 0x1822F6220
	protected void .ctor(int codePage, int shift, string encodingName, string webName) { }

	// RVA: 0x22F59A0 Offset: 0x22F3FA0 VA: 0x1822F59A0 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x22F5AD0 Offset: 0x22F40D0 VA: 0x1822F5AD0 Slot: 18
	public override int GetByteCount(string s) { }

	// RVA: 0x22F5970 Offset: 0x22F3F70 VA: 0x1822F5970 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x22F5B40 Offset: 0x22F4140 VA: 0x1822F5B40 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x22F5D40 Offset: 0x22F4340 VA: 0x1822F5D40 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x22F5E70 Offset: 0x22F4470 VA: 0x1822F5E70 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x22F6120 Offset: 0x22F4720 VA: 0x1822F6120 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x22F61A0 Offset: 0x22F47A0 VA: 0x1822F61A0 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800 Slot: 10
	public override string get_WebName() { }

}

