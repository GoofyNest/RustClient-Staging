public struct CancellationTokenRegistration : IEquatable<CancellationTokenRegistration>, IDisposable // TypeDefIndex: 750
{	private readonly CancellationCallbackInfo m_callbackInfo; // 0x0
	private readonly SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> m_registrationInfo; // 0x8


	internal void .ctor(CancellationCallbackInfo callbackInfo, SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> registrationInfo) { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal bool TryDeregister() { }

	public void Dispose() { }

	public override bool Equals(object obj) { }

	public bool Equals(CancellationTokenRegistration other) { }

	public override int GetHashCode() { }

}

