internal static class Native // TypeDefIndex: 4578
{	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22F7250 Offset: 0x22F5850 VA: 0x1822F7250
	public static void YGNodeMeasureInvoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode, IntPtr returnValueAddress) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22F7090 Offset: 0x22F5690 VA: 0x1822F7090
	public static void YGNodeBaselineInvoke(YogaNode node, float width, float height, IntPtr returnValueAddress) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x22F7190 Offset: 0x22F5790 VA: 0x1822F7190
	public static float YGNodeLayoutGetLeft(IntPtr node) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x22F71D0 Offset: 0x22F57D0 VA: 0x1822F71D0
	public static float YGNodeLayoutGetTop(IntPtr node) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x22F7210 Offset: 0x22F5810 VA: 0x1822F7210
	public static float YGNodeLayoutGetWidth(IntPtr node) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x22F7150 Offset: 0x22F5750 VA: 0x1822F7150
	public static float YGNodeLayoutGetHeight(IntPtr node) { }

}

public class Native // TypeDefIndex: 7323
{
// Namespace: Facepunch.Network.Raknet
[SuppressUnmanagedCodeSecurityAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
public class Native // TypeDefIndex: 7323
	// Methods

	// RVA: 0x22CDBA0 Offset: 0x22CC1A0 VA: 0x1822CDBA0
	public static extern IntPtr NET_Create() { }

	// RVA: 0x22CDB20 Offset: 0x22CC120 VA: 0x1822CDB20
	public static extern void NET_Close(IntPtr nw) { }

	// RVA: 0x22CE1D0 Offset: 0x22CC7D0 VA: 0x1822CE1D0
	public static extern int NET_StartClient(IntPtr nw, string hostName, int port, int retries, int retryDelay, int timeout) { }

	// RVA: 0x22CE2B0 Offset: 0x22CC8B0 VA: 0x1822CE2B0
	public static extern int NET_StartServer(IntPtr nw, string ip, int port, int maxConnections) { }

	// RVA: 0x22CE010 Offset: 0x22CC610 VA: 0x1822CE010
	public static extern IntPtr NET_LastStartupError(IntPtr nw) { }

	// RVA: 0x22CDE50 Offset: 0x22CC450 VA: 0x1822CDE50
	public static extern uint NET_GetReceiveBufferSize(IntPtr nw) { }

	// RVA: 0x22CE090 Offset: 0x22CC690 VA: 0x1822CE090
	public static extern bool NET_Receive(IntPtr nw) { }

	// RVA: 0x22CD370 Offset: 0x22CB970 VA: 0x1822CD370
	public static extern ulong NETRCV_GUID(IntPtr nw) { }

	// RVA: 0x22CD2F0 Offset: 0x22CB8F0 VA: 0x1822CD2F0
	public static extern uint NETRCV_Address(IntPtr nw) { }

	// RVA: 0x22CD470 Offset: 0x22CBA70 VA: 0x1822CD470
	public static extern uint NETRCV_Port(IntPtr nw) { }

	// RVA: 0x22CD4F0 Offset: 0x22CBAF0 VA: 0x1822CD4F0
	public static extern IntPtr NETRCV_RawData(IntPtr nw) { }

	// RVA: 0x22CD3F0 Offset: 0x22CB9F0 VA: 0x1822CD3F0
	public static extern int NETRCV_LengthBits(IntPtr nw) { }

	// RVA: 0x22CD6A0 Offset: 0x22CBCA0 VA: 0x1822CD6A0
	public static extern int NETRCV_UnreadBits(IntPtr nw) { }

	// RVA: 0x22CD570 Offset: 0x22CBB70 VA: 0x1822CD570
	public static extern bool NETRCV_ReadBytes(IntPtr nw, byte* data, int length) { }

	// RVA: 0x22CD610 Offset: 0x22CBC10 VA: 0x1822CD610
	public static extern void NETRCV_SetReadPointer(IntPtr nw, int bitsOffset) { }

	// RVA: 0x22CD970 Offset: 0x22CBF70 VA: 0x1822CD970
	public static extern void NETSND_Start(IntPtr nw) { }

	// RVA: 0x22CD9F0 Offset: 0x22CBFF0 VA: 0x1822CD9F0
	public static extern void NETSND_WriteBytes(IntPtr nw, byte* data, int length) { }

	// RVA: 0x22CD8F0 Offset: 0x22CBEF0 VA: 0x1822CD8F0
	public static extern uint NETSND_Size(IntPtr nw) { }

	// RVA: 0x22CD720 Offset: 0x22CBD20 VA: 0x1822CD720
	public static extern uint NETSND_Broadcast(IntPtr nw, int priority, int reliability, int channel) { }

	// RVA: 0x22CD840 Offset: 0x22CBE40 VA: 0x1822CD840
	public static extern uint NETSND_Send(IntPtr nw, ulong connectionID, int priority, int reliability, int channel) { }

	// RVA: 0x22CDA90 Offset: 0x22CC090 VA: 0x1822CDA90
	public static extern void NET_CloseConnection(IntPtr nw, ulong connectionID) { }

	// RVA: 0x22CDC10 Offset: 0x22CC210 VA: 0x1822CDC10
	public static extern IntPtr NET_GetAddress(IntPtr nw, ulong connectionID) { }

	// RVA: 0x22CDED0 Offset: 0x22CC4D0 VA: 0x1822CDED0
	public static extern IntPtr NET_GetStatisticsString(IntPtr nw, ulong connectionID) { }

	// RVA: 0x22CDF60 Offset: 0x22CC560 VA: 0x1822CDF60
	public static extern bool NET_GetStatistics(IntPtr nw, ulong connectionID, ref Native.RaknetStats data, int dataLength) { }

	// RVA: 0x22CDCA0 Offset: 0x22CC2A0 VA: 0x1822CDCA0
	public static extern int NET_GetAveragePing(IntPtr nw, ulong connectionID) { }

	// RVA: 0x22CDD30 Offset: 0x22CC330 VA: 0x1822CDD30
	public static extern int NET_GetLastPing(IntPtr nw, ulong connectionID) { }

	// RVA: 0x22CDDC0 Offset: 0x22CC3C0 VA: 0x1822CDDC0
	public static extern int NET_GetLowestPing(IntPtr nw, ulong connectionID) { }

	// RVA: 0x22CE110 Offset: 0x22CC710 VA: 0x1822CE110
	public static extern void NET_SendMessage(IntPtr nw, byte* data, int length, uint adr, ushort port) { }

	// RVA: 0x22CD7C0 Offset: 0x22CBDC0 VA: 0x1822CD7C0
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

