public static class TMPro_EventManager // TypeDefIndex: 6786
{
	public static readonly FastAction<object, Compute_DT_EventArgs> COMPUTE_DT_EVENT; 
	public static readonly FastAction<bool, Material> MATERIAL_PROPERTY_EVENT; 
	public static readonly FastAction<bool, TMP_FontAsset> FONT_PROPERTY_EVENT; 
	public static readonly FastAction<bool, Object> SPRITE_ASSET_PROPERTY_EVENT; 
	public static readonly FastAction<bool, TextMeshPro> TEXTMESHPRO_PROPERTY_EVENT; 
	public static readonly FastAction<GameObject, Material, Material> DRAG_AND_DROP_MATERIAL_EVENT; 
	public static readonly FastAction<bool> TEXT_STYLE_PROPERTY_EVENT; 
	public static readonly FastAction<TMP_ColorGradient> COLOR_GRADIENT_PROPERTY_EVENT; 
	public static readonly FastAction TMP_SETTINGS_PROPERTY_EVENT; 
	public static readonly FastAction RESOURCE_LOAD_EVENT; 
	public static readonly FastAction<bool, TextMeshProUGUI> TEXTMESHPRO_UGUI_PROPERTY_EVENT; 
	public static readonly FastAction OnPreRenderObject_Event; 
	public static readonly FastAction<Object> TEXT_CHANGED_EVENT; 


	public static void ON_PRE_RENDER_OBJECT_CHANGED() { }

	public static void ON_MATERIAL_PROPERTY_CHANGED(bool isChanged, Material mat) { }

	public static void ON_FONT_PROPERTY_CHANGED(bool isChanged, TMP_FontAsset font) { }

	public static void ON_SPRITE_ASSET_PROPERTY_CHANGED(bool isChanged, Object obj) { }

	public static void ON_TEXTMESHPRO_PROPERTY_CHANGED(bool isChanged, TextMeshPro obj) { }

	public static void ON_DRAG_AND_DROP_MATERIAL_CHANGED(GameObject sender, Material currentMaterial, Material newMaterial) { }

	public static void ON_TEXT_STYLE_PROPERTY_CHANGED(bool isChanged) { }

	public static void ON_COLOR_GRAIDENT_PROPERTY_CHANGED(TMP_ColorGradient gradient) { }

	public static void ON_TEXT_CHANGED(Object obj) { }

	public static void ON_TMP_SETTINGS_CHANGED() { }

	public static void ON_RESOURCES_LOADED() { }

	public static void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(bool isChanged, TextMeshProUGUI obj) { }

	public static void ON_COMPUTE_DT_EVENT(object Sender, Compute_DT_EventArgs e) { }

	private static void .cctor() { }

}

public static class TMPro_ExtensionMethods // TypeDefIndex: 6788
{

	[ExtensionAttribute] 
	public static string ArrayToString(char[] chars) { }

	[ExtensionAttribute] 
	public static string IntToString(int[] unicodes) { }

	[ExtensionAttribute] 
	public static string IntToString(int[] unicodes, int start, int length) { }

	[ExtensionAttribute] 
	public static int FindInstanceID<T>(List<T> list, T target) { }
	/* GenericInstMethod :
	|
	|-TMPro_ExtensionMethods.FindInstanceID<object>
	*/

	[ExtensionAttribute] 
	public static bool Compare(Color32 a, Color32 b) { }

	[ExtensionAttribute] 
	public static bool CompareRGB(Color32 a, Color32 b) { }

	[ExtensionAttribute] 
	public static bool Compare(Color a, Color b) { }

	[ExtensionAttribute] 
	public static bool CompareRGB(Color a, Color b) { }

	[ExtensionAttribute] 
	public static Color32 Multiply(Color32 c1, Color32 c2) { }

	[ExtensionAttribute] 
	public static Color32 Tint(Color32 c1, Color32 c2) { }

	[ExtensionAttribute] 
	public static Color32 Tint(Color32 c1, float tint) { }

	[ExtensionAttribute] 
	public static bool Compare(Vector3 v1, Vector3 v2, int accuracy) { }

	[ExtensionAttribute] 
	public static bool Compare(Quaternion q1, Quaternion q2, int accuracy) { }

}

