internal class CrossContextChannel : IMessageSink // TypeDefIndex: 1175
{	// Methods

	// RVA: 0x14767E0 Offset: 0x1474DE0 VA: 0x1814767E0 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x14763A0 Offset: 0x14749A0 VA: 0x1814763A0 Slot: 5
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

	// RVA: 0x1473FD0 Offset: 0x14725D0 VA: 0x181473FD0
	public void .ctor(IMessageSink next, Context context, IMessage call) { }

	// RVA: 0x1473DA0 Offset: 0x14723A0 VA: 0x181473DA0 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x1473D50 Offset: 0x1472350 VA: 0x181473D50 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

}

