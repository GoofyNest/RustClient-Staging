internal static class ValidateNames // TypeDefIndex: 2000
{	// Fields
	private static XmlCharType xmlCharType; // 0x2B111E0

	// Methods

	// RVA: 0xE4FB70 Offset: 0xE4E170 VA: 0x180E4FB70
	internal static int ParseNmtoken(string s, int offset) { }

	// RVA: 0xE4FA80 Offset: 0xE4E080 VA: 0x180E4FA80
	internal static int ParseNmtokenNoNamespaces(string s, int offset) { }

	// RVA: 0xE4F910 Offset: 0xE4DF10 VA: 0x180E4F910
	internal static int ParseNameNoNamespaces(string s, int offset) { }

	// RVA: 0xE4F6E0 Offset: 0xE4DCE0 VA: 0x180E4F6E0
	internal static bool IsNameNoNamespaces(string s) { }

	// RVA: 0xE4F760 Offset: 0xE4DD60 VA: 0x180E4F760
	internal static int ParseNCName(string s, int offset) { }

	// RVA: 0xE4F8B0 Offset: 0xE4DEB0 VA: 0x180E4F8B0
	internal static int ParseNCName(string s) { }

	// RVA: 0xE4FE10 Offset: 0xE4E410 VA: 0x180E4FE10
	internal static int ParseQName(string s, int offset, out int colonOffset) { }

	// RVA: 0xE4FC40 Offset: 0xE4E240 VA: 0x180E4FC40
	internal static void ParseQNameThrow(string s, out string prefix, out string localName) { }

	// RVA: 0xE50050 Offset: 0xE4E650 VA: 0x180E50050
	internal static void ThrowInvalidName(string s, int offsetStartChar, int offsetBadChar) { }

	// RVA: 0xE4F500 Offset: 0xE4DB00 VA: 0x180E4F500
	internal static Exception GetInvalidNameException(string s, int offsetStartChar, int offsetBadChar) { }

	// RVA: 0xE4FF00 Offset: 0xE4E500 VA: 0x180E4FF00
	internal static void SplitQName(string name, out string prefix, out string lname) { }

	// RVA: 0xE50220 Offset: 0xE4E820 VA: 0x180E50220
	private static void .cctor() { }

}

