public abstract class DES : SymmetricAlgorithm // TypeDefIndex: 953
{	// Fields
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Properties
	public override byte[] Key { get; set; }

	// Methods

	// RVA: 0x16FF4B0 Offset: 0x16FDAB0 VA: 0x1816FF4B0
	protected void .ctor() { }

	// RVA: 0x16FF560 Offset: 0x16FDB60 VA: 0x1816FF560 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x16FF660 Offset: 0x16FDC60 VA: 0x1816FF660 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x16FEEA0 Offset: 0x16FD4A0 VA: 0x1816FEEA0
	public static DES Create() { }

	// RVA: 0x16FF0C0 Offset: 0x16FD6C0 VA: 0x1816FF0C0
	public static bool IsWeakKey(byte[] rgbKey) { }

	// RVA: 0x16FEF10 Offset: 0x16FD510 VA: 0x1816FEF10
	public static bool IsSemiWeakKey(byte[] rgbKey) { }

	// RVA: 0x16FEEF0 Offset: 0x16FD4F0 VA: 0x1816FEEF0
	private static bool IsLegalKeySize(byte[] rgbKey) { }

	// RVA: 0x16FF1E0 Offset: 0x16FD7E0 VA: 0x1816FF1E0
	private static ulong QuadWordFromBigEndian(byte[] block) { }

	// RVA: 0x16FF320 Offset: 0x16FD920 VA: 0x1816FF320
	private static void .cctor() { }

}

