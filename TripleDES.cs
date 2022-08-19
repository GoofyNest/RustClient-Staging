public abstract class TripleDES : SymmetricAlgorithm // TypeDefIndex: 1000
{	// Fields
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Properties
	public override byte[] Key { get; set; }

	// Methods

	// RVA: 0x17C8C20 Offset: 0x17C7220 VA: 0x1817C8C20
	protected void .ctor() { }

	// RVA: 0x17C8CE0 Offset: 0x17C72E0 VA: 0x1817C8CE0 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x17C8DB0 Offset: 0x17C73B0 VA: 0x1817C8DB0 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x17C8510 Offset: 0x17C6B10 VA: 0x1817C8510
	public static TripleDES Create() { }

	// RVA: 0x17C8850 Offset: 0x17C6E50 VA: 0x1817C8850
	public static bool IsWeakKey(byte[] rgbKey) { }

	// RVA: 0x17C8630 Offset: 0x17C6C30 VA: 0x1817C8630
	private static bool EqualBytes(byte[] rgbKey, int start1, int start2, int count) { }

	// RVA: 0x17C8830 Offset: 0x17C6E30 VA: 0x1817C8830
	private static bool IsLegalKeySize(byte[] rgbKey) { }

	// RVA: 0x17C8A80 Offset: 0x17C7080 VA: 0x1817C8A80
	private static void .cctor() { }

}

