public abstract class Delegate : ICloneable, ISerializable // TypeDefIndex: 356
{	// Fields
	private IntPtr method_ptr; // 0x10
	private IntPtr invoke_impl; // 0x18
	private object m_target; // 0x20
	private IntPtr method; // 0x28
	private IntPtr delegate_trampoline; // 0x30
	private IntPtr extra_arg; // 0x38
	private IntPtr method_code; // 0x40
	private MethodInfo method_info; // 0x48
	private MethodInfo original_method_info; // 0x50
	private DelegateData data; // 0x58
	private bool method_is_virtual; // 0x60

	// Properties
	public MethodInfo Method { get; }
	public object Target { get; }

	// Methods

	// RVA: 0x82C300 Offset: 0x82A900 VA: 0x18082C300
	public MethodInfo get_Method() { }

	// RVA: 0xD73BA0 Offset: 0xD721A0 VA: 0x180D73BA0
	private MethodInfo GetVirtualMethod_internal() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public object get_Target() { }

	// RVA: 0xD72210 Offset: 0xD70810 VA: 0x180D72210
	internal static Delegate CreateDelegate_internal(Type type, object target, MethodInfo info, bool throwOnBindFailure) { }

	// RVA: 0xD73DB0 Offset: 0xD723B0 VA: 0x180D73DB0
	private static bool arg_type_match(Type delArgType, Type argType) { }

	// RVA: 0xD73F60 Offset: 0xD72560 VA: 0x180D73F60
	private static bool arg_type_match_this(Type delArgType, Type argType, bool boxedThis) { }

	// RVA: 0xD74120 Offset: 0xD72720 VA: 0x180D74120
	private static bool return_type_match(Type delReturnType, Type returnType) { }

	// RVA: 0xD72220 Offset: 0xD70820 VA: 0x180D72220
	public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method, bool throwOnBindFailure) { }

	// RVA: 0xD72340 Offset: 0xD70940 VA: 0x180D72340
	private static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method, bool throwOnBindFailure, bool allowClosed) { }

	// RVA: 0xD72240 Offset: 0xD70840 VA: 0x180D72240
	public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method) { }

	// RVA: 0xD72FF0 Offset: 0xD715F0 VA: 0x180D72FF0
	public static Delegate CreateDelegate(Type type, MethodInfo method, bool throwOnBindFailure) { }

	// RVA: 0xD72FC0 Offset: 0xD715C0 VA: 0x180D72FC0
	public static Delegate CreateDelegate(Type type, MethodInfo method) { }

	// RVA: 0xD72260 Offset: 0xD70860 VA: 0x180D72260
	public static Delegate CreateDelegate(Type type, object target, string method) { }

	// RVA: 0xD73300 Offset: 0xD71900 VA: 0x180D73300
	private static MethodInfo GetCandidateMethod(Type type, Type target, string method, BindingFlags bflags, bool ignoreCase, bool throwOnBindFailure) { }

	// RVA: 0xD73020 Offset: 0xD71620 VA: 0x180D73020
	public static Delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase, bool throwOnBindFailure) { }

	// RVA: 0xD72EC0 Offset: 0xD714C0 VA: 0x180D72EC0
	public static Delegate CreateDelegate(Type type, Type target, string method) { }

	// RVA: 0xD72DC0 Offset: 0xD713C0 VA: 0x180D72DC0
	public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase, bool throwOnBindFailure) { }

	// RVA: 0xD72CD0 Offset: 0xD712D0 VA: 0x180D72CD0
	public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase) { }

	// RVA: 0xD71D90 Offset: 0xD70390 VA: 0x180D71D90 Slot: 6
	public virtual object Clone() { }

	// RVA: 0xD73140 Offset: 0xD71740 VA: 0x180D73140 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xD73740 Offset: 0xD71D40 VA: 0x180D73740 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xD73880 Offset: 0xD71E80 VA: 0x180D73880 Slot: 7
	protected virtual MethodInfo GetMethodImpl() { }

	// RVA: 0xD73970 Offset: 0xD71F70 VA: 0x180D73970 Slot: 8
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xD737D0 Offset: 0xD71DD0 VA: 0x180D737D0 Slot: 9
	public virtual Delegate[] GetInvocationList() { }

	// RVA: 0xD72030 Offset: 0xD70630 VA: 0x180D72030
	public static Delegate Combine(Delegate a, Delegate b) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0xD71E10 Offset: 0xD70410 VA: 0x180D71E10
	public static Delegate Combine(Delegate[] delegates) { }

	// RVA: 0xD71DA0 Offset: 0xD703A0 VA: 0x180D71DA0 Slot: 10
	protected virtual Delegate CombineImpl(Delegate d) { }

	// RVA: 0xD73BE0 Offset: 0xD721E0 VA: 0x180D73BE0
	public static Delegate Remove(Delegate source, Delegate value) { }

	// RVA: 0xD73BB0 Offset: 0xD721B0 VA: 0x180D73BB0 Slot: 11
	protected virtual Delegate RemoveImpl(Delegate d) { }

	// RVA: 0xD740F0 Offset: 0xD726F0 VA: 0x180D740F0
	public static bool op_Equality(Delegate d1, Delegate d2) { }

	// RVA: 0xD72200 Offset: 0xD70800 VA: 0x180D72200
	internal static Delegate CreateDelegateNoSecurityCheck(RuntimeType type, object firstArgument, MethodInfo method) { }

	// RVA: 0xD71D80 Offset: 0xD70380 VA: 0x180D71D80
	internal static MulticastDelegate AllocDelegateLike_internal(Delegate d) { }

}

