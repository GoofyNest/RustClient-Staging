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

	// RVA: 0x211CF0 Offset: 0x2110F0 VA: 0x180211CF0
	public char get_Item(int i) { }

	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	public char[] get_Chars() { }

	// RVA: 0x122E10 Offset: 0x122210 VA: 0x180122E10
	public int get_StartIndex() { }

	// RVA: 0x1AE430 Offset: 0x1AD830 VA: 0x1801AE430
	public int get_Length() { }

	// RVA: 0xF9120 Offset: 0xF8520 VA: 0x1800F9120
	public void .ctor(char[] chars, int startIndex, int length) { }

	// RVA: 0x211CC0 Offset: 0x2110C0 VA: 0x180211CC0 Slot: 3
	public override string ToString() { }

}

