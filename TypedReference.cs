public struct TypedReference // TypeDefIndex: 323
{	private RuntimeTypeHandle type; // 0x0
	private IntPtr Value; // 0x8
	private IntPtr Type; // 0x10

	internal bool IsNull { get; }


	[CLSCompliantAttribute] // RVA: 0x6F4E0 Offset: 0x6E8E0 VA: 0x18006F4E0
	public static TypedReference MakeTypedReference(object target, FieldInfo[] flds) { }

	private static TypedReference MakeTypedReferenceInternal(object target, FieldInfo[] fields) { }

	public override int GetHashCode() { }

	public override bool Equals(object o) { }

	internal bool get_IsNull() { }

	[CLSCompliantAttribute] // RVA: 0x6F4E0 Offset: 0x6E8E0 VA: 0x18006F4E0
	public static void SetTypedReference(TypedReference target, object value) { }

}

