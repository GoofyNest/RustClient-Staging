internal struct StringBuffer // TypeDefIndex: 5960
{	// Fields
	private char[] _buffer; // 0x0
	private int _position; // 0x8

	// Properties
	public int Position { get; set; }
	public bool IsEmpty { get; }
	public char[] InternalBuffer { get; }

	// Methods

	// RVA: 0x122C30 Offset: 0x122030 VA: 0x180122C30
	public int get_Position() { }

	// RVA: 0x19DC40 Offset: 0x19D040 VA: 0x18019DC40
	public void set_Position(int value) { }

	// RVA: 0x118820 Offset: 0x117C20 VA: 0x180118820
	public bool get_IsEmpty() { }

	// RVA: 0x210E20 Offset: 0x210220 VA: 0x180210E20
	public void .ctor(IArrayPool<char> bufferPool, int initalSize) { }

	// RVA: 0x210EB0 Offset: 0x2102B0 VA: 0x180210EB0
	private void .ctor(char[] buffer) { }

	// RVA: 0x2109D0 Offset: 0x20FDD0 VA: 0x1802109D0
	public void Append(IArrayPool<char> bufferPool, char value) { }

	// RVA: 0x210B10 Offset: 0x20FF10 VA: 0x180210B10
	public void Append(IArrayPool<char> bufferPool, char[] buffer, int startIndex, int count) { }

	// RVA: 0x210C50 Offset: 0x210050 VA: 0x180210C50
	public void Clear(IArrayPool<char> bufferPool) { }

	// RVA: 0x210CE0 Offset: 0x2100E0 VA: 0x180210CE0
	private void EnsureSize(IArrayPool<char> bufferPool, int appendLength) { }

	// RVA: 0x210DF0 Offset: 0x2101F0 VA: 0x180210DF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x210DC0 Offset: 0x2101C0 VA: 0x180210DC0
	public string ToString(int start, int length) { }

	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	public char[] get_InternalBuffer() { }

}

