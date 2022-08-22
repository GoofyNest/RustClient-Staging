public class ArcadeGame : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6500
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<ArcadeGame.arcadeEnt> arcadeEnts; // 0x18

	// Methods

	// RVA: 0x1FF1170 Offset: 0x1FEF770 VA: 0x181FF1170
	public static void ResetToPool(ArcadeGame instance) { }

	// RVA: 0x1FF0FC0 Offset: 0x1FEF5C0 VA: 0x181FF0FC0
	public void ResetToPool() { }

	// RVA: 0x1FF0D40 Offset: 0x1FEF340 VA: 0x181FF0D40 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1FEFFA0 Offset: 0x1FEE5A0 VA: 0x181FEFFA0
	public void CopyTo(ArcadeGame instance) { }

	// RVA: 0x1FF01B0 Offset: 0x1FEE7B0 VA: 0x181FF01B0
	public ArcadeGame Copy() { }

	// RVA: 0x1FF08B0 Offset: 0x1FEEEB0 VA: 0x181FF08B0
	public static ArcadeGame Deserialize(Stream stream) { }

	// RVA: 0x1FF0500 Offset: 0x1FEEB00 VA: 0x181FF0500
	public static ArcadeGame DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1FF0820 Offset: 0x1FEEE20 VA: 0x181FF0820
	public static ArcadeGame DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1FF0B20 Offset: 0x1FEF120 VA: 0x181FF0B20
	public static ArcadeGame Deserialize(byte[] buffer) { }

	// RVA: 0x1FF0F80 Offset: 0x1FEF580 VA: 0x181FF0F80
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1FF18B0 Offset: 0x1FEFEB0 VA: 0x181FF18B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1FF18D0 Offset: 0x1FEFED0 VA: 0x181FF18D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ArcadeGame previous) { }

	// RVA: 0x1FF0FA0 Offset: 0x1FEF5A0 VA: 0x181FF0FA0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1FF0C40 Offset: 0x1FEF240 VA: 0x181FF0C40
	public static ArcadeGame Deserialize(byte[] buffer, ArcadeGame instance, bool isDelta = False) { }

	// RVA: 0x1FF0930 Offset: 0x1FEEF30 VA: 0x181FF0930
	public static ArcadeGame Deserialize(Stream stream, ArcadeGame instance, bool isDelta) { }

	// RVA: 0x1FF0230 Offset: 0x1FEE830 VA: 0x181FF0230
	public static ArcadeGame DeserializeLengthDelimited(Stream stream, ArcadeGame instance, bool isDelta) { }

	// RVA: 0x1FF0580 Offset: 0x1FEEB80 VA: 0x181FF0580
	public static ArcadeGame DeserializeLength(Stream stream, int length, ArcadeGame instance, bool isDelta) { }

	// RVA: 0x1FF1320 Offset: 0x1FEF920 VA: 0x181FF1320
	public static void SerializeDelta(Stream stream, ArcadeGame instance, ArcadeGame previous) { }

	// RVA: 0x1FF16C0 Offset: 0x1FEFCC0 VA: 0x181FF16C0
	public static void Serialize(Stream stream, ArcadeGame instance) { }

	// RVA: 0x1FF18A0 Offset: 0x1FEFEA0 VA: 0x181FF18A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1FF18B0 Offset: 0x1FEFEB0 VA: 0x181FF18B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1FF15B0 Offset: 0x1FEFBB0 VA: 0x181FF15B0
	public static byte[] SerializeToBytes(ArcadeGame instance) { }

	// RVA: 0x1FF1500 Offset: 0x1FEFB00 VA: 0x181FF1500
	public static void SerializeLengthDelimited(Stream stream, ArcadeGame instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x20087B0 Offset: 0x2006DB0 VA: 0x1820087B0
	public static void ResetToPool(ArcadeGame.arcadeEnt instance) { }

	// RVA: 0x2008920 Offset: 0x2006F20 VA: 0x182008920
	public void ResetToPool() { }

	// RVA: 0x20086F0 Offset: 0x2006CF0 VA: 0x1820086F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2007320 Offset: 0x2005920 VA: 0x182007320
	public void CopyTo(ArcadeGame.arcadeEnt instance) { }

	// RVA: 0x20073D0 Offset: 0x20059D0 VA: 0x1820073D0
	public ArcadeGame.arcadeEnt Copy() { }

	// RVA: 0x2008000 Offset: 0x2006600 VA: 0x182008000
	public static ArcadeGame.arcadeEnt Deserialize(Stream stream) { }

	// RVA: 0x20079F0 Offset: 0x2005FF0 VA: 0x1820079F0
	public static ArcadeGame.arcadeEnt DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2007F70 Offset: 0x2006570 VA: 0x182007F70
	public static ArcadeGame.arcadeEnt DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2008080 Offset: 0x2006680 VA: 0x182008080
	public static ArcadeGame.arcadeEnt Deserialize(byte[] buffer) { }

	// RVA: 0x2008770 Offset: 0x2006D70 VA: 0x182008770
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2009B40 Offset: 0x2008140 VA: 0x182009B40 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2009B60 Offset: 0x2008160 VA: 0x182009B60 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ArcadeGame.arcadeEnt previous) { }

	// RVA: 0x2008790 Offset: 0x2006D90 VA: 0x182008790 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20085F0 Offset: 0x2006BF0 VA: 0x1820085F0
	public static ArcadeGame.arcadeEnt Deserialize(byte[] buffer, ArcadeGame.arcadeEnt instance, bool isDelta = False) { }

	// RVA: 0x20081A0 Offset: 0x20067A0 VA: 0x1820081A0
	public static ArcadeGame.arcadeEnt Deserialize(Stream stream, ArcadeGame.arcadeEnt instance, bool isDelta) { }

	// RVA: 0x20074D0 Offset: 0x2005AD0 VA: 0x1820074D0
	public static ArcadeGame.arcadeEnt DeserializeLengthDelimited(Stream stream, ArcadeGame.arcadeEnt instance, bool isDelta) { }

	// RVA: 0x2007A70 Offset: 0x2006070 VA: 0x182007A70
	public static ArcadeGame.arcadeEnt DeserializeLength(Stream stream, int length, ArcadeGame.arcadeEnt instance, bool isDelta) { }

	// RVA: 0x2008A90 Offset: 0x2007090 VA: 0x182008A90
	public static void SerializeDelta(Stream stream, ArcadeGame.arcadeEnt instance, ArcadeGame.arcadeEnt previous) { }

	// RVA: 0x20095A0 Offset: 0x2007BA0 VA: 0x1820095A0
	public static void Serialize(Stream stream, ArcadeGame.arcadeEnt instance) { }

	// RVA: 0x2009B30 Offset: 0x2008130 VA: 0x182009B30
	public byte[] ToProtoBytes() { }

	// RVA: 0x2009B40 Offset: 0x2008140 VA: 0x182009B40
	public void ToProto(Stream stream) { }

	// RVA: 0x2009490 Offset: 0x2007A90 VA: 0x182009490
	public static byte[] SerializeToBytes(ArcadeGame.arcadeEnt instance) { }

	// RVA: 0x20093E0 Offset: 0x20079E0 VA: 0x1820093E0
	public static void SerializeLengthDelimited(Stream stream, ArcadeGame.arcadeEnt instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

