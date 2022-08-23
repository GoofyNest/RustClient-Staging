public static class NumberExtensions // TypeDefIndex: 4844
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static string FormatBytes<T>(T input, bool shortFormat = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED76F0 Offset: 0xED5CF0 VA: 0x180ED76F0
	|-NumberExtensions.FormatBytes<int>
	|
	|-RVA: 0xED7930 Offset: 0xED5F30 VA: 0x180ED7930
	|-NumberExtensions.FormatBytes<long>
	|
	|-RVA: 0xED7B70 Offset: 0xED6170 VA: 0x180ED7B70
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

