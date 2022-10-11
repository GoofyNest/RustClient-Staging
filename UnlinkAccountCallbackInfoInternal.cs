internal struct UnlinkAccountCallbackInfoInternal : ICallbackInfoInternal, IGettable<UnlinkAccountCallbackInfo>, ISettable<UnlinkAccountCallbackInfo>, IDisposable // TypeDefIndex: 9627
{
	private Result m_ResultCode; 
	private IntPtr m_ClientData; 
	private IntPtr m_LocalUserId; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ProductUserId get_LocalUserId() { }

	public void set_LocalUserId(ProductUserId value) { }

	public void Set(ref UnlinkAccountCallbackInfo other) { }

	public void Set(ref Nullable<UnlinkAccountCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out UnlinkAccountCallbackInfo output) { }

}

