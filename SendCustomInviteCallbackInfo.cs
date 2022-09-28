public struct SendCustomInviteCallbackInfo : ICallbackInfo // TypeDefIndex: 9532
{
	[CompilerGeneratedAttribute] 
	private Result <ResultCode>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private object <ClientData>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ProductUserId <LocalUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ProductUserId[] <TargetUserIds>k__BackingField; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId[] TargetUserIds { get; set; }


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
	public ProductUserId[] get_TargetUserIds() { }

	[CompilerGeneratedAttribute] 
	public void set_TargetUserIds(ProductUserId[] value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref SendCustomInviteCallbackInfoInternal other) { }

}

