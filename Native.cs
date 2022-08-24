internal static class Native // TypeDefIndex: 4578
{
	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static void YGNodeMeasureInvoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode, IntPtr returnValueAddress) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static void YGNodeBaselineInvoke(YogaNode node, float width, float height, IntPtr returnValueAddress) { }

	[FreeFunctionAttribute] // RVA: 0x7A550 Offset: 0x79950 VA: 0x18007A550
	public static float YGNodeLayoutGetLeft(IntPtr node) { }

	[FreeFunctionAttribute] // RVA: 0x7A550 Offset: 0x79950 VA: 0x18007A550
	public static float YGNodeLayoutGetTop(IntPtr node) { }

	[FreeFunctionAttribute] // RVA: 0x7A550 Offset: 0x79950 VA: 0x18007A550
	public static float YGNodeLayoutGetWidth(IntPtr node) { }

	[FreeFunctionAttribute] // RVA: 0x7A550 Offset: 0x79950 VA: 0x18007A550
	public static float YGNodeLayoutGetHeight(IntPtr node) { }

}

public class Native // TypeDefIndex: 7323
{
[SuppressUnmanagedCodeSecurityAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
public class Native // TypeDefIndex: 7323

	public static extern IntPtr NET_Create() { }

	public static extern void NET_Close(IntPtr nw) { }

	public static extern int NET_StartClient(IntPtr nw, string hostName, int port, int retries, int retryDelay, int timeout) { }

	public static extern int NET_StartServer(IntPtr nw, string ip, int port, int maxConnections) { }

	public static extern IntPtr NET_LastStartupError(IntPtr nw) { }

	public static extern uint NET_GetReceiveBufferSize(IntPtr nw) { }

	public static extern bool NET_Receive(IntPtr nw) { }

	public static extern ulong NETRCV_GUID(IntPtr nw) { }

	public static extern uint NETRCV_Address(IntPtr nw) { }

	public static extern uint NETRCV_Port(IntPtr nw) { }

	public static extern IntPtr NETRCV_RawData(IntPtr nw) { }

	public static extern int NETRCV_LengthBits(IntPtr nw) { }

	public static extern int NETRCV_UnreadBits(IntPtr nw) { }

	public static extern bool NETRCV_ReadBytes(IntPtr nw, byte* data, int length) { }

	public static extern void NETRCV_SetReadPointer(IntPtr nw, int bitsOffset) { }

	public static extern void NETSND_Start(IntPtr nw) { }

	public static extern void NETSND_WriteBytes(IntPtr nw, byte* data, int length) { }

	public static extern uint NETSND_Size(IntPtr nw) { }

	public static extern uint NETSND_Broadcast(IntPtr nw, int priority, int reliability, int channel) { }

	public static extern uint NETSND_Send(IntPtr nw, ulong connectionID, int priority, int reliability, int channel) { }

	public static extern void NET_CloseConnection(IntPtr nw, ulong connectionID) { }

	public static extern IntPtr NET_GetAddress(IntPtr nw, ulong connectionID) { }

	public static extern IntPtr NET_GetStatisticsString(IntPtr nw, ulong connectionID) { }

	public static extern bool NET_GetStatistics(IntPtr nw, ulong connectionID, ref Native.RaknetStats data, int dataLength) { }

	public static extern int NET_GetAveragePing(IntPtr nw, ulong connectionID) { }

	public static extern int NET_GetLastPing(IntPtr nw, ulong connectionID) { }

	public static extern int NET_GetLowestPing(IntPtr nw, ulong connectionID) { }

	public static extern void NET_SendMessage(IntPtr nw, byte* data, int length, uint adr, ushort port) { }

	public static extern float NETSND_ReadCompressedFloat(IntPtr nw) { }

	public void .ctor() { }

}

public enum Native.Metrics // TypeDefIndex: 7324
{	public int value__; // 0x0
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
{	public int value__; // 0x0
	public const Native.PacketPriority IMMEDIATE_PRIORITY = 0;
	public const Native.PacketPriority HIGH_PRIORITY = 1;
	public const Native.PacketPriority MEDIUM_PRIORITY = 2;
	public const Native.PacketPriority LOW_PRIORITY = 3;
	public const Native.PacketPriority NUMBER_OF_PRIORITIES = 4;

}

public struct Native.RaknetStats // TypeDefIndex: 7326
{	[FixedBufferAttribute] // RVA: 0x975C0 Offset: 0x969C0 VA: 0x1800975C0
	public Native.RaknetStats.<valueOverLastSecond>e__FixedBuffer valueOverLastSecond; // 0x0
	[FixedBufferAttribute] // RVA: 0x97830 Offset: 0x96C30 VA: 0x180097830
	public Native.RaknetStats.<runningTotal>e__FixedBuffer runningTotal; // 0x38
	public ulong connectionStartTime; // 0x70
	public byte isLimitedByCongestionControl; // 0x78
	public ulong BPSLimitByCongestionControl; // 0x80
	public byte isLimitedByOutgoingBandwidthLimit; // 0x88
	public ulong BPSLimitByOutgoingBandwidthLimit; // 0x90
	[FixedBufferAttribute] // RVA: 0x979C0 Offset: 0x96DC0 VA: 0x1800979C0
	public Native.RaknetStats.<messageInSendBuffer>e__FixedBuffer messageInSendBuffer; // 0x98
	[FixedBufferAttribute] // RVA: 0x97B30 Offset: 0x96F30 VA: 0x180097B30
	public Native.RaknetStats.<bytesInSendBuffer>e__FixedBuffer bytesInSendBuffer; // 0xA8
	public uint messagesInResendBuffer; // 0xC8
	public ulong bytesInResendBuffer; // 0xD0
	public float packetlossLastSecond; // 0xD8
	public float packetlossTotal; // 0xDC

}

public struct Native.RaknetStats.<valueOverLastSecond>e__FixedBuffer // TypeDefIndex: 7327
{	public ulong FixedElementField; // 0x0

}

public struct Native.RaknetStats.<runningTotal>e__FixedBuffer // TypeDefIndex: 7328
{	public ulong FixedElementField; // 0x0

}

public struct Native.RaknetStats.<messageInSendBuffer>e__FixedBuffer // TypeDefIndex: 7329
{	public uint FixedElementField; // 0x0

}

public struct Native.RaknetStats.<bytesInSendBuffer>e__FixedBuffer // TypeDefIndex: 7330
{	public double FixedElementField; // 0x0

}

