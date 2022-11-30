public struct CreateUserCallbackInfo : ICallbackInfo // TypeDefIndex: 9328
{
	[CompilerGeneratedAttribute]
	private Result <ResultCode>k__BackingField;
	[CompilerGeneratedAttribute]
	private object <ClientData>k__BackingField;
	[CompilerGeneratedAttribute]
	private ProductUserId <LocalUserId>k__BackingField;
	[CompilerGeneratedAttribute]
	private Utf8String <KWSUserId>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <IsMinor>k__BackingField;

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String KWSUserId { get; set; }
	public bool IsMinor { get; set; }


	[CompilerGeneratedAttribute]
	public Result get_ResultCode() { }

	[CompilerGeneratedAttribute]
	public void set_ResultCode(Result value) { }

	[CompilerGeneratedAttribute]
	public object get_ClientData() { }

	[CompilerGeneratedAttribute]
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute]
	public ProductUserId get_LocalUserId() { }

	[CompilerGeneratedAttribute]
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute]
	public Utf8String get_KWSUserId() { }

	[CompilerGeneratedAttribute]
	public void set_KWSUserId(Utf8String value) { }

	[CompilerGeneratedAttribute]
	public bool get_IsMinor() { }

	[CompilerGeneratedAttribute]
	public void set_IsMinor(bool value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref CreateUserCallbackInfoInternal other) { }

}

public struct CreateUserCallbackInfo : ICallbackInfo // TypeDefIndex: 9571
{
	[CompilerGeneratedAttribute]
	private Result <ResultCode>k__BackingField;
	[CompilerGeneratedAttribute]
	private object <ClientData>k__BackingField;
	[CompilerGeneratedAttribute]
	private ProductUserId <LocalUserId>k__BackingField;

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }


	[CompilerGeneratedAttribute]
	public Result get_ResultCode() { }

	[CompilerGeneratedAttribute]
	public void set_ResultCode(Result value) { }

	[CompilerGeneratedAttribute]
	public object get_ClientData() { }

	[CompilerGeneratedAttribute]
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute]
	public ProductUserId get_LocalUserId() { }

	[CompilerGeneratedAttribute]
	public void set_LocalUserId(ProductUserId value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref CreateUserCallbackInfoInternal other) { }

}

