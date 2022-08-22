public class MissionReward : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6452
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int itemID; // 0x14
	public int itemAmount; // 0x18

	// Methods

	// RVA: 0x1F4FC40 Offset: 0x1F4E240 VA: 0x181F4FC40
	public static void ResetToPool(MissionReward instance) { }

	// RVA: 0x1F4FBC0 Offset: 0x1F4E1C0 VA: 0x181F4FBC0
	public void ResetToPool() { }

	// RVA: 0x1F4F9A0 Offset: 0x1F4DFA0 VA: 0x181F4F9A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBE8E0 Offset: 0x1DBCEE0 VA: 0x181DBE8E0
	public void CopyTo(MissionReward instance) { }

	// RVA: 0x1F4EBA0 Offset: 0x1F4D1A0 VA: 0x181F4EBA0
	public MissionReward Copy() { }

	// RVA: 0x1F4F1A0 Offset: 0x1F4D7A0 VA: 0x181F4F1A0
	public static MissionReward Deserialize(Stream stream) { }

	// RVA: 0x1F4EC10 Offset: 0x1F4D210 VA: 0x181F4EC10
	public static MissionReward DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F4EEE0 Offset: 0x1F4D4E0 VA: 0x181F4EEE0
	public static MissionReward DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F4F360 Offset: 0x1F4D960 VA: 0x181F4F360
	public static MissionReward Deserialize(byte[] buffer) { }

	// RVA: 0x1F4FA20 Offset: 0x1F4E020 VA: 0x181F4FA20
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F50100 Offset: 0x1F4E700 VA: 0x181F50100 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F50120 Offset: 0x1F4E720 VA: 0x181F50120 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MissionReward previous) { }

	// RVA: 0x1F4FBA0 Offset: 0x1F4E1A0 VA: 0x181F4FBA0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F4F5D0 Offset: 0x1F4DBD0 VA: 0x181F4F5D0
	public static MissionReward Deserialize(byte[] buffer, MissionReward instance, bool isDelta = False) { }

	// RVA: 0x1F4F820 Offset: 0x1F4DE20 VA: 0x181F4F820
	public static MissionReward Deserialize(Stream stream, MissionReward instance, bool isDelta) { }

	// RVA: 0x1F4EC90 Offset: 0x1F4D290 VA: 0x181F4EC90
	public static MissionReward DeserializeLengthDelimited(Stream stream, MissionReward instance, bool isDelta) { }

	// RVA: 0x1F4EF70 Offset: 0x1F4D570 VA: 0x181F4EF70
	public static MissionReward DeserializeLength(Stream stream, int length, MissionReward instance, bool isDelta) { }

	// RVA: 0x1F4FCC0 Offset: 0x1F4E2C0 VA: 0x181F4FCC0
	public static void SerializeDelta(Stream stream, MissionReward instance, MissionReward previous) { }

	// RVA: 0x1F4FFF0 Offset: 0x1F4E5F0 VA: 0x181F4FFF0
	public static void Serialize(Stream stream, MissionReward instance) { }

	// RVA: 0x1F500F0 Offset: 0x1F4E6F0 VA: 0x181F500F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F50100 Offset: 0x1F4E700 VA: 0x181F50100
	public void ToProto(Stream stream) { }

	// RVA: 0x1F4FEE0 Offset: 0x1F4E4E0 VA: 0x181F4FEE0
	public static byte[] SerializeToBytes(MissionReward instance) { }

	// RVA: 0x1F4FE30 Offset: 0x1F4E430 VA: 0x181F4FE30
	public static void SerializeLengthDelimited(Stream stream, MissionReward instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

