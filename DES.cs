public abstract class DES : SymmetricAlgorithm // TypeDefIndex: 953
{	// Fields
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Properties
	public override byte[] Key { get; set; }

	// Methods

	// RVA: 0x16FD0A0 Offset: 0x16FB6A0 VA: 0x1816FD0A0
	protected void .ctor() { }

	// RVA: 0x16FD150 Offset: 0x16FB750 VA: 0x1816FD150 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x16FD250 Offset: 0x16FB850 VA: 0x1816FD250 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x16FCA90 Offset: 0x16FB090 VA: 0x1816FCA90
	public static DES Create() { }

	// RVA: 0x16FCCB0 Offset: 0x16FB2B0 VA: 0x1816FCCB0
	public static bool IsWeakKey(byte[] rgbKey) { }

	// RVA: 0x16FCB00 Offset: 0x16FB100 VA: 0x1816FCB00
	public static bool IsSemiWeakKey(byte[] rgbKey) { }

	// RVA: 0x16FCAE0 Offset: 0x16FB0E0 VA: 0x1816FCAE0
	private static bool IsLegalKeySize(byte[] rgbKey) { }

	// RVA: 0x16FCDD0 Offset: 0x16FB3D0 VA: 0x1816FCDD0
	private static ulong QuadWordFromBigEndian(byte[] block) { }

	// RVA: 0x16FCF10 Offset: 0x16FB510 VA: 0x1816FCF10
	private static void .cctor() { }

}

