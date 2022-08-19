internal static class Native // TypeDefIndex: 4578
{	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22F6930 Offset: 0x22F4F30 VA: 0x1822F6930
	public static void YGNodeMeasureInvoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode, IntPtr returnValueAddress) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22F6770 Offset: 0x22F4D70 VA: 0x1822F6770
	public static void YGNodeBaselineInvoke(YogaNode node, float width, float height, IntPtr returnValueAddress) { }

	[FreeFunctionAttribute] // RVA: 0x7A300 Offset: 0x79700 VA: 0x18007A300
	// RVA: 0x22F6870 Offset: 0x22F4E70 VA: 0x1822F6870
	public static float YGNodeLayoutGetLeft(IntPtr node) { }

	[FreeFunctionAttribute] // RVA: 0x7A300 Offset: 0x79700 VA: 0x18007A300
	// RVA: 0x22F68B0 Offset: 0x22F4EB0 VA: 0x1822F68B0
	public static float YGNodeLayoutGetTop(IntPtr node) { }

	[FreeFunctionAttribute] // RVA: 0x7A300 Offset: 0x79700 VA: 0x18007A300
	// RVA: 0x22F68F0 Offset: 0x22F4EF0 VA: 0x1822F68F0
	public static float YGNodeLayoutGetWidth(IntPtr node) { }

	[FreeFunctionAttribute] // RVA: 0x7A300 Offset: 0x79700 VA: 0x18007A300
	// RVA: 0x22F6830 Offset: 0x22F4E30 VA: 0x1822F6830
	public static float YGNodeLayoutGetHeight(IntPtr node) { }

}

