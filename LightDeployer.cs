public class LightDeployer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6374
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint active; // 0x14

	// Methods

	// RVA: 0x1F1FC00 Offset: 0x1F1E200 VA: 0x181F1FC00
	public static void ResetToPool(LightDeployer instance) { }

	// RVA: 0x1F1FB80 Offset: 0x1F1E180 VA: 0x181F1FB80
	public void ResetToPool() { }

	// RVA: 0x1F1FA50 Offset: 0x1F1E050 VA: 0x181F1FA50 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE690 Offset: 0x1BFCC90 VA: 0x181BFE690
	public void CopyTo(LightDeployer instance) { }

	// RVA: 0x1F1F0D0 Offset: 0x1F1D6D0 VA: 0x181F1F0D0
	public LightDeployer Copy() { }

	// RVA: 0x1F1F890 Offset: 0x1F1DE90 VA: 0x181F1F890
	public static LightDeployer Deserialize(Stream stream) { }

	// RVA: 0x1F1F360 Offset: 0x1F1D960 VA: 0x181F1F360
	public static LightDeployer DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F1F5E0 Offset: 0x1F1DBE0 VA: 0x181F1F5E0
	public static LightDeployer DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F1F670 Offset: 0x1F1DC70 VA: 0x181F1F670
	public static LightDeployer Deserialize(byte[] buffer) { }

	// RVA: 0x1F1FB40 Offset: 0x1F1E140 VA: 0x181F1FB40
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F200D0 Offset: 0x1F1E6D0 VA: 0x181F200D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F201A0 Offset: 0x1F1E7A0 VA: 0x181F201A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, LightDeployer previous) { }

	// RVA: 0x1F1FB60 Offset: 0x1F1E160 VA: 0x181F1FB60 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F1F790 Offset: 0x1F1DD90 VA: 0x181F1F790
	public static LightDeployer Deserialize(byte[] buffer, LightDeployer instance, bool isDelta = False) { }

	// RVA: 0x1F1F910 Offset: 0x1F1DF10 VA: 0x181F1F910
	public static LightDeployer Deserialize(Stream stream, LightDeployer instance, bool isDelta) { }

	// RVA: 0x1F1F140 Offset: 0x1F1D740 VA: 0x181F1F140
	public static LightDeployer DeserializeLengthDelimited(Stream stream, LightDeployer instance, bool isDelta) { }

	// RVA: 0x1F1F3E0 Offset: 0x1F1D9E0 VA: 0x181F1F3E0
	public static LightDeployer DeserializeLength(Stream stream, int length, LightDeployer instance, bool isDelta) { }

	// RVA: 0x1F1FC80 Offset: 0x1F1E280 VA: 0x181F1FC80
	public static void SerializeDelta(Stream stream, LightDeployer instance, LightDeployer previous) { }

	// RVA: 0x1F1FFF0 Offset: 0x1F1E5F0 VA: 0x181F1FFF0
	public static void Serialize(Stream stream, LightDeployer instance) { }

	// RVA: 0x1F200C0 Offset: 0x1F1E6C0 VA: 0x181F200C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F200D0 Offset: 0x1F1E6D0 VA: 0x181F200D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F1FE40 Offset: 0x1F1E440 VA: 0x181F1FE40
	public static byte[] SerializeToBytes(LightDeployer instance) { }

	// RVA: 0x1F1FD90 Offset: 0x1F1E390 VA: 0x181F1FD90
	public static void SerializeLengthDelimited(Stream stream, LightDeployer instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

