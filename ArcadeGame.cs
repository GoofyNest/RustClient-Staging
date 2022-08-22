public class ArcadeGame : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6500
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<ArcadeGame.arcadeEnt> arcadeEnts; // 0x18

	// Methods

	// RVA: 0x1FF1430 Offset: 0x1FEFA30 VA: 0x181FF1430
	public static void ResetToPool(ArcadeGame instance) { }

	// RVA: 0x1FF1280 Offset: 0x1FEF880 VA: 0x181FF1280
	public void ResetToPool() { }

	// RVA: 0x1FF1000 Offset: 0x1FEF600 VA: 0x181FF1000 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1FF0260 Offset: 0x1FEE860 VA: 0x181FF0260
	public void CopyTo(ArcadeGame instance) { }

	// RVA: 0x1FF0470 Offset: 0x1FEEA70 VA: 0x181FF0470
	public ArcadeGame Copy() { }

	// RVA: 0x1FF0B70 Offset: 0x1FEF170 VA: 0x181FF0B70
	public static ArcadeGame Deserialize(Stream stream) { }

	// RVA: 0x1FF07C0 Offset: 0x1FEEDC0 VA: 0x181FF07C0
	public static ArcadeGame DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1FF0AE0 Offset: 0x1FEF0E0 VA: 0x181FF0AE0
	public static ArcadeGame DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1FF0DE0 Offset: 0x1FEF3E0 VA: 0x181FF0DE0
	public static ArcadeGame Deserialize(byte[] buffer) { }

	// RVA: 0x1FF1240 Offset: 0x1FEF840 VA: 0x181FF1240
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1FF1B70 Offset: 0x1FF0170 VA: 0x181FF1B70 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1FF1B90 Offset: 0x1FF0190 VA: 0x181FF1B90 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ArcadeGame previous) { }

	// RVA: 0x1FF1260 Offset: 0x1FEF860 VA: 0x181FF1260 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1FF0F00 Offset: 0x1FEF500 VA: 0x181FF0F00
	public static ArcadeGame Deserialize(byte[] buffer, ArcadeGame instance, bool isDelta = False) { }

	// RVA: 0x1FF0BF0 Offset: 0x1FEF1F0 VA: 0x181FF0BF0
	public static ArcadeGame Deserialize(Stream stream, ArcadeGame instance, bool isDelta) { }

	// RVA: 0x1FF04F0 Offset: 0x1FEEAF0 VA: 0x181FF04F0
	public static ArcadeGame DeserializeLengthDelimited(Stream stream, ArcadeGame instance, bool isDelta) { }

	// RVA: 0x1FF0840 Offset: 0x1FEEE40 VA: 0x181FF0840
	public static ArcadeGame DeserializeLength(Stream stream, int length, ArcadeGame instance, bool isDelta) { }

	// RVA: 0x1FF15E0 Offset: 0x1FEFBE0 VA: 0x181FF15E0
	public static void SerializeDelta(Stream stream, ArcadeGame instance, ArcadeGame previous) { }

	// RVA: 0x1FF1980 Offset: 0x1FEFF80 VA: 0x181FF1980
	public static void Serialize(Stream stream, ArcadeGame instance) { }

	// RVA: 0x1FF1B60 Offset: 0x1FF0160 VA: 0x181FF1B60
	public byte[] ToProtoBytes() { }

	// RVA: 0x1FF1B70 Offset: 0x1FF0170 VA: 0x181FF1B70
	public void ToProto(Stream stream) { }

	// RVA: 0x1FF1870 Offset: 0x1FEFE70 VA: 0x181FF1870
	public static byte[] SerializeToBytes(ArcadeGame instance) { }

	// RVA: 0x1FF17C0 Offset: 0x1FEFDC0 VA: 0x181FF17C0
	public static void SerializeLengthDelimited(Stream stream, ArcadeGame instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x2008A70 Offset: 0x2007070 VA: 0x182008A70
	public static void ResetToPool(ArcadeGame.arcadeEnt instance) { }

	// RVA: 0x2008BE0 Offset: 0x20071E0 VA: 0x182008BE0
	public void ResetToPool() { }

	// RVA: 0x20089B0 Offset: 0x2006FB0 VA: 0x1820089B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20075E0 Offset: 0x2005BE0 VA: 0x1820075E0
	public void CopyTo(ArcadeGame.arcadeEnt instance) { }

	// RVA: 0x2007690 Offset: 0x2005C90 VA: 0x182007690
	public ArcadeGame.arcadeEnt Copy() { }

	// RVA: 0x20082C0 Offset: 0x20068C0 VA: 0x1820082C0
	public static ArcadeGame.arcadeEnt Deserialize(Stream stream) { }

	// RVA: 0x2007CB0 Offset: 0x20062B0 VA: 0x182007CB0
	public static ArcadeGame.arcadeEnt DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2008230 Offset: 0x2006830 VA: 0x182008230
	public static ArcadeGame.arcadeEnt DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2008340 Offset: 0x2006940 VA: 0x182008340
	public static ArcadeGame.arcadeEnt Deserialize(byte[] buffer) { }

	// RVA: 0x2008A30 Offset: 0x2007030 VA: 0x182008A30
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2009E00 Offset: 0x2008400 VA: 0x182009E00 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2009E20 Offset: 0x2008420 VA: 0x182009E20 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ArcadeGame.arcadeEnt previous) { }

	// RVA: 0x2008A50 Offset: 0x2007050 VA: 0x182008A50 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20088B0 Offset: 0x2006EB0 VA: 0x1820088B0
	public static ArcadeGame.arcadeEnt Deserialize(byte[] buffer, ArcadeGame.arcadeEnt instance, bool isDelta = False) { }

	// RVA: 0x2008460 Offset: 0x2006A60 VA: 0x182008460
	public static ArcadeGame.arcadeEnt Deserialize(Stream stream, ArcadeGame.arcadeEnt instance, bool isDelta) { }

	// RVA: 0x2007790 Offset: 0x2005D90 VA: 0x182007790
	public static ArcadeGame.arcadeEnt DeserializeLengthDelimited(Stream stream, ArcadeGame.arcadeEnt instance, bool isDelta) { }

	// RVA: 0x2007D30 Offset: 0x2006330 VA: 0x182007D30
	public static ArcadeGame.arcadeEnt DeserializeLength(Stream stream, int length, ArcadeGame.arcadeEnt instance, bool isDelta) { }

	// RVA: 0x2008D50 Offset: 0x2007350 VA: 0x182008D50
	public static void SerializeDelta(Stream stream, ArcadeGame.arcadeEnt instance, ArcadeGame.arcadeEnt previous) { }

	// RVA: 0x2009860 Offset: 0x2007E60 VA: 0x182009860
	public static void Serialize(Stream stream, ArcadeGame.arcadeEnt instance) { }

	// RVA: 0x2009DF0 Offset: 0x20083F0 VA: 0x182009DF0
	public byte[] ToProtoBytes() { }

	// RVA: 0x2009E00 Offset: 0x2008400 VA: 0x182009E00
	public void ToProto(Stream stream) { }

	// RVA: 0x2009750 Offset: 0x2007D50 VA: 0x182009750
	public static byte[] SerializeToBytes(ArcadeGame.arcadeEnt instance) { }

	// RVA: 0x20096A0 Offset: 0x2007CA0 VA: 0x1820096A0
	public static void SerializeLengthDelimited(Stream stream, ArcadeGame.arcadeEnt instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

