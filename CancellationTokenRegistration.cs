public struct CancellationTokenRegistration : IEquatable<CancellationTokenRegistration>, IDisposable // TypeDefIndex: 750
{	// Fields
	private readonly CancellationCallbackInfo m_callbackInfo; // 0x0
	private readonly SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> m_registrationInfo; // 0x8

	// Methods

	// RVA: 0x1F0200 Offset: 0x1EF600 VA: 0x1801F0200
	internal void .ctor(CancellationCallbackInfo callbackInfo, SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> registrationInfo) { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1F01F0 Offset: 0x1EF5F0 VA: 0x1801F01F0
	internal bool TryDeregister() { }

	// RVA: 0x1EFFD0 Offset: 0x1EF3D0 VA: 0x1801EFFD0 Slot: 5
	public void Dispose() { }

	// RVA: 0x1EFFE0 Offset: 0x1EF3E0 VA: 0x1801EFFE0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1F00C0 Offset: 0x1EF4C0 VA: 0x1801F00C0 Slot: 4
	public bool Equals(CancellationTokenRegistration other) { }

	// RVA: 0x1F0150 Offset: 0x1EF550 VA: 0x1801F0150 Slot: 2
	public override int GetHashCode() { }

}

