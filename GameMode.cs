public class GameMode : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6399
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<GameMode.TeamInfo> teams; // 0x18
	public List<GameMode.ScoreColumn> scoreColumns; // 0x20
	public List<GameMode.PlayerScore> playerScores; // 0x28


	public static void ResetToPool(GameMode instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(GameMode instance) { }

	public GameMode Copy() { }

	public static GameMode Deserialize(Stream stream) { }

	public static GameMode DeserializeLengthDelimited(Stream stream) { }

	public static GameMode DeserializeLength(Stream stream, int length) { }

	public static GameMode Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, GameMode previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static GameMode Deserialize(byte[] buffer, GameMode instance, bool isDelta = False) { }

	public static GameMode Deserialize(Stream stream, GameMode instance, bool isDelta) { }

	public static GameMode DeserializeLengthDelimited(Stream stream, GameMode instance, bool isDelta) { }

	public static GameMode DeserializeLength(Stream stream, int length, GameMode instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, GameMode instance, GameMode previous) { }

	public static void Serialize(Stream stream, GameMode instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(GameMode instance) { }

	public static void SerializeLengthDelimited(Stream stream, GameMode instance) { }

	public void .ctor() { }

}

public class GameMode.TeamInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6400
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int score; // 0x14


	public static void ResetToPool(GameMode.TeamInfo instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(GameMode.TeamInfo instance) { }

	public GameMode.TeamInfo Copy() { }

	public static GameMode.TeamInfo Deserialize(Stream stream) { }

	public static GameMode.TeamInfo DeserializeLengthDelimited(Stream stream) { }

	public static GameMode.TeamInfo DeserializeLength(Stream stream, int length) { }

	public static GameMode.TeamInfo Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, GameMode.TeamInfo previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static GameMode.TeamInfo Deserialize(byte[] buffer, GameMode.TeamInfo instance, bool isDelta = False) { }

	public static GameMode.TeamInfo Deserialize(Stream stream, GameMode.TeamInfo instance, bool isDelta) { }

	public static GameMode.TeamInfo DeserializeLengthDelimited(Stream stream, GameMode.TeamInfo instance, bool isDelta) { }

	public static GameMode.TeamInfo DeserializeLength(Stream stream, int length, GameMode.TeamInfo instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, GameMode.TeamInfo instance, GameMode.TeamInfo previous) { }

	public static void Serialize(Stream stream, GameMode.TeamInfo instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(GameMode.TeamInfo instance) { }

	public static void SerializeLengthDelimited(Stream stream, GameMode.TeamInfo instance) { }

	public void .ctor() { }

}

public class GameMode.ScoreColumn : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6401
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string name; // 0x18


	public static void ResetToPool(GameMode.ScoreColumn instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(GameMode.ScoreColumn instance) { }

	public GameMode.ScoreColumn Copy() { }

	public static GameMode.ScoreColumn Deserialize(Stream stream) { }

	public static GameMode.ScoreColumn DeserializeLengthDelimited(Stream stream) { }

	public static GameMode.ScoreColumn DeserializeLength(Stream stream, int length) { }

	public static GameMode.ScoreColumn Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, GameMode.ScoreColumn previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static GameMode.ScoreColumn Deserialize(byte[] buffer, GameMode.ScoreColumn instance, bool isDelta = False) { }

	public static GameMode.ScoreColumn Deserialize(Stream stream, GameMode.ScoreColumn instance, bool isDelta) { }

	public static GameMode.ScoreColumn DeserializeLengthDelimited(Stream stream, GameMode.ScoreColumn instance, bool isDelta) { }

	public static GameMode.ScoreColumn DeserializeLength(Stream stream, int length, GameMode.ScoreColumn instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, GameMode.ScoreColumn instance, GameMode.ScoreColumn previous) { }

	public static void Serialize(Stream stream, GameMode.ScoreColumn instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(GameMode.ScoreColumn instance) { }

	public static void SerializeLengthDelimited(Stream stream, GameMode.ScoreColumn instance) { }

	public void .ctor() { }

}

public class GameMode.PlayerScore : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6402
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string playerName; // 0x18
	public ulong userid; // 0x20
	public List<int> scores; // 0x28
	public int team; // 0x30


	public static void ResetToPool(GameMode.PlayerScore instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(GameMode.PlayerScore instance) { }

	public GameMode.PlayerScore Copy() { }

	public static GameMode.PlayerScore Deserialize(Stream stream) { }

	public static GameMode.PlayerScore DeserializeLengthDelimited(Stream stream) { }

	public static GameMode.PlayerScore DeserializeLength(Stream stream, int length) { }

	public static GameMode.PlayerScore Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, GameMode.PlayerScore previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static GameMode.PlayerScore Deserialize(byte[] buffer, GameMode.PlayerScore instance, bool isDelta = False) { }

	public static GameMode.PlayerScore Deserialize(Stream stream, GameMode.PlayerScore instance, bool isDelta) { }

	public static GameMode.PlayerScore DeserializeLengthDelimited(Stream stream, GameMode.PlayerScore instance, bool isDelta) { }

	public static GameMode.PlayerScore DeserializeLength(Stream stream, int length, GameMode.PlayerScore instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, GameMode.PlayerScore instance, GameMode.PlayerScore previous) { }

	public static void Serialize(Stream stream, GameMode.PlayerScore instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(GameMode.PlayerScore instance) { }

	public static void SerializeLengthDelimited(Stream stream, GameMode.PlayerScore instance) { }

	public void .ctor() { }

}

public class gamemode : ConsoleSystem // TypeDefIndex: 11928
{
	public void .ctor() { }

}

