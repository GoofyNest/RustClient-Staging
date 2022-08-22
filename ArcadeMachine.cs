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

	// RVA: 0x1FF3290 Offset: 0x1FF1890 VA: 0x181FF3290
	public static void ResetToPool(ArcadeMachine instance) { }

	// RVA: 0x1FF3050 Offset: 0x1FF1650 VA: 0x181FF3050
	public void ResetToPool() { }

	// RVA: 0x1FF2F90 Offset: 0x1FF1590 VA: 0x181FF2F90 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1FF1BB0 Offset: 0x1FF01B0 VA: 0x181FF1BB0
	public void CopyTo(ArcadeMachine instance) { }

	// RVA: 0x1FF1DA0 Offset: 0x1FF03A0 VA: 0x181FF1DA0
	public ArcadeMachine Copy() { }

	// RVA: 0x1FF2B00 Offset: 0x1FF1100 VA: 0x181FF2B00
	public static ArcadeMachine Deserialize(Stream stream) { }

	// RVA: 0x1FF2310 Offset: 0x1FF0910 VA: 0x181FF2310
	public static ArcadeMachine DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1FF2390 Offset: 0x1FF0990 VA: 0x181FF2390
	public static ArcadeMachine DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1FF29E0 Offset: 0x1FF0FE0 VA: 0x181FF29E0
	public static ArcadeMachine Deserialize(byte[] buffer) { }

	// RVA: 0x1FF3010 Offset: 0x1FF1610 VA: 0x181FF3010
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1FF3EA0 Offset: 0x1FF24A0 VA: 0x181FF3EA0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1FF3EC0 Offset: 0x1FF24C0 VA: 0x181FF3EC0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ArcadeMachine previous) { }

	// RVA: 0x1FF3030 Offset: 0x1FF1630 VA: 0x181FF3030 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1FF28E0 Offset: 0x1FF0EE0 VA: 0x181FF28E0
	public static ArcadeMachine Deserialize(byte[] buffer, ArcadeMachine instance, bool isDelta = False) { }

	// RVA: 0x1FF2B80 Offset: 0x1FF1180 VA: 0x181FF2B80
	public static ArcadeMachine Deserialize(Stream stream, ArcadeMachine instance, bool isDelta) { }

	// RVA: 0x1FF1E20 Offset: 0x1FF0420 VA: 0x181FF1E20
	public static ArcadeMachine DeserializeLengthDelimited(Stream stream, ArcadeMachine instance, bool isDelta) { }

	// RVA: 0x1FF2420 Offset: 0x1FF0A20 VA: 0x181FF2420
	public static ArcadeMachine DeserializeLength(Stream stream, int length, ArcadeMachine instance, bool isDelta) { }

	// RVA: 0x1FF34D0 Offset: 0x1FF1AD0 VA: 0x181FF34D0
	public static void SerializeDelta(Stream stream, ArcadeMachine instance, ArcadeMachine previous) { }

	// RVA: 0x1FF3B60 Offset: 0x1FF2160 VA: 0x181FF3B60
	public static void Serialize(Stream stream, ArcadeMachine instance) { }

	// RVA: 0x1FF3E90 Offset: 0x1FF2490 VA: 0x181FF3E90
	public byte[] ToProtoBytes() { }

	// RVA: 0x1FF3EA0 Offset: 0x1FF24A0 VA: 0x181FF3EA0
	public void ToProto(Stream stream) { }

	// RVA: 0x1FF3A50 Offset: 0x1FF2050 VA: 0x181FF3A50
	public static byte[] SerializeToBytes(ArcadeMachine instance) { }

	// RVA: 0x1FF39A0 Offset: 0x1FF1FA0 VA: 0x181FF39A0
	public static void SerializeLengthDelimited(Stream stream, ArcadeMachine instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x2006F00 Offset: 0x2005500 VA: 0x182006F00
	public static void ResetToPool(ArcadeMachine.ScoreEntry instance) { }

	// RVA: 0x2006FB0 Offset: 0x20055B0 VA: 0x182006FB0
	public void ResetToPool() { }

	// RVA: 0x2006CA0 Offset: 0x20052A0 VA: 0x182006CA0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2005CB0 Offset: 0x20042B0 VA: 0x182005CB0
	public void CopyTo(ArcadeMachine.ScoreEntry instance) { }

	// RVA: 0x2005D00 Offset: 0x2004300 VA: 0x182005D00
	public ArcadeMachine.ScoreEntry Copy() { }

	// RVA: 0x2006810 Offset: 0x2004E10 VA: 0x182006810
	public static ArcadeMachine.ScoreEntry Deserialize(Stream stream) { }

	// RVA: 0x2005D90 Offset: 0x2004390 VA: 0x182005D90
	public static ArcadeMachine.ScoreEntry DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20060A0 Offset: 0x20046A0 VA: 0x1820060A0
	public static ArcadeMachine.ScoreEntry DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2006560 Offset: 0x2004B60 VA: 0x182006560
	public static ArcadeMachine.ScoreEntry Deserialize(byte[] buffer) { }

	// RVA: 0x2006D20 Offset: 0x2005320 VA: 0x182006D20
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20075A0 Offset: 0x2005BA0 VA: 0x1820075A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20075C0 Offset: 0x2005BC0 VA: 0x1820075C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ArcadeMachine.ScoreEntry previous) { }

	// RVA: 0x2006EE0 Offset: 0x20054E0 VA: 0x182006EE0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2006A10 Offset: 0x2005010 VA: 0x182006A10
	public static ArcadeMachine.ScoreEntry Deserialize(byte[] buffer, ArcadeMachine.ScoreEntry instance, bool isDelta = False) { }

	// RVA: 0x20063A0 Offset: 0x20049A0 VA: 0x1820063A0
	public static ArcadeMachine.ScoreEntry Deserialize(Stream stream, ArcadeMachine.ScoreEntry instance, bool isDelta) { }

	// RVA: 0x2005E10 Offset: 0x2004410 VA: 0x182005E10
	public static ArcadeMachine.ScoreEntry DeserializeLengthDelimited(Stream stream, ArcadeMachine.ScoreEntry instance, bool isDelta) { }

	// RVA: 0x2006130 Offset: 0x2004730 VA: 0x182006130
	public static ArcadeMachine.ScoreEntry DeserializeLength(Stream stream, int length, ArcadeMachine.ScoreEntry instance, bool isDelta) { }

	// RVA: 0x2007060 Offset: 0x2005660 VA: 0x182007060
	public static void SerializeDelta(Stream stream, ArcadeMachine.ScoreEntry instance, ArcadeMachine.ScoreEntry previous) { }

	// RVA: 0x2007400 Offset: 0x2005A00 VA: 0x182007400
	public static void Serialize(Stream stream, ArcadeMachine.ScoreEntry instance) { }

	// RVA: 0x2007590 Offset: 0x2005B90 VA: 0x182007590
	public byte[] ToProtoBytes() { }

	// RVA: 0x20075A0 Offset: 0x2005BA0 VA: 0x1820075A0
	public void ToProto(Stream stream) { }

	// RVA: 0x20072F0 Offset: 0x20058F0 VA: 0x1820072F0
	public static byte[] SerializeToBytes(ArcadeMachine.ScoreEntry instance) { }

	// RVA: 0x2007240 Offset: 0x2005840 VA: 0x182007240
	public static void SerializeLengthDelimited(Stream stream, ArcadeMachine.ScoreEntry instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

