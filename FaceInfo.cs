public struct FaceInfo // TypeDefIndex: 4109
{
// Namespace: UnityEngine.TextCore
[UsedByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
[Serializable]
public struct FaceInfo // TypeDefIndex: 4109
	// Fields
	[NativeNameAttribute] // RVA: 0x839A0 Offset: 0x82DA0 VA: 0x1800839A0
	[SerializeField] // RVA: 0x839A0 Offset: 0x82DA0 VA: 0x1800839A0
	private string m_FamilyName; // 0x0
	[SerializeField] // RVA: 0x83AD0 Offset: 0x82ED0 VA: 0x180083AD0
	[NativeNameAttribute] // RVA: 0x83AD0 Offset: 0x82ED0 VA: 0x180083AD0
	private string m_StyleName; // 0x8
	[NativeNameAttribute] // RVA: 0x83CF0 Offset: 0x830F0 VA: 0x180083CF0
	[SerializeField] // RVA: 0x83CF0 Offset: 0x830F0 VA: 0x180083CF0
	private int m_PointSize; // 0x10
	[SerializeField] // RVA: 0x83DB0 Offset: 0x831B0 VA: 0x180083DB0
	[NativeNameAttribute] // RVA: 0x83DB0 Offset: 0x831B0 VA: 0x180083DB0
	private float m_Scale; // 0x14
	[SerializeField] // RVA: 0x83EC0 Offset: 0x832C0 VA: 0x180083EC0
	[NativeNameAttribute] // RVA: 0x83EC0 Offset: 0x832C0 VA: 0x180083EC0
	private float m_LineHeight; // 0x18
	[NativeNameAttribute] // RVA: 0x84010 Offset: 0x83410 VA: 0x180084010
	[SerializeField] // RVA: 0x84010 Offset: 0x83410 VA: 0x180084010
	private float m_AscentLine; // 0x1C
	[NativeNameAttribute] // RVA: 0x843F0 Offset: 0x837F0 VA: 0x1800843F0
	[SerializeField] // RVA: 0x843F0 Offset: 0x837F0 VA: 0x1800843F0
	private float m_CapLine; // 0x20
	[SerializeField] // RVA: 0x844C0 Offset: 0x838C0 VA: 0x1800844C0
	[NativeNameAttribute] // RVA: 0x844C0 Offset: 0x838C0 VA: 0x1800844C0
	private float m_MeanLine; // 0x24
	[SerializeField] // RVA: 0x84570 Offset: 0x83970 VA: 0x180084570
	[NativeNameAttribute] // RVA: 0x84570 Offset: 0x83970 VA: 0x180084570
	private float m_Baseline; // 0x28
	[SerializeField] // RVA: 0x847C0 Offset: 0x83BC0 VA: 0x1800847C0
	[NativeNameAttribute] // RVA: 0x847C0 Offset: 0x83BC0 VA: 0x1800847C0
	private float m_DescentLine; // 0x2C
	[NativeNameAttribute] // RVA: 0x84890 Offset: 0x83C90 VA: 0x180084890
	[SerializeField] // RVA: 0x84890 Offset: 0x83C90 VA: 0x180084890
	private float m_SuperscriptOffset; // 0x30
	[NativeNameAttribute] // RVA: 0x84A50 Offset: 0x83E50 VA: 0x180084A50
	[SerializeField] // RVA: 0x84A50 Offset: 0x83E50 VA: 0x180084A50
	private float m_SuperscriptSize; // 0x34
	[SerializeField] // RVA: 0x84B60 Offset: 0x83F60 VA: 0x180084B60
	[NativeNameAttribute] // RVA: 0x84B60 Offset: 0x83F60 VA: 0x180084B60
	private float m_SubscriptOffset; // 0x38
	[SerializeField] // RVA: 0x84E80 Offset: 0x84280 VA: 0x180084E80
	[NativeNameAttribute] // RVA: 0x84E80 Offset: 0x84280 VA: 0x180084E80
	private float m_SubscriptSize; // 0x3C
	[SerializeField] // RVA: 0x84FA0 Offset: 0x843A0 VA: 0x180084FA0
	[NativeNameAttribute] // RVA: 0x84FA0 Offset: 0x843A0 VA: 0x180084FA0
	private float m_UnderlineOffset; // 0x40
	[NativeNameAttribute] // RVA: 0x85290 Offset: 0x84690 VA: 0x180085290
	[SerializeField] // RVA: 0x85290 Offset: 0x84690 VA: 0x180085290
	private float m_UnderlineThickness; // 0x44
	[SerializeField] // RVA: 0x854A0 Offset: 0x848A0 VA: 0x1800854A0
	[NativeNameAttribute] // RVA: 0x854A0 Offset: 0x848A0 VA: 0x1800854A0
	private float m_StrikethroughOffset; // 0x48
	[SerializeField] // RVA: 0x856B0 Offset: 0x84AB0 VA: 0x1800856B0
	[NativeNameAttribute] // RVA: 0x856B0 Offset: 0x84AB0 VA: 0x1800856B0
	private float m_StrikethroughThickness; // 0x4C
	[NativeNameAttribute] // RVA: 0x857B0 Offset: 0x84BB0 VA: 0x1800857B0
	[SerializeField] // RVA: 0x857B0 Offset: 0x84BB0 VA: 0x1800857B0
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

	// RVA: 0xF1490 Offset: 0xF0890 VA: 0x1800F1490
	public void set_familyName(string value) { }

	// RVA: 0xF14A0 Offset: 0xF08A0 VA: 0x1800F14A0
	public void set_styleName(string value) { }

	// RVA: 0x211720 Offset: 0x210B20 VA: 0x180211720
	public int get_pointSize() { }

	// RVA: 0x120460 Offset: 0x11F860 VA: 0x180120460
	public void set_pointSize(int value) { }

	// RVA: 0x23D1A0 Offset: 0x23C5A0 VA: 0x18023D1A0
	public float get_scale() { }

	// RVA: 0x23D910 Offset: 0x23CD10 VA: 0x18023D910
	public void set_scale(float value) { }

	// RVA: 0x23D850 Offset: 0x23CC50 VA: 0x18023D850
	public float get_lineHeight() { }

	// RVA: 0x2395A0 Offset: 0x2389A0 VA: 0x1802395A0
	public void set_lineHeight(float value) { }

	// RVA: 0x2395D0 Offset: 0x2389D0 VA: 0x1802395D0
	public float get_ascentLine() { }

	// RVA: 0x239830 Offset: 0x238C30 VA: 0x180239830
	public void set_ascentLine(float value) { }

	// RVA: 0x23D830 Offset: 0x23CC30 VA: 0x18023D830
	public float get_capLine() { }

	// RVA: 0x23D8F0 Offset: 0x23CCF0 VA: 0x18023D8F0
	public void set_capLine(float value) { }

	// RVA: 0x23D900 Offset: 0x23CD00 VA: 0x18023D900
	public void set_meanLine(float value) { }

	// RVA: 0x23D820 Offset: 0x23CC20 VA: 0x18023D820
	public float get_baseline() { }

	// RVA: 0x23D8E0 Offset: 0x23CCE0 VA: 0x18023D8E0
	public void set_baseline(float value) { }

	// RVA: 0x23D840 Offset: 0x23CC40 VA: 0x18023D840
	public float get_descentLine() { }

	// RVA: 0x116F20 Offset: 0x116320 VA: 0x180116F20
	public void set_descentLine(float value) { }

	// RVA: 0x23D890 Offset: 0x23CC90 VA: 0x18023D890
	public float get_superscriptOffset() { }

	// RVA: 0x23D960 Offset: 0x23CD60 VA: 0x18023D960
	public void set_superscriptOffset(float value) { }

	// RVA: 0x23D8A0 Offset: 0x23CCA0 VA: 0x18023D8A0
	public float get_superscriptSize() { }

	// RVA: 0x23D970 Offset: 0x23CD70 VA: 0x18023D970
	public void set_superscriptSize(float value) { }

	// RVA: 0x23D870 Offset: 0x23CC70 VA: 0x18023D870
	public float get_subscriptOffset() { }

	// RVA: 0x23D940 Offset: 0x23CD40 VA: 0x18023D940
	public void set_subscriptOffset(float value) { }

	// RVA: 0x23D880 Offset: 0x23CC80 VA: 0x18023D880
	public float get_subscriptSize() { }

	// RVA: 0x23D950 Offset: 0x23CD50 VA: 0x18023D950
	public void set_subscriptSize(float value) { }

	// RVA: 0x23D8C0 Offset: 0x23CCC0 VA: 0x18023D8C0
	public float get_underlineOffset() { }

	// RVA: 0x23D980 Offset: 0x23CD80 VA: 0x18023D980
	public void set_underlineOffset(float value) { }

	// RVA: 0x23D8D0 Offset: 0x23CCD0 VA: 0x18023D8D0
	public float get_underlineThickness() { }

	// RVA: 0x23D990 Offset: 0x23CD90 VA: 0x18023D990
	public void set_underlineThickness(float value) { }

	// RVA: 0x23D860 Offset: 0x23CC60 VA: 0x18023D860
	public float get_strikethroughOffset() { }

	// RVA: 0x23D920 Offset: 0x23CD20 VA: 0x18023D920
	public void set_strikethroughOffset(float value) { }

	// RVA: 0x23D930 Offset: 0x23CD30 VA: 0x18023D930
	public void set_strikethroughThickness(float value) { }

	// RVA: 0x23D8B0 Offset: 0x23CCB0 VA: 0x18023D8B0
	public float get_tabWidth() { }

	// RVA: 0x19E0C0 Offset: 0x19D4C0 VA: 0x18019E0C0
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

