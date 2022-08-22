internal struct RuntimeClassHandle // TypeDefIndex: 5
{	// Fields
	private RuntimeStructs.MonoClass* value; // 0x0

	// Properties
	internal RuntimeStructs.MonoClass* Value { get; }

	// Methods

	// RVA: 0x1D2EB0 Offset: 0x1D22B0 VA: 0x1801D2EB0
	internal void .ctor(RuntimeStructs.MonoClass* value) { }

	// RVA: 0x1F6820 Offset: 0x1F5C20 VA: 0x1801F6820
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	internal RuntimeStructs.MonoClass* get_Value() { }

	// RVA: 0x1F66E0 Offset: 0x1F5AE0 VA: 0x1801F66E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1F67E0 Offset: 0x1F5BE0 VA: 0x1801F67E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x164A280 Offset: 0x1648880 VA: 0x18164A280
	internal static IntPtr GetTypeFromClass(RuntimeStructs.MonoClass* klass) { }

	// RVA: 0x1F6810 Offset: 0x1F5C10 VA: 0x1801F6810
	internal RuntimeTypeHandle GetTypeHandle() { }

}

