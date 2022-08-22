internal class LeaseSink : IMessageSink // TypeDefIndex: 1168
{	// Fields
	private IMessageSink _nextSink; // 0x10

	// Methods

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	public void .ctor(IMessageSink nextSink) { }

	// RVA: 0x1478870 Offset: 0x1476E70 VA: 0x181478870 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x14785F0 Offset: 0x1476BF0 VA: 0x1814785F0 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x1478670 Offset: 0x1476C70 VA: 0x181478670
	private void RenewLease(IMessage msg) { }

}

