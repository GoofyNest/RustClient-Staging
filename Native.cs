internal static class Native // TypeDefIndex: 4578
{	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22F6A30 Offset: 0x22F5030 VA: 0x1822F6A30
	public static void YGNodeMeasureInvoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode, IntPtr returnValueAddress) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22F6870 Offset: 0x22F4E70 VA: 0x1822F6870
	public static void YGNodeBaselineInvoke(YogaNode node, float width, float height, IntPtr returnValueAddress) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x22F6970 Offset: 0x22F4F70 VA: 0x1822F6970
	public static float YGNodeLayoutGetLeft(IntPtr node) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x22F69B0 Offset: 0x22F4FB0 VA: 0x1822F69B0
	public static float YGNodeLayoutGetTop(IntPtr node) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x22F69F0 Offset: 0x22F4FF0 VA: 0x1822F69F0
	public static float YGNodeLayoutGetWidth(IntPtr node) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x22F6930 Offset: 0x22F4F30 VA: 0x1822F6930
	public static float YGNodeLayoutGetHeight(IntPtr node) { }

}

public class Native // TypeDefIndex: 7323
{
// Namespace: Facepunch.Network.Raknet
[SuppressUnmanagedCodeSecurityAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
public class Native // TypeDefIndex: 7323
	// Methods

	// RVA: 0x22CD380 Offset: 0x22CB980 VA: 0x1822CD380
	public static extern IntPtr NET_Create() { }

	// RVA: 0x22CD300 Offset: 0x22CB900 VA: 0x1822CD300
	public static extern void NET_Close(IntPtr nw) { }

	// RVA: 0x22CD9B0 Offset: 0x22CBFB0 VA: 0x1822CD9B0
	public static extern int NET_StartClient(IntPtr nw, string hostName, int port, int retries, int retryDelay, int timeout) { }

	// RVA: 0x22CDA90 Offset: 0x22CC090 VA: 0x1822CDA90
	public static extern int NET_StartServer(IntPtr nw, string ip, int port, int maxConnections) { }

	// RVA: 0x22CD7F0 Offset: 0x22CBDF0 VA: 0x1822CD7F0
	public static extern IntPtr NET_LastStartupError(IntPtr nw) { }

	// RVA: 0x22CD630 Offset: 0x22CBC30 VA: 0x1822CD630
	public static extern uint NET_GetReceiveBufferSize(IntPtr nw) { }

	// RVA: 0x22CD870 Offset: 0x22CBE70 VA: 0x1822CD870
	public static extern bool NET_Receive(IntPtr nw) { }

	// RVA: 0x22CCB50 Offset: 0x22CB150 VA: 0x1822CCB50
	public static extern ulong NETRCV_GUID(IntPtr nw) { }

	// RVA: 0x22CCAD0 Offset: 0x22CB0D0 VA: 0x1822CCAD0
	public static extern uint NETRCV_Address(IntPtr nw) { }

	// RVA: 0x22CCC50 Offset: 0x22CB250 VA: 0x1822CCC50
	public static extern uint NETRCV_Port(IntPtr nw) { }

	// RVA: 0x22CCCD0 Offset: 0x22CB2D0 VA: 0x1822CCCD0
	public static extern IntPtr NETRCV_RawData(IntPtr nw) { }

	// RVA: 0x22CCBD0 Offset: 0x22CB1D0 VA: 0x1822CCBD0
	public static extern int NETRCV_LengthBits(IntPtr nw) { }

	// RVA: 0x22CCE80 Offset: 0x22CB480 VA: 0x1822CCE80
	public static extern int NETRCV_UnreadBits(IntPtr nw) { }

	// RVA: 0x22CCD50 Offset: 0x22CB350 VA: 0x1822CCD50
	public static extern bool NETRCV_ReadBytes(IntPtr nw, byte* data, int length) { }

	// RVA: 0x22CCDF0 Offset: 0x22CB3F0 VA: 0x1822CCDF0
	public static extern void NETRCV_SetReadPointer(IntPtr nw, int bitsOffset) { }

	// RVA: 0x22CD150 Offset: 0x22CB750 VA: 0x1822CD150
	public static extern void NETSND_Start(IntPtr nw) { }

	// RVA: 0x22CD1D0 Offset: 0x22CB7D0 VA: 0x1822CD1D0
	public static extern void NETSND_WriteBytes(IntPtr nw, byte* data, int length) { }

	// RVA: 0x22CD0D0 Offset: 0x22CB6D0 VA: 0x1822CD0D0
	public static extern uint NETSND_Size(IntPtr nw) { }

	// RVA: 0x22CCF00 Offset: 0x22CB500 VA: 0x1822CCF00
	public static extern uint NETSND_Broadcast(IntPtr nw, int priority, int reliability, int channel) { }

	// RVA: 0x22CD020 Offset: 0x22CB620 VA: 0x1822CD020
	public static extern uint NETSND_Send(IntPtr nw, ulong connectionID, int priority, int reliability, int channel) { }

	// RVA: 0x22CD270 Offset: 0x22CB870 VA: 0x1822CD270
	public static extern void NET_CloseConnection(IntPtr nw, ulong connectionID) { }

	// RVA: 0x22CD3F0 Offset: 0x22CB9F0 VA: 0x1822CD3F0
	public static extern IntPtr NET_GetAddress(IntPtr nw, ulong connectionID) { }

	// RVA: 0x22CD6B0 Offset: 0x22CBCB0 VA: 0x1822CD6B0
	public static extern IntPtr NET_GetStatisticsString(IntPtr nw, ulong connectionID) { }

	// RVA: 0x22CD740 Offset: 0x22CBD40 VA: 0x1822CD740
	public static extern bool NET_GetStatistics(IntPtr nw, ulong connectionID, ref Native.RaknetStats data, int dataLength) { }

	// RVA: 0x22CD480 Offset: 0x22CBA80 VA: 0x1822CD480
	public static extern int NET_GetAveragePing(IntPtr nw, ulong connectionID) { }

	// RVA: 0x22CD510 Offset: 0x22CBB10 VA: 0x1822CD510
	public static extern int NET_GetLastPing(IntPtr nw, ulong connectionID) { }

	// RVA: 0x22CD5A0 Offset: 0x22CBBA0 VA: 0x1822CD5A0
	public static extern int NET_GetLowestPing(IntPtr nw, ulong connectionID) { }

	// RVA: 0x22CD8F0 Offset: 0x22CBEF0 VA: 0x1822CD8F0
	public static extern void NET_SendMessage(IntPtr nw, byte* data, int length, uint adr, ushort port) { }

	// RVA: 0x22CCFA0 Offset: 0x22CB5A0 VA: 0x1822CCFA0
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
	[FixedBufferAttribute] // RVA: 0x97500 Offset: 0x96900 VA: 0x180097500
	public Native.RaknetStats.<valueOverLastSecond>e__FixedBuffer valueOverLastSecond; // 0x0
	[FixedBufferAttribute] // RVA: 0x97740 Offset: 0x96B40 VA: 0x180097740
	public Native.RaknetStats.<runningTotal>e__FixedBuffer runningTotal; // 0x38
	public ulong connectionStartTime; // 0x70
	public byte isLimitedByCongestionControl; // 0x78
	public ulong BPSLimitByCongestionControl; // 0x80
	public byte isLimitedByOutgoingBandwidthLimit; // 0x88
	public ulong BPSLimitByOutgoingBandwidthLimit; // 0x90
	[FixedBufferAttribute] // RVA: 0x97870 Offset: 0x96C70 VA: 0x180097870
	public Native.RaknetStats.<messageInSendBuffer>e__FixedBuffer messageInSendBuffer; // 0x98
	[FixedBufferAttribute] // RVA: 0x979D0 Offset: 0x96DD0 VA: 0x1800979D0
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

