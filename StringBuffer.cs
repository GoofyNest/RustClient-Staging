internal struct StringBuffer // TypeDefIndex: 5960
{	// Fields
	private char[] _buffer; // 0x0
	private int _position; // 0x8

	// Properties
	public int Position { get; set; }
	public bool IsEmpty { get; }
	public char[] InternalBuffer { get; }

	// Methods

	// RVA: 0x122E90 Offset: 0x122290 VA: 0x180122E90
	public int get_Position() { }

	// RVA: 0x19DFD0 Offset: 0x19D3D0 VA: 0x18019DFD0
	public void set_Position(int value) { }

	// RVA: 0x1188A0 Offset: 0x117CA0 VA: 0x1801188A0
	public bool get_IsEmpty() { }

	// RVA: 0x211B40 Offset: 0x210F40 VA: 0x180211B40
	public void .ctor(IArrayPool<char> bufferPool, int initalSize) { }

	// RVA: 0x211BD0 Offset: 0x210FD0 VA: 0x180211BD0
	private void .ctor(char[] buffer) { }

	// RVA: 0x2116F0 Offset: 0x210AF0 VA: 0x1802116F0
	public void Append(IArrayPool<char> bufferPool, char value) { }

	// RVA: 0x211830 Offset: 0x210C30 VA: 0x180211830
	public void Append(IArrayPool<char> bufferPool, char[] buffer, int startIndex, int count) { }

	// RVA: 0x211970 Offset: 0x210D70 VA: 0x180211970
	public void Clear(IArrayPool<char> bufferPool) { }

	// RVA: 0x211A00 Offset: 0x210E00 VA: 0x180211A00
	private void EnsureSize(IArrayPool<char> bufferPool, int appendLength) { }

	// RVA: 0x211B10 Offset: 0x210F10 VA: 0x180211B10 Slot: 3
	public override string ToString() { }

	// RVA: 0x211AE0 Offset: 0x210EE0 VA: 0x180211AE0
	public string ToString(int start, int length) { }

	// RVA: 0xFC8C0 Offset: 0xFBCC0 VA: 0x1800FC8C0
	public char[] get_InternalBuffer() { }

}

