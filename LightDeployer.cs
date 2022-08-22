public class LightDeployer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6374
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint active; // 0x14

	// Methods

	// RVA: 0x1F1FA40 Offset: 0x1F1E040 VA: 0x181F1FA40
	public static void ResetToPool(LightDeployer instance) { }

	// RVA: 0x1F1F9C0 Offset: 0x1F1DFC0 VA: 0x181F1F9C0
	public void ResetToPool() { }

	// RVA: 0x1F1F890 Offset: 0x1F1DE90 VA: 0x181F1F890 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE4D0 Offset: 0x1BFCAD0 VA: 0x181BFE4D0
	public void CopyTo(LightDeployer instance) { }

	// RVA: 0x1F1EF10 Offset: 0x1F1D510 VA: 0x181F1EF10
	public LightDeployer Copy() { }

	// RVA: 0x1F1F6D0 Offset: 0x1F1DCD0 VA: 0x181F1F6D0
	public static LightDeployer Deserialize(Stream stream) { }

	// RVA: 0x1F1F1A0 Offset: 0x1F1D7A0 VA: 0x181F1F1A0
	public static LightDeployer DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F1F420 Offset: 0x1F1DA20 VA: 0x181F1F420
	public static LightDeployer DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F1F4B0 Offset: 0x1F1DAB0 VA: 0x181F1F4B0
	public static LightDeployer Deserialize(byte[] buffer) { }

	// RVA: 0x1F1F980 Offset: 0x1F1DF80 VA: 0x181F1F980
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F1FF10 Offset: 0x1F1E510 VA: 0x181F1FF10 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F1FFE0 Offset: 0x1F1E5E0 VA: 0x181F1FFE0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, LightDeployer previous) { }

	// RVA: 0x1F1F9A0 Offset: 0x1F1DFA0 VA: 0x181F1F9A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F1F5D0 Offset: 0x1F1DBD0 VA: 0x181F1F5D0
	public static LightDeployer Deserialize(byte[] buffer, LightDeployer instance, bool isDelta = False) { }

	// RVA: 0x1F1F750 Offset: 0x1F1DD50 VA: 0x181F1F750
	public static LightDeployer Deserialize(Stream stream, LightDeployer instance, bool isDelta) { }

	// RVA: 0x1F1EF80 Offset: 0x1F1D580 VA: 0x181F1EF80
	public static LightDeployer DeserializeLengthDelimited(Stream stream, LightDeployer instance, bool isDelta) { }

	// RVA: 0x1F1F220 Offset: 0x1F1D820 VA: 0x181F1F220
	public static LightDeployer DeserializeLength(Stream stream, int length, LightDeployer instance, bool isDelta) { }

	// RVA: 0x1F1FAC0 Offset: 0x1F1E0C0 VA: 0x181F1FAC0
	public static void SerializeDelta(Stream stream, LightDeployer instance, LightDeployer previous) { }

	// RVA: 0x1F1FE30 Offset: 0x1F1E430 VA: 0x181F1FE30
	public static void Serialize(Stream stream, LightDeployer instance) { }

	// RVA: 0x1F1FF00 Offset: 0x1F1E500 VA: 0x181F1FF00
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F1FF10 Offset: 0x1F1E510 VA: 0x181F1FF10
	public void ToProto(Stream stream) { }

	// RVA: 0x1F1FC80 Offset: 0x1F1E280 VA: 0x181F1FC80
	public static byte[] SerializeToBytes(LightDeployer instance) { }

	// RVA: 0x1F1FBD0 Offset: 0x1F1E1D0 VA: 0x181F1FBD0
	public static void SerializeLengthDelimited(Stream stream, LightDeployer instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

