internal class CrossAppDomainSink : IMessageSink // TypeDefIndex: 1190
{	// Fields
	private static Hashtable s_sinks; // 0x0
	private static MethodInfo processMessageMethod; // 0x8
	private int _domainID; // 0x10

	// Properties
	internal int TargetDomainId { get; }

	// Methods

	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	internal void .ctor(int domainID) { }

	// RVA: 0xFE5FF0 Offset: 0xFE45F0 VA: 0x180FE5FF0
	internal static CrossAppDomainSink GetSink(int domainID) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	internal int get_TargetDomainId() { }

	// RVA: 0xFE62F0 Offset: 0xFE48F0 VA: 0x180FE62F0
	private static CrossAppDomainSink.ProcessMessageRes ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg) { }

	// RVA: 0xFE64D0 Offset: 0xFE4AD0 VA: 0x180FE64D0 Slot: 6
	public virtual IMessage SyncProcessMessage(IMessage msgRequest) { }

	// RVA: 0xFE5F30 Offset: 0xFE4530 VA: 0x180FE5F30 Slot: 7
	public virtual IMessageCtrl AsyncProcessMessage(IMessage reqMsg, IMessageSink replySink) { }

	// RVA: 0xFE6410 Offset: 0xFE4A10 VA: 0x180FE6410
	public void SendAsyncMessage(object data) { }

	// RVA: 0xFE6930 Offset: 0xFE4F30 VA: 0x180FE6930
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFE6830 Offset: 0xFE4E30 VA: 0x180FE6830
	private void <AsyncProcessMessage>b__10_0(object data) { }

}

private struct CrossAppDomainSink.ProcessMessageRes // TypeDefIndex: 1191
{	// Fields
	public byte[] arrResponse; // 0x0
	public CADMethodReturnMessage cadMrm; // 0x8

}

