public class GregorianCalendar : Calendar // TypeDefIndex: 702
{	// Fields
	internal GregorianCalendarTypes m_type; // 0x20
	internal static readonly int[] DaysToMonth365; // 0x0
	internal static readonly int[] DaysToMonth366; // 0x8
	private static Calendar s_defaultInstance; // 0x10

	// Properties
	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public override DateTime MinSupportedDateTime { get; }
	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public override DateTime MaxSupportedDateTime { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; }

	// Methods

	[OnDeserializedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x16F1D80 Offset: 0x16F0380 VA: 0x1816F1D80
	private void OnDeserialized(StreamingContext ctx) { }

	// RVA: 0x16F2460 Offset: 0x16F0A60 VA: 0x1816F2460 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x16F2400 Offset: 0x16F0A00 VA: 0x1816F2400 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x16F1900 Offset: 0x16EFF00 VA: 0x1816F1900
	internal static Calendar GetDefaultInstance() { }

	// RVA: 0x16F2390 Offset: 0x16F0990 VA: 0x1816F2390
	public void .ctor() { }

	// RVA: 0x16F2260 Offset: 0x16F0860 VA: 0x1816F2260
	public void .ctor(GregorianCalendarTypes type) { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x16F13B0 Offset: 0x16EF9B0 VA: 0x1816F13B0 Slot: 28
	internal virtual int GetDatePart(long ticks, int part) { }

	// RVA: 0x16F15A0 Offset: 0x16EFBA0 VA: 0x1816F15A0 Slot: 11
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x16F15E0 Offset: 0x16EFBE0 VA: 0x1816F15E0 Slot: 12
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x16F1630 Offset: 0x16EFC30 VA: 0x1816F1630 Slot: 13
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x5B1870 Offset: 0x5AFE70 VA: 0x1805B1870 Slot: 14
	public override int GetEra(DateTime time) { }

	// RVA: 0x16F23A0 Offset: 0x16F09A0 VA: 0x1816F23A0 Slot: 15
	public override int[] get_Eras() { }

	// RVA: 0x16F1A00 Offset: 0x16F0000 VA: 0x1816F1A00 Slot: 16
	public override int GetMonth(DateTime time) { }

	// RVA: 0x16F1A40 Offset: 0x16F0040 VA: 0x1816F1A40 Slot: 17
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x16F1BA0 Offset: 0x16F01A0 VA: 0x1816F1BA0 Slot: 18
	public override int GetYear(DateTime time) { }

	// RVA: 0x16F1BE0 Offset: 0x16F01E0 VA: 0x1816F1BE0 Slot: 20
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x16F1E50 Offset: 0x16F0450 VA: 0x1816F1E50 Slot: 21
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x16F20A0 Offset: 0x16F06A0 VA: 0x1816F20A0 Slot: 22
	internal override bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result) { }

	// RVA: 0x16F24C0 Offset: 0x16F0AC0 VA: 0x1816F24C0 Slot: 26
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x16F1F40 Offset: 0x16F0540 VA: 0x1816F1F40 Slot: 27
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x16F21B0 Offset: 0x16F07B0 VA: 0x1816F21B0
	private static void .cctor() { }

}

