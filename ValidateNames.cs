internal static class ValidateNames // TypeDefIndex: 2000
{	// Fields
	private static XmlCharType xmlCharType; // 0x13F7B

	// Methods

	// RVA: 0xE50620 Offset: 0xE4EC20 VA: 0x180E50620
	internal static int ParseNmtoken(string s, int offset) { }

	// RVA: 0xE50530 Offset: 0xE4EB30 VA: 0x180E50530
	internal static int ParseNmtokenNoNamespaces(string s, int offset) { }

	// RVA: 0xE503C0 Offset: 0xE4E9C0 VA: 0x180E503C0
	internal static int ParseNameNoNamespaces(string s, int offset) { }

	// RVA: 0xE50190 Offset: 0xE4E790 VA: 0x180E50190
	internal static bool IsNameNoNamespaces(string s) { }

	// RVA: 0xE50210 Offset: 0xE4E810 VA: 0x180E50210
	internal static int ParseNCName(string s, int offset) { }

	// RVA: 0xE50360 Offset: 0xE4E960 VA: 0x180E50360
	internal static int ParseNCName(string s) { }

	// RVA: 0xE508C0 Offset: 0xE4EEC0 VA: 0x180E508C0
	internal static int ParseQName(string s, int offset, out int colonOffset) { }

	// RVA: 0xE506F0 Offset: 0xE4ECF0 VA: 0x180E506F0
	internal static void ParseQNameThrow(string s, out string prefix, out string localName) { }

	// RVA: 0xE50B00 Offset: 0xE4F100 VA: 0x180E50B00
	internal static void ThrowInvalidName(string s, int offsetStartChar, int offsetBadChar) { }

	// RVA: 0xE4FFB0 Offset: 0xE4E5B0 VA: 0x180E4FFB0
	internal static Exception GetInvalidNameException(string s, int offsetStartChar, int offsetBadChar) { }

	// RVA: 0xE509B0 Offset: 0xE4EFB0 VA: 0x180E509B0
	internal static void SplitQName(string name, out string prefix, out string lname) { }

	// RVA: 0xE50CD0 Offset: 0xE4F2D0 VA: 0x180E50CD0
	private static void .cctor() { }

}

