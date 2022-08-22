internal static class StyleValueExtensions // TypeDefIndex: 4718
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal static StyleEnum<T> ToStyleEnum<T>(StyleInt styleInt, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3BC10 Offset: 0x1A3A210 VA: 0x181A3BC10
	|-StyleValueExtensions.ToStyleEnum<Int32Enum>
	|-StyleValueExtensions.ToStyleEnum<DisplayStyle>
	|-StyleValueExtensions.ToStyleEnum<Overflow>
	|-StyleValueExtensions.ToStyleEnum<Visibility>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEBC6B0 Offset: 0xEBACB0 VA: 0x180EBC6B0
	internal static StyleLength ToStyleLength(StyleValue styleValue) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEBC670 Offset: 0xEBAC70 VA: 0x180EBC670
	internal static StyleFloat ToStyleFloat(StyleValue styleValue) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal static string DebugString<T>(IStyleValue<T> styleValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED8CB0 Offset: 0xED72B0 VA: 0x180ED8CB0
	|-StyleValueExtensions.DebugString<int>
	|
	|-RVA: 0xED8BA0 Offset: 0xED71A0 VA: 0x180ED8BA0
	|-StyleValueExtensions.DebugString<Int32Enum>
	|
	|-RVA: 0xED8F30 Offset: 0xED7530 VA: 0x180ED8F30
	|-StyleValueExtensions.DebugString<object>
	|-StyleValueExtensions.DebugString<Font>
	|
	|-RVA: 0xED9020 Offset: 0xED7620 VA: 0x180ED9020
	|-StyleValueExtensions.DebugString<float>
	|
	|-RVA: 0xED8A30 Offset: 0xED7030 VA: 0x180ED8A30
	|-StyleValueExtensions.DebugString<Color>
	|
	|-RVA: 0xED8DC0 Offset: 0xED73C0 VA: 0x180ED8DC0
	|-StyleValueExtensions.DebugString<Length>
	*/

}

