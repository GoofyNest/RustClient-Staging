internal struct RuntimeClassHandle // TypeDefIndex: 5
{	// Fields
	private RuntimeStructs.MonoClass* value; // 0x0

	// Properties
	internal RuntimeStructs.MonoClass* Value { get; }

	// Methods

	// RVA: 0x1D3520 Offset: 0x1D2920 VA: 0x1801D3520
	internal void .ctor(RuntimeStructs.MonoClass* value) { }

	// RVA: 0x1F5670 Offset: 0x1F4A70 VA: 0x1801F5670
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	internal RuntimeStructs.MonoClass* get_Value() { }

	// RVA: 0x1F5530 Offset: 0x1F4930 VA: 0x1801F5530 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1F5630 Offset: 0x1F4A30 VA: 0x1801F5630 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x16375A0 Offset: 0x1635BA0 VA: 0x1816375A0
	internal static IntPtr GetTypeFromClass(RuntimeStructs.MonoClass* klass) { }

	// RVA: 0x1F5660 Offset: 0x1F4A60 VA: 0x1801F5660
	internal RuntimeTypeHandle GetTypeHandle() { }

}

