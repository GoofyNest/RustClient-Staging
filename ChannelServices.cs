public sealed class ChannelServices // TypeDefIndex: 1187
{	// Fields
	private static ArrayList registeredChannels; // 0x0
	private static ArrayList delayedClientChannels; // 0x8
	private static CrossContextChannel _crossContextSink; // 0x10
	internal static string CrossContextUrl; // 0x18
	private static IList oldStartModeTypes; // 0x20

	// Properties
	internal static CrossContextChannel CrossContextChannel { get; }

	// Methods

	// RVA: 0xFE0890 Offset: 0xFDEE90 VA: 0x180FE0890
	internal static CrossContextChannel get_CrossContextChannel() { }

	// RVA: 0xFDE3C0 Offset: 0xFDC9C0 VA: 0x180FDE3C0
	internal static IMessageSink CreateClientChannelSinkChain(string url, object remoteChannelData, out string objectUri) { }

	// RVA: 0xFDE2B0 Offset: 0xFDC8B0 VA: 0x180FDE2B0
	internal static IMessageSink CreateClientChannelSinkChain(IChannelSender sender, string url, object[] channelDataArray, out string objectUri) { }

	[ObsoleteAttribute] // RVA: 0xD26B0 Offset: 0xD1AB0 VA: 0x1800D26B0
	// RVA: 0xFDFFB0 Offset: 0xFDE5B0 VA: 0x180FDFFB0
	public static void RegisterChannel(IChannel chnl) { }

	// RVA: 0xFE0010 Offset: 0xFDE610 VA: 0x180FE0010
	public static void RegisterChannel(IChannel chnl, bool ensureSecurity) { }

	// RVA: 0xFDF180 Offset: 0xFDD780 VA: 0x180FDF180
	internal static void RegisterChannelConfig(ChannelData channel) { }

	// RVA: 0xFDEB30 Offset: 0xFDD130 VA: 0x180FDEB30
	private static object CreateProvider(ProviderData prov) { }

	// RVA: 0xFE05C0 Offset: 0xFDEBC0 VA: 0x180FE05C0
	public static IMessage SyncDispatchMessage(IMessage msg) { }

	// RVA: 0xFDDFA0 Offset: 0xFDC5A0 VA: 0x180FDDFA0
	private static ReturnMessage CheckIncomingMessage(IMessage msg) { }

	// RVA: 0xFDE170 Offset: 0xFDC770 VA: 0x180FDE170
	internal static IMessage CheckReturnMessage(IMessage callMsg, IMessage retMsg) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250
	private static bool IsLocalCall(IMessage callMsg) { }

	// RVA: 0xFDEE70 Offset: 0xFDD470 VA: 0x180FDEE70
	internal static object[] GetCurrentChannelInfo() { }

	// RVA: 0xFE06A0 Offset: 0xFDECA0 VA: 0x180FE06A0
	private static void .cctor() { }

}

