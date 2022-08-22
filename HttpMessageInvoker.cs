public class HttpMessageInvoker : IDisposable // TypeDefIndex: 5751
{	// Fields
	private HttpMessageHandler handler; // 0x10
	private readonly bool disposeHandler; // 0x18

	// Methods

	// RVA: 0x108EE00 Offset: 0x108D400 VA: 0x18108EE00
	public void .ctor(HttpMessageHandler handler, bool disposeHandler) { }

	// RVA: 0x100F370 Offset: 0x100D970 VA: 0x18100F370 Slot: 4
	public void Dispose() { }

	// RVA: 0x108EDA0 Offset: 0x108D3A0 VA: 0x18108EDA0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x108A5A0 Offset: 0x1088BA0 VA: 0x18108A5A0 Slot: 6
	public virtual Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

}

