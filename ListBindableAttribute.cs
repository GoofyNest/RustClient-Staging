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

	// RVA: 0xFDCB80 Offset: 0xFDB180 VA: 0x180FDCB80
	public void .ctor(bool listBindable) { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_ListBindable() { }

	// RVA: 0x15C84F0 Offset: 0x15C6AF0 VA: 0x1815C84F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15C0570 Offset: 0x15BEB70 VA: 0x1815C0570 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15C8570 Offset: 0x15C6B70 VA: 0x1815C8570 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x15C85F0 Offset: 0x15C6BF0 VA: 0x1815C85F0
	private static void .cctor() { }

}

