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

	// RVA: 0x100FD30 Offset: 0x100E330 VA: 0x18100FD30
	public void .ctor() { }

	// RVA: 0x100FBD0 Offset: 0x100E1D0 VA: 0x18100FBD0
	public void .ctor(AddressFamily family) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public Socket get_Client() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_Client(Socket value) { }

	// RVA: 0x100F6A0 Offset: 0x100DCA0 VA: 0x18100F6A0
	private void FreeResources() { }

	// RVA: 0x100F370 Offset: 0x100D970 VA: 0x18100F370 Slot: 4
	public void Dispose() { }

	// RVA: 0x100F2C0 Offset: 0x100D8C0 VA: 0x18100F2C0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x100F180 Offset: 0x100D780 VA: 0x18100F180
	public void Connect(IPEndPoint endPoint) { }

	// RVA: 0x100F110 Offset: 0x100D710 VA: 0x18100F110
	private void CheckForBroadcast(IPAddress ipAddress) { }

	// RVA: 0x100EEA0 Offset: 0x100D4A0 VA: 0x18100EEA0
	public IAsyncResult BeginSend(byte[] datagram, int bytes, IPEndPoint endPoint, AsyncCallback requestCallback, object state) { }

	// RVA: 0x100EE70 Offset: 0x100D470 VA: 0x18100EE70
	public IAsyncResult BeginSend(byte[] datagram, int bytes, AsyncCallback requestCallback, object state) { }

	// RVA: 0x100F5D0 Offset: 0x100DBD0 VA: 0x18100F5D0
	public int EndSend(IAsyncResult asyncResult) { }

	// RVA: 0x100ED20 Offset: 0x100D320 VA: 0x18100ED20
	public IAsyncResult BeginReceive(AsyncCallback requestCallback, object state) { }

	// RVA: 0x100F390 Offset: 0x100D990 VA: 0x18100F390
	public byte[] EndReceive(IAsyncResult asyncResult, ref IPEndPoint remoteEP) { }

	// RVA: 0x100F8E0 Offset: 0x100DEE0 VA: 0x18100F8E0
	public Task<int> SendAsync(byte[] datagram, int bytes) { }

	// RVA: 0x100F710 Offset: 0x100DD10 VA: 0x18100F710
	public Task<UdpReceiveResult> ReceiveAsync() { }

	// RVA: 0x100FE10 Offset: 0x100E410 VA: 0x18100FE10
	private void createClientSocket() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x100ED20 Offset: 0x100D320 VA: 0x18100ED20
	private IAsyncResult <ReceiveAsync>b__64_0(AsyncCallback callback, object state) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x100FAD0 Offset: 0x100E0D0 VA: 0x18100FAD0
	private UdpReceiveResult <ReceiveAsync>b__64_1(IAsyncResult ar) { }

}

