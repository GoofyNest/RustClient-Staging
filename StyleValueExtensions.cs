internal static class StyleValueExtensions // TypeDefIndex: 4718
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static StyleEnum<T> ToStyleEnum<T>(StyleInt styleInt, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3B430 Offset: 0x1A39A30 VA: 0x181A3B430
	|-StyleValueExtensions.ToStyleEnum<Int32Enum>
	|-StyleValueExtensions.ToStyleEnum<DisplayStyle>
	|-StyleValueExtensions.ToStyleEnum<Overflow>
	|-StyleValueExtensions.ToStyleEnum<Visibility>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static StyleLength ToStyleLength(StyleValue styleValue) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static StyleFloat ToStyleFloat(StyleValue styleValue) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static string DebugString<T>(IStyleValue<T> styleValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED9860 Offset: 0xED7E60 VA: 0x180ED9860
	|-StyleValueExtensions.DebugString<int>
	|
	|-RVA: 0xED9750 Offset: 0xED7D50 VA: 0x180ED9750
	|-StyleValueExtensions.DebugString<Int32Enum>
	|
	|-RVA: 0xED9AE0 Offset: 0xED80E0 VA: 0x180ED9AE0
	|-StyleValueExtensions.DebugString<object>
	|-StyleValueExtensions.DebugString<Font>
	|
	|-RVA: 0xED9BD0 Offset: 0xED81D0 VA: 0x180ED9BD0
	|-StyleValueExtensions.DebugString<float>
	|
	|-RVA: 0xED95E0 Offset: 0xED7BE0 VA: 0x180ED95E0
	|-StyleValueExtensions.DebugString<Color>
	|
	|-RVA: 0xED9970 Offset: 0xED7F70 VA: 0x180ED9970
	|-StyleValueExtensions.DebugString<Length>
	*/

}

