public abstract class TimeZone // TypeDefIndex: 401
{	// Fields
	private static TimeZone currentTimeZone; // 0x0
	private static object tz_lock; // 0x8
	private static long timezone_check; // 0x10

	// Properties
	public static TimeZone CurrentTimeZone { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x161A3C0 Offset: 0x16189C0 VA: 0x18161A3C0
	public static TimeZone get_CurrentTimeZone() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract TimeSpan GetUtcOffset(DateTime time);

	// RVA: 0x161A360 Offset: 0x1618960 VA: 0x18161A360
	private static void .cctor() { }

}

