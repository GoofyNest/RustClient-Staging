internal struct OnIncomingConnectionRequestInfoInternal : ICallbackInfoInternal, IGettable<OnIncomingConnectionRequestInfo>, ISettable<OnIncomingConnectionRequestInfo>, IDisposable // TypeDefIndex: 8973
{
	private IntPtr m_ClientData;
	private IntPtr m_LocalUserId;
	private IntPtr m_RemoteUserId;
	private IntPtr m_SocketId;

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId RemoteUserId { get; set; }
	public Nullable<SocketId> SocketId { get; set; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ProductUserId get_LocalUserId() { }

	public void set_LocalUserId(ProductUserId value) { }

	public ProductUserId get_RemoteUserId() { }

	public void set_RemoteUserId(ProductUserId value) { }

	public Nullable<SocketId> get_SocketId() { }

	public void set_SocketId(Nullable<SocketId> value) { }

	public void Set(ref OnIncomingConnectionRequestInfo other) { }

	public void Set(ref Nullable<OnIncomingConnectionRequestInfo> other) { }

	public void Dispose() { }

	public void Get(out OnIncomingConnectionRequestInfo output) { }

}

