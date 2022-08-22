internal class CrossAppDomainChannel : IChannel, IChannelSender, IChannelReceiver // TypeDefIndex: 1189
{	// Fields
	private static object s_lock; // 0x13DBF

	// Properties
	public virtual string ChannelName { get; }
	public virtual int ChannelPriority { get; }
	public virtual object ChannelData { get; }

	// Methods

	// RVA: 0xFE5BC0 Offset: 0xFE41C0 VA: 0x180FE5BC0
	internal static void RegisterCrossAppDomainChannel() { }

	// RVA: 0xFE5E60 Offset: 0xFE4460 VA: 0x180FE5E60 Slot: 9
	public virtual string get_ChannelName() { }

	// RVA: 0x8D9540 Offset: 0x8D7B40 VA: 0x1808D9540 Slot: 10
	public virtual int get_ChannelPriority() { }

	// RVA: 0xFE5D90 Offset: 0xFE4390 VA: 0x180FE5D90 Slot: 11
	public virtual object get_ChannelData() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 12
	public virtual void StartListening(object data) { }

	// RVA: 0xFE5A60 Offset: 0xFE4060 VA: 0x180FE5A60 Slot: 13
	public virtual IMessageSink CreateMessageSink(string url, object data, out string uri) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFE5D30 Offset: 0xFE4330 VA: 0x180FE5D30
	private static void .cctor() { }

}

