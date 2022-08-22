public sealed class BrowsableAttribute : Attribute // TypeDefIndex: 2670
{	// Fields
	public static readonly BrowsableAttribute Yes; // 0x0
	public static readonly BrowsableAttribute No; // 0x8
	public static readonly BrowsableAttribute Default; // 0x10
	private bool browsable; // 0x10

	// Properties
	public bool Browsable { get; }

	// Methods

	// RVA: 0x15BE150 Offset: 0x15BC750 VA: 0x1815BE150
	public void .ctor(bool browsable) { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_Browsable() { }

	// RVA: 0x15BDFA0 Offset: 0x15BC5A0 VA: 0x1815BDFA0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13C7CB0 Offset: 0x13C62B0 VA: 0x1813C7CB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15BE020 Offset: 0x15BC620 VA: 0x1815BE020 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x15BE090 Offset: 0x15BC690 VA: 0x1815BE090
	private static void .cctor() { }

}

