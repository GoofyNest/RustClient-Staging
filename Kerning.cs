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

	// RVA: 0x57C9E0 Offset: 0x57AFE0 VA: 0x18057C9E0
	public void set_firstGlyph(uint value) { }

	// RVA: 0xC659D0 Offset: 0xC63FD0 VA: 0x180C659D0
	public GlyphValueRecord_Legacy get_firstGlyphAdjustments() { }

	// RVA: 0x7D0C00 Offset: 0x7CF200 VA: 0x1807D0C00
	public uint get_secondGlyph() { }

	// RVA: 0x7D0C60 Offset: 0x7CF260 VA: 0x1807D0C60
	public void set_secondGlyph(uint value) { }

	// RVA: 0xB11220 Offset: 0xB0F820 VA: 0x180B11220
	public GlyphValueRecord_Legacy get_secondGlyphAdjustments() { }

	// RVA: 0xC659E0 Offset: 0xC63FE0 VA: 0x180C659E0
	public bool get_ignoreSpacingAdjustments() { }

	// RVA: 0xC659A0 Offset: 0xC63FA0 VA: 0x180C659A0
	public void .ctor() { }

	// RVA: 0xC65950 Offset: 0xC63F50 VA: 0x180C65950
	public void .ctor(uint left, uint right, float offset) { }

	// RVA: 0xC658F0 Offset: 0xC63EF0 VA: 0x180C658F0
	public void .ctor(uint firstGlyph, GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, GlyphValueRecord_Legacy secondGlyphAdjustments) { }

	// RVA: 0xC65860 Offset: 0xC63E60 VA: 0x180C65860
	internal void ConvertLegacyKerningData() { }

	// RVA: 0xC65870 Offset: 0xC63E70 VA: 0x180C65870
	private static void .cctor() { }

}

public class KerningTable // TypeDefIndex: 6769
{	// Fields
	public List<KerningPair> kerningPairs; // 0x10

	// Methods

	// RVA: 0xC660C0 Offset: 0xC646C0 VA: 0x180C660C0
	public void .ctor() { }

	// RVA: 0xC65B30 Offset: 0xC64130 VA: 0x180C65B30
	public void AddKerningPair() { }

	// RVA: 0xC65C60 Offset: 0xC64260 VA: 0x180C65C60
	public int AddKerningPair(uint first, uint second, float offset) { }

	// RVA: 0xC659F0 Offset: 0xC63FF0 VA: 0x180C659F0
	public int AddGlyphPairAdjustmentRecord(uint first, GlyphValueRecord_Legacy firstAdjustments, uint second, GlyphValueRecord_Legacy secondAdjustments) { }

	// RVA: 0xC65DE0 Offset: 0xC643E0 VA: 0x180C65DE0
	public void RemoveKerningPair(int left, int right) { }

	// RVA: 0xC65D80 Offset: 0xC64380 VA: 0x180C65D80
	public void RemoveKerningPair(int index) { }

	// RVA: 0xC65EC0 Offset: 0xC644C0 VA: 0x180C65EC0
	public void SortKerningPairs() { }

}

private sealed class KerningTable.<>c__DisplayClass3_0 // TypeDefIndex: 6770
{	// Fields
	public uint first; // 0x10
	public uint second; // 0x14

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC84E00 Offset: 0xC83400 VA: 0x180C84E00
	internal bool <AddKerningPair>b__0(KerningPair item) { }

}

private sealed class KerningTable.<>c__DisplayClass4_0 // TypeDefIndex: 6771
{	// Fields
	public uint first; // 0x10
	public uint second; // 0x14

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC84E00 Offset: 0xC83400 VA: 0x180C84E00
	internal bool <AddGlyphPairAdjustmentRecord>b__0(KerningPair item) { }

}

private sealed class KerningTable.<>c__DisplayClass5_0 // TypeDefIndex: 6772
{	// Fields
	public int left; // 0x10
	public int right; // 0x14

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC84E30 Offset: 0xC83430 VA: 0x180C84E30
	internal bool <RemoveKerningPair>b__0(KerningPair item) { }

}

private sealed class KerningTable.<>c // TypeDefIndex: 6773
{	// Fields
	public static readonly KerningTable.<>c <>9; // 0x0
	public static Func<KerningPair, uint> <>9__7_0; // 0x8
	public static Func<KerningPair, uint> <>9__7_1; // 0x10

	// Methods

	// RVA: 0xC84ED0 Offset: 0xC834D0 VA: 0x180C84ED0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7B4E60 Offset: 0x7B3460 VA: 0x1807B4E60
	internal uint <SortKerningPairs>b__7_0(KerningPair s) { }

	// RVA: 0x4D5880 Offset: 0x4D3E80 VA: 0x1804D5880
	internal uint <SortKerningPairs>b__7_1(KerningPair s) { }

}

