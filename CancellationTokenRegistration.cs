public struct CancellationTokenRegistration : IEquatable<CancellationTokenRegistration>, IDisposable // TypeDefIndex: 750
{	// Fields
	private readonly CancellationCallbackInfo m_callbackInfo; // 0x0
	private readonly SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> m_registrationInfo; // 0x8

	// Methods

	// RVA: 0x1F0620 Offset: 0x1EFA20 VA: 0x1801F0620
	internal void .ctor(CancellationCallbackInfo callbackInfo, SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> registrationInfo) { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1F0610 Offset: 0x1EFA10 VA: 0x1801F0610
	internal bool TryDeregister() { }

	// RVA: 0x1F03F0 Offset: 0x1EF7F0 VA: 0x1801F03F0 Slot: 5
	public void Dispose() { }

	// RVA: 0x1F0400 Offset: 0x1EF800 VA: 0x1801F0400 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1F04E0 Offset: 0x1EF8E0 VA: 0x1801F04E0 Slot: 4
	public bool Equals(CancellationTokenRegistration other) { }

	// RVA: 0x1F0570 Offset: 0x1EF970 VA: 0x1801F0570 Slot: 2
	public override int GetHashCode() { }

}

