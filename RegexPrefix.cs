internal sealed class RegexPrefix // TypeDefIndex: 2615
{	// Fields
	internal string _prefix; // 0x10
	internal bool _caseInsensitive; // 0x18
	internal static RegexPrefix _empty; // 0x0

	// Properties
	internal string Prefix { get; }
	internal bool CaseInsensitive { get; }
	internal static RegexPrefix Empty { get; }

	// Methods

	// RVA: 0x1466C70 Offset: 0x1465270 VA: 0x181466C70
	internal void .ctor(string prefix, bool ci) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal string get_Prefix() { }

	// RVA: 0x95FAF0 Offset: 0x95E0F0 VA: 0x18095FAF0
	internal bool get_CaseInsensitive() { }

	// RVA: 0x16B7350 Offset: 0x16B5950 VA: 0x1816B7350
	internal static RegexPrefix get_Empty() { }

	// RVA: 0x16B72C0 Offset: 0x16B58C0 VA: 0x1816B72C0
	private static void .cctor() { }

}

