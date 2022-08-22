internal sealed class SerObjectInfoCache // TypeDefIndex: 1110
{	// Fields
	internal string fullTypeName; // 0x10
	internal string assemblyString; // 0x18
	internal bool hasTypeForwardedFrom; // 0x20
	internal MemberInfo[] memberInfos; // 0x28
	internal string[] memberNames; // 0x30
	internal Type[] memberTypes; // 0x38

	// Methods

	// RVA: 0xFFC010 Offset: 0xFFA610 VA: 0x180FFC010
	internal void .ctor(string typeName, string assemblyName, bool hasTypeForwardedFrom) { }

	// RVA: 0x1202840 Offset: 0x1200E40 VA: 0x181202840
	internal void .ctor(Type type) { }

}

