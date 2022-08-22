internal abstract class RC4 : SymmetricAlgorithm // TypeDefIndex: 74
{	// Fields
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Properties
	public override byte[] IV { get; set; }

	// Methods

	// RVA: 0x1754D10 Offset: 0x1753310 VA: 0x181754D10
	public void .ctor() { }

	// RVA: 0x1754DC0 Offset: 0x17533C0 VA: 0x181754DC0 Slot: 9
	public override byte[] get_IV() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	public override void set_IV(byte[] value) { }

	// RVA: 0x1754A40 Offset: 0x1753040 VA: 0x181754A40
	public static RC4 Create() { }

	// RVA: 0x1754B70 Offset: 0x1753170 VA: 0x181754B70
	private static void .cctor() { }

}

