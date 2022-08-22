public sealed class ListBindableAttribute : Attribute // TypeDefIndex: 2724
{	// Fields
	public static readonly ListBindableAttribute Yes; // 0x0
	public static readonly ListBindableAttribute No; // 0x8
	public static readonly ListBindableAttribute Default; // 0x10
	private bool listBindable; // 0x10
	private bool isDefault; // 0x11

	// Properties
	public bool ListBindable { get; }

	// Methods

	// RVA: 0xFDCE40 Offset: 0xFDB440 VA: 0x180FDCE40
	public void .ctor(bool listBindable) { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_ListBindable() { }

	// RVA: 0x15C87B0 Offset: 0x15C6DB0 VA: 0x1815C87B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15C0830 Offset: 0x15BEE30 VA: 0x1815C0830 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15C8830 Offset: 0x15C6E30 VA: 0x1815C8830 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x15C88B0 Offset: 0x15C6EB0 VA: 0x1815C88B0
	private static void .cctor() { }

}

