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

	// RVA: 0x82BDB0 Offset: 0x82A3B0 VA: 0x18082BDB0
	public MethodInfo get_Method() { }

	// RVA: 0xD730F0 Offset: 0xD716F0 VA: 0x180D730F0
	private MethodInfo GetVirtualMethod_internal() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public object get_Target() { }

	// RVA: 0xD71760 Offset: 0xD6FD60 VA: 0x180D71760
	internal static Delegate CreateDelegate_internal(Type type, object target, MethodInfo info, bool throwOnBindFailure) { }

	// RVA: 0xD73300 Offset: 0xD71900 VA: 0x180D73300
	private static bool arg_type_match(Type delArgType, Type argType) { }

	// RVA: 0xD734B0 Offset: 0xD71AB0 VA: 0x180D734B0
	private static bool arg_type_match_this(Type delArgType, Type argType, bool boxedThis) { }

	// RVA: 0xD73670 Offset: 0xD71C70 VA: 0x180D73670
	private static bool return_type_match(Type delReturnType, Type returnType) { }

	// RVA: 0xD71770 Offset: 0xD6FD70 VA: 0x180D71770
	public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method, bool throwOnBindFailure) { }

	// RVA: 0xD71890 Offset: 0xD6FE90 VA: 0x180D71890
	private static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method, bool throwOnBindFailure, bool allowClosed) { }

	// RVA: 0xD71790 Offset: 0xD6FD90 VA: 0x180D71790
	public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method) { }

	// RVA: 0xD72540 Offset: 0xD70B40 VA: 0x180D72540
	public static Delegate CreateDelegate(Type type, MethodInfo method, bool throwOnBindFailure) { }

	// RVA: 0xD72510 Offset: 0xD70B10 VA: 0x180D72510
	public static Delegate CreateDelegate(Type type, MethodInfo method) { }

	// RVA: 0xD717B0 Offset: 0xD6FDB0 VA: 0x180D717B0
	public static Delegate CreateDelegate(Type type, object target, string method) { }

	// RVA: 0xD72850 Offset: 0xD70E50 VA: 0x180D72850
	private static MethodInfo GetCandidateMethod(Type type, Type target, string method, BindingFlags bflags, bool ignoreCase, bool throwOnBindFailure) { }

	// RVA: 0xD72570 Offset: 0xD70B70 VA: 0x180D72570
	public static Delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase, bool throwOnBindFailure) { }

	// RVA: 0xD72410 Offset: 0xD70A10 VA: 0x180D72410
	public static Delegate CreateDelegate(Type type, Type target, string method) { }

	// RVA: 0xD72310 Offset: 0xD70910 VA: 0x180D72310
	public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase, bool throwOnBindFailure) { }

	// RVA: 0xD72220 Offset: 0xD70820 VA: 0x180D72220
	public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase) { }

	// RVA: 0xD712E0 Offset: 0xD6F8E0 VA: 0x180D712E0 Slot: 6
	public virtual object Clone() { }

	// RVA: 0xD72690 Offset: 0xD70C90 VA: 0x180D72690 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xD72C90 Offset: 0xD71290 VA: 0x180D72C90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xD72DD0 Offset: 0xD713D0 VA: 0x180D72DD0 Slot: 7
	protected virtual MethodInfo GetMethodImpl() { }

	// RVA: 0xD72EC0 Offset: 0xD714C0 VA: 0x180D72EC0 Slot: 8
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xD72D20 Offset: 0xD71320 VA: 0x180D72D20 Slot: 9
	public virtual Delegate[] GetInvocationList() { }

	// RVA: 0xD71580 Offset: 0xD6FB80 VA: 0x180D71580
	public static Delegate Combine(Delegate a, Delegate b) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0xD71360 Offset: 0xD6F960 VA: 0x180D71360
	public static Delegate Combine(Delegate[] delegates) { }

	// RVA: 0xD712F0 Offset: 0xD6F8F0 VA: 0x180D712F0 Slot: 10
	protected virtual Delegate CombineImpl(Delegate d) { }

	// RVA: 0xD73130 Offset: 0xD71730 VA: 0x180D73130
	public static Delegate Remove(Delegate source, Delegate value) { }

	// RVA: 0xD73100 Offset: 0xD71700 VA: 0x180D73100 Slot: 11
	protected virtual Delegate RemoveImpl(Delegate d) { }

	// RVA: 0xD73640 Offset: 0xD71C40 VA: 0x180D73640
	public static bool op_Equality(Delegate d1, Delegate d2) { }

	// RVA: 0xD71750 Offset: 0xD6FD50 VA: 0x180D71750
	internal static Delegate CreateDelegateNoSecurityCheck(RuntimeType type, object firstArgument, MethodInfo method) { }

	// RVA: 0xD712D0 Offset: 0xD6F8D0 VA: 0x180D712D0
	internal static MulticastDelegate AllocDelegateLike_internal(Delegate d) { }

}

