public struct SessionInviteAcceptedCallbackInfo : ICallbackInfo // TypeDefIndex: 8566
{
	[CompilerGeneratedAttribute]
	private object <ClientData>k__BackingField;
	[CompilerGeneratedAttribute]
	private Utf8String <SessionId>k__BackingField;
	[CompilerGeneratedAttribute]
	private ProductUserId <LocalUserId>k__BackingField;
	[CompilerGeneratedAttribute]
	private ProductUserId <TargetUserId>k__BackingField;
	[CompilerGeneratedAttribute]
	private Utf8String <InviteId>k__BackingField;

	public object ClientData { get; set; }
	public Utf8String SessionId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public Utf8String InviteId { get; set; }


	[CompilerGeneratedAttribute]
	public object get_ClientData() { }

	[CompilerGeneratedAttribute]
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute]
	public Utf8String get_SessionId() { }

	[CompilerGeneratedAttribute]
	public void set_SessionId(Utf8String value) { }

	[CompilerGeneratedAttribute]
	public ProductUserId get_LocalUserId() { }

	[CompilerGeneratedAttribute]
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute]
	public ProductUserId get_TargetUserId() { }

	[CompilerGeneratedAttribute]
	public void set_TargetUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute]
	public Utf8String get_InviteId() { }

	[CompilerGeneratedAttribute]
	public void set_InviteId(Utf8String value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref SessionInviteAcceptedCallbackInfoInternal other) { }

}

