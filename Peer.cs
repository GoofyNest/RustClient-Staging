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

	// RVA: 0x22CE050 Offset: 0x22CC650 VA: 0x1822CE050
	public static Peer CreateServer(string ip, int port, int maxConnections) { }

	// RVA: 0x22CDB80 Offset: 0x22CC180 VA: 0x1822CDB80
	public static Peer CreateConnection(string hostname, int port, int retries, int retryDelay, int timeout) { }

	// RVA: 0x22CDAC0 Offset: 0x22CC0C0 VA: 0x1822CDAC0
	public void Close() { }

	// RVA: 0x22CEE20 Offset: 0x22CD420 VA: 0x1822CEE20
	public uint PendingReceiveCount() { }

	// RVA: 0x22CF260 Offset: 0x22CD860 VA: 0x1822CF260
	public bool Receive() { }

	// RVA: 0x22CFD30 Offset: 0x22CE330 VA: 0x1822CFD30 Slot: 4
	public virtual ulong get_incomingGUID() { }

	// RVA: 0x22CFA20 Offset: 0x22CE020 VA: 0x1822CFA20 Slot: 5
	public virtual uint get_incomingAddressInt() { }

	// RVA: 0x22CFDC0 Offset: 0x22CE3C0 VA: 0x1822CFDC0 Slot: 6
	public virtual uint get_incomingPort() { }

	// RVA: 0x22CFAB0 Offset: 0x22CE0B0 VA: 0x1822CFAB0
	public string get_incomingAddress() { }

	// RVA: 0x22CFC40 Offset: 0x22CE240 VA: 0x1822CFC40 Slot: 7
	public virtual int get_incomingBits() { }

	// RVA: 0x22CFBB0 Offset: 0x22CE1B0 VA: 0x1822CFBB0 Slot: 8
	public virtual int get_incomingBitsUnread() { }

	// RVA: 0x22CFD00 Offset: 0x22CE300 VA: 0x1822CFD00 Slot: 9
	public virtual int get_incomingBytes() { }

	// RVA: 0x22CFCD0 Offset: 0x22CE2D0 VA: 0x1822CFCD0 Slot: 10
	public virtual int get_incomingBytesUnread() { }

	// RVA: 0x22CF670 Offset: 0x22CDC70 VA: 0x1822CF670 Slot: 11
	public virtual void SetReadPos(int bitsOffset) { }

	// RVA: 0x22CF1B0 Offset: 0x22CD7B0 VA: 0x1822CF1B0 Slot: 12
	protected virtual bool Read(byte* data, int length) { }

	// RVA: 0x22CF160 Offset: 0x22CD760 VA: 0x1822CF160
	public int ReadBytes(byte[] buffer, int offset, int length) { }

	// RVA: 0x22CEF70 Offset: 0x22CD570 VA: 0x1822CEF70
	public byte ReadByte() { }

	// RVA: 0x22CEEE0 Offset: 0x22CD4E0 VA: 0x1822CEEE0 Slot: 13
	public virtual IntPtr RawData() { }

	// RVA: 0x22CF060 Offset: 0x22CD660 VA: 0x1822CF060
	public int ReadBytes(MemoryStream memoryStream, int length) { }

	// RVA: 0x22CF410 Offset: 0x22CDA10 VA: 0x1822CF410 Slot: 14
	public virtual void SendStart() { }

	// RVA: 0x22CF7C0 Offset: 0x22CDDC0 VA: 0x1822CF7C0
	public void WriteByte(byte val) { }

	// RVA: 0x22CF840 Offset: 0x22CDE40 VA: 0x1822CF840
	public void WriteBytes(byte[] val, int offset, int length) { }

	// RVA: 0x22CF7F0 Offset: 0x22CDDF0 VA: 0x1822CF7F0
	public void WriteBytes(byte[] val) { }

	// RVA: 0x22CF880 Offset: 0x22CDE80 VA: 0x1822CF880
	public void WriteBytes(MemoryStream stream) { }

	// RVA: 0x22CF910 Offset: 0x22CDF10 VA: 0x1822CF910 Slot: 15
	protected virtual void Write(byte* data, int size) { }

	// RVA: 0x22CF320 Offset: 0x22CD920 VA: 0x1822CF320 Slot: 16
	public virtual uint SendBroadcast(Priority priority, SendMethod reliability, sbyte channel) { }

	// RVA: 0x22CF4A0 Offset: 0x22CDAA0 VA: 0x1822CF4A0 Slot: 17
	public virtual uint SendTo(ulong guid, Priority priority, SendMethod reliability, sbyte channel) { }

	// RVA: 0x22CF5A0 Offset: 0x22CDBA0 VA: 0x1822CF5A0
	public void SendUnconnectedMessage(byte* data, int length, uint adr, ushort port) { }

	// RVA: 0x22CE450 Offset: 0x22CCA50 VA: 0x1822CE450
	public string GetAddress(ulong guid) { }

	// RVA: 0x22CF710 Offset: 0x22CDD10 VA: 0x1822CF710
	private static string StringFromPointer(IntPtr p) { }

	// RVA: 0x22CF7B0 Offset: 0x22CDDB0 VA: 0x1822CF7B0
	public int ToRaknetPriority(Priority priority) { }

	// RVA: 0x22CF790 Offset: 0x22CDD90 VA: 0x1822CF790
	public int ToRaknetPacketReliability(SendMethod reliability) { }

	// RVA: 0x22CED60 Offset: 0x22CD360 VA: 0x1822CED60
	public void Kick(Connection connection) { }

	// RVA: 0x22CDA50 Offset: 0x22CC050 VA: 0x1822CDA50 Slot: 18
	protected virtual void Check() { }

	// RVA: 0x22CE900 Offset: 0x22CCF00 VA: 0x1822CE900 Slot: 19
	public virtual string GetStatisticsString(ulong guid) { }

	// RVA: 0x22CE540 Offset: 0x22CCB40 VA: 0x1822CE540 Slot: 20
	public virtual int GetPingAverage(ulong guid) { }

	// RVA: 0x22CE5E0 Offset: 0x22CCBE0 VA: 0x1822CE5E0 Slot: 21
	public virtual int GetPingLast(ulong guid) { }

	// RVA: 0x22CE680 Offset: 0x22CCC80 VA: 0x1822CE680 Slot: 22
	public virtual int GetPingLowest(ulong guid) { }

	// RVA: 0x22CEC10 Offset: 0x22CD210 VA: 0x1822CEC10 Slot: 23
	public virtual Native.RaknetStats GetStatistics(ulong guid) { }

	// RVA: 0x22CE720 Offset: 0x22CCD20 VA: 0x1822CE720 Slot: 24
	public virtual ulong GetStat(Connection connection, BaseNetwork.StatTypeLong type) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x22CF9D0 Offset: 0x22CDFD0 VA: 0x1822CF9D0
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

