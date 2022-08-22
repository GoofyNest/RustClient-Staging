public class LightDeployer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6374
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint active; // 0x14

	// Methods

	// RVA: 0x1F20520 Offset: 0x1F1EB20 VA: 0x181F20520
	public static void ResetToPool(LightDeployer instance) { }

	// RVA: 0x1F204A0 Offset: 0x1F1EAA0 VA: 0x181F204A0
	public void ResetToPool() { }

	// RVA: 0x1F20370 Offset: 0x1F1E970 VA: 0x181F20370 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFEF80 Offset: 0x1BFD580 VA: 0x181BFEF80
	public void CopyTo(LightDeployer instance) { }

	// RVA: 0x1F1F9F0 Offset: 0x1F1DFF0 VA: 0x181F1F9F0
	public LightDeployer Copy() { }

	// RVA: 0x1F201B0 Offset: 0x1F1E7B0 VA: 0x181F201B0
	public static LightDeployer Deserialize(Stream stream) { }

	// RVA: 0x1F1FC80 Offset: 0x1F1E280 VA: 0x181F1FC80
	public static LightDeployer DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F1FF00 Offset: 0x1F1E500 VA: 0x181F1FF00
	public static LightDeployer DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F1FF90 Offset: 0x1F1E590 VA: 0x181F1FF90
	public static LightDeployer Deserialize(byte[] buffer) { }

	// RVA: 0x1F20460 Offset: 0x1F1EA60 VA: 0x181F20460
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F209F0 Offset: 0x1F1EFF0 VA: 0x181F209F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F20AC0 Offset: 0x1F1F0C0 VA: 0x181F20AC0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, LightDeployer previous) { }

	// RVA: 0x1F20480 Offset: 0x1F1EA80 VA: 0x181F20480 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F200B0 Offset: 0x1F1E6B0 VA: 0x181F200B0
	public static LightDeployer Deserialize(byte[] buffer, LightDeployer instance, bool isDelta = False) { }

	// RVA: 0x1F20230 Offset: 0x1F1E830 VA: 0x181F20230
	public static LightDeployer Deserialize(Stream stream, LightDeployer instance, bool isDelta) { }

	// RVA: 0x1F1FA60 Offset: 0x1F1E060 VA: 0x181F1FA60
	public static LightDeployer DeserializeLengthDelimited(Stream stream, LightDeployer instance, bool isDelta) { }

	// RVA: 0x1F1FD00 Offset: 0x1F1E300 VA: 0x181F1FD00
	public static LightDeployer DeserializeLength(Stream stream, int length, LightDeployer instance, bool isDelta) { }

	// RVA: 0x1F205A0 Offset: 0x1F1EBA0 VA: 0x181F205A0
	public static void SerializeDelta(Stream stream, LightDeployer instance, LightDeployer previous) { }

	// RVA: 0x1F20910 Offset: 0x1F1EF10 VA: 0x181F20910
	public static void Serialize(Stream stream, LightDeployer instance) { }

	// RVA: 0x1F209E0 Offset: 0x1F1EFE0 VA: 0x181F209E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F209F0 Offset: 0x1F1EFF0 VA: 0x181F209F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F20760 Offset: 0x1F1ED60 VA: 0x181F20760
	public static byte[] SerializeToBytes(LightDeployer instance) { }

	// RVA: 0x1F206B0 Offset: 0x1F1ECB0 VA: 0x181F206B0
	public static void SerializeLengthDelimited(Stream stream, LightDeployer instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

