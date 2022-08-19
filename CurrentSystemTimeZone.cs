internal class CurrentSystemTimeZone : TimeZone // TypeDefIndex: 402
{	// Fields
	private readonly TimeZoneInfo LocalTimeZone; // 0x10

	// Methods

	// RVA: 0x1792220 Offset: 0x1790820 VA: 0x181792220
	internal void .ctor() { }

	// RVA: 0x1792170 Offset: 0x1790770 VA: 0x181792170 Slot: 4
	public override TimeSpan GetUtcOffset(DateTime dateTime) { }

	// RVA: 0x1792160 Offset: 0x1790760 VA: 0x181792160
	public static bool GetTimeZoneData(int year, out long[] data, out string[] names, out bool daylight_inverted) { }

}

