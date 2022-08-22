public struct TypedReference // TypeDefIndex: 323
{	// Fields
	private RuntimeTypeHandle type; // 0x0
	private IntPtr Value; // 0x8
	private IntPtr Type; // 0x10

	// Properties
	internal bool IsNull { get; }

	// Methods

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x2145400 Offset: 0x2143A00 VA: 0x182145400
	public static TypedReference MakeTypedReference(object target, FieldInfo[] flds) { }

	// RVA: 0x21453E0 Offset: 0x21439E0 VA: 0x1821453E0
	private static TypedReference MakeTypedReferenceInternal(object target, FieldInfo[] fields) { }

	// RVA: 0x2329A0 Offset: 0x231DA0 VA: 0x1802329A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x232990 Offset: 0x231D90 VA: 0x180232990 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x232A40 Offset: 0x231E40 VA: 0x180232A40
	internal bool get_IsNull() { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x2145920 Offset: 0x2143F20 VA: 0x182145920
	public static void SetTypedReference(TypedReference target, object value) { }

}

