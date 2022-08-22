public class ArcadeGame : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6500
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<ArcadeGame.arcadeEnt> arcadeEnts; // 0x18

	// Methods

	// RVA: 0x1FF1C50 Offset: 0x1FF0250 VA: 0x181FF1C50
	public static void ResetToPool(ArcadeGame instance) { }

	// RVA: 0x1FF1AA0 Offset: 0x1FF00A0 VA: 0x181FF1AA0
	public void ResetToPool() { }

	// RVA: 0x1FF1820 Offset: 0x1FEFE20 VA: 0x181FF1820 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1FF0A80 Offset: 0x1FEF080 VA: 0x181FF0A80
	public void CopyTo(ArcadeGame instance) { }

	// RVA: 0x1FF0C90 Offset: 0x1FEF290 VA: 0x181FF0C90
	public ArcadeGame Copy() { }

	// RVA: 0x1FF1390 Offset: 0x1FEF990 VA: 0x181FF1390
	public static ArcadeGame Deserialize(Stream stream) { }

	// RVA: 0x1FF0FE0 Offset: 0x1FEF5E0 VA: 0x181FF0FE0
	public static ArcadeGame DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1FF1300 Offset: 0x1FEF900 VA: 0x181FF1300
	public static ArcadeGame DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1FF1600 Offset: 0x1FEFC00 VA: 0x181FF1600
	public static ArcadeGame Deserialize(byte[] buffer) { }

	// RVA: 0x1FF1A60 Offset: 0x1FF0060 VA: 0x181FF1A60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1FF2390 Offset: 0x1FF0990 VA: 0x181FF2390 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1FF23B0 Offset: 0x1FF09B0 VA: 0x181FF23B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ArcadeGame previous) { }

	// RVA: 0x1FF1A80 Offset: 0x1FF0080 VA: 0x181FF1A80 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1FF1720 Offset: 0x1FEFD20 VA: 0x181FF1720
	public static ArcadeGame Deserialize(byte[] buffer, ArcadeGame instance, bool isDelta = False) { }

	// RVA: 0x1FF1410 Offset: 0x1FEFA10 VA: 0x181FF1410
	public static ArcadeGame Deserialize(Stream stream, ArcadeGame instance, bool isDelta) { }

	// RVA: 0x1FF0D10 Offset: 0x1FEF310 VA: 0x181FF0D10
	public static ArcadeGame DeserializeLengthDelimited(Stream stream, ArcadeGame instance, bool isDelta) { }

	// RVA: 0x1FF1060 Offset: 0x1FEF660 VA: 0x181FF1060
	public static ArcadeGame DeserializeLength(Stream stream, int length, ArcadeGame instance, bool isDelta) { }

	// RVA: 0x1FF1E00 Offset: 0x1FF0400 VA: 0x181FF1E00
	public static void SerializeDelta(Stream stream, ArcadeGame instance, ArcadeGame previous) { }

	// RVA: 0x1FF21A0 Offset: 0x1FF07A0 VA: 0x181FF21A0
	public static void Serialize(Stream stream, ArcadeGame instance) { }

	// RVA: 0x1FF2380 Offset: 0x1FF0980 VA: 0x181FF2380
	public byte[] ToProtoBytes() { }

	// RVA: 0x1FF2390 Offset: 0x1FF0990 VA: 0x181FF2390
	public void ToProto(Stream stream) { }

	// RVA: 0x1FF2090 Offset: 0x1FF0690 VA: 0x181FF2090
	public static byte[] SerializeToBytes(ArcadeGame instance) { }

	// RVA: 0x1FF1FE0 Offset: 0x1FF05E0 VA: 0x181FF1FE0
	public static void SerializeLengthDelimited(Stream stream, ArcadeGame instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class ArcadeGame.arcadeEnt : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6501
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint id; // 0x14
	public string name; // 0x18
	public uint spriteID; // 0x20
	public uint soundID; // 0x24
	public bool visible; // 0x28
	public Vector3 position; // 0x2C
	public Vector3 heading; // 0x38
	public bool enabled; // 0x44
	public Vector3 scale; // 0x48
	public Vector3 colliderScale; // 0x54
	public float alpha; // 0x60
	public uint prefabID; // 0x64
	public uint parentID; // 0x68

	// Methods

	// RVA: 0x2009290 Offset: 0x2007890 VA: 0x182009290
	public static void ResetToPool(ArcadeGame.arcadeEnt instance) { }

	// RVA: 0x2009400 Offset: 0x2007A00 VA: 0x182009400
	public void ResetToPool() { }

	// RVA: 0x20091D0 Offset: 0x20077D0 VA: 0x1820091D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2007E00 Offset: 0x2006400 VA: 0x182007E00
	public void CopyTo(ArcadeGame.arcadeEnt instance) { }

	// RVA: 0x2007EB0 Offset: 0x20064B0 VA: 0x182007EB0
	public ArcadeGame.arcadeEnt Copy() { }

	// RVA: 0x2008AE0 Offset: 0x20070E0 VA: 0x182008AE0
	public static ArcadeGame.arcadeEnt Deserialize(Stream stream) { }

	// RVA: 0x20084D0 Offset: 0x2006AD0 VA: 0x1820084D0
	public static ArcadeGame.arcadeEnt DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2008A50 Offset: 0x2007050 VA: 0x182008A50
	public static ArcadeGame.arcadeEnt DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2008B60 Offset: 0x2007160 VA: 0x182008B60
	public static ArcadeGame.arcadeEnt Deserialize(byte[] buffer) { }

	// RVA: 0x2009250 Offset: 0x2007850 VA: 0x182009250
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x200A620 Offset: 0x2008C20 VA: 0x18200A620 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x200A640 Offset: 0x2008C40 VA: 0x18200A640 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ArcadeGame.arcadeEnt previous) { }

	// RVA: 0x2009270 Offset: 0x2007870 VA: 0x182009270 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20090D0 Offset: 0x20076D0 VA: 0x1820090D0
	public static ArcadeGame.arcadeEnt Deserialize(byte[] buffer, ArcadeGame.arcadeEnt instance, bool isDelta = False) { }

	// RVA: 0x2008C80 Offset: 0x2007280 VA: 0x182008C80
	public static ArcadeGame.arcadeEnt Deserialize(Stream stream, ArcadeGame.arcadeEnt instance, bool isDelta) { }

	// RVA: 0x2007FB0 Offset: 0x20065B0 VA: 0x182007FB0
	public static ArcadeGame.arcadeEnt DeserializeLengthDelimited(Stream stream, ArcadeGame.arcadeEnt instance, bool isDelta) { }

	// RVA: 0x2008550 Offset: 0x2006B50 VA: 0x182008550
	public static ArcadeGame.arcadeEnt DeserializeLength(Stream stream, int length, ArcadeGame.arcadeEnt instance, bool isDelta) { }

	// RVA: 0x2009570 Offset: 0x2007B70 VA: 0x182009570
	public static void SerializeDelta(Stream stream, ArcadeGame.arcadeEnt instance, ArcadeGame.arcadeEnt previous) { }

	// RVA: 0x200A080 Offset: 0x2008680 VA: 0x18200A080
	public static void Serialize(Stream stream, ArcadeGame.arcadeEnt instance) { }

	// RVA: 0x200A610 Offset: 0x2008C10 VA: 0x18200A610
	public byte[] ToProtoBytes() { }

	// RVA: 0x200A620 Offset: 0x2008C20 VA: 0x18200A620
	public void ToProto(Stream stream) { }

	// RVA: 0x2009F70 Offset: 0x2008570 VA: 0x182009F70
	public static byte[] SerializeToBytes(ArcadeGame.arcadeEnt instance) { }

	// RVA: 0x2009EC0 Offset: 0x20084C0 VA: 0x182009EC0
	public static void SerializeLengthDelimited(Stream stream, ArcadeGame.arcadeEnt instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

