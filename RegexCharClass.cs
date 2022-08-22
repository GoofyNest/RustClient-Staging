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

	// RVA: 0x14C4C60 Offset: 0x14C3260 VA: 0x1814C4C60
	private static void .cctor() { }

	// RVA: 0x14CA1F0 Offset: 0x14C87F0 VA: 0x1814CA1F0
	internal void .ctor() { }

	// RVA: 0x14CA290 Offset: 0x14C8890 VA: 0x1814CA290
	private void .ctor(bool negate, List<RegexCharClass.SingleRange> ranges, StringBuilder categories, RegexCharClass subtraction) { }

	// RVA: 0x14CA310 Offset: 0x14C8910 VA: 0x1814CA310
	internal bool get_CanMerge() { }

	// RVA: 0x13A3A40 Offset: 0x13A2040 VA: 0x1813A3A40
	internal void set_Negate(bool value) { }

	// RVA: 0x14C2B00 Offset: 0x14C1100 VA: 0x1814C2B00
	internal void AddChar(char c) { }

	// RVA: 0x14C2910 Offset: 0x14C0F10 VA: 0x1814C2910
	internal void AddCharClass(RegexCharClass cc) { }

	// RVA: 0x14C30C0 Offset: 0x14C16C0 VA: 0x1814C30C0
	private void AddSet(string set) { }

	// RVA: 0x7EE450 Offset: 0x7ECA50 VA: 0x1807EE450
	internal void AddSubtraction(RegexCharClass sub) { }

	// RVA: 0x14C2FE0 Offset: 0x14C15E0 VA: 0x1814C2FE0
	internal void AddRange(char first, char last) { }

	// RVA: 0x14C26C0 Offset: 0x14C0CC0 VA: 0x1814C26C0
	internal void AddCategoryFromName(string categoryName, bool invert, bool caseInsensitive, string pattern) { }

	// RVA: 0x14C28F0 Offset: 0x14C0EF0 VA: 0x1814C28F0
	private void AddCategory(string category) { }

	// RVA: 0x14C2EA0 Offset: 0x14C14A0 VA: 0x1814C2EA0
	internal void AddLowercase(CultureInfo culture) { }

	// RVA: 0x14C2BB0 Offset: 0x14C11B0 VA: 0x1814C2BB0
	private void AddLowercaseRange(char chMin, char chMax, CultureInfo culture) { }

	// RVA: 0x14C33D0 Offset: 0x14C19D0 VA: 0x1814C33D0
	internal void AddWord(bool ecma, bool negate) { }

	// RVA: 0x14C32B0 Offset: 0x14C18B0 VA: 0x1814C32B0
	internal void AddSpace(bool ecma, bool negate) { }

	// RVA: 0x14C2B10 Offset: 0x14C1110 VA: 0x1814C2B10
	internal void AddDigit(bool ecma, bool negate, string pattern) { }

	// RVA: 0x14C4A50 Offset: 0x14C3050 VA: 0x1814C4A50
	internal static char SingletonChar(string set) { }

	// RVA: 0x14C3F20 Offset: 0x14C2520 VA: 0x1814C3F20
	internal static bool IsMergeable(string charClass) { }

	// RVA: 0x14C3E30 Offset: 0x14C2430 VA: 0x1814C3E30
	internal static bool IsEmpty(string charClass) { }

	// RVA: 0x14C4170 Offset: 0x14C2770 VA: 0x1814C4170
	internal static bool IsSingleton(string set) { }

	// RVA: 0x14C4030 Offset: 0x14C2630 VA: 0x1814C4030
	internal static bool IsSingletonInverse(string set) { }

	// RVA: 0x14C42B0 Offset: 0x14C28B0 VA: 0x1814C42B0
	private static bool IsSubtraction(string charClass) { }

	// RVA: 0x14C4000 Offset: 0x14C2600 VA: 0x1814C4000
	internal static bool IsNegated(string set) { }

	// RVA: 0x14C3D80 Offset: 0x14C2380 VA: 0x1814C3D80
	internal static bool IsECMAWordChar(char ch) { }

	// RVA: 0x14C4310 Offset: 0x14C2910 VA: 0x1814C4310
	internal static bool IsWordChar(char ch) { }

	// RVA: 0x14C3CB0 Offset: 0x14C22B0 VA: 0x1814C3CB0
	internal static bool CharInClass(char ch, string set) { }

	// RVA: 0x14C3AC0 Offset: 0x14C20C0 VA: 0x1814C3AC0
	internal static bool CharInClassRecursive(char ch, string set, int start) { }

	// RVA: 0x14C39C0 Offset: 0x14C1FC0 VA: 0x1814C39C0
	private static bool CharInClassInternal(char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	// RVA: 0x14C3820 Offset: 0x14C1E20 VA: 0x1814C3820
	private static bool CharInCategory(char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	// RVA: 0x14C3750 Offset: 0x14C1D50 VA: 0x1814C3750
	private static bool CharInCategoryGroup(char ch, UnicodeCategory chcategory, string category, ref int i) { }

	// RVA: 0x14C43F0 Offset: 0x14C29F0 VA: 0x1814C43F0
	private static string NegateCategory(string category) { }

	// RVA: 0x14C4700 Offset: 0x14C2D00 VA: 0x1814C4700
	internal static RegexCharClass Parse(string charClass) { }

	// RVA: 0x14C44C0 Offset: 0x14C2AC0 VA: 0x1814C44C0
	private static RegexCharClass ParseRecursive(string charClass, int start) { }

	// RVA: 0x14C4760 Offset: 0x14C2D60 VA: 0x1814C4760
	private int RangeCount() { }

	// RVA: 0x14C4A70 Offset: 0x14C3070 VA: 0x1814C4A70
	internal string ToStringClass() { }

	// RVA: 0x14C3D20 Offset: 0x14C2320 VA: 0x1814C3D20
	private RegexCharClass.SingleRange GetRangeAt(int i) { }

	// RVA: 0x14C34F0 Offset: 0x14C1AF0 VA: 0x1814C34F0
	private void Canonicalize() { }

	// RVA: 0x14C47A0 Offset: 0x14C2DA0 VA: 0x1814C47A0
	private static string SetFromProperty(string capname, bool invert, string pattern) { }

}

private struct RegexCharClass.LowerCaseMapping // TypeDefIndex: 2609
{	// Fields
	internal char _chMin; // 0x0
	internal char _chMax; // 0x2
	internal int _lcOp; // 0x4
	internal int _data; // 0x8

	// Methods

	// RVA: 0x1F1A40 Offset: 0x1F0E40 VA: 0x1801F1A40
	internal void .ctor(char chMin, char chMax, int lcOp, int data) { }

}

private sealed class RegexCharClass.SingleRangeComparer : IComparer<RegexCharClass.SingleRange> // TypeDefIndex: 2610
{	// Methods

	// RVA: 0x14CF170 Offset: 0x14CD770 VA: 0x1814CF170 Slot: 4
	public int Compare(RegexCharClass.SingleRange x, RegexCharClass.SingleRange y) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class RegexCharClass.SingleRange // TypeDefIndex: 2611
{	// Fields
	internal char _first; // 0x10
	internal char _last; // 0x12

	// Methods

	// RVA: 0x14CF1B0 Offset: 0x14CD7B0 VA: 0x1814CF1B0
	internal void .ctor(char first, char last) { }

}

