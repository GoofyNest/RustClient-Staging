internal static class StyleValueExtensions // TypeDefIndex: 4718
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static StyleEnum<T> ToStyleEnum<T>(StyleInt styleInt, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3B370 Offset: 0x1A39970 VA: 0x181A3B370
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
	|-RVA: 0xED97A0 Offset: 0xED7DA0 VA: 0x180ED97A0
	|-StyleValueExtensions.DebugString<int>
	|
	|-RVA: 0xED9690 Offset: 0xED7C90 VA: 0x180ED9690
	|-StyleValueExtensions.DebugString<Int32Enum>
	|
	|-RVA: 0xED9A20 Offset: 0xED8020 VA: 0x180ED9A20
	|-StyleValueExtensions.DebugString<object>
	|-StyleValueExtensions.DebugString<Font>
	|
	|-RVA: 0xED9B10 Offset: 0xED8110 VA: 0x180ED9B10
	|-StyleValueExtensions.DebugString<float>
	|
	|-RVA: 0xED9520 Offset: 0xED7B20 VA: 0x180ED9520
	|-StyleValueExtensions.DebugString<Color>
	|
	|-RVA: 0xED98B0 Offset: 0xED7EB0 VA: 0x180ED98B0
	|-StyleValueExtensions.DebugString<Length>
	*/

}

