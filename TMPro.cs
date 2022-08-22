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

	// RVA: 0x115E860 Offset: 0x115CE60 VA: 0x18115E860
	public static void ON_PRE_RENDER_OBJECT_CHANGED() { }

	// RVA: 0x115E7D0 Offset: 0x115CDD0 VA: 0x18115E7D0
	public static void ON_MATERIAL_PROPERTY_CHANGED(bool isChanged, Material mat) { }

	// RVA: 0x115E740 Offset: 0x115CD40 VA: 0x18115E740
	public static void ON_FONT_PROPERTY_CHANGED(bool isChanged, TMP_FontAsset font) { }

	// RVA: 0x115E940 Offset: 0x115CF40 VA: 0x18115E940
	public static void ON_SPRITE_ASSET_PROPERTY_CHANGED(bool isChanged, Object obj) { }

	// RVA: 0x115E9D0 Offset: 0x115CFD0 VA: 0x18115E9D0
	public static void ON_TEXTMESHPRO_PROPERTY_CHANGED(bool isChanged, TextMeshPro obj) { }

	// RVA: 0x115E6A0 Offset: 0x115CCA0 VA: 0x18115E6A0
	public static void ON_DRAG_AND_DROP_MATERIAL_CHANGED(GameObject sender, Material currentMaterial, Material newMaterial) { }

	// RVA: 0x115EB70 Offset: 0x115D170 VA: 0x18115EB70
	public static void ON_TEXT_STYLE_PROPERTY_CHANGED(bool isChanged) { }

	// RVA: 0x115E590 Offset: 0x115CB90 VA: 0x18115E590
	public static void ON_COLOR_GRAIDENT_PROPERTY_CHANGED(TMP_ColorGradient gradient) { }

	// RVA: 0x115EAF0 Offset: 0x115D0F0 VA: 0x18115EAF0
	public static void ON_TEXT_CHANGED(Object obj) { }

	// RVA: 0x115EBF0 Offset: 0x115D1F0 VA: 0x18115EBF0
	public static void ON_TMP_SETTINGS_CHANGED() { }

	// RVA: 0x115E8D0 Offset: 0x115CED0 VA: 0x18115E8D0
	public static void ON_RESOURCES_LOADED() { }

	// RVA: 0x115EA60 Offset: 0x115D060 VA: 0x18115EA60
	public static void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(bool isChanged, TextMeshProUGUI obj) { }

	// RVA: 0x115E610 Offset: 0x115CC10 VA: 0x18115E610
	public static void ON_COMPUTE_DT_EVENT(object Sender, Compute_DT_EventArgs e) { }

	// RVA: 0x115EC60 Offset: 0x115D260 VA: 0x18115EC60
	private static void .cctor() { }

}

public static class TMPro_ExtensionMethods // TypeDefIndex: 6853
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x115EF80 Offset: 0x115D580 VA: 0x18115EF80
	public static string ArrayToString(char[] chars) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x115F250 Offset: 0x115D850 VA: 0x18115F250
	public static string IntToString(int[] unicodes) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x115F2F0 Offset: 0x115D8F0 VA: 0x18115F2F0
	public static string IntToString(int[] unicodes, int start, int length) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static int FindInstanceID<T>(List<T> list, T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED9190 Offset: 0xED7790 VA: 0x180ED9190
	|-TMPro_ExtensionMethods.FindInstanceID<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x115F210 Offset: 0x115D810 VA: 0x18115F210
	public static bool Compare(Color32 a, Color32 b) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x115F060 Offset: 0x115D660 VA: 0x18115F060
	public static bool CompareRGB(Color32 a, Color32 b) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x115F120 Offset: 0x115D720 VA: 0x18115F120
	public static bool Compare(Color a, Color b) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x115F030 Offset: 0x115D630 VA: 0x18115F030
	public static bool CompareRGB(Color a, Color b) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x115F410 Offset: 0x115DA10 VA: 0x18115F410
	public static Color32 Multiply(Color32 c1, Color32 c2) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x115F410 Offset: 0x115DA10 VA: 0x18115F410
	public static Color32 Tint(Color32 c1, Color32 c2) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x115F500 Offset: 0x115DB00 VA: 0x18115F500
	public static Color32 Tint(Color32 c1, float tint) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x115F090 Offset: 0x115D690 VA: 0x18115F090
	public static bool Compare(Vector3 v1, Vector3 v2, int accuracy) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x115F160 Offset: 0x115D760 VA: 0x18115F160
	public static bool Compare(Quaternion q1, Quaternion q2, int accuracy) { }

}

