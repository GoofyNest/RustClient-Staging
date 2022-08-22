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
	// RVA: 0x16F4190 Offset: 0x16F2790 VA: 0x1816F4190
	private void OnDeserialized(StreamingContext ctx) { }

	// RVA: 0x16F4870 Offset: 0x16F2E70 VA: 0x1816F4870 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x16F4810 Offset: 0x16F2E10 VA: 0x1816F4810 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x16F3D10 Offset: 0x16F2310 VA: 0x1816F3D10
	internal static Calendar GetDefaultInstance() { }

	// RVA: 0x16F47A0 Offset: 0x16F2DA0 VA: 0x1816F47A0
	public void .ctor() { }

	// RVA: 0x16F4670 Offset: 0x16F2C70 VA: 0x1816F4670
	public void .ctor(GregorianCalendarTypes type) { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x16F37C0 Offset: 0x16F1DC0 VA: 0x1816F37C0 Slot: 28
	internal virtual int GetDatePart(long ticks, int part) { }

	// RVA: 0x16F39B0 Offset: 0x16F1FB0 VA: 0x1816F39B0 Slot: 11
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x16F39F0 Offset: 0x16F1FF0 VA: 0x1816F39F0 Slot: 12
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x16F3A40 Offset: 0x16F2040 VA: 0x1816F3A40 Slot: 13
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 14
	public override int GetEra(DateTime time) { }

	// RVA: 0x16F47B0 Offset: 0x16F2DB0 VA: 0x1816F47B0 Slot: 15
	public override int[] get_Eras() { }

	// RVA: 0x16F3E10 Offset: 0x16F2410 VA: 0x1816F3E10 Slot: 16
	public override int GetMonth(DateTime time) { }

	// RVA: 0x16F3E50 Offset: 0x16F2450 VA: 0x1816F3E50 Slot: 17
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x16F3FB0 Offset: 0x16F25B0 VA: 0x1816F3FB0 Slot: 18
	public override int GetYear(DateTime time) { }

	// RVA: 0x16F3FF0 Offset: 0x16F25F0 VA: 0x1816F3FF0 Slot: 20
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x16F4260 Offset: 0x16F2860 VA: 0x1816F4260 Slot: 21
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x16F44B0 Offset: 0x16F2AB0 VA: 0x1816F44B0 Slot: 22
	internal override bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result) { }

	// RVA: 0x16F48D0 Offset: 0x16F2ED0 VA: 0x1816F48D0 Slot: 26
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x16F4350 Offset: 0x16F2950 VA: 0x1816F4350 Slot: 27
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x16F45C0 Offset: 0x16F2BC0 VA: 0x1816F45C0
	private static void .cctor() { }

}

