internal class StackBuilderSink : IMessageSink // TypeDefIndex: 1262
{	// Fields
	private MarshalByRefObject _target; // 0x10
	private RealProxy _rp; // 0x18

	// Methods

	// RVA: 0x148E500 Offset: 0x148CB00 VA: 0x18148E500
	public void .ctor(MarshalByRefObject obj, bool forceInternalExecute) { }

	// RVA: 0x148E3D0 Offset: 0x148C9D0 VA: 0x18148E3D0 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x148D9C0 Offset: 0x148BFC0 VA: 0x18148D9C0 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x148DE90 Offset: 0x148C490 VA: 0x18148DE90
	private void ExecuteAsyncMessage(object ob) { }

	// RVA: 0x148DB10 Offset: 0x148C110 VA: 0x18148DB10
	private void CheckParameters(IMessage msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x148E4A0 Offset: 0x148CAA0 VA: 0x18148E4A0
	private void <AsyncProcessMessage>b__4_0(object data) { }

}

