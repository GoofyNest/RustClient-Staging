public struct KerningPairKey // TypeDefIndex: 6766
{	// Fields
	public uint ascii_Left; // 0x0
	public uint ascii_Right; // 0x4
	public uint key; // 0x8

	// Methods

	// RVA: 0x117530 Offset: 0x116930 VA: 0x180117530
	public void .ctor(uint ascii_left, uint ascii_right) { }

}

public class KerningPair // TypeDefIndex: 6768
{	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0xCC3A0 Offset: 0xCB7A0 VA: 0x1800CC3A0
	[SerializeField] // RVA: 0xCC3A0 Offset: 0xCB7A0 VA: 0x1800CC3A0
	private uint m_FirstGlyph; // 0x10
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GlyphValueRecord_Legacy m_FirstGlyphAdjustments; // 0x14
	[FormerlySerializedAsAttribute] // RVA: 0xCC6B0 Offset: 0xCBAB0 VA: 0x1800CC6B0
	[SerializeField] // RVA: 0xCC6B0 Offset: 0xCBAB0 VA: 0x1800CC6B0
	private uint m_SecondGlyph; // 0x24
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GlyphValueRecord_Legacy m_SecondGlyphAdjustments; // 0x28
	[FormerlySerializedAsAttribute] // RVA: 0xCC9F0 Offset: 0xCBDF0 VA: 0x1800CC9F0
	public float xOffset; // 0x38
	internal static KerningPair empty; // 0x0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_IgnoreSpacingAdjustments; // 0x3C

	// Properties
	public uint firstGlyph { get; set; }
	public GlyphValueRecord_Legacy firstGlyphAdjustments { get; }
	public uint secondGlyph { get; set; }
	public GlyphValueRecord_Legacy secondGlyphAdjustments { get; }
	public bool ignoreSpacingAdjustments { get; }

	// Methods

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public uint get_firstGlyph() { }

	// RVA: 0x57C970 Offset: 0x57AF70 VA: 0x18057C970
	public void set_firstGlyph(uint value) { }

	// RVA: 0xC66160 Offset: 0xC64760 VA: 0x180C66160
	public GlyphValueRecord_Legacy get_firstGlyphAdjustments() { }

	// RVA: 0x79C630 Offset: 0x79AC30 VA: 0x18079C630
	public uint get_secondGlyph() { }

	// RVA: 0x79C690 Offset: 0x79AC90 VA: 0x18079C690
	public void set_secondGlyph(uint value) { }

	// RVA: 0xB119B0 Offset: 0xB0FFB0 VA: 0x180B119B0
	public GlyphValueRecord_Legacy get_secondGlyphAdjustments() { }

	// RVA: 0xC66170 Offset: 0xC64770 VA: 0x180C66170
	public bool get_ignoreSpacingAdjustments() { }

	// RVA: 0xC66130 Offset: 0xC64730 VA: 0x180C66130
	public void .ctor() { }

	// RVA: 0xC660E0 Offset: 0xC646E0 VA: 0x180C660E0
	public void .ctor(uint left, uint right, float offset) { }

	// RVA: 0xC66080 Offset: 0xC64680 VA: 0x180C66080
	public void .ctor(uint firstGlyph, GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, GlyphValueRecord_Legacy secondGlyphAdjustments) { }

	// RVA: 0xC65FF0 Offset: 0xC645F0 VA: 0x180C65FF0
	internal void ConvertLegacyKerningData() { }

	// RVA: 0xC66000 Offset: 0xC64600 VA: 0x180C66000
	private static void .cctor() { }

}

public class KerningTable // TypeDefIndex: 6769
{	// Fields
	public List<KerningPair> kerningPairs; // 0x10

	// Methods

	// RVA: 0xC66850 Offset: 0xC64E50 VA: 0x180C66850
	public void .ctor() { }

	// RVA: 0xC662C0 Offset: 0xC648C0 VA: 0x180C662C0
	public void AddKerningPair() { }

	// RVA: 0xC663F0 Offset: 0xC649F0 VA: 0x180C663F0
	public int AddKerningPair(uint first, uint second, float offset) { }

	// RVA: 0xC66180 Offset: 0xC64780 VA: 0x180C66180
	public int AddGlyphPairAdjustmentRecord(uint first, GlyphValueRecord_Legacy firstAdjustments, uint second, GlyphValueRecord_Legacy secondAdjustments) { }

	// RVA: 0xC66570 Offset: 0xC64B70 VA: 0x180C66570
	public void RemoveKerningPair(int left, int right) { }

	// RVA: 0xC66510 Offset: 0xC64B10 VA: 0x180C66510
	public void RemoveKerningPair(int index) { }

	// RVA: 0xC66650 Offset: 0xC64C50 VA: 0x180C66650
	public void SortKerningPairs() { }

}

private sealed class KerningTable.<>c__DisplayClass3_0 // TypeDefIndex: 6770
{	// Fields
	public uint first; // 0x10
	public uint second; // 0x14

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC85560 Offset: 0xC83B60 VA: 0x180C85560
	internal bool <AddKerningPair>b__0(KerningPair item) { }

}

private sealed class KerningTable.<>c__DisplayClass4_0 // TypeDefIndex: 6771
{	// Fields
	public uint first; // 0x10
	public uint second; // 0x14

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC85560 Offset: 0xC83B60 VA: 0x180C85560
	internal bool <AddGlyphPairAdjustmentRecord>b__0(KerningPair item) { }

}

private sealed class KerningTable.<>c__DisplayClass5_0 // TypeDefIndex: 6772
{	// Fields
	public int left; // 0x10
	public int right; // 0x14

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC85590 Offset: 0xC83B90 VA: 0x180C85590
	internal bool <RemoveKerningPair>b__0(KerningPair item) { }

}

private sealed class KerningTable.<>c // TypeDefIndex: 6773
{	// Fields
	public static readonly KerningTable.<>c <>9; // 0x0
	public static Func<KerningPair, uint> <>9__7_0; // 0x8
	public static Func<KerningPair, uint> <>9__7_1; // 0x10

	// Methods

	// RVA: 0xC85630 Offset: 0xC83C30 VA: 0x180C85630
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7D3360 Offset: 0x7D1960 VA: 0x1807D3360
	internal uint <SortKerningPairs>b__7_0(KerningPair s) { }

	// RVA: 0x4D5810 Offset: 0x4D3E10 VA: 0x1804D5810
	internal uint <SortKerningPairs>b__7_1(KerningPair s) { }

}

