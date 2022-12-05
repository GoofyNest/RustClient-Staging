public struct UpdateReceivingCallbackInfo : ICallbackInfo // TypeDefIndex: 8722
{
	[CompilerGeneratedAttribute]
	private Result <ResultCode>k__BackingField;
	[CompilerGeneratedAttribute]
	private object <ClientData>k__BackingField;
	[CompilerGeneratedAttribute]
	private ProductUserId <LocalUserId>k__BackingField;
	[CompilerGeneratedAttribute]
	private Utf8String <RoomName>k__BackingField;
	[CompilerGeneratedAttribute]
	private ProductUserId <ParticipantId>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <AudioEnabled>k__BackingField;

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public ProductUserId ParticipantId { get; set; }
	public bool AudioEnabled { get; set; }


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
	public Utf8String get_RoomName() { }

	[CompilerGeneratedAttribute]
	public void set_RoomName(Utf8String value) { }

	[CompilerGeneratedAttribute]
	public ProductUserId get_ParticipantId() { }

	[CompilerGeneratedAttribute]
	public void set_ParticipantId(ProductUserId value) { }

	[CompilerGeneratedAttribute]
	public bool get_AudioEnabled() { }

	[CompilerGeneratedAttribute]
	public void set_AudioEnabled(bool value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref UpdateReceivingCallbackInfoInternal other) { }

}

