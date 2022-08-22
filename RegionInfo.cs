public class RegionInfo // TypeDefIndex: 746
{	// Fields
	private static RegionInfo currentRegion; // 0x0
	private int regionId; // 0x10
	private string iso2Name; // 0x18
	private string iso3Name; // 0x20
	private string win3Name; // 0x28
	private string englishName; // 0x30
	private string nativeName; // 0x38
	private string currencySymbol; // 0x40
	private string isoCurrencySymbol; // 0x48
	private string currencyEnglishName; // 0x50
	private string currencyNativeName; // 0x58

	// Properties
	public static RegionInfo CurrentRegion { get; }
	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public virtual string CurrencyEnglishName { get; }
	public virtual string CurrencySymbol { get; }
	[MonoTODOAttribute] // RVA: 0xB0C00 Offset: 0xB0000 VA: 0x1800B0C00
	public virtual string DisplayName { get; }
	public virtual string EnglishName { get; }
	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public virtual int GeoId { get; }
	public virtual bool IsMetric { get; }
	public virtual string ISOCurrencySymbol { get; }
	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public virtual string NativeName { get; }
	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public virtual string CurrencyNativeName { get; }
	public virtual string Name { get; }
	public virtual string ThreeLetterISORegionName { get; }
	public virtual string ThreeLetterWindowsRegionName { get; }
	public virtual string TwoLetterISORegionName { get; }

	// Methods

	// RVA: 0x1386050 Offset: 0x1384650 VA: 0x181386050
	public static RegionInfo get_CurrentRegion() { }

	// RVA: 0x1385EE0 Offset: 0x13844E0 VA: 0x181385EE0
	public void .ctor(int culture) { }

	// RVA: 0x1385D40 Offset: 0x1384340 VA: 0x181385D40
	public void .ctor(string name) { }

	// RVA: 0x1385BD0 Offset: 0x13841D0 VA: 0x181385BD0
	private void .ctor(CultureInfo ci) { }

	// RVA: 0x1385AC0 Offset: 0x13840C0 VA: 0x181385AC0
	private bool GetByTerritory(CultureInfo ci) { }

	// RVA: 0x1386040 Offset: 0x1384640 VA: 0x181386040
	private bool construct_internal_region_from_name(string name) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870 Slot: 4
	public virtual string get_CurrencyEnglishName() { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0 Slot: 5
	public virtual string get_CurrencySymbol() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050 Slot: 6
	public virtual string get_DisplayName() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050 Slot: 7
	public virtual string get_EnglishName() { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00 Slot: 8
	public virtual int get_GeoId() { }

	// RVA: 0x1386250 Offset: 0x1384850 VA: 0x181386250 Slot: 9
	public virtual bool get_IsMetric() { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450 Slot: 10
	public virtual string get_ISOCurrencySymbol() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0 Slot: 11
	public virtual string get_NativeName() { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860 Slot: 12
	public virtual string get_CurrencyNativeName() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 13
	public virtual string get_Name() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 14
	public virtual string get_ThreeLetterISORegionName() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440 Slot: 15
	public virtual string get_ThreeLetterWindowsRegionName() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 16
	public virtual string get_TwoLetterISORegionName() { }

	// RVA: 0x13859F0 Offset: 0x1383FF0 VA: 0x1813859F0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1385B70 Offset: 0x1384170 VA: 0x181385B70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1385BB0 Offset: 0x13841B0 VA: 0x181385BB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x13859B0 Offset: 0x1383FB0 VA: 0x1813859B0
	internal static void ClearCachedData() { }

}

