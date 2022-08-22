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

	// RVA: 0x10107D0 Offset: 0x100EDD0 VA: 0x1810107D0
	public void .ctor() { }

	// RVA: 0x1010670 Offset: 0x100EC70 VA: 0x181010670
	public void .ctor(AddressFamily family) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public Socket get_Client() { }

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	public void set_Client(Socket value) { }

	// RVA: 0x1010140 Offset: 0x100E740 VA: 0x181010140
	private void FreeResources() { }

	// RVA: 0x100FE10 Offset: 0x100E410 VA: 0x18100FE10 Slot: 4
	public void Dispose() { }

	// RVA: 0x100FD60 Offset: 0x100E360 VA: 0x18100FD60 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x100FC20 Offset: 0x100E220 VA: 0x18100FC20
	public void Connect(IPEndPoint endPoint) { }

	// RVA: 0x100FBB0 Offset: 0x100E1B0 VA: 0x18100FBB0
	private void CheckForBroadcast(IPAddress ipAddress) { }

	// RVA: 0x100F940 Offset: 0x100DF40 VA: 0x18100F940
	public IAsyncResult BeginSend(byte[] datagram, int bytes, IPEndPoint endPoint, AsyncCallback requestCallback, object state) { }

	// RVA: 0x100F910 Offset: 0x100DF10 VA: 0x18100F910
	public IAsyncResult BeginSend(byte[] datagram, int bytes, AsyncCallback requestCallback, object state) { }

	// RVA: 0x1010070 Offset: 0x100E670 VA: 0x181010070
	public int EndSend(IAsyncResult asyncResult) { }

	// RVA: 0x100F7C0 Offset: 0x100DDC0 VA: 0x18100F7C0
	public IAsyncResult BeginReceive(AsyncCallback requestCallback, object state) { }

	// RVA: 0x100FE30 Offset: 0x100E430 VA: 0x18100FE30
	public byte[] EndReceive(IAsyncResult asyncResult, ref IPEndPoint remoteEP) { }

	// RVA: 0x1010380 Offset: 0x100E980 VA: 0x181010380
	public Task<int> SendAsync(byte[] datagram, int bytes) { }

	// RVA: 0x10101B0 Offset: 0x100E7B0 VA: 0x1810101B0
	public Task<UdpReceiveResult> ReceiveAsync() { }

	// RVA: 0x10108B0 Offset: 0x100EEB0 VA: 0x1810108B0
	private void createClientSocket() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x100F7C0 Offset: 0x100DDC0 VA: 0x18100F7C0
	private IAsyncResult <ReceiveAsync>b__64_0(AsyncCallback callback, object state) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1010570 Offset: 0x100EB70 VA: 0x181010570
	private UdpReceiveResult <ReceiveAsync>b__64_1(IAsyncResult ar) { }

}

