public static class FormatterServices // TypeDefIndex: 1026
{	// Fields
	internal static ConcurrentDictionary<MemberHolder, MemberInfo[]> m_MemberInfoTable; // 0x0
	private static bool unsafeTypeForwardersIsEnabled; // 0x8
	private static bool unsafeTypeForwardersIsEnabledInitialized; // 0x9
	private static readonly Type[] advancedTypes; // 0x10
	private static Binder s_binder; // 0x18

	// Methods

	// RVA: 0x11F5DE0 Offset: 0x11F43E0 VA: 0x1811F5DE0
	private static void .cctor() { }

	// RVA: 0x11F4680 Offset: 0x11F2C80 VA: 0x1811F4680
	private static MemberInfo[] GetSerializableMembers(RuntimeType type) { }

	// RVA: 0x11F3920 Offset: 0x11F1F20 VA: 0x1811F3920
	private static bool CheckSerializable(RuntimeType type) { }

	// RVA: 0x11F4CE0 Offset: 0x11F32E0 VA: 0x1811F4CE0
	private static MemberInfo[] InternalGetSerializableMembers(RuntimeType type) { }

	// RVA: 0x11F42F0 Offset: 0x11F28F0 VA: 0x1811F42F0
	private static bool GetParentTypes(RuntimeType parentType, out RuntimeType[] parentTypes, out int parentTypeCount) { }

	// RVA: 0x11F4830 Offset: 0x11F2E30 VA: 0x1811F4830
	public static MemberInfo[] GetSerializableMembers(Type type, StreamingContext context) { }

	// RVA: 0x11F4B30 Offset: 0x11F3130 VA: 0x1811F4B30
	public static object GetUninitializedObject(Type type) { }

	// RVA: 0x11F5F50 Offset: 0x11F4550 VA: 0x1811F5F50
	private static object nativeGetUninitializedObject(RuntimeType type) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	private static bool GetEnableUnsafeTypeForwarders() { }

	// RVA: 0x11F5D00 Offset: 0x11F4300 VA: 0x1811F5D00
	internal static bool UnsafeTypeForwardersIsEnabled() { }

	// RVA: 0x11F5B10 Offset: 0x11F4110 VA: 0x1811F5B10
	internal static void SerializationSetValue(MemberInfo fi, object target, object value) { }

	// RVA: 0x11F5800 Offset: 0x11F3E00 VA: 0x1811F5800
	public static object PopulateObjectMembers(object obj, MemberInfo[] members, object[] data) { }

	// RVA: 0x11F3F80 Offset: 0x11F2580 VA: 0x1811F3F80
	public static object[] GetObjectData(object obj, MemberInfo[] members) { }

	// RVA: 0x11F4A80 Offset: 0x11F3080 VA: 0x1811F4A80
	public static Type GetTypeFromAssembly(Assembly assem, string name) { }

	// RVA: 0x11F57F0 Offset: 0x11F3DF0 VA: 0x1811F57F0
	internal static Assembly LoadAssemblyFromString(string assemblyName) { }

	// RVA: 0x11F5770 Offset: 0x11F3D70 VA: 0x1811F5770
	internal static Assembly LoadAssemblyFromStringNoThrow(string assemblyName) { }

	// RVA: 0x11F3950 Offset: 0x11F1F50 VA: 0x1811F3950
	internal static string GetClrAssemblyName(Type type, out bool hasTypeForwardedFrom) { }

	// RVA: 0x11F3EF0 Offset: 0x11F24F0 VA: 0x1811F3EF0
	internal static string GetClrTypeFullName(Type type) { }

	// RVA: 0x11F3AB0 Offset: 0x11F20B0 VA: 0x1811F3AB0
	private static string GetClrTypeFullNameForArray(Type type) { }

	// RVA: 0x11F3C90 Offset: 0x11F2290 VA: 0x1811F3C90
	private static string GetClrTypeFullNameForNonArrayTypes(Type type) { }

}

private sealed class FormatterServices.<>c__DisplayClass9_0 // TypeDefIndex: 1027
{	// Fields
	public Type type; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x12071E0 Offset: 0x12057E0 VA: 0x1812071E0
	internal MemberInfo[] <GetSerializableMembers>b__0(MemberHolder _) { }

}

