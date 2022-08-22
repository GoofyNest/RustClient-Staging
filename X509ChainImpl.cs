internal abstract class X509ChainImpl : IDisposable // TypeDefIndex: 2826
{	// Properties
	public abstract bool IsValid { get; }
	public abstract X509ChainPolicy ChainPolicy { get; set; }
	public abstract X509ChainStatus[] ChainStatus { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsValid();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract X509ChainPolicy get_ChainPolicy();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void set_ChainPolicy(X509ChainPolicy value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract X509ChainStatus[] get_ChainStatus();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool Build(X509Certificate2 certificate);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Reset();

	// RVA: 0x14D8F60 Offset: 0x14D7560 VA: 0x1814D8F60 Slot: 4
	public void Dispose() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 11
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x14D8FD0 Offset: 0x14D75D0 VA: 0x1814D8FD0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

