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
	[NativeNameAttribute] // RVA: 0x83D80 Offset: 0x83180 VA: 0x180083D80
	[SerializeField] // RVA: 0x83D80 Offset: 0x83180 VA: 0x180083D80
	private int m_PointSize; // 0x10
	[SerializeField] // RVA: 0x83E40 Offset: 0x83240 VA: 0x180083E40
	[NativeNameAttribute] // RVA: 0x83E40 Offset: 0x83240 VA: 0x180083E40
	private float m_Scale; // 0x14
	[SerializeField] // RVA: 0x83F10 Offset: 0x83310 VA: 0x180083F10
	[NativeNameAttribute] // RVA: 0x83F10 Offset: 0x83310 VA: 0x180083F10
	private float m_LineHeight; // 0x18
	[NativeNameAttribute] // RVA: 0x840A0 Offset: 0x834A0 VA: 0x1800840A0
	[SerializeField] // RVA: 0x840A0 Offset: 0x834A0 VA: 0x1800840A0
	private float m_AscentLine; // 0x1C
	[NativeNameAttribute] // RVA: 0x844B0 Offset: 0x838B0 VA: 0x1800844B0
	[SerializeField] // RVA: 0x844B0 Offset: 0x838B0 VA: 0x1800844B0
	private float m_CapLine; // 0x20
	[SerializeField] // RVA: 0x84540 Offset: 0x83940 VA: 0x180084540
	[NativeNameAttribute] // RVA: 0x84540 Offset: 0x83940 VA: 0x180084540
	private float m_MeanLine; // 0x24
	[SerializeField] // RVA: 0x845F0 Offset: 0x839F0 VA: 0x1800845F0
	[NativeNameAttribute] // RVA: 0x845F0 Offset: 0x839F0 VA: 0x1800845F0
	private float m_Baseline; // 0x28
	[SerializeField] // RVA: 0x84850 Offset: 0x83C50 VA: 0x180084850
	[NativeNameAttribute] // RVA: 0x84850 Offset: 0x83C50 VA: 0x180084850
	private float m_DescentLine; // 0x2C
	[NativeNameAttribute] // RVA: 0x84950 Offset: 0x83D50 VA: 0x180084950
	[SerializeField] // RVA: 0x84950 Offset: 0x83D50 VA: 0x180084950
	private float m_SuperscriptOffset; // 0x30
	[NativeNameAttribute] // RVA: 0x84B70 Offset: 0x83F70 VA: 0x180084B70
	[SerializeField] // RVA: 0x84B70 Offset: 0x83F70 VA: 0x180084B70
	private float m_SuperscriptSize; // 0x34
	[SerializeField] // RVA: 0x84D30 Offset: 0x84130 VA: 0x180084D30
	[NativeNameAttribute] // RVA: 0x84D30 Offset: 0x84130 VA: 0x180084D30
	private float m_SubscriptOffset; // 0x38
	[SerializeField] // RVA: 0x84FC0 Offset: 0x843C0 VA: 0x180084FC0
	[NativeNameAttribute] // RVA: 0x84FC0 Offset: 0x843C0 VA: 0x180084FC0
	private float m_SubscriptSize; // 0x3C
	[SerializeField] // RVA: 0x85080 Offset: 0x84480 VA: 0x180085080
	[NativeNameAttribute] // RVA: 0x85080 Offset: 0x84480 VA: 0x180085080
	private float m_UnderlineOffset; // 0x40
	[NativeNameAttribute] // RVA: 0x85340 Offset: 0x84740 VA: 0x180085340
	[SerializeField] // RVA: 0x85340 Offset: 0x84740 VA: 0x180085340
	private float m_UnderlineThickness; // 0x44
	[SerializeField] // RVA: 0x854D0 Offset: 0x848D0 VA: 0x1800854D0
	[NativeNameAttribute] // RVA: 0x854D0 Offset: 0x848D0 VA: 0x1800854D0
	private float m_StrikethroughOffset; // 0x48
	[SerializeField] // RVA: 0x856E0 Offset: 0x84AE0 VA: 0x1800856E0
	[NativeNameAttribute] // RVA: 0x856E0 Offset: 0x84AE0 VA: 0x1800856E0
	private float m_StrikethroughThickness; // 0x4C
	[NativeNameAttribute] // RVA: 0x857E0 Offset: 0x84BE0 VA: 0x1800857E0
	[SerializeField] // RVA: 0x857E0 Offset: 0x84BE0 VA: 0x1800857E0
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

