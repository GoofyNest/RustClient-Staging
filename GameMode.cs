public class GameMode : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6399
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<GameMode.TeamInfo> teams; // 0x18
	public List<GameMode.ScoreColumn> scoreColumns; // 0x20
	public List<GameMode.PlayerScore> playerScores; // 0x28

	// Methods

	// RVA: 0x1D5D170 Offset: 0x1D5B770 VA: 0x181D5D170
	public static void ResetToPool(GameMode instance) { }

	// RVA: 0x1D5CD50 Offset: 0x1D5B350 VA: 0x181D5CD50
	public void ResetToPool() { }

	// RVA: 0x1D5CC90 Offset: 0x1D5B290 VA: 0x181D5CC90 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D5B700 Offset: 0x1D59D00 VA: 0x181D5B700
	public void CopyTo(GameMode instance) { }

	// RVA: 0x1D5BC00 Offset: 0x1D5A200 VA: 0x181D5BC00
	public GameMode Copy() { }

	// RVA: 0x1D5C770 Offset: 0x1D5AD70 VA: 0x181D5C770
	public static GameMode Deserialize(Stream stream) { }

	// RVA: 0x1D5C0F0 Offset: 0x1D5A6F0 VA: 0x181D5C0F0
	public static GameMode DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D5C170 Offset: 0x1D5A770 VA: 0x181D5C170
	public static GameMode DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D5C650 Offset: 0x1D5AC50 VA: 0x181D5C650
	public static GameMode Deserialize(byte[] buffer) { }

	// RVA: 0x1D5CD10 Offset: 0x1D5B310 VA: 0x181D5CD10
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D5E120 Offset: 0x1D5C720 VA: 0x181D5E120 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D5E140 Offset: 0x1D5C740 VA: 0x181D5E140 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, GameMode previous) { }

	// RVA: 0x1D5CD30 Offset: 0x1D5B330 VA: 0x181D5CD30 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D5C7F0 Offset: 0x1D5ADF0 VA: 0x181D5C7F0
	public static GameMode Deserialize(byte[] buffer, GameMode instance, bool isDelta = False) { }

	// RVA: 0x1D5C8F0 Offset: 0x1D5AEF0 VA: 0x181D5C8F0
	public static GameMode Deserialize(Stream stream, GameMode instance, bool isDelta) { }

	// RVA: 0x1D5BC80 Offset: 0x1D5A280 VA: 0x181D5BC80
	public static GameMode DeserializeLengthDelimited(Stream stream, GameMode instance, bool isDelta) { }

	// RVA: 0x1D5C200 Offset: 0x1D5A800 VA: 0x181D5C200
	public static GameMode DeserializeLength(Stream stream, int length, GameMode instance, bool isDelta) { }

	// RVA: 0x1D5D590 Offset: 0x1D5BB90 VA: 0x181D5D590
	public static void SerializeDelta(Stream stream, GameMode instance, GameMode previous) { }

	// RVA: 0x1D5DC10 Offset: 0x1D5C210 VA: 0x181D5DC10
	public static void Serialize(Stream stream, GameMode instance) { }

	// RVA: 0x1D5E110 Offset: 0x1D5C710 VA: 0x181D5E110
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D5E120 Offset: 0x1D5C720 VA: 0x181D5E120
	public void ToProto(Stream stream) { }

	// RVA: 0x1D5DB00 Offset: 0x1D5C100 VA: 0x181D5DB00
	public static byte[] SerializeToBytes(GameMode instance) { }

	// RVA: 0x1D5DA50 Offset: 0x1D5C050 VA: 0x181D5DA50
	public static void SerializeLengthDelimited(Stream stream, GameMode instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class GameMode.TeamInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6400
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int score; // 0x14

	// Methods

	// RVA: 0x1D6AE60 Offset: 0x1D69460 VA: 0x181D6AE60
	public static void ResetToPool(GameMode.TeamInfo instance) { }

	// RVA: 0x1D6ADE0 Offset: 0x1D693E0 VA: 0x181D6ADE0
	public void ResetToPool() { }

	// RVA: 0x1D6AD20 Offset: 0x1D69320 VA: 0x181D6AD20 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE4D0 Offset: 0x1BFCAD0 VA: 0x181BFE4D0
	public void CopyTo(GameMode.TeamInfo instance) { }

	// RVA: 0x1D6A3A0 Offset: 0x1D689A0 VA: 0x181D6A3A0
	public GameMode.TeamInfo Copy() { }

	// RVA: 0x1D6AB80 Offset: 0x1D69180 VA: 0x181D6AB80
	public static GameMode.TeamInfo Deserialize(Stream stream) { }

	// RVA: 0x1D6A410 Offset: 0x1D68A10 VA: 0x181D6A410
	public static GameMode.TeamInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D6A8B0 Offset: 0x1D68EB0 VA: 0x181D6A8B0
	public static GameMode.TeamInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D6AC00 Offset: 0x1D69200 VA: 0x181D6AC00
	public static GameMode.TeamInfo Deserialize(byte[] buffer) { }

	// RVA: 0x1D6ADA0 Offset: 0x1D693A0 VA: 0x181D6ADA0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D6B330 Offset: 0x1D69930 VA: 0x181D6B330 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D6B400 Offset: 0x1D69A00 VA: 0x181D6B400 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, GameMode.TeamInfo previous) { }

	// RVA: 0x1D6ADC0 Offset: 0x1D693C0 VA: 0x181D6ADC0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D6AA80 Offset: 0x1D69080 VA: 0x181D6AA80
	public static GameMode.TeamInfo Deserialize(byte[] buffer, GameMode.TeamInfo instance, bool isDelta = False) { }

	// RVA: 0x1D6A940 Offset: 0x1D68F40 VA: 0x181D6A940
	public static GameMode.TeamInfo Deserialize(Stream stream, GameMode.TeamInfo instance, bool isDelta) { }

	// RVA: 0x1D6A490 Offset: 0x1D68A90 VA: 0x181D6A490
	public static GameMode.TeamInfo DeserializeLengthDelimited(Stream stream, GameMode.TeamInfo instance, bool isDelta) { }

	// RVA: 0x1D6A6B0 Offset: 0x1D68CB0 VA: 0x181D6A6B0
	public static GameMode.TeamInfo DeserializeLength(Stream stream, int length, GameMode.TeamInfo instance, bool isDelta) { }

	// RVA: 0x1D6AEE0 Offset: 0x1D694E0 VA: 0x181D6AEE0
	public static void SerializeDelta(Stream stream, GameMode.TeamInfo instance, GameMode.TeamInfo previous) { }

	// RVA: 0x1D6B250 Offset: 0x1D69850 VA: 0x181D6B250
	public static void Serialize(Stream stream, GameMode.TeamInfo instance) { }

	// RVA: 0x1D6B320 Offset: 0x1D69920 VA: 0x181D6B320
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D6B330 Offset: 0x1D69930 VA: 0x181D6B330
	public void ToProto(Stream stream) { }

	// RVA: 0x1D6B0A0 Offset: 0x1D696A0 VA: 0x181D6B0A0
	public static byte[] SerializeToBytes(GameMode.TeamInfo instance) { }

	// RVA: 0x1D6AFF0 Offset: 0x1D695F0 VA: 0x181D6AFF0
	public static void SerializeLengthDelimited(Stream stream, GameMode.TeamInfo instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class GameMode.ScoreColumn : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6401
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string name; // 0x18

	// Methods

	// RVA: 0x1D686B0 Offset: 0x1D66CB0 VA: 0x181D686B0
	public static void ResetToPool(GameMode.ScoreColumn instance) { }

	// RVA: 0x1D68620 Offset: 0x1D66C20 VA: 0x181D68620
	public void ResetToPool() { }

	// RVA: 0x1D68560 Offset: 0x1D66B60 VA: 0x181D68560 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D67B90 Offset: 0x1D66190 VA: 0x181D67B90
	public void CopyTo(GameMode.ScoreColumn instance) { }

	// RVA: 0x1D67BC0 Offset: 0x1D661C0 VA: 0x181D67BC0
	public GameMode.ScoreColumn Copy() { }

	// RVA: 0x1D68270 Offset: 0x1D66870 VA: 0x181D68270
	public static GameMode.ScoreColumn Deserialize(Stream stream) { }

	// RVA: 0x1D67C40 Offset: 0x1D66240 VA: 0x181D67C40
	public static GameMode.ScoreColumn DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D680E0 Offset: 0x1D666E0 VA: 0x181D680E0
	public static GameMode.ScoreColumn DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D68440 Offset: 0x1D66A40 VA: 0x181D68440
	public static GameMode.ScoreColumn Deserialize(byte[] buffer) { }

	// RVA: 0x1D685E0 Offset: 0x1D66BE0 VA: 0x181D685E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D68BA0 Offset: 0x1D671A0 VA: 0x181D68BA0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D68BC0 Offset: 0x1D671C0 VA: 0x181D68BC0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, GameMode.ScoreColumn previous) { }

	// RVA: 0x1D68600 Offset: 0x1D66C00 VA: 0x181D68600 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D68170 Offset: 0x1D66770 VA: 0x181D68170
	public static GameMode.ScoreColumn Deserialize(byte[] buffer, GameMode.ScoreColumn instance, bool isDelta = False) { }

	// RVA: 0x1D682F0 Offset: 0x1D668F0 VA: 0x181D682F0
	public static GameMode.ScoreColumn Deserialize(Stream stream, GameMode.ScoreColumn instance, bool isDelta) { }

	// RVA: 0x1D67CC0 Offset: 0x1D662C0 VA: 0x181D67CC0
	public static GameMode.ScoreColumn DeserializeLengthDelimited(Stream stream, GameMode.ScoreColumn instance, bool isDelta) { }

	// RVA: 0x1D67EE0 Offset: 0x1D664E0 VA: 0x181D67EE0
	public static GameMode.ScoreColumn DeserializeLength(Stream stream, int length, GameMode.ScoreColumn instance, bool isDelta) { }

	// RVA: 0x1D68740 Offset: 0x1D66D40 VA: 0x181D68740
	public static void SerializeDelta(Stream stream, GameMode.ScoreColumn instance, GameMode.ScoreColumn previous) { }

	// RVA: 0x1D68A60 Offset: 0x1D67060 VA: 0x181D68A60
	public static void Serialize(Stream stream, GameMode.ScoreColumn instance) { }

	// RVA: 0x1D68B90 Offset: 0x1D67190 VA: 0x181D68B90
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D68BA0 Offset: 0x1D671A0 VA: 0x181D68BA0
	public void ToProto(Stream stream) { }

	// RVA: 0x1D68950 Offset: 0x1D66F50 VA: 0x181D68950
	public static byte[] SerializeToBytes(GameMode.ScoreColumn instance) { }

	// RVA: 0x1D688A0 Offset: 0x1D66EA0 VA: 0x181D688A0
	public static void SerializeLengthDelimited(Stream stream, GameMode.ScoreColumn instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x1D67350 Offset: 0x1D65950 VA: 0x181D67350
	public static void ResetToPool(GameMode.PlayerScore instance) { }

	// RVA: 0x1D67220 Offset: 0x1D65820 VA: 0x181D67220
	public void ResetToPool() { }

	// RVA: 0x1D66EF0 Offset: 0x1D654F0 VA: 0x181D66EF0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D65890 Offset: 0x1D63E90 VA: 0x181D65890
	public void CopyTo(GameMode.PlayerScore instance) { }

	// RVA: 0x1D659C0 Offset: 0x1D63FC0 VA: 0x181D659C0
	public GameMode.PlayerScore Copy() { }

	// RVA: 0x1D662F0 Offset: 0x1D648F0 VA: 0x181D662F0
	public static GameMode.PlayerScore Deserialize(Stream stream) { }

	// RVA: 0x1D65EA0 Offset: 0x1D644A0 VA: 0x181D65EA0
	public static GameMode.PlayerScore DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D65F20 Offset: 0x1D64520 VA: 0x181D65F20
	public static GameMode.PlayerScore DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D665A0 Offset: 0x1D64BA0 VA: 0x181D665A0
	public static GameMode.PlayerScore Deserialize(byte[] buffer) { }

	// RVA: 0x1D66F70 Offset: 0x1D65570 VA: 0x181D66F70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D67B50 Offset: 0x1D66150 VA: 0x181D67B50 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D67B70 Offset: 0x1D66170 VA: 0x181D67B70 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, GameMode.PlayerScore previous) { }

	// RVA: 0x1D67200 Offset: 0x1D65800 VA: 0x181D67200 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D66B80 Offset: 0x1D65180 VA: 0x181D66B80
	public static GameMode.PlayerScore Deserialize(byte[] buffer, GameMode.PlayerScore instance, bool isDelta = False) { }

	// RVA: 0x1D668F0 Offset: 0x1D64EF0 VA: 0x181D668F0
	public static GameMode.PlayerScore Deserialize(Stream stream, GameMode.PlayerScore instance, bool isDelta) { }

	// RVA: 0x1D65B40 Offset: 0x1D64140 VA: 0x181D65B40
	public static GameMode.PlayerScore DeserializeLengthDelimited(Stream stream, GameMode.PlayerScore instance, bool isDelta) { }

	// RVA: 0x1D65FB0 Offset: 0x1D645B0 VA: 0x181D65FB0
	public static GameMode.PlayerScore DeserializeLength(Stream stream, int length, GameMode.PlayerScore instance, bool isDelta) { }

	// RVA: 0x1D67480 Offset: 0x1D65A80 VA: 0x181D67480
	public static void SerializeDelta(Stream stream, GameMode.PlayerScore instance, GameMode.PlayerScore previous) { }

	// RVA: 0x1D67900 Offset: 0x1D65F00 VA: 0x181D67900
	public static void Serialize(Stream stream, GameMode.PlayerScore instance) { }

	// RVA: 0x1D67B40 Offset: 0x1D66140 VA: 0x181D67B40
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D67B50 Offset: 0x1D66150 VA: 0x181D67B50
	public void ToProto(Stream stream) { }

	// RVA: 0x1D677F0 Offset: 0x1D65DF0 VA: 0x181D677F0
	public static byte[] SerializeToBytes(GameMode.PlayerScore instance) { }

	// RVA: 0x1D67740 Offset: 0x1D65D40 VA: 0x181D67740
	public static void SerializeLengthDelimited(Stream stream, GameMode.PlayerScore instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class gamemode : ConsoleSystem // TypeDefIndex: 11924
{	// Methods

	// RVA: 0x372500 Offset: 0x370B00 VA: 0x180372500
	public void .ctor() { }

}

