internal class StackBuilderSink : IMessageSink // TypeDefIndex: 1262
{	// Fields
	private MarshalByRefObject _target; // 0x10
	private RealProxy _rp; // 0x18

	// Methods

	// RVA: 0x148E7C0 Offset: 0x148CDC0 VA: 0x18148E7C0
	public void .ctor(MarshalByRefObject obj, bool forceInternalExecute) { }

	// RVA: 0x148E690 Offset: 0x148CC90 VA: 0x18148E690 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x148DC80 Offset: 0x148C280 VA: 0x18148DC80 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x148E150 Offset: 0x148C750 VA: 0x18148E150
	private void ExecuteAsyncMessage(object ob) { }

	// RVA: 0x148DDD0 Offset: 0x148C3D0 VA: 0x18148DDD0
	private void CheckParameters(IMessage msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x148E760 Offset: 0x148CD60 VA: 0x18148E760
	private void <AsyncProcessMessage>b__4_0(object data) { }

}

