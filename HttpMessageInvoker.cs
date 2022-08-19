public class HttpMessageInvoker : IDisposable // TypeDefIndex: 5751
{	// Fields
	private HttpMessageHandler handler; // 0x10
	private readonly bool disposeHandler; // 0x18

	// Methods

	// RVA: 0x108EB40 Offset: 0x108D140 VA: 0x18108EB40
	public void .ctor(HttpMessageHandler handler, bool disposeHandler) { }

	// RVA: 0x100F0B0 Offset: 0x100D6B0 VA: 0x18100F0B0 Slot: 4
	public void Dispose() { }

	// RVA: 0x108EAE0 Offset: 0x108D0E0 VA: 0x18108EAE0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x108A2E0 Offset: 0x10888E0 VA: 0x18108A2E0 Slot: 6
	public virtual Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

}

