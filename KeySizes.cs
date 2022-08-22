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

	// RVA: 0x57C9D0 Offset: 0x57AFD0 VA: 0x18057C9D0
	public int get_MaxSize() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public int get_SkipSize() { }

	// RVA: 0xE93740 Offset: 0xE91D40 VA: 0x180E93740
	public void .ctor(int minSize, int maxSize, int skipSize) { }

	// RVA: 0x1702C50 Offset: 0x1701250 VA: 0x181702C50
	internal bool IsLegal(int keySize) { }

	// RVA: 0x1702BB0 Offset: 0x17011B0 VA: 0x181702BB0
	internal static bool IsLegalKeySize(KeySizes[] legalKeys, int size) { }

}

