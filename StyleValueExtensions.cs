internal static class StyleValueExtensions // TypeDefIndex: 4718
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static StyleEnum<T> ToStyleEnum<T>(StyleInt styleInt, T value) { }
	/* GenericInstMethod :
	|
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
	|-StyleValueExtensions.DebugString<int>
	|
	|-StyleValueExtensions.DebugString<Int32Enum>
	|
	|-StyleValueExtensions.DebugString<object>
	|-StyleValueExtensions.DebugString<Font>
	|
	|-StyleValueExtensions.DebugString<float>
	|
	|-StyleValueExtensions.DebugString<Color>
	|
	|-StyleValueExtensions.DebugString<Length>
	*/

}

