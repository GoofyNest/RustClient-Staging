public class MissionReward : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6452
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int itemID; // 0x14
	public int itemAmount; // 0x18

	// Methods

	// RVA: 0x1F4FE00 Offset: 0x1F4E400 VA: 0x181F4FE00
	public static void ResetToPool(MissionReward instance) { }

	// RVA: 0x1F4FD80 Offset: 0x1F4E380 VA: 0x181F4FD80
	public void ResetToPool() { }

	// RVA: 0x1F4FB60 Offset: 0x1F4E160 VA: 0x181F4FB60 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBEAA0 Offset: 0x1DBD0A0 VA: 0x181DBEAA0
	public void CopyTo(MissionReward instance) { }

	// RVA: 0x1F4ED60 Offset: 0x1F4D360 VA: 0x181F4ED60
	public MissionReward Copy() { }

	// RVA: 0x1F4F360 Offset: 0x1F4D960 VA: 0x181F4F360
	public static MissionReward Deserialize(Stream stream) { }

	// RVA: 0x1F4EDD0 Offset: 0x1F4D3D0 VA: 0x181F4EDD0
	public static MissionReward DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F4F0A0 Offset: 0x1F4D6A0 VA: 0x181F4F0A0
	public static MissionReward DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F4F520 Offset: 0x1F4DB20 VA: 0x181F4F520
	public static MissionReward Deserialize(byte[] buffer) { }

	// RVA: 0x1F4FBE0 Offset: 0x1F4E1E0 VA: 0x181F4FBE0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F502C0 Offset: 0x1F4E8C0 VA: 0x181F502C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F502E0 Offset: 0x1F4E8E0 VA: 0x181F502E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MissionReward previous) { }

	// RVA: 0x1F4FD60 Offset: 0x1F4E360 VA: 0x181F4FD60 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F4F790 Offset: 0x1F4DD90 VA: 0x181F4F790
	public static MissionReward Deserialize(byte[] buffer, MissionReward instance, bool isDelta = False) { }

	// RVA: 0x1F4F9E0 Offset: 0x1F4DFE0 VA: 0x181F4F9E0
	public static MissionReward Deserialize(Stream stream, MissionReward instance, bool isDelta) { }

	// RVA: 0x1F4EE50 Offset: 0x1F4D450 VA: 0x181F4EE50
	public static MissionReward DeserializeLengthDelimited(Stream stream, MissionReward instance, bool isDelta) { }

	// RVA: 0x1F4F130 Offset: 0x1F4D730 VA: 0x181F4F130
	public static MissionReward DeserializeLength(Stream stream, int length, MissionReward instance, bool isDelta) { }

	// RVA: 0x1F4FE80 Offset: 0x1F4E480 VA: 0x181F4FE80
	public static void SerializeDelta(Stream stream, MissionReward instance, MissionReward previous) { }

	// RVA: 0x1F501B0 Offset: 0x1F4E7B0 VA: 0x181F501B0
	public static void Serialize(Stream stream, MissionReward instance) { }

	// RVA: 0x1F502B0 Offset: 0x1F4E8B0 VA: 0x181F502B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F502C0 Offset: 0x1F4E8C0 VA: 0x181F502C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F500A0 Offset: 0x1F4E6A0 VA: 0x181F500A0
	public static byte[] SerializeToBytes(MissionReward instance) { }

	// RVA: 0x1F4FFF0 Offset: 0x1F4E5F0 VA: 0x181F4FFF0
	public static void SerializeLengthDelimited(Stream stream, MissionReward instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

