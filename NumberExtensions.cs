public static class NumberExtensions // TypeDefIndex: 4844
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	public static string FormatBytes<T>(T input, bool shortFormat = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED6840 Offset: 0xED4E40 VA: 0x180ED6840
	|-NumberExtensions.FormatBytes<int>
	|
	|-RVA: 0xED6A80 Offset: 0xED5080 VA: 0x180ED6A80
	|-NumberExtensions.FormatBytes<long>
	|
	|-RVA: 0xED6CC0 Offset: 0xED52C0 VA: 0x180ED6CC0
	|-NumberExtensions.FormatBytes<ulong>
	*/

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	public static T Clamp<T>(T input, T min, T max) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2E50 Offset: 0x5D1450 VA: 0x1805D2E50
	|-NumberExtensions.Clamp<int>
	*/

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x226F8E0 Offset: 0x226DEE0 VA: 0x18226F8E0
	public static string FormatSeconds(ulong i) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x226F8F0 Offset: 0x226DEF0 VA: 0x18226F8F0
	public static string FormatSeconds(long s) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x226F8D0 Offset: 0x226DED0 VA: 0x18226F8D0
	public static string FormatSecondsLong(ulong i) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x226ED80 Offset: 0x226D380 VA: 0x18226ED80
	public static string FormatSecondsLong(long s) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x226ECB0 Offset: 0x226D2B0 VA: 0x18226ECB0
	public static string FormatNumberShort(ulong i) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x226ECC0 Offset: 0x226D2C0 VA: 0x18226ECC0
	public static string FormatNumberShort(long num) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x226EC50 Offset: 0x226D250 VA: 0x18226EC50
	public static string FormatDistance(float num) { }

}

