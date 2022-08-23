internal static class StyleValueExtensions // TypeDefIndex: 4718
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static StyleEnum<T> ToStyleEnum<T>(StyleInt styleInt, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3B470 Offset: 0x1A39A70 VA: 0x181A3B470
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
	|-RVA: 0xED98A0 Offset: 0xED7EA0 VA: 0x180ED98A0
	|-StyleValueExtensions.DebugString<int>
	|
	|-RVA: 0xED9790 Offset: 0xED7D90 VA: 0x180ED9790
	|-StyleValueExtensions.DebugString<Int32Enum>
	|
	|-RVA: 0xED9B20 Offset: 0xED8120 VA: 0x180ED9B20
	|-StyleValueExtensions.DebugString<object>
	|-StyleValueExtensions.DebugString<Font>
	|
	|-RVA: 0xED9C10 Offset: 0xED8210 VA: 0x180ED9C10
	|-StyleValueExtensions.DebugString<float>
	|
	|-RVA: 0xED9620 Offset: 0xED7C20 VA: 0x180ED9620
	|-StyleValueExtensions.DebugString<Color>
	|
	|-RVA: 0xED99B0 Offset: 0xED7FB0 VA: 0x180ED99B0
	|-StyleValueExtensions.DebugString<Length>
	*/

}

