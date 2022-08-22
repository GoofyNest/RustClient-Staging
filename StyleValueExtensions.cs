internal static class StyleValueExtensions // TypeDefIndex: 4718
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static StyleEnum<T> ToStyleEnum<T>(StyleInt styleInt, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3B330 Offset: 0x1A39930 VA: 0x181A3B330
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
	|-RVA: 0xED9760 Offset: 0xED7D60 VA: 0x180ED9760
	|-StyleValueExtensions.DebugString<int>
	|
	|-RVA: 0xED9650 Offset: 0xED7C50 VA: 0x180ED9650
	|-StyleValueExtensions.DebugString<Int32Enum>
	|
	|-RVA: 0xED99E0 Offset: 0xED7FE0 VA: 0x180ED99E0
	|-StyleValueExtensions.DebugString<object>
	|-StyleValueExtensions.DebugString<Font>
	|
	|-RVA: 0xED9AD0 Offset: 0xED80D0 VA: 0x180ED9AD0
	|-StyleValueExtensions.DebugString<float>
	|
	|-RVA: 0xED94E0 Offset: 0xED7AE0 VA: 0x180ED94E0
	|-StyleValueExtensions.DebugString<Color>
	|
	|-RVA: 0xED9870 Offset: 0xED7E70 VA: 0x180ED9870
	|-StyleValueExtensions.DebugString<Length>
	*/

}

