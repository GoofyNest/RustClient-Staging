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

	// RVA: 0x211050 Offset: 0x210450 VA: 0x180211050
	public char get_Item(int i) { }

	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	public char[] get_Chars() { }

	// RVA: 0x122C30 Offset: 0x122030 VA: 0x180122C30
	public int get_StartIndex() { }

	// RVA: 0x1AE130 Offset: 0x1AD530 VA: 0x1801AE130
	public int get_Length() { }

	// RVA: 0xF9120 Offset: 0xF8520 VA: 0x1800F9120
	public void .ctor(char[] chars, int startIndex, int length) { }

	// RVA: 0x211020 Offset: 0x210420 VA: 0x180211020 Slot: 3
	public override string ToString() { }

}

