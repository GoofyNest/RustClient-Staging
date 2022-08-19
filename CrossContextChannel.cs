internal class CrossContextChannel : IMessageSink // TypeDefIndex: 1175
{	// Methods

	// RVA: 0x1476520 Offset: 0x1474B20 VA: 0x181476520 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x14760E0 Offset: 0x14746E0 VA: 0x1814760E0 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private class CrossContextChannel.ContextRestoreSink : IMessageSink // TypeDefIndex: 1176
{	// Fields
	private IMessageSink _next; // 0x10
	private Context _context; // 0x18
	private IMessage _call; // 0x20

	// Methods

	// RVA: 0x1473D10 Offset: 0x1472310 VA: 0x181473D10
	public void .ctor(IMessageSink next, Context context, IMessage call) { }

	// RVA: 0x1473AE0 Offset: 0x14720E0 VA: 0x181473AE0 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x1473A90 Offset: 0x1472090 VA: 0x181473A90 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

}

