public static class NumberExtensions // TypeDefIndex: 4844
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static string FormatBytes<T>(T input, bool shortFormat = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED6B00 Offset: 0xED5100 VA: 0x180ED6B00
	|-NumberExtensions.FormatBytes<int>
	|
	|-RVA: 0xED6D40 Offset: 0xED5340 VA: 0x180ED6D40
	|-NumberExtensions.FormatBytes<long>
	|
	|-RVA: 0xED6F80 Offset: 0xED5580 VA: 0x180ED6F80
	|-NumberExtensions.FormatBytes<ulong>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static T Clamp<T>(T input, T min, T max) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2E50 Offset: 0x5D1450 VA: 0x1805D2E50
	|-NumberExtensions.Clamp<int>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x226F9E0 Offset: 0x226DFE0 VA: 0x18226F9E0
	public static string FormatSeconds(ulong i) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x226F9F0 Offset: 0x226DFF0 VA: 0x18226F9F0
	public static string FormatSeconds(long s) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x226F9D0 Offset: 0x226DFD0 VA: 0x18226F9D0
	public static string FormatSecondsLong(ulong i) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x226EE80 Offset: 0x226D480 VA: 0x18226EE80
	public static string FormatSecondsLong(long s) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x226EDB0 Offset: 0x226D3B0 VA: 0x18226EDB0
	public static string FormatNumberShort(ulong i) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x226EDC0 Offset: 0x226D3C0 VA: 0x18226EDC0
	public static string FormatNumberShort(long num) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x226ED50 Offset: 0x226D350 VA: 0x18226ED50
	public static string FormatDistance(float num) { }

}

