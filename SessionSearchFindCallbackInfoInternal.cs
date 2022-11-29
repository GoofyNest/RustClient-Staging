internal struct SessionSearchFindCallbackInfoInternal : ICallbackInfoInternal, IGettable<SessionSearchFindCallbackInfo>, ISettable<SessionSearchFindCallbackInfo>, IDisposable // TypeDefIndex: 8587
{
	private Result m_ResultCode; 
	private IntPtr m_ClientData; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public void Set(ref SessionSearchFindCallbackInfo other) { }

	public void Set(ref Nullable<SessionSearchFindCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out SessionSearchFindCallbackInfo output) { }

}

