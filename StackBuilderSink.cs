internal class StackBuilderSink : IMessageSink // TypeDefIndex: 1262
{	// Fields
	private MarshalByRefObject _target; // 0x10
	private RealProxy _rp; // 0x18

	// Methods

	// RVA: 0x148D890 Offset: 0x148BE90 VA: 0x18148D890
	public void .ctor(MarshalByRefObject obj, bool forceInternalExecute) { }

	// RVA: 0x148D760 Offset: 0x148BD60 VA: 0x18148D760 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x148CD50 Offset: 0x148B350 VA: 0x18148CD50 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x148D220 Offset: 0x148B820 VA: 0x18148D220
	private void ExecuteAsyncMessage(object ob) { }

	// RVA: 0x148CEA0 Offset: 0x148B4A0 VA: 0x18148CEA0
	private void CheckParameters(IMessage msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x148D830 Offset: 0x148BE30 VA: 0x18148D830
	private void <AsyncProcessMessage>b__4_0(object data) { }

}

