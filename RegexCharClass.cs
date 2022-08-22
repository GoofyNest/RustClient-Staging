internal sealed class RegexCharClass // TypeDefIndex: 2608
{	// Fields
	private List<RegexCharClass.SingleRange> _rangelist; // 0x10
	private StringBuilder _categories; // 0x18
	private bool _canonical; // 0x20
	private bool _negate; // 0x21
	private RegexCharClass _subtractor; // 0x28
	private static readonly string InternalRegexIgnoreCase; // 0x0
	private static readonly string Space; // 0x8
	private static readonly string NotSpace; // 0x10
	private static readonly string Word; // 0x18
	private static readonly string NotWord; // 0x20
	internal static readonly string SpaceClass; // 0x28
	internal static readonly string NotSpaceClass; // 0x30
	internal static readonly string WordClass; // 0x38
	internal static readonly string NotWordClass; // 0x40
	internal static readonly string DigitClass; // 0x48
	internal static readonly string NotDigitClass; // 0x50
	private static Dictionary<string, string> _definedCategories; // 0x58
	private static readonly string[,] _propTable; // 0x60
	private static readonly RegexCharClass.LowerCaseMapping[] _lcTable; // 0x68

	// Properties
	internal bool CanMerge { get; }
	internal bool Negate { set; }

	// Methods

	// RVA: 0x14C3D30 Offset: 0x14C2330 VA: 0x1814C3D30
	private static void .cctor() { }

	// RVA: 0x14C92C0 Offset: 0x14C78C0 VA: 0x1814C92C0
	internal void .ctor() { }

	// RVA: 0x14C9360 Offset: 0x14C7960 VA: 0x1814C9360
	private void .ctor(bool negate, List<RegexCharClass.SingleRange> ranges, StringBuilder categories, RegexCharClass subtraction) { }

	// RVA: 0x14C93E0 Offset: 0x14C79E0 VA: 0x1814C93E0
	internal bool get_CanMerge() { }

	// RVA: 0x13A2B40 Offset: 0x13A1140 VA: 0x1813A2B40
	internal void set_Negate(bool value) { }

	// RVA: 0x14C1BD0 Offset: 0x14C01D0 VA: 0x1814C1BD0
	internal void AddChar(char c) { }

	// RVA: 0x14C19E0 Offset: 0x14BFFE0 VA: 0x1814C19E0
	internal void AddCharClass(RegexCharClass cc) { }

	// RVA: 0x14C2190 Offset: 0x14C0790 VA: 0x1814C2190
	private void AddSet(string set) { }

	// RVA: 0x7EE9E0 Offset: 0x7ECFE0 VA: 0x1807EE9E0
	internal void AddSubtraction(RegexCharClass sub) { }

	// RVA: 0x14C20B0 Offset: 0x14C06B0 VA: 0x1814C20B0
	internal void AddRange(char first, char last) { }

	// RVA: 0x14C1790 Offset: 0x14BFD90 VA: 0x1814C1790
	internal void AddCategoryFromName(string categoryName, bool invert, bool caseInsensitive, string pattern) { }

	// RVA: 0x14C19C0 Offset: 0x14BFFC0 VA: 0x1814C19C0
	private void AddCategory(string category) { }

	// RVA: 0x14C1F70 Offset: 0x14C0570 VA: 0x1814C1F70
	internal void AddLowercase(CultureInfo culture) { }

	// RVA: 0x14C1C80 Offset: 0x14C0280 VA: 0x1814C1C80
	private void AddLowercaseRange(char chMin, char chMax, CultureInfo culture) { }

	// RVA: 0x14C24A0 Offset: 0x14C0AA0 VA: 0x1814C24A0
	internal void AddWord(bool ecma, bool negate) { }

	// RVA: 0x14C2380 Offset: 0x14C0980 VA: 0x1814C2380
	internal void AddSpace(bool ecma, bool negate) { }

	// RVA: 0x14C1BE0 Offset: 0x14C01E0 VA: 0x1814C1BE0
	internal void AddDigit(bool ecma, bool negate, string pattern) { }

	// RVA: 0x14C3B20 Offset: 0x14C2120 VA: 0x1814C3B20
	internal static char SingletonChar(string set) { }

	// RVA: 0x14C2FF0 Offset: 0x14C15F0 VA: 0x1814C2FF0
	internal static bool IsMergeable(string charClass) { }

	// RVA: 0x14C2F00 Offset: 0x14C1500 VA: 0x1814C2F00
	internal static bool IsEmpty(string charClass) { }

	// RVA: 0x14C3240 Offset: 0x14C1840 VA: 0x1814C3240
	internal static bool IsSingleton(string set) { }

	// RVA: 0x14C3100 Offset: 0x14C1700 VA: 0x1814C3100
	internal static bool IsSingletonInverse(string set) { }

	// RVA: 0x14C3380 Offset: 0x14C1980 VA: 0x1814C3380
	private static bool IsSubtraction(string charClass) { }

	// RVA: 0x14C30D0 Offset: 0x14C16D0 VA: 0x1814C30D0
	internal static bool IsNegated(string set) { }

	// RVA: 0x14C2E50 Offset: 0x14C1450 VA: 0x1814C2E50
	internal static bool IsECMAWordChar(char ch) { }

	// RVA: 0x14C33E0 Offset: 0x14C19E0 VA: 0x1814C33E0
	internal static bool IsWordChar(char ch) { }

	// RVA: 0x14C2D80 Offset: 0x14C1380 VA: 0x1814C2D80
	internal static bool CharInClass(char ch, string set) { }

	// RVA: 0x14C2B90 Offset: 0x14C1190 VA: 0x1814C2B90
	internal static bool CharInClassRecursive(char ch, string set, int start) { }

	// RVA: 0x14C2A90 Offset: 0x14C1090 VA: 0x1814C2A90
	private static bool CharInClassInternal(char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	// RVA: 0x14C28F0 Offset: 0x14C0EF0 VA: 0x1814C28F0
	private static bool CharInCategory(char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	// RVA: 0x14C2820 Offset: 0x14C0E20 VA: 0x1814C2820
	private static bool CharInCategoryGroup(char ch, UnicodeCategory chcategory, string category, ref int i) { }

	// RVA: 0x14C34C0 Offset: 0x14C1AC0 VA: 0x1814C34C0
	private static string NegateCategory(string category) { }

	// RVA: 0x14C37D0 Offset: 0x14C1DD0 VA: 0x1814C37D0
	internal static RegexCharClass Parse(string charClass) { }

	// RVA: 0x14C3590 Offset: 0x14C1B90 VA: 0x1814C3590
	private static RegexCharClass ParseRecursive(string charClass, int start) { }

	// RVA: 0x14C3830 Offset: 0x14C1E30 VA: 0x1814C3830
	private int RangeCount() { }

	// RVA: 0x14C3B40 Offset: 0x14C2140 VA: 0x1814C3B40
	internal string ToStringClass() { }

	// RVA: 0x14C2DF0 Offset: 0x14C13F0 VA: 0x1814C2DF0
	private RegexCharClass.SingleRange GetRangeAt(int i) { }

	// RVA: 0x14C25C0 Offset: 0x14C0BC0 VA: 0x1814C25C0
	private void Canonicalize() { }

	// RVA: 0x14C3870 Offset: 0x14C1E70 VA: 0x1814C3870
	private static string SetFromProperty(string capname, bool invert, string pattern) { }

}

private struct RegexCharClass.LowerCaseMapping // TypeDefIndex: 2609
{	// Fields
	internal char _chMin; // 0x0
	internal char _chMax; // 0x2
	internal int _lcOp; // 0x4
	internal int _data; // 0x8

	// Methods

	// RVA: 0x1F1E60 Offset: 0x1F1260 VA: 0x1801F1E60
	internal void .ctor(char chMin, char chMax, int lcOp, int data) { }

}

private sealed class RegexCharClass.SingleRangeComparer : IComparer<RegexCharClass.SingleRange> // TypeDefIndex: 2610
{	// Methods

	// RVA: 0x14CE240 Offset: 0x14CC840 VA: 0x1814CE240 Slot: 4
	public int Compare(RegexCharClass.SingleRange x, RegexCharClass.SingleRange y) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class RegexCharClass.SingleRange // TypeDefIndex: 2611
{	// Fields
	internal char _first; // 0x10
	internal char _last; // 0x12

	// Methods

	// RVA: 0x14CE280 Offset: 0x14CC880 VA: 0x1814CE280
	internal void .ctor(char first, char last) { }

}

