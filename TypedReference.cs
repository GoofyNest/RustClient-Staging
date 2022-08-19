public struct TypedReference // TypeDefIndex: 323
{	// Fields
	private RuntimeTypeHandle type; // 0x0
	private IntPtr Value; // 0x8
	private IntPtr Type; // 0x10

	// Properties
	internal bool IsNull { get; }

	// Methods

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x2144AE0 Offset: 0x21430E0 VA: 0x182144AE0
	public static TypedReference MakeTypedReference(object target, FieldInfo[] flds) { }

	// RVA: 0x2144AC0 Offset: 0x21430C0 VA: 0x182144AC0
	private static TypedReference MakeTypedReferenceInternal(object target, FieldInfo[] fields) { }

	// RVA: 0x232A20 Offset: 0x231E20 VA: 0x180232A20 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x232A10 Offset: 0x231E10 VA: 0x180232A10 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x232AC0 Offset: 0x231EC0 VA: 0x180232AC0
	internal bool get_IsNull() { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x2145000 Offset: 0x2143600 VA: 0x182145000
	public static void SetTypedReference(TypedReference target, object value) { }

}

