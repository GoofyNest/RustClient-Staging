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

	// RVA: 0x18C97D0 Offset: 0x18C7DD0 VA: 0x1818C97D0 Slot: 21
	public bool get_IsLiteral() { }

	// RVA: 0x18C9860 Offset: 0x18C7E60 VA: 0x1818C9860 Slot: 22
	public bool get_IsStatic() { }

	// RVA: 0x18C97B0 Offset: 0x18C7DB0 VA: 0x1818C97B0 Slot: 23
	public bool get_IsInitOnly() { }

	// RVA: 0x18C9830 Offset: 0x18C7E30 VA: 0x1818C9830 Slot: 24
	public bool get_IsPublic() { }

	// RVA: 0x18C9810 Offset: 0x18C7E10 VA: 0x1818C9810 Slot: 25
	public bool get_IsPrivate() { }

	// RVA: 0x18C97F0 Offset: 0x18C7DF0 VA: 0x1818C97F0 Slot: 26
	public bool get_IsNotSerialized() { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture);

	[DebuggerStepThroughAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[DebuggerHiddenAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	// RVA: 0x18C9780 Offset: 0x18C7D80 VA: 0x1818C9780 Slot: 28
	public void SetValue(object obj, object value) { }

	// RVA: 0x18C9880 Offset: 0x18C7E80 VA: 0x1818C9880
	private static FieldInfo internal_from_handle_type(IntPtr field_handle, IntPtr type_handle) { }

	// RVA: 0x18C9270 Offset: 0x18C7870 VA: 0x1818C9270
	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle) { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x18C92F0 Offset: 0x18C78F0 VA: 0x1818C92F0
	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle, RuntimeTypeHandle declaringType) { }

	// RVA: 0x18C93B0 Offset: 0x18C79B0 VA: 0x1818C93B0 Slot: 29
	internal virtual int GetFieldOffset() { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x18C9710 Offset: 0x18C7D10 VA: 0x1818C9710 Slot: 30
	public virtual void SetValueDirect(TypedReference obj, object value) { }

	// RVA: 0x17C9C90 Offset: 0x17C8290 VA: 0x1817C9C90
	private MarshalAsAttribute get_marshal_info() { }

	// RVA: 0x18C9410 Offset: 0x18C7A10 VA: 0x1818C9410
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x18C96B0 Offset: 0x18C7CB0 VA: 0x1818C96B0 Slot: 31
	public virtual object GetRawConstantValue() { }

	// RVA: 0x1291940 Offset: 0x128FF40 VA: 0x181291940 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xCCE560 Offset: 0xCCCB60 VA: 0x180CCE560 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18C6390 Offset: 0x18C4990 VA: 0x1818C6390
	public static bool op_Equality(FieldInfo left, FieldInfo right) { }

	// RVA: 0x18C63E0 Offset: 0x18C49E0 VA: 0x1818C63E0
	public static bool op_Inequality(FieldInfo left, FieldInfo right) { }

}

