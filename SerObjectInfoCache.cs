internal sealed class SerObjectInfoCache // TypeDefIndex: 1110
{	// Fields
	internal string fullTypeName; // 0x10
	internal string assemblyString; // 0x18
	internal bool hasTypeForwardedFrom; // 0x20
	internal MemberInfo[] memberInfos; // 0x28
	internal string[] memberNames; // 0x30
	internal Type[] memberTypes; // 0x38

	// Methods

	// RVA: 0xFFBD50 Offset: 0xFFA350 VA: 0x180FFBD50
	internal void .ctor(string typeName, string assemblyName, bool hasTypeForwardedFrom) { }

	// RVA: 0x1202580 Offset: 0x1200B80 VA: 0x181202580
	internal void .ctor(Type type) { }

}
