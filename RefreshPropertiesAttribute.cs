public sealed class RefreshPropertiesAttribute : Attribute // TypeDefIndex: 2775
{	// Fields
	public static readonly RefreshPropertiesAttribute All; // 0x0
	public static readonly RefreshPropertiesAttribute Repaint; // 0x8
	public static readonly RefreshPropertiesAttribute Default; // 0x10
	private RefreshProperties refresh; // 0x10

	// Properties
	public RefreshProperties RefreshProperties { get; }

	// Methods

	// RVA: 0xB118A0 Offset: 0xB0FEA0 VA: 0x180B118A0
	public void .ctor(RefreshProperties refresh) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public RefreshProperties get_RefreshProperties() { }

	// RVA: 0x1731860 Offset: 0x172FE60 VA: 0x181731860 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x15BF900 Offset: 0x15BDF00 VA: 0x1815BF900 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17318F0 Offset: 0x172FEF0 VA: 0x1817318F0 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1731960 Offset: 0x172FF60 VA: 0x181731960
	private static void .cctor() { }

}

