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

	// RVA: 0x147A5C0 Offset: 0x1478BC0 VA: 0x18147A5C0
	private static void .cctor() { }

	// RVA: 0x147A710 Offset: 0x1478D10 VA: 0x18147A710
	public static TimeSpan get_LeaseManagerPollTime() { }

	// RVA: 0x147A890 Offset: 0x1478E90 VA: 0x18147A890
	public static void set_LeaseManagerPollTime(TimeSpan value) { }

	// RVA: 0x147A770 Offset: 0x1478D70 VA: 0x18147A770
	public static TimeSpan get_LeaseTime() { }

	// RVA: 0x147A920 Offset: 0x1478F20 VA: 0x18147A920
	public static void set_LeaseTime(TimeSpan value) { }

	// RVA: 0x147A7D0 Offset: 0x1478DD0 VA: 0x18147A7D0
	public static TimeSpan get_RenewOnCallTime() { }

	// RVA: 0x147A980 Offset: 0x1478F80 VA: 0x18147A980
	public static void set_RenewOnCallTime(TimeSpan value) { }

	// RVA: 0x147A830 Offset: 0x1478E30 VA: 0x18147A830
	public static TimeSpan get_SponsorshipTimeout() { }

	// RVA: 0x147A9E0 Offset: 0x1478FE0 VA: 0x18147A9E0
	public static void set_SponsorshipTimeout(TimeSpan value) { }

	// RVA: 0x147A540 Offset: 0x1478B40 VA: 0x18147A540
	internal static void TrackLifetime(ServerIdentity identity) { }

}

