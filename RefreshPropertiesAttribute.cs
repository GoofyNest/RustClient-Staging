public sealed class RefreshPropertiesAttribute : Attribute // TypeDefIndex: 2775
{	// Fields
	public static readonly RefreshPropertiesAttribute All; // 0x0
	public static readonly RefreshPropertiesAttribute Repaint; // 0x8
	public static readonly RefreshPropertiesAttribute Default; // 0x10
	private RefreshProperties refresh; // 0x10

	// Properties
	public RefreshProperties RefreshProperties { get; }

	// Methods

	// RVA: 0xB113D0 Offset: 0xB0F9D0 VA: 0x180B113D0
	public void .ctor(RefreshProperties refresh) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public RefreshProperties get_RefreshProperties() { }

	// RVA: 0x1733CA0 Offset: 0x17322A0 VA: 0x181733CA0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x15C0830 Offset: 0x15BEE30 VA: 0x1815C0830 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1733D30 Offset: 0x1732330 VA: 0x181733D30 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1733DA0 Offset: 0x17323A0 VA: 0x181733DA0
	private static void .cctor() { }

}

