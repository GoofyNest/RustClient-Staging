internal class SimpleCollator // TypeDefIndex: 39
{	// Fields
	private static bool QuickCheckDisabled; // 0x0
	private static SimpleCollator invariant; // 0x8
	private readonly TextInfo textInfo; // 0x10
	private readonly CodePointIndexer cjkIndexer; // 0x18
	private readonly Contraction[] contractions; // 0x20
	private readonly Level2Map[] level2Maps; // 0x28
	private readonly byte[] unsafeFlags; // 0x30
	private readonly byte* cjkCatTable; // 0x38
	private readonly byte* cjkLv1Table; // 0x40
	private readonly byte* cjkLv2Table; // 0x48
	private readonly CodePointIndexer cjkLv2Indexer; // 0x50
	private readonly int lcid; // 0x58
	private readonly bool frenchSort; // 0x5C
	private const int UnsafeFlagLength = 96;

	// Methods

	// RVA: 0x1650440 Offset: 0x164EA40 VA: 0x181650440
	public void .ctor(CultureInfo culture) { }

	// RVA: 0x16501F0 Offset: 0x164E7F0 VA: 0x1816501F0
	private void SetCJKTable(CultureInfo culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x164CEE0 Offset: 0x164B4E0 VA: 0x18164CEE0
	private static CultureInfo GetNeutralCulture(CultureInfo info) { }

	// RVA: 0x164AE50 Offset: 0x1649450 VA: 0x18164AE50
	private byte Category(int cp) { }

	// RVA: 0x164EF00 Offset: 0x164D500 VA: 0x18164EF00
	private byte Level1(int cp) { }

	// RVA: 0x164EFA0 Offset: 0x164D5A0 VA: 0x18164EFA0
	private byte Level2(int cp, SimpleCollator.ExtenderType ext) { }

	// RVA: 0x164E1C0 Offset: 0x164C7C0 VA: 0x18164E1C0
	private static bool IsHalfKana(int cp, CompareOptions opt) { }

	// RVA: 0x164CC00 Offset: 0x164B200 VA: 0x18164CC00
	private Contraction GetContraction(string s, int start, int end) { }

	// RVA: 0x164CCE0 Offset: 0x164B2E0 VA: 0x18164CCE0
	private Contraction GetContraction(string s, int start, int end, Contraction[] clist) { }

	// RVA: 0x164D4E0 Offset: 0x164BAE0 VA: 0x18164D4E0
	private Contraction GetTailContraction(string s, int start, int end) { }

	// RVA: 0x164D5C0 Offset: 0x164BBC0 VA: 0x18164D5C0
	private Contraction GetTailContraction(string s, int start, int end, Contraction[] clist) { }

	// RVA: 0x164C940 Offset: 0x164AF40 VA: 0x18164C940
	private int FilterOptions(int i, CompareOptions opt) { }

	// RVA: 0x164CE30 Offset: 0x164B430 VA: 0x18164CE30
	private SimpleCollator.ExtenderType GetExtenderType(int i) { }

	// RVA: 0x1650350 Offset: 0x164E950 VA: 0x181650350
	private static byte ToDashTypeValue(SimpleCollator.ExtenderType ext, CompareOptions opt) { }

	// RVA: 0x164C720 Offset: 0x164AD20 VA: 0x18164C720
	private int FilterExtender(int i, SimpleCollator.ExtenderType ext, CompareOptions opt) { }

	// RVA: 0x164E250 Offset: 0x164C850 VA: 0x18164E250
	private static bool IsIgnorable(int i, CompareOptions opt) { }

	// RVA: 0x164E4A0 Offset: 0x164CAA0 VA: 0x18164E4A0
	private bool IsSafe(int i) { }

	// RVA: 0x164CF70 Offset: 0x164B570 VA: 0x18164CF70
	public SortKey GetSortKey(string s, CompareOptions options) { }

	// RVA: 0x164D060 Offset: 0x164B660 VA: 0x18164D060
	public SortKey GetSortKey(string s, int start, int length, CompareOptions options) { }

	// RVA: 0x164D160 Offset: 0x164B760 VA: 0x18164D160
	private void GetSortKey(string s, int start, int end, SortKeyBuffer buf, CompareOptions opt) { }

	// RVA: 0x164C1D0 Offset: 0x164A7D0 VA: 0x18164C1D0
	private void FillSortKeyRaw(int i, SimpleCollator.ExtenderType ext, SortKeyBuffer buf, CompareOptions opt) { }

	// RVA: 0x164C670 Offset: 0x164AC70 VA: 0x18164C670
	private void FillSurrogateSortKeyRaw(int i, SortKeyBuffer buf) { }

	// RVA: 0x164C0D0 Offset: 0x164A6D0 VA: 0x18164C0D0
	internal int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options) { }

	// RVA: 0x164AEF0 Offset: 0x16494F0 VA: 0x18164AEF0
	private void ClearBuffer(byte* buffer, int size) { }

	// RVA: 0x164AF30 Offset: 0x1649530 VA: 0x18164AF30
	private int CompareInternal(string s1, int idx1, int len1, string s2, int idx2, int len2, out bool targetConsumed, out bool sourceConsumed, bool skipHeadingExtenders, bool immediateBreakup, ref SimpleCollator.Context ctx) { }

	// RVA: 0x164AF10 Offset: 0x1649510 VA: 0x18164AF10
	private int CompareFlagPair(bool b1, bool b2) { }

	// RVA: 0x164E2E0 Offset: 0x164C8E0 VA: 0x18164E2E0
	public bool IsPrefix(string src, string target, CompareOptions opt) { }

	// RVA: 0x164E320 Offset: 0x164C920 VA: 0x18164E320
	public bool IsPrefix(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x164E420 Offset: 0x164CA20 VA: 0x18164E420
	private bool IsPrefix(string s, string target, int start, int length, bool skipHeadingExtenders, ref SimpleCollator.Context ctx) { }

	// RVA: 0x164E5D0 Offset: 0x164CBD0 VA: 0x18164E5D0
	public bool IsSuffix(string src, string target, CompareOptions opt) { }

	// RVA: 0x164E510 Offset: 0x164CB10 VA: 0x18164E510
	public bool IsSuffix(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x16500B0 Offset: 0x164E6B0 VA: 0x1816500B0
	private int QuickIndexOf(string s, string target, int start, int length, out bool testWasUnable) { }

	// RVA: 0x164DF00 Offset: 0x164C500 VA: 0x18164DF00
	public int IndexOf(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x164D870 Offset: 0x164BE70 VA: 0x18164D870
	private int IndexOfOrdinal(string s, string target, int start, int length) { }

	// RVA: 0x164D7F0 Offset: 0x164BDF0 VA: 0x18164D7F0
	private int IndexOfOrdinal(string s, char target, int start, int length) { }

	// RVA: 0x164D930 Offset: 0x164BF30 VA: 0x18164D930
	private int IndexOfSortKey(string s, int start, int length, byte* sortkey, char target, int ti, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x164D9F0 Offset: 0x164BFF0 VA: 0x18164D9F0
	private int IndexOf(string s, string target, int start, int length, byte* targetSortKey, ref SimpleCollator.Context ctx) { }

	// RVA: 0x164ED70 Offset: 0x164D370 VA: 0x18164ED70
	public int LastIndexOf(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x164E690 Offset: 0x164CC90 VA: 0x18164E690
	private int LastIndexOfOrdinal(string s, string target, int start, int length) { }

	// RVA: 0x164E7C0 Offset: 0x164CDC0 VA: 0x18164E7C0
	private int LastIndexOfSortKey(string s, int start, int orgStart, int length, byte* sortkey, int ti, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x164E890 Offset: 0x164CE90 VA: 0x18164E890
	private int LastIndexOf(string s, string target, int start, int length, byte* targetSortKey, ref SimpleCollator.Context ctx) { }

	// RVA: 0x164FCE0 Offset: 0x164E2E0 VA: 0x18164FCE0
	private bool MatchesForward(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x164F930 Offset: 0x164DF30 VA: 0x18164F930
	private bool MatchesForwardCore(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, SimpleCollator.ExtenderType ext, ref Contraction ct, ref SimpleCollator.Context ctx) { }

	// RVA: 0x164FEB0 Offset: 0x164E4B0 VA: 0x18164FEB0
	private bool MatchesPrimitive(CompareOptions opt, byte* source, int si, SimpleCollator.ExtenderType ext, byte* target, int ti, bool noLv4) { }

	// RVA: 0x164F750 Offset: 0x164DD50 VA: 0x18164F750
	private bool MatchesBackward(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x164F140 Offset: 0x164D740 VA: 0x18164F140
	private bool MatchesBackwardCore(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, SimpleCollator.ExtenderType ext, ref Contraction ct, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1650370 Offset: 0x164E970 VA: 0x181650370
	private static void .cctor() { }

}

internal struct SimpleCollator.Context // TypeDefIndex: 40
{	// Fields
	public readonly CompareOptions Option; // 0x0
	public readonly byte* NeverMatchFlags; // 0x8
	public readonly byte* AlwaysMatchFlags; // 0x10
	public byte* Buffer1; // 0x18
	public byte* Buffer2; // 0x20
	public int PrevCode; // 0x28
	public byte* PrevSortKey; // 0x30

	// Methods

	// RVA: 0x1F6630 Offset: 0x1F5A30 VA: 0x1801F6630
	public void .ctor(CompareOptions opt, byte* alwaysMatchFlags, byte* neverMatchFlags, byte* buffer1, byte* buffer2, byte* prev1) { }

}

private struct SimpleCollator.PreviousInfo // TypeDefIndex: 41
{	// Fields
	public int Code; // 0x0
	public byte* SortKey; // 0x8

	// Methods

	// RVA: 0x1F6750 Offset: 0x1F5B50 VA: 0x1801F6750
	public void .ctor(bool dummy) { }

}

private struct SimpleCollator.Escape // TypeDefIndex: 42
{	// Fields
	public string Source; // 0x0
	public int Index; // 0x8
	public int Start; // 0xC
	public int End; // 0x10
	public int Optional; // 0x14

}

private enum SimpleCollator.ExtenderType // TypeDefIndex: 43
{	// Fields
	public int value__; // 0x0
	public const SimpleCollator.ExtenderType None = 0;
	public const SimpleCollator.ExtenderType Simple = 1;
	public const SimpleCollator.ExtenderType Voiced = 2;
	public const SimpleCollator.ExtenderType Conditional = 3;
	public const SimpleCollator.ExtenderType Buggy = 4;

}

