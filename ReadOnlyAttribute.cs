public sealed class ReadOnlyAttribute : Attribute // TypeDefIndex: 2738
{	// Fields
	private bool isReadOnly; // 0x10
	public static readonly ReadOnlyAttribute Yes; // 0x0
	public static readonly ReadOnlyAttribute No; // 0x8
	public static readonly ReadOnlyAttribute Default; // 0x10

	// Properties
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0xFDCB80 Offset: 0xFDB180 VA: 0x180FDCB80
	public void .ctor(bool isReadOnly) { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_IsReadOnly() { }

	// RVA: 0x15D33C0 Offset: 0x15D19C0 VA: 0x1815D33C0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x15C0570 Offset: 0x15BEB70 VA: 0x1815C0570 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15D3440 Offset: 0x15D1A40 VA: 0x1815D3440 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x15D34C0 Offset: 0x15D1AC0 VA: 0x1815D34C0
	private static void .cctor() { }

}

public sealed class ReadOnlyAttribute : Attribute // TypeDefIndex: 3315
{	// Methods

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

}

public class ReadOnlyAttribute : PropertyAttribute // TypeDefIndex: 8019
{	// Methods

	// RVA: 0x517860 Offset: 0x515E60 VA: 0x180517860
	public void .ctor() { }

}
