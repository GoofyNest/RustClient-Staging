public abstract class RC2 : SymmetricAlgorithm // TypeDefIndex: 973
{	// Fields
	protected int EffectiveKeySizeValue; // 0x48
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Properties
	public virtual int EffectiveKeySize { get; }
	public override int KeySize { get; set; }

	// Methods

	// RVA: 0x1706950 Offset: 0x1704F50 VA: 0x181706950
	protected void .ctor() { }

	// RVA: 0x1706A00 Offset: 0x1705000 VA: 0x181706A00 Slot: 26
	public virtual int get_EffectiveKeySize() { }

	// RVA: 0x6BB940 Offset: 0x6B9F40 VA: 0x1806BB940 Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x1706A10 Offset: 0x1705010 VA: 0x181706A10 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x1706760 Offset: 0x1704D60 VA: 0x181706760
	public static RC2 Create() { }

	// RVA: 0x17067B0 Offset: 0x1704DB0 VA: 0x1817067B0
	private static void .cctor() { }

}

