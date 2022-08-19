public abstract class MethodBase : MemberInfo, _MethodBase // TypeDefIndex: 539
{	// Properties
	public abstract RuntimeMethodHandle MethodHandle { get; }
	public abstract MethodAttributes Attributes { get; }
	public virtual CallingConventions CallingConvention { get; }
	public virtual bool IsGenericMethodDefinition { get; }
	public virtual bool ContainsGenericParameters { get; }
	public virtual bool IsGenericMethod { get; }
	public virtual bool IsSecurityCritical { get; }
	public bool IsPublic { get; }
	public bool IsStatic { get; }
	public bool IsVirtual { get; }
	public bool IsAbstract { get; }
	[ComVisibleAttribute] // RVA: 0x75F80 Offset: 0x75380 VA: 0x180075F80
	public bool IsConstructor { get; }

	// Methods

	// RVA: 0x18CC2E0 Offset: 0x18CA8E0 VA: 0x1818CC2E0
	public static MethodBase GetMethodFromHandle(RuntimeMethodHandle handle) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x18CC830 Offset: 0x18CAE30 VA: 0x1818CC830
	public static bool op_Equality(MethodBase left, MethodBase right) { }

	// RVA: 0x18CCA80 Offset: 0x18CB080 VA: 0x1818CCA80
	public static bool op_Inequality(MethodBase left, MethodBase right) { }

	// RVA: 0x18CB940 Offset: 0x18C9F40 VA: 0x1818CB940 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xCCE560 Offset: 0xCCCB60 VA: 0x180CCE560 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x10B7D70 Offset: 0x10B6370 VA: 0x1810B7D70 Slot: 17
	internal virtual ParameterInfo[] GetParametersNoCopy() { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract ParameterInfo[] GetParameters();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract MethodImplAttributes GetMethodImplementationFlags();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract RuntimeMethodHandle get_MethodHandle();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract MethodAttributes get_Attributes();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 23
	public virtual CallingConventions get_CallingConvention() { }

	[ComVisibleAttribute] // RVA: 0x75F80 Offset: 0x75380 VA: 0x180075F80
	// RVA: 0x18CC1A0 Offset: 0x18CA7A0 VA: 0x1818CC1A0 Slot: 24
	public virtual Type[] GetGenericArguments() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 25
	public virtual bool get_IsGenericMethodDefinition() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 26
	public virtual bool get_ContainsGenericParameters() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 27
	public virtual bool get_IsGenericMethod() { }

	// RVA: 0x18CC7A0 Offset: 0x18CADA0 VA: 0x1818CC7A0 Slot: 28
	public virtual bool get_IsSecurityCritical() { }

	[DebuggerHiddenAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[DebuggerStepThroughAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	// RVA: 0x18CC650 Offset: 0x18CAC50 VA: 0x1818CC650 Slot: 29
	public object Invoke(object obj, object[] parameters) { }

	// RVA: 0x18CC770 Offset: 0x18CAD70 VA: 0x1818CC770 Slot: 30
	public bool get_IsPublic() { }

	// RVA: 0x18CC7F0 Offset: 0x18CADF0 VA: 0x1818CC7F0 Slot: 31
	public bool get_IsStatic() { }

	// RVA: 0x18CC810 Offset: 0x18CAE10 VA: 0x1818CC810 Slot: 32
	public bool get_IsVirtual() { }

	// RVA: 0x18CC690 Offset: 0x18CAC90 VA: 0x1818CC690 Slot: 33
	public bool get_IsAbstract() { }

	// RVA: 0x18CC6C0 Offset: 0x18CACC0 VA: 0x1818CC6C0 Slot: 34
	public bool get_IsConstructor() { }

	// RVA: 0x18CC220 Offset: 0x18CA820 VA: 0x1818CC220 Slot: 35
	public virtual MethodBody GetMethodBody() { }

	// RVA: 0x18CBEC0 Offset: 0x18CA4C0 VA: 0x1818CBEC0
	internal static string ConstructParameters(Type[] parameterTypes, CallingConventions callingConvention, bool serialization) { }

	// RVA: 0x18CC090 Offset: 0x18CA690 VA: 0x1818CC090 Slot: 36
	internal virtual string FormatNameAndSig(bool serialization) { }

	// RVA: 0x18CC4F0 Offset: 0x18CAAF0 VA: 0x1818CC4F0 Slot: 37
	internal virtual Type[] GetParameterTypes() { }

	// RVA: 0x10B7D70 Offset: 0x10B6370 VA: 0x1810B7D70 Slot: 38
	internal virtual ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x18CC620 Offset: 0x18CAC20 VA: 0x1818CC620 Slot: 39
	internal virtual int GetParametersCount() { }

	// RVA: 0x18CC2A0 Offset: 0x18CA8A0 VA: 0x1818CC2A0
	internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle) { }

	// RVA: 0x18CC290 Offset: 0x18CA890 VA: 0x1818CC290
	internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle, RuntimeTypeHandle reflectedType) { }

	// RVA: 0x18CC210 Offset: 0x18CA810 VA: 0x1818CC210
	internal static MethodBody GetMethodBodyInternal(IntPtr handle) { }

	// RVA: 0x18CC210 Offset: 0x18CA810 VA: 0x1818CC210
	internal static MethodBody GetMethodBody(IntPtr handle) { }

	// RVA: 0x18CC270 Offset: 0x18CA870 VA: 0x1818CC270
	private static MethodBase GetMethodFromHandleInternalType(IntPtr method_handle, IntPtr type_handle) { }

	// RVA: 0x18CC280 Offset: 0x18CA880 VA: 0x1818CC280
	internal static MethodBase GetMethodFromHandleInternalType_native(IntPtr method_handle, IntPtr type_handle, bool genericCheck) { }

}

