public class ReclaimTerminal : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6405
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int itemCount; // 0x14

	// Methods

	// RVA: 0x1DFFAC0 Offset: 0x1DFE0C0 VA: 0x181DFFAC0
	public static void ResetToPool(ReclaimTerminal instance) { }

	// RVA: 0x1DFFA40 Offset: 0x1DFE040 VA: 0x181DFFA40
	public void ResetToPool() { }

	// RVA: 0x1DFF910 Offset: 0x1DFDF10 VA: 0x181DFF910 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE790 Offset: 0x1BFCD90 VA: 0x181BFE790
	public void CopyTo(ReclaimTerminal instance) { }

	// RVA: 0x1DFEF90 Offset: 0x1DFD590 VA: 0x181DFEF90
	public ReclaimTerminal Copy() { }

	// RVA: 0x1DFF890 Offset: 0x1DFDE90 VA: 0x181DFF890
	public static ReclaimTerminal Deserialize(Stream stream) { }

	// RVA: 0x1DFF000 Offset: 0x1DFD600 VA: 0x181DFF000
	public static ReclaimTerminal DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DFF2A0 Offset: 0x1DFD8A0 VA: 0x181DFF2A0
	public static ReclaimTerminal DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DFF770 Offset: 0x1DFDD70 VA: 0x181DFF770
	public static ReclaimTerminal Deserialize(byte[] buffer) { }

	// RVA: 0x1DFFA00 Offset: 0x1DFE000 VA: 0x181DFFA00
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DFFF90 Offset: 0x1DFE590 VA: 0x181DFFF90 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E00060 Offset: 0x1DFE660 VA: 0x181E00060 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ReclaimTerminal previous) { }

	// RVA: 0x1DFFA20 Offset: 0x1DFE020 VA: 0x181DFFA20 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DFF530 Offset: 0x1DFDB30 VA: 0x181DFF530
	public static ReclaimTerminal Deserialize(byte[] buffer, ReclaimTerminal instance, bool isDelta = False) { }

	// RVA: 0x1DFF630 Offset: 0x1DFDC30 VA: 0x181DFF630
	public static ReclaimTerminal Deserialize(Stream stream, ReclaimTerminal instance, bool isDelta) { }

	// RVA: 0x1DFF080 Offset: 0x1DFD680 VA: 0x181DFF080
	public static ReclaimTerminal DeserializeLengthDelimited(Stream stream, ReclaimTerminal instance, bool isDelta) { }

	// RVA: 0x1DFF330 Offset: 0x1DFD930 VA: 0x181DFF330
	public static ReclaimTerminal DeserializeLength(Stream stream, int length, ReclaimTerminal instance, bool isDelta) { }

	// RVA: 0x1DFFB40 Offset: 0x1DFE140 VA: 0x181DFFB40
	public static void SerializeDelta(Stream stream, ReclaimTerminal instance, ReclaimTerminal previous) { }

	// RVA: 0x1DFFEB0 Offset: 0x1DFE4B0 VA: 0x181DFFEB0
	public static void Serialize(Stream stream, ReclaimTerminal instance) { }

	// RVA: 0x1DFFF80 Offset: 0x1DFE580 VA: 0x181DFFF80
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DFFF90 Offset: 0x1DFE590 VA: 0x181DFFF90
	public void ToProto(Stream stream) { }

	// RVA: 0x1DFFD00 Offset: 0x1DFE300 VA: 0x181DFFD00
	public static byte[] SerializeToBytes(ReclaimTerminal instance) { }

	// RVA: 0x1DFFC50 Offset: 0x1DFE250 VA: 0x181DFFC50
	public static void SerializeLengthDelimited(Stream stream, ReclaimTerminal instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class ReclaimTerminal : StorageContainer // TypeDefIndex: 8626
{	// Fields
	public int itemCount; // 0x3D0
	public static readonly Translate.Phrase DespawnToast; // 0x0

	// Methods

	// RVA: 0x6AC740 Offset: 0x6AAD40 VA: 0x1806AC740 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x6AC6D0 Offset: 0x6AACD0 VA: 0x1806AC6D0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x6AC8A0 Offset: 0x6AAEA0 VA: 0x1806AC8A0
	public void .ctor() { }

	// RVA: 0x6AC830 Offset: 0x6AAE30 VA: 0x1806AC830
	private static void .cctor() { }

}

