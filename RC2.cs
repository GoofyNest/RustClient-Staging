public abstract class RC2 : SymmetricAlgorithm // TypeDefIndex: 973
{	// Fields
	protected int EffectiveKeySizeValue; // 0x48
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Properties
	public virtual int EffectiveKeySize { get; }
	public override int KeySize { get; set; }

	// Methods

	// RVA: 0x1706C10 Offset: 0x1705210 VA: 0x181706C10
	protected void .ctor() { }

	// RVA: 0x1706CC0 Offset: 0x17052C0 VA: 0x181706CC0 Slot: 26
	public virtual int get_EffectiveKeySize() { }

	// RVA: 0x6BBA50 Offset: 0x6BA050 VA: 0x1806BBA50 Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x1706CD0 Offset: 0x17052D0 VA: 0x181706CD0 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x1706A20 Offset: 0x1705020 VA: 0x181706A20
	public static RC2 Create() { }

	// RVA: 0x1706A70 Offset: 0x1705070 VA: 0x181706A70
	private static void .cctor() { }

}

