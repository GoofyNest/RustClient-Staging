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

	// RVA: 0xFE5550 Offset: 0xFE3B50 VA: 0x180FE5550
	internal static CrossAppDomainSink GetSink(int domainID) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	internal int get_TargetDomainId() { }

	// RVA: 0xFE5850 Offset: 0xFE3E50 VA: 0x180FE5850
	private static CrossAppDomainSink.ProcessMessageRes ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg) { }

	// RVA: 0xFE5A30 Offset: 0xFE4030 VA: 0x180FE5A30 Slot: 6
	public virtual IMessage SyncProcessMessage(IMessage msgRequest) { }

	// RVA: 0xFE5490 Offset: 0xFE3A90 VA: 0x180FE5490 Slot: 7
	public virtual IMessageCtrl AsyncProcessMessage(IMessage reqMsg, IMessageSink replySink) { }

	// RVA: 0xFE5970 Offset: 0xFE3F70 VA: 0x180FE5970
	public void SendAsyncMessage(object data) { }

	// RVA: 0xFE5E90 Offset: 0xFE4490 VA: 0x180FE5E90
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFE5D90 Offset: 0xFE4390 VA: 0x180FE5D90
	private void <AsyncProcessMessage>b__10_0(object data) { }

}

private struct CrossAppDomainSink.ProcessMessageRes // TypeDefIndex: 1191
{	// Fields
	public byte[] arrResponse; // 0x0
	public CADMethodReturnMessage cadMrm; // 0x8

}

