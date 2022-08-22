internal struct StringBuffer // TypeDefIndex: 5960
{	// Fields
	private char[] _buffer; // 0x0
	private int _position; // 0x8

	// Properties
	public int Position { get; set; }
	public bool IsEmpty { get; }
	public char[] InternalBuffer { get; }

	// Methods

	// RVA: 0x122E10 Offset: 0x122210 VA: 0x180122E10
	public int get_Position() { }

	// RVA: 0x19DF50 Offset: 0x19D350 VA: 0x18019DF50
	public void set_Position(int value) { }

	// RVA: 0x118820 Offset: 0x117C20 VA: 0x180118820
	public bool get_IsEmpty() { }

	// RVA: 0x211AC0 Offset: 0x210EC0 VA: 0x180211AC0
	public void .ctor(IArrayPool<char> bufferPool, int initalSize) { }

	// RVA: 0x211B50 Offset: 0x210F50 VA: 0x180211B50
	private void .ctor(char[] buffer) { }

	// RVA: 0x211670 Offset: 0x210A70 VA: 0x180211670
	public void Append(IArrayPool<char> bufferPool, char value) { }

	// RVA: 0x2117B0 Offset: 0x210BB0 VA: 0x1802117B0
	public void Append(IArrayPool<char> bufferPool, char[] buffer, int startIndex, int count) { }

	// RVA: 0x2118F0 Offset: 0x210CF0 VA: 0x1802118F0
	public void Clear(IArrayPool<char> bufferPool) { }

	// RVA: 0x211980 Offset: 0x210D80 VA: 0x180211980
	private void EnsureSize(IArrayPool<char> bufferPool, int appendLength) { }

	// RVA: 0x211A90 Offset: 0x210E90 VA: 0x180211A90 Slot: 3
	public override string ToString() { }

	// RVA: 0x211A60 Offset: 0x210E60 VA: 0x180211A60
	public string ToString(int start, int length) { }

	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	public char[] get_InternalBuffer() { }

}