public class Native // TypeDefIndex: 7323
{
// Namespace: Facepunch.Network.Raknet
[SuppressUnmanagedCodeSecurityAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
public class Native // TypeDefIndex: 7323
	// Methods

	// RVA: 0x22CD280 Offset: 0x22CB880 VA: 0x1822CD280
	public static extern IntPtr NET_Create() { }

	// RVA: 0x22CD200 Offset: 0x22CB800 VA: 0x1822CD200
	public static extern void NET_Close(IntPtr nw) { }

	// RVA: 0x22CD8B0 Offset: 0x22CBEB0 VA: 0x1822CD8B0
	public static extern int NET_StartClient(IntPtr nw, string hostName, int port, int retries, int retryDelay, int timeout) { }

	// RVA: 0x22CD990 Offset: 0x22CBF90 VA: 0x1822CD990
	public static extern int NET_StartServer(IntPtr nw, string ip, int port, int maxConnections) { }

	// RVA: 0x22CD6F0 Offset: 0x22CBCF0 VA: 0x1822CD6F0
	public static extern IntPtr NET_LastStartupError(IntPtr nw) { }

	// RVA: 0x22CD530 Offset: 0x22CBB30 VA: 0x1822CD530
	public static extern uint NET_GetReceiveBufferSize(IntPtr nw) { }

	// RVA: 0x22CD770 Offset: 0x22CBD70 VA: 0x1822CD770
	public static extern bool NET_Receive(IntPtr nw) { }

	// RVA: 0x22CCA50 Offset: 0x22CB050 VA: 0x1822CCA50
	public static extern ulong NETRCV_GUID(IntPtr nw) { }

	// RVA: 0x22CC9D0 Offset: 0x22CAFD0 VA: 0x1822CC9D0
	public static extern uint NETRCV_Address(IntPtr nw) { }

	// RVA: 0x22CCB50 Offset: 0x22CB150 VA: 0x1822CCB50
	public static extern uint NETRCV_Port(IntPtr nw) { }

	// RVA: 0x22CCBD0 Offset: 0x22CB1D0 VA: 0x1822CCBD0
	public static extern IntPtr NETRCV_RawData(IntPtr nw) { }

	// RVA: 0x22CCAD0 Offset: 0x22CB0D0 VA: 0x1822CCAD0
	public static extern int NETRCV_LengthBits(IntPtr nw) { }

	// RVA: 0x22CCD80 Offset: 0x22CB380 VA: 0x1822CCD80
	public static extern int NETRCV_UnreadBits(IntPtr nw) { }

	// RVA: 0x22CCC50 Offset: 0x22CB250 VA: 0x1822CCC50
	public static extern bool NETRCV_ReadBytes(IntPtr nw, byte* data, int length) { }

	// RVA: 0x22CCCF0 Offset: 0x22CB2F0 VA: 0x1822CCCF0
	public static extern void NETRCV_SetReadPointer(IntPtr nw, int bitsOffset) { }

	// RVA: 0x22CD050 Offset: 0x22CB650 VA: 0x1822CD050
	public static extern void NETSND_Start(IntPtr nw) { }

	// RVA: 0x22CD0D0 Offset: 0x22CB6D0 VA: 0x1822CD0D0
	public static extern void NETSND_WriteBytes(IntPtr nw, byte* data, int length) { }

	// RVA: 0x22CCFD0 Offset: 0x22CB5D0 VA: 0x1822CCFD0
	public static extern uint NETSND_Size(IntPtr nw) { }

	// RVA: 0x22CCE00 Offset: 0x22CB400 VA: 0x1822CCE00
	public static extern uint NETSND_Broadcast(IntPtr nw, int priority, int reliability, int channel) { }

	// RVA: 0x22CCF20 Offset: 0x22CB520 VA: 0x1822CCF20
	public static extern uint NETSND_Send(IntPtr nw, ulong connectionID, int priority, int reliability, int channel) { }

	// RVA: 0x22CD170 Offset: 0x22CB770 VA: 0x1822CD170
	public static extern void NET_CloseConnection(IntPtr nw, ulong connectionID) { }

	// RVA: 0x22CD2F0 Offset: 0x22CB8F0 VA: 0x1822CD2F0
	public static extern IntPtr NET_GetAddress(IntPtr nw, ulong connectionID) { }

	// RVA: 0x22CD5B0 Offset: 0x22CBBB0 VA: 0x1822CD5B0
	public static extern IntPtr NET_GetStatisticsString(IntPtr nw, ulong connectionID) { }

	// RVA: 0x22CD640 Offset: 0x22CBC40 VA: 0x1822CD640
	public static extern bool NET_GetStatistics(IntPtr nw, ulong connectionID, ref Native.RaknetStats data, int dataLength) { }

	// RVA: 0x22CD380 Offset: 0x22CB980 VA: 0x1822CD380
	public static extern int NET_GetAveragePing(IntPtr nw, ulong connectionID) { }

	// RVA: 0x22CD410 Offset: 0x22CBA10 VA: 0x1822CD410
	public static extern int NET_GetLastPing(IntPtr nw, ulong connectionID) { }

	// RVA: 0x22CD4A0 Offset: 0x22CBAA0 VA: 0x1822CD4A0
	public static extern int NET_GetLowestPing(IntPtr nw, ulong connectionID) { }

	// RVA: 0x22CD7F0 Offset: 0x22CBDF0 VA: 0x1822CD7F0
	public static extern void NET_SendMessage(IntPtr nw, byte* data, int length, uint adr, ushort port) { }

	// RVA: 0x22CCEA0 Offset: 0x22CB4A0 VA: 0x1822CCEA0
	public static extern float NETSND_ReadCompressedFloat(IntPtr nw) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public enum Native.Metrics // TypeDefIndex: 7324
{	// Fields
	public int value__; // 0x0
	public const Native.Metrics USER_MESSAGE_BYTES_PUSHED = 0;
	public const Native.Metrics USER_MESSAGE_BYTES_SENT = 1;
	public const Native.Metrics USER_MESSAGE_BYTES_RESENT = 2;
	public const Native.Metrics USER_MESSAGE_BYTES_RECEIVED_PROCESSED = 3;
	public const Native.Metrics USER_MESSAGE_BYTES_RECEIVED_IGNORED = 4;
	public const Native.Metrics ACTUAL_BYTES_SENT = 5;
	public const Native.Metrics ACTUAL_BYTES_RECEIVED = 6;
	public const Native.Metrics RNS_PER_SECOND_METRICS_COUNT = 7;

}

public enum Native.PacketPriority // TypeDefIndex: 7325
{	// Fields
	public int value__; // 0x0
	public const Native.PacketPriority IMMEDIATE_PRIORITY = 0;
	public const Native.PacketPriority HIGH_PRIORITY = 1;
	public const Native.PacketPriority MEDIUM_PRIORITY = 2;
	public const Native.PacketPriority LOW_PRIORITY = 3;
	public const Native.PacketPriority NUMBER_OF_PRIORITIES = 4;

}

public struct Native.RaknetStats // TypeDefIndex: 7326
{	// Fields
	[FixedBufferAttribute] // RVA: 0x97330 Offset: 0x96730 VA: 0x180097330
	public Native.RaknetStats.<valueOverLastSecond>e__FixedBuffer valueOverLastSecond; // 0x0
	[FixedBufferAttribute] // RVA: 0x976B0 Offset: 0x96AB0 VA: 0x1800976B0
	public Native.RaknetStats.<runningTotal>e__FixedBuffer runningTotal; // 0x38
	public ulong connectionStartTime; // 0x70
	public byte isLimitedByCongestionControl; // 0x78
	public ulong BPSLimitByCongestionControl; // 0x80
	public byte isLimitedByOutgoingBandwidthLimit; // 0x88
	public ulong BPSLimitByOutgoingBandwidthLimit; // 0x90
	[FixedBufferAttribute] // RVA: 0x97810 Offset: 0x96C10 VA: 0x180097810
	public Native.RaknetStats.<messageInSendBuffer>e__FixedBuffer messageInSendBuffer; // 0x98
	[FixedBufferAttribute] // RVA: 0x97940 Offset: 0x96D40 VA: 0x180097940
	public Native.RaknetStats.<bytesInSendBuffer>e__FixedBuffer bytesInSendBuffer; // 0xA8
	public uint messagesInResendBuffer; // 0xC8
	public ulong bytesInResendBuffer; // 0xD0
	public float packetlossLastSecond; // 0xD8
	public float packetlossTotal; // 0xDC

}

public struct Native.RaknetStats.<valueOverLastSecond>e__FixedBuffer // TypeDefIndex: 7327
{	// Fields
	public ulong FixedElementField; // 0x0

}

public struct Native.RaknetStats.<runningTotal>e__FixedBuffer // TypeDefIndex: 7328
{	// Fields
	public ulong FixedElementField; // 0x0

}

public struct Native.RaknetStats.<messageInSendBuffer>e__FixedBuffer // TypeDefIndex: 7329
{	// Fields
	public uint FixedElementField; // 0x0

}

public struct Native.RaknetStats.<bytesInSendBuffer>e__FixedBuffer // TypeDefIndex: 7330
{	// Fields
	public double FixedElementField; // 0x0

}

