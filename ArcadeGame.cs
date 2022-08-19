public class ArcadeGame : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6500
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<ArcadeGame.arcadeEnt> arcadeEnts; // 0x18

	// Methods

	// RVA: 0x1FF1330 Offset: 0x1FEF930 VA: 0x181FF1330
	public static void ResetToPool(ArcadeGame instance) { }

	// RVA: 0x1FF1180 Offset: 0x1FEF780 VA: 0x181FF1180
	public void ResetToPool() { }

	// RVA: 0x1FF0F00 Offset: 0x1FEF500 VA: 0x181FF0F00 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1FF0160 Offset: 0x1FEE760 VA: 0x181FF0160
	public void CopyTo(ArcadeGame instance) { }

	// RVA: 0x1FF0370 Offset: 0x1FEE970 VA: 0x181FF0370
	public ArcadeGame Copy() { }

	// RVA: 0x1FF0A70 Offset: 0x1FEF070 VA: 0x181FF0A70
	public static ArcadeGame Deserialize(Stream stream) { }

	// RVA: 0x1FF06C0 Offset: 0x1FEECC0 VA: 0x181FF06C0
	public static ArcadeGame DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1FF09E0 Offset: 0x1FEEFE0 VA: 0x181FF09E0
	public static ArcadeGame DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1FF0CE0 Offset: 0x1FEF2E0 VA: 0x181FF0CE0
	public static ArcadeGame Deserialize(byte[] buffer) { }

	// RVA: 0x1FF1140 Offset: 0x1FEF740 VA: 0x181FF1140
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1FF1A70 Offset: 0x1FF0070 VA: 0x181FF1A70 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1FF1A90 Offset: 0x1FF0090 VA: 0x181FF1A90 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ArcadeGame previous) { }

	// RVA: 0x1FF1160 Offset: 0x1FEF760 VA: 0x181FF1160 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1FF0E00 Offset: 0x1FEF400 VA: 0x181FF0E00
	public static ArcadeGame Deserialize(byte[] buffer, ArcadeGame instance, bool isDelta = False) { }

	// RVA: 0x1FF0AF0 Offset: 0x1FEF0F0 VA: 0x181FF0AF0
	public static ArcadeGame Deserialize(Stream stream, ArcadeGame instance, bool isDelta) { }

	// RVA: 0x1FF03F0 Offset: 0x1FEE9F0 VA: 0x181FF03F0
	public static ArcadeGame DeserializeLengthDelimited(Stream stream, ArcadeGame instance, bool isDelta) { }

	// RVA: 0x1FF0740 Offset: 0x1FEED40 VA: 0x181FF0740
	public static ArcadeGame DeserializeLength(Stream stream, int length, ArcadeGame instance, bool isDelta) { }

	// RVA: 0x1FF14E0 Offset: 0x1FEFAE0 VA: 0x181FF14E0
	public static void SerializeDelta(Stream stream, ArcadeGame instance, ArcadeGame previous) { }

	// RVA: 0x1FF1880 Offset: 0x1FEFE80 VA: 0x181FF1880
	public static void Serialize(Stream stream, ArcadeGame instance) { }

	// RVA: 0x1FF1A60 Offset: 0x1FF0060 VA: 0x181FF1A60
	public byte[] ToProtoBytes() { }

	// RVA: 0x1FF1A70 Offset: 0x1FF0070 VA: 0x181FF1A70
	public void ToProto(Stream stream) { }

	// RVA: 0x1FF1770 Offset: 0x1FEFD70 VA: 0x181FF1770
	public static byte[] SerializeToBytes(ArcadeGame instance) { }

	// RVA: 0x1FF16C0 Offset: 0x1FEFCC0 VA: 0x181FF16C0
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

	// RVA: 0x2008970 Offset: 0x2006F70 VA: 0x182008970
	public static void ResetToPool(ArcadeGame.arcadeEnt instance) { }

	// RVA: 0x2008AE0 Offset: 0x20070E0 VA: 0x182008AE0
	public void ResetToPool() { }

	// RVA: 0x20088B0 Offset: 0x2006EB0 VA: 0x1820088B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20074E0 Offset: 0x2005AE0 VA: 0x1820074E0
	public void CopyTo(ArcadeGame.arcadeEnt instance) { }

	// RVA: 0x2007590 Offset: 0x2005B90 VA: 0x182007590
	public ArcadeGame.arcadeEnt Copy() { }

	// RVA: 0x20081C0 Offset: 0x20067C0 VA: 0x1820081C0
	public static ArcadeGame.arcadeEnt Deserialize(Stream stream) { }

	// RVA: 0x2007BB0 Offset: 0x20061B0 VA: 0x182007BB0
	public static ArcadeGame.arcadeEnt DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2008130 Offset: 0x2006730 VA: 0x182008130
	public static ArcadeGame.arcadeEnt DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2008240 Offset: 0x2006840 VA: 0x182008240
	public static ArcadeGame.arcadeEnt Deserialize(byte[] buffer) { }

	// RVA: 0x2008930 Offset: 0x2006F30 VA: 0x182008930
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2009D00 Offset: 0x2008300 VA: 0x182009D00 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2009D20 Offset: 0x2008320 VA: 0x182009D20 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ArcadeGame.arcadeEnt previous) { }

	// RVA: 0x2008950 Offset: 0x2006F50 VA: 0x182008950 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20087B0 Offset: 0x2006DB0 VA: 0x1820087B0
	public static ArcadeGame.arcadeEnt Deserialize(byte[] buffer, ArcadeGame.arcadeEnt instance, bool isDelta = False) { }

	// RVA: 0x2008360 Offset: 0x2006960 VA: 0x182008360
	public static ArcadeGame.arcadeEnt Deserialize(Stream stream, ArcadeGame.arcadeEnt instance, bool isDelta) { }

	// RVA: 0x2007690 Offset: 0x2005C90 VA: 0x182007690
	public static ArcadeGame.arcadeEnt DeserializeLengthDelimited(Stream stream, ArcadeGame.arcadeEnt instance, bool isDelta) { }

	// RVA: 0x2007C30 Offset: 0x2006230 VA: 0x182007C30
	public static ArcadeGame.arcadeEnt DeserializeLength(Stream stream, int length, ArcadeGame.arcadeEnt instance, bool isDelta) { }

	// RVA: 0x2008C50 Offset: 0x2007250 VA: 0x182008C50
	public static void SerializeDelta(Stream stream, ArcadeGame.arcadeEnt instance, ArcadeGame.arcadeEnt previous) { }

	// RVA: 0x2009760 Offset: 0x2007D60 VA: 0x182009760
	public static void Serialize(Stream stream, ArcadeGame.arcadeEnt instance) { }

	// RVA: 0x2009CF0 Offset: 0x20082F0 VA: 0x182009CF0
	public byte[] ToProtoBytes() { }

	// RVA: 0x2009D00 Offset: 0x2008300 VA: 0x182009D00
	public void ToProto(Stream stream) { }

	// RVA: 0x2009650 Offset: 0x2007C50 VA: 0x182009650
	public static byte[] SerializeToBytes(ArcadeGame.arcadeEnt instance) { }

	// RVA: 0x20095A0 Offset: 0x2007BA0 VA: 0x1820095A0
	public static void SerializeLengthDelimited(Stream stream, ArcadeGame.arcadeEnt instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

