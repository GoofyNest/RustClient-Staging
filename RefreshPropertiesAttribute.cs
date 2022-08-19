public sealed class RefreshPropertiesAttribute : Attribute // TypeDefIndex: 2775
{	// Fields
	public static readonly RefreshPropertiesAttribute All; // 0x0
	public static readonly RefreshPropertiesAttribute Repaint; // 0x8
	public static readonly RefreshPropertiesAttribute Default; // 0x10
	private RefreshProperties refresh; // 0x10

	// Properties
	public RefreshProperties RefreshProperties { get; }

	// Methods

	// RVA: 0xB11110 Offset: 0xB0F710 VA: 0x180B11110
	public void .ctor(RefreshProperties refresh) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public RefreshProperties get_RefreshProperties() { }

	// RVA: 0x17339E0 Offset: 0x1731FE0 VA: 0x1817339E0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x15C0570 Offset: 0x15BEB70 VA: 0x1815C0570 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1733A70 Offset: 0x1732070 VA: 0x181733A70 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1733AE0 Offset: 0x17320E0 VA: 0x181733AE0
	private static void .cctor() { }

}

