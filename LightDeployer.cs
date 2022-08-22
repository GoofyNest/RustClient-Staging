public class LightDeployer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6374
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint active; // 0x14

	// Methods

	// RVA: 0x1F1FD00 Offset: 0x1F1E300 VA: 0x181F1FD00
	public static void ResetToPool(LightDeployer instance) { }

	// RVA: 0x1F1FC80 Offset: 0x1F1E280 VA: 0x181F1FC80
	public void ResetToPool() { }

	// RVA: 0x1F1FB50 Offset: 0x1F1E150 VA: 0x181F1FB50 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE790 Offset: 0x1BFCD90 VA: 0x181BFE790
	public void CopyTo(LightDeployer instance) { }

	// RVA: 0x1F1F1D0 Offset: 0x1F1D7D0 VA: 0x181F1F1D0
	public LightDeployer Copy() { }

	// RVA: 0x1F1F990 Offset: 0x1F1DF90 VA: 0x181F1F990
	public static LightDeployer Deserialize(Stream stream) { }

	// RVA: 0x1F1F460 Offset: 0x1F1DA60 VA: 0x181F1F460
	public static LightDeployer DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F1F6E0 Offset: 0x1F1DCE0 VA: 0x181F1F6E0
	public static LightDeployer DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F1F770 Offset: 0x1F1DD70 VA: 0x181F1F770
	public static LightDeployer Deserialize(byte[] buffer) { }

	// RVA: 0x1F1FC40 Offset: 0x1F1E240 VA: 0x181F1FC40
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F201D0 Offset: 0x1F1E7D0 VA: 0x181F201D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F202A0 Offset: 0x1F1E8A0 VA: 0x181F202A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, LightDeployer previous) { }

	// RVA: 0x1F1FC60 Offset: 0x1F1E260 VA: 0x181F1FC60 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F1F890 Offset: 0x1F1DE90 VA: 0x181F1F890
	public static LightDeployer Deserialize(byte[] buffer, LightDeployer instance, bool isDelta = False) { }

	// RVA: 0x1F1FA10 Offset: 0x1F1E010 VA: 0x181F1FA10
	public static LightDeployer Deserialize(Stream stream, LightDeployer instance, bool isDelta) { }

	// RVA: 0x1F1F240 Offset: 0x1F1D840 VA: 0x181F1F240
	public static LightDeployer DeserializeLengthDelimited(Stream stream, LightDeployer instance, bool isDelta) { }

	// RVA: 0x1F1F4E0 Offset: 0x1F1DAE0 VA: 0x181F1F4E0
	public static LightDeployer DeserializeLength(Stream stream, int length, LightDeployer instance, bool isDelta) { }

	// RVA: 0x1F1FD80 Offset: 0x1F1E380 VA: 0x181F1FD80
	public static void SerializeDelta(Stream stream, LightDeployer instance, LightDeployer previous) { }

	// RVA: 0x1F200F0 Offset: 0x1F1E6F0 VA: 0x181F200F0
	public static void Serialize(Stream stream, LightDeployer instance) { }

	// RVA: 0x1F201C0 Offset: 0x1F1E7C0 VA: 0x181F201C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F201D0 Offset: 0x1F1E7D0 VA: 0x181F201D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F1FF40 Offset: 0x1F1E540 VA: 0x181F1FF40
	public static byte[] SerializeToBytes(LightDeployer instance) { }

	// RVA: 0x1F1FE90 Offset: 0x1F1E490 VA: 0x181F1FE90
	public static void SerializeLengthDelimited(Stream stream, LightDeployer instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

