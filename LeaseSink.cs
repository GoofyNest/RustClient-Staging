internal class LeaseSink : IMessageSink // TypeDefIndex: 1168
{	// Fields
	private IMessageSink _nextSink; // 0x10

	// Methods

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	public void .ctor(IMessageSink nextSink) { }

	// RVA: 0x14797A0 Offset: 0x1477DA0 VA: 0x1814797A0 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x1479520 Offset: 0x1477B20 VA: 0x181479520 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x14795A0 Offset: 0x1477BA0 VA: 0x1814795A0
	private void RenewLease(IMessage msg) { }

}

