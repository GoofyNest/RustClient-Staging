internal struct DeleteDeviceIdCallbackInfoInternal : ICallbackInfoInternal, IGettable<DeleteDeviceIdCallbackInfo>, ISettable<DeleteDeviceIdCallbackInfo>, IDisposable // TypeDefIndex: 9580
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

	public void Set(ref DeleteDeviceIdCallbackInfo other) { }

	public void Set(ref Nullable<DeleteDeviceIdCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out DeleteDeviceIdCallbackInfo output) { }

}

