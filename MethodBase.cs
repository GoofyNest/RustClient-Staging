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
	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	public bool IsConstructor { get; }

	// Methods

	// RVA: 0x18CC2A0 Offset: 0x18CA8A0 VA: 0x1818CC2A0
	public static MethodBase GetMethodFromHandle(RuntimeMethodHandle handle) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x18CC7F0 Offset: 0x18CADF0 VA: 0x1818CC7F0
	public static bool op_Equality(MethodBase left, MethodBase right) { }

	// RVA: 0x18CCA40 Offset: 0x18CB040 VA: 0x1818CCA40
	public static bool op_Inequality(MethodBase left, MethodBase right) { }

	// RVA: 0x18CB900 Offset: 0x18C9F00 VA: 0x1818CB900 Slot: 0
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

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x18CC160 Offset: 0x18CA760 VA: 0x1818CC160 Slot: 24
	public virtual Type[] GetGenericArguments() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 25
	public virtual bool get_IsGenericMethodDefinition() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 26
	public virtual bool get_ContainsGenericParameters() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 27
	public virtual bool get_IsGenericMethod() { }

	// RVA: 0x18CC760 Offset: 0x18CAD60 VA: 0x1818CC760 Slot: 28
	public virtual bool get_IsSecurityCritical() { }

	[DebuggerHiddenAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[DebuggerStepThroughAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x18CC610 Offset: 0x18CAC10 VA: 0x1818CC610 Slot: 29
	public object Invoke(object obj, object[] parameters) { }

	// RVA: 0x18CC730 Offset: 0x18CAD30 VA: 0x1818CC730 Slot: 30
	public bool get_IsPublic() { }

	// RVA: 0x18CC7B0 Offset: 0x18CADB0 VA: 0x1818CC7B0 Slot: 31
	public bool get_IsStatic() { }

	// RVA: 0x18CC7D0 Offset: 0x18CADD0 VA: 0x1818CC7D0 Slot: 32
	public bool get_IsVirtual() { }

	// RVA: 0x18CC650 Offset: 0x18CAC50 VA: 0x1818CC650 Slot: 33
	public bool get_IsAbstract() { }

	// RVA: 0x18CC680 Offset: 0x18CAC80 VA: 0x1818CC680 Slot: 34
	public bool get_IsConstructor() { }

	// RVA: 0x18CC1E0 Offset: 0x18CA7E0 VA: 0x1818CC1E0 Slot: 35
	public virtual MethodBody GetMethodBody() { }

	// RVA: 0x18CBE80 Offset: 0x18CA480 VA: 0x1818CBE80
	internal static string ConstructParameters(Type[] parameterTypes, CallingConventions callingConvention, bool serialization) { }

	// RVA: 0x18CC050 Offset: 0x18CA650 VA: 0x1818CC050 Slot: 36
	internal virtual string FormatNameAndSig(bool serialization) { }

	// RVA: 0x18CC4B0 Offset: 0x18CAAB0 VA: 0x1818CC4B0 Slot: 37
	internal virtual Type[] GetParameterTypes() { }

	// RVA: 0x10B7D70 Offset: 0x10B6370 VA: 0x1810B7D70 Slot: 38
	internal virtual ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x18CC5E0 Offset: 0x18CABE0 VA: 0x1818CC5E0 Slot: 39
	internal virtual int GetParametersCount() { }

	// RVA: 0x18CC260 Offset: 0x18CA860 VA: 0x1818CC260
	internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle) { }

	// RVA: 0x18CC250 Offset: 0x18CA850 VA: 0x1818CC250
	internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle, RuntimeTypeHandle reflectedType) { }

	// RVA: 0x18CC1D0 Offset: 0x18CA7D0 VA: 0x1818CC1D0
	internal static MethodBody GetMethodBodyInternal(IntPtr handle) { }

	// RVA: 0x18CC1D0 Offset: 0x18CA7D0 VA: 0x1818CC1D0
	internal static MethodBody GetMethodBody(IntPtr handle) { }

	// RVA: 0x18CC230 Offset: 0x18CA830 VA: 0x1818CC230
	private static MethodBase GetMethodFromHandleInternalType(IntPtr method_handle, IntPtr type_handle) { }

	// RVA: 0x18CC240 Offset: 0x18CA840 VA: 0x1818CC240
	internal static MethodBase GetMethodFromHandleInternalType_native(IntPtr method_handle, IntPtr type_handle, bool genericCheck) { }

}

