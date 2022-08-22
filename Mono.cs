internal struct MonoAssemblyName // TypeDefIndex: 19
{	// Fields
	internal IntPtr name; // 0x0
	internal IntPtr culture; // 0x8
	internal IntPtr hash_value; // 0x10
	internal IntPtr public_key; // 0x18
	[FixedBufferAttribute] // RVA: 0xE6F10 Offset: 0xE6310 VA: 0x1800E6F10
	internal MonoAssemblyName.<public_key_token>e__FixedBuffer public_key_token; // 0x20
	internal uint hash_alg; // 0x34
	internal uint hash_len; // 0x38
	internal uint flags; // 0x3C
	internal ushort major; // 0x40
	internal ushort minor; // 0x42
	internal ushort build; // 0x44
	internal ushort revision; // 0x46
	internal ushort arch; // 0x48

}

public struct MonoAssemblyName.<public_key_token>e__FixedBuffer // TypeDefIndex: 20
{	// Fields
	public byte FixedElementField; // 0x0

}

internal class MonoTODOAttribute : Attribute // TypeDefIndex: 139
{	// Fields
	private string comment; // 0x10

	// Methods

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0x7B9710 Offset: 0x7B7D10 VA: 0x1807B9710
	public void .ctor(string comment) { }

}

internal class MonoLimitationAttribute : MonoTODOAttribute // TypeDefIndex: 140
{	// Methods

	// RVA: 0x7B9710 Offset: 0x7B7D10 VA: 0x1807B9710
	public void .ctor(string comment) { }

}

internal class MonoTypeInfo // TypeDefIndex: 344
{	// Fields
	public string full_name; // 0x10
	public MonoCMethod default_ctor; // 0x18

	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void .ctor() { }

}

internal class MonoAsyncCall // TypeDefIndex: 372
{	// Fields
	private object msg; // 0x10
	private IntPtr cb_method; // 0x18
	private object cb_target; // 0x20
	private object state; // 0x28
	private object res; // 0x30
	private object out_args; // 0x38

	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void .ctor() { }

}

internal static class MonoCustomAttrs // TypeDefIndex: 373
{	// Fields
	private static Assembly corlib; // 0x0
	[ThreadStaticAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Dictionary<Type, AttributeUsageAttribute> usage_cache; // 0x80000000
	private static readonly AttributeUsageAttribute DefaultAttributeUsage; // 0x8

	// Methods

	// RVA: 0x1676500 Offset: 0x1674B00 VA: 0x181676500
	private static bool IsUserCattrProvider(object obj) { }

	// RVA: 0x1674F80 Offset: 0x1673580 VA: 0x181674F80
	internal static object[] GetCustomAttributesInternal(ICustomAttributeProvider obj, Type attributeType, bool pseudoAttrs) { }

	// RVA: 0x1675BB0 Offset: 0x16741B0 VA: 0x181675BB0
	internal static object[] GetPseudoCustomAttributes(ICustomAttributeProvider obj, Type attributeType) { }

	// RVA: 0x1676080 Offset: 0x1674680 VA: 0x181676080
	private static object[] GetPseudoCustomAttributes(Type type) { }

	// RVA: 0x1674CF0 Offset: 0x16732F0 VA: 0x181674CF0
	internal static object[] GetCustomAttributesBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly) { }

	// RVA: 0x1674F90 Offset: 0x1673590 VA: 0x181674F90
	internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	// RVA: 0x1675A40 Offset: 0x1674040 VA: 0x181675A40
	internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, bool inherit) { }

	// RVA: 0x1674ED0 Offset: 0x16734D0 VA: 0x181674ED0
	private static CustomAttributeData[] GetCustomAttributesDataInternal(ICustomAttributeProvider obj) { }

	// RVA: 0x1674EE0 Offset: 0x16734E0 VA: 0x181674EE0
	internal static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj) { }

	// RVA: 0x1676230 Offset: 0x1674830 VA: 0x181676230
	internal static bool IsDefined(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	// RVA: 0x1676220 Offset: 0x1674820 VA: 0x181676220
	internal static bool IsDefinedInternal(ICustomAttributeProvider obj, Type AttributeType) { }

	// RVA: 0x16746C0 Offset: 0x1672CC0 VA: 0x1816746C0
	private static PropertyInfo GetBasePropertyDefinition(MonoProperty property) { }

	// RVA: 0x16744F0 Offset: 0x1672AF0 VA: 0x1816744F0
	private static EventInfo GetBaseEventDefinition(MonoEvent evt) { }

	// RVA: 0x16749D0 Offset: 0x1672FD0 VA: 0x1816749D0
	private static ICustomAttributeProvider GetBase(ICustomAttributeProvider obj) { }

	// RVA: 0x1676740 Offset: 0x1674D40 VA: 0x181676740
	private static AttributeUsageAttribute RetrieveAttributeUsageNoCache(Type attributeType) { }

	// RVA: 0x16769B0 Offset: 0x1674FB0 VA: 0x1816769B0
	private static AttributeUsageAttribute RetrieveAttributeUsage(Type attributeType) { }

	// RVA: 0x1676B20 Offset: 0x1675120 VA: 0x181676B20
	private static void .cctor() { }

}

private class MonoCustomAttrs.AttributeInfo // TypeDefIndex: 374
{	// Fields
	private AttributeUsageAttribute _usage; // 0x10
	private int _inheritanceLevel; // 0x18

	// Properties
	public AttributeUsageAttribute Usage { get; }
	public int InheritanceLevel { get; }

	// Methods

	// RVA: 0x166ED20 Offset: 0x166D320 VA: 0x18166ED20
	public void .ctor(AttributeUsageAttribute usage, int inheritanceLevel) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public AttributeUsageAttribute get_Usage() { }

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	public int get_InheritanceLevel() { }

}

internal sealed class MonoListItem // TypeDefIndex: 375
{	// Fields
	private MonoListItem next; // 0x10
	private object data; // 0x18

	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void .ctor() { }

}

internal class MonoAssembly : RuntimeAssembly // TypeDefIndex: 573
{	// Methods

	// RVA: 0x18CD3D0 Offset: 0x18CB9D0 VA: 0x1818CD3D0 Slot: 27
	public override Type GetType(string name, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x18CD160 Offset: 0x18CB760 VA: 0x1818CD160 Slot: 28
	public override Module GetModule(string name) { }

	// RVA: 0x18CD3C0 Offset: 0x18CB9C0 VA: 0x1818CD3C0 Slot: 29
	public override AssemblyName[] GetReferencedAssemblies() { }

	// RVA: 0x18CD2B0 Offset: 0x18CB8B0 VA: 0x1818CD2B0 Slot: 30
	public override Module[] GetModules(bool getResourceModules) { }

	// RVA: 0x18C5C30 Offset: 0x18C4230 VA: 0x1818C5C30
	public void .ctor() { }

}

internal struct MonoEventInfo // TypeDefIndex: 574
{	// Fields
	public Type declaring_type; // 0x0
	public Type reflected_type; // 0x8
	public string name; // 0x10
	public MethodInfo add_method; // 0x18
	public MethodInfo remove_method; // 0x20
	public MethodInfo raise_method; // 0x28
	public EventAttributes attrs; // 0x30
	public MethodInfo[] other_methods; // 0x38

	// Methods

	// RVA: 0x18CDDD0 Offset: 0x18CC3D0 VA: 0x1818CDDD0
	private static void get_event_info(MonoEvent ev, out MonoEventInfo info) { }

	// RVA: 0x18CDD90 Offset: 0x18CC390 VA: 0x1818CDD90
	internal static MonoEventInfo GetEventInfo(MonoEvent ev) { }

}

internal sealed class MonoEvent : RuntimeEventInfo // TypeDefIndex: 576
{	// Fields
	private IntPtr klass; // 0x18
	private IntPtr handle; // 0x20

	// Properties
	public override Type DeclaringType { get; }
	public override Type ReflectedType { get; }
	public override string Name { get; }

	// Methods

	// RVA: 0x18CDDE0 Offset: 0x18CC3E0 VA: 0x1818CDDE0 Slot: 18
	public override MethodInfo GetAddMethod(bool nonPublic) { }

	// RVA: 0x18CDF60 Offset: 0x18CC560 VA: 0x1818CDF60 Slot: 19
	public override MethodInfo GetRaiseMethod(bool nonPublic) { }

	// RVA: 0x18CDFF0 Offset: 0x18CC5F0 VA: 0x1818CDFF0 Slot: 20
	public override MethodInfo GetRemoveMethod(bool nonPublic) { }

	// RVA: 0x18CE180 Offset: 0x18CC780 VA: 0x1818CE180 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x18CE1E0 Offset: 0x18CC7E0 VA: 0x1818CE1E0 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18CE1B0 Offset: 0x18CC7B0 VA: 0x1818CE1B0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18CE100 Offset: 0x18CC700 VA: 0x1818CE100 Slot: 3
	public override string ToString() { }

