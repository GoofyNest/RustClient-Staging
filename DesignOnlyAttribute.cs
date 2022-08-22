public sealed class DesignOnlyAttribute : Attribute // TypeDefIndex: 2690
{	// Fields
	private bool isDesignOnly; // 0x10
	public static readonly DesignOnlyAttribute Yes; // 0x0
	public static readonly DesignOnlyAttribute No; // 0x8
	public static readonly DesignOnlyAttribute Default; // 0x10

	// Properties
	public bool IsDesignOnly { get; }

	// Methods

	// RVA: 0xFDD8E0 Offset: 0xFDBEE0 VA: 0x180FDD8E0
	public void .ctor(bool isDesignOnly) { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_IsDesignOnly() { }

	// RVA: 0x15C0420 Offset: 0x15BEA20 VA: 0x1815C0420 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x15C03A0 Offset: 0x15BE9A0 VA: 0x1815C03A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13C7CB0 Offset: 0x13C62B0 VA: 0x1813C7CB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15C04A0 Offset: 0x15BEAA0 VA: 0x1815C04A0
	private static void .cctor() { }

}

