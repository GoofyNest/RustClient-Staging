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

	// RVA: 0x1385D90 Offset: 0x1384390 VA: 0x181385D90
	public static RegionInfo get_CurrentRegion() { }

	// RVA: 0x1385C20 Offset: 0x1384220 VA: 0x181385C20
	public void .ctor(int culture) { }

	// RVA: 0x1385A80 Offset: 0x1384080 VA: 0x181385A80
	public void .ctor(string name) { }

	// RVA: 0x1385910 Offset: 0x1383F10 VA: 0x181385910
	private void .ctor(CultureInfo ci) { }

	// RVA: 0x1385800 Offset: 0x1383E00 VA: 0x181385800
	private bool GetByTerritory(CultureInfo ci) { }

	// RVA: 0x1385D80 Offset: 0x1384380 VA: 0x181385D80
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

	// RVA: 0x1385F90 Offset: 0x1384590 VA: 0x181385F90 Slot: 9
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

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330 Slot: 15
	public virtual string get_ThreeLetterWindowsRegionName() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 16
	public virtual string get_TwoLetterISORegionName() { }

	// RVA: 0x1385730 Offset: 0x1383D30 VA: 0x181385730 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x13858B0 Offset: 0x1383EB0 VA: 0x1813858B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13858F0 Offset: 0x1383EF0 VA: 0x1813858F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x13856F0 Offset: 0x1383CF0 VA: 0x1813856F0
	internal static void ClearCachedData() { }

}

