internal class LeaseSink : IMessageSink // TypeDefIndex: 1168
{	// Fields
	private IMessageSink _nextSink; // 0x10

	// Methods

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	public void .ctor(IMessageSink nextSink) { }

	// RVA: 0x14794E0 Offset: 0x1477AE0 VA: 0x1814794E0 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x1479260 Offset: 0x1477860 VA: 0x181479260 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x14792E0 Offset: 0x14778E0 VA: 0x1814792E0
	private void RenewLease(IMessage msg) { }

}

