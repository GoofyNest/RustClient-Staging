public static class FormatterServices // TypeDefIndex: 1026
{	// Fields
	internal static ConcurrentDictionary<MemberHolder, MemberInfo[]> m_MemberInfoTable; // 0x0
	private static bool unsafeTypeForwardersIsEnabled; // 0x8
	private static bool unsafeTypeForwardersIsEnabledInitialized; // 0x9
	private static readonly Type[] advancedTypes; // 0x10
	private static Binder s_binder; // 0x18

	// Methods

	// RVA: 0x11F5740 Offset: 0x11F3D40 VA: 0x1811F5740
	private static void .cctor() { }

	// RVA: 0x11F3FE0 Offset: 0x11F25E0 VA: 0x1811F3FE0
	private static MemberInfo[] GetSerializableMembers(RuntimeType type) { }

	// RVA: 0x11F3280 Offset: 0x11F1880 VA: 0x1811F3280
	private static bool CheckSerializable(RuntimeType type) { }

	// RVA: 0x11F4640 Offset: 0x11F2C40 VA: 0x1811F4640
	private static MemberInfo[] InternalGetSerializableMembers(RuntimeType type) { }

	// RVA: 0x11F3C50 Offset: 0x11F2250 VA: 0x1811F3C50
	private static bool GetParentTypes(RuntimeType parentType, out RuntimeType[] parentTypes, out int parentTypeCount) { }

	// RVA: 0x11F4190 Offset: 0x11F2790 VA: 0x1811F4190
	public static MemberInfo[] GetSerializableMembers(Type type, StreamingContext context) { }

	// RVA: 0x11F4490 Offset: 0x11F2A90 VA: 0x1811F4490
	public static object GetUninitializedObject(Type type) { }

	// RVA: 0x11F58B0 Offset: 0x11F3EB0 VA: 0x1811F58B0
	private static object nativeGetUninitializedObject(RuntimeType type) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	private static bool GetEnableUnsafeTypeForwarders() { }

	// RVA: 0x11F5660 Offset: 0x11F3C60 VA: 0x1811F5660
	internal static bool UnsafeTypeForwardersIsEnabled() { }

	// RVA: 0x11F5470 Offset: 0x11F3A70 VA: 0x1811F5470
	internal static void SerializationSetValue(MemberInfo fi, object target, object value) { }

	// RVA: 0x11F5160 Offset: 0x11F3760 VA: 0x1811F5160
	public static object PopulateObjectMembers(object obj, MemberInfo[] members, object[] data) { }

	// RVA: 0x11F38E0 Offset: 0x11F1EE0 VA: 0x1811F38E0
	public static object[] GetObjectData(object obj, MemberInfo[] members) { }

	// RVA: 0x11F43E0 Offset: 0x11F29E0 VA: 0x1811F43E0
	public static Type GetTypeFromAssembly(Assembly assem, string name) { }

	// RVA: 0x11F5150 Offset: 0x11F3750 VA: 0x1811F5150
	internal static Assembly LoadAssemblyFromString(string assemblyName) { }

	// RVA: 0x11F50D0 Offset: 0x11F36D0 VA: 0x1811F50D0
	internal static Assembly LoadAssemblyFromStringNoThrow(string assemblyName) { }

	// RVA: 0x11F32B0 Offset: 0x11F18B0 VA: 0x1811F32B0
	internal static string GetClrAssemblyName(Type type, out bool hasTypeForwardedFrom) { }

	// RVA: 0x11F3850 Offset: 0x11F1E50 VA: 0x1811F3850
	internal static string GetClrTypeFullName(Type type) { }

	// RVA: 0x11F3410 Offset: 0x11F1A10 VA: 0x1811F3410
	private static string GetClrTypeFullNameForArray(Type type) { }

	// RVA: 0x11F35F0 Offset: 0x11F1BF0 VA: 0x1811F35F0
	private static string GetClrTypeFullNameForNonArrayTypes(Type type) { }

}

private sealed class FormatterServices.<>c__DisplayClass9_0 // TypeDefIndex: 1027
{	// Fields
	public Type type; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1206B40 Offset: 0x1205140 VA: 0x181206B40
	internal MemberInfo[] <GetSerializableMembers>b__0(MemberHolder _) { }

}

