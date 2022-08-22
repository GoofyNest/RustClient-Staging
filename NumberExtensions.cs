public static class NumberExtensions // TypeDefIndex: 4844
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static string FormatBytes<T>(T input, bool shortFormat = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED75B0 Offset: 0xED5BB0 VA: 0x180ED75B0
	|-NumberExtensions.FormatBytes<int>
	|
	|-RVA: 0xED77F0 Offset: 0xED5DF0 VA: 0x180ED77F0
	|-NumberExtensions.FormatBytes<long>
	|
	|-RVA: 0xED7A30 Offset: 0xED6030 VA: 0x180ED7A30
	|-NumberExtensions.FormatBytes<ulong>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static T Clamp<T>(T input, T min, T max) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2DE0 Offset: 0x5D13E0 VA: 0x1805D2DE0
	|-NumberExtensions.Clamp<int>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2270200 Offset: 0x226E800 VA: 0x182270200
	public static string FormatSeconds(ulong i) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2270210 Offset: 0x226E810 VA: 0x182270210
	public static string FormatSeconds(long s) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22701F0 Offset: 0x226E7F0 VA: 0x1822701F0
	public static string FormatSecondsLong(ulong i) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x226F6A0 Offset: 0x226DCA0 VA: 0x18226F6A0
	public static string FormatSecondsLong(long s) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x226F5D0 Offset: 0x226DBD0 VA: 0x18226F5D0
	public static string FormatNumberShort(ulong i) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x226F5E0 Offset: 0x226DBE0 VA: 0x18226F5E0
	public static string FormatNumberShort(long num) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x226F570 Offset: 0x226DB70 VA: 0x18226F570
	public static string FormatDistance(float num) { }

}

