public abstract class TripleDES : SymmetricAlgorithm // TypeDefIndex: 1000
{	// Fields
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Properties
	public override byte[] Key { get; set; }

	// Methods

	// RVA: 0x17C8EE0 Offset: 0x17C74E0 VA: 0x1817C8EE0
	protected void .ctor() { }

	// RVA: 0x17C8FA0 Offset: 0x17C75A0 VA: 0x1817C8FA0 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x17C9070 Offset: 0x17C7670 VA: 0x1817C9070 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x17C87D0 Offset: 0x17C6DD0 VA: 0x1817C87D0
	public static TripleDES Create() { }

	// RVA: 0x17C8B10 Offset: 0x17C7110 VA: 0x1817C8B10
	public static bool IsWeakKey(byte[] rgbKey) { }

	// RVA: 0x17C88F0 Offset: 0x17C6EF0 VA: 0x1817C88F0
	private static bool EqualBytes(byte[] rgbKey, int start1, int start2, int count) { }

	// RVA: 0x17C8AF0 Offset: 0x17C70F0 VA: 0x1817C8AF0
	private static bool IsLegalKeySize(byte[] rgbKey) { }

	// RVA: 0x17C8D40 Offset: 0x17C7340 VA: 0x1817C8D40
	private static void .cctor() { }

}

