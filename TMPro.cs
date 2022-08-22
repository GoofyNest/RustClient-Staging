public static class TMPro_EventManager // TypeDefIndex: 6851
{	// Fields
	public static readonly FastAction<object, Compute_DT_EventArgs> COMPUTE_DT_EVENT; // 0x0
	public static readonly FastAction<bool, Material> MATERIAL_PROPERTY_EVENT; // 0x8
	public static readonly FastAction<bool, TMP_FontAsset> FONT_PROPERTY_EVENT; // 0x10
	public static readonly FastAction<bool, Object> SPRITE_ASSET_PROPERTY_EVENT; // 0x18
	public static readonly FastAction<bool, TextMeshPro> TEXTMESHPRO_PROPERTY_EVENT; // 0x20
	public static readonly FastAction<GameObject, Material, Material> DRAG_AND_DROP_MATERIAL_EVENT; // 0x28
	public static readonly FastAction<bool> TEXT_STYLE_PROPERTY_EVENT; // 0x30
	public static readonly FastAction<TMP_ColorGradient> COLOR_GRADIENT_PROPERTY_EVENT; // 0x38
	public static readonly FastAction TMP_SETTINGS_PROPERTY_EVENT; // 0x40
	public static readonly FastAction RESOURCE_LOAD_EVENT; // 0x48
	public static readonly FastAction<bool, TextMeshProUGUI> TEXTMESHPRO_UGUI_PROPERTY_EVENT; // 0x50
	public static readonly FastAction OnPreRenderObject_Event; // 0x58
	public static readonly FastAction<Object> TEXT_CHANGED_EVENT; // 0x60

	// Methods

	// RVA: 0x115F2D0 Offset: 0x115D8D0 VA: 0x18115F2D0
	public static void ON_PRE_RENDER_OBJECT_CHANGED() { }

	// RVA: 0x115F240 Offset: 0x115D840 VA: 0x18115F240
	public static void ON_MATERIAL_PROPERTY_CHANGED(bool isChanged, Material mat) { }

	// RVA: 0x115F1B0 Offset: 0x115D7B0 VA: 0x18115F1B0
	public static void ON_FONT_PROPERTY_CHANGED(bool isChanged, TMP_FontAsset font) { }

	// RVA: 0x115F3B0 Offset: 0x115D9B0 VA: 0x18115F3B0
	public static void ON_SPRITE_ASSET_PROPERTY_CHANGED(bool isChanged, Object obj) { }

	// RVA: 0x115F440 Offset: 0x115DA40 VA: 0x18115F440
	public static void ON_TEXTMESHPRO_PROPERTY_CHANGED(bool isChanged, TextMeshPro obj) { }

	// RVA: 0x115F110 Offset: 0x115D710 VA: 0x18115F110
	public static void ON_DRAG_AND_DROP_MATERIAL_CHANGED(GameObject sender, Material currentMaterial, Material newMaterial) { }

	// RVA: 0x115F5E0 Offset: 0x115DBE0 VA: 0x18115F5E0
	public static void ON_TEXT_STYLE_PROPERTY_CHANGED(bool isChanged) { }

	// RVA: 0x115F000 Offset: 0x115D600 VA: 0x18115F000
	public static void ON_COLOR_GRAIDENT_PROPERTY_CHANGED(TMP_ColorGradient gradient) { }

	// RVA: 0x115F560 Offset: 0x115DB60 VA: 0x18115F560
	public static void ON_TEXT_CHANGED(Object obj) { }

	// RVA: 0x115F660 Offset: 0x115DC60 VA: 0x18115F660
	public static void ON_TMP_SETTINGS_CHANGED() { }

	// RVA: 0x115F340 Offset: 0x115D940 VA: 0x18115F340
	public static void ON_RESOURCES_LOADED() { }

	// RVA: 0x115F4D0 Offset: 0x115DAD0 VA: 0x18115F4D0
	public static void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(bool isChanged, TextMeshProUGUI obj) { }

	// RVA: 0x115F080 Offset: 0x115D680 VA: 0x18115F080
	public static void ON_COMPUTE_DT_EVENT(object Sender, Compute_DT_EventArgs e) { }

	// RVA: 0x115F6D0 Offset: 0x115DCD0 VA: 0x18115F6D0
	private static void .cctor() { }

}

public static class TMPro_ExtensionMethods // TypeDefIndex: 6853
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x115F9F0 Offset: 0x115DFF0 VA: 0x18115F9F0
	public static string ArrayToString(char[] chars) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x115FCC0 Offset: 0x115E2C0 VA: 0x18115FCC0
	public static string IntToString(int[] unicodes) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x115FD60 Offset: 0x115E360 VA: 0x18115FD60
	public static string IntToString(int[] unicodes, int start, int length) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static int FindInstanceID<T>(List<T> list, T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED9C40 Offset: 0xED8240 VA: 0x180ED9C40
	|-TMPro_ExtensionMethods.FindInstanceID<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x115FC80 Offset: 0x115E280 VA: 0x18115FC80
	public static bool Compare(Color32 a, Color32 b) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x115FAD0 Offset: 0x115E0D0 VA: 0x18115FAD0
	public static bool CompareRGB(Color32 a, Color32 b) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x115FB90 Offset: 0x115E190 VA: 0x18115FB90
	public static bool Compare(Color a, Color b) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x115FAA0 Offset: 0x115E0A0 VA: 0x18115FAA0
	public static bool CompareRGB(Color a, Color b) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x115FE80 Offset: 0x115E480 VA: 0x18115FE80
	public static Color32 Multiply(Color32 c1, Color32 c2) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x115FE80 Offset: 0x115E480 VA: 0x18115FE80
	public static Color32 Tint(Color32 c1, Color32 c2) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x115FF70 Offset: 0x115E570 VA: 0x18115FF70
	public static Color32 Tint(Color32 c1, float tint) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x115FB00 Offset: 0x115E100 VA: 0x18115FB00
	public static bool Compare(Vector3 v1, Vector3 v2, int accuracy) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x115FBD0 Offset: 0x115E1D0 VA: 0x18115FBD0
	public static bool Compare(Quaternion q1, Quaternion q2, int accuracy) { }

}

