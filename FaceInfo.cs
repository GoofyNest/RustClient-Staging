public struct FaceInfo // TypeDefIndex: 4109
{
[UsedByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
[Serializable]
public struct FaceInfo // TypeDefIndex: 4109
	[NativeNameAttribute] // RVA: 0x83AB0 Offset: 0x82EB0 VA: 0x180083AB0
	[SerializeField] // RVA: 0x83AB0 Offset: 0x82EB0 VA: 0x180083AB0
	private string m_FamilyName; // 0x0
	[SerializeField] // RVA: 0x83BE0 Offset: 0x82FE0 VA: 0x180083BE0
	[NativeNameAttribute] // RVA: 0x83BE0 Offset: 0x82FE0 VA: 0x180083BE0
	private string m_StyleName; // 0x8
	[NativeNameAttribute] // RVA: 0x83DC0 Offset: 0x831C0 VA: 0x180083DC0
	[SerializeField] // RVA: 0x83DC0 Offset: 0x831C0 VA: 0x180083DC0
	private int m_PointSize; // 0x10
	[SerializeField] // RVA: 0x83E80 Offset: 0x83280 VA: 0x180083E80
	[NativeNameAttribute] // RVA: 0x83E80 Offset: 0x83280 VA: 0x180083E80
	private float m_Scale; // 0x14
	[SerializeField] // RVA: 0x83FD0 Offset: 0x833D0 VA: 0x180083FD0
	[NativeNameAttribute] // RVA: 0x83FD0 Offset: 0x833D0 VA: 0x180083FD0
	private float m_LineHeight; // 0x18
	[NativeNameAttribute] // RVA: 0x84120 Offset: 0x83520 VA: 0x180084120
	[SerializeField] // RVA: 0x84120 Offset: 0x83520 VA: 0x180084120
	private float m_AscentLine; // 0x1C
	[NativeNameAttribute] // RVA: 0x84540 Offset: 0x83940 VA: 0x180084540
	[SerializeField] // RVA: 0x84540 Offset: 0x83940 VA: 0x180084540
	private float m_CapLine; // 0x20
	[SerializeField] // RVA: 0x845D0 Offset: 0x839D0 VA: 0x1800845D0
	[NativeNameAttribute] // RVA: 0x845D0 Offset: 0x839D0 VA: 0x1800845D0
	private float m_MeanLine; // 0x24
	[SerializeField] // RVA: 0x846C0 Offset: 0x83AC0 VA: 0x1800846C0
	[NativeNameAttribute] // RVA: 0x846C0 Offset: 0x83AC0 VA: 0x1800846C0
	private float m_Baseline; // 0x28
	[SerializeField] // RVA: 0x84890 Offset: 0x83C90 VA: 0x180084890
	[NativeNameAttribute] // RVA: 0x84890 Offset: 0x83C90 VA: 0x180084890
	private float m_DescentLine; // 0x2C
	[NativeNameAttribute] // RVA: 0x84970 Offset: 0x83D70 VA: 0x180084970
	[SerializeField] // RVA: 0x84970 Offset: 0x83D70 VA: 0x180084970
	private float m_SuperscriptOffset; // 0x30
	[NativeNameAttribute] // RVA: 0x84BA0 Offset: 0x83FA0 VA: 0x180084BA0
	[SerializeField] // RVA: 0x84BA0 Offset: 0x83FA0 VA: 0x180084BA0
	private float m_SuperscriptSize; // 0x34
	[SerializeField] // RVA: 0x84CB0 Offset: 0x840B0 VA: 0x180084CB0
	[NativeNameAttribute] // RVA: 0x84CB0 Offset: 0x840B0 VA: 0x180084CB0
	private float m_SubscriptOffset; // 0x38
	[SerializeField] // RVA: 0x84F40 Offset: 0x84340 VA: 0x180084F40
	[NativeNameAttribute] // RVA: 0x84F40 Offset: 0x84340 VA: 0x180084F40
	private float m_SubscriptSize; // 0x3C
	[SerializeField] // RVA: 0x85030 Offset: 0x84430 VA: 0x180085030
	[NativeNameAttribute] // RVA: 0x85030 Offset: 0x84430 VA: 0x180085030
	private float m_UnderlineOffset; // 0x40
	[NativeNameAttribute] // RVA: 0x85380 Offset: 0x84780 VA: 0x180085380
	[SerializeField] // RVA: 0x85380 Offset: 0x84780 VA: 0x180085380
	private float m_UnderlineThickness; // 0x44
	[SerializeField] // RVA: 0x85540 Offset: 0x84940 VA: 0x180085540
	[NativeNameAttribute] // RVA: 0x85540 Offset: 0x84940 VA: 0x180085540
	private float m_StrikethroughOffset; // 0x48
	[SerializeField] // RVA: 0x85800 Offset: 0x84C00 VA: 0x180085800
	[NativeNameAttribute] // RVA: 0x85800 Offset: 0x84C00 VA: 0x180085800
	private float m_StrikethroughThickness; // 0x4C
	[NativeNameAttribute] // RVA: 0x85900 Offset: 0x84D00 VA: 0x180085900
	[SerializeField] // RVA: 0x85900 Offset: 0x84D00 VA: 0x180085900
	private float m_TabWidth; // 0x50

	public string familyName { set; }
	public string styleName { set; }
	public int pointSize { get; set; }
	public float scale { get; set; }
	public float lineHeight { get; set; }
	public float ascentLine { get; set; }
	public float capLine { get; set; }
	public float meanLine { set; }
	public float baseline { get; set; }
	public float descentLine { get; set; }
	public float superscriptOffset { get; set; }
	public float superscriptSize { get; set; }
	public float subscriptOffset { get; set; }
	public float subscriptSize { get; set; }
	public float underlineOffset { get; set; }
	public float underlineThickness { get; set; }
	public float strikethroughOffset { get; set; }
	public float strikethroughThickness { set; }
	public float tabWidth { get; set; }


	public void set_familyName(string value) { }

	public void set_styleName(string value) { }

	public int get_pointSize() { }

	public void set_pointSize(int value) { }

	public float get_scale() { }

	public void set_scale(float value) { }

	public float get_lineHeight() { }

	public void set_lineHeight(float value) { }

	public float get_ascentLine() { }

	public void set_ascentLine(float value) { }

	public float get_capLine() { }

	public void set_capLine(float value) { }

	public void set_meanLine(float value) { }

	public float get_baseline() { }

	public void set_baseline(float value) { }

	public float get_descentLine() { }

	public void set_descentLine(float value) { }

	public float get_superscriptOffset() { }

	public void set_superscriptOffset(float value) { }

	public float get_superscriptSize() { }

	public void set_superscriptSize(float value) { }

	public float get_subscriptOffset() { }

	public void set_subscriptOffset(float value) { }

	public float get_subscriptSize() { }

	public void set_subscriptSize(float value) { }

	public float get_underlineOffset() { }

	public void set_underlineOffset(float value) { }

	public float get_underlineThickness() { }

	public void set_underlineThickness(float value) { }

	public float get_strikethroughOffset() { }

	public void set_strikethroughOffset(float value) { }

	public void set_strikethroughThickness(float value) { }

	public float get_tabWidth() { }

	public void set_tabWidth(float value) { }

}

public class FaceInfo_Legacy // TypeDefIndex: 6762
{	public string Name; // 0x10
	public float PointSize; // 0x18
	public float Scale; // 0x1C
	public int CharacterCount; // 0x20
	public float LineHeight; // 0x24
	public float Baseline; // 0x28
	public float Ascender; // 0x2C
	public float CapHeight; // 0x30
	public float Descender; // 0x34
	public float CenterLine; // 0x38
	public float SuperscriptOffset; // 0x3C
	public float SubscriptOffset; // 0x40
	public float SubSize; // 0x44
	public float Underline; // 0x48
	public float UnderlineThickness; // 0x4C
	public float strikethrough; // 0x50
	public float strikethroughThickness; // 0x54
	public float TabWidth; // 0x58
	public float Padding; // 0x5C
	public float AtlasWidth; // 0x60
	public float AtlasHeight; // 0x64


	public void .ctor() { }

}

