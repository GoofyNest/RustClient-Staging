internal class DisposerReplySink : IMessageSink // TypeDefIndex: 1149
{	// Fields
	private IMessageSink _next; // 0x10
	private IDisposable _disposable; // 0x18

	// Methods

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	public void .ctor(IMessageSink next, IDisposable disposable) { }

	// RVA: 0x1477010 Offset: 0x1475610 VA: 0x181477010 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x1476FC0 Offset: 0x14755C0 VA: 0x181476FC0 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

}

