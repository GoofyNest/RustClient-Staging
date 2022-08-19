internal struct RuntimeClassHandle // TypeDefIndex: 5
{	// Fields
	private RuntimeStructs.MonoClass* value; // 0x0

	// Properties
	internal RuntimeStructs.MonoClass* Value { get; }

	// Methods

	// RVA: 0x1D2F30 Offset: 0x1D2330 VA: 0x1801D2F30
	internal void .ctor(RuntimeStructs.MonoClass* value) { }

	// RVA: 0x1F68A0 Offset: 0x1F5CA0 VA: 0x1801F68A0
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0xFC8C0 Offset: 0xFBCC0 VA: 0x1800FC8C0
	internal RuntimeStructs.MonoClass* get_Value() { }

	// RVA: 0x1F6760 Offset: 0x1F5B60 VA: 0x1801F6760 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1F6860 Offset: 0x1F5C60 VA: 0x1801F6860 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1649FC0 Offset: 0x16485C0 VA: 0x181649FC0
	internal static IntPtr GetTypeFromClass(RuntimeStructs.MonoClass* klass) { }

	// RVA: 0x1F6890 Offset: 0x1F5C90 VA: 0x1801F6890
	internal RuntimeTypeHandle GetTypeHandle() { }

}

