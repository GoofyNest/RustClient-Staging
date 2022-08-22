internal class CrossAppDomainChannel : IChannel, IChannelSender, IChannelReceiver // TypeDefIndex: 1189
{	// Fields
	private static object s_lock; // 0x2B101B4

	// Properties
	public virtual string ChannelName { get; }
	public virtual int ChannelPriority { get; }
	public virtual object ChannelData { get; }

	// Methods

	// RVA: 0xFE4E60 Offset: 0xFE3460 VA: 0x180FE4E60
	internal static void RegisterCrossAppDomainChannel() { }

	// RVA: 0xFE5100 Offset: 0xFE3700 VA: 0x180FE5100 Slot: 9
	public virtual string get_ChannelName() { }

	// RVA: 0x8D8F20 Offset: 0x8D7520 VA: 0x1808D8F20 Slot: 10
	public virtual int get_ChannelPriority() { }

	// RVA: 0xFE5030 Offset: 0xFE3630 VA: 0x180FE5030 Slot: 11
	public virtual object get_ChannelData() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 12
	public virtual void StartListening(object data) { }

	// RVA: 0xFE4D00 Offset: 0xFE3300 VA: 0x180FE4D00 Slot: 13
	public virtual IMessageSink CreateMessageSink(string url, object data, out string uri) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFE4FD0 Offset: 0xFE35D0 VA: 0x180FE4FD0
	private static void .cctor() { }

}

