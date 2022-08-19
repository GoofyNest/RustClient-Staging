internal class Lease : MarshalByRefObject, ILease // TypeDefIndex: 1165
{	// Fields
	private DateTime _leaseExpireTime; // 0x18
	private LeaseState _currentState; // 0x20
	private TimeSpan _initialLeaseTime; // 0x28
	private TimeSpan _renewOnCallTime; // 0x30
	private TimeSpan _sponsorshipTimeout; // 0x38
	private ArrayList _sponsors; // 0x40
	private Queue _renewingSponsors; // 0x48
	private Lease.RenewalDelegate _renewalDelegate; // 0x50

	// Properties
	public TimeSpan CurrentLeaseTime { get; }
	public LeaseState CurrentState { get; }
	public TimeSpan RenewOnCallTime { get; }

	// Methods

	// RVA: 0x147A080 Offset: 0x1478680 VA: 0x18147A080
	public void .ctor() { }

	// RVA: 0x147A220 Offset: 0x1478820 VA: 0x18147A220 Slot: 6
	public TimeSpan get_CurrentLeaseTime() { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0 Slot: 7
	public LeaseState get_CurrentState() { }

	// RVA: 0x1479550 Offset: 0x1477B50 VA: 0x181479550
	public void Activate() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050 Slot: 8
	public TimeSpan get_RenewOnCallTime() { }

	// RVA: 0x1479C80 Offset: 0x1478280 VA: 0x181479C80 Slot: 9
	public TimeSpan Renew(TimeSpan renewalTime) { }

	// RVA: 0x1479D60 Offset: 0x1478360 VA: 0x181479D60 Slot: 10
	public void Unregister(ISponsor obj) { }

	// RVA: 0x1479EB0 Offset: 0x14784B0 VA: 0x181479EB0
	internal void UpdateState() { }

	// RVA: 0x1479560 Offset: 0x1477B60 VA: 0x181479560
	private void CheckNextSponsor() { }

	// RVA: 0x14797E0 Offset: 0x1477DE0 VA: 0x1814797E0
	private void ProcessSponsorResponse(object state, bool timedOut) { }

}

private sealed class Lease.RenewalDelegate : MulticastDelegate // TypeDefIndex: 1166
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x148C340 Offset: 0x148A940 VA: 0x18148C340 Slot: 12
	public virtual TimeSpan Invoke(ILease lease) { }

	// RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380 Slot: 13
	public virtual IAsyncResult BeginInvoke(ILease lease, AsyncCallback callback, object object) { }

	// RVA: 0x12213D0 Offset: 0x121F9D0 VA: 0x1812213D0 Slot: 14
	public virtual TimeSpan EndInvoke(IAsyncResult result) { }

}
