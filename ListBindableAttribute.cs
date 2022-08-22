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

	// RVA: 0xFDD8E0 Offset: 0xFDBEE0 VA: 0x180FDD8E0
	public void .ctor(bool listBindable) { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_ListBindable() { }

	// RVA: 0x15C7880 Offset: 0x15C5E80 VA: 0x1815C7880 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15BF900 Offset: 0x15BDF00 VA: 0x1815BF900 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15C7900 Offset: 0x15C5F00 VA: 0x1815C7900 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x15C7980 Offset: 0x15C5F80 VA: 0x1815C7980
	private static void .cctor() { }

}

