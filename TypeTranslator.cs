internal class TypeTranslator // TypeDefIndex: 2064
{	// Fields
	private static Hashtable nameCache; // 0x0
	private static Hashtable primitiveTypes; // 0x8
	private static Hashtable primitiveArrayTypes; // 0x10
	private static Hashtable nullableTypes; // 0x18

	// Methods

	// RVA: 0x1109AE0 Offset: 0x11080E0 VA: 0x181109AE0
	private static void .cctor() { }

	// RVA: 0x1108D70 Offset: 0x1107370 VA: 0x181108D70
	public static TypeData GetTypeData(Type type) { }

	// RVA: 0x1108DD0 Offset: 0x11073D0 VA: 0x181108DD0
	public static TypeData GetTypeData(Type runtimeType, string xmlDataType, bool underlyingEnumType = False) { }

	// RVA: 0x1108D10 Offset: 0x1107310 VA: 0x181108D10
	public static TypeData GetPrimitiveTypeData(string typeName) { }

	// RVA: 0x1108AC0 Offset: 0x11070C0 VA: 0x181108AC0
	public static TypeData GetPrimitiveTypeData(string typeName, bool nullable) { }

	// RVA: 0x1108900 Offset: 0x1106F00 VA: 0x181108900
	public static TypeData FindPrimitiveTypeData(string typeName) { }

	// RVA: 0x11089D0 Offset: 0x1106FD0 VA: 0x1811089D0
	public static string GetArrayName(string elemName) { }

	// RVA: 0x1109990 Offset: 0x1107F90 VA: 0x181109990
	public static void ParseArrayType(string arrayType, out string type, out string ns, out string dimensions) { }

}

