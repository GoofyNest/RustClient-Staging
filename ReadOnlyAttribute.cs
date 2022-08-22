public sealed class ReadOnlyAttribute : Attribute // TypeDefIndex: 2738
{	// Fields
	private bool isReadOnly; // 0x10
	public static readonly ReadOnlyAttribute Yes; // 0x0
	public static readonly ReadOnlyAttribute No; // 0x8
	public static readonly ReadOnlyAttribute Default; // 0x10

	// Properties
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0xFDD8E0 Offset: 0xFDBEE0 VA: 0x180FDD8E0
	public void .ctor(bool isReadOnly) { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_IsReadOnly() { }

	// RVA: 0x15D2750 Offset: 0x15D0D50 VA: 0x1815D2750 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x15BF900 Offset: 0x15BDF00 VA: 0x1815BF900 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15D27D0 Offset: 0x15D0DD0 VA: 0x1815D27D0 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x15D2850 Offset: 0x15D0E50 VA: 0x1815D2850
	private static void .cctor() { }

}

public sealed class ReadOnlyAttribute : Attribute // TypeDefIndex: 3315
{	// Methods

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

}

public class ReadOnlyAttribute : PropertyAttribute // TypeDefIndex: 8019
{	// Methods

	// RVA: 0x5177F0 Offset: 0x515DF0 VA: 0x1805177F0
	public void .ctor() { }

}

