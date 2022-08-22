internal class Peer // TypeDefIndex: 7334
{	// Fields
	private IntPtr ptr; // 0x10
	private static byte[] ByteBuffer; // 0x0

	// Properties
	public virtual ulong incomingGUID { get; }
	public virtual uint incomingAddressInt { get; }
	public virtual uint incomingPort { get; }
	public string incomingAddress { get; }
	public virtual int incomingBits { get; }
	public virtual int incomingBitsUnread { get; }
	public virtual int incomingBytes { get; }
	public virtual int incomingBytesUnread { get; }

	// Methods

	// RVA: 0x22CE150 Offset: 0x22CC750 VA: 0x1822CE150
	public static Peer CreateServer(string ip, int port, int maxConnections) { }

	// RVA: 0x22CDC80 Offset: 0x22CC280 VA: 0x1822CDC80
	public static Peer CreateConnection(string hostname, int port, int retries, int retryDelay, int timeout) { }

	// RVA: 0x22CDBC0 Offset: 0x22CC1C0 VA: 0x1822CDBC0
	public void Close() { }

	// RVA: 0x22CEF20 Offset: 0x22CD520 VA: 0x1822CEF20
	public uint PendingReceiveCount() { }

	// RVA: 0x22CF360 Offset: 0x22CD960 VA: 0x1822CF360
	public bool Receive() { }

	// RVA: 0x22CFE30 Offset: 0x22CE430 VA: 0x1822CFE30 Slot: 4
	public virtual ulong get_incomingGUID() { }

	// RVA: 0x22CFB20 Offset: 0x22CE120 VA: 0x1822CFB20 Slot: 5
	public virtual uint get_incomingAddressInt() { }

	// RVA: 0x22CFEC0 Offset: 0x22CE4C0 VA: 0x1822CFEC0 Slot: 6
	public virtual uint get_incomingPort() { }

	// RVA: 0x22CFBB0 Offset: 0x22CE1B0 VA: 0x1822CFBB0
	public string get_incomingAddress() { }

	// RVA: 0x22CFD40 Offset: 0x22CE340 VA: 0x1822CFD40 Slot: 7
	public virtual int get_incomingBits() { }

	// RVA: 0x22CFCB0 Offset: 0x22CE2B0 VA: 0x1822CFCB0 Slot: 8
	public virtual int get_incomingBitsUnread() { }

	// RVA: 0x22CFE00 Offset: 0x22CE400 VA: 0x1822CFE00 Slot: 9
	public virtual int get_incomingBytes() { }

	// RVA: 0x22CFDD0 Offset: 0x22CE3D0 VA: 0x1822CFDD0 Slot: 10
	public virtual int get_incomingBytesUnread() { }

	// RVA: 0x22CF770 Offset: 0x22CDD70 VA: 0x1822CF770 Slot: 11
	public virtual void SetReadPos(int bitsOffset) { }

	// RVA: 0x22CF2B0 Offset: 0x22CD8B0 VA: 0x1822CF2B0 Slot: 12
	protected virtual bool Read(byte* data, int length) { }

	// RVA: 0x22CF260 Offset: 0x22CD860 VA: 0x1822CF260
	public int ReadBytes(byte[] buffer, int offset, int length) { }

	// RVA: 0x22CF070 Offset: 0x22CD670 VA: 0x1822CF070
	public byte ReadByte() { }

	// RVA: 0x22CEFE0 Offset: 0x22CD5E0 VA: 0x1822CEFE0 Slot: 13
	public virtual IntPtr RawData() { }

	// RVA: 0x22CF160 Offset: 0x22CD760 VA: 0x1822CF160
	public int ReadBytes(MemoryStream memoryStream, int length) { }

	// RVA: 0x22CF510 Offset: 0x22CDB10 VA: 0x1822CF510 Slot: 14
	public virtual void SendStart() { }

	// RVA: 0x22CF8C0 Offset: 0x22CDEC0 VA: 0x1822CF8C0
	public void WriteByte(byte val) { }

	// RVA: 0x22CF940 Offset: 0x22CDF40 VA: 0x1822CF940
	public void WriteBytes(byte[] val, int offset, int length) { }

	// RVA: 0x22CF8F0 Offset: 0x22CDEF0 VA: 0x1822CF8F0
	public void WriteBytes(byte[] val) { }

	// RVA: 0x22CF980 Offset: 0x22CDF80 VA: 0x1822CF980
	public void WriteBytes(MemoryStream stream) { }

	// RVA: 0x22CFA10 Offset: 0x22CE010 VA: 0x1822CFA10 Slot: 15
	protected virtual void Write(byte* data, int size) { }

	// RVA: 0x22CF420 Offset: 0x22CDA20 VA: 0x1822CF420 Slot: 16
	public virtual uint SendBroadcast(Priority priority, SendMethod reliability, sbyte channel) { }

	// RVA: 0x22CF5A0 Offset: 0x22CDBA0 VA: 0x1822CF5A0 Slot: 17
	public virtual uint SendTo(ulong guid, Priority priority, SendMethod reliability, sbyte channel) { }

	// RVA: 0x22CF6A0 Offset: 0x22CDCA0 VA: 0x1822CF6A0
	public void SendUnconnectedMessage(byte* data, int length, uint adr, ushort port) { }

	// RVA: 0x22CE550 Offset: 0x22CCB50 VA: 0x1822CE550
	public string GetAddress(ulong guid) { }

	// RVA: 0x22CF810 Offset: 0x22CDE10 VA: 0x1822CF810
	private static string StringFromPointer(IntPtr p) { }

	// RVA: 0x22CF8B0 Offset: 0x22CDEB0 VA: 0x1822CF8B0
	public int ToRaknetPriority(Priority priority) { }

	// RVA: 0x22CF890 Offset: 0x22CDE90 VA: 0x1822CF890
	public int ToRaknetPacketReliability(SendMethod reliability) { }

	// RVA: 0x22CEE60 Offset: 0x22CD460 VA: 0x1822CEE60
	public void Kick(Connection connection) { }

	// RVA: 0x22CDB50 Offset: 0x22CC150 VA: 0x1822CDB50 Slot: 18
	protected virtual void Check() { }

	// RVA: 0x22CEA00 Offset: 0x22CD000 VA: 0x1822CEA00 Slot: 19
	public virtual string GetStatisticsString(ulong guid) { }

	// RVA: 0x22CE640 Offset: 0x22CCC40 VA: 0x1822CE640 Slot: 20
	public virtual int GetPingAverage(ulong guid) { }

	// RVA: 0x22CE6E0 Offset: 0x22CCCE0 VA: 0x1822CE6E0 Slot: 21
	public virtual int GetPingLast(ulong guid) { }

	// RVA: 0x22CE780 Offset: 0x22CCD80 VA: 0x1822CE780 Slot: 22
	public virtual int GetPingLowest(ulong guid) { }

	// RVA: 0x22CED10 Offset: 0x22CD310 VA: 0x1822CED10 Slot: 23
	public virtual Native.RaknetStats GetStatistics(ulong guid) { }

	// RVA: 0x22CE820 Offset: 0x22CCE20 VA: 0x1822CE820 Slot: 24
	public virtual ulong GetStat(Connection connection, BaseNetwork.StatTypeLong type) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x22CFAD0 Offset: 0x22CE0D0 VA: 0x1822CFAD0
	private static void .cctor() { }

}

public enum Peer.PacketPriority // TypeDefIndex: 7335
{	// Fields
	public int value__; // 0x0
	public const Peer.PacketPriority IMMEDIATE_PRIORITY = 0;
	public const Peer.PacketPriority HIGH_PRIORITY = 1;
	public const Peer.PacketPriority MEDIUM_PRIORITY = 2;
	public const Peer.PacketPriority LOW_PRIORITY = 3;

}

public enum Peer.PacketReliability // TypeDefIndex: 7336
{	// Fields
	public int value__; // 0x0
	public const Peer.PacketReliability UNRELIABLE = 0;
	public const Peer.PacketReliability UNRELIABLE_SEQUENCED = 1;
	public const Peer.PacketReliability RELIABLE = 2;
	public const Peer.PacketReliability RELIABLE_ORDERED = 3;
	public const Peer.PacketReliability RELIABLE_SEQUENCED = 4;

}

