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

	// RVA: 0x1FF2FD0 Offset: 0x1FF15D0 VA: 0x181FF2FD0
	public static void ResetToPool(ArcadeMachine instance) { }

	// RVA: 0x1FF2D90 Offset: 0x1FF1390 VA: 0x181FF2D90
	public void ResetToPool() { }

	// RVA: 0x1FF2CD0 Offset: 0x1FF12D0 VA: 0x181FF2CD0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1FF18F0 Offset: 0x1FEFEF0 VA: 0x181FF18F0
	public void CopyTo(ArcadeMachine instance) { }

	// RVA: 0x1FF1AE0 Offset: 0x1FF00E0 VA: 0x181FF1AE0
	public ArcadeMachine Copy() { }

	// RVA: 0x1FF2840 Offset: 0x1FF0E40 VA: 0x181FF2840
	public static ArcadeMachine Deserialize(Stream stream) { }

	// RVA: 0x1FF2050 Offset: 0x1FF0650 VA: 0x181FF2050
	public static ArcadeMachine DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1FF20D0 Offset: 0x1FF06D0 VA: 0x181FF20D0
	public static ArcadeMachine DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1FF2720 Offset: 0x1FF0D20 VA: 0x181FF2720
	public static ArcadeMachine Deserialize(byte[] buffer) { }

	// RVA: 0x1FF2D50 Offset: 0x1FF1350 VA: 0x181FF2D50
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1FF3BE0 Offset: 0x1FF21E0 VA: 0x181FF3BE0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1FF3C00 Offset: 0x1FF2200 VA: 0x181FF3C00 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ArcadeMachine previous) { }

	// RVA: 0x1FF2D70 Offset: 0x1FF1370 VA: 0x181FF2D70 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1FF2620 Offset: 0x1FF0C20 VA: 0x181FF2620
	public static ArcadeMachine Deserialize(byte[] buffer, ArcadeMachine instance, bool isDelta = False) { }

	// RVA: 0x1FF28C0 Offset: 0x1FF0EC0 VA: 0x181FF28C0
	public static ArcadeMachine Deserialize(Stream stream, ArcadeMachine instance, bool isDelta) { }

	// RVA: 0x1FF1B60 Offset: 0x1FF0160 VA: 0x181FF1B60
	public static ArcadeMachine DeserializeLengthDelimited(Stream stream, ArcadeMachine instance, bool isDelta) { }

	// RVA: 0x1FF2160 Offset: 0x1FF0760 VA: 0x181FF2160
	public static ArcadeMachine DeserializeLength(Stream stream, int length, ArcadeMachine instance, bool isDelta) { }

	// RVA: 0x1FF3210 Offset: 0x1FF1810 VA: 0x181FF3210
	public static void SerializeDelta(Stream stream, ArcadeMachine instance, ArcadeMachine previous) { }

	// RVA: 0x1FF38A0 Offset: 0x1FF1EA0 VA: 0x181FF38A0
	public static void Serialize(Stream stream, ArcadeMachine instance) { }

	// RVA: 0x1FF3BD0 Offset: 0x1FF21D0 VA: 0x181FF3BD0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1FF3BE0 Offset: 0x1FF21E0 VA: 0x181FF3BE0
	public void ToProto(Stream stream) { }

	// RVA: 0x1FF3790 Offset: 0x1FF1D90 VA: 0x181FF3790
	public static byte[] SerializeToBytes(ArcadeMachine instance) { }

	// RVA: 0x1FF36E0 Offset: 0x1FF1CE0 VA: 0x181FF36E0
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

	// RVA: 0x2006C40 Offset: 0x2005240 VA: 0x182006C40
	public static void ResetToPool(ArcadeMachine.ScoreEntry instance) { }

	// RVA: 0x2006CF0 Offset: 0x20052F0 VA: 0x182006CF0
	public void ResetToPool() { }

	// RVA: 0x20069E0 Offset: 0x2004FE0 VA: 0x1820069E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20059F0 Offset: 0x2003FF0 VA: 0x1820059F0
	public void CopyTo(ArcadeMachine.ScoreEntry instance) { }

	// RVA: 0x2005A40 Offset: 0x2004040 VA: 0x182005A40
	public ArcadeMachine.ScoreEntry Copy() { }

	// RVA: 0x2006550 Offset: 0x2004B50 VA: 0x182006550
	public static ArcadeMachine.ScoreEntry Deserialize(Stream stream) { }

	// RVA: 0x2005AD0 Offset: 0x20040D0 VA: 0x182005AD0
	public static ArcadeMachine.ScoreEntry DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2005DE0 Offset: 0x20043E0 VA: 0x182005DE0
	public static ArcadeMachine.ScoreEntry DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20062A0 Offset: 0x20048A0 VA: 0x1820062A0
	public static ArcadeMachine.ScoreEntry Deserialize(byte[] buffer) { }

	// RVA: 0x2006A60 Offset: 0x2005060 VA: 0x182006A60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20072E0 Offset: 0x20058E0 VA: 0x1820072E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2007300 Offset: 0x2005900 VA: 0x182007300 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ArcadeMachine.ScoreEntry previous) { }

	// RVA: 0x2006C20 Offset: 0x2005220 VA: 0x182006C20 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2006750 Offset: 0x2004D50 VA: 0x182006750
	public static ArcadeMachine.ScoreEntry Deserialize(byte[] buffer, ArcadeMachine.ScoreEntry instance, bool isDelta = False) { }

	// RVA: 0x20060E0 Offset: 0x20046E0 VA: 0x1820060E0
	public static ArcadeMachine.ScoreEntry Deserialize(Stream stream, ArcadeMachine.ScoreEntry instance, bool isDelta) { }

	// RVA: 0x2005B50 Offset: 0x2004150 VA: 0x182005B50
	public static ArcadeMachine.ScoreEntry DeserializeLengthDelimited(Stream stream, ArcadeMachine.ScoreEntry instance, bool isDelta) { }

	// RVA: 0x2005E70 Offset: 0x2004470 VA: 0x182005E70
	public static ArcadeMachine.ScoreEntry DeserializeLength(Stream stream, int length, ArcadeMachine.ScoreEntry instance, bool isDelta) { }

	// RVA: 0x2006DA0 Offset: 0x20053A0 VA: 0x182006DA0
	public static void SerializeDelta(Stream stream, ArcadeMachine.ScoreEntry instance, ArcadeMachine.ScoreEntry previous) { }

	// RVA: 0x2007140 Offset: 0x2005740 VA: 0x182007140
	public static void Serialize(Stream stream, ArcadeMachine.ScoreEntry instance) { }

	// RVA: 0x20072D0 Offset: 0x20058D0 VA: 0x1820072D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20072E0 Offset: 0x20058E0 VA: 0x1820072E0
	public void ToProto(Stream stream) { }

	// RVA: 0x2007030 Offset: 0x2005630 VA: 0x182007030
	public static byte[] SerializeToBytes(ArcadeMachine.ScoreEntry instance) { }

	// RVA: 0x2006F80 Offset: 0x2005580 VA: 0x182006F80
	public static void SerializeLengthDelimited(Stream stream, ArcadeMachine.ScoreEntry instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

