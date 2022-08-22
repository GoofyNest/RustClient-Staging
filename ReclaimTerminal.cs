public class ReclaimTerminal : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6405
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int itemCount; // 0x14

	// Methods

	// RVA: 0x1DFF800 Offset: 0x1DFDE00 VA: 0x181DFF800
	public static void ResetToPool(ReclaimTerminal instance) { }

	// RVA: 0x1DFF780 Offset: 0x1DFDD80 VA: 0x181DFF780
	public void ResetToPool() { }

	// RVA: 0x1DFF650 Offset: 0x1DFDC50 VA: 0x181DFF650 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE4D0 Offset: 0x1BFCAD0 VA: 0x181BFE4D0
	public void CopyTo(ReclaimTerminal instance) { }

	// RVA: 0x1DFECD0 Offset: 0x1DFD2D0 VA: 0x181DFECD0
	public ReclaimTerminal Copy() { }

	// RVA: 0x1DFF5D0 Offset: 0x1DFDBD0 VA: 0x181DFF5D0
	public static ReclaimTerminal Deserialize(Stream stream) { }

	// RVA: 0x1DFED40 Offset: 0x1DFD340 VA: 0x181DFED40
	public static ReclaimTerminal DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DFEFE0 Offset: 0x1DFD5E0 VA: 0x181DFEFE0
	public static ReclaimTerminal DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DFF4B0 Offset: 0x1DFDAB0 VA: 0x181DFF4B0
	public static ReclaimTerminal Deserialize(byte[] buffer) { }

	// RVA: 0x1DFF740 Offset: 0x1DFDD40 VA: 0x181DFF740
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DFFCD0 Offset: 0x1DFE2D0 VA: 0x181DFFCD0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DFFDA0 Offset: 0x1DFE3A0 VA: 0x181DFFDA0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ReclaimTerminal previous) { }

	// RVA: 0x1DFF760 Offset: 0x1DFDD60 VA: 0x181DFF760 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DFF270 Offset: 0x1DFD870 VA: 0x181DFF270
	public static ReclaimTerminal Deserialize(byte[] buffer, ReclaimTerminal instance, bool isDelta = False) { }

	// RVA: 0x1DFF370 Offset: 0x1DFD970 VA: 0x181DFF370
	public static ReclaimTerminal Deserialize(Stream stream, ReclaimTerminal instance, bool isDelta) { }

	// RVA: 0x1DFEDC0 Offset: 0x1DFD3C0 VA: 0x181DFEDC0
	public static ReclaimTerminal DeserializeLengthDelimited(Stream stream, ReclaimTerminal instance, bool isDelta) { }

	// RVA: 0x1DFF070 Offset: 0x1DFD670 VA: 0x181DFF070
	public static ReclaimTerminal DeserializeLength(Stream stream, int length, ReclaimTerminal instance, bool isDelta) { }

	// RVA: 0x1DFF880 Offset: 0x1DFDE80 VA: 0x181DFF880
	public static void SerializeDelta(Stream stream, ReclaimTerminal instance, ReclaimTerminal previous) { }

	// RVA: 0x1DFFBF0 Offset: 0x1DFE1F0 VA: 0x181DFFBF0
	public static void Serialize(Stream stream, ReclaimTerminal instance) { }

	// RVA: 0x1DFFCC0 Offset: 0x1DFE2C0 VA: 0x181DFFCC0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DFFCD0 Offset: 0x1DFE2D0 VA: 0x181DFFCD0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DFFA40 Offset: 0x1DFE040 VA: 0x181DFFA40
	public static byte[] SerializeToBytes(ReclaimTerminal instance) { }

	// RVA: 0x1DFF990 Offset: 0x1DFDF90 VA: 0x181DFF990
	public static void SerializeLengthDelimited(Stream stream, ReclaimTerminal instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class ReclaimTerminal : StorageContainer // TypeDefIndex: 8626
{	// Fields
	public int itemCount; // 0x3D0
	public static readonly Translate.Phrase DespawnToast; // 0x0

	// Methods

	// RVA: 0x6AC630 Offset: 0x6AAC30 VA: 0x1806AC630 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x6AC5C0 Offset: 0x6AABC0 VA: 0x1806AC5C0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x6AC790 Offset: 0x6AAD90 VA: 0x1806AC790
	public void .ctor() { }

	// RVA: 0x6AC720 Offset: 0x6AAD20 VA: 0x1806AC720
	private static void .cctor() { }

}

