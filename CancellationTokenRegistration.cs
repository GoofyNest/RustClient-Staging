public struct CancellationTokenRegistration : IEquatable<CancellationTokenRegistration>, IDisposable // TypeDefIndex: 750
{	// Fields
	private readonly CancellationCallbackInfo m_callbackInfo; // 0x0
	private readonly SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> m_registrationInfo; // 0x8

	// Methods

	// RVA: 0x1F0280 Offset: 0x1EF680 VA: 0x1801F0280
	internal void .ctor(CancellationCallbackInfo callbackInfo, SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> registrationInfo) { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1F0270 Offset: 0x1EF670 VA: 0x1801F0270
	internal bool TryDeregister() { }

	// RVA: 0x1F0050 Offset: 0x1EF450 VA: 0x1801F0050 Slot: 5
	public void Dispose() { }

	// RVA: 0x1F0060 Offset: 0x1EF460 VA: 0x1801F0060 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1F0140 Offset: 0x1EF540 VA: 0x1801F0140 Slot: 4
	public bool Equals(CancellationTokenRegistration other) { }

	// RVA: 0x1F01D0 Offset: 0x1EF5D0 VA: 0x1801F01D0 Slot: 2
	public override int GetHashCode() { }

}

