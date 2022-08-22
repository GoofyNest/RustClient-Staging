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

	// RVA: 0x13852A0 Offset: 0x13838A0 VA: 0x1813852A0
	public void .ctor() { }

	[OnSerializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1384900 Offset: 0x1382F00 VA: 0x181384900
	private void OnSerializing(StreamingContext ctx) { }

	[OnDeserializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void OnDeserialized(StreamingContext ctx) { }

	// RVA: 0x1384BE0 Offset: 0x13831E0 VA: 0x181384BE0
	internal void .ctor(CultureData cultureData) { }

	// RVA: 0x1385430 Offset: 0x1383A30 VA: 0x181385430
	public static NumberFormatInfo get_InvariantInfo() { }

	// RVA: 0x1384680 Offset: 0x1382C80 VA: 0x181384680
	public static NumberFormatInfo GetInstance(IFormatProvider formatProvider) { }

	// RVA: 0x1384580 Offset: 0x1382B80 VA: 0x181384580 Slot: 4
	public object Clone() { }

	// RVA: 0x2FA5B0 Offset: 0x2F8BB0 VA: 0x1802FA5B0
	public int get_CurrencyDecimalDigits() { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public string get_CurrencyDecimalSeparator() { }

	// RVA: 0xDB3C70 Offset: 0xDB2270 VA: 0x180DB3C70
	public bool get_IsReadOnly() { }

	// RVA: 0x13852B0 Offset: 0x13838B0 VA: 0x1813852B0
	public int[] get_CurrencyGroupSizes() { }

	// RVA: 0x1385540 Offset: 0x1383B40 VA: 0x181385540
	public int[] get_NumberGroupSizes() { }

	// RVA: 0x13855C0 Offset: 0x1383BC0 VA: 0x1813855C0
	public int[] get_PercentGroupSizes() { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public string get_CurrencyGroupSeparator() { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public string get_CurrencySymbol() { }

	// RVA: 0x1385330 Offset: 0x1383930 VA: 0x181385330
	public static NumberFormatInfo get_CurrentInfo() { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	public string get_NaNSymbol() { }

	// RVA: 0x1079E60 Offset: 0x1078460 VA: 0x181079E60
	public int get_CurrencyNegativePattern() { }

	// RVA: 0x1079E50 Offset: 0x1078450 VA: 0x181079E50
	public int get_NumberNegativePattern() { }

	// RVA: 0x1079E40 Offset: 0x1078440 VA: 0x181079E40
	public int get_PercentPositivePattern() { }

	// RVA: 0xAE2A20 Offset: 0xAE1020 VA: 0x180AE2A20
	public int get_PercentNegativePattern() { }

	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520
	public string get_NegativeInfinitySymbol() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_NegativeSign() { }

	// RVA: 0xA4D020 Offset: 0xA4B620 VA: 0x180A4D020
	public int get_NumberDecimalDigits() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public string get_NumberDecimalSeparator() { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public string get_NumberGroupSeparator() { }

	// RVA: 0x1079E30 Offset: 0x1078430 VA: 0x181079E30
	public int get_CurrencyPositivePattern() { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	public string get_PositiveInfinitySymbol() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public string get_PositiveSign() { }

	// RVA: 0xAE2A40 Offset: 0xAE1040 VA: 0x180AE2A40
	public int get_PercentDecimalDigits() { }

	// RVA: 0x5743E0 Offset: 0x5729E0 VA: 0x1805743E0
	public string get_PercentDecimalSeparator() { }

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	public string get_PercentGroupSeparator() { }

	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050
	public string get_PercentSymbol() { }

	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380
	public string get_PerMilleSymbol() { }

	// RVA: 0x13845F0 Offset: 0x1382BF0 VA: 0x1813845F0 Slot: 5
	public object GetFormat(Type formatType) { }

	// RVA: 0x1384990 Offset: 0x1382F90 VA: 0x181384990
	public static NumberFormatInfo ReadOnly(NumberFormatInfo nfi) { }

	// RVA: 0x1384B10 Offset: 0x1383110 VA: 0x181384B10
	internal static void ValidateParseStyleInteger(NumberStyles style) { }

	// RVA: 0x1384A40 Offset: 0x1383040 VA: 0x181384A40
	internal static void ValidateParseStyleFloatingPoint(NumberStyles style) { }

}

