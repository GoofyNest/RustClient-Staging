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

	// RVA: 0x1384660 Offset: 0x1382C60 VA: 0x181384660
	public void .ctor() { }

	[OnSerializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1383CC0 Offset: 0x13822C0 VA: 0x181383CC0
	private void OnSerializing(StreamingContext ctx) { }

	[OnDeserializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void OnDeserialized(StreamingContext ctx) { }

	// RVA: 0x1383FA0 Offset: 0x13825A0 VA: 0x181383FA0
	internal void .ctor(CultureData cultureData) { }

	// RVA: 0x13847F0 Offset: 0x1382DF0 VA: 0x1813847F0
	public static NumberFormatInfo get_InvariantInfo() { }

	// RVA: 0x1383A40 Offset: 0x1382040 VA: 0x181383A40
	public static NumberFormatInfo GetInstance(IFormatProvider formatProvider) { }

	// RVA: 0x1383940 Offset: 0x1381F40 VA: 0x181383940 Slot: 4
	public object Clone() { }

	// RVA: 0x2FA5B0 Offset: 0x2F8BB0 VA: 0x1802FA5B0
	public int get_CurrencyDecimalDigits() { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public string get_CurrencyDecimalSeparator() { }

	// RVA: 0xDB49E0 Offset: 0xDB2FE0 VA: 0x180DB49E0
	public bool get_IsReadOnly() { }

	// RVA: 0x1384670 Offset: 0x1382C70 VA: 0x181384670
	public int[] get_CurrencyGroupSizes() { }

	// RVA: 0x1384900 Offset: 0x1382F00 VA: 0x181384900
	public int[] get_NumberGroupSizes() { }

	// RVA: 0x1384980 Offset: 0x1382F80 VA: 0x181384980
	public int[] get_PercentGroupSizes() { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	public string get_CurrencyGroupSeparator() { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	public string get_CurrencySymbol() { }

	// RVA: 0x13846F0 Offset: 0x1382CF0 VA: 0x1813846F0
	public static NumberFormatInfo get_CurrentInfo() { }

	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0
	public string get_NaNSymbol() { }

	// RVA: 0x107AB90 Offset: 0x1079190 VA: 0x18107AB90
	public int get_CurrencyNegativePattern() { }

	// RVA: 0x107AB80 Offset: 0x1079180 VA: 0x18107AB80
	public int get_NumberNegativePattern() { }

	// RVA: 0x107AB70 Offset: 0x1079170 VA: 0x18107AB70
	public int get_PercentPositivePattern() { }

	// RVA: 0xAE31B0 Offset: 0xAE17B0 VA: 0x180AE31B0
	public int get_PercentNegativePattern() { }

	// RVA: 0x4E84B0 Offset: 0x4E6AB0 VA: 0x1804E84B0
	public string get_NegativeInfinitySymbol() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public string get_NegativeSign() { }

	// RVA: 0xA4D7D0 Offset: 0xA4BDD0 VA: 0x180A4D7D0
	public int get_NumberDecimalDigits() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public string get_NumberDecimalSeparator() { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public string get_NumberGroupSeparator() { }

	// RVA: 0x107AB60 Offset: 0x1079160 VA: 0x18107AB60
	public int get_CurrencyPositivePattern() { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	public string get_PositiveInfinitySymbol() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public string get_PositiveSign() { }

	// RVA: 0xAE31D0 Offset: 0xAE17D0 VA: 0x180AE31D0
	public int get_PercentDecimalDigits() { }

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	public string get_PercentDecimalSeparator() { }

	// RVA: 0x574300 Offset: 0x572900 VA: 0x180574300
	public string get_PercentGroupSeparator() { }

	// RVA: 0x4E3FE0 Offset: 0x4E25E0 VA: 0x1804E3FE0
	public string get_PercentSymbol() { }

	// RVA: 0x574310 Offset: 0x572910 VA: 0x180574310
	public string get_PerMilleSymbol() { }

	// RVA: 0x13839B0 Offset: 0x1381FB0 VA: 0x1813839B0 Slot: 5
	public object GetFormat(Type formatType) { }

	// RVA: 0x1383D50 Offset: 0x1382350 VA: 0x181383D50
	public static NumberFormatInfo ReadOnly(NumberFormatInfo nfi) { }

	// RVA: 0x1383ED0 Offset: 0x13824D0 VA: 0x181383ED0
	internal static void ValidateParseStyleInteger(NumberStyles style) { }

	// RVA: 0x1383E00 Offset: 0x1382400 VA: 0x181383E00
	internal static void ValidateParseStyleFloatingPoint(NumberStyles style) { }

}

