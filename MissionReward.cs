public class MissionReward : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6452
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int itemID; // 0x14
	public int itemAmount; // 0x18

	// Methods

	// RVA: 0x1F4FF00 Offset: 0x1F4E500 VA: 0x181F4FF00
	public static void ResetToPool(MissionReward instance) { }

	// RVA: 0x1F4FE80 Offset: 0x1F4E480 VA: 0x181F4FE80
	public void ResetToPool() { }

	// RVA: 0x1F4FC60 Offset: 0x1F4E260 VA: 0x181F4FC60 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBEBA0 Offset: 0x1DBD1A0 VA: 0x181DBEBA0
	public void CopyTo(MissionReward instance) { }

	// RVA: 0x1F4EE60 Offset: 0x1F4D460 VA: 0x181F4EE60
	public MissionReward Copy() { }

	// RVA: 0x1F4F460 Offset: 0x1F4DA60 VA: 0x181F4F460
	public static MissionReward Deserialize(Stream stream) { }

	// RVA: 0x1F4EED0 Offset: 0x1F4D4D0 VA: 0x181F4EED0
	public static MissionReward DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F4F1A0 Offset: 0x1F4D7A0 VA: 0x181F4F1A0
	public static MissionReward DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F4F620 Offset: 0x1F4DC20 VA: 0x181F4F620
	public static MissionReward Deserialize(byte[] buffer) { }

	// RVA: 0x1F4FCE0 Offset: 0x1F4E2E0 VA: 0x181F4FCE0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F503C0 Offset: 0x1F4E9C0 VA: 0x181F503C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F503E0 Offset: 0x1F4E9E0 VA: 0x181F503E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MissionReward previous) { }

	// RVA: 0x1F4FE60 Offset: 0x1F4E460 VA: 0x181F4FE60 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F4F890 Offset: 0x1F4DE90 VA: 0x181F4F890
	public static MissionReward Deserialize(byte[] buffer, MissionReward instance, bool isDelta = False) { }

	// RVA: 0x1F4FAE0 Offset: 0x1F4E0E0 VA: 0x181F4FAE0
	public static MissionReward Deserialize(Stream stream, MissionReward instance, bool isDelta) { }

	// RVA: 0x1F4EF50 Offset: 0x1F4D550 VA: 0x181F4EF50
	public static MissionReward DeserializeLengthDelimited(Stream stream, MissionReward instance, bool isDelta) { }

	// RVA: 0x1F4F230 Offset: 0x1F4D830 VA: 0x181F4F230
	public static MissionReward DeserializeLength(Stream stream, int length, MissionReward instance, bool isDelta) { }

	// RVA: 0x1F4FF80 Offset: 0x1F4E580 VA: 0x181F4FF80
	public static void SerializeDelta(Stream stream, MissionReward instance, MissionReward previous) { }

	// RVA: 0x1F502B0 Offset: 0x1F4E8B0 VA: 0x181F502B0
	public static void Serialize(Stream stream, MissionReward instance) { }

	// RVA: 0x1F503B0 Offset: 0x1F4E9B0 VA: 0x181F503B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F503C0 Offset: 0x1F4E9C0 VA: 0x181F503C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F501A0 Offset: 0x1F4E7A0 VA: 0x181F501A0
	public static byte[] SerializeToBytes(MissionReward instance) { }

	// RVA: 0x1F500F0 Offset: 0x1F4E6F0 VA: 0x181F500F0
	public static void SerializeLengthDelimited(Stream stream, MissionReward instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

