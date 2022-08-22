public sealed class ReadOnlyAttribute : Attribute // TypeDefIndex: 2738
{	// Fields
	private bool isReadOnly; // 0x10
	public static readonly ReadOnlyAttribute Yes; // 0x0
	public static readonly ReadOnlyAttribute No; // 0x8
	public static readonly ReadOnlyAttribute Default; // 0x10

	// Properties
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0xFDCE40 Offset: 0xFDB440 VA: 0x180FDCE40
	public void .ctor(bool isReadOnly) { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_IsReadOnly() { }

	// RVA: 0x15D3680 Offset: 0x15D1C80 VA: 0x1815D3680 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x15C0830 Offset: 0x15BEE30 VA: 0x1815C0830 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15D3700 Offset: 0x15D1D00 VA: 0x1815D3700 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x15D3780 Offset: 0x15D1D80 VA: 0x1815D3780
	private static void .cctor() { }

}

public sealed class ReadOnlyAttribute : Attribute // TypeDefIndex: 3315
{	// Methods

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

}

public class ReadOnlyAttribute : PropertyAttribute // TypeDefIndex: 8019
{	// Methods

	// RVA: 0x517860 Offset: 0x515E60 VA: 0x180517860
	public void .ctor() { }

}

