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

	// RVA: 0x1385150 Offset: 0x1383750 VA: 0x181385150
	public static RegionInfo get_CurrentRegion() { }

	// RVA: 0x1384FE0 Offset: 0x13835E0 VA: 0x181384FE0
	public void .ctor(int culture) { }

	// RVA: 0x1384E40 Offset: 0x1383440 VA: 0x181384E40
	public void .ctor(string name) { }

	// RVA: 0x1384CD0 Offset: 0x13832D0 VA: 0x181384CD0
	private void .ctor(CultureInfo ci) { }

	// RVA: 0x1384BC0 Offset: 0x13831C0 VA: 0x181384BC0
	private bool GetByTerritory(CultureInfo ci) { }

	// RVA: 0x1385140 Offset: 0x1383740 VA: 0x181385140
	private bool construct_internal_region_from_name(string name) { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800 Slot: 4
	public virtual string get_CurrencyEnglishName() { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540 Slot: 5
	public virtual string get_CurrencySymbol() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0 Slot: 6
	public virtual string get_DisplayName() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0 Slot: 7
	public virtual string get_EnglishName() { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00 Slot: 8
	public virtual int get_GeoId() { }

	// RVA: 0x1385350 Offset: 0x1383950 VA: 0x181385350 Slot: 9
	public virtual bool get_IsMetric() { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0 Slot: 10
	public virtual string get_ISOCurrencySymbol() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340 Slot: 11
	public virtual string get_NativeName() { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0 Slot: 12
	public virtual string get_CurrencyNativeName() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 13
	public virtual string get_Name() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 14
	public virtual string get_ThreeLetterISORegionName() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0 Slot: 15
	public virtual string get_ThreeLetterWindowsRegionName() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 16
	public virtual string get_TwoLetterISORegionName() { }

	// RVA: 0x1384AF0 Offset: 0x13830F0 VA: 0x181384AF0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1384C70 Offset: 0x1383270 VA: 0x181384C70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1384CB0 Offset: 0x13832B0 VA: 0x181384CB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1384AB0 Offset: 0x13830B0 VA: 0x181384AB0
	internal static void ClearCachedData() { }

}