	// RVA: 0x18CE080 Offset: 0x18CC680 VA: 0x1818CE080 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18CDEF0 Offset: 0x18CC4F0 VA: 0x1818CDEF0 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18CDE70 Offset: 0x18CC470 VA: 0x1818CDE70 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18C67B0 Offset: 0x18C4DB0 VA: 0x1818C67B0 Slot: 14
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

internal class MonoField : RtFieldInfo // TypeDefIndex: 579
{	// Fields
	internal IntPtr klass; // 0x10
	internal RuntimeFieldHandle fhandle; // 0x18
	private string name; // 0x20
	private Type type; // 0x28
	private FieldAttributes attrs; // 0x30

	// Properties
	public override FieldAttributes Attributes { get; }
	public override RuntimeFieldHandle FieldHandle { get; }
	public override Type FieldType { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }

	// Methods

	// RVA: 0xA39490 Offset: 0xA37A90 VA: 0x180A39490 Slot: 17
	public override FieldAttributes get_Attributes() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 18
	public override RuntimeFieldHandle get_FieldHandle() { }

	// RVA: 0xD73BA0 Offset: 0xD721A0 VA: 0x180D73BA0
	private Type ResolveType() { }

	// RVA: 0x18CE950 Offset: 0x18CCF50 VA: 0x1818CE950 Slot: 19
	public override Type get_FieldType() { }

	// RVA: 0x18CE3B0 Offset: 0x18CC9B0 VA: 0x1818CE3B0
	private Type GetParentType(bool declaring) { }

	// RVA: 0x18CE9E0 Offset: 0x18CCFE0 VA: 0x1818CE9E0 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18CE940 Offset: 0x18CCF40 VA: 0x1818CE940 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18CE570 Offset: 0x18CCB70 VA: 0x1818CE570 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18CE330 Offset: 0x18CC930 VA: 0x1818CE330 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18CE2B0 Offset: 0x18CC8B0 VA: 0x1818CE2B0 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18CE3A0 Offset: 0x18CC9A0 VA: 0x1818CE3A0 Slot: 29
	internal override int GetFieldOffset() { }

	// RVA: 0x18CE3D0 Offset: 0x18CC9D0 VA: 0x1818CE3D0
	private object GetValueInternal(object obj) { }

	// RVA: 0x18CE3E0 Offset: 0x18CC9E0 VA: 0x1818CE3E0 Slot: 20
	public override object GetValue(object obj) { }

	// RVA: 0x18CE8E0 Offset: 0x18CCEE0 VA: 0x1818CE8E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1299720 Offset: 0x1297D20 VA: 0x181299720
	private static void SetValueInternal(FieldInfo fi, object obj, object value) { }

	// RVA: 0x18CE5F0 Offset: 0x18CCBF0 VA: 0x1818CE5F0 Slot: 27
	public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	// RVA: 0x18CE3C0 Offset: 0x18CC9C0 VA: 0x1818CE3C0 Slot: 31
	public override object GetRawConstantValue() { }

	// RVA: 0x18C67B0 Offset: 0x18C4DB0 VA: 0x1818C67B0 Slot: 14
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x18CE210 Offset: 0x18CC810 VA: 0x1818CE210
	private void CheckGeneric() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

internal struct MonoMethodInfo // TypeDefIndex: 580
{	// Fields
	private Type parent; // 0x0
	private Type ret; // 0x8
	internal MethodAttributes attrs; // 0x10
	internal MethodImplAttributes iattrs; // 0x14
	private CallingConventions callconv; // 0x18

	// Methods

	// RVA: 0x18CEB00 Offset: 0x18CD100 VA: 0x1818CEB00
	private static void get_method_info(IntPtr handle, out MonoMethodInfo info) { }

	// RVA: 0x18CE9F0 Offset: 0x18CCFF0 VA: 0x1818CE9F0
	private static int get_method_attributes(IntPtr handle) { }

	// RVA: 0x18CEA90 Offset: 0x18CD090 VA: 0x1818CEA90
	internal static MonoMethodInfo GetMethodInfo(IntPtr handle) { }

	// RVA: 0x18CEA30 Offset: 0x18CD030 VA: 0x1818CEA30
	internal static Type GetDeclaringType(IntPtr handle) { }

	// RVA: 0x18CEAD0 Offset: 0x18CD0D0 VA: 0x1818CEAD0
	internal static Type GetReturnType(IntPtr handle) { }

	// RVA: 0x18CE9F0 Offset: 0x18CCFF0 VA: 0x1818CE9F0
	internal static MethodAttributes GetAttributes(IntPtr handle) { }

	// RVA: 0x18CEA00 Offset: 0x18CD000 VA: 0x1818CEA00
	internal static CallingConventions GetCallingConvention(IntPtr handle) { }

	// RVA: 0x18CEA60 Offset: 0x18CD060 VA: 0x1818CEA60
	internal static MethodImplAttributes GetMethodImplementationFlags(IntPtr handle) { }

	// RVA: 0x18CEAC0 Offset: 0x18CD0C0 VA: 0x1818CEAC0
	private static ParameterInfo[] get_parameter_info(IntPtr handle, MemberInfo member) { }

	// RVA: 0x18CEAC0 Offset: 0x18CD0C0 VA: 0x1818CEAC0
	internal static ParameterInfo[] GetParametersInfo(IntPtr handle, MemberInfo member) { }

}

internal class MonoMethod : RuntimeMethodInfo // TypeDefIndex: 582
{	// Fields
	internal IntPtr mhandle; // 0x10
	private string name; // 0x18
	private Type reftype; // 0x20

