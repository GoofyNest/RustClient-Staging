public abstract class RC2 : SymmetricAlgorithm // TypeDefIndex: 973
{	// Fields
	protected int EffectiveKeySizeValue; // 0x48
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Properties
	public virtual int EffectiveKeySize { get; }
	public override int KeySize { get; set; }

	// Methods

	// RVA: 0x1704800 Offset: 0x1702E00 VA: 0x181704800
	protected void .ctor() { }

	// RVA: 0x17048B0 Offset: 0x1702EB0 VA: 0x1817048B0 Slot: 26
	public virtual int get_EffectiveKeySize() { }

	// RVA: 0x6BB9E0 Offset: 0x6B9FE0 VA: 0x1806BB9E0 Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x17048C0 Offset: 0x1702EC0 VA: 0x1817048C0 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x1704610 Offset: 0x1702C10 VA: 0x181704610
	public static RC2 Create() { }

	// RVA: 0x1704660 Offset: 0x1702C60 VA: 0x181704660
	private static void .cctor() { }

}

