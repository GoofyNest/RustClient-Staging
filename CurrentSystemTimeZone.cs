internal class CurrentSystemTimeZone : TimeZone // TypeDefIndex: 402
{	// Fields
	private readonly TimeZoneInfo LocalTimeZone; // 0x10

	// Methods

	// RVA: 0x17948F0 Offset: 0x1792EF0 VA: 0x1817948F0
	internal void .ctor() { }

	// RVA: 0x1794840 Offset: 0x1792E40 VA: 0x181794840 Slot: 4
	public override TimeSpan GetUtcOffset(DateTime dateTime) { }

	// RVA: 0x1794830 Offset: 0x1792E30 VA: 0x181794830
	public static bool GetTimeZoneData(int year, out long[] data, out string[] names, out bool daylight_inverted) { }

}