	// Properties
	public override Type ReturnType { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override MethodAttributes Attributes { get; }
	public override CallingConventions CallingConvention { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override bool IsGenericMethodDefinition { get; }
	public override bool IsGenericMethod { get; }
	public override bool ContainsGenericParameters { get; }
	public override bool IsSecurityCritical { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x18CF920 Offset: 0x18CDF20 VA: 0x1818CF920
	internal static string get_name(MethodBase method) { }

	// RVA: 0x18CF910 Offset: 0x18CDF10 VA: 0x1818CF910
	internal static MonoMethod get_base_method(MonoMethod method, bool definition) { }

	// RVA: 0x18CEE40 Offset: 0x18CD440 VA: 0x1818CEE40 Slot: 41
	public override MethodInfo GetBaseDefinition() { }

	// RVA: 0x18CEE50 Offset: 0x18CD450 VA: 0x1818CEE50 Slot: 45
	internal override MethodInfo GetBaseMethod() { }

	// RVA: 0x18CF8E0 Offset: 0x18CDEE0 VA: 0x1818CF8E0 Slot: 40
	public override Type get_ReturnType() { }

	// RVA: 0x18CD780 Offset: 0x18CBD80 VA: 0x1818CD780 Slot: 19
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x18CF040 Offset: 0x18CD640 VA: 0x1818CF040 Slot: 18
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x18CD7E0 Offset: 0x18CBDE0 VA: 0x1818CD7E0 Slot: 38
	internal override ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x18CF010 Offset: 0x18CD610 VA: 0x1818CF010 Slot: 39
	internal override int GetParametersCount() { }

	// RVA: 0x18CF290 Offset: 0x18CD890 VA: 0x1818CF290
	internal object InternalInvoke(object obj, object[] parameters, out Exception exc) { }

	[DebuggerHiddenAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[DebuggerStepThroughAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x18CF2A0 Offset: 0x18CD8A0 VA: 0x1818CF2A0 Slot: 22
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x18CEB10 Offset: 0x18CD110 VA: 0x1818CEB10
	internal static void ConvertValues(Binder binder, object[] args, ParameterInfo[] pinfo, CultureInfo culture, BindingFlags invokeAttr) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 20
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x18CDCD0 Offset: 0x18CC2D0 VA: 0x1818CDCD0 Slot: 21
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x18CDCE0 Offset: 0x18CC2E0 VA: 0x1818CDCE0 Slot: 23
	public override CallingConventions get_CallingConvention() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18CDD50 Offset: 0x18CC350 VA: 0x1818CDD50 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x18CDD80 Offset: 0x18CC380 VA: 0x1818CDD80 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18CF430 Offset: 0x18CDA30 VA: 0x1818CF430 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18CEE60 Offset: 0x18CD460 VA: 0x1818CEE60 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18CEED0 Offset: 0x18CD4D0 VA: 0x1818CEED0 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18CF000 Offset: 0x18CD600 VA: 0x1818CF000
	internal void GetPInvoke(out PInvokeAttributes flags, out string entryPoint, out string dllName) { }

	// RVA: 0x18CF0E0 Offset: 0x18CD6E0 VA: 0x1818CF0E0
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x18CF4C0 Offset: 0x18CDAC0 VA: 0x1818CF4C0 Slot: 43
	public override MethodInfo MakeGenericMethod(Type[] methodInstantiation) { }

	// RVA: 0x18CF4B0 Offset: 0x18CDAB0 VA: 0x1818CF4B0
	private MethodInfo MakeGenericMethod_impl(Type[] types) { }

	// RVA: 0x18CEF50 Offset: 0x18CD550 VA: 0x1818CEF50 Slot: 24
	public override Type[] GetGenericArguments() { }

	// RVA: 0x18CEF60 Offset: 0x18CD560 VA: 0x1818CEF60
	private MethodInfo GetGenericMethodDefinition_impl() { }

	// RVA: 0x18CEF70 Offset: 0x18CD570 VA: 0x1818CEF70 Slot: 42
	public override MethodInfo GetGenericMethodDefinition() { }

	// RVA: 0x18CF8C0 Offset: 0x18CDEC0 VA: 0x1818CF8C0 Slot: 25
	public override bool get_IsGenericMethodDefinition() { }

	// RVA: 0x18CF8D0 Offset: 0x18CDED0 VA: 0x1818CF8D0 Slot: 27
	public override bool get_IsGenericMethod() { }

	// RVA: 0x18CF7E0 Offset: 0x18CDDE0 VA: 0x1818CF7E0 Slot: 26
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x18CD770 Offset: 0x18CBD70 VA: 0x1818CD770 Slot: 35
	public override MethodBody GetMethodBody() { }

	// RVA: 0x18C67B0 Offset: 0x18C4DB0 VA: 0x1818C67B0 Slot: 14
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x5B1870 Offset: 0x5AFE70 VA: 0x1805B1870
	private static int get_core_clr_security_level() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 28
	public override bool get_IsSecurityCritical() { }

}

internal class MonoCMethod : RuntimeConstructorInfo // TypeDefIndex: 584
{	// Fields
	internal IntPtr mhandle; // 0x10
	private string name; // 0x18
	private Type reftype; // 0x20

	// Properties
	public override RuntimeMethodHandle MethodHandle { get; }
	public override MethodAttributes Attributes { get; }
	public override CallingConventions CallingConvention { get; }
	public override bool ContainsGenericParameters { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override bool IsSecurityCritical { get; }

	// Methods

	// RVA: 0x18CD780 Offset: 0x18CBD80 VA: 0x1818CD780 Slot: 19
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x18CD7E0 Offset: 0x18CBDE0 VA: 0x1818CD7E0 Slot: 18
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x18CD7E0 Offset: 0x18CBDE0 VA: 0x1818CD7E0 Slot: 38
	internal override ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x18CD7B0 Offset: 0x18CBDB0 VA: 0x1818CD7B0 Slot: 39
	internal override int GetParametersCount() { }

	// RVA: 0x18CD7F0 Offset: 0x18CBDF0 VA: 0x1818CD7F0
	internal object InternalInvoke(object obj, object[] parameters, out Exception exc) { }

	[DebuggerStepThroughAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[DebuggerHiddenAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x18CD900 Offset: 0x18CBF00 VA: 0x1818CD900 Slot: 22
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x18CD4B0 Offset: 0x18CBAB0 VA: 0x1818CD4B0
	private object DoInvoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x18CD800 Offset: 0x18CBE00 VA: 0x1818CD800
	public object InternalInvoke(object obj, object[] parameters) { }

	[DebuggerHiddenAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[DebuggerStepThroughAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x18CD8D0 Offset: 0x18CBED0 VA: 0x1818CD8D0 Slot: 40
	public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 20
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x18CDCD0 Offset: 0x18CC2D0 VA: 0x1818CDCD0 Slot: 21
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x18CDCE0 Offset: 0x18CC2E0 VA: 0x1818CDCE0 Slot: 23
	public override CallingConventions get_CallingConvention() { }

	// RVA: 0x18CDD10 Offset: 0x18CC310 VA: 0x1818CDD10 Slot: 26
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18CDD50 Offset: 0x18CC350 VA: 0x1818CDD50 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x18CDD80 Offset: 0x18CC380 VA: 0x1818CDD80 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18CDA30 Offset: 0x18CC030 VA: 0x1818CDA30 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18CD700 Offset: 0x18CBD00 VA: 0x1818CD700 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18CD680 Offset: 0x18CBC80 VA: 0x1818CD680 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18CD770 Offset: 0x18CBD70 VA: 0x1818CD770 Slot: 35
	public override MethodBody GetMethodBody() { }

	// RVA: 0x18CDAB0 Offset: 0x18CC0B0 VA: 0x1818CDAB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x18C67B0 Offset: 0x18C4DB0 VA: 0x1818C67B0 Slot: 14
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x5B1870 Offset: 0x5AFE70 VA: 0x1805B1870
	private static int get_core_clr_security_level() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 28
	public override bool get_IsSecurityCritical() { }

	// RVA: 0x18CDC70 Offset: 0x18CC270 VA: 0x1818CDC70
	public void .ctor() { }

}

internal class MonoModule : RuntimeModule // TypeDefIndex: 586
{	// Properties
	public override Assembly Assembly { get; }
	public override string ScopeName { get; }
	public override Guid ModuleVersionId { get; }

	// Methods

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 10
	public override Assembly get_Assembly() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0 Slot: 11
	public override string get_ScopeName() { }

	// RVA: 0x18CFCA0 Offset: 0x18CE2A0 VA: 0x1818CFCA0 Slot: 12
	public override Guid get_ModuleVersionId() { }

	// RVA: 0x8C1660 Offset: 0x8BFC60 VA: 0x1808C1660 Slot: 13
	public override bool IsResource() { }

	// RVA: 0x18CF9B0 Offset: 0x18CDFB0 VA: 0x1818CF9B0 Slot: 14
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18CF930 Offset: 0x18CDF30 VA: 0x1818CF930 Slot: 15
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18CFBC0 Offset: 0x18CE1C0 VA: 0x1818CFBC0 Slot: 16
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18CFA20 Offset: 0x18CE020 VA: 0x1818CFA20 Slot: 8
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18CFB40 Offset: 0x18CE140 VA: 0x1818CFB40
	internal RuntimeAssembly GetRuntimeAssembly() { }

	// RVA: 0x18CFC40 Offset: 0x18CE240 VA: 0x1818CFC40
	public void .ctor() { }

}

internal class MonoParameterInfo : RuntimeParameterInfo // TypeDefIndex: 588
{	// Properties
	public override object DefaultValue { get; }

	// Methods

	// RVA: 0x18CFE40 Offset: 0x18CE440 VA: 0x1818CFE40
	internal void .ctor(ParameterInfo pinfo, MemberInfo member) { }

	// RVA: 0x18CFF10 Offset: 0x18CE510 VA: 0x1818CFF10 Slot: 13
	public override object get_DefaultValue() { }

	// RVA: 0x18CFCD0 Offset: 0x18CE2D0 VA: 0x1818CFCD0 Slot: 14
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18CFD40 Offset: 0x18CE340 VA: 0x1818CFD40 Slot: 15
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18CFDC0 Offset: 0x18CE3C0 VA: 0x1818CFDC0 Slot: 16
	public override bool IsDefined(Type attributeType, bool inherit) { }

}

internal struct MonoPropertyInfo // TypeDefIndex: 589
{	// Fields
	public Type parent; // 0x0
	public Type declaring_type; // 0x8
	public string name; // 0x10
	public MethodInfo get_method; // 0x18
	public MethodInfo set_method; // 0x20
	public PropertyAttributes attrs; // 0x28

	// Methods

	// RVA: 0x18D0190 Offset: 0x18CE790 VA: 0x1818D0190
	internal static void get_property_info(MonoProperty prop, ref MonoPropertyInfo info, PInfo req_info) { }

	// RVA: 0x18D0180 Offset: 0x18CE780 VA: 0x1818D0180
	internal static Type[] GetTypeModifiers(MonoProperty prop, bool optional) { }

	// RVA: 0xD73BA0 Offset: 0xD721A0 VA: 0x180D73BA0
	internal static object get_default_value(MonoProperty prop) { }

}

internal class MonoProperty : RuntimePropertyInfo // TypeDefIndex: 592
{	// Fields
	internal IntPtr klass; // 0x10
	internal IntPtr prop; // 0x18
	private MonoPropertyInfo info; // 0x20
	private PInfo cached; // 0x50
	private MonoProperty.GetterAdapter cached_getter; // 0x58

	// Properties
	public override PropertyAttributes Attributes { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override Type PropertyType { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }

	// Methods

	// RVA: 0x18D01A0 Offset: 0x18CE7A0 VA: 0x1818D01A0
	private void CachePropertyInfo(PInfo flags) { }

	// RVA: 0x18D11E0 Offset: 0x18CF7E0 VA: 0x1818D11E0 Slot: 17
	public override PropertyAttributes get_Attributes() { }

	// RVA: 0x18D1220 Offset: 0x18CF820 VA: 0x1818D1220 Slot: 18
	public override bool get_CanRead() { }

	// RVA: 0x18D1270 Offset: 0x18CF870 VA: 0x1818D1270 Slot: 19
	public override bool get_CanWrite() { }

	// RVA: 0x18D1340 Offset: 0x18CF940 VA: 0x1818D1340 Slot: 20
	public override Type get_PropertyType() { }

	// RVA: 0x18D1420 Offset: 0x18CFA20 VA: 0x1818D1420 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18D12C0 Offset: 0x18CF8C0 VA: 0x1818D12C0 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x18D1300 Offset: 0x18CF900 VA: 0x1818D1300 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18D0560 Offset: 0x18CEB60 VA: 0x1818D0560 Slot: 21
	public override MethodInfo[] GetAccessors(bool nonPublic) { }

	// RVA: 0x18D0830 Offset: 0x18CEE30 VA: 0x1818D0830 Slot: 23
	public override MethodInfo GetGetMethod(bool nonPublic) { }

	// RVA: 0x18D08E0 Offset: 0x18CEEE0 VA: 0x1818D08E0 Slot: 24
	public override ParameterInfo[] GetIndexParameters() { }

	// RVA: 0x18D0CA0 Offset: 0x18CF2A0 VA: 0x1818D0CA0 Slot: 26
	public override MethodInfo GetSetMethod(bool nonPublic) { }

	// RVA: 0xD73BA0 Offset: 0xD721A0 VA: 0x180D73BA0 Slot: 33
	public override object GetConstantValue() { }

	// RVA: 0xD73BA0 Offset: 0xD721A0 VA: 0x180D73BA0 Slot: 34
	public override object GetRawConstantValue() { }

	// RVA: 0x18D0F30 Offset: 0x18CF530 VA: 0x1818D0F30 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18D07D0 Offset: 0x18CEDD0 VA: 0x1818D07D0 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18D0760 Offset: 0x18CED60 VA: 0x1818D0760 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: -1 Offset: -1
	private static object GetterAdapterFrame<T, R>(MonoProperty.Getter<T, R> getter, object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED74D0 Offset: 0xED5AD0 VA: 0x180ED74D0
	|-MonoProperty.GetterAdapterFrame<object, object>
	*/

	// RVA: -1 Offset: -1
	private static object StaticGetterAdapterFrame<R>(MonoProperty.StaticGetter<R> getter, object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED7560 Offset: 0xED5B60 VA: 0x180ED7560
	|-MonoProperty.StaticGetterAdapterFrame<object>
	*/

	// RVA: 0x18D01E0 Offset: 0x18CE7E0 VA: 0x1818D01E0
	private static MonoProperty.GetterAdapter CreateGetterDelegate(MethodInfo method) { }

	// RVA: 0x18D0D50 Offset: 0x18CF350 VA: 0x1818D0D50 Slot: 27
	public override object GetValue(object obj, object[] index) { }

	// RVA: 0x18D0D90 Offset: 0x18CF390 VA: 0x1818D0D90 Slot: 28
	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x18D0FA0 Offset: 0x18CF5A0 VA: 0x1818D0FA0 Slot: 30
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x18D0BC0 Offset: 0x18CF1C0 VA: 0x1818D0BC0 Slot: 31
	public override Type[] GetOptionalCustomModifiers() { }

	// RVA: 0x18D0C30 Offset: 0x18CF230 VA: 0x1818D0C30 Slot: 32
	public override Type[] GetRequiredCustomModifiers() { }

	// RVA: 0x18C67B0 Offset: 0x18C4DB0 VA: 0x1818C67B0 Slot: 14
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class MonoProperty.GetterAdapter : MulticastDelegate // TypeDefIndex: 593
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x133A9A0 Offset: 0x1338FA0 VA: 0x18133A9A0 Slot: 12
	public virtual object Invoke(object _this) { }

	// RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380 Slot: 13
	public virtual IAsyncResult BeginInvoke(object _this, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual object EndInvoke(IAsyncResult result) { }

}

private sealed class MonoProperty.Getter<T, R> : MulticastDelegate // TypeDefIndex: 594
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	|-MonoProperty.Getter<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual R Invoke(T _this) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x189F240 Offset: 0x189D840 VA: 0x18189F240
	|-MonoProperty.Getter<object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(T _this, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380
	|-MonoProperty.Getter<object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual R EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0
	|-MonoProperty.Getter<object, object>.EndInvoke
	*/

}

private sealed class MonoProperty.StaticGetter<R> : MulticastDelegate // TypeDefIndex: 595
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	|-MonoProperty.StaticGetter<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual R Invoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD510C0 Offset: 0xD4F6C0 VA: 0x180D510C0
	|-MonoProperty.StaticGetter<object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A190 Offset: 0x498790 VA: 0x18049A190
	|-MonoProperty.StaticGetter<object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual R EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0
	|-MonoProperty.StaticGetter<object>.EndInvoke
	*/

}

internal enum MonoFileType // TypeDefIndex: 674
{	// Fields
	public int value__; // 0x0
	public const MonoFileType Unknown = 0;
	public const MonoFileType Disk = 1;
	public const MonoFileType Char = 2;
	public const MonoFileType Pipe = 3;
	public const MonoFileType Remote = 32768;

}

internal static class MonoIO // TypeDefIndex: 675
{	// Fields
	public static readonly IntPtr InvalidHandle; // 0x0
	private static bool dump_handles; // 0x8

	// Properties
	public static IntPtr ConsoleOutput { get; }
	public static IntPtr ConsoleInput { get; }
	public static IntPtr ConsoleError { get; }
	public static char VolumeSeparatorChar { get; }
	public static char DirectorySeparatorChar { get; }
	public static char AltDirectorySeparatorChar { get; }
	public static char PathSeparator { get; }

	// Methods

	// RVA: 0x1615330 Offset: 0x1613930 VA: 0x181615330
	public static Exception GetException(MonoIOError error) { }

	// RVA: 0x1614C70 Offset: 0x1613270 VA: 0x181614C70
	public static Exception GetException(string path, MonoIOError error) { }

	// RVA: 0x1614740 Offset: 0x1612D40 VA: 0x181614740
	private static bool CreateDirectory(char* path, out MonoIOError error) { }

	// RVA: 0x1614750 Offset: 0x1612D50 VA: 0x181614750
	public static bool CreateDirectory(string path, out MonoIOError error) { }

	// RVA: 0x1615AB0 Offset: 0x16140B0 VA: 0x181615AB0
	private static bool RemoveDirectory(char* path, out MonoIOError error) { }

	// RVA: 0x1615A40 Offset: 0x1614040 VA: 0x181615A40
	public static bool RemoveDirectory(string path, out MonoIOError error) { }

	// RVA: 0x1614C60 Offset: 0x1613260 VA: 0x181614C60
	public static string GetCurrentDirectory(out MonoIOError error) { }

	// RVA: 0x1615780 Offset: 0x1613D80 VA: 0x181615780
	private static bool MoveFile(char* path, char* dest, out MonoIOError error) { }

	// RVA: 0x1615790 Offset: 0x1613D90 VA: 0x181615790
	public static bool MoveFile(string path, string dest, out MonoIOError error) { }

	// RVA: 0x1614680 Offset: 0x1612C80 VA: 0x181614680
	private static bool CopyFile(char* path, char* dest, bool overwrite, out MonoIOError error) { }

	// RVA: 0x1614690 Offset: 0x1612C90 VA: 0x181614690
	public static bool CopyFile(string path, string dest, bool overwrite, out MonoIOError error) { }

	// RVA: 0x16147C0 Offset: 0x1612DC0 VA: 0x1816147C0
	private static bool DeleteFile(char* path, out MonoIOError error) { }

	// RVA: 0x16147D0 Offset: 0x1612DD0 VA: 0x1816147D0
	public static bool DeleteFile(string path, out MonoIOError error) { }

	// RVA: 0x1615410 Offset: 0x1613A10 VA: 0x181615410
	private static FileAttributes GetFileAttributes(char* path, out MonoIOError error) { }

	// RVA: 0x1615420 Offset: 0x1613A20 VA: 0x181615420
	public static FileAttributes GetFileAttributes(string path, out MonoIOError error) { }

	// RVA: 0x1615640 Offset: 0x1613C40 VA: 0x181615640
	private static MonoFileType GetFileType(IntPtr handle, out MonoIOError error) { }

	// RVA: 0x1615520 Offset: 0x1613B20 VA: 0x181615520
	public static MonoFileType GetFileType(SafeHandle safeHandle, out MonoIOError error) { }

	// RVA: 0x1614C40 Offset: 0x1613240 VA: 0x181614C40
	private static IntPtr FindFirstFile(char* pathWithPattern, out string fileName, out int fileAttr, out int error) { }

	// RVA: 0x1614BB0 Offset: 0x16131B0 VA: 0x181614BB0
	public static IntPtr FindFirstFile(string pathWithPattern, out string fileName, out int fileAttr, out int error) { }

	// RVA: 0x1614C50 Offset: 0x1613250 VA: 0x181614C50
	public static bool FindNextFile(IntPtr hnd, out string fileName, out int fileAttr, out int error) { }

	// RVA: 0x1614BA0 Offset: 0x16131A0 VA: 0x181614BA0
	public static bool FindCloseFile(IntPtr hnd) { }

	// RVA: 0x1614AE0 Offset: 0x16130E0 VA: 0x181614AE0
	public static bool Exists(string path, out MonoIOError error) { }

	// RVA: 0x1614930 Offset: 0x1612F30 VA: 0x181614930
	public static bool ExistsFile(string path, out MonoIOError error) { }

	// RVA: 0x1614850 Offset: 0x1612E50 VA: 0x181614850
	public static bool ExistsDirectory(string path, out MonoIOError error) { }

	// RVA: 0x1614A00 Offset: 0x1613000 VA: 0x181614A00
	public static bool ExistsSymlink(string path, out MonoIOError error) { }

	// RVA: 0x1615490 Offset: 0x1613A90 VA: 0x181615490
	private static bool GetFileStat(char* path, out MonoIOStat stat, out MonoIOError error) { }

	// RVA: 0x16154A0 Offset: 0x1613AA0 VA: 0x1816154A0
	public static bool GetFileStat(string path, out MonoIOStat stat, out MonoIOError error) { }

	// RVA: 0x1615830 Offset: 0x1613E30 VA: 0x181615830
	private static IntPtr Open(char* filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error) { }

	// RVA: 0x1615840 Offset: 0x1613E40 VA: 0x181615840
	public static IntPtr Open(string filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error) { }

	// RVA: 0x1614670 Offset: 0x1612C70 VA: 0x181614670
	public static bool Close(IntPtr handle, out MonoIOError error) { }

	// RVA: 0x1615A20 Offset: 0x1614020 VA: 0x181615A20
	private static int Read(IntPtr handle, byte[] dest, int dest_offset, int count, out MonoIOError error) { }

	// RVA: 0x16158D0 Offset: 0x1613ED0 VA: 0x1816158D0
	public static int Read(SafeHandle safeHandle, byte[] dest, int dest_offset, int count, out MonoIOError error) { }

	// RVA: 0x1616280 Offset: 0x1614880 VA: 0x181616280
	private static int Write(IntPtr handle, [In] byte[] src, int src_offset, int count, out MonoIOError error) { }

	// RVA: 0x1616290 Offset: 0x1614890 VA: 0x181616290
	public static int Write(SafeHandle safeHandle, byte[] src, int src_offset, int count, out MonoIOError error) { }

	// RVA: 0x1615AC0 Offset: 0x16140C0 VA: 0x181615AC0
	private static long Seek(IntPtr handle, long offset, SeekOrigin origin, out MonoIOError error) { }

	// RVA: 0x1615AD0 Offset: 0x16140D0 VA: 0x181615AD0
	public static long Seek(SafeHandle safeHandle, long offset, SeekOrigin origin, out MonoIOError error) { }

	// RVA: 0x1615650 Offset: 0x1613C50 VA: 0x181615650
	private static long GetLength(IntPtr handle, out MonoIOError error) { }

	// RVA: 0x1615660 Offset: 0x1613C60 VA: 0x181615660
	public static long GetLength(SafeHandle safeHandle, out MonoIOError error) { }

	// RVA: 0x1616270 Offset: 0x1614870 VA: 0x181616270
	private static bool SetLength(IntPtr handle, long length, out MonoIOError error) { }

	// RVA: 0x1616140 Offset: 0x1614740 VA: 0x181616140
	public static bool SetLength(SafeHandle safeHandle, long length, out MonoIOError error) { }

	// RVA: 0x1615EA0 Offset: 0x16144A0 VA: 0x181615EA0
	private static bool SetFileTime(IntPtr handle, long creation_time, long last_access_time, long last_write_time, out MonoIOError error) { }

	// RVA: 0x1615EB0 Offset: 0x16144B0 VA: 0x181615EB0
	public static bool SetFileTime(SafeHandle safeHandle, long creation_time, long last_access_time, long last_write_time, out MonoIOError error) { }

	// RVA: 0x1615C10 Offset: 0x1614210 VA: 0x181615C10
	public static bool SetCreationTime(string path, DateTime dateTime, out MonoIOError error) { }

	// RVA: 0x1616000 Offset: 0x1614600 VA: 0x181616000
	public static bool SetLastAccessTime(string path, DateTime dateTime, out MonoIOError error) { }

	// RVA: 0x16160A0 Offset: 0x16146A0 VA: 0x1816160A0
	public static bool SetLastWriteTime(string path, DateTime dateTime, out MonoIOError error) { }

	// RVA: 0x1615CB0 Offset: 0x16142B0 VA: 0x181615CB0
	public static bool SetFileTime(string path, int type, long creation_time, long last_access_time, long last_write_time, DateTime dateTime, out MonoIOError error) { }

	// RVA: 0x1616480 Offset: 0x1614A80 VA: 0x181616480
	public static IntPtr get_ConsoleOutput() { }

	// RVA: 0x1616470 Offset: 0x1614A70 VA: 0x181616470
	public static IntPtr get_ConsoleInput() { }

	// RVA: 0x1616460 Offset: 0x1614A60 VA: 0x181616460
	public static IntPtr get_ConsoleError() { }

	// RVA: 0x1614840 Offset: 0x1612E40 VA: 0x181614840
	public static bool DuplicateHandle(IntPtr source_process_handle, IntPtr source_handle, IntPtr target_process_handle, out IntPtr target_handle, int access, int inherit, int options, out MonoIOError error) { }

	// RVA: 0x16164B0 Offset: 0x1614AB0 VA: 0x1816164B0
	public static char get_VolumeSeparatorChar() { }

	// RVA: 0x1616490 Offset: 0x1614A90 VA: 0x181616490
	public static char get_DirectorySeparatorChar() { }

	// RVA: 0x1616450 Offset: 0x1614A50 VA: 0x181616450
	public static char get_AltDirectorySeparatorChar() { }

	// RVA: 0x16164A0 Offset: 0x1614AA0 VA: 0x1816164A0
	public static char get_PathSeparator() { }

	// RVA: 0xD73BA0 Offset: 0xD721A0 VA: 0x180D73BA0
	private static void DumpHandles() { }

	// RVA: 0x1615A30 Offset: 0x1614030 VA: 0x181615A30
	public static bool RemapPath(string path, out string newPath) { }

	// RVA: 0x16163E0 Offset: 0x16149E0 VA: 0x1816163E0
	private static void .cctor() { }

}

internal enum MonoIOError // TypeDefIndex: 676
{	// Fields
	public int value__; // 0x0
	public const MonoIOError ERROR_SUCCESS = 0;
	public const MonoIOError ERROR_FILE_NOT_FOUND = 2;
	public const MonoIOError ERROR_PATH_NOT_FOUND = 3;
	public const MonoIOError ERROR_TOO_MANY_OPEN_FILES = 4;
	public const MonoIOError ERROR_ACCESS_DENIED = 5;
	public const MonoIOError ERROR_INVALID_HANDLE = 6;
	public const MonoIOError ERROR_INVALID_DRIVE = 15;
	public const MonoIOError ERROR_NOT_SAME_DEVICE = 17;
	public const MonoIOError ERROR_NO_MORE_FILES = 18;
	public const MonoIOError ERROR_NOT_READY = 21;
	public const MonoIOError ERROR_WRITE_FAULT = 29;
	public const MonoIOError ERROR_READ_FAULT = 30;
	public const MonoIOError ERROR_GEN_FAILURE = 31;
	public const MonoIOError ERROR_SHARING_VIOLATION = 32;
	public const MonoIOError ERROR_LOCK_VIOLATION = 33;
	public const MonoIOError ERROR_HANDLE_DISK_FULL = 39;
	public const MonoIOError ERROR_FILE_EXISTS = 80;
	public const MonoIOError ERROR_CANNOT_MAKE = 82;
	public const MonoIOError ERROR_INVALID_PARAMETER = 87;
	public const MonoIOError ERROR_BROKEN_PIPE = 109;
	public const MonoIOError ERROR_INVALID_NAME = 123;
	public const MonoIOError ERROR_DIR_NOT_EMPTY = 145;
	public const MonoIOError ERROR_ALREADY_EXISTS = 183;
	public const MonoIOError ERROR_FILENAME_EXCED_RANGE = 206;
	public const MonoIOError ERROR_DIRECTORY = 267;
	public const MonoIOError ERROR_ENCRYPTION_FAILED = 6000;

}

internal struct MonoIOStat // TypeDefIndex: 677
{	// Fields
	public FileAttributes fileAttributes; // 0x0
	public long Length; // 0x8
	public long CreationTime; // 0x10
	public long LastAccessTime; // 0x18
	public long LastWriteTime; // 0x20

}

internal class MonoMethodMessage : IMethodCallMessage, IMethodMessage, IMessage, IMethodReturnMessage, IInternalMessage // TypeDefIndex: 1252
{	// Fields
	private MonoMethod method; // 0x10
	private object[] args; // 0x18
	private string[] names; // 0x20
	private byte[] arg_types; // 0x28
	public LogicalCallContext ctx; // 0x30
	public object rval; // 0x38
	public Exception exc; // 0x40
	private AsyncResult asyncResult; // 0x48
	private CallType call_type; // 0x50
	private string uri; // 0x58
	private MCMDictionary properties; // 0x60
	private Type[] methodSignature; // 0x68
	private Identity identity; // 0x70
	internal static string CallContextKey; // 0x0
	internal static string UriKey; // 0x8

	// Properties
	public IDictionary Properties { get; }
	public int ArgCount { get; }
	public object[] Args { get; }
	public LogicalCallContext LogicalCallContext { get; set; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public string TypeName { get; }
	public string Uri { get; set; }
	public Exception Exception { get; }
	public int OutArgCount { get; }
	public object[] OutArgs { get; }
	public object ReturnValue { get; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }
	public AsyncResult AsyncResult { get; }
	internal CallType CallType { get; }

	// Methods

	// RVA: 0x147FC10 Offset: 0x147E210 VA: 0x18147FC10
	internal void InitMessage(MonoMethod method, object[] out_args) { }

	// RVA: 0x1480050 Offset: 0x147E650 VA: 0x181480050
	public void .ctor(MethodBase method, object[] out_args) { }

	// RVA: 0x1480150 Offset: 0x147E750 VA: 0x181480150
	internal void .ctor(MethodInfo minfo, object[] in_args, object[] out_args) { }

	// RVA: 0x147FB50 Offset: 0x147E150 VA: 0x18147FB50
	private static MethodInfo GetMethodInfo(Type type, string methodName) { }

	// RVA: 0x14802D0 Offset: 0x147E8D0 VA: 0x1814802D0
	public void .ctor(Type type, string methodName, object[] in_args) { }

	// RVA: 0x1480910 Offset: 0x147EF10 VA: 0x181480910 Slot: 13
	public IDictionary get_Properties() { }

	// RVA: 0x14803F0 Offset: 0x147E9F0 VA: 0x1814803F0 Slot: 4
	public int get_ArgCount() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 5
	public object[] get_Args() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0 Slot: 6
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	public void set_LogicalCallContext(LogicalCallContext value) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 7
	public MethodBase get_MethodBase() { }

	// RVA: 0x1480520 Offset: 0x147EB20 VA: 0x181480520 Slot: 8
	public string get_MethodName() { }

	// RVA: 0x14805A0 Offset: 0x147EBA0 VA: 0x1814805A0 Slot: 9
	public object get_MethodSignature() { }

	// RVA: 0x1480990 Offset: 0x147EF90 VA: 0x181480990 Slot: 10
	public string get_TypeName() { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0 Slot: 19
	public string get_Uri() { }

	// RVA: 0x4CF810 Offset: 0x4CDE10 VA: 0x1804CF810 Slot: 20
	public void set_Uri(string value) { }

	// RVA: 0x147FB10 Offset: 0x147E110 VA: 0x18147FB10 Slot: 12
	public object GetArg(int arg_num) { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540 Slot: 14
	public Exception get_Exception() { }

	// RVA: 0x1480700 Offset: 0x147ED00 VA: 0x181480700 Slot: 21
	public int get_OutArgCount() { }

	// RVA: 0x1480770 Offset: 0x147ED70 VA: 0x181480770 Slot: 15
	public object[] get_OutArgs() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340 Slot: 16
	public object get_ReturnValue() { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360 Slot: 17
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0 Slot: 18
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	public AsyncResult get_AsyncResult() { }

	// RVA: 0x1480430 Offset: 0x147EA30 VA: 0x181480430
	internal CallType get_CallType() { }

	// RVA: 0x147FF60 Offset: 0x147E560 VA: 0x18147FF60
	public bool NeedsOutProcessing(out int outCount) { }

	// RVA: 0x147FFE0 Offset: 0x147E5E0 VA: 0x18147FFE0
	private static void .cctor() { }

}

public class MonoTlsConnectionInfo // TypeDefIndex: 1743
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private CipherSuiteCode <CipherSuiteCode>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TlsProtocols <ProtocolVersion>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <PeerDomainName>k__BackingField; // 0x18

	// Properties
	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	public CipherSuiteCode CipherSuiteCode { get; set; }
	public TlsProtocols ProtocolVersion { get; set; }
	public string PeerDomainName { set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13A88C0 Offset: 0x13A6EC0 VA: 0x1813A88C0
	public CipherSuiteCode get_CipherSuiteCode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1AB9EC0 Offset: 0x1AB84C0 VA: 0x181AB9EC0
	public void set_CipherSuiteCode(CipherSuiteCode value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57C960 Offset: 0x57AF60 VA: 0x18057C960
	public TlsProtocols get_ProtocolVersion() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57C980 Offset: 0x57AF80 VA: 0x18057C980
	public void set_ProtocolVersion(TlsProtocols value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_PeerDomainName(string value) { }

	// RVA: 0x1AB9E40 Offset: 0x1AB8440 VA: 0x181AB9E40 Slot: 3
	public override string ToString() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public enum MonoSslPolicyErrors // TypeDefIndex: 1744
{	// Fields
	public int value__; // 0x0
	public const MonoSslPolicyErrors None = 0;
	public const MonoSslPolicyErrors RemoteCertificateNotAvailable = 1;
	public const MonoSslPolicyErrors RemoteCertificateNameMismatch = 2;
	public const MonoSslPolicyErrors RemoteCertificateChainErrors = 4;

}

public sealed class MonoRemoteCertificateValidationCallback : MulticastDelegate // TypeDefIndex: 1745
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xFFC390 Offset: 0xFFA990 VA: 0x180FFC390 Slot: 12
	public virtual bool Invoke(string targetHost, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors) { }

	// RVA: 0x1AB9DA0 Offset: 0x1AB83A0 VA: 0x181AB9DA0 Slot: 13
	public virtual IAsyncResult BeginInvoke(string targetHost, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors, AsyncCallback callback, object object) { }

	// RVA: 0xFF6FB0 Offset: 0xFF55B0 VA: 0x180FF6FB0 Slot: 14
	public virtual bool EndInvoke(IAsyncResult result) { }

}

public sealed class MonoLocalCertificateSelectionCallback : MulticastDelegate // TypeDefIndex: 1746
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xFFA0F0 Offset: 0xFF86F0 VA: 0x180FFA0F0 Slot: 12
	public virtual X509Certificate Invoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

	// RVA: 0xFFA0A0 Offset: 0xFF86A0 VA: 0x180FFA0A0 Slot: 13
	public virtual IAsyncResult BeginInvoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual X509Certificate EndInvoke(IAsyncResult result) { }

}

public abstract class MonoTlsProvider // TypeDefIndex: 1747
{	// Properties
	public abstract Guid ID { get; }
	public abstract string Name { get; }
	public abstract bool SupportsSslStream { get; }
	public abstract bool SupportsConnectionInfo { get; }
	public abstract bool SupportsMonoExtensions { get; }
	public abstract SslProtocols SupportedProtocols { get; }
	internal abstract bool SupportsCleanShutdown { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Guid get_ID();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_SupportsSslStream();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_SupportsConnectionInfo();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_SupportsMonoExtensions();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract SslProtocols get_SupportedProtocols();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract IMonoSslStream CreateSslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings);

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract IMonoSslStream CreateSslStreamInternal(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings);

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract bool ValidateCertificate(ICertificateValidator2 validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref MonoSslPolicyErrors errors, ref int status11);

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract bool get_SupportsCleanShutdown();

}

public static class MonoTlsProviderFactory // TypeDefIndex: 1748
{	// Methods

	// RVA: 0x1AB9ED0 Offset: 0x1AB84D0 VA: 0x181AB9ED0
	public static MonoTlsProvider GetProvider() { }

}

public sealed class MonoTlsSettings // TypeDefIndex: 1749
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MonoRemoteCertificateValidationCallback <RemoteCertificateValidationCallback>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MonoLocalCertificateSelectionCallback <ClientCertificateSelectionCallback>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<DateTime> <CertificateValidationTime>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private X509CertificateCollection <TrustAnchors>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object <UserSettings>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string[] <CertificateSearchPaths>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <SendCloseNotify>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<TlsProtocols> <EnabledProtocols>k__BackingField; // 0x4C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private CipherSuiteCode[] <EnabledCiphers>k__BackingField; // 0x58
	private bool cloned; // 0x60
	private bool checkCertName; // 0x61
	private bool checkCertRevocationStatus; // 0x62
	private Nullable<bool> useServicePointManagerCallback; // 0x63
	private bool skipSystemValidators; // 0x65
	private bool callbackNeedsChain; // 0x66
	private ICertificateValidator certificateValidator; // 0x68
	private static MonoTlsSettings defaultSettings; // 0x0

	// Properties
	public MonoRemoteCertificateValidationCallback RemoteCertificateValidationCallback { get; set; }
	public MonoLocalCertificateSelectionCallback ClientCertificateSelectionCallback { get; set; }
	public Nullable<bool> UseServicePointManagerCallback { get; set; }
	public bool CallbackNeedsCertificateChain { get; }
	public Nullable<DateTime> CertificateValidationTime { get; set; }
	public X509CertificateCollection TrustAnchors { get; set; }
	public object UserSettings { get; set; }
	internal string[] CertificateSearchPaths { get; set; }
	internal bool SendCloseNotify { get; set; }
	public Nullable<TlsProtocols> EnabledProtocols { get; set; }
	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	public CipherSuiteCode[] EnabledCiphers { get; set; }
	public static MonoTlsSettings DefaultSettings { get; }
	[ObsoleteAttribute] // RVA: 0x7F2D0 Offset: 0x7E6D0 VA: 0x18007F2D0
	public ICertificateValidator CertificateValidator { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public MonoRemoteCertificateValidationCallback get_RemoteCertificateValidationCallback() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	public void set_RemoteCertificateValidationCallback(MonoRemoteCertificateValidationCallback value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public MonoLocalCertificateSelectionCallback get_ClientCertificateSelectionCallback() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_ClientCertificateSelectionCallback(MonoLocalCertificateSelectionCallback value) { }

	// RVA: 0x1ABA320 Offset: 0x1AB8920 VA: 0x181ABA320
	public Nullable<bool> get_UseServicePointManagerCallback() { }

	// RVA: 0x1ABA340 Offset: 0x1AB8940 VA: 0x181ABA340
	public void set_UseServicePointManagerCallback(Nullable<bool> value) { }

	// RVA: 0x10872C0 Offset: 0x10858C0 VA: 0x1810872C0
	public bool get_CallbackNeedsCertificateChain() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD680B0 Offset: 0xD666B0 VA: 0x180D680B0
	public Nullable<DateTime> get_CertificateValidationTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10972E0 Offset: 0x10958E0 VA: 0x1810972E0
	public void set_CertificateValidationTime(Nullable<DateTime> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public X509CertificateCollection get_TrustAnchors() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	public void set_TrustAnchors(X509CertificateCollection value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public object get_UserSettings() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6AD650 Offset: 0x6ABC50 VA: 0x1806AD650
	public void set_UserSettings(object value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	internal string[] get_CertificateSearchPaths() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5A0 Offset: 0x4BABA0 VA: 0x1804BC5A0
	internal void set_CertificateSearchPaths(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC370 Offset: 0x4BA970 VA: 0x1804BC370
	internal bool get_SendCloseNotify() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC570 Offset: 0x4BAB70 VA: 0x1804BC570
	internal void set_SendCloseNotify(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF90BD0 Offset: 0xF8F1D0 VA: 0x180F90BD0
	public Nullable<TlsProtocols> get_EnabledProtocols() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1ABA330 Offset: 0x1AB8930 VA: 0x181ABA330
	public void set_EnabledProtocols(Nullable<TlsProtocols> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	public CipherSuiteCode[] get_EnabledCiphers() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF810 Offset: 0x4CDE10 VA: 0x1804CF810
	public void set_EnabledCiphers(CipherSuiteCode[] value) { }

	// RVA: 0x1ABA120 Offset: 0x1AB8720 VA: 0x181ABA120
	public void .ctor() { }

	// RVA: 0x1ABA290 Offset: 0x1AB8890 VA: 0x181ABA290
	public static MonoTlsSettings get_DefaultSettings() { }

	// RVA: 0x1ABA050 Offset: 0x1AB8650 VA: 0x181ABA050
	public static MonoTlsSettings CopyDefaultSettings() { }

	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0
	public ICertificateValidator get_CertificateValidator() { }

	[ObsoleteAttribute] // RVA: 0x7F2D0 Offset: 0x7E6D0 VA: 0x18007F2D0
	// RVA: 0x1AB9F50 Offset: 0x1AB8550 VA: 0x181AB9F50
	public MonoTlsSettings CloneWithValidator(ICertificateValidator validator) { }

	// RVA: 0x1AB9FF0 Offset: 0x1AB85F0 VA: 0x181AB9FF0
	public MonoTlsSettings Clone() { }

	// RVA: 0x1ABA130 Offset: 0x1AB8730 VA: 0x181ABA130
	private void .ctor(MonoTlsSettings other) { }

}

internal class MonoTODOAttribute : Attribute // TypeDefIndex: 1810
{	// Methods

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

}

internal sealed class MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 2454
{	// Methods

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor(Type t) { }

}

internal static class MonoTlsProviderFactory // TypeDefIndex: 2552
{	// Fields
	private static object locker; // 0x0
	private static bool initialized; // 0x8
	private static MonoTlsProvider defaultProvider; // 0x10
	private static Dictionary<string, Tuple<Guid, string>> providerRegistration; // 0x18
	private static Dictionary<Guid, MonoTlsProvider> providerCache; // 0x20
	internal static readonly Guid UnityTlsId; // 0x28
	internal static readonly Guid AppleTlsId; // 0x38
	internal static readonly Guid BtlsId; // 0x48
	internal static readonly Guid LegacyId; // 0x58

	// Methods

	// RVA: 0x1219ED0 Offset: 0x12184D0 VA: 0x181219ED0
	internal static MonoTlsProvider GetProviderInternal() { }

	// RVA: 0x121A0A0 Offset: 0x12186A0 VA: 0x18121A0A0
	internal static void InitializeInternal() { }

	// RVA: 0x121A8A0 Offset: 0x1218EA0 VA: 0x18121A8A0
	private static MonoTlsProvider LookupProvider(string name, bool throwOnError) { }

	// RVA: 0x121A450 Offset: 0x1218A50 VA: 0x18121A450
	private static void InitializeProviderRegistration() { }

	// RVA: 0x1219E50 Offset: 0x1218450 VA: 0x181219E50
	private static MonoTlsProvider CreateDefaultProviderImpl() { }

	// RVA: 0x121A010 Offset: 0x1218610 VA: 0x18121A010
	internal static MonoTlsProvider GetProvider() { }

	// RVA: 0x121ADA0 Offset: 0x12193A0 VA: 0x18121ADA0
	private static void .cctor() { }

}

internal class MonoTlsStream // TypeDefIndex: 2553
{	// Fields
	private readonly MonoTlsProvider provider; // 0x10
	private readonly NetworkStream networkStream; // 0x18
	private readonly HttpWebRequest request; // 0x20
	private readonly MonoTlsSettings settings; // 0x28
	private IMonoSslStream sslStream; // 0x30
	private WebExceptionStatus status; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <CertificateValidationFailed>k__BackingField; // 0x3C

	// Properties
	internal HttpWebRequest Request { get; }
	internal WebExceptionStatus ExceptionStatus { get; }
	internal bool CertificateValidationFailed { get; set; }

	// Methods

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal HttpWebRequest get_Request() { }

	// RVA: 0x6BB9E0 Offset: 0x6B9FE0 VA: 0x1806BB9E0
	internal WebExceptionStatus get_ExceptionStatus() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC66170 Offset: 0xC64770 VA: 0x180C66170
	internal bool get_CertificateValidationFailed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE73A10 Offset: 0xE72010 VA: 0x180E73A10
	internal void set_CertificateValidationFailed(bool value) { }

	// RVA: 0x121B440 Offset: 0x1219A40 VA: 0x18121B440
	public void .ctor(HttpWebRequest request, NetworkStream networkStream) { }

	// RVA: 0x121AED0 Offset: 0x12194D0 VA: 0x18121AED0
	internal Stream CreateStream(byte[] buffer) { }

}

internal class MonoChunkStream // TypeDefIndex: 3014
{	// Fields
	internal WebHeaderCollection headers; // 0x10
	private int chunkSize; // 0x18
	private int chunkRead; // 0x1C
	private int totalWritten; // 0x20
	private MonoChunkStream.State state; // 0x24
	private StringBuilder saved; // 0x28
	private bool sawCR; // 0x30
	private bool gotit; // 0x31
	private int trailerState; // 0x34
	private ArrayList chunks; // 0x38

	// Properties
	public bool WantMore { get; }
	public bool DataAvailable { get; }
	public int ChunkLeft { get; }

	// Methods

	// RVA: 0x1346CD0 Offset: 0x13452D0 VA: 0x181346CD0
	public void .ctor(byte[] buffer, int offset, int size, WebHeaderCollection headers) { }

	// RVA: 0x1346C20 Offset: 0x1345220 VA: 0x181346C20
	public void .ctor(WebHeaderCollection headers) { }

	// RVA: 0x1346AC0 Offset: 0x13450C0 VA: 0x181346AC0
	public void ResetBuffer() { }

	// RVA: 0x1346B70 Offset: 0x1345170 VA: 0x181346B70
	public void WriteAndReadBack(byte[] buffer, int offset, int size, ref int read) { }

	// RVA: 0x1346A60 Offset: 0x1345060 VA: 0x181346A60
	public int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x13464F0 Offset: 0x1344AF0 VA: 0x1813464F0
	private int ReadFromChunks(byte[] buffer, int offset, int size) { }

	// RVA: 0x1346BF0 Offset: 0x13451F0 VA: 0x181346BF0
	public void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x1346010 Offset: 0x1344610 VA: 0x181346010
	private void InternalWrite(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x1346EE0 Offset: 0x13454E0 VA: 0x181346EE0
	public bool get_WantMore() { }

	// RVA: 0x1346DD0 Offset: 0x13453D0 VA: 0x181346DD0
	public bool get_DataAvailable() { }

	// RVA: 0x1346DC0 Offset: 0x13453C0 VA: 0x181346DC0
	public int get_ChunkLeft() { }

	// RVA: 0x13462E0 Offset: 0x13448E0 VA: 0x1813462E0
	private MonoChunkStream.State ReadBody(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x1345D50 Offset: 0x1344350 VA: 0x181345D50
	private MonoChunkStream.State GetChunkSize(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x1346A70 Offset: 0x1345070 VA: 0x181346A70
	private static string RemoveChunkExtension(string input) { }

	// RVA: 0x1346410 Offset: 0x1344A10 VA: 0x181346410
	private MonoChunkStream.State ReadCRLF(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x13467A0 Offset: 0x1344DA0 VA: 0x1813467A0
	private MonoChunkStream.State ReadTrailer(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x1346B00 Offset: 0x1345100 VA: 0x181346B00
	private static void ThrowProtocolViolation(string message) { }

}

private enum MonoChunkStream.State // TypeDefIndex: 3015
{	// Fields
	public int value__; // 0x0
	public const MonoChunkStream.State None = 0;
	public const MonoChunkStream.State PartialSize = 1;
	public const MonoChunkStream.State Body = 2;
	public const MonoChunkStream.State BodyFinished = 3;
	public const MonoChunkStream.State Trailer = 4;

}

private class MonoChunkStream.Chunk // TypeDefIndex: 3016
{	// Fields
	public byte[] Bytes; // 0x10
	public int Offset; // 0x18

	// Methods

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	public void .ctor(byte[] chunk) { }

	// RVA: 0x132EDF0 Offset: 0x132D3F0 VA: 0x18132EDF0
	public int Read(byte[] buffer, int offset, int size) { }

}

public class MonoBehaviour : Behaviour // TypeDefIndex: 3518
{	// Properties
	public bool useGUILayout { get; set; }

	// Methods

	// RVA: 0x18F69F0 Offset: 0x18F4FF0 VA: 0x1818F69F0
	public bool IsInvoking() { }

	// RVA: 0x18F6970 Offset: 0x18F4F70 VA: 0x1818F6970
	public void CancelInvoke() { }

	// RVA: 0x18F6B80 Offset: 0x18F5180 VA: 0x1818F6B80
	public void Invoke(string methodName, float time) { }

	// RVA: 0x18F6AA0 Offset: 0x18F50A0 VA: 0x1818F6AA0
	public void InvokeRepeating(string methodName, float time, float repeatRate) { }

	// RVA: 0x18F6920 Offset: 0x18F4F20 VA: 0x1818F6920
	public void CancelInvoke(string methodName) { }

	// RVA: 0x18F6BE0 Offset: 0x18F51E0 VA: 0x1818F6BE0
	public bool IsInvoking(string methodName) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F6E10 Offset: 0x18F5410 VA: 0x1818F6E10
	public Coroutine StartCoroutine(string methodName) { }

	// RVA: 0x18F6F10 Offset: 0x18F5510 VA: 0x1818F6F10
	public Coroutine StartCoroutine(string methodName, object value) { }

	// RVA: 0x18F6D20 Offset: 0x18F5320 VA: 0x1818F6D20
	public Coroutine StartCoroutine(IEnumerator routine) { }

	[ObsoleteAttribute] // RVA: 0xC1AF0 Offset: 0xC0EF0 VA: 0x1800C1AF0
	// RVA: 0x18F6D20 Offset: 0x18F5320 VA: 0x1818F6D20
	public Coroutine StartCoroutine_Auto(IEnumerator routine) { }

	// RVA: 0x18F7100 Offset: 0x18F5700 VA: 0x1818F7100
	public void StopCoroutine(IEnumerator routine) { }

	// RVA: 0x18F7240 Offset: 0x18F5840 VA: 0x1818F7240
	public void StopCoroutine(Coroutine routine) { }

	// RVA: 0x18F71F0 Offset: 0x18F57F0 VA: 0x1818F71F0
	public void StopCoroutine(string methodName) { }

	// RVA: 0x18F7020 Offset: 0x18F5620 VA: 0x1818F7020
	public void StopAllCoroutines() { }

	// RVA: 0x18F7340 Offset: 0x18F5940 VA: 0x1818F7340
	public bool get_useGUILayout() { }

	// RVA: 0x18F73E0 Offset: 0x18F59E0 VA: 0x1818F73E0
	public void set_useGUILayout(bool value) { }

	// RVA: 0x18F7380 Offset: 0x18F5980 VA: 0x1818F7380
	public static void print(object message) { }

	[FreeFunctionAttribute] // RVA: 0xC1B80 Offset: 0xC0F80 VA: 0x1800C1B80
	// RVA: 0x18F6970 Offset: 0x18F4F70 VA: 0x1818F6970
	private static void Internal_CancelInvokeAll(MonoBehaviour self) { }

	[FreeFunctionAttribute] // RVA: 0xC1C90 Offset: 0xC1090 VA: 0x1800C1C90
	// RVA: 0x18F69F0 Offset: 0x18F4FF0 VA: 0x1818F69F0
	private static bool Internal_IsInvokingAll(MonoBehaviour self) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x18F6A30 Offset: 0x18F5030 VA: 0x1818F6A30
	private static void InvokeDelayed(MonoBehaviour self, string methodName, float time, float repeatRate) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x18F6920 Offset: 0x18F4F20 VA: 0x1818F6920
	private static void CancelInvoke(MonoBehaviour self, string methodName) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x18F6BE0 Offset: 0x18F51E0 VA: 0x1818F6BE0
	private static bool IsInvoking(MonoBehaviour self, string methodName) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x18F6C30 Offset: 0x18F5230 VA: 0x1818F6C30
	private static bool IsObjectMonoBehaviour(Object obj) { }

	// RVA: 0x18F6CC0 Offset: 0x18F52C0 VA: 0x1818F6CC0
	private Coroutine StartCoroutineManaged(string methodName, object value) { }

	// RVA: 0x18F6C70 Offset: 0x18F5270 VA: 0x1818F6C70
	private Coroutine StartCoroutineManaged2(IEnumerator enumerator) { }

	// RVA: 0x18F70B0 Offset: 0x18F56B0 VA: 0x1818F70B0
	private void StopCoroutineManaged(Coroutine routine) { }

	// RVA: 0x18F7060 Offset: 0x18F5660 VA: 0x1818F7060
	private void StopCoroutineFromEnumeratorManaged(IEnumerator routine) { }

	// RVA: 0x18F69B0 Offset: 0x18F4FB0 VA: 0x1818F69B0
	internal string GetScriptClassName() { }

	// RVA: 0x18F7330 Offset: 0x18F5930 VA: 0x1818F7330
	public void .ctor() { }

}

internal class MonoTODOAttribute : Attribute // TypeDefIndex: 3974
{
// Namespace: System
[AttributeUsageAttribute] // RVA: 0x80FF0 Offset: 0x803F0 VA: 0x180080FF0
internal class MonoTODOAttribute : Attribute // TypeDefIndex: 3974
	// Fields
	private string comment; // 0x10

	// Methods

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0x7B9710 Offset: 0x7B7D10 VA: 0x1807B9710
	public void .ctor(string comment) { }

}

internal class MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 5256
{	// Methods

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

}

internal static class Mono // TypeDefIndex: 6227
{	// Methods

	// RVA: 0x14B4E20 Offset: 0x14B3420 VA: 0x1814B4E20
	internal static void FixHttpsValidation() { }

}

private sealed class Mono.<>c // TypeDefIndex: 6228
{	// Fields
	public static readonly Mono.<>c <>9; // 0x0
	public static RemoteCertificateValidationCallback <>9__0_0; // 0x8

	// Methods

	// RVA: 0x14BC3D0 Offset: 0x14BA9D0 VA: 0x1814BC3D0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0
	internal bool <FixHttpsValidation>b__0_0(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

}

internal class MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 7139
{
// Namespace: EasyAntiCheat
internal class MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 7139
	// Methods

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

}

public abstract class MonoEncoding : Encoding // TypeDefIndex: 7373
{	// Fields
	private readonly int win_code_page; // 0x38

	// Properties
	public override int WindowsCodePage { get; }

	// Methods

	// RVA: 0x22ADEF0 Offset: 0x22AC4F0 VA: 0x1822ADEF0
	public void .ctor(int codePage) { }

	// RVA: 0x22ADEC0 Offset: 0x22AC4C0 VA: 0x1822ADEC0
	public void .ctor(int codePage, int windowsCodePage) { }

	// RVA: 0x22ADF10 Offset: 0x22AC510 VA: 0x1822ADF10 Slot: 11
	public override int get_WindowsCodePage() { }

	// RVA: 0x22ADC30 Offset: 0x22AC230 VA: 0x1822ADC30
	public void HandleFallback(ref EncoderFallbackBuffer buffer, char* chars, ref int charIndex, ref int charCount, byte* bytes, ref int byteIndex, ref int byteCount) { }

	// RVA: 0x22AD570 Offset: 0x22ABB70 VA: 0x1822AD570 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x22AD990 Offset: 0x22ABF90 VA: 0x1822AD990 Slot: 24
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x22AD700 Offset: 0x22ABD00 VA: 0x1822AD700 Slot: 26
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x22AD6E0 Offset: 0x22ABCE0 VA: 0x1822AD6E0 Slot: 20
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x22ADC10 Offset: 0x22AC210 VA: 0x1822ADC10 Slot: 28
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: -1 Offset: -1 Slot: 46
	public abstract int GetByteCountImpl(char* chars, int charCount);

	// RVA: -1 Offset: -1 Slot: 47
	public abstract int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount);

}

public abstract class MonoEncoder : Encoder // TypeDefIndex: 7374
{	// Fields
	private MonoEncoding encoding; // 0x20

	// Methods

	// RVA: 0x15C0090 Offset: 0x15BE690 VA: 0x1815C0090
	public void .ctor(MonoEncoding encoding) { }

	// RVA: 0x22AD0B0 Offset: 0x22AB6B0 VA: 0x1822AD0B0 Slot: 5
	public override int GetByteCount(char[] chars, int index, int count, bool refresh) { }

	// RVA: 0x22AD230 Offset: 0x22AB830 VA: 0x1822AD230 Slot: 7
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int GetByteCountImpl(char* chars, int charCount, bool refresh);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount, bool refresh);

	// RVA: 0x22AD4B0 Offset: 0x22ABAB0 VA: 0x1822AD4B0 Slot: 8
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	// RVA: 0x22AD4D0 Offset: 0x22ABAD0 VA: 0x1822AD4D0
	public void HandleFallback(char* chars, ref int charIndex, ref int charCount, byte* bytes, ref int byteIndex, ref int byteCount) { }

}

