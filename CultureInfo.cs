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

	// RVA: 0x16DDE10 Offset: 0x16DC410 VA: 0x1816DDE10
	public static CultureInfo get_InvariantCulture() { }

	// RVA: 0x16DDA60 Offset: 0x16DC060 VA: 0x1816DDA60
	public static CultureInfo get_CurrentCulture() { }

	// RVA: 0x16DDA90 Offset: 0x16DC090 VA: 0x1816DDA90
	public static CultureInfo get_CurrentUICulture() { }

	// RVA: 0x16D9C40 Offset: 0x16D8240 VA: 0x1816D9C40
	internal static CultureInfo ConstructCurrentCulture() { }

	// RVA: 0x16D9DD0 Offset: 0x16D83D0 VA: 0x1816D9DD0
	internal static CultureInfo ConstructCurrentUICulture() { }

	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520
	internal string get_Territory() { }

	// RVA: 0x57C9D0 Offset: 0x57AFD0 VA: 0x18057C9D0 Slot: 6
	public virtual int get_LCID() { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450 Slot: 7
	public virtual string get_Name() { }

	// RVA: 0x16DD850 Offset: 0x16DBE50 VA: 0x1816DD850 Slot: 8
	public virtual Calendar get_Calendar() { }

	// RVA: 0x16DDF70 Offset: 0x16DC570 VA: 0x1816DDF70 Slot: 9
	public virtual CultureInfo get_Parent() { }

	// RVA: 0x16DE1B0 Offset: 0x16DC7B0 VA: 0x1816DE1B0 Slot: 10
	public virtual TextInfo get_TextInfo() { }

	// RVA: 0x16D99B0 Offset: 0x16D7FB0 VA: 0x1816D99B0 Slot: 11
	public virtual object Clone() { }

	// RVA: 0x16DC140 Offset: 0x16DA740 VA: 0x1816DC140 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x16DC650 Offset: 0x16DAC50 VA: 0x1816DC650
	public static CultureInfo[] GetCultures(CultureTypes types) { }

	// RVA: 0x16DCB30 Offset: 0x16DB130 VA: 0x1816DCB30
	private CultureInfo.Data GetTextInfoData() { }

	// RVA: 0x16DCB20 Offset: 0x16DB120 VA: 0x1816DCB20 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450 Slot: 3
	public override string ToString() { }

	// RVA: 0x16DD8F0 Offset: 0x16DBEF0 VA: 0x1816DD8F0 Slot: 12
	public virtual CompareInfo get_CompareInfo() { }

	// RVA: 0x16DDE80 Offset: 0x16DC480 VA: 0x1816DDE80 Slot: 13
	public virtual bool get_IsNeutralCulture() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void CheckNeutral() { }

	// RVA: 0x16DDEC0 Offset: 0x16DC4C0 VA: 0x1816DDEC0 Slot: 14
	public virtual NumberFormatInfo get_NumberFormat() { }

	// RVA: 0x16DE680 Offset: 0x16DCC80 VA: 0x1816DE680 Slot: 15
	public virtual void set_NumberFormat(NumberFormatInfo value) { }

	// RVA: 0x16DDAC0 Offset: 0x16DC0C0 VA: 0x1816DDAC0 Slot: 16
	public virtual DateTimeFormatInfo get_DateTimeFormat() { }

	// RVA: 0x16DE5A0 Offset: 0x16DCBA0 VA: 0x1816DE5A0 Slot: 17
	public virtual void set_DateTimeFormat(DateTimeFormatInfo value) { }

	// RVA: 0x16DDCE0 Offset: 0x16DC2E0 VA: 0x1816DDCE0 Slot: 18
	public virtual string get_EnglishName() { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_IsReadOnly() { }

	// RVA: 0x16DCA10 Offset: 0x16DB010 VA: 0x1816DCA10 Slot: 19
	public virtual object GetFormat(Type formatType) { }

	// RVA: 0x16D9FA0 Offset: 0x16D85A0 VA: 0x1816D9FA0
	private void Construct() { }

	// RVA: 0x16DD790 Offset: 0x16DBD90 VA: 0x1816DD790
	private bool construct_internal_locale_from_lcid(int lcid) { }

	// RVA: 0x16DD7A0 Offset: 0x16DBDA0 VA: 0x1816DD7A0
	private bool construct_internal_locale_from_name(string name) { }

	// RVA: 0x16DE400 Offset: 0x16DCA00 VA: 0x1816DE400
	private static string get_current_locale_name() { }

	// RVA: 0x16DE590 Offset: 0x16DCB90 VA: 0x1816DE590
	private static CultureInfo[] internal_get_cultures(bool neutral, bool specific, bool installed) { }

	// RVA: 0x16D9E20 Offset: 0x16D8420 VA: 0x1816D9E20
	private void ConstructInvariant(bool read_only) { }

	// RVA: 0x16DC0C0 Offset: 0x16DA6C0 VA: 0x1816DC0C0
	private TextInfo CreateTextInfo(bool readOnly) { }

	// RVA: 0x16DD1B0 Offset: 0x16DB7B0 VA: 0x1816DD1B0
	public void .ctor(int culture) { }

	// RVA: 0x16DD190 Offset: 0x16DB790 VA: 0x1816DD190
	public void .ctor(int culture, bool useUserOverride) { }

	// RVA: 0x16DD1D0 Offset: 0x16DB7D0 VA: 0x1816DD1D0
	private void .ctor(int culture, bool useUserOverride, bool read_only) { }

	// RVA: 0x16DD4E0 Offset: 0x16DBAE0 VA: 0x1816DD4E0
	public void .ctor(string name) { }

	// RVA: 0x16DD4A0 Offset: 0x16DBAA0 VA: 0x1816DD4A0
	public void .ctor(string name, bool useUserOverride) { }

	// RVA: 0x16DD500 Offset: 0x16DBB00 VA: 0x1816DD500
	private void .ctor(string name, bool useUserOverride, bool read_only) { }

	// RVA: 0x16DD4C0 Offset: 0x16DBAC0 VA: 0x1816DD4C0
	private void .ctor() { }

	// RVA: 0x16DE410 Offset: 0x16DCA10 VA: 0x1816DE410
	private static void insert_into_shared_tables(CultureInfo c) { }

	// RVA: 0x16DC1E0 Offset: 0x16DA7E0 VA: 0x1816DC1E0
	public static CultureInfo GetCultureInfo(int culture) { }

	// RVA: 0x16DC420 Offset: 0x16DAA20 VA: 0x1816DC420
	public static CultureInfo GetCultureInfo(string name) { }

	// RVA: 0x16DA180 Offset: 0x16D8780 VA: 0x1816DA180
	internal static CultureInfo CreateCulture(string name, bool reference) { }

	// RVA: 0x16DBD90 Offset: 0x16DA390 VA: 0x1816DBD90
	public static CultureInfo CreateSpecificCulture(string name) { }

	// RVA: 0x16DA290 Offset: 0x16D8890 VA: 0x1816DA290
	private static CultureInfo CreateSpecificCultureFromNeutral(string name) { }

	// RVA: 0x16DD7B0 Offset: 0x16DBDB0 VA: 0x1816DD7B0
	internal int get_CalendarType() { }

	// RVA: 0x16D9FC0 Offset: 0x16D85C0 VA: 0x1816D9FC0
	private static Calendar CreateCalendar(int calendarType) { }

	// RVA: 0x16DA210 Offset: 0x16D8810 VA: 0x1816DA210
	private static Exception CreateNotFoundException(string name) { }

	// RVA: 0x16DDC00 Offset: 0x16DC200 VA: 0x1816DDC00
	public static CultureInfo get_DefaultThreadCurrentCulture() { }

	// RVA: 0x16DDC70 Offset: 0x16DC270 VA: 0x1816DDC70
	public static CultureInfo get_DefaultThreadCurrentUICulture() { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	internal string get_SortName() { }

	// RVA: 0x16DE370 Offset: 0x16DC970 VA: 0x1816DE370
	internal static CultureInfo get_UserDefaultUICulture() { }

	// RVA: 0x16DE320 Offset: 0x16DC920 VA: 0x1816DE320
	internal static CultureInfo get_UserDefaultCulture() { }

	// RVA: 0x16D9810 Offset: 0x16D7E10 VA: 0x1816D9810
	internal static void CheckDomainSafetyObject(object obj, object container) { }

	// RVA: 0x16DDD20 Offset: 0x16DC320 VA: 0x1816DDD20
	internal bool get_HasInvariantCultureName() { }

	// RVA: 0x16DCB50 Offset: 0x16DB150 VA: 0x1816DCB50
	internal static bool VerifyCultureName(string cultureName, bool throwException) { }

	// RVA: 0x16DCC80 Offset: 0x16DB280 VA: 0x1816DCC80
	internal static bool VerifyCultureName(CultureInfo culture, bool throwException) { }

	// RVA: 0x16DCE30 Offset: 0x16DB430 VA: 0x1816DCE30
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

