public class MissionReward : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6452
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int itemID; // 0x14
	public int itemAmount; // 0x18

	// Methods

	// RVA: 0x1F50720 Offset: 0x1F4ED20 VA: 0x181F50720
	public static void ResetToPool(MissionReward instance) { }

	// RVA: 0x1F506A0 Offset: 0x1F4ECA0 VA: 0x181F506A0
	public void ResetToPool() { }

	// RVA: 0x1F50480 Offset: 0x1F4EA80 VA: 0x181F50480 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBF390 Offset: 0x1DBD990 VA: 0x181DBF390
	public void CopyTo(MissionReward instance) { }

	// RVA: 0x1F4F680 Offset: 0x1F4DC80 VA: 0x181F4F680
	public MissionReward Copy() { }

	// RVA: 0x1F4FC80 Offset: 0x1F4E280 VA: 0x181F4FC80
	public static MissionReward Deserialize(Stream stream) { }

	// RVA: 0x1F4F6F0 Offset: 0x1F4DCF0 VA: 0x181F4F6F0
	public static MissionReward DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F4F9C0 Offset: 0x1F4DFC0 VA: 0x181F4F9C0
	public static MissionReward DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F4FE40 Offset: 0x1F4E440 VA: 0x181F4FE40
	public static MissionReward Deserialize(byte[] buffer) { }

	// RVA: 0x1F50500 Offset: 0x1F4EB00 VA: 0x181F50500
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F50BE0 Offset: 0x1F4F1E0 VA: 0x181F50BE0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F50C00 Offset: 0x1F4F200 VA: 0x181F50C00 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MissionReward previous) { }

	// RVA: 0x1F50680 Offset: 0x1F4EC80 VA: 0x181F50680 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F500B0 Offset: 0x1F4E6B0 VA: 0x181F500B0
	public static MissionReward Deserialize(byte[] buffer, MissionReward instance, bool isDelta = False) { }

	// RVA: 0x1F50300 Offset: 0x1F4E900 VA: 0x181F50300
	public static MissionReward Deserialize(Stream stream, MissionReward instance, bool isDelta) { }

	// RVA: 0x1F4F770 Offset: 0x1F4DD70 VA: 0x181F4F770
	public static MissionReward DeserializeLengthDelimited(Stream stream, MissionReward instance, bool isDelta) { }

	// RVA: 0x1F4FA50 Offset: 0x1F4E050 VA: 0x181F4FA50
	public static MissionReward DeserializeLength(Stream stream, int length, MissionReward instance, bool isDelta) { }

	// RVA: 0x1F507A0 Offset: 0x1F4EDA0 VA: 0x181F507A0
	public static void SerializeDelta(Stream stream, MissionReward instance, MissionReward previous) { }

	// RVA: 0x1F50AD0 Offset: 0x1F4F0D0 VA: 0x181F50AD0
	public static void Serialize(Stream stream, MissionReward instance) { }

	// RVA: 0x1F50BD0 Offset: 0x1F4F1D0 VA: 0x181F50BD0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F50BE0 Offset: 0x1F4F1E0 VA: 0x181F50BE0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F509C0 Offset: 0x1F4EFC0 VA: 0x181F509C0
	public static byte[] SerializeToBytes(MissionReward instance) { }

	// RVA: 0x1F50910 Offset: 0x1F4EF10 VA: 0x181F50910
	public static void SerializeLengthDelimited(Stream stream, MissionReward instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

