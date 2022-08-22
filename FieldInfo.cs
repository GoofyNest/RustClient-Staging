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

	// RVA: 0xE37E50 Offset: 0xE36450 VA: 0x180E37E50 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: 0x18C9790 Offset: 0x18C7D90 VA: 0x1818C9790 Slot: 21
	public bool get_IsLiteral() { }

	// RVA: 0x18C9820 Offset: 0x18C7E20 VA: 0x1818C9820 Slot: 22
	public bool get_IsStatic() { }

	// RVA: 0x18C9770 Offset: 0x18C7D70 VA: 0x1818C9770 Slot: 23
	public bool get_IsInitOnly() { }

	// RVA: 0x18C97F0 Offset: 0x18C7DF0 VA: 0x1818C97F0 Slot: 24
	public bool get_IsPublic() { }

	// RVA: 0x18C97D0 Offset: 0x18C7DD0 VA: 0x1818C97D0 Slot: 25
	public bool get_IsPrivate() { }

	// RVA: 0x18C97B0 Offset: 0x18C7DB0 VA: 0x1818C97B0 Slot: 26
	public bool get_IsNotSerialized() { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture);

	[DebuggerStepThroughAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[DebuggerHiddenAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x18C9740 Offset: 0x18C7D40 VA: 0x1818C9740 Slot: 28
	public void SetValue(object obj, object value) { }

	// RVA: 0x18C9840 Offset: 0x18C7E40 VA: 0x1818C9840
	private static FieldInfo internal_from_handle_type(IntPtr field_handle, IntPtr type_handle) { }

	// RVA: 0x18C9230 Offset: 0x18C7830 VA: 0x1818C9230
	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18C92B0 Offset: 0x18C78B0 VA: 0x1818C92B0
	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle, RuntimeTypeHandle declaringType) { }

	// RVA: 0x18C9370 Offset: 0x18C7970 VA: 0x1818C9370 Slot: 29
	internal virtual int GetFieldOffset() { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x18C96D0 Offset: 0x18C7CD0 VA: 0x1818C96D0 Slot: 30
	public virtual void SetValueDirect(TypedReference obj, object value) { }

	// RVA: 0x17C9C90 Offset: 0x17C8290 VA: 0x1817C9C90
	private MarshalAsAttribute get_marshal_info() { }

	// RVA: 0x18C93D0 Offset: 0x18C79D0 VA: 0x1818C93D0
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x18C9670 Offset: 0x18C7C70 VA: 0x1818C9670 Slot: 31
	public virtual object GetRawConstantValue() { }

	// RVA: 0x1291940 Offset: 0x128FF40 VA: 0x181291940 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xCCE560 Offset: 0xCCCB60 VA: 0x180CCE560 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18C6350 Offset: 0x18C4950 VA: 0x1818C6350
	public static bool op_Equality(FieldInfo left, FieldInfo right) { }

	// RVA: 0x18C63A0 Offset: 0x18C49A0 VA: 0x1818C63A0
	public static bool op_Inequality(FieldInfo left, FieldInfo right) { }

}

