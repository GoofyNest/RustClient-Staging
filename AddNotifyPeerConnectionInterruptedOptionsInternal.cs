internal struct AddNotifyPeerConnectionInterruptedOptionsInternal : ISettable<AddNotifyPeerConnectionInterruptedOptions>, IDisposable // TypeDefIndex: 8934
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_SocketId; 

	public ProductUserId LocalUserId { set; }
	public Nullable<SocketId> SocketId { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_SocketId(Nullable<SocketId> value) { }

	public void Set(ref AddNotifyPeerConnectionInterruptedOptions other) { }

	public void Set(ref Nullable<AddNotifyPeerConnectionInterruptedOptions> other) { }

	public void Dispose() { }

}

