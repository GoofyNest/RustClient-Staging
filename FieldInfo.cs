public abstract class FieldInfo : MemberInfo, _FieldInfo // TypeDefIndex: 568
{	// Properties
	public abstract FieldAttributes Attributes { get; }
	public abstract RuntimeFieldHandle FieldHandle { get; }
	public abstract Type FieldType { get; }
	public override MemberTypes MemberType { get; }
	public bool IsLiteral { get; }
	public bool IsStatic { get; }
	public bool IsInitOnly { get; }
	public bool IsPublic { get; }
	public bool IsPrivate { get; }
	public bool IsNotSerialized { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 17
	public abstract FieldAttributes get_Attributes();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract RuntimeFieldHandle get_FieldHandle();

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract Type get_FieldType();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract object GetValue(object obj);

	// RVA: 0xE38110 Offset: 0xE36710 VA: 0x180E38110 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: 0x18C9A50 Offset: 0x18C8050 VA: 0x1818C9A50 Slot: 21
	public bool get_IsLiteral() { }

	// RVA: 0x18C9AE0 Offset: 0x18C80E0 VA: 0x1818C9AE0 Slot: 22
	public bool get_IsStatic() { }

	// RVA: 0x18C9A30 Offset: 0x18C8030 VA: 0x1818C9A30 Slot: 23
	public bool get_IsInitOnly() { }

	// RVA: 0x18C9AB0 Offset: 0x18C80B0 VA: 0x1818C9AB0 Slot: 24
	public bool get_IsPublic() { }

	// RVA: 0x18C9A90 Offset: 0x18C8090 VA: 0x1818C9A90 Slot: 25
	public bool get_IsPrivate() { }

	// RVA: 0x18C9A70 Offset: 0x18C8070 VA: 0x1818C9A70 Slot: 26
	public bool get_IsNotSerialized() { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture);

	[DebuggerStepThroughAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[DebuggerHiddenAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x18C9A00 Offset: 0x18C8000 VA: 0x1818C9A00 Slot: 28
	public void SetValue(object obj, object value) { }

	// RVA: 0x18C9B00 Offset: 0x18C8100 VA: 0x1818C9B00
	private static FieldInfo internal_from_handle_type(IntPtr field_handle, IntPtr type_handle) { }

	// RVA: 0x18C94F0 Offset: 0x18C7AF0 VA: 0x1818C94F0
	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18C9570 Offset: 0x18C7B70 VA: 0x1818C9570
	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle, RuntimeTypeHandle declaringType) { }

	// RVA: 0x18C9630 Offset: 0x18C7C30 VA: 0x1818C9630 Slot: 29
	internal virtual int GetFieldOffset() { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x18C9990 Offset: 0x18C7F90 VA: 0x1818C9990 Slot: 30
	public virtual void SetValueDirect(TypedReference obj, object value) { }

	// RVA: 0x17C9F50 Offset: 0x17C8550 VA: 0x1817C9F50
	private MarshalAsAttribute get_marshal_info() { }

	// RVA: 0x18C9690 Offset: 0x18C7C90 VA: 0x1818C9690
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x18C9930 Offset: 0x18C7F30 VA: 0x1818C9930 Slot: 31
	public virtual object GetRawConstantValue() { }

	// RVA: 0x1291C00 Offset: 0x1290200 VA: 0x181291C00 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xCCE820 Offset: 0xCCCE20 VA: 0x180CCE820 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18C6610 Offset: 0x18C4C10 VA: 0x1818C6610
	public static bool op_Equality(FieldInfo left, FieldInfo right) { }

	// RVA: 0x18C6660 Offset: 0x18C4C60 VA: 0x1818C6660
	public static bool op_Inequality(FieldInfo left, FieldInfo right) { }

}

