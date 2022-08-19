public sealed class LifetimeServices // TypeDefIndex: 1170
{	// Fields
	private static TimeSpan _leaseManagerPollTime; // 0x0
	private static TimeSpan _leaseTime; // 0x8
	private static TimeSpan _renewOnCallTime; // 0x10
	private static TimeSpan _sponsorshipTimeout; // 0x18
	private static LeaseManager _leaseManager; // 0x20

	// Properties
	public static TimeSpan LeaseManagerPollTime { get; set; }
	public static TimeSpan LeaseTime { get; set; }
	public static TimeSpan RenewOnCallTime { get; set; }
	public static TimeSpan SponsorshipTimeout { get; set; }

	// Methods

	// RVA: 0x147A300 Offset: 0x1478900 VA: 0x18147A300
	private static void .cctor() { }

	// RVA: 0x147A450 Offset: 0x1478A50 VA: 0x18147A450
	public static TimeSpan get_LeaseManagerPollTime() { }

	// RVA: 0x147A5D0 Offset: 0x1478BD0 VA: 0x18147A5D0
	public static void set_LeaseManagerPollTime(TimeSpan value) { }

	// RVA: 0x147A4B0 Offset: 0x1478AB0 VA: 0x18147A4B0
	public static TimeSpan get_LeaseTime() { }

	// RVA: 0x147A660 Offset: 0x1478C60 VA: 0x18147A660
	public static void set_LeaseTime(TimeSpan value) { }

	// RVA: 0x147A510 Offset: 0x1478B10 VA: 0x18147A510
	public static TimeSpan get_RenewOnCallTime() { }

	// RVA: 0x147A6C0 Offset: 0x1478CC0 VA: 0x18147A6C0
	public static void set_RenewOnCallTime(TimeSpan value) { }

	// RVA: 0x147A570 Offset: 0x1478B70 VA: 0x18147A570
	public static TimeSpan get_SponsorshipTimeout() { }

	// RVA: 0x147A720 Offset: 0x1478D20 VA: 0x18147A720
	public static void set_SponsorshipTimeout(TimeSpan value) { }

	// RVA: 0x147A280 Offset: 0x1478880 VA: 0x18147A280
	internal static void TrackLifetime(ServerIdentity identity) { }

}

