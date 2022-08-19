public static class FormatterServices // TypeDefIndex: 1026
{	// Fields
	internal static ConcurrentDictionary<MemberHolder, MemberInfo[]> m_MemberInfoTable; // 0x0
	private static bool unsafeTypeForwardersIsEnabled; // 0x8
	private static bool unsafeTypeForwardersIsEnabledInitialized; // 0x9
	private static readonly Type[] advancedTypes; // 0x10
	private static Binder s_binder; // 0x18

	// Methods

	// RVA: 0x11F5480 Offset: 0x11F3A80 VA: 0x1811F5480
	private static void .cctor() { }

	// RVA: 0x11F3D20 Offset: 0x11F2320 VA: 0x1811F3D20
	private static MemberInfo[] GetSerializableMembers(RuntimeType type) { }

	// RVA: 0x11F2FC0 Offset: 0x11F15C0 VA: 0x1811F2FC0
	private static bool CheckSerializable(RuntimeType type) { }

	// RVA: 0x11F4380 Offset: 0x11F2980 VA: 0x1811F4380
	private static MemberInfo[] InternalGetSerializableMembers(RuntimeType type) { }

	// RVA: 0x11F3990 Offset: 0x11F1F90 VA: 0x1811F3990
	private static bool GetParentTypes(RuntimeType parentType, out RuntimeType[] parentTypes, out int parentTypeCount) { }

	// RVA: 0x11F3ED0 Offset: 0x11F24D0 VA: 0x1811F3ED0
	public static MemberInfo[] GetSerializableMembers(Type type, StreamingContext context) { }

	// RVA: 0x11F41D0 Offset: 0x11F27D0 VA: 0x1811F41D0
	public static object GetUninitializedObject(Type type) { }

	// RVA: 0x11F55F0 Offset: 0x11F3BF0 VA: 0x1811F55F0
	private static object nativeGetUninitializedObject(RuntimeType type) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	private static bool GetEnableUnsafeTypeForwarders() { }

	// RVA: 0x11F53A0 Offset: 0x11F39A0 VA: 0x1811F53A0
	internal static bool UnsafeTypeForwardersIsEnabled() { }

	// RVA: 0x11F51B0 Offset: 0x11F37B0 VA: 0x1811F51B0
	internal static void SerializationSetValue(MemberInfo fi, object target, object value) { }

	// RVA: 0x11F4EA0 Offset: 0x11F34A0 VA: 0x1811F4EA0
	public static object PopulateObjectMembers(object obj, MemberInfo[] members, object[] data) { }

	// RVA: 0x11F3620 Offset: 0x11F1C20 VA: 0x1811F3620
	public static object[] GetObjectData(object obj, MemberInfo[] members) { }

	// RVA: 0x11F4120 Offset: 0x11F2720 VA: 0x1811F4120
	public static Type GetTypeFromAssembly(Assembly assem, string name) { }

	// RVA: 0x11F4E90 Offset: 0x11F3490 VA: 0x1811F4E90
	internal static Assembly LoadAssemblyFromString(string assemblyName) { }

	// RVA: 0x11F4E10 Offset: 0x11F3410 VA: 0x1811F4E10
	internal static Assembly LoadAssemblyFromStringNoThrow(string assemblyName) { }

	// RVA: 0x11F2FF0 Offset: 0x11F15F0 VA: 0x1811F2FF0
	internal static string GetClrAssemblyName(Type type, out bool hasTypeForwardedFrom) { }

	// RVA: 0x11F3590 Offset: 0x11F1B90 VA: 0x1811F3590
	internal static string GetClrTypeFullName(Type type) { }

	// RVA: 0x11F3150 Offset: 0x11F1750 VA: 0x1811F3150
	private static string GetClrTypeFullNameForArray(Type type) { }

	// RVA: 0x11F3330 Offset: 0x11F1930 VA: 0x1811F3330
	private static string GetClrTypeFullNameForNonArrayTypes(Type type) { }

}

private sealed class FormatterServices.<>c__DisplayClass9_0 // TypeDefIndex: 1027
{	// Fields
	public Type type; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1206880 Offset: 0x1204E80 VA: 0x181206880
	internal MemberInfo[] <GetSerializableMembers>b__0(MemberHolder _) { }

}

