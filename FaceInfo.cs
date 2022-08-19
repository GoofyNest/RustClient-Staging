public struct FaceInfo // TypeDefIndex: 4109
{
// Namespace: UnityEngine.TextCore
[UsedByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
[Serializable]
public struct FaceInfo // TypeDefIndex: 4109
	// Fields
	[NativeNameAttribute] // RVA: 0x83930 Offset: 0x82D30 VA: 0x180083930
	[SerializeField] // RVA: 0x83930 Offset: 0x82D30 VA: 0x180083930
	private string m_FamilyName; // 0x0
	[SerializeField] // RVA: 0x83A70 Offset: 0x82E70 VA: 0x180083A70
	[NativeNameAttribute] // RVA: 0x83A70 Offset: 0x82E70 VA: 0x180083A70
	private string m_StyleName; // 0x8
	[NativeNameAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	[SerializeField] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	private int m_PointSize; // 0x10
	[SerializeField] // RVA: 0x83D40 Offset: 0x83140 VA: 0x180083D40
	[NativeNameAttribute] // RVA: 0x83D40 Offset: 0x83140 VA: 0x180083D40
	private float m_Scale; // 0x14
	[SerializeField] // RVA: 0x83E90 Offset: 0x83290 VA: 0x180083E90
	[NativeNameAttribute] // RVA: 0x83E90 Offset: 0x83290 VA: 0x180083E90
	private float m_LineHeight; // 0x18
	[NativeNameAttribute] // RVA: 0x83FA0 Offset: 0x833A0 VA: 0x180083FA0
	[SerializeField] // RVA: 0x83FA0 Offset: 0x833A0 VA: 0x180083FA0
	private float m_AscentLine; // 0x1C
	[NativeNameAttribute] // RVA: 0x843C0 Offset: 0x837C0 VA: 0x1800843C0
	[SerializeField] // RVA: 0x843C0 Offset: 0x837C0 VA: 0x1800843C0
	private float m_CapLine; // 0x20
	[SerializeField] // RVA: 0x84450 Offset: 0x83850 VA: 0x180084450
	[NativeNameAttribute] // RVA: 0x84450 Offset: 0x83850 VA: 0x180084450
	private float m_MeanLine; // 0x24
	[SerializeField] // RVA: 0x84540 Offset: 0x83940 VA: 0x180084540
	[NativeNameAttribute] // RVA: 0x84540 Offset: 0x83940 VA: 0x180084540
	private float m_Baseline; // 0x28
	[SerializeField] // RVA: 0x84720 Offset: 0x83B20 VA: 0x180084720
	[NativeNameAttribute] // RVA: 0x84720 Offset: 0x83B20 VA: 0x180084720
	private float m_DescentLine; // 0x2C
	[NativeNameAttribute] // RVA: 0x84820 Offset: 0x83C20 VA: 0x180084820
	[SerializeField] // RVA: 0x84820 Offset: 0x83C20 VA: 0x180084820
	private float m_SuperscriptOffset; // 0x30
	[NativeNameAttribute] // RVA: 0x849E0 Offset: 0x83DE0 VA: 0x1800849E0
	[SerializeField] // RVA: 0x849E0 Offset: 0x83DE0 VA: 0x1800849E0
	private float m_SuperscriptSize; // 0x34
	[SerializeField] // RVA: 0x84AF0 Offset: 0x83EF0 VA: 0x180084AF0
	[NativeNameAttribute] // RVA: 0x84AF0 Offset: 0x83EF0 VA: 0x180084AF0
	private float m_SubscriptOffset; // 0x38
	[SerializeField] // RVA: 0x84E10 Offset: 0x84210 VA: 0x180084E10
	[NativeNameAttribute] // RVA: 0x84E10 Offset: 0x84210 VA: 0x180084E10
	private float m_SubscriptSize; // 0x3C
	[SerializeField] // RVA: 0x84F30 Offset: 0x84330 VA: 0x180084F30
	[NativeNameAttribute] // RVA: 0x84F30 Offset: 0x84330 VA: 0x180084F30
	private float m_UnderlineOffset; // 0x40
	[NativeNameAttribute] // RVA: 0x85280 Offset: 0x84680 VA: 0x180085280
	[SerializeField] // RVA: 0x85280 Offset: 0x84680 VA: 0x180085280
	private float m_UnderlineThickness; // 0x44
	[SerializeField] // RVA: 0x85400 Offset: 0x84800 VA: 0x180085400
	[NativeNameAttribute] // RVA: 0x85400 Offset: 0x84800 VA: 0x180085400
	private float m_StrikethroughOffset; // 0x48
	[SerializeField] // RVA: 0x85640 Offset: 0x84A40 VA: 0x180085640
	[NativeNameAttribute] // RVA: 0x85640 Offset: 0x84A40 VA: 0x180085640
	private float m_StrikethroughThickness; // 0x4C
	[NativeNameAttribute] // RVA: 0x85740 Offset: 0x84B40 VA: 0x180085740
	[SerializeField] // RVA: 0x85740 Offset: 0x84B40 VA: 0x180085740
	private float m_TabWidth; // 0x50

	// Properties
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

	// Methods

	// RVA: 0xF1510 Offset: 0xF0910 VA: 0x1800F1510
	public void set_familyName(string value) { }

	// RVA: 0xF1520 Offset: 0xF0920 VA: 0x1800F1520
	public void set_styleName(string value) { }

	// RVA: 0x212370 Offset: 0x211770 VA: 0x180212370
	public int get_pointSize() { }

	// RVA: 0x1204E0 Offset: 0x11F8E0 VA: 0x1801204E0
	public void set_pointSize(int value) { }

	// RVA: 0x23D220 Offset: 0x23C620 VA: 0x18023D220
	public float get_scale() { }

	// RVA: 0x23D990 Offset: 0x23CD90 VA: 0x18023D990
	public void set_scale(float value) { }

	// RVA: 0x23D8D0 Offset: 0x23CCD0 VA: 0x18023D8D0
	public float get_lineHeight() { }

	// RVA: 0x239620 Offset: 0x238A20 VA: 0x180239620
	public void set_lineHeight(float value) { }

	// RVA: 0x239650 Offset: 0x238A50 VA: 0x180239650
	public float get_ascentLine() { }

	// RVA: 0x2398B0 Offset: 0x238CB0 VA: 0x1802398B0
	public void set_ascentLine(float value) { }

	// RVA: 0x23D8B0 Offset: 0x23CCB0 VA: 0x18023D8B0
	public float get_capLine() { }

	// RVA: 0x23D970 Offset: 0x23CD70 VA: 0x18023D970
	public void set_capLine(float value) { }

	// RVA: 0x23D980 Offset: 0x23CD80 VA: 0x18023D980
	public void set_meanLine(float value) { }

	// RVA: 0x23D8A0 Offset: 0x23CCA0 VA: 0x18023D8A0
	public float get_baseline() { }

	// RVA: 0x23D960 Offset: 0x23CD60 VA: 0x18023D960
	public void set_baseline(float value) { }

	// RVA: 0x23D8C0 Offset: 0x23CCC0 VA: 0x18023D8C0
	public float get_descentLine() { }

	// RVA: 0x116FA0 Offset: 0x1163A0 VA: 0x180116FA0
	public void set_descentLine(float value) { }

	// RVA: 0x23D910 Offset: 0x23CD10 VA: 0x18023D910
	public float get_superscriptOffset() { }

	// RVA: 0x23D9E0 Offset: 0x23CDE0 VA: 0x18023D9E0
	public void set_superscriptOffset(float value) { }

	// RVA: 0x23D920 Offset: 0x23CD20 VA: 0x18023D920
	public float get_superscriptSize() { }

	// RVA: 0x23D9F0 Offset: 0x23CDF0 VA: 0x18023D9F0
	public void set_superscriptSize(float value) { }

	// RVA: 0x23D8F0 Offset: 0x23CCF0 VA: 0x18023D8F0
	public float get_subscriptOffset() { }

	// RVA: 0x23D9C0 Offset: 0x23CDC0 VA: 0x18023D9C0
	public void set_subscriptOffset(float value) { }

	// RVA: 0x23D900 Offset: 0x23CD00 VA: 0x18023D900
	public float get_subscriptSize() { }

	// RVA: 0x23D9D0 Offset: 0x23CDD0 VA: 0x18023D9D0
	public void set_subscriptSize(float value) { }

	// RVA: 0x23D940 Offset: 0x23CD40 VA: 0x18023D940
	public float get_underlineOffset() { }

	// RVA: 0x23DA00 Offset: 0x23CE00 VA: 0x18023DA00
	public void set_underlineOffset(float value) { }

	// RVA: 0x23D950 Offset: 0x23CD50 VA: 0x18023D950
	public float get_underlineThickness() { }

	// RVA: 0x23DA10 Offset: 0x23CE10 VA: 0x18023DA10
	public void set_underlineThickness(float value) { }

	// RVA: 0x23D8E0 Offset: 0x23CCE0 VA: 0x18023D8E0
	public float get_strikethroughOffset() { }

	// RVA: 0x23D9A0 Offset: 0x23CDA0 VA: 0x18023D9A0
	public void set_strikethroughOffset(float value) { }

	// RVA: 0x23D9B0 Offset: 0x23CDB0 VA: 0x18023D9B0
	public void set_strikethroughThickness(float value) { }

	// RVA: 0x23D930 Offset: 0x23CD30 VA: 0x18023D930
	public float get_tabWidth() { }

	// RVA: 0x19E450 Offset: 0x19D850 VA: 0x18019E450
	public void set_tabWidth(float value) { }

}

public class FaceInfo_Legacy // TypeDefIndex: 6762
{	// Fields
	public string Name; // 0x10
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

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

