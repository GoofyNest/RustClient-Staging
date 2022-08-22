internal class CurrentSystemTimeZone : TimeZone // TypeDefIndex: 402
{	// Fields
	private readonly TimeZoneInfo LocalTimeZone; // 0x10

	// Methods

	// RVA: 0x17924E0 Offset: 0x1790AE0 VA: 0x1817924E0
	internal void .ctor() { }

	// RVA: 0x1792430 Offset: 0x1790A30 VA: 0x181792430 Slot: 4
	public override TimeSpan GetUtcOffset(DateTime dateTime) { }

	// RVA: 0x1792420 Offset: 0x1790A20 VA: 0x181792420
	public static bool GetTimeZoneData(int year, out long[] data, out string[] names, out bool daylight_inverted) { }

}

