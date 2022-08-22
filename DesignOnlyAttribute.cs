public sealed class DesignOnlyAttribute : Attribute // TypeDefIndex: 2690
{	// Fields
	private bool isDesignOnly; // 0x10
	public static readonly DesignOnlyAttribute Yes; // 0x0
	public static readonly DesignOnlyAttribute No; // 0x8
	public static readonly DesignOnlyAttribute Default; // 0x10

	// Properties
	public bool IsDesignOnly { get; }

	// Methods

	// RVA: 0xFDCE40 Offset: 0xFDB440 VA: 0x180FDCE40
	public void .ctor(bool isDesignOnly) { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_IsDesignOnly() { }

	// RVA: 0x15C1350 Offset: 0x15BF950 VA: 0x1815C1350 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x15C12D0 Offset: 0x15BF8D0 VA: 0x1815C12D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13C8BB0 Offset: 0x13C71B0 VA: 0x1813C8BB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15C13D0 Offset: 0x15BF9D0 VA: 0x1815C13D0
	private static void .cctor() { }

}

