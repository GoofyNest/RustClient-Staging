internal class CrossContextChannel : IMessageSink // TypeDefIndex: 1175
{	// Methods

	// RVA: 0x14758B0 Offset: 0x1473EB0 VA: 0x1814758B0 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x1475470 Offset: 0x1473A70 VA: 0x181475470 Slot: 5
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

	// RVA: 0x14730A0 Offset: 0x14716A0 VA: 0x1814730A0
	public void .ctor(IMessageSink next, Context context, IMessage call) { }

	// RVA: 0x1472E70 Offset: 0x1471470 VA: 0x181472E70 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x1472E20 Offset: 0x1471420 VA: 0x181472E20 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

}

