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

	// RVA: 0x115E5A0 Offset: 0x115CBA0 VA: 0x18115E5A0
	public static void ON_PRE_RENDER_OBJECT_CHANGED() { }

	// RVA: 0x115E510 Offset: 0x115CB10 VA: 0x18115E510
	public static void ON_MATERIAL_PROPERTY_CHANGED(bool isChanged, Material mat) { }

	// RVA: 0x115E480 Offset: 0x115CA80 VA: 0x18115E480
	public static void ON_FONT_PROPERTY_CHANGED(bool isChanged, TMP_FontAsset font) { }

	// RVA: 0x115E680 Offset: 0x115CC80 VA: 0x18115E680
	public static void ON_SPRITE_ASSET_PROPERTY_CHANGED(bool isChanged, Object obj) { }

	// RVA: 0x115E710 Offset: 0x115CD10 VA: 0x18115E710
	public static void ON_TEXTMESHPRO_PROPERTY_CHANGED(bool isChanged, TextMeshPro obj) { }

	// RVA: 0x115E3E0 Offset: 0x115C9E0 VA: 0x18115E3E0
	public static void ON_DRAG_AND_DROP_MATERIAL_CHANGED(GameObject sender, Material currentMaterial, Material newMaterial) { }

	// RVA: 0x115E8B0 Offset: 0x115CEB0 VA: 0x18115E8B0
	public static void ON_TEXT_STYLE_PROPERTY_CHANGED(bool isChanged) { }

	// RVA: 0x115E2D0 Offset: 0x115C8D0 VA: 0x18115E2D0
	public static void ON_COLOR_GRAIDENT_PROPERTY_CHANGED(TMP_ColorGradient gradient) { }

	// RVA: 0x115E830 Offset: 0x115CE30 VA: 0x18115E830
	public static void ON_TEXT_CHANGED(Object obj) { }

	// RVA: 0x115E930 Offset: 0x115CF30 VA: 0x18115E930
	public static void ON_TMP_SETTINGS_CHANGED() { }

	// RVA: 0x115E610 Offset: 0x115CC10 VA: 0x18115E610
	public static void ON_RESOURCES_LOADED() { }

	// RVA: 0x115E7A0 Offset: 0x115CDA0 VA: 0x18115E7A0
	public static void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(bool isChanged, TextMeshProUGUI obj) { }

	// RVA: 0x115E350 Offset: 0x115C950 VA: 0x18115E350
	public static void ON_COMPUTE_DT_EVENT(object Sender, Compute_DT_EventArgs e) { }

	// RVA: 0x115E9A0 Offset: 0x115CFA0 VA: 0x18115E9A0
	private static void .cctor() { }

}

public static class TMPro_ExtensionMethods // TypeDefIndex: 6853
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x115ECC0 Offset: 0x115D2C0 VA: 0x18115ECC0
	public static string ArrayToString(char[] chars) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x115EF90 Offset: 0x115D590 VA: 0x18115EF90
	public static string IntToString(int[] unicodes) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x115F030 Offset: 0x115D630 VA: 0x18115F030
	public static string IntToString(int[] unicodes, int start, int length) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	public static int FindInstanceID<T>(List<T> list, T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED8ED0 Offset: 0xED74D0 VA: 0x180ED8ED0
	|-TMPro_ExtensionMethods.FindInstanceID<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x115EF50 Offset: 0x115D550 VA: 0x18115EF50
	public static bool Compare(Color32 a, Color32 b) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x115EDA0 Offset: 0x115D3A0 VA: 0x18115EDA0
	public static bool CompareRGB(Color32 a, Color32 b) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x115EE60 Offset: 0x115D460 VA: 0x18115EE60
	public static bool Compare(Color a, Color b) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x115ED70 Offset: 0x115D370 VA: 0x18115ED70
	public static bool CompareRGB(Color a, Color b) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x115F150 Offset: 0x115D750 VA: 0x18115F150
	public static Color32 Multiply(Color32 c1, Color32 c2) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x115F150 Offset: 0x115D750 VA: 0x18115F150
	public static Color32 Tint(Color32 c1, Color32 c2) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x115F240 Offset: 0x115D840 VA: 0x18115F240
	public static Color32 Tint(Color32 c1, float tint) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x115EDD0 Offset: 0x115D3D0 VA: 0x18115EDD0
	public static bool Compare(Vector3 v1, Vector3 v2, int accuracy) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x115EEA0 Offset: 0x115D4A0 VA: 0x18115EEA0
	public static bool Compare(Quaternion q1, Quaternion q2, int accuracy) { }

}

