internal abstract class RC4 : SymmetricAlgorithm // TypeDefIndex: 74
{	// Fields
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Properties
	public override byte[] IV { get; set; }

	// Methods

	// RVA: 0x1754A50 Offset: 0x1753050 VA: 0x181754A50
	public void .ctor() { }

	// RVA: 0x1754B00 Offset: 0x1753100 VA: 0x181754B00 Slot: 9
	public override byte[] get_IV() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	public override void set_IV(byte[] value) { }

	// RVA: 0x1754780 Offset: 0x1752D80 VA: 0x181754780
	public static RC4 Create() { }

	// RVA: 0x17548B0 Offset: 0x1752EB0 VA: 0x1817548B0
	private static void .cctor() { }

}

