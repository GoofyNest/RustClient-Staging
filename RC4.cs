internal abstract class RC4 : SymmetricAlgorithm // TypeDefIndex: 74
{	// Fields
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Properties
	public override byte[] IV { get; set; }

	// Methods

	// RVA: 0x17528D0 Offset: 0x1750ED0 VA: 0x1817528D0
	public void .ctor() { }

	// RVA: 0x1752980 Offset: 0x1750F80 VA: 0x181752980 Slot: 9
	public override byte[] get_IV() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	public override void set_IV(byte[] value) { }

	// RVA: 0x1752600 Offset: 0x1750C00 VA: 0x181752600
	public static RC4 Create() { }

	// RVA: 0x1752730 Offset: 0x1750D30 VA: 0x181752730
	private static void .cctor() { }

}

