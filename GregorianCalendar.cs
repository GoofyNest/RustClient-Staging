public class GregorianCalendar : Calendar // TypeDefIndex: 702
{	// Fields
	internal GregorianCalendarTypes m_type; // 0x20
	internal static readonly int[] DaysToMonth365; // 0x0
	internal static readonly int[] DaysToMonth366; // 0x8
	private static Calendar s_defaultInstance; // 0x10

	// Properties
	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	public override DateTime MinSupportedDateTime { get; }
	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	public override DateTime MaxSupportedDateTime { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; }

	// Methods

	[OnDeserializedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x16F3ED0 Offset: 0x16F24D0 VA: 0x1816F3ED0
	private void OnDeserialized(StreamingContext ctx) { }

	// RVA: 0x16F45B0 Offset: 0x16F2BB0 VA: 0x1816F45B0 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x16F4550 Offset: 0x16F2B50 VA: 0x1816F4550 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x16F3A50 Offset: 0x16F2050 VA: 0x1816F3A50
	internal static Calendar GetDefaultInstance() { }

	// RVA: 0x16F44E0 Offset: 0x16F2AE0 VA: 0x1816F44E0
	public void .ctor() { }

	// RVA: 0x16F43B0 Offset: 0x16F29B0 VA: 0x1816F43B0
	public void .ctor(GregorianCalendarTypes type) { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x16F3500 Offset: 0x16F1B00 VA: 0x1816F3500 Slot: 28
	internal virtual int GetDatePart(long ticks, int part) { }

	// RVA: 0x16F36F0 Offset: 0x16F1CF0 VA: 0x1816F36F0 Slot: 11
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x16F3730 Offset: 0x16F1D30 VA: 0x1816F3730 Slot: 12
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x16F3780 Offset: 0x16F1D80 VA: 0x1816F3780 Slot: 13
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 14
	public override int GetEra(DateTime time) { }

	// RVA: 0x16F44F0 Offset: 0x16F2AF0 VA: 0x1816F44F0 Slot: 15
	public override int[] get_Eras() { }

	// RVA: 0x16F3B50 Offset: 0x16F2150 VA: 0x1816F3B50 Slot: 16
	public override int GetMonth(DateTime time) { }

	// RVA: 0x16F3B90 Offset: 0x16F2190 VA: 0x1816F3B90 Slot: 17
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x16F3CF0 Offset: 0x16F22F0 VA: 0x1816F3CF0 Slot: 18
	public override int GetYear(DateTime time) { }

	// RVA: 0x16F3D30 Offset: 0x16F2330 VA: 0x1816F3D30 Slot: 20
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x16F3FA0 Offset: 0x16F25A0 VA: 0x1816F3FA0 Slot: 21
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x16F41F0 Offset: 0x16F27F0 VA: 0x1816F41F0 Slot: 22
	internal override bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result) { }

	// RVA: 0x16F4610 Offset: 0x16F2C10 VA: 0x1816F4610 Slot: 26
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x16F4090 Offset: 0x16F2690 VA: 0x1816F4090 Slot: 27
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x16F4300 Offset: 0x16F2900 VA: 0x1816F4300
	private static void .cctor() { }

}

