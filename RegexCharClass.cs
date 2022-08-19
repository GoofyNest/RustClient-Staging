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

	// RVA: 0x14C49A0 Offset: 0x14C2FA0 VA: 0x1814C49A0
	private static void .cctor() { }

	// RVA: 0x14C9F30 Offset: 0x14C8530 VA: 0x1814C9F30
	internal void .ctor() { }

	// RVA: 0x14C9FD0 Offset: 0x14C85D0 VA: 0x1814C9FD0
	private void .ctor(bool negate, List<RegexCharClass.SingleRange> ranges, StringBuilder categories, RegexCharClass subtraction) { }

	// RVA: 0x14CA050 Offset: 0x14C8650 VA: 0x1814CA050
	internal bool get_CanMerge() { }

	// RVA: 0x13A3780 Offset: 0x13A1D80 VA: 0x1813A3780
	internal void set_Negate(bool value) { }

	// RVA: 0x14C2840 Offset: 0x14C0E40 VA: 0x1814C2840
	internal void AddChar(char c) { }

	// RVA: 0x14C2650 Offset: 0x14C0C50 VA: 0x1814C2650
	internal void AddCharClass(RegexCharClass cc) { }

	// RVA: 0x14C2E00 Offset: 0x14C1400 VA: 0x1814C2E00
	private void AddSet(string set) { }

	// RVA: 0x7EE340 Offset: 0x7EC940 VA: 0x1807EE340
	internal void AddSubtraction(RegexCharClass sub) { }

	// RVA: 0x14C2D20 Offset: 0x14C1320 VA: 0x1814C2D20
	internal void AddRange(char first, char last) { }

	// RVA: 0x14C2400 Offset: 0x14C0A00 VA: 0x1814C2400
	internal void AddCategoryFromName(string categoryName, bool invert, bool caseInsensitive, string pattern) { }

	// RVA: 0x14C2630 Offset: 0x14C0C30 VA: 0x1814C2630
	private void AddCategory(string category) { }

	// RVA: 0x14C2BE0 Offset: 0x14C11E0 VA: 0x1814C2BE0
	internal void AddLowercase(CultureInfo culture) { }

	// RVA: 0x14C28F0 Offset: 0x14C0EF0 VA: 0x1814C28F0
	private void AddLowercaseRange(char chMin, char chMax, CultureInfo culture) { }

	// RVA: 0x14C3110 Offset: 0x14C1710 VA: 0x1814C3110
	internal void AddWord(bool ecma, bool negate) { }

	// RVA: 0x14C2FF0 Offset: 0x14C15F0 VA: 0x1814C2FF0
	internal void AddSpace(bool ecma, bool negate) { }

	// RVA: 0x14C2850 Offset: 0x14C0E50 VA: 0x1814C2850
	internal void AddDigit(bool ecma, bool negate, string pattern) { }

	// RVA: 0x14C4790 Offset: 0x14C2D90 VA: 0x1814C4790
	internal static char SingletonChar(string set) { }

	// RVA: 0x14C3C60 Offset: 0x14C2260 VA: 0x1814C3C60
	internal static bool IsMergeable(string charClass) { }

	// RVA: 0x14C3B70 Offset: 0x14C2170 VA: 0x1814C3B70
	internal static bool IsEmpty(string charClass) { }

	// RVA: 0x14C3EB0 Offset: 0x14C24B0 VA: 0x1814C3EB0
	internal static bool IsSingleton(string set) { }

	// RVA: 0x14C3D70 Offset: 0x14C2370 VA: 0x1814C3D70
	internal static bool IsSingletonInverse(string set) { }

	// RVA: 0x14C3FF0 Offset: 0x14C25F0 VA: 0x1814C3FF0
	private static bool IsSubtraction(string charClass) { }

	// RVA: 0x14C3D40 Offset: 0x14C2340 VA: 0x1814C3D40
	internal static bool IsNegated(string set) { }

	// RVA: 0x14C3AC0 Offset: 0x14C20C0 VA: 0x1814C3AC0
	internal static bool IsECMAWordChar(char ch) { }

	// RVA: 0x14C4050 Offset: 0x14C2650 VA: 0x1814C4050
	internal static bool IsWordChar(char ch) { }

	// RVA: 0x14C39F0 Offset: 0x14C1FF0 VA: 0x1814C39F0
	internal static bool CharInClass(char ch, string set) { }

	// RVA: 0x14C3800 Offset: 0x14C1E00 VA: 0x1814C3800
	internal static bool CharInClassRecursive(char ch, string set, int start) { }

	// RVA: 0x14C3700 Offset: 0x14C1D00 VA: 0x1814C3700
	private static bool CharInClassInternal(char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	// RVA: 0x14C3560 Offset: 0x14C1B60 VA: 0x1814C3560
	private static bool CharInCategory(char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	// RVA: 0x14C3490 Offset: 0x14C1A90 VA: 0x1814C3490
	private static bool CharInCategoryGroup(char ch, UnicodeCategory chcategory, string category, ref int i) { }

	// RVA: 0x14C4130 Offset: 0x14C2730 VA: 0x1814C4130
	private static string NegateCategory(string category) { }

	// RVA: 0x14C4440 Offset: 0x14C2A40 VA: 0x1814C4440
	internal static RegexCharClass Parse(string charClass) { }

	// RVA: 0x14C4200 Offset: 0x14C2800 VA: 0x1814C4200
	private static RegexCharClass ParseRecursive(string charClass, int start) { }

	// RVA: 0x14C44A0 Offset: 0x14C2AA0 VA: 0x1814C44A0
	private int RangeCount() { }

	// RVA: 0x14C47B0 Offset: 0x14C2DB0 VA: 0x1814C47B0
	internal string ToStringClass() { }

	// RVA: 0x14C3A60 Offset: 0x14C2060 VA: 0x1814C3A60
	private RegexCharClass.SingleRange GetRangeAt(int i) { }

	// RVA: 0x14C3230 Offset: 0x14C1830 VA: 0x1814C3230
	private void Canonicalize() { }

	// RVA: 0x14C44E0 Offset: 0x14C2AE0 VA: 0x1814C44E0
	private static string SetFromProperty(string capname, bool invert, string pattern) { }

}

private struct RegexCharClass.LowerCaseMapping // TypeDefIndex: 2609
{	// Fields
	internal char _chMin; // 0x0
	internal char _chMax; // 0x2
	internal int _lcOp; // 0x4
	internal int _data; // 0x8

	// Methods

	// RVA: 0x1F1AC0 Offset: 0x1F0EC0 VA: 0x1801F1AC0
	internal void .ctor(char chMin, char chMax, int lcOp, int data) { }

}

private sealed class RegexCharClass.SingleRangeComparer : IComparer<RegexCharClass.SingleRange> // TypeDefIndex: 2610
{	// Methods

	// RVA: 0x14CEEB0 Offset: 0x14CD4B0 VA: 0x1814CEEB0 Slot: 4
	public int Compare(RegexCharClass.SingleRange x, RegexCharClass.SingleRange y) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class RegexCharClass.SingleRange // TypeDefIndex: 2611
{	// Fields
	internal char _first; // 0x10
	internal char _last; // 0x12

	// Methods

	// RVA: 0x14CEEF0 Offset: 0x14CD4F0 VA: 0x1814CEEF0
	internal void .ctor(char first, char last) { }

}

