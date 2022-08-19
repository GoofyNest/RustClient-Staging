public abstract class DES : SymmetricAlgorithm // TypeDefIndex: 953
{	// Fields
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Properties
	public override byte[] Key { get; set; }

	// Methods

	// RVA: 0x16FF1F0 Offset: 0x16FD7F0 VA: 0x1816FF1F0
	protected void .ctor() { }

	// RVA: 0x16FF2A0 Offset: 0x16FD8A0 VA: 0x1816FF2A0 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x16FF3A0 Offset: 0x16FD9A0 VA: 0x1816FF3A0 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x16FEBE0 Offset: 0x16FD1E0 VA: 0x1816FEBE0
	public static DES Create() { }

	// RVA: 0x16FEE00 Offset: 0x16FD400 VA: 0x1816FEE00
	public static bool IsWeakKey(byte[] rgbKey) { }

	// RVA: 0x16FEC50 Offset: 0x16FD250 VA: 0x1816FEC50
	public static bool IsSemiWeakKey(byte[] rgbKey) { }

	// RVA: 0x16FEC30 Offset: 0x16FD230 VA: 0x1816FEC30
	private static bool IsLegalKeySize(byte[] rgbKey) { }

	// RVA: 0x16FEF20 Offset: 0x16FD520 VA: 0x1816FEF20
	private static ulong QuadWordFromBigEndian(byte[] block) { }

	// RVA: 0x16FF060 Offset: 0x16FD660 VA: 0x1816FF060
	private static void .cctor() { }

}

