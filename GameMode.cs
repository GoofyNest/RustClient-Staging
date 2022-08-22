public class GameMode : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6399
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<GameMode.TeamInfo> teams; // 0x18
	public List<GameMode.ScoreColumn> scoreColumns; // 0x20
	public List<GameMode.PlayerScore> playerScores; // 0x28

	// Methods

	// RVA: 0x1D5DC20 Offset: 0x1D5C220 VA: 0x181D5DC20
	public static void ResetToPool(GameMode instance) { }

	// RVA: 0x1D5D800 Offset: 0x1D5BE00 VA: 0x181D5D800
	public void ResetToPool() { }

	// RVA: 0x1D5D740 Offset: 0x1D5BD40 VA: 0x181D5D740 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D5C1B0 Offset: 0x1D5A7B0 VA: 0x181D5C1B0
	public void CopyTo(GameMode instance) { }

	// RVA: 0x1D5C6B0 Offset: 0x1D5ACB0 VA: 0x181D5C6B0
	public GameMode Copy() { }

	// RVA: 0x1D5D220 Offset: 0x1D5B820 VA: 0x181D5D220
	public static GameMode Deserialize(Stream stream) { }

	// RVA: 0x1D5CBA0 Offset: 0x1D5B1A0 VA: 0x181D5CBA0
	public static GameMode DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D5CC20 Offset: 0x1D5B220 VA: 0x181D5CC20
	public static GameMode DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D5D100 Offset: 0x1D5B700 VA: 0x181D5D100
	public static GameMode Deserialize(byte[] buffer) { }

	// RVA: 0x1D5D7C0 Offset: 0x1D5BDC0 VA: 0x181D5D7C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D5EBD0 Offset: 0x1D5D1D0 VA: 0x181D5EBD0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D5EBF0 Offset: 0x1D5D1F0 VA: 0x181D5EBF0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, GameMode previous) { }

	// RVA: 0x1D5D7E0 Offset: 0x1D5BDE0 VA: 0x181D5D7E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D5D2A0 Offset: 0x1D5B8A0 VA: 0x181D5D2A0
	public static GameMode Deserialize(byte[] buffer, GameMode instance, bool isDelta = False) { }

	// RVA: 0x1D5D3A0 Offset: 0x1D5B9A0 VA: 0x181D5D3A0
	public static GameMode Deserialize(Stream stream, GameMode instance, bool isDelta) { }

	// RVA: 0x1D5C730 Offset: 0x1D5AD30 VA: 0x181D5C730
	public static GameMode DeserializeLengthDelimited(Stream stream, GameMode instance, bool isDelta) { }

	// RVA: 0x1D5CCB0 Offset: 0x1D5B2B0 VA: 0x181D5CCB0
	public static GameMode DeserializeLength(Stream stream, int length, GameMode instance, bool isDelta) { }

	// RVA: 0x1D5E040 Offset: 0x1D5C640 VA: 0x181D5E040
	public static void SerializeDelta(Stream stream, GameMode instance, GameMode previous) { }

	// RVA: 0x1D5E6C0 Offset: 0x1D5CCC0 VA: 0x181D5E6C0
	public static void Serialize(Stream stream, GameMode instance) { }

	// RVA: 0x1D5EBC0 Offset: 0x1D5D1C0 VA: 0x181D5EBC0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D5EBD0 Offset: 0x1D5D1D0 VA: 0x181D5EBD0
	public void ToProto(Stream stream) { }

	// RVA: 0x1D5E5B0 Offset: 0x1D5CBB0 VA: 0x181D5E5B0
	public static byte[] SerializeToBytes(GameMode instance) { }

	// RVA: 0x1D5E500 Offset: 0x1D5CB00 VA: 0x181D5E500
	public static void SerializeLengthDelimited(Stream stream, GameMode instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class GameMode.TeamInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6400
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int score; // 0x14

	// Methods

	// RVA: 0x1D6B910 Offset: 0x1D69F10 VA: 0x181D6B910
	public static void ResetToPool(GameMode.TeamInfo instance) { }

	// RVA: 0x1D6B890 Offset: 0x1D69E90 VA: 0x181D6B890
	public void ResetToPool() { }

	// RVA: 0x1D6B7D0 Offset: 0x1D69DD0 VA: 0x181D6B7D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFEF80 Offset: 0x1BFD580 VA: 0x181BFEF80
	public void CopyTo(GameMode.TeamInfo instance) { }

	// RVA: 0x1D6AE50 Offset: 0x1D69450 VA: 0x181D6AE50
	public GameMode.TeamInfo Copy() { }

	// RVA: 0x1D6B630 Offset: 0x1D69C30 VA: 0x181D6B630
	public static GameMode.TeamInfo Deserialize(Stream stream) { }

	// RVA: 0x1D6AEC0 Offset: 0x1D694C0 VA: 0x181D6AEC0
	public static GameMode.TeamInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D6B360 Offset: 0x1D69960 VA: 0x181D6B360
	public static GameMode.TeamInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D6B6B0 Offset: 0x1D69CB0 VA: 0x181D6B6B0
	public static GameMode.TeamInfo Deserialize(byte[] buffer) { }

	// RVA: 0x1D6B850 Offset: 0x1D69E50 VA: 0x181D6B850
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D6BDE0 Offset: 0x1D6A3E0 VA: 0x181D6BDE0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D6BEB0 Offset: 0x1D6A4B0 VA: 0x181D6BEB0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, GameMode.TeamInfo previous) { }

	// RVA: 0x1D6B870 Offset: 0x1D69E70 VA: 0x181D6B870 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D6B530 Offset: 0x1D69B30 VA: 0x181D6B530
	public static GameMode.TeamInfo Deserialize(byte[] buffer, GameMode.TeamInfo instance, bool isDelta = False) { }

	// RVA: 0x1D6B3F0 Offset: 0x1D699F0 VA: 0x181D6B3F0
	public static GameMode.TeamInfo Deserialize(Stream stream, GameMode.TeamInfo instance, bool isDelta) { }

	// RVA: 0x1D6AF40 Offset: 0x1D69540 VA: 0x181D6AF40
	public static GameMode.TeamInfo DeserializeLengthDelimited(Stream stream, GameMode.TeamInfo instance, bool isDelta) { }

	// RVA: 0x1D6B160 Offset: 0x1D69760 VA: 0x181D6B160
	public static GameMode.TeamInfo DeserializeLength(Stream stream, int length, GameMode.TeamInfo instance, bool isDelta) { }

	// RVA: 0x1D6B990 Offset: 0x1D69F90 VA: 0x181D6B990
	public static void SerializeDelta(Stream stream, GameMode.TeamInfo instance, GameMode.TeamInfo previous) { }

	// RVA: 0x1D6BD00 Offset: 0x1D6A300 VA: 0x181D6BD00
	public static void Serialize(Stream stream, GameMode.TeamInfo instance) { }

	// RVA: 0x1D6BDD0 Offset: 0x1D6A3D0 VA: 0x181D6BDD0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D6BDE0 Offset: 0x1D6A3E0 VA: 0x181D6BDE0
	public void ToProto(Stream stream) { }

	// RVA: 0x1D6BB50 Offset: 0x1D6A150 VA: 0x181D6BB50
	public static byte[] SerializeToBytes(GameMode.TeamInfo instance) { }

	// RVA: 0x1D6BAA0 Offset: 0x1D6A0A0 VA: 0x181D6BAA0
	public static void SerializeLengthDelimited(Stream stream, GameMode.TeamInfo instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class GameMode.ScoreColumn : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6401
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string name; // 0x18

	// Methods

	// RVA: 0x1D69160 Offset: 0x1D67760 VA: 0x181D69160
	public static void ResetToPool(GameMode.ScoreColumn instance) { }

	// RVA: 0x1D690D0 Offset: 0x1D676D0 VA: 0x181D690D0
	public void ResetToPool() { }

	// RVA: 0x1D69010 Offset: 0x1D67610 VA: 0x181D69010 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D68640 Offset: 0x1D66C40 VA: 0x181D68640
	public void CopyTo(GameMode.ScoreColumn instance) { }

	// RVA: 0x1D68670 Offset: 0x1D66C70 VA: 0x181D68670
	public GameMode.ScoreColumn Copy() { }

	// RVA: 0x1D68D20 Offset: 0x1D67320 VA: 0x181D68D20
	public static GameMode.ScoreColumn Deserialize(Stream stream) { }

	// RVA: 0x1D686F0 Offset: 0x1D66CF0 VA: 0x181D686F0
	public static GameMode.ScoreColumn DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D68B90 Offset: 0x1D67190 VA: 0x181D68B90
	public static GameMode.ScoreColumn DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D68EF0 Offset: 0x1D674F0 VA: 0x181D68EF0
	public static GameMode.ScoreColumn Deserialize(byte[] buffer) { }

	// RVA: 0x1D69090 Offset: 0x1D67690 VA: 0x181D69090
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D69650 Offset: 0x1D67C50 VA: 0x181D69650 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D69670 Offset: 0x1D67C70 VA: 0x181D69670 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, GameMode.ScoreColumn previous) { }

	// RVA: 0x1D690B0 Offset: 0x1D676B0 VA: 0x181D690B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D68C20 Offset: 0x1D67220 VA: 0x181D68C20
	public static GameMode.ScoreColumn Deserialize(byte[] buffer, GameMode.ScoreColumn instance, bool isDelta = False) { }

	// RVA: 0x1D68DA0 Offset: 0x1D673A0 VA: 0x181D68DA0
	public static GameMode.ScoreColumn Deserialize(Stream stream, GameMode.ScoreColumn instance, bool isDelta) { }

	// RVA: 0x1D68770 Offset: 0x1D66D70 VA: 0x181D68770
	public static GameMode.ScoreColumn DeserializeLengthDelimited(Stream stream, GameMode.ScoreColumn instance, bool isDelta) { }

	// RVA: 0x1D68990 Offset: 0x1D66F90 VA: 0x181D68990
	public static GameMode.ScoreColumn DeserializeLength(Stream stream, int length, GameMode.ScoreColumn instance, bool isDelta) { }

	// RVA: 0x1D691F0 Offset: 0x1D677F0 VA: 0x181D691F0
	public static void SerializeDelta(Stream stream, GameMode.ScoreColumn instance, GameMode.ScoreColumn previous) { }

	// RVA: 0x1D69510 Offset: 0x1D67B10 VA: 0x181D69510
	public static void Serialize(Stream stream, GameMode.ScoreColumn instance) { }

	// RVA: 0x1D69640 Offset: 0x1D67C40 VA: 0x181D69640
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D69650 Offset: 0x1D67C50 VA: 0x181D69650
	public void ToProto(Stream stream) { }

	// RVA: 0x1D69400 Offset: 0x1D67A00 VA: 0x181D69400
	public static byte[] SerializeToBytes(GameMode.ScoreColumn instance) { }

	// RVA: 0x1D69350 Offset: 0x1D67950 VA: 0x181D69350
	public static void SerializeLengthDelimited(Stream stream, GameMode.ScoreColumn instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class GameMode.PlayerScore : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6402
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string playerName; // 0x18
	public ulong userid; // 0x20
	public List<int> scores; // 0x28
	public int team; // 0x30

	// Methods

	// RVA: 0x1D67E00 Offset: 0x1D66400 VA: 0x181D67E00
	public static void ResetToPool(GameMode.PlayerScore instance) { }

	// RVA: 0x1D67CD0 Offset: 0x1D662D0 VA: 0x181D67CD0
	public void ResetToPool() { }

	// RVA: 0x1D679A0 Offset: 0x1D65FA0 VA: 0x181D679A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D66340 Offset: 0x1D64940 VA: 0x181D66340
	public void CopyTo(GameMode.PlayerScore instance) { }

	// RVA: 0x1D66470 Offset: 0x1D64A70 VA: 0x181D66470
	public GameMode.PlayerScore Copy() { }

	// RVA: 0x1D66DA0 Offset: 0x1D653A0 VA: 0x181D66DA0
	public static GameMode.PlayerScore Deserialize(Stream stream) { }

	// RVA: 0x1D66950 Offset: 0x1D64F50 VA: 0x181D66950
	public static GameMode.PlayerScore DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D669D0 Offset: 0x1D64FD0 VA: 0x181D669D0
	public static GameMode.PlayerScore DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D67050 Offset: 0x1D65650 VA: 0x181D67050
	public static GameMode.PlayerScore Deserialize(byte[] buffer) { }

	// RVA: 0x1D67A20 Offset: 0x1D66020 VA: 0x181D67A20
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D68600 Offset: 0x1D66C00 VA: 0x181D68600 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D68620 Offset: 0x1D66C20 VA: 0x181D68620 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, GameMode.PlayerScore previous) { }

	// RVA: 0x1D67CB0 Offset: 0x1D662B0 VA: 0x181D67CB0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D67630 Offset: 0x1D65C30 VA: 0x181D67630
	public static GameMode.PlayerScore Deserialize(byte[] buffer, GameMode.PlayerScore instance, bool isDelta = False) { }

	// RVA: 0x1D673A0 Offset: 0x1D659A0 VA: 0x181D673A0
	public static GameMode.PlayerScore Deserialize(Stream stream, GameMode.PlayerScore instance, bool isDelta) { }

	// RVA: 0x1D665F0 Offset: 0x1D64BF0 VA: 0x181D665F0
	public static GameMode.PlayerScore DeserializeLengthDelimited(Stream stream, GameMode.PlayerScore instance, bool isDelta) { }

	// RVA: 0x1D66A60 Offset: 0x1D65060 VA: 0x181D66A60
	public static GameMode.PlayerScore DeserializeLength(Stream stream, int length, GameMode.PlayerScore instance, bool isDelta) { }

	// RVA: 0x1D67F30 Offset: 0x1D66530 VA: 0x181D67F30
	public static void SerializeDelta(Stream stream, GameMode.PlayerScore instance, GameMode.PlayerScore previous) { }

	// RVA: 0x1D683B0 Offset: 0x1D669B0 VA: 0x181D683B0
	public static void Serialize(Stream stream, GameMode.PlayerScore instance) { }

	// RVA: 0x1D685F0 Offset: 0x1D66BF0 VA: 0x181D685F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D68600 Offset: 0x1D66C00 VA: 0x181D68600
	public void ToProto(Stream stream) { }

	// RVA: 0x1D682A0 Offset: 0x1D668A0 VA: 0x181D682A0
	public static byte[] SerializeToBytes(GameMode.PlayerScore instance) { }

	// RVA: 0x1D681F0 Offset: 0x1D667F0 VA: 0x181D681F0
	public static void SerializeLengthDelimited(Stream stream, GameMode.PlayerScore instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class gamemode : ConsoleSystem // TypeDefIndex: 11924
{	// Methods

	// RVA: 0x372500 Offset: 0x370B00 VA: 0x180372500
	public void .ctor() { }

}

