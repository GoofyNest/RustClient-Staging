internal class CrossAppDomainChannel : IChannel, IChannelSender, IChannelReceiver // TypeDefIndex: 1189
{	// Fields
	private static object s_lock; // 0x2B111F4

	// Properties
	public virtual string ChannelName { get; }
	public virtual int ChannelPriority { get; }
	public virtual object ChannelData { get; }

	// Methods

	// RVA: 0xFE5120 Offset: 0xFE3720 VA: 0x180FE5120
	internal static void RegisterCrossAppDomainChannel() { }

	// RVA: 0xFE53C0 Offset: 0xFE39C0 VA: 0x180FE53C0 Slot: 9
	public virtual string get_ChannelName() { }

	// RVA: 0x8D9030 Offset: 0x8D7630 VA: 0x1808D9030 Slot: 10
	public virtual int get_ChannelPriority() { }

	// RVA: 0xFE52F0 Offset: 0xFE38F0 VA: 0x180FE52F0 Slot: 11
	public virtual object get_ChannelData() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 12
	public virtual void StartListening(object data) { }

	// RVA: 0xFE4FC0 Offset: 0xFE35C0 VA: 0x180FE4FC0 Slot: 13
	public virtual IMessageSink CreateMessageSink(string url, object data, out string uri) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFE5290 Offset: 0xFE3890 VA: 0x180FE5290
	private static void .cctor() { }

}

