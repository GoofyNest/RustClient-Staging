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

	// RVA: 0x1650700 Offset: 0x164ED00 VA: 0x181650700
	public void .ctor(CultureInfo culture) { }

	// RVA: 0x16504B0 Offset: 0x164EAB0 VA: 0x1816504B0
	private void SetCJKTable(CultureInfo culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x164D1A0 Offset: 0x164B7A0 VA: 0x18164D1A0
	private static CultureInfo GetNeutralCulture(CultureInfo info) { }

	// RVA: 0x164B110 Offset: 0x1649710 VA: 0x18164B110
	private byte Category(int cp) { }

	// RVA: 0x164F1C0 Offset: 0x164D7C0 VA: 0x18164F1C0
	private byte Level1(int cp) { }

	// RVA: 0x164F260 Offset: 0x164D860 VA: 0x18164F260
	private byte Level2(int cp, SimpleCollator.ExtenderType ext) { }

	// RVA: 0x164E480 Offset: 0x164CA80 VA: 0x18164E480
	private static bool IsHalfKana(int cp, CompareOptions opt) { }

	// RVA: 0x164CEC0 Offset: 0x164B4C0 VA: 0x18164CEC0
	private Contraction GetContraction(string s, int start, int end) { }

	// RVA: 0x164CFA0 Offset: 0x164B5A0 VA: 0x18164CFA0
	private Contraction GetContraction(string s, int start, int end, Contraction[] clist) { }

	// RVA: 0x164D7A0 Offset: 0x164BDA0 VA: 0x18164D7A0
	private Contraction GetTailContraction(string s, int start, int end) { }

	// RVA: 0x164D880 Offset: 0x164BE80 VA: 0x18164D880
	private Contraction GetTailContraction(string s, int start, int end, Contraction[] clist) { }

	// RVA: 0x164CC00 Offset: 0x164B200 VA: 0x18164CC00
	private int FilterOptions(int i, CompareOptions opt) { }

	// RVA: 0x164D0F0 Offset: 0x164B6F0 VA: 0x18164D0F0
	private SimpleCollator.ExtenderType GetExtenderType(int i) { }

	// RVA: 0x1650610 Offset: 0x164EC10 VA: 0x181650610
	private static byte ToDashTypeValue(SimpleCollator.ExtenderType ext, CompareOptions opt) { }

	// RVA: 0x164C9E0 Offset: 0x164AFE0 VA: 0x18164C9E0
	private int FilterExtender(int i, SimpleCollator.ExtenderType ext, CompareOptions opt) { }

	// RVA: 0x164E510 Offset: 0x164CB10 VA: 0x18164E510
	private static bool IsIgnorable(int i, CompareOptions opt) { }

	// RVA: 0x164E760 Offset: 0x164CD60 VA: 0x18164E760
	private bool IsSafe(int i) { }

	// RVA: 0x164D230 Offset: 0x164B830 VA: 0x18164D230
	public SortKey GetSortKey(string s, CompareOptions options) { }

	// RVA: 0x164D320 Offset: 0x164B920 VA: 0x18164D320
	public SortKey GetSortKey(string s, int start, int length, CompareOptions options) { }

	// RVA: 0x164D420 Offset: 0x164BA20 VA: 0x18164D420
	private void GetSortKey(string s, int start, int end, SortKeyBuffer buf, CompareOptions opt) { }

	// RVA: 0x164C490 Offset: 0x164AA90 VA: 0x18164C490
	private void FillSortKeyRaw(int i, SimpleCollator.ExtenderType ext, SortKeyBuffer buf, CompareOptions opt) { }

	// RVA: 0x164C930 Offset: 0x164AF30 VA: 0x18164C930
	private void FillSurrogateSortKeyRaw(int i, SortKeyBuffer buf) { }

	// RVA: 0x164C390 Offset: 0x164A990 VA: 0x18164C390
	internal int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options) { }

	// RVA: 0x164B1B0 Offset: 0x16497B0 VA: 0x18164B1B0
	private void ClearBuffer(byte* buffer, int size) { }

	// RVA: 0x164B1F0 Offset: 0x16497F0 VA: 0x18164B1F0
	private int CompareInternal(string s1, int idx1, int len1, string s2, int idx2, int len2, out bool targetConsumed, out bool sourceConsumed, bool skipHeadingExtenders, bool immediateBreakup, ref SimpleCollator.Context ctx) { }

	// RVA: 0x164B1D0 Offset: 0x16497D0 VA: 0x18164B1D0
	private int CompareFlagPair(bool b1, bool b2) { }

	// RVA: 0x164E5A0 Offset: 0x164CBA0 VA: 0x18164E5A0
	public bool IsPrefix(string src, string target, CompareOptions opt) { }

	// RVA: 0x164E5E0 Offset: 0x164CBE0 VA: 0x18164E5E0
	public bool IsPrefix(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x164E6E0 Offset: 0x164CCE0 VA: 0x18164E6E0
	private bool IsPrefix(string s, string target, int start, int length, bool skipHeadingExtenders, ref SimpleCollator.Context ctx) { }

	// RVA: 0x164E890 Offset: 0x164CE90 VA: 0x18164E890
	public bool IsSuffix(string src, string target, CompareOptions opt) { }

	// RVA: 0x164E7D0 Offset: 0x164CDD0 VA: 0x18164E7D0
	public bool IsSuffix(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x1650370 Offset: 0x164E970 VA: 0x181650370
	private int QuickIndexOf(string s, string target, int start, int length, out bool testWasUnable) { }

	// RVA: 0x164E1C0 Offset: 0x164C7C0 VA: 0x18164E1C0
	public int IndexOf(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x164DB30 Offset: 0x164C130 VA: 0x18164DB30
	private int IndexOfOrdinal(string s, string target, int start, int length) { }

	// RVA: 0x164DAB0 Offset: 0x164C0B0 VA: 0x18164DAB0
	private int IndexOfOrdinal(string s, char target, int start, int length) { }

	// RVA: 0x164DBF0 Offset: 0x164C1F0 VA: 0x18164DBF0
	private int IndexOfSortKey(string s, int start, int length, byte* sortkey, char target, int ti, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x164DCB0 Offset: 0x164C2B0 VA: 0x18164DCB0
	private int IndexOf(string s, string target, int start, int length, byte* targetSortKey, ref SimpleCollator.Context ctx) { }

	// RVA: 0x164F030 Offset: 0x164D630 VA: 0x18164F030
	public int LastIndexOf(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x164E950 Offset: 0x164CF50 VA: 0x18164E950
	private int LastIndexOfOrdinal(string s, string target, int start, int length) { }

	// RVA: 0x164EA80 Offset: 0x164D080 VA: 0x18164EA80
	private int LastIndexOfSortKey(string s, int start, int orgStart, int length, byte* sortkey, int ti, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x164EB50 Offset: 0x164D150 VA: 0x18164EB50
	private int LastIndexOf(string s, string target, int start, int length, byte* targetSortKey, ref SimpleCollator.Context ctx) { }

	// RVA: 0x164FFA0 Offset: 0x164E5A0 VA: 0x18164FFA0
	private bool MatchesForward(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x164FBF0 Offset: 0x164E1F0 VA: 0x18164FBF0
	private bool MatchesForwardCore(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, SimpleCollator.ExtenderType ext, ref Contraction ct, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1650170 Offset: 0x164E770 VA: 0x181650170
	private bool MatchesPrimitive(CompareOptions opt, byte* source, int si, SimpleCollator.ExtenderType ext, byte* target, int ti, bool noLv4) { }

	// RVA: 0x164FA10 Offset: 0x164E010 VA: 0x18164FA10
	private bool MatchesBackward(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x164F400 Offset: 0x164DA00 VA: 0x18164F400
	private bool MatchesBackwardCore(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, SimpleCollator.ExtenderType ext, ref Contraction ct, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1650630 Offset: 0x164EC30 VA: 0x181650630
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

	// RVA: 0x1F65B0 Offset: 0x1F59B0 VA: 0x1801F65B0
	public void .ctor(CompareOptions opt, byte* alwaysMatchFlags, byte* neverMatchFlags, byte* buffer1, byte* buffer2, byte* prev1) { }

}

private struct SimpleCollator.PreviousInfo // TypeDefIndex: 41
{	// Fields
	public int Code; // 0x0
	public byte* SortKey; // 0x8

	// Methods

	// RVA: 0x1F66D0 Offset: 0x1F5AD0 VA: 0x1801F66D0
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

