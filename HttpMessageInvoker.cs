public class HttpMessageInvoker : IDisposable // TypeDefIndex: 5751
{	// Fields
	private HttpMessageHandler handler; // 0x10
	private readonly bool disposeHandler; // 0x18

	// Methods

	// RVA: 0x108F870 Offset: 0x108DE70 VA: 0x18108F870
	public void .ctor(HttpMessageHandler handler, bool disposeHandler) { }

	// RVA: 0x100FE10 Offset: 0x100E410 VA: 0x18100FE10 Slot: 4
	public void Dispose() { }

	// RVA: 0x108F810 Offset: 0x108DE10 VA: 0x18108F810 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x108B010 Offset: 0x1089610 VA: 0x18108B010 Slot: 6
	public virtual Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

}

