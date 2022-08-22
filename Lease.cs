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

	// RVA: 0x1479410 Offset: 0x1477A10 VA: 0x181479410
	public void .ctor() { }

	// RVA: 0x14795B0 Offset: 0x1477BB0 VA: 0x1814795B0 Slot: 6
	public TimeSpan get_CurrentLeaseTime() { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760 Slot: 7
	public LeaseState get_CurrentState() { }

	// RVA: 0x14788E0 Offset: 0x1476EE0 VA: 0x1814788E0
	public void Activate() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0 Slot: 8
	public TimeSpan get_RenewOnCallTime() { }

	// RVA: 0x1479010 Offset: 0x1477610 VA: 0x181479010 Slot: 9
	public TimeSpan Renew(TimeSpan renewalTime) { }

	// RVA: 0x14790F0 Offset: 0x14776F0 VA: 0x1814790F0 Slot: 10
	public void Unregister(ISponsor obj) { }

	// RVA: 0x1479240 Offset: 0x1477840 VA: 0x181479240
	internal void UpdateState() { }

	// RVA: 0x14788F0 Offset: 0x1476EF0 VA: 0x1814788F0
	private void CheckNextSponsor() { }

	// RVA: 0x1478B70 Offset: 0x1477170 VA: 0x181478B70
	private void ProcessSponsorResponse(object state, bool timedOut) { }

}

private sealed class Lease.RenewalDelegate : MulticastDelegate // TypeDefIndex: 1166
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x148B6D0 Offset: 0x1489CD0 VA: 0x18148B6D0 Slot: 12
	public virtual TimeSpan Invoke(ILease lease) { }

	// RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380 Slot: 13
	public virtual IAsyncResult BeginInvoke(ILease lease, AsyncCallback callback, object object) { }

	// RVA: 0x1221D30 Offset: 0x1220330 VA: 0x181221D30 Slot: 14
	public virtual TimeSpan EndInvoke(IAsyncResult result) { }

}

