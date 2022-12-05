public struct LobbyInviteAcceptedCallbackInfo : ICallbackInfo // TypeDefIndex: 9158
{
	[CompilerGeneratedAttribute]
	private object <ClientData>k__BackingField;
	[CompilerGeneratedAttribute]
	private Utf8String <InviteId>k__BackingField;
	[CompilerGeneratedAttribute]
	private ProductUserId <LocalUserId>k__BackingField;
	[CompilerGeneratedAttribute]
	private ProductUserId <TargetUserId>k__BackingField;
	[CompilerGeneratedAttribute]
	private Utf8String <LobbyId>k__BackingField;

	public object ClientData { get; set; }
	public Utf8String InviteId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public Utf8String LobbyId { get; set; }


	[CompilerGeneratedAttribute]
	public object get_ClientData() { }

	[CompilerGeneratedAttribute]
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute]
	public Utf8String get_InviteId() { }

	[CompilerGeneratedAttribute]
	public void set_InviteId(Utf8String value) { }

	[CompilerGeneratedAttribute]
	public ProductUserId get_LocalUserId() { }

	[CompilerGeneratedAttribute]
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute]
	public ProductUserId get_TargetUserId() { }

	[CompilerGeneratedAttribute]
	public void set_TargetUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute]
	public Utf8String get_LobbyId() { }

	[CompilerGeneratedAttribute]
	public void set_LobbyId(Utf8String value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref LobbyInviteAcceptedCallbackInfoInternal other) { }

}

