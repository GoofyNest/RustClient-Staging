public sealed class DesignOnlyAttribute : Attribute // TypeDefIndex: 2690
{	// Fields
	private bool isDesignOnly; // 0x10
	public static readonly DesignOnlyAttribute Yes; // 0x0
	public static readonly DesignOnlyAttribute No; // 0x8
	public static readonly DesignOnlyAttribute Default; // 0x10

	// Properties
	public bool IsDesignOnly { get; }

	// Methods

	// RVA: 0xFDCB80 Offset: 0xFDB180 VA: 0x180FDCB80
	public void .ctor(bool isDesignOnly) { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_IsDesignOnly() { }

	// RVA: 0x15C1090 Offset: 0x15BF690 VA: 0x1815C1090 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x15C1010 Offset: 0x15BF610 VA: 0x1815C1010 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13C88F0 Offset: 0x13C6EF0 VA: 0x1813C88F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15C1110 Offset: 0x15BF710 VA: 0x1815C1110
	private static void .cctor() { }

}

