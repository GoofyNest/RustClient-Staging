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

	// RVA: 0x1FF3190 Offset: 0x1FF1790 VA: 0x181FF3190
	public static void ResetToPool(ArcadeMachine instance) { }

	// RVA: 0x1FF2F50 Offset: 0x1FF1550 VA: 0x181FF2F50
	public void ResetToPool() { }

	// RVA: 0x1FF2E90 Offset: 0x1FF1490 VA: 0x181FF2E90 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1FF1AB0 Offset: 0x1FF00B0 VA: 0x181FF1AB0
	public void CopyTo(ArcadeMachine instance) { }

	// RVA: 0x1FF1CA0 Offset: 0x1FF02A0 VA: 0x181FF1CA0
	public ArcadeMachine Copy() { }

	// RVA: 0x1FF2A00 Offset: 0x1FF1000 VA: 0x181FF2A00
	public static ArcadeMachine Deserialize(Stream stream) { }

	// RVA: 0x1FF2210 Offset: 0x1FF0810 VA: 0x181FF2210
	public static ArcadeMachine DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1FF2290 Offset: 0x1FF0890 VA: 0x181FF2290
	public static ArcadeMachine DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1FF28E0 Offset: 0x1FF0EE0 VA: 0x181FF28E0
	public static ArcadeMachine Deserialize(byte[] buffer) { }

	// RVA: 0x1FF2F10 Offset: 0x1FF1510 VA: 0x181FF2F10
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1FF3DA0 Offset: 0x1FF23A0 VA: 0x181FF3DA0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1FF3DC0 Offset: 0x1FF23C0 VA: 0x181FF3DC0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ArcadeMachine previous) { }

	// RVA: 0x1FF2F30 Offset: 0x1FF1530 VA: 0x181FF2F30 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1FF27E0 Offset: 0x1FF0DE0 VA: 0x181FF27E0
	public static ArcadeMachine Deserialize(byte[] buffer, ArcadeMachine instance, bool isDelta = False) { }

	// RVA: 0x1FF2A80 Offset: 0x1FF1080 VA: 0x181FF2A80
	public static ArcadeMachine Deserialize(Stream stream, ArcadeMachine instance, bool isDelta) { }

	// RVA: 0x1FF1D20 Offset: 0x1FF0320 VA: 0x181FF1D20
	public static ArcadeMachine DeserializeLengthDelimited(Stream stream, ArcadeMachine instance, bool isDelta) { }

	// RVA: 0x1FF2320 Offset: 0x1FF0920 VA: 0x181FF2320
	public static ArcadeMachine DeserializeLength(Stream stream, int length, ArcadeMachine instance, bool isDelta) { }

	// RVA: 0x1FF33D0 Offset: 0x1FF19D0 VA: 0x181FF33D0
	public static void SerializeDelta(Stream stream, ArcadeMachine instance, ArcadeMachine previous) { }

	// RVA: 0x1FF3A60 Offset: 0x1FF2060 VA: 0x181FF3A60
	public static void Serialize(Stream stream, ArcadeMachine instance) { }

	// RVA: 0x1FF3D90 Offset: 0x1FF2390 VA: 0x181FF3D90
	public byte[] ToProtoBytes() { }

	// RVA: 0x1FF3DA0 Offset: 0x1FF23A0 VA: 0x181FF3DA0
	public void ToProto(Stream stream) { }

	// RVA: 0x1FF3950 Offset: 0x1FF1F50 VA: 0x181FF3950
	public static byte[] SerializeToBytes(ArcadeMachine instance) { }

	// RVA: 0x1FF38A0 Offset: 0x1FF1EA0 VA: 0x181FF38A0
	public static void SerializeLengthDelimited(Stream stream, ArcadeMachine instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x2006E00 Offset: 0x2005400 VA: 0x182006E00
	public static void ResetToPool(ArcadeMachine.ScoreEntry instance) { }

	// RVA: 0x2006EB0 Offset: 0x20054B0 VA: 0x182006EB0
	public void ResetToPool() { }

	// RVA: 0x2006BA0 Offset: 0x20051A0 VA: 0x182006BA0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2005BB0 Offset: 0x20041B0 VA: 0x182005BB0
	public void CopyTo(ArcadeMachine.ScoreEntry instance) { }

	// RVA: 0x2005C00 Offset: 0x2004200 VA: 0x182005C00
	public ArcadeMachine.ScoreEntry Copy() { }

	// RVA: 0x2006710 Offset: 0x2004D10 VA: 0x182006710
	public static ArcadeMachine.ScoreEntry Deserialize(Stream stream) { }

	// RVA: 0x2005C90 Offset: 0x2004290 VA: 0x182005C90
	public static ArcadeMachine.ScoreEntry DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2005FA0 Offset: 0x20045A0 VA: 0x182005FA0
	public static ArcadeMachine.ScoreEntry DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2006460 Offset: 0x2004A60 VA: 0x182006460
	public static ArcadeMachine.ScoreEntry Deserialize(byte[] buffer) { }

	// RVA: 0x2006C20 Offset: 0x2005220 VA: 0x182006C20
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20074A0 Offset: 0x2005AA0 VA: 0x1820074A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20074C0 Offset: 0x2005AC0 VA: 0x1820074C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ArcadeMachine.ScoreEntry previous) { }

	// RVA: 0x2006DE0 Offset: 0x20053E0 VA: 0x182006DE0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2006910 Offset: 0x2004F10 VA: 0x182006910
	public static ArcadeMachine.ScoreEntry Deserialize(byte[] buffer, ArcadeMachine.ScoreEntry instance, bool isDelta = False) { }

	// RVA: 0x20062A0 Offset: 0x20048A0 VA: 0x1820062A0
	public static ArcadeMachine.ScoreEntry Deserialize(Stream stream, ArcadeMachine.ScoreEntry instance, bool isDelta) { }

	// RVA: 0x2005D10 Offset: 0x2004310 VA: 0x182005D10
	public static ArcadeMachine.ScoreEntry DeserializeLengthDelimited(Stream stream, ArcadeMachine.ScoreEntry instance, bool isDelta) { }

	// RVA: 0x2006030 Offset: 0x2004630 VA: 0x182006030
	public static ArcadeMachine.ScoreEntry DeserializeLength(Stream stream, int length, ArcadeMachine.ScoreEntry instance, bool isDelta) { }

	// RVA: 0x2006F60 Offset: 0x2005560 VA: 0x182006F60
	public static void SerializeDelta(Stream stream, ArcadeMachine.ScoreEntry instance, ArcadeMachine.ScoreEntry previous) { }

	// RVA: 0x2007300 Offset: 0x2005900 VA: 0x182007300
	public static void Serialize(Stream stream, ArcadeMachine.ScoreEntry instance) { }

	// RVA: 0x2007490 Offset: 0x2005A90 VA: 0x182007490
	public byte[] ToProtoBytes() { }

	// RVA: 0x20074A0 Offset: 0x2005AA0 VA: 0x1820074A0
	public void ToProto(Stream stream) { }

	// RVA: 0x20071F0 Offset: 0x20057F0 VA: 0x1820071F0
	public static byte[] SerializeToBytes(ArcadeMachine.ScoreEntry instance) { }

	// RVA: 0x2007140 Offset: 0x2005740 VA: 0x182007140
	public static void SerializeLengthDelimited(Stream stream, ArcadeMachine.ScoreEntry instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

