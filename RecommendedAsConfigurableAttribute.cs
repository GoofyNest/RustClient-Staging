public class RecommendedAsConfigurableAttribute : Attribute // TypeDefIndex: 2739
{	// Fields
	private bool recommendedAsConfigurable; // 0x10
	public static readonly RecommendedAsConfigurableAttribute No; // 0x0
	public static readonly RecommendedAsConfigurableAttribute Yes; // 0x8
	public static readonly RecommendedAsConfigurableAttribute Default; // 0x10

	// Properties
	public bool RecommendedAsConfigurable { get; }

	// Methods

	// RVA: 0xFDCE40 Offset: 0xFDB440 VA: 0x180FDCE40
	public void .ctor(bool recommendedAsConfigurable) { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_RecommendedAsConfigurable() { }

	// RVA: 0x15D3840 Offset: 0x15D1E40 VA: 0x1815D3840 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15C0830 Offset: 0x15BEE30 VA: 0x1815C0830 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15D38E0 Offset: 0x15D1EE0 VA: 0x1815D38E0 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x15D38F0 Offset: 0x15D1EF0 VA: 0x1815D38F0
	private static void .cctor() { }

}

