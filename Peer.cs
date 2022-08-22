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

	// RVA: 0x22CDE90 Offset: 0x22CC490 VA: 0x1822CDE90
	public static Peer CreateServer(string ip, int port, int maxConnections) { }

	// RVA: 0x22CD9C0 Offset: 0x22CBFC0 VA: 0x1822CD9C0
	public static Peer CreateConnection(string hostname, int port, int retries, int retryDelay, int timeout) { }

	// RVA: 0x22CD900 Offset: 0x22CBF00 VA: 0x1822CD900
	public void Close() { }

	// RVA: 0x22CEC60 Offset: 0x22CD260 VA: 0x1822CEC60
	public uint PendingReceiveCount() { }

	// RVA: 0x22CF0A0 Offset: 0x22CD6A0 VA: 0x1822CF0A0
	public bool Receive() { }

	// RVA: 0x22CFB70 Offset: 0x22CE170 VA: 0x1822CFB70 Slot: 4
	public virtual ulong get_incomingGUID() { }

	// RVA: 0x22CF860 Offset: 0x22CDE60 VA: 0x1822CF860 Slot: 5
	public virtual uint get_incomingAddressInt() { }

	// RVA: 0x22CFC00 Offset: 0x22CE200 VA: 0x1822CFC00 Slot: 6
	public virtual uint get_incomingPort() { }

	// RVA: 0x22CF8F0 Offset: 0x22CDEF0 VA: 0x1822CF8F0
	public string get_incomingAddress() { }

	// RVA: 0x22CFA80 Offset: 0x22CE080 VA: 0x1822CFA80 Slot: 7
	public virtual int get_incomingBits() { }

	// RVA: 0x22CF9F0 Offset: 0x22CDFF0 VA: 0x1822CF9F0 Slot: 8
	public virtual int get_incomingBitsUnread() { }

	// RVA: 0x22CFB40 Offset: 0x22CE140 VA: 0x1822CFB40 Slot: 9
	public virtual int get_incomingBytes() { }

	// RVA: 0x22CFB10 Offset: 0x22CE110 VA: 0x1822CFB10 Slot: 10
	public virtual int get_incomingBytesUnread() { }

	// RVA: 0x22CF4B0 Offset: 0x22CDAB0 VA: 0x1822CF4B0 Slot: 11
	public virtual void SetReadPos(int bitsOffset) { }

	// RVA: 0x22CEFF0 Offset: 0x22CD5F0 VA: 0x1822CEFF0 Slot: 12
	protected virtual bool Read(byte* data, int length) { }

	// RVA: 0x22CEFA0 Offset: 0x22CD5A0 VA: 0x1822CEFA0
	public int ReadBytes(byte[] buffer, int offset, int length) { }

	// RVA: 0x22CEDB0 Offset: 0x22CD3B0 VA: 0x1822CEDB0
	public byte ReadByte() { }

	// RVA: 0x22CED20 Offset: 0x22CD320 VA: 0x1822CED20 Slot: 13
	public virtual IntPtr RawData() { }

	// RVA: 0x22CEEA0 Offset: 0x22CD4A0 VA: 0x1822CEEA0
	public int ReadBytes(MemoryStream memoryStream, int length) { }

	// RVA: 0x22CF250 Offset: 0x22CD850 VA: 0x1822CF250 Slot: 14
	public virtual void SendStart() { }

	// RVA: 0x22CF600 Offset: 0x22CDC00 VA: 0x1822CF600
	public void WriteByte(byte val) { }

	// RVA: 0x22CF680 Offset: 0x22CDC80 VA: 0x1822CF680
	public void WriteBytes(byte[] val, int offset, int length) { }

	// RVA: 0x22CF630 Offset: 0x22CDC30 VA: 0x1822CF630
	public void WriteBytes(byte[] val) { }

	// RVA: 0x22CF6C0 Offset: 0x22CDCC0 VA: 0x1822CF6C0
	public void WriteBytes(MemoryStream stream) { }

	// RVA: 0x22CF750 Offset: 0x22CDD50 VA: 0x1822CF750 Slot: 15
	protected virtual void Write(byte* data, int size) { }

	// RVA: 0x22CF160 Offset: 0x22CD760 VA: 0x1822CF160 Slot: 16
	public virtual uint SendBroadcast(Priority priority, SendMethod reliability, sbyte channel) { }

	// RVA: 0x22CF2E0 Offset: 0x22CD8E0 VA: 0x1822CF2E0 Slot: 17
	public virtual uint SendTo(ulong guid, Priority priority, SendMethod reliability, sbyte channel) { }

	// RVA: 0x22CF3E0 Offset: 0x22CD9E0 VA: 0x1822CF3E0
	public void SendUnconnectedMessage(byte* data, int length, uint adr, ushort port) { }

	// RVA: 0x22CE290 Offset: 0x22CC890 VA: 0x1822CE290
	public string GetAddress(ulong guid) { }

	// RVA: 0x22CF550 Offset: 0x22CDB50 VA: 0x1822CF550
	private static string StringFromPointer(IntPtr p) { }

	// RVA: 0x22CF5F0 Offset: 0x22CDBF0 VA: 0x1822CF5F0
	public int ToRaknetPriority(Priority priority) { }

	// RVA: 0x22CF5D0 Offset: 0x22CDBD0 VA: 0x1822CF5D0
	public int ToRaknetPacketReliability(SendMethod reliability) { }

	// RVA: 0x22CEBA0 Offset: 0x22CD1A0 VA: 0x1822CEBA0
	public void Kick(Connection connection) { }

	// RVA: 0x22CD890 Offset: 0x22CBE90 VA: 0x1822CD890 Slot: 18
	protected virtual void Check() { }

	// RVA: 0x22CE740 Offset: 0x22CCD40 VA: 0x1822CE740 Slot: 19
	public virtual string GetStatisticsString(ulong guid) { }

	// RVA: 0x22CE380 Offset: 0x22CC980 VA: 0x1822CE380 Slot: 20
	public virtual int GetPingAverage(ulong guid) { }

	// RVA: 0x22CE420 Offset: 0x22CCA20 VA: 0x1822CE420 Slot: 21
	public virtual int GetPingLast(ulong guid) { }

	// RVA: 0x22CE4C0 Offset: 0x22CCAC0 VA: 0x1822CE4C0 Slot: 22
	public virtual int GetPingLowest(ulong guid) { }

	// RVA: 0x22CEA50 Offset: 0x22CD050 VA: 0x1822CEA50 Slot: 23
	public virtual Native.RaknetStats GetStatistics(ulong guid) { }

	// RVA: 0x22CE560 Offset: 0x22CCB60 VA: 0x1822CE560 Slot: 24
	public virtual ulong GetStat(Connection connection, BaseNetwork.StatTypeLong type) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x22CF810 Offset: 0x22CDE10 VA: 0x1822CF810
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

