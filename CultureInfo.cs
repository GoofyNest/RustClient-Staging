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

	// RVA: 0x16DDB50 Offset: 0x16DC150 VA: 0x1816DDB50
	public static CultureInfo get_InvariantCulture() { }

	// RVA: 0x16DD7A0 Offset: 0x16DBDA0 VA: 0x1816DD7A0
	public static CultureInfo get_CurrentCulture() { }

	// RVA: 0x16DD7D0 Offset: 0x16DBDD0 VA: 0x1816DD7D0
	public static CultureInfo get_CurrentUICulture() { }

	// RVA: 0x16D9980 Offset: 0x16D7F80 VA: 0x1816D9980
	internal static CultureInfo ConstructCurrentCulture() { }

	// RVA: 0x16D9B10 Offset: 0x16D8110 VA: 0x1816D9B10
	internal static CultureInfo ConstructCurrentUICulture() { }

	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520
	internal string get_Territory() { }

	// RVA: 0x57C9D0 Offset: 0x57AFD0 VA: 0x18057C9D0 Slot: 6
	public virtual int get_LCID() { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450 Slot: 7
	public virtual string get_Name() { }

	// RVA: 0x16DD590 Offset: 0x16DBB90 VA: 0x1816DD590 Slot: 8
	public virtual Calendar get_Calendar() { }

	// RVA: 0x16DDCB0 Offset: 0x16DC2B0 VA: 0x1816DDCB0 Slot: 9
	public virtual CultureInfo get_Parent() { }

	// RVA: 0x16DDEF0 Offset: 0x16DC4F0 VA: 0x1816DDEF0 Slot: 10
	public virtual TextInfo get_TextInfo() { }

	// RVA: 0x16D96F0 Offset: 0x16D7CF0 VA: 0x1816D96F0 Slot: 11
	public virtual object Clone() { }

	// RVA: 0x16DBE80 Offset: 0x16DA480 VA: 0x1816DBE80 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x16DC390 Offset: 0x16DA990 VA: 0x1816DC390
	public static CultureInfo[] GetCultures(CultureTypes types) { }

	// RVA: 0x16DC870 Offset: 0x16DAE70 VA: 0x1816DC870
	private CultureInfo.Data GetTextInfoData() { }

	// RVA: 0x16DC860 Offset: 0x16DAE60 VA: 0x1816DC860 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450 Slot: 3
	public override string ToString() { }

	// RVA: 0x16DD630 Offset: 0x16DBC30 VA: 0x1816DD630 Slot: 12
	public virtual CompareInfo get_CompareInfo() { }

	// RVA: 0x16DDBC0 Offset: 0x16DC1C0 VA: 0x1816DDBC0 Slot: 13
	public virtual bool get_IsNeutralCulture() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void CheckNeutral() { }

	// RVA: 0x16DDC00 Offset: 0x16DC200 VA: 0x1816DDC00 Slot: 14
	public virtual NumberFormatInfo get_NumberFormat() { }

	// RVA: 0x16DE3C0 Offset: 0x16DC9C0 VA: 0x1816DE3C0 Slot: 15
	public virtual void set_NumberFormat(NumberFormatInfo value) { }

	// RVA: 0x16DD800 Offset: 0x16DBE00 VA: 0x1816DD800 Slot: 16
	public virtual DateTimeFormatInfo get_DateTimeFormat() { }

	// RVA: 0x16DE2E0 Offset: 0x16DC8E0 VA: 0x1816DE2E0 Slot: 17
	public virtual void set_DateTimeFormat(DateTimeFormatInfo value) { }

	// RVA: 0x16DDA20 Offset: 0x16DC020 VA: 0x1816DDA20 Slot: 18
	public virtual string get_EnglishName() { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_IsReadOnly() { }

	// RVA: 0x16DC750 Offset: 0x16DAD50 VA: 0x1816DC750 Slot: 19
	public virtual object GetFormat(Type formatType) { }

	// RVA: 0x16D9CE0 Offset: 0x16D82E0 VA: 0x1816D9CE0
	private void Construct() { }

	// RVA: 0x16DD4D0 Offset: 0x16DBAD0 VA: 0x1816DD4D0
	private bool construct_internal_locale_from_lcid(int lcid) { }

	// RVA: 0x16DD4E0 Offset: 0x16DBAE0 VA: 0x1816DD4E0
	private bool construct_internal_locale_from_name(string name) { }

	// RVA: 0x16DE140 Offset: 0x16DC740 VA: 0x1816DE140
	private static string get_current_locale_name() { }

	// RVA: 0x16DE2D0 Offset: 0x16DC8D0 VA: 0x1816DE2D0
	private static CultureInfo[] internal_get_cultures(bool neutral, bool specific, bool installed) { }

	// RVA: 0x16D9B60 Offset: 0x16D8160 VA: 0x1816D9B60
	private void ConstructInvariant(bool read_only) { }

	// RVA: 0x16DBE00 Offset: 0x16DA400 VA: 0x1816DBE00
	private TextInfo CreateTextInfo(bool readOnly) { }

	// RVA: 0x16DCEF0 Offset: 0x16DB4F0 VA: 0x1816DCEF0
	public void .ctor(int culture) { }

	// RVA: 0x16DCED0 Offset: 0x16DB4D0 VA: 0x1816DCED0
	public void .ctor(int culture, bool useUserOverride) { }

	// RVA: 0x16DCF10 Offset: 0x16DB510 VA: 0x1816DCF10
	private void .ctor(int culture, bool useUserOverride, bool read_only) { }

	// RVA: 0x16DD220 Offset: 0x16DB820 VA: 0x1816DD220
	public void .ctor(string name) { }

	// RVA: 0x16DD1E0 Offset: 0x16DB7E0 VA: 0x1816DD1E0
	public void .ctor(string name, bool useUserOverride) { }

	// RVA: 0x16DD240 Offset: 0x16DB840 VA: 0x1816DD240
	private void .ctor(string name, bool useUserOverride, bool read_only) { }

	// RVA: 0x16DD200 Offset: 0x16DB800 VA: 0x1816DD200
	private void .ctor() { }

	// RVA: 0x16DE150 Offset: 0x16DC750 VA: 0x1816DE150
	private static void insert_into_shared_tables(CultureInfo c) { }

	// RVA: 0x16DBF20 Offset: 0x16DA520 VA: 0x1816DBF20
	public static CultureInfo GetCultureInfo(int culture) { }

	// RVA: 0x16DC160 Offset: 0x16DA760 VA: 0x1816DC160
	public static CultureInfo GetCultureInfo(string name) { }

	// RVA: 0x16D9EC0 Offset: 0x16D84C0 VA: 0x1816D9EC0
	internal static CultureInfo CreateCulture(string name, bool reference) { }

	// RVA: 0x16DBAD0 Offset: 0x16DA0D0 VA: 0x1816DBAD0
	public static CultureInfo CreateSpecificCulture(string name) { }

	// RVA: 0x16D9FD0 Offset: 0x16D85D0 VA: 0x1816D9FD0
	private static CultureInfo CreateSpecificCultureFromNeutral(string name) { }

	// RVA: 0x16DD4F0 Offset: 0x16DBAF0 VA: 0x1816DD4F0
	internal int get_CalendarType() { }

	// RVA: 0x16D9D00 Offset: 0x16D8300 VA: 0x1816D9D00
	private static Calendar CreateCalendar(int calendarType) { }

	// RVA: 0x16D9F50 Offset: 0x16D8550 VA: 0x1816D9F50
	private static Exception CreateNotFoundException(string name) { }

	// RVA: 0x16DD940 Offset: 0x16DBF40 VA: 0x1816DD940
	public static CultureInfo get_DefaultThreadCurrentCulture() { }

	// RVA: 0x16DD9B0 Offset: 0x16DBFB0 VA: 0x1816DD9B0
	public static CultureInfo get_DefaultThreadCurrentUICulture() { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	internal string get_SortName() { }

	// RVA: 0x16DE0B0 Offset: 0x16DC6B0 VA: 0x1816DE0B0
	internal static CultureInfo get_UserDefaultUICulture() { }

	// RVA: 0x16DE060 Offset: 0x16DC660 VA: 0x1816DE060
	internal static CultureInfo get_UserDefaultCulture() { }

	// RVA: 0x16D9550 Offset: 0x16D7B50 VA: 0x1816D9550
	internal static void CheckDomainSafetyObject(object obj, object container) { }

	// RVA: 0x16DDA60 Offset: 0x16DC060 VA: 0x1816DDA60
	internal bool get_HasInvariantCultureName() { }

	// RVA: 0x16DC890 Offset: 0x16DAE90 VA: 0x1816DC890
	internal static bool VerifyCultureName(string cultureName, bool throwException) { }

	// RVA: 0x16DC9C0 Offset: 0x16DAFC0 VA: 0x1816DC9C0
	internal static bool VerifyCultureName(CultureInfo culture, bool throwException) { }

	// RVA: 0x16DCB70 Offset: 0x16DB170 VA: 0x1816DCB70
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

