public abstract class TripleDES : SymmetricAlgorithm // TypeDefIndex: 1000
{	// Fields
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Properties
	public override byte[] Key { get; set; }

	// Methods

	// RVA: 0x17C6A30 Offset: 0x17C5030 VA: 0x1817C6A30
	protected void .ctor() { }

	// RVA: 0x17C6AF0 Offset: 0x17C50F0 VA: 0x1817C6AF0 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x17C6BC0 Offset: 0x17C51C0 VA: 0x1817C6BC0 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x17C6320 Offset: 0x17C4920 VA: 0x1817C6320
	public static TripleDES Create() { }

	// RVA: 0x17C6660 Offset: 0x17C4C60 VA: 0x1817C6660
	public static bool IsWeakKey(byte[] rgbKey) { }

	// RVA: 0x17C6440 Offset: 0x17C4A40 VA: 0x1817C6440
	private static bool EqualBytes(byte[] rgbKey, int start1, int start2, int count) { }

	// RVA: 0x17C6640 Offset: 0x17C4C40 VA: 0x1817C6640
	private static bool IsLegalKeySize(byte[] rgbKey) { }

	// RVA: 0x17C6890 Offset: 0x17C4E90 VA: 0x1817C6890
	private static void .cctor() { }

}

