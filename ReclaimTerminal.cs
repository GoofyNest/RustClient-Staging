public class ReclaimTerminal : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6405
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int itemCount; // 0x14

	// Methods

	// RVA: 0x1DFF9C0 Offset: 0x1DFDFC0 VA: 0x181DFF9C0
	public static void ResetToPool(ReclaimTerminal instance) { }

	// RVA: 0x1DFF940 Offset: 0x1DFDF40 VA: 0x181DFF940
	public void ResetToPool() { }

	// RVA: 0x1DFF810 Offset: 0x1DFDE10 VA: 0x181DFF810 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE690 Offset: 0x1BFCC90 VA: 0x181BFE690
	public void CopyTo(ReclaimTerminal instance) { }

	// RVA: 0x1DFEE90 Offset: 0x1DFD490 VA: 0x181DFEE90
	public ReclaimTerminal Copy() { }

	// RVA: 0x1DFF790 Offset: 0x1DFDD90 VA: 0x181DFF790
	public static ReclaimTerminal Deserialize(Stream stream) { }

	// RVA: 0x1DFEF00 Offset: 0x1DFD500 VA: 0x181DFEF00
	public static ReclaimTerminal DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DFF1A0 Offset: 0x1DFD7A0 VA: 0x181DFF1A0
	public static ReclaimTerminal DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DFF670 Offset: 0x1DFDC70 VA: 0x181DFF670
	public static ReclaimTerminal Deserialize(byte[] buffer) { }

	// RVA: 0x1DFF900 Offset: 0x1DFDF00 VA: 0x181DFF900
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DFFE90 Offset: 0x1DFE490 VA: 0x181DFFE90 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DFFF60 Offset: 0x1DFE560 VA: 0x181DFFF60 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ReclaimTerminal previous) { }

	// RVA: 0x1DFF920 Offset: 0x1DFDF20 VA: 0x181DFF920 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DFF430 Offset: 0x1DFDA30 VA: 0x181DFF430
	public static ReclaimTerminal Deserialize(byte[] buffer, ReclaimTerminal instance, bool isDelta = False) { }

	// RVA: 0x1DFF530 Offset: 0x1DFDB30 VA: 0x181DFF530
	public static ReclaimTerminal Deserialize(Stream stream, ReclaimTerminal instance, bool isDelta) { }

	// RVA: 0x1DFEF80 Offset: 0x1DFD580 VA: 0x181DFEF80
	public static ReclaimTerminal DeserializeLengthDelimited(Stream stream, ReclaimTerminal instance, bool isDelta) { }

	// RVA: 0x1DFF230 Offset: 0x1DFD830 VA: 0x181DFF230
	public static ReclaimTerminal DeserializeLength(Stream stream, int length, ReclaimTerminal instance, bool isDelta) { }

	// RVA: 0x1DFFA40 Offset: 0x1DFE040 VA: 0x181DFFA40
	public static void SerializeDelta(Stream stream, ReclaimTerminal instance, ReclaimTerminal previous) { }

	// RVA: 0x1DFFDB0 Offset: 0x1DFE3B0 VA: 0x181DFFDB0
	public static void Serialize(Stream stream, ReclaimTerminal instance) { }

	// RVA: 0x1DFFE80 Offset: 0x1DFE480 VA: 0x181DFFE80
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DFFE90 Offset: 0x1DFE490 VA: 0x181DFFE90
	public void ToProto(Stream stream) { }

	// RVA: 0x1DFFC00 Offset: 0x1DFE200 VA: 0x181DFFC00
	public static byte[] SerializeToBytes(ReclaimTerminal instance) { }

	// RVA: 0x1DFFB50 Offset: 0x1DFE150 VA: 0x181DFFB50
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

