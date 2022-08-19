public class UdpClient : IDisposable // TypeDefIndex: 3060
{	// Fields
	private Socket m_ClientSocket; // 0x10
	private bool m_Active; // 0x18
	private byte[] m_Buffer; // 0x20
	private AddressFamily m_Family; // 0x28
	private bool m_CleanedUp; // 0x2C
	private bool m_IsBroadcast; // 0x2D

	// Properties
	public Socket Client { get; set; }

	// Methods

	// RVA: 0x100FA70 Offset: 0x100E070 VA: 0x18100FA70
	public void .ctor() { }

	// RVA: 0x100F910 Offset: 0x100DF10 VA: 0x18100F910
	public void .ctor(AddressFamily family) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public Socket get_Client() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_Client(Socket value) { }

	// RVA: 0x100F3E0 Offset: 0x100D9E0 VA: 0x18100F3E0
	private void FreeResources() { }

	// RVA: 0x100F0B0 Offset: 0x100D6B0 VA: 0x18100F0B0 Slot: 4
	public void Dispose() { }

	// RVA: 0x100F000 Offset: 0x100D600 VA: 0x18100F000 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x100EEC0 Offset: 0x100D4C0 VA: 0x18100EEC0
	public void Connect(IPEndPoint endPoint) { }

	// RVA: 0x100EE50 Offset: 0x100D450 VA: 0x18100EE50
	private void CheckForBroadcast(IPAddress ipAddress) { }

	// RVA: 0x100EBE0 Offset: 0x100D1E0 VA: 0x18100EBE0
	public IAsyncResult BeginSend(byte[] datagram, int bytes, IPEndPoint endPoint, AsyncCallback requestCallback, object state) { }

	// RVA: 0x100EBB0 Offset: 0x100D1B0 VA: 0x18100EBB0
	public IAsyncResult BeginSend(byte[] datagram, int bytes, AsyncCallback requestCallback, object state) { }

	// RVA: 0x100F310 Offset: 0x100D910 VA: 0x18100F310
	public int EndSend(IAsyncResult asyncResult) { }

	// RVA: 0x100EA60 Offset: 0x100D060 VA: 0x18100EA60
	public IAsyncResult BeginReceive(AsyncCallback requestCallback, object state) { }

	// RVA: 0x100F0D0 Offset: 0x100D6D0 VA: 0x18100F0D0
	public byte[] EndReceive(IAsyncResult asyncResult, ref IPEndPoint remoteEP) { }

	// RVA: 0x100F620 Offset: 0x100DC20 VA: 0x18100F620
	public Task<int> SendAsync(byte[] datagram, int bytes) { }

	// RVA: 0x100F450 Offset: 0x100DA50 VA: 0x18100F450
	public Task<UdpReceiveResult> ReceiveAsync() { }

	// RVA: 0x100FB50 Offset: 0x100E150 VA: 0x18100FB50
	private void createClientSocket() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x100EA60 Offset: 0x100D060 VA: 0x18100EA60
	private IAsyncResult <ReceiveAsync>b__64_0(AsyncCallback callback, object state) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x100F810 Offset: 0x100DE10 VA: 0x18100F810
	private UdpReceiveResult <ReceiveAsync>b__64_1(IAsyncResult ar) { }

}

