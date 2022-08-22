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

	// RVA: 0x1479690 Offset: 0x1477C90 VA: 0x181479690
	private static void .cctor() { }

	// RVA: 0x14797E0 Offset: 0x1477DE0 VA: 0x1814797E0
	public static TimeSpan get_LeaseManagerPollTime() { }

	// RVA: 0x1479960 Offset: 0x1477F60 VA: 0x181479960
	public static void set_LeaseManagerPollTime(TimeSpan value) { }

	// RVA: 0x1479840 Offset: 0x1477E40 VA: 0x181479840
	public static TimeSpan get_LeaseTime() { }

	// RVA: 0x14799F0 Offset: 0x1477FF0 VA: 0x1814799F0
	public static void set_LeaseTime(TimeSpan value) { }

	// RVA: 0x14798A0 Offset: 0x1477EA0 VA: 0x1814798A0
	public static TimeSpan get_RenewOnCallTime() { }

	// RVA: 0x1479A50 Offset: 0x1478050 VA: 0x181479A50
	public static void set_RenewOnCallTime(TimeSpan value) { }

	// RVA: 0x1479900 Offset: 0x1477F00 VA: 0x181479900
	public static TimeSpan get_SponsorshipTimeout() { }

	// RVA: 0x1479AB0 Offset: 0x14780B0 VA: 0x181479AB0
	public static void set_SponsorshipTimeout(TimeSpan value) { }

	// RVA: 0x1479610 Offset: 0x1477C10 VA: 0x181479610
	internal static void TrackLifetime(ServerIdentity identity) { }

}

