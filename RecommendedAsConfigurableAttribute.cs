public class RecommendedAsConfigurableAttribute : Attribute // TypeDefIndex: 2739
{	// Fields
	private bool recommendedAsConfigurable; // 0x10
	public static readonly RecommendedAsConfigurableAttribute No; // 0x0
	public static readonly RecommendedAsConfigurableAttribute Yes; // 0x8
	public static readonly RecommendedAsConfigurableAttribute Default; // 0x10

	// Properties
	public bool RecommendedAsConfigurable { get; }

	// Methods

	// RVA: 0xFDCB80 Offset: 0xFDB180 VA: 0x180FDCB80
	public void .ctor(bool recommendedAsConfigurable) { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_RecommendedAsConfigurable() { }

	// RVA: 0x15D3580 Offset: 0x15D1B80 VA: 0x1815D3580 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15C0570 Offset: 0x15BEB70 VA: 0x1815C0570 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15D3620 Offset: 0x15D1C20 VA: 0x1815D3620 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x15D3630 Offset: 0x15D1C30 VA: 0x1815D3630
	private static void .cctor() { }

}

