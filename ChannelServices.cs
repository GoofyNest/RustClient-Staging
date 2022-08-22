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

	// RVA: 0xFE1330 Offset: 0xFDF930 VA: 0x180FE1330
	internal static CrossContextChannel get_CrossContextChannel() { }

	// RVA: 0xFDEE60 Offset: 0xFDD460 VA: 0x180FDEE60
	internal static IMessageSink CreateClientChannelSinkChain(string url, object remoteChannelData, out string objectUri) { }

	// RVA: 0xFDED50 Offset: 0xFDD350 VA: 0x180FDED50
	internal static IMessageSink CreateClientChannelSinkChain(IChannelSender sender, string url, object[] channelDataArray, out string objectUri) { }

	[ObsoleteAttribute] // RVA: 0xD26B0 Offset: 0xD1AB0 VA: 0x1800D26B0
	// RVA: 0xFE0A50 Offset: 0xFDF050 VA: 0x180FE0A50
	public static void RegisterChannel(IChannel chnl) { }

	// RVA: 0xFE0AB0 Offset: 0xFDF0B0 VA: 0x180FE0AB0
	public static void RegisterChannel(IChannel chnl, bool ensureSecurity) { }

	// RVA: 0xFDFC20 Offset: 0xFDE220 VA: 0x180FDFC20
	internal static void RegisterChannelConfig(ChannelData channel) { }

	// RVA: 0xFDF5D0 Offset: 0xFDDBD0 VA: 0x180FDF5D0
	private static object CreateProvider(ProviderData prov) { }

	// RVA: 0xFE1060 Offset: 0xFDF660 VA: 0x180FE1060
	public static IMessage SyncDispatchMessage(IMessage msg) { }

	// RVA: 0xFDEA40 Offset: 0xFDD040 VA: 0x180FDEA40
	private static ReturnMessage CheckIncomingMessage(IMessage msg) { }

	// RVA: 0xFDEC10 Offset: 0xFDD210 VA: 0x180FDEC10
	internal static IMessage CheckReturnMessage(IMessage callMsg, IMessage retMsg) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0
	private static bool IsLocalCall(IMessage callMsg) { }

	// RVA: 0xFDF910 Offset: 0xFDDF10 VA: 0x180FDF910
	internal static object[] GetCurrentChannelInfo() { }

	// RVA: 0xFE1140 Offset: 0xFDF740 VA: 0x180FE1140
	private static void .cctor() { }

}

