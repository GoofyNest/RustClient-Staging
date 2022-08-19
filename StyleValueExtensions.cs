internal static class StyleValueExtensions // TypeDefIndex: 4718
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	internal static StyleEnum<T> ToStyleEnum<T>(StyleInt styleInt, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3B990 Offset: 0x1A39F90 VA: 0x181A3B990
	|-StyleValueExtensions.ToStyleEnum<Int32Enum>
	|-StyleValueExtensions.ToStyleEnum<DisplayStyle>
	|-StyleValueExtensions.ToStyleEnum<Overflow>
	|-StyleValueExtensions.ToStyleEnum<Visibility>
	*/

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xEBC3F0 Offset: 0xEBA9F0 VA: 0x180EBC3F0
	internal static StyleLength ToStyleLength(StyleValue styleValue) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xEBC3B0 Offset: 0xEBA9B0 VA: 0x180EBC3B0
	internal static StyleFloat ToStyleFloat(StyleValue styleValue) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	internal static string DebugString<T>(IStyleValue<T> styleValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED89F0 Offset: 0xED6FF0 VA: 0x180ED89F0
	|-StyleValueExtensions.DebugString<int>
	|
	|-RVA: 0xED88E0 Offset: 0xED6EE0 VA: 0x180ED88E0
	|-StyleValueExtensions.DebugString<Int32Enum>
	|
	|-RVA: 0xED8C70 Offset: 0xED7270 VA: 0x180ED8C70
	|-StyleValueExtensions.DebugString<object>
	|-StyleValueExtensions.DebugString<Font>
	|
	|-RVA: 0xED8D60 Offset: 0xED7360 VA: 0x180ED8D60
	|-StyleValueExtensions.DebugString<float>
	|
	|-RVA: 0xED8770 Offset: 0xED6D70 VA: 0x180ED8770
	|-StyleValueExtensions.DebugString<Color>
	|
	|-RVA: 0xED8B00 Offset: 0xED7100 VA: 0x180ED8B00
	|-StyleValueExtensions.DebugString<Length>
	*/

}

