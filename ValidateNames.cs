internal static class ValidateNames // TypeDefIndex: 2000
{	// Fields
	private static XmlCharType xmlCharType; // 0x2B11180

	// Methods

	// RVA: 0xE4F8B0 Offset: 0xE4DEB0 VA: 0x180E4F8B0
	internal static int ParseNmtoken(string s, int offset) { }

	// RVA: 0xE4F7C0 Offset: 0xE4DDC0 VA: 0x180E4F7C0
	internal static int ParseNmtokenNoNamespaces(string s, int offset) { }

	// RVA: 0xE4F650 Offset: 0xE4DC50 VA: 0x180E4F650
	internal static int ParseNameNoNamespaces(string s, int offset) { }

	// RVA: 0xE4F420 Offset: 0xE4DA20 VA: 0x180E4F420
	internal static bool IsNameNoNamespaces(string s) { }

	// RVA: 0xE4F4A0 Offset: 0xE4DAA0 VA: 0x180E4F4A0
	internal static int ParseNCName(string s, int offset) { }

	// RVA: 0xE4F5F0 Offset: 0xE4DBF0 VA: 0x180E4F5F0
	internal static int ParseNCName(string s) { }

	// RVA: 0xE4FB50 Offset: 0xE4E150 VA: 0x180E4FB50
	internal static int ParseQName(string s, int offset, out int colonOffset) { }

	// RVA: 0xE4F980 Offset: 0xE4DF80 VA: 0x180E4F980
	internal static void ParseQNameThrow(string s, out string prefix, out string localName) { }

	// RVA: 0xE4FD90 Offset: 0xE4E390 VA: 0x180E4FD90
	internal static void ThrowInvalidName(string s, int offsetStartChar, int offsetBadChar) { }

	// RVA: 0xE4F240 Offset: 0xE4D840 VA: 0x180E4F240
	internal static Exception GetInvalidNameException(string s, int offsetStartChar, int offsetBadChar) { }

	// RVA: 0xE4FC40 Offset: 0xE4E240 VA: 0x180E4FC40
	internal static void SplitQName(string name, out string prefix, out string lname) { }

	// RVA: 0xE4FF60 Offset: 0xE4E560 VA: 0x180E4FF60
	private static void .cctor() { }

}

