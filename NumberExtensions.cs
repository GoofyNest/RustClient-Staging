public static class NumberExtensions // TypeDefIndex: 4844
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static string FormatBytes<T>(T input, bool shortFormat = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED76B0 Offset: 0xED5CB0 VA: 0x180ED76B0
	|-NumberExtensions.FormatBytes<int>
	|
	|-RVA: 0xED78F0 Offset: 0xED5EF0 VA: 0x180ED78F0
	|-NumberExtensions.FormatBytes<long>
	|
	|-RVA: 0xED7B30 Offset: 0xED6130 VA: 0x180ED7B30
	|-NumberExtensions.FormatBytes<ulong>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static T Clamp<T>(T input, T min, T max) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2EB0 Offset: 0x5D14B0 VA: 0x1805D2EB0
	|-NumberExtensions.Clamp<int>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static string FormatSeconds(ulong i) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static string FormatSeconds(long s) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static string FormatSecondsLong(ulong i) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static string FormatSecondsLong(long s) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static string FormatNumberShort(ulong i) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static string FormatNumberShort(long num) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static string FormatDistance(float num) { }

}

