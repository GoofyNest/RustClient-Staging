public abstract class FieldInfo : MemberInfo, _FieldInfo // TypeDefIndex: 568
{	public abstract FieldAttributes Attributes { get; }
	public abstract RuntimeFieldHandle FieldHandle { get; }
	public abstract Type FieldType { get; }
	public override MemberTypes MemberType { get; }
	public bool IsLiteral { get; }
	public bool IsStatic { get; }
	public bool IsInitOnly { get; }
	public bool IsPublic { get; }
	public bool IsPrivate { get; }
	public bool IsNotSerialized { get; }


	public abstract FieldAttributes get_Attributes();

	public abstract RuntimeFieldHandle get_FieldHandle();

	protected void .ctor() { }

	public abstract Type get_FieldType();

	public abstract object GetValue(object obj);

	public override MemberTypes get_MemberType() { }

	public bool get_IsLiteral() { }

	public bool get_IsStatic() { }

	public bool get_IsInitOnly() { }

	public bool get_IsPublic() { }

	public bool get_IsPrivate() { }

	public bool get_IsNotSerialized() { }

	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture);

	[DebuggerStepThroughAttribute] // RVA: 0x71780 Offset: 0x70B80 VA: 0x180071780
	[DebuggerHiddenAttribute] // RVA: 0x71780 Offset: 0x70B80 VA: 0x180071780
	public void SetValue(object obj, object value) { }

	private static FieldInfo internal_from_handle_type(IntPtr field_handle, IntPtr type_handle) { }

	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle) { }

	[ComVisibleAttribute] // RVA: 0x75DE0 Offset: 0x751E0 VA: 0x180075DE0
	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle, RuntimeTypeHandle declaringType) { }

	internal virtual int GetFieldOffset() { }

	[CLSCompliantAttribute] // RVA: 0x6F4E0 Offset: 0x6E8E0 VA: 0x18006F4E0
	public virtual void SetValueDirect(TypedReference obj, object value) { }

	private MarshalAsAttribute get_marshal_info() { }

	internal object[] GetPseudoCustomAttributes() { }

	public virtual object GetRawConstantValue() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public static bool op_Equality(FieldInfo left, FieldInfo right) { }

	public static bool op_Inequality(FieldInfo left, FieldInfo right) { }

}

