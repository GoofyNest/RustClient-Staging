public abstract class Calendar : ICloneable // TypeDefIndex: 687
{	// Fields
	internal const long TicksPerMillisecond = 10000;
	internal const long TicksPerSecond = 10000000;
	internal const long TicksPerMinute = 600000000;
	internal const long TicksPerHour = 36000000000;
	internal const long TicksPerDay = 864000000000;
	internal const int MillisPerSecond = 1000;
	internal const int MillisPerMinute = 60000;
	internal const int MillisPerHour = 3600000;
	internal const int MillisPerDay = 86400000;
	internal const int DaysPerYear = 365;
	internal const int DaysPer4Years = 1461;
	internal const int DaysPer100Years = 36524;
	internal const int DaysPer400Years = 146097;
	internal const int DaysTo10000 = 3652059;
	internal const long MaxMillis = 315537897600000;
	internal const int CAL_GREGORIAN = 1;
	internal const int CAL_GREGORIAN_US = 2;
	internal const int CAL_JAPAN = 3;
	internal const int CAL_TAIWAN = 4;
	internal const int CAL_KOREA = 5;
	internal const int CAL_HIJRI = 6;
	internal const int CAL_THAI = 7;
	internal const int CAL_HEBREW = 8;
	internal const int CAL_GREGORIAN_ME_FRENCH = 9;
	internal const int CAL_GREGORIAN_ARABIC = 10;
	internal const int CAL_GREGORIAN_XLIT_ENGLISH = 11;
	internal const int CAL_GREGORIAN_XLIT_FRENCH = 12;
	internal const int CAL_JULIAN = 13;
	internal const int CAL_JAPANESELUNISOLAR = 14;
	internal const int CAL_CHINESELUNISOLAR = 15;
	internal const int CAL_SAKA = 16;
	internal const int CAL_LUNAR_ETO_CHN = 17;
	internal const int CAL_LUNAR_ETO_KOR = 18;
	internal const int CAL_LUNAR_ETO_ROKUYOU = 19;
	internal const int CAL_KOREANLUNISOLAR = 20;
	internal const int CAL_TAIWANLUNISOLAR = 21;
	internal const int CAL_PERSIAN = 22;
	internal const int CAL_UMALQURA = 23;
	internal int m_currentEraValue; // 0x10
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	private bool m_isReadOnly; // 0x14
	public const int CurrentEra = 0;
	internal int twoDigitYearMax; // 0x18

	// Properties
	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public virtual DateTime MinSupportedDateTime { get; }
	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public virtual DateTime MaxSupportedDateTime { get; }
	internal virtual int ID { get; }
	internal virtual int BaseCalendarID { get; }
	internal virtual int CurrentEraValue { get; }
	public abstract int[] Eras { get; }
	public virtual int TwoDigitYearMax { get; }

	// Methods

	// RVA: 0x10D3A30 Offset: 0x10D2030 VA: 0x1810D3A30 Slot: 5
	public virtual DateTime get_MinSupportedDateTime() { }

	// RVA: 0x10D39D0 Offset: 0x10D1FD0 VA: 0x1810D39D0 Slot: 6
	public virtual DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x10D37B0 Offset: 0x10D1DB0 VA: 0x1810D37B0
	protected void .ctor() { }

	// RVA: 0x6869A0 Offset: 0x684FA0 VA: 0x1806869A0 Slot: 7
	internal virtual int get_ID() { }

	// RVA: 0x82C300 Offset: 0x82A900 VA: 0x18082C300 Slot: 8
	internal virtual int get_BaseCalendarID() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x10D32D0 Offset: 0x10D18D0 VA: 0x1810D32D0 Slot: 9
	public virtual object Clone() { }

	// RVA: 0xA115D0 Offset: 0xA0FBD0 VA: 0x180A115D0
	internal void SetReadOnlyState(bool readOnly) { }

	// RVA: 0x10D37D0 Offset: 0x10D1DD0 VA: 0x1810D37D0 Slot: 10
	internal virtual int get_CurrentEraValue() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int GetDayOfMonth(DateTime time);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract DayOfWeek GetDayOfWeek(DateTime time);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract int GetDaysInMonth(int year, int month, int era);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int GetEra(DateTime time);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract int[] get_Eras();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract int GetMonth(DateTime time);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract int GetMonthsInYear(int year, int era);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract int GetYear(DateTime time);

	// RVA: 0x10D33F0 Offset: 0x10D19F0 VA: 0x1810D33F0 Slot: 19
	public virtual bool IsLeapYear(int year) { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract bool IsLeapYear(int year, int era);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era);

	// RVA: 0x10D36C0 Offset: 0x10D1CC0 VA: 0x1810D36C0 Slot: 22
	internal virtual bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result) { }

	// RVA: 0x10D3520 Offset: 0x10D1B20 VA: 0x1810D3520 Slot: 23
	internal virtual bool IsValidYear(int year, int era) { }

	// RVA: 0x10D34A0 Offset: 0x10D1AA0 VA: 0x1810D34A0 Slot: 24
	internal virtual bool IsValidMonth(int year, int month, int era) { }

	// RVA: 0x10D3410 Offset: 0x10D1A10 VA: 0x1810D3410 Slot: 25
	internal virtual bool IsValidDay(int year, int month, int day, int era) { }

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400 Slot: 26
	public virtual int get_TwoDigitYearMax() { }

	// RVA: 0x10D35B0 Offset: 0x10D1BB0 VA: 0x1810D35B0 Slot: 27
	public virtual int ToFourDigitYear(int year) { }

	// RVA: 0x10D33A0 Offset: 0x10D19A0 VA: 0x1810D33A0
	internal static int GetSystemTwoDigitYearSetting(int CalID, int defaultYearValue) { }

}

