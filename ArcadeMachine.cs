public class ArcadeMachine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6364
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<ArcadeMachine.ScoreEntry> scores; // 0x18
	public int genericInt1; // 0x20
	public int genericInt2; // 0x24
	public int genericInt3; // 0x28
	public int genericInt4; // 0x2C
	public float genericFloat1; // 0x30
	public float genericFloat2; // 0x34
	public float genericFloat3; // 0x38
	public float genericFloat4; // 0x3C

	// Methods

	// RVA: 0x1FF3AB0 Offset: 0x1FF20B0 VA: 0x181FF3AB0
	public static void ResetToPool(ArcadeMachine instance) { }

	// RVA: 0x1FF3870 Offset: 0x1FF1E70 VA: 0x181FF3870
	public void ResetToPool() { }

	// RVA: 0x1FF37B0 Offset: 0x1FF1DB0 VA: 0x181FF37B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1FF23D0 Offset: 0x1FF09D0 VA: 0x181FF23D0
	public void CopyTo(ArcadeMachine instance) { }

	// RVA: 0x1FF25C0 Offset: 0x1FF0BC0 VA: 0x181FF25C0
	public ArcadeMachine Copy() { }

	// RVA: 0x1FF3320 Offset: 0x1FF1920 VA: 0x181FF3320
	public static ArcadeMachine Deserialize(Stream stream) { }

	// RVA: 0x1FF2B30 Offset: 0x1FF1130 VA: 0x181FF2B30
	public static ArcadeMachine DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1FF2BB0 Offset: 0x1FF11B0 VA: 0x181FF2BB0
	public static ArcadeMachine DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1FF3200 Offset: 0x1FF1800 VA: 0x181FF3200
	public static ArcadeMachine Deserialize(byte[] buffer) { }

	// RVA: 0x1FF3830 Offset: 0x1FF1E30 VA: 0x181FF3830
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1FF46C0 Offset: 0x1FF2CC0 VA: 0x181FF46C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1FF46E0 Offset: 0x1FF2CE0 VA: 0x181FF46E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ArcadeMachine previous) { }

	// RVA: 0x1FF3850 Offset: 0x1FF1E50 VA: 0x181FF3850 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1FF3100 Offset: 0x1FF1700 VA: 0x181FF3100
	public static ArcadeMachine Deserialize(byte[] buffer, ArcadeMachine instance, bool isDelta = False) { }

	// RVA: 0x1FF33A0 Offset: 0x1FF19A0 VA: 0x181FF33A0
	public static ArcadeMachine Deserialize(Stream stream, ArcadeMachine instance, bool isDelta) { }

	// RVA: 0x1FF2640 Offset: 0x1FF0C40 VA: 0x181FF2640
	public static ArcadeMachine DeserializeLengthDelimited(Stream stream, ArcadeMachine instance, bool isDelta) { }

	// RVA: 0x1FF2C40 Offset: 0x1FF1240 VA: 0x181FF2C40
	public static ArcadeMachine DeserializeLength(Stream stream, int length, ArcadeMachine instance, bool isDelta) { }

	// RVA: 0x1FF3CF0 Offset: 0x1FF22F0 VA: 0x181FF3CF0
	public static void SerializeDelta(Stream stream, ArcadeMachine instance, ArcadeMachine previous) { }

	// RVA: 0x1FF4380 Offset: 0x1FF2980 VA: 0x181FF4380
	public static void Serialize(Stream stream, ArcadeMachine instance) { }

	// RVA: 0x1FF46B0 Offset: 0x1FF2CB0 VA: 0x181FF46B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1FF46C0 Offset: 0x1FF2CC0 VA: 0x181FF46C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1FF4270 Offset: 0x1FF2870 VA: 0x181FF4270
	public static byte[] SerializeToBytes(ArcadeMachine instance) { }

	// RVA: 0x1FF41C0 Offset: 0x1FF27C0 VA: 0x181FF41C0
	public static void SerializeLengthDelimited(Stream stream, ArcadeMachine instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class ArcadeMachine.ScoreEntry : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6365
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong playerID; // 0x18
	public string displayName; // 0x20
	public int score; // 0x28

	// Methods

	// RVA: 0x2007720 Offset: 0x2005D20 VA: 0x182007720
	public static void ResetToPool(ArcadeMachine.ScoreEntry instance) { }

	// RVA: 0x20077D0 Offset: 0x2005DD0 VA: 0x1820077D0
	public void ResetToPool() { }

	// RVA: 0x20074C0 Offset: 0x2005AC0 VA: 0x1820074C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20064D0 Offset: 0x2004AD0 VA: 0x1820064D0
	public void CopyTo(ArcadeMachine.ScoreEntry instance) { }

	// RVA: 0x2006520 Offset: 0x2004B20 VA: 0x182006520
	public ArcadeMachine.ScoreEntry Copy() { }

	// RVA: 0x2007030 Offset: 0x2005630 VA: 0x182007030
	public static ArcadeMachine.ScoreEntry Deserialize(Stream stream) { }

	// RVA: 0x20065B0 Offset: 0x2004BB0 VA: 0x1820065B0
	public static ArcadeMachine.ScoreEntry DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20068C0 Offset: 0x2004EC0 VA: 0x1820068C0
	public static ArcadeMachine.ScoreEntry DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2006D80 Offset: 0x2005380 VA: 0x182006D80
	public static ArcadeMachine.ScoreEntry Deserialize(byte[] buffer) { }

	// RVA: 0x2007540 Offset: 0x2005B40 VA: 0x182007540
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2007DC0 Offset: 0x20063C0 VA: 0x182007DC0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2007DE0 Offset: 0x20063E0 VA: 0x182007DE0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ArcadeMachine.ScoreEntry previous) { }

	// RVA: 0x2007700 Offset: 0x2005D00 VA: 0x182007700 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2007230 Offset: 0x2005830 VA: 0x182007230
	public static ArcadeMachine.ScoreEntry Deserialize(byte[] buffer, ArcadeMachine.ScoreEntry instance, bool isDelta = False) { }

	// RVA: 0x2006BC0 Offset: 0x20051C0 VA: 0x182006BC0
	public static ArcadeMachine.ScoreEntry Deserialize(Stream stream, ArcadeMachine.ScoreEntry instance, bool isDelta) { }

	// RVA: 0x2006630 Offset: 0x2004C30 VA: 0x182006630
	public static ArcadeMachine.ScoreEntry DeserializeLengthDelimited(Stream stream, ArcadeMachine.ScoreEntry instance, bool isDelta) { }

	// RVA: 0x2006950 Offset: 0x2004F50 VA: 0x182006950
	public static ArcadeMachine.ScoreEntry DeserializeLength(Stream stream, int length, ArcadeMachine.ScoreEntry instance, bool isDelta) { }

	// RVA: 0x2007880 Offset: 0x2005E80 VA: 0x182007880
	public static void SerializeDelta(Stream stream, ArcadeMachine.ScoreEntry instance, ArcadeMachine.ScoreEntry previous) { }

	// RVA: 0x2007C20 Offset: 0x2006220 VA: 0x182007C20
	public static void Serialize(Stream stream, ArcadeMachine.ScoreEntry instance) { }

	// RVA: 0x2007DB0 Offset: 0x20063B0 VA: 0x182007DB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x2007DC0 Offset: 0x20063C0 VA: 0x182007DC0
	public void ToProto(Stream stream) { }

	// RVA: 0x2007B10 Offset: 0x2006110 VA: 0x182007B10
	public static byte[] SerializeToBytes(ArcadeMachine.ScoreEntry instance) { }

	// RVA: 0x2007A60 Offset: 0x2006060 VA: 0x182007A60
	public static void SerializeLengthDelimited(Stream stream, ArcadeMachine.ScoreEntry instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

