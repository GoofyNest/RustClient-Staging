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

	// RVA: 0x22F5740 Offset: 0x22F3D40 VA: 0x1822F5740
	protected void .ctor(int codePage, int shift, string encodingName, string webName) { }

	// RVA: 0x22F4EC0 Offset: 0x22F34C0 VA: 0x1822F4EC0 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x22F4FF0 Offset: 0x22F35F0 VA: 0x1822F4FF0 Slot: 18
	public override int GetByteCount(string s) { }

	// RVA: 0x22F4E90 Offset: 0x22F3490 VA: 0x1822F4E90 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x22F5060 Offset: 0x22F3660 VA: 0x1822F5060 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x22F5260 Offset: 0x22F3860 VA: 0x1822F5260 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x22F5390 Offset: 0x22F3990 VA: 0x1822F5390 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x22F5640 Offset: 0x22F3C40 VA: 0x1822F5640 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x22F56C0 Offset: 0x22F3CC0 VA: 0x1822F56C0 Slot: 41
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

