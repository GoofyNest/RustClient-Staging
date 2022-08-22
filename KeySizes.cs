public sealed class KeySizes // TypeDefIndex: 943
{	// Fields
	private int m_minSize; // 0x10
	private int m_maxSize; // 0x14
	private int m_skipSize; // 0x18

	// Properties
	public int MinSize { get; }
	public int MaxSize { get; }
	public int SkipSize { get; }

	// Methods

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public int get_MinSize() { }

	// RVA: 0x57C960 Offset: 0x57AF60 VA: 0x18057C960
	public int get_MaxSize() { }

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	public int get_SkipSize() { }

	// RVA: 0xE941F0 Offset: 0xE927F0 VA: 0x180E941F0
	public void .ctor(int minSize, int maxSize, int skipSize) { }

	// RVA: 0x1700840 Offset: 0x16FEE40 VA: 0x181700840
	internal bool IsLegal(int keySize) { }

	// RVA: 0x17007A0 Offset: 0x16FEDA0 VA: 0x1817007A0
	internal static bool IsLegalKeySize(KeySizes[] legalKeys, int size) { }

}

