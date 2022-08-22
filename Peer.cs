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

	// RVA: 0x22CE970 Offset: 0x22CCF70 VA: 0x1822CE970
	public static Peer CreateServer(string ip, int port, int maxConnections) { }

	// RVA: 0x22CE4A0 Offset: 0x22CCAA0 VA: 0x1822CE4A0
	public static Peer CreateConnection(string hostname, int port, int retries, int retryDelay, int timeout) { }

	// RVA: 0x22CE3E0 Offset: 0x22CC9E0 VA: 0x1822CE3E0
	public void Close() { }

	// RVA: 0x22CF740 Offset: 0x22CDD40 VA: 0x1822CF740
	public uint PendingReceiveCount() { }

	// RVA: 0x22CFB80 Offset: 0x22CE180 VA: 0x1822CFB80
	public bool Receive() { }

	// RVA: 0x22D0650 Offset: 0x22CEC50 VA: 0x1822D0650 Slot: 4
	public virtual ulong get_incomingGUID() { }

	// RVA: 0x22D0340 Offset: 0x22CE940 VA: 0x1822D0340 Slot: 5
	public virtual uint get_incomingAddressInt() { }

	// RVA: 0x22D06E0 Offset: 0x22CECE0 VA: 0x1822D06E0 Slot: 6
	public virtual uint get_incomingPort() { }

	// RVA: 0x22D03D0 Offset: 0x22CE9D0 VA: 0x1822D03D0
	public string get_incomingAddress() { }

	// RVA: 0x22D0560 Offset: 0x22CEB60 VA: 0x1822D0560 Slot: 7
	public virtual int get_incomingBits() { }

	// RVA: 0x22D04D0 Offset: 0x22CEAD0 VA: 0x1822D04D0 Slot: 8
	public virtual int get_incomingBitsUnread() { }

	// RVA: 0x22D0620 Offset: 0x22CEC20 VA: 0x1822D0620 Slot: 9
	public virtual int get_incomingBytes() { }

	// RVA: 0x22D05F0 Offset: 0x22CEBF0 VA: 0x1822D05F0 Slot: 10
	public virtual int get_incomingBytesUnread() { }

	// RVA: 0x22CFF90 Offset: 0x22CE590 VA: 0x1822CFF90 Slot: 11
	public virtual void SetReadPos(int bitsOffset) { }

	// RVA: 0x22CFAD0 Offset: 0x22CE0D0 VA: 0x1822CFAD0 Slot: 12
	protected virtual bool Read(byte* data, int length) { }

	// RVA: 0x22CFA80 Offset: 0x22CE080 VA: 0x1822CFA80
	public int ReadBytes(byte[] buffer, int offset, int length) { }

	// RVA: 0x22CF890 Offset: 0x22CDE90 VA: 0x1822CF890
	public byte ReadByte() { }

	// RVA: 0x22CF800 Offset: 0x22CDE00 VA: 0x1822CF800 Slot: 13
	public virtual IntPtr RawData() { }

	// RVA: 0x22CF980 Offset: 0x22CDF80 VA: 0x1822CF980
	public int ReadBytes(MemoryStream memoryStream, int length) { }

	// RVA: 0x22CFD30 Offset: 0x22CE330 VA: 0x1822CFD30 Slot: 14
	public virtual void SendStart() { }

	// RVA: 0x22D00E0 Offset: 0x22CE6E0 VA: 0x1822D00E0
	public void WriteByte(byte val) { }

	// RVA: 0x22D0160 Offset: 0x22CE760 VA: 0x1822D0160
	public void WriteBytes(byte[] val, int offset, int length) { }

	// RVA: 0x22D0110 Offset: 0x22CE710 VA: 0x1822D0110
	public void WriteBytes(byte[] val) { }

	// RVA: 0x22D01A0 Offset: 0x22CE7A0 VA: 0x1822D01A0
	public void WriteBytes(MemoryStream stream) { }

	// RVA: 0x22D0230 Offset: 0x22CE830 VA: 0x1822D0230 Slot: 15
	protected virtual void Write(byte* data, int size) { }

	// RVA: 0x22CFC40 Offset: 0x22CE240 VA: 0x1822CFC40 Slot: 16
	public virtual uint SendBroadcast(Priority priority, SendMethod reliability, sbyte channel) { }

	// RVA: 0x22CFDC0 Offset: 0x22CE3C0 VA: 0x1822CFDC0 Slot: 17
	public virtual uint SendTo(ulong guid, Priority priority, SendMethod reliability, sbyte channel) { }

	// RVA: 0x22CFEC0 Offset: 0x22CE4C0 VA: 0x1822CFEC0
	public void SendUnconnectedMessage(byte* data, int length, uint adr, ushort port) { }

	// RVA: 0x22CED70 Offset: 0x22CD370 VA: 0x1822CED70
	public string GetAddress(ulong guid) { }

	// RVA: 0x22D0030 Offset: 0x22CE630 VA: 0x1822D0030
	private static string StringFromPointer(IntPtr p) { }

	// RVA: 0x22D00D0 Offset: 0x22CE6D0 VA: 0x1822D00D0
	public int ToRaknetPriority(Priority priority) { }

	// RVA: 0x22D00B0 Offset: 0x22CE6B0 VA: 0x1822D00B0
	public int ToRaknetPacketReliability(SendMethod reliability) { }

	// RVA: 0x22CF680 Offset: 0x22CDC80 VA: 0x1822CF680
	public void Kick(Connection connection) { }

	// RVA: 0x22CE370 Offset: 0x22CC970 VA: 0x1822CE370 Slot: 18
	protected virtual void Check() { }

	// RVA: 0x22CF220 Offset: 0x22CD820 VA: 0x1822CF220 Slot: 19
	public virtual string GetStatisticsString(ulong guid) { }

	// RVA: 0x22CEE60 Offset: 0x22CD460 VA: 0x1822CEE60 Slot: 20
	public virtual int GetPingAverage(ulong guid) { }

	// RVA: 0x22CEF00 Offset: 0x22CD500 VA: 0x1822CEF00 Slot: 21
	public virtual int GetPingLast(ulong guid) { }

	// RVA: 0x22CEFA0 Offset: 0x22CD5A0 VA: 0x1822CEFA0 Slot: 22
	public virtual int GetPingLowest(ulong guid) { }

	// RVA: 0x22CF530 Offset: 0x22CDB30 VA: 0x1822CF530 Slot: 23
	public virtual Native.RaknetStats GetStatistics(ulong guid) { }

	// RVA: 0x22CF040 Offset: 0x22CD640 VA: 0x1822CF040 Slot: 24
	public virtual ulong GetStat(Connection connection, BaseNetwork.StatTypeLong type) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x22D02F0 Offset: 0x22CE8F0 VA: 0x1822D02F0
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

