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

	// RVA: 0x22F5A00 Offset: 0x22F4000 VA: 0x1822F5A00
	protected void .ctor(int codePage, int shift, string encodingName, string webName) { }

	// RVA: 0x22F5180 Offset: 0x22F3780 VA: 0x1822F5180 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x22F52B0 Offset: 0x22F38B0 VA: 0x1822F52B0 Slot: 18
	public override int GetByteCount(string s) { }

	// RVA: 0x22F5150 Offset: 0x22F3750 VA: 0x1822F5150 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x22F5320 Offset: 0x22F3920 VA: 0x1822F5320 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x22F5520 Offset: 0x22F3B20 VA: 0x1822F5520 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x22F5650 Offset: 0x22F3C50 VA: 0x1822F5650 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x22F5900 Offset: 0x22F3F00 VA: 0x1822F5900 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x22F5980 Offset: 0x22F3F80 VA: 0x1822F5980 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870 Slot: 10
	public override string get_WebName() { }

}

