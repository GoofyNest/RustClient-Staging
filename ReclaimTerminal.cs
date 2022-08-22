public class ReclaimTerminal : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6405
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int itemCount; // 0x14

	// Methods

	// RVA: 0x1E002E0 Offset: 0x1DFE8E0 VA: 0x181E002E0
	public static void ResetToPool(ReclaimTerminal instance) { }

	// RVA: 0x1E00260 Offset: 0x1DFE860 VA: 0x181E00260
	public void ResetToPool() { }

	// RVA: 0x1E00130 Offset: 0x1DFE730 VA: 0x181E00130 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFEF80 Offset: 0x1BFD580 VA: 0x181BFEF80
	public void CopyTo(ReclaimTerminal instance) { }

	// RVA: 0x1DFF7B0 Offset: 0x1DFDDB0 VA: 0x181DFF7B0
	public ReclaimTerminal Copy() { }

	// RVA: 0x1E000B0 Offset: 0x1DFE6B0 VA: 0x181E000B0
	public static ReclaimTerminal Deserialize(Stream stream) { }

	// RVA: 0x1DFF820 Offset: 0x1DFDE20 VA: 0x181DFF820
	public static ReclaimTerminal DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DFFAC0 Offset: 0x1DFE0C0 VA: 0x181DFFAC0
	public static ReclaimTerminal DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DFFF90 Offset: 0x1DFE590 VA: 0x181DFFF90
	public static ReclaimTerminal Deserialize(byte[] buffer) { }

	// RVA: 0x1E00220 Offset: 0x1DFE820 VA: 0x181E00220
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E007B0 Offset: 0x1DFEDB0 VA: 0x181E007B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E00880 Offset: 0x1DFEE80 VA: 0x181E00880 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ReclaimTerminal previous) { }

	// RVA: 0x1E00240 Offset: 0x1DFE840 VA: 0x181E00240 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DFFD50 Offset: 0x1DFE350 VA: 0x181DFFD50
	public static ReclaimTerminal Deserialize(byte[] buffer, ReclaimTerminal instance, bool isDelta = False) { }

	// RVA: 0x1DFFE50 Offset: 0x1DFE450 VA: 0x181DFFE50
	public static ReclaimTerminal Deserialize(Stream stream, ReclaimTerminal instance, bool isDelta) { }

	// RVA: 0x1DFF8A0 Offset: 0x1DFDEA0 VA: 0x181DFF8A0
	public static ReclaimTerminal DeserializeLengthDelimited(Stream stream, ReclaimTerminal instance, bool isDelta) { }

	// RVA: 0x1DFFB50 Offset: 0x1DFE150 VA: 0x181DFFB50
	public static ReclaimTerminal DeserializeLength(Stream stream, int length, ReclaimTerminal instance, bool isDelta) { }

	// RVA: 0x1E00360 Offset: 0x1DFE960 VA: 0x181E00360
	public static void SerializeDelta(Stream stream, ReclaimTerminal instance, ReclaimTerminal previous) { }

	// RVA: 0x1E006D0 Offset: 0x1DFECD0 VA: 0x181E006D0
	public static void Serialize(Stream stream, ReclaimTerminal instance) { }

	// RVA: 0x1E007A0 Offset: 0x1DFEDA0 VA: 0x181E007A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E007B0 Offset: 0x1DFEDB0 VA: 0x181E007B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E00520 Offset: 0x1DFEB20 VA: 0x181E00520
	public static byte[] SerializeToBytes(ReclaimTerminal instance) { }

	// RVA: 0x1E00470 Offset: 0x1DFEA70 VA: 0x181E00470
	public static void SerializeLengthDelimited(Stream stream, ReclaimTerminal instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class ReclaimTerminal : StorageContainer // TypeDefIndex: 8626
{	// Fields
	public int itemCount; // 0x3D0
	public static readonly Translate.Phrase DespawnToast; // 0x0

	// Methods

	// RVA: 0x6AC6D0 Offset: 0x6AACD0 VA: 0x1806AC6D0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x6AC660 Offset: 0x6AAC60 VA: 0x1806AC660 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x6AC830 Offset: 0x6AAE30 VA: 0x1806AC830
	public void .ctor() { }

	// RVA: 0x6AC7C0 Offset: 0x6AADC0 VA: 0x1806AC7C0
	private static void .cctor() { }

}

