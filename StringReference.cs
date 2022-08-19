internal struct StringReference // TypeDefIndex: 5936
{	// Fields
	private readonly char[] _chars; // 0x0
	private readonly int _startIndex; // 0x8
	private readonly int _length; // 0xC

	// Properties
	public char Item { get; }
	public char[] Chars { get; }
	public int StartIndex { get; }
	public int Length { get; }

	// Methods

	// RVA: 0x211D70 Offset: 0x211170 VA: 0x180211D70
	public char get_Item(int i) { }

	// RVA: 0xFC8C0 Offset: 0xFBCC0 VA: 0x1800FC8C0
	public char[] get_Chars() { }

	// RVA: 0x122E90 Offset: 0x122290 VA: 0x180122E90
	public int get_StartIndex() { }

	// RVA: 0x1AE4B0 Offset: 0x1AD8B0 VA: 0x1801AE4B0
	public int get_Length() { }

	// RVA: 0xF91A0 Offset: 0xF85A0 VA: 0x1800F91A0
	public void .ctor(char[] chars, int startIndex, int length) { }

	// RVA: 0x211D40 Offset: 0x211140 VA: 0x180211D40 Slot: 3
	public override string ToString() { }

}

