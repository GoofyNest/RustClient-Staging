public sealed class BrowsableAttribute : Attribute // TypeDefIndex: 2670
{	// Fields
	public static readonly BrowsableAttribute Yes; // 0x0
	public static readonly BrowsableAttribute No; // 0x8
	public static readonly BrowsableAttribute Default; // 0x10
	private bool browsable; // 0x10

	// Properties
	public bool Browsable { get; }

	// Methods

	// RVA: 0x15BEDC0 Offset: 0x15BD3C0 VA: 0x1815BEDC0
	public void .ctor(bool browsable) { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_Browsable() { }

	// RVA: 0x15BEC10 Offset: 0x15BD210 VA: 0x1815BEC10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13C88F0 Offset: 0x13C6EF0 VA: 0x1813C88F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15BEC90 Offset: 0x15BD290 VA: 0x1815BEC90 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x15BED00 Offset: 0x15BD300 VA: 0x1815BED00
	private static void .cctor() { }

}

