public sealed class BrowsableAttribute : Attribute // TypeDefIndex: 2670
{	// Fields
	public static readonly BrowsableAttribute Yes; // 0x0
	public static readonly BrowsableAttribute No; // 0x8
	public static readonly BrowsableAttribute Default; // 0x10
	private bool browsable; // 0x10

	// Properties
	public bool Browsable { get; }

	// Methods

	// RVA: 0x15BF080 Offset: 0x15BD680 VA: 0x1815BF080
	public void .ctor(bool browsable) { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_Browsable() { }

	// RVA: 0x15BEED0 Offset: 0x15BD4D0 VA: 0x1815BEED0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13C8BB0 Offset: 0x13C71B0 VA: 0x1813C8BB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15BEF50 Offset: 0x15BD550 VA: 0x1815BEF50 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x15BEFC0 Offset: 0x15BD5C0 VA: 0x1815BEFC0
	private static void .cctor() { }

}

