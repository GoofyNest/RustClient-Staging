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

	// RVA: 0x14669B0 Offset: 0x1464FB0 VA: 0x1814669B0
	internal void .ctor(string prefix, bool ci) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal string get_Prefix() { }

	// RVA: 0x95F9E0 Offset: 0x95DFE0 VA: 0x18095F9E0
	internal bool get_CaseInsensitive() { }

	// RVA: 0x16B7090 Offset: 0x16B5690 VA: 0x1816B7090
	internal static RegexPrefix get_Empty() { }

	// RVA: 0x16B7000 Offset: 0x16B5600 VA: 0x1816B7000
	private static void .cctor() { }

}

