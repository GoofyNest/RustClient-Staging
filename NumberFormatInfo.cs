public sealed class NumberFormatInfo : ICloneable, IFormatProvider // TypeDefIndex: 713
{	// Fields
	private static NumberFormatInfo invariantInfo; // 0x0
	internal int[] numberGroupSizes; // 0x10
	internal int[] currencyGroupSizes; // 0x18
	internal int[] percentGroupSizes; // 0x20
	internal string positiveSign; // 0x28
	internal string negativeSign; // 0x30
	internal string numberDecimalSeparator; // 0x38
	internal string numberGroupSeparator; // 0x40
	internal string currencyGroupSeparator; // 0x48
	internal string currencyDecimalSeparator; // 0x50
	internal string currencySymbol; // 0x58
	internal string ansiCurrencySymbol; // 0x60
	internal string nanSymbol; // 0x68
	internal string positiveInfinitySymbol; // 0x70
	internal string negativeInfinitySymbol; // 0x78
	internal string percentDecimalSeparator; // 0x80
	internal string percentGroupSeparator; // 0x88
	internal string percentSymbol; // 0x90
	internal string perMilleSymbol; // 0x98
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	internal string[] nativeDigits; // 0xA0
	[OptionalFieldAttribute] // RVA: 0x96550 Offset: 0x95950 VA: 0x180096550
	internal int m_dataItem; // 0xA8
	internal int numberDecimalDigits; // 0xAC
	internal int currencyDecimalDigits; // 0xB0
	internal int currencyPositivePattern; // 0xB4
	internal int currencyNegativePattern; // 0xB8
	internal int numberNegativePattern; // 0xBC
	internal int percentPositivePattern; // 0xC0
	internal int percentNegativePattern; // 0xC4
	internal int percentDecimalDigits; // 0xC8
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	internal int digitSubstitution; // 0xCC
	internal bool isReadOnly; // 0xD0
	[OptionalFieldAttribute] // RVA: 0x96550 Offset: 0x95950 VA: 0x180096550
	internal bool m_useUserOverride; // 0xD1
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	internal bool m_isInvariant; // 0xD2
	[OptionalFieldAttribute] // RVA: 0x96550 Offset: 0x95950 VA: 0x180096550
	internal bool validForParseAsNumber; // 0xD3
	[OptionalFieldAttribute] // RVA: 0x96550 Offset: 0x95950 VA: 0x180096550
	internal bool validForParseAsCurrency; // 0xD4
	private const NumberStyles InvalidNumberStyles = -1024;

	// Properties
	public static NumberFormatInfo InvariantInfo { get; }
	public int CurrencyDecimalDigits { get; }
	public string CurrencyDecimalSeparator { get; }
	public bool IsReadOnly { get; }
	public int[] CurrencyGroupSizes { get; }
	public int[] NumberGroupSizes { get; }
	public int[] PercentGroupSizes { get; }
	public string CurrencyGroupSeparator { get; }
	public string CurrencySymbol { get; }
	public static NumberFormatInfo CurrentInfo { get; }
	public string NaNSymbol { get; }
	public int CurrencyNegativePattern { get; }
	public int NumberNegativePattern { get; }
	public int PercentPositivePattern { get; }
	public int PercentNegativePattern { get; }
	public string NegativeInfinitySymbol { get; }
	public string NegativeSign { get; }
	public int NumberDecimalDigits { get; }
	public string NumberDecimalSeparator { get; }
	public string NumberGroupSeparator { get; }
	public int CurrencyPositivePattern { get; }
	public string PositiveInfinitySymbol { get; }
	public string PositiveSign { get; }
	public int PercentDecimalDigits { get; }
	public string PercentDecimalSeparator { get; }
	public string PercentGroupSeparator { get; }
	public string PercentSymbol { get; }
	public string PerMilleSymbol { get; }

	// Methods

	// RVA: 0x1385560 Offset: 0x1383B60 VA: 0x181385560
	public void .ctor() { }

	[OnSerializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1384BC0 Offset: 0x13831C0 VA: 0x181384BC0
	private void OnSerializing(StreamingContext ctx) { }

	[OnDeserializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void OnDeserialized(StreamingContext ctx) { }

	// RVA: 0x1384EA0 Offset: 0x13834A0 VA: 0x181384EA0
	internal void .ctor(CultureData cultureData) { }

	// RVA: 0x13856F0 Offset: 0x1383CF0 VA: 0x1813856F0
	public static NumberFormatInfo get_InvariantInfo() { }

	// RVA: 0x1384940 Offset: 0x1382F40 VA: 0x181384940
	public static NumberFormatInfo GetInstance(IFormatProvider formatProvider) { }

	// RVA: 0x1384840 Offset: 0x1382E40 VA: 0x181384840 Slot: 4
	public object Clone() { }

	// RVA: 0x2FA5B0 Offset: 0x2F8BB0 VA: 0x1802FA5B0
	public int get_CurrencyDecimalDigits() { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public string get_CurrencyDecimalSeparator() { }

	// RVA: 0xDB3F30 Offset: 0xDB2530 VA: 0x180DB3F30
	public bool get_IsReadOnly() { }

	// RVA: 0x1385570 Offset: 0x1383B70 VA: 0x181385570
	public int[] get_CurrencyGroupSizes() { }

	// RVA: 0x1385800 Offset: 0x1383E00 VA: 0x181385800
	public int[] get_NumberGroupSizes() { }

	// RVA: 0x1385880 Offset: 0x1383E80 VA: 0x181385880
	public int[] get_PercentGroupSizes() { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public string get_CurrencyGroupSeparator() { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public string get_CurrencySymbol() { }

	// RVA: 0x13855F0 Offset: 0x1383BF0 VA: 0x1813855F0
	public static NumberFormatInfo get_CurrentInfo() { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	public string get_NaNSymbol() { }

	// RVA: 0x107A120 Offset: 0x1078720 VA: 0x18107A120
	public int get_CurrencyNegativePattern() { }

	// RVA: 0x107A110 Offset: 0x1078710 VA: 0x18107A110
	public int get_NumberNegativePattern() { }

	// RVA: 0x107A100 Offset: 0x1078700 VA: 0x18107A100
	public int get_PercentPositivePattern() { }

	// RVA: 0xAE2CE0 Offset: 0xAE12E0 VA: 0x180AE2CE0
	public int get_PercentNegativePattern() { }

	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520
	public string get_NegativeInfinitySymbol() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_NegativeSign() { }

	// RVA: 0xA4D2E0 Offset: 0xA4B8E0 VA: 0x180A4D2E0
	public int get_NumberDecimalDigits() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public string get_NumberDecimalSeparator() { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public string get_NumberGroupSeparator() { }

	// RVA: 0x107A0F0 Offset: 0x10786F0 VA: 0x18107A0F0
	public int get_CurrencyPositivePattern() { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	public string get_PositiveInfinitySymbol() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public string get_PositiveSign() { }

	// RVA: 0xAE2D00 Offset: 0xAE1300 VA: 0x180AE2D00
	public int get_PercentDecimalDigits() { }

	// RVA: 0x5743E0 Offset: 0x5729E0 VA: 0x1805743E0
	public string get_PercentDecimalSeparator() { }

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	public string get_PercentGroupSeparator() { }

	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050
	public string get_PercentSymbol() { }

	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380
	public string get_PerMilleSymbol() { }

	// RVA: 0x13848B0 Offset: 0x1382EB0 VA: 0x1813848B0 Slot: 5
	public object GetFormat(Type formatType) { }

	// RVA: 0x1384C50 Offset: 0x1383250 VA: 0x181384C50
	public static NumberFormatInfo ReadOnly(NumberFormatInfo nfi) { }

	// RVA: 0x1384DD0 Offset: 0x13833D0 VA: 0x181384DD0
	internal static void ValidateParseStyleInteger(NumberStyles style) { }

	// RVA: 0x1384D00 Offset: 0x1383300 VA: 0x181384D00
	internal static void ValidateParseStyleFloatingPoint(NumberStyles style) { }

}

