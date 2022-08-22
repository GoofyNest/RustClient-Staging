public static class NumberExtensions // TypeDefIndex: 4844
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static T Clamp<T>(T input, T min, T max) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2E50 Offset: 0x5D1450 VA: 0x1805D2E50
	|-NumberExtensions.Clamp<int>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x226F720 Offset: 0x226DD20 VA: 0x18226F720
	public static string FormatSeconds(ulong i) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x226F730 Offset: 0x226DD30 VA: 0x18226F730
	public static string FormatSeconds(long s) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x226F710 Offset: 0x226DD10 VA: 0x18226F710
	public static string FormatSecondsLong(ulong i) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x226EBC0 Offset: 0x226D1C0 VA: 0x18226EBC0
	public static string FormatSecondsLong(long s) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x226EAF0 Offset: 0x226D0F0 VA: 0x18226EAF0
	public static string FormatNumberShort(ulong i) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x226EB00 Offset: 0x226D100 VA: 0x18226EB00
	public static string FormatNumberShort(long num) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x226EA90 Offset: 0x226D090 VA: 0x18226EA90
	public static string FormatDistance(float num) { }

}

