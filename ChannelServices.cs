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

	// RVA: 0xFE05D0 Offset: 0xFDEBD0 VA: 0x180FE05D0
	internal static CrossContextChannel get_CrossContextChannel() { }

	// RVA: 0xFDE100 Offset: 0xFDC700 VA: 0x180FDE100
	internal static IMessageSink CreateClientChannelSinkChain(string url, object remoteChannelData, out string objectUri) { }

	// RVA: 0xFDDFF0 Offset: 0xFDC5F0 VA: 0x180FDDFF0
	internal static IMessageSink CreateClientChannelSinkChain(IChannelSender sender, string url, object[] channelDataArray, out string objectUri) { }

	[ObsoleteAttribute] // RVA: 0xD26B0 Offset: 0xD1AB0 VA: 0x1800D26B0
	// RVA: 0xFDFCF0 Offset: 0xFDE2F0 VA: 0x180FDFCF0
	public static void RegisterChannel(IChannel chnl) { }

	// RVA: 0xFDFD50 Offset: 0xFDE350 VA: 0x180FDFD50
	public static void RegisterChannel(IChannel chnl, bool ensureSecurity) { }

	// RVA: 0xFDEEC0 Offset: 0xFDD4C0 VA: 0x180FDEEC0
	internal static void RegisterChannelConfig(ChannelData channel) { }

	// RVA: 0xFDE870 Offset: 0xFDCE70 VA: 0x180FDE870
	private static object CreateProvider(ProviderData prov) { }

	// RVA: 0xFE0300 Offset: 0xFDE900 VA: 0x180FE0300
	public static IMessage SyncDispatchMessage(IMessage msg) { }

	// RVA: 0xFDDCE0 Offset: 0xFDC2E0 VA: 0x180FDDCE0
	private static ReturnMessage CheckIncomingMessage(IMessage msg) { }

	// RVA: 0xFDDEB0 Offset: 0xFDC4B0 VA: 0x180FDDEB0
	internal static IMessage CheckReturnMessage(IMessage callMsg, IMessage retMsg) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250
	private static bool IsLocalCall(IMessage callMsg) { }

	// RVA: 0xFDEBB0 Offset: 0xFDD1B0 VA: 0x180FDEBB0
	internal static object[] GetCurrentChannelInfo() { }

	// RVA: 0xFE03E0 Offset: 0xFDE9E0 VA: 0x180FE03E0
	private static void .cctor() { }

}

