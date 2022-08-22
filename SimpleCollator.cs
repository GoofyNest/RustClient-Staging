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

	// RVA: 0x163DA20 Offset: 0x163C020 VA: 0x18163DA20
	public void .ctor(CultureInfo culture) { }

	// RVA: 0x163D7D0 Offset: 0x163BDD0 VA: 0x18163D7D0
	private void SetCJKTable(CultureInfo culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x163A4C0 Offset: 0x1638AC0 VA: 0x18163A4C0
	private static CultureInfo GetNeutralCulture(CultureInfo info) { }

	// RVA: 0x1638430 Offset: 0x1636A30 VA: 0x181638430
	private byte Category(int cp) { }

	// RVA: 0x163C4E0 Offset: 0x163AAE0 VA: 0x18163C4E0
	private byte Level1(int cp) { }

	// RVA: 0x163C580 Offset: 0x163AB80 VA: 0x18163C580
	private byte Level2(int cp, SimpleCollator.ExtenderType ext) { }

	// RVA: 0x163B7A0 Offset: 0x1639DA0 VA: 0x18163B7A0
	private static bool IsHalfKana(int cp, CompareOptions opt) { }

	// RVA: 0x163A1E0 Offset: 0x16387E0 VA: 0x18163A1E0
	private Contraction GetContraction(string s, int start, int end) { }

	// RVA: 0x163A2C0 Offset: 0x16388C0 VA: 0x18163A2C0
	private Contraction GetContraction(string s, int start, int end, Contraction[] clist) { }

	// RVA: 0x163AAC0 Offset: 0x16390C0 VA: 0x18163AAC0
	private Contraction GetTailContraction(string s, int start, int end) { }

	// RVA: 0x163ABA0 Offset: 0x16391A0 VA: 0x18163ABA0
	private Contraction GetTailContraction(string s, int start, int end, Contraction[] clist) { }

	// RVA: 0x1639F20 Offset: 0x1638520 VA: 0x181639F20
	private int FilterOptions(int i, CompareOptions opt) { }

	// RVA: 0x163A410 Offset: 0x1638A10 VA: 0x18163A410
	private SimpleCollator.ExtenderType GetExtenderType(int i) { }

	// RVA: 0x163D930 Offset: 0x163BF30 VA: 0x18163D930
	private static byte ToDashTypeValue(SimpleCollator.ExtenderType ext, CompareOptions opt) { }

	// RVA: 0x1639D00 Offset: 0x1638300 VA: 0x181639D00
	private int FilterExtender(int i, SimpleCollator.ExtenderType ext, CompareOptions opt) { }

	// RVA: 0x163B830 Offset: 0x1639E30 VA: 0x18163B830
	private static bool IsIgnorable(int i, CompareOptions opt) { }

	// RVA: 0x163BA80 Offset: 0x163A080 VA: 0x18163BA80
	private bool IsSafe(int i) { }

	// RVA: 0x163A550 Offset: 0x1638B50 VA: 0x18163A550
	public SortKey GetSortKey(string s, CompareOptions options) { }

	// RVA: 0x163A640 Offset: 0x1638C40 VA: 0x18163A640
	public SortKey GetSortKey(string s, int start, int length, CompareOptions options) { }

	// RVA: 0x163A740 Offset: 0x1638D40 VA: 0x18163A740
	private void GetSortKey(string s, int start, int end, SortKeyBuffer buf, CompareOptions opt) { }

	// RVA: 0x16397B0 Offset: 0x1637DB0 VA: 0x1816397B0
	private void FillSortKeyRaw(int i, SimpleCollator.ExtenderType ext, SortKeyBuffer buf, CompareOptions opt) { }

	// RVA: 0x1639C50 Offset: 0x1638250 VA: 0x181639C50
	private void FillSurrogateSortKeyRaw(int i, SortKeyBuffer buf) { }

	// RVA: 0x16396B0 Offset: 0x1637CB0 VA: 0x1816396B0
	internal int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options) { }

	// RVA: 0x16384D0 Offset: 0x1636AD0 VA: 0x1816384D0
	private void ClearBuffer(byte* buffer, int size) { }

	// RVA: 0x1638510 Offset: 0x1636B10 VA: 0x181638510
	private int CompareInternal(string s1, int idx1, int len1, string s2, int idx2, int len2, out bool targetConsumed, out bool sourceConsumed, bool skipHeadingExtenders, bool immediateBreakup, ref SimpleCollator.Context ctx) { }

	// RVA: 0x16384F0 Offset: 0x1636AF0 VA: 0x1816384F0
	private int CompareFlagPair(bool b1, bool b2) { }

	// RVA: 0x163B8C0 Offset: 0x1639EC0 VA: 0x18163B8C0
	public bool IsPrefix(string src, string target, CompareOptions opt) { }

	// RVA: 0x163B900 Offset: 0x1639F00 VA: 0x18163B900
	public bool IsPrefix(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x163BA00 Offset: 0x163A000 VA: 0x18163BA00
	private bool IsPrefix(string s, string target, int start, int length, bool skipHeadingExtenders, ref SimpleCollator.Context ctx) { }

	// RVA: 0x163BBB0 Offset: 0x163A1B0 VA: 0x18163BBB0
	public bool IsSuffix(string src, string target, CompareOptions opt) { }

	// RVA: 0x163BAF0 Offset: 0x163A0F0 VA: 0x18163BAF0
	public bool IsSuffix(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x163D690 Offset: 0x163BC90 VA: 0x18163D690
	private int QuickIndexOf(string s, string target, int start, int length, out bool testWasUnable) { }

	// RVA: 0x163B4E0 Offset: 0x1639AE0 VA: 0x18163B4E0
	public int IndexOf(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x163AE50 Offset: 0x1639450 VA: 0x18163AE50
	private int IndexOfOrdinal(string s, string target, int start, int length) { }

	// RVA: 0x163ADD0 Offset: 0x16393D0 VA: 0x18163ADD0
	private int IndexOfOrdinal(string s, char target, int start, int length) { }

	// RVA: 0x163AF10 Offset: 0x1639510 VA: 0x18163AF10
	private int IndexOfSortKey(string s, int start, int length, byte* sortkey, char target, int ti, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x163AFD0 Offset: 0x16395D0 VA: 0x18163AFD0
	private int IndexOf(string s, string target, int start, int length, byte* targetSortKey, ref SimpleCollator.Context ctx) { }

	// RVA: 0x163C350 Offset: 0x163A950 VA: 0x18163C350
	public int LastIndexOf(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x163BC70 Offset: 0x163A270 VA: 0x18163BC70
	private int LastIndexOfOrdinal(string s, string target, int start, int length) { }

	// RVA: 0x163BDA0 Offset: 0x163A3A0 VA: 0x18163BDA0
	private int LastIndexOfSortKey(string s, int start, int orgStart, int length, byte* sortkey, int ti, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x163BE70 Offset: 0x163A470 VA: 0x18163BE70
	private int LastIndexOf(string s, string target, int start, int length, byte* targetSortKey, ref SimpleCollator.Context ctx) { }

	// RVA: 0x163D2C0 Offset: 0x163B8C0 VA: 0x18163D2C0
	private bool MatchesForward(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x163CF10 Offset: 0x163B510 VA: 0x18163CF10
	private bool MatchesForwardCore(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, SimpleCollator.ExtenderType ext, ref Contraction ct, ref SimpleCollator.Context ctx) { }

	// RVA: 0x163D490 Offset: 0x163BA90 VA: 0x18163D490
	private bool MatchesPrimitive(CompareOptions opt, byte* source, int si, SimpleCollator.ExtenderType ext, byte* target, int ti, bool noLv4) { }

	// RVA: 0x163CD30 Offset: 0x163B330 VA: 0x18163CD30
	private bool MatchesBackward(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x163C720 Offset: 0x163AD20 VA: 0x18163C720
	private bool MatchesBackwardCore(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, SimpleCollator.ExtenderType ext, ref Contraction ct, ref SimpleCollator.Context ctx) { }

	// RVA: 0x163D950 Offset: 0x163BF50 VA: 0x18163D950
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

	// RVA: 0x1F5400 Offset: 0x1F4800 VA: 0x1801F5400
	public void .ctor(CompareOptions opt, byte* alwaysMatchFlags, byte* neverMatchFlags, byte* buffer1, byte* buffer2, byte* prev1) { }

}

private struct SimpleCollator.PreviousInfo // TypeDefIndex: 41
{	// Fields
	public int Code; // 0x0
	public byte* SortKey; // 0x8

	// Methods

	// RVA: 0x1F5520 Offset: 0x1F4920 VA: 0x1801F5520
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

