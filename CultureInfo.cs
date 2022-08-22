public class CultureInfo : ICloneable, IFormatProvider // TypeDefIndex: 741
{	// Fields
	private static CultureInfo invariant_culture_info; // 0x0
	private static object shared_table_lock; // 0x8
	private static CultureInfo default_current_culture; // 0x10
	private bool m_isReadOnly; // 0x10
	private int cultureID; // 0x14
	private int parent_lcid; // 0x18
	private int datetime_index; // 0x1C
	private int number_index; // 0x20
	private int default_calendar_type; // 0x24
	private bool m_useUserOverride; // 0x28
	internal NumberFormatInfo numInfo; // 0x30
	internal DateTimeFormatInfo dateTimeInfo; // 0x38
	private TextInfo textInfo; // 0x40
	internal string m_name; // 0x48
	private string englishname; // 0x50
	private string nativename; // 0x58
	private string iso3lang; // 0x60
	private string iso2lang; // 0x68
	private string win3lang; // 0x70
	private string territory; // 0x78
	private string[] native_calendar_names; // 0x80
	private CompareInfo compareInfo; // 0x88
	private readonly void* textinfo_data; // 0x90
	private int m_dataItem; // 0x98
	private Calendar calendar; // 0xA0
	private CultureInfo parent_culture; // 0xA8
	private bool constructed; // 0xB0
	internal byte[] cached_serialized_form; // 0xB8
	internal CultureData m_cultureData; // 0xC0
	internal bool m_isInherited; // 0xC8
	internal const int InvariantCultureId = 127;
	private const int CalendarTypeBits = 8;
	private const string MSG_READONLY = "This instance is read only";
	private static CultureInfo s_DefaultThreadCurrentUICulture; // 0x18
	private static CultureInfo s_DefaultThreadCurrentCulture; // 0x20
	private static Dictionary<int, CultureInfo> shared_by_number; // 0x28
	private static Dictionary<string, CultureInfo> shared_by_name; // 0x30
	internal static readonly bool IsTaiwanSku; // 0x38

	// Properties
	public static CultureInfo InvariantCulture { get; }
	public static CultureInfo CurrentCulture { get; }
	public static CultureInfo CurrentUICulture { get; }
	internal string Territory { get; }
	public virtual int LCID { get; }
	public virtual string Name { get; }
	public virtual Calendar Calendar { get; }
	public virtual CultureInfo Parent { get; }
	public virtual TextInfo TextInfo { get; }
	public virtual CompareInfo CompareInfo { get; }
	public virtual bool IsNeutralCulture { get; }
	public virtual NumberFormatInfo NumberFormat { get; set; }
	public virtual DateTimeFormatInfo DateTimeFormat { get; set; }
	public virtual string EnglishName { get; }
	public bool IsReadOnly { get; }
	internal int CalendarType { get; }
	public static CultureInfo DefaultThreadCurrentCulture { get; }
	public static CultureInfo DefaultThreadCurrentUICulture { get; }
	internal string SortName { get; }
	internal static CultureInfo UserDefaultUICulture { get; }
	internal static CultureInfo UserDefaultCulture { get; }
	internal bool HasInvariantCultureName { get; }

	// Methods

	// RVA: 0x16DBA00 Offset: 0x16DA000 VA: 0x1816DBA00
	public static CultureInfo get_InvariantCulture() { }

	// RVA: 0x16DB650 Offset: 0x16D9C50 VA: 0x1816DB650
	public static CultureInfo get_CurrentCulture() { }

	// RVA: 0x16DB680 Offset: 0x16D9C80 VA: 0x1816DB680
	public static CultureInfo get_CurrentUICulture() { }

	// RVA: 0x16D7830 Offset: 0x16D5E30 VA: 0x1816D7830
	internal static CultureInfo ConstructCurrentCulture() { }

	// RVA: 0x16D79C0 Offset: 0x16D5FC0 VA: 0x1816D79C0
	internal static CultureInfo ConstructCurrentUICulture() { }

	// RVA: 0x4E84B0 Offset: 0x4E6AB0 VA: 0x1804E84B0
	internal string get_Territory() { }

	// RVA: 0x57C960 Offset: 0x57AF60 VA: 0x18057C960 Slot: 6
	public virtual int get_LCID() { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0 Slot: 7
	public virtual string get_Name() { }

	// RVA: 0x16DB440 Offset: 0x16D9A40 VA: 0x1816DB440 Slot: 8
	public virtual Calendar get_Calendar() { }

	// RVA: 0x16DBB60 Offset: 0x16DA160 VA: 0x1816DBB60 Slot: 9
	public virtual CultureInfo get_Parent() { }

	// RVA: 0x16DBDA0 Offset: 0x16DA3A0 VA: 0x1816DBDA0 Slot: 10
	public virtual TextInfo get_TextInfo() { }

	// RVA: 0x16D75A0 Offset: 0x16D5BA0 VA: 0x1816D75A0 Slot: 11
	public virtual object Clone() { }

	// RVA: 0x16D9D30 Offset: 0x16D8330 VA: 0x1816D9D30 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x16DA240 Offset: 0x16D8840 VA: 0x1816DA240
	public static CultureInfo[] GetCultures(CultureTypes types) { }

	// RVA: 0x16DA720 Offset: 0x16D8D20 VA: 0x1816DA720
	private CultureInfo.Data GetTextInfoData() { }

	// RVA: 0x16DA710 Offset: 0x16D8D10 VA: 0x1816DA710 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x16DB4E0 Offset: 0x16D9AE0 VA: 0x1816DB4E0 Slot: 12
	public virtual CompareInfo get_CompareInfo() { }

	// RVA: 0x16DBA70 Offset: 0x16DA070 VA: 0x1816DBA70 Slot: 13
	public virtual bool get_IsNeutralCulture() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void CheckNeutral() { }

	// RVA: 0x16DBAB0 Offset: 0x16DA0B0 VA: 0x1816DBAB0 Slot: 14
	public virtual NumberFormatInfo get_NumberFormat() { }

	// RVA: 0x16DC270 Offset: 0x16DA870 VA: 0x1816DC270 Slot: 15
	public virtual void set_NumberFormat(NumberFormatInfo value) { }

	// RVA: 0x16DB6B0 Offset: 0x16D9CB0 VA: 0x1816DB6B0 Slot: 16
	public virtual DateTimeFormatInfo get_DateTimeFormat() { }

	// RVA: 0x16DC190 Offset: 0x16DA790 VA: 0x1816DC190 Slot: 17
	public virtual void set_DateTimeFormat(DateTimeFormatInfo value) { }

	// RVA: 0x16DB8D0 Offset: 0x16D9ED0 VA: 0x1816DB8D0 Slot: 18
	public virtual string get_EnglishName() { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_IsReadOnly() { }

	// RVA: 0x16DA600 Offset: 0x16D8C00 VA: 0x1816DA600 Slot: 19
	public virtual object GetFormat(Type formatType) { }

	// RVA: 0x16D7B90 Offset: 0x16D6190 VA: 0x1816D7B90
	private void Construct() { }

	// RVA: 0x16DB380 Offset: 0x16D9980 VA: 0x1816DB380
	private bool construct_internal_locale_from_lcid(int lcid) { }

	// RVA: 0x16DB390 Offset: 0x16D9990 VA: 0x1816DB390
	private bool construct_internal_locale_from_name(string name) { }

	// RVA: 0x16DBFF0 Offset: 0x16DA5F0 VA: 0x1816DBFF0
	private static string get_current_locale_name() { }

	// RVA: 0x16DC180 Offset: 0x16DA780 VA: 0x1816DC180
	private static CultureInfo[] internal_get_cultures(bool neutral, bool specific, bool installed) { }

	// RVA: 0x16D7A10 Offset: 0x16D6010 VA: 0x1816D7A10
	private void ConstructInvariant(bool read_only) { }

	// RVA: 0x16D9CB0 Offset: 0x16D82B0 VA: 0x1816D9CB0
	private TextInfo CreateTextInfo(bool readOnly) { }

	// RVA: 0x16DADA0 Offset: 0x16D93A0 VA: 0x1816DADA0
	public void .ctor(int culture) { }

	// RVA: 0x16DAD80 Offset: 0x16D9380 VA: 0x1816DAD80
	public void .ctor(int culture, bool useUserOverride) { }

	// RVA: 0x16DADC0 Offset: 0x16D93C0 VA: 0x1816DADC0
	private void .ctor(int culture, bool useUserOverride, bool read_only) { }

	// RVA: 0x16DB0D0 Offset: 0x16D96D0 VA: 0x1816DB0D0
	public void .ctor(string name) { }

	// RVA: 0x16DB090 Offset: 0x16D9690 VA: 0x1816DB090
	public void .ctor(string name, bool useUserOverride) { }

	// RVA: 0x16DB0F0 Offset: 0x16D96F0 VA: 0x1816DB0F0
	private void .ctor(string name, bool useUserOverride, bool read_only) { }

	// RVA: 0x16DB0B0 Offset: 0x16D96B0 VA: 0x1816DB0B0
	private void .ctor() { }

	// RVA: 0x16DC000 Offset: 0x16DA600 VA: 0x1816DC000
	private static void insert_into_shared_tables(CultureInfo c) { }

	// RVA: 0x16D9DD0 Offset: 0x16D83D0 VA: 0x1816D9DD0
	public static CultureInfo GetCultureInfo(int culture) { }

	// RVA: 0x16DA010 Offset: 0x16D8610 VA: 0x1816DA010
	public static CultureInfo GetCultureInfo(string name) { }

	// RVA: 0x16D7D70 Offset: 0x16D6370 VA: 0x1816D7D70
	internal static CultureInfo CreateCulture(string name, bool reference) { }

	// RVA: 0x16D9980 Offset: 0x16D7F80 VA: 0x1816D9980
	public static CultureInfo CreateSpecificCulture(string name) { }

	// RVA: 0x16D7E80 Offset: 0x16D6480 VA: 0x1816D7E80
	private static CultureInfo CreateSpecificCultureFromNeutral(string name) { }

	// RVA: 0x16DB3A0 Offset: 0x16D99A0 VA: 0x1816DB3A0
	internal int get_CalendarType() { }

	// RVA: 0x16D7BB0 Offset: 0x16D61B0 VA: 0x1816D7BB0
	private static Calendar CreateCalendar(int calendarType) { }

	// RVA: 0x16D7E00 Offset: 0x16D6400 VA: 0x1816D7E00
	private static Exception CreateNotFoundException(string name) { }

	// RVA: 0x16DB7F0 Offset: 0x16D9DF0 VA: 0x1816DB7F0
	public static CultureInfo get_DefaultThreadCurrentCulture() { }

	// RVA: 0x16DB860 Offset: 0x16D9E60 VA: 0x1816DB860
	public static CultureInfo get_DefaultThreadCurrentUICulture() { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	internal string get_SortName() { }

	// RVA: 0x16DBF60 Offset: 0x16DA560 VA: 0x1816DBF60
	internal static CultureInfo get_UserDefaultUICulture() { }

	// RVA: 0x16DBF10 Offset: 0x16DA510 VA: 0x1816DBF10
	internal static CultureInfo get_UserDefaultCulture() { }

	// RVA: 0x16D7400 Offset: 0x16D5A00 VA: 0x1816D7400
	internal static void CheckDomainSafetyObject(object obj, object container) { }

	// RVA: 0x16DB910 Offset: 0x16D9F10 VA: 0x1816DB910
	internal bool get_HasInvariantCultureName() { }

	// RVA: 0x16DA740 Offset: 0x16D8D40 VA: 0x1816DA740
	internal static bool VerifyCultureName(string cultureName, bool throwException) { }

	// RVA: 0x16DA870 Offset: 0x16D8E70 VA: 0x1816DA870
	internal static bool VerifyCultureName(CultureInfo culture, bool throwException) { }

	// RVA: 0x16DAA20 Offset: 0x16D9020 VA: 0x1816DAA20
	private static void .cctor() { }

}

private struct CultureInfo.Data // TypeDefIndex: 742
{	// Fields
	public int ansi; // 0x0
	public int ebcdic; // 0x4
	public int mac; // 0x8
	public int oem; // 0xC
	public bool right_to_left; // 0x10
	public byte list_sep; // 0x11

}

