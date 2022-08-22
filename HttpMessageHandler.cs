public abstract class HttpMessageHandler : IDisposable // TypeDefIndex: 5750
{	// Methods

	// RVA: 0x100FE10 Offset: 0x100E410 VA: 0x18100FE10 Slot: 4
	public void Dispose() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 6
	protected internal abstract Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

