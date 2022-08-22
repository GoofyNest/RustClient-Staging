public class GameMode : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6399
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<GameMode.TeamInfo> teams; // 0x18
	public List<GameMode.ScoreColumn> scoreColumns; // 0x20
	public List<GameMode.PlayerScore> playerScores; // 0x28

	// Methods

	// RVA: 0x1D5D430 Offset: 0x1D5BA30 VA: 0x181D5D430
	public static void ResetToPool(GameMode instance) { }

	// RVA: 0x1D5D010 Offset: 0x1D5B610 VA: 0x181D5D010
	public void ResetToPool() { }

	// RVA: 0x1D5CF50 Offset: 0x1D5B550 VA: 0x181D5CF50 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D5B9C0 Offset: 0x1D59FC0 VA: 0x181D5B9C0
	public void CopyTo(GameMode instance) { }

	// RVA: 0x1D5BEC0 Offset: 0x1D5A4C0 VA: 0x181D5BEC0
	public GameMode Copy() { }

	// RVA: 0x1D5CA30 Offset: 0x1D5B030 VA: 0x181D5CA30
	public static GameMode Deserialize(Stream stream) { }

	// RVA: 0x1D5C3B0 Offset: 0x1D5A9B0 VA: 0x181D5C3B0
	public static GameMode DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D5C430 Offset: 0x1D5AA30 VA: 0x181D5C430
	public static GameMode DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D5C910 Offset: 0x1D5AF10 VA: 0x181D5C910
	public static GameMode Deserialize(byte[] buffer) { }

	// RVA: 0x1D5CFD0 Offset: 0x1D5B5D0 VA: 0x181D5CFD0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D5E3E0 Offset: 0x1D5C9E0 VA: 0x181D5E3E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D5E400 Offset: 0x1D5CA00 VA: 0x181D5E400 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, GameMode previous) { }

	// RVA: 0x1D5CFF0 Offset: 0x1D5B5F0 VA: 0x181D5CFF0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D5CAB0 Offset: 0x1D5B0B0 VA: 0x181D5CAB0
	public static GameMode Deserialize(byte[] buffer, GameMode instance, bool isDelta = False) { }

	// RVA: 0x1D5CBB0 Offset: 0x1D5B1B0 VA: 0x181D5CBB0
	public static GameMode Deserialize(Stream stream, GameMode instance, bool isDelta) { }

	// RVA: 0x1D5BF40 Offset: 0x1D5A540 VA: 0x181D5BF40
	public static GameMode DeserializeLengthDelimited(Stream stream, GameMode instance, bool isDelta) { }

	// RVA: 0x1D5C4C0 Offset: 0x1D5AAC0 VA: 0x181D5C4C0
	public static GameMode DeserializeLength(Stream stream, int length, GameMode instance, bool isDelta) { }

	// RVA: 0x1D5D850 Offset: 0x1D5BE50 VA: 0x181D5D850
	public static void SerializeDelta(Stream stream, GameMode instance, GameMode previous) { }

	// RVA: 0x1D5DED0 Offset: 0x1D5C4D0 VA: 0x181D5DED0
	public static void Serialize(Stream stream, GameMode instance) { }

	// RVA: 0x1D5E3D0 Offset: 0x1D5C9D0 VA: 0x181D5E3D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D5E3E0 Offset: 0x1D5C9E0 VA: 0x181D5E3E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1D5DDC0 Offset: 0x1D5C3C0 VA: 0x181D5DDC0
	public static byte[] SerializeToBytes(GameMode instance) { }

	// RVA: 0x1D5DD10 Offset: 0x1D5C310 VA: 0x181D5DD10
	public static void SerializeLengthDelimited(Stream stream, GameMode instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class GameMode.TeamInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6400
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int score; // 0x14

	// Methods

	// RVA: 0x1D6B120 Offset: 0x1D69720 VA: 0x181D6B120
	public static void ResetToPool(GameMode.TeamInfo instance) { }

	// RVA: 0x1D6B0A0 Offset: 0x1D696A0 VA: 0x181D6B0A0
	public void ResetToPool() { }

	// RVA: 0x1D6AFE0 Offset: 0x1D695E0 VA: 0x181D6AFE0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE790 Offset: 0x1BFCD90 VA: 0x181BFE790
	public void CopyTo(GameMode.TeamInfo instance) { }

	// RVA: 0x1D6A660 Offset: 0x1D68C60 VA: 0x181D6A660
	public GameMode.TeamInfo Copy() { }

	// RVA: 0x1D6AE40 Offset: 0x1D69440 VA: 0x181D6AE40
	public static GameMode.TeamInfo Deserialize(Stream stream) { }

	// RVA: 0x1D6A6D0 Offset: 0x1D68CD0 VA: 0x181D6A6D0
	public static GameMode.TeamInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D6AB70 Offset: 0x1D69170 VA: 0x181D6AB70
	public static GameMode.TeamInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D6AEC0 Offset: 0x1D694C0 VA: 0x181D6AEC0
	public static GameMode.TeamInfo Deserialize(byte[] buffer) { }

	// RVA: 0x1D6B060 Offset: 0x1D69660 VA: 0x181D6B060
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D6B5F0 Offset: 0x1D69BF0 VA: 0x181D6B5F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D6B6C0 Offset: 0x1D69CC0 VA: 0x181D6B6C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, GameMode.TeamInfo previous) { }

	// RVA: 0x1D6B080 Offset: 0x1D69680 VA: 0x181D6B080 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D6AD40 Offset: 0x1D69340 VA: 0x181D6AD40
	public static GameMode.TeamInfo Deserialize(byte[] buffer, GameMode.TeamInfo instance, bool isDelta = False) { }

	// RVA: 0x1D6AC00 Offset: 0x1D69200 VA: 0x181D6AC00
	public static GameMode.TeamInfo Deserialize(Stream stream, GameMode.TeamInfo instance, bool isDelta) { }

	// RVA: 0x1D6A750 Offset: 0x1D68D50 VA: 0x181D6A750
	public static GameMode.TeamInfo DeserializeLengthDelimited(Stream stream, GameMode.TeamInfo instance, bool isDelta) { }

	// RVA: 0x1D6A970 Offset: 0x1D68F70 VA: 0x181D6A970
	public static GameMode.TeamInfo DeserializeLength(Stream stream, int length, GameMode.TeamInfo instance, bool isDelta) { }

	// RVA: 0x1D6B1A0 Offset: 0x1D697A0 VA: 0x181D6B1A0
	public static void SerializeDelta(Stream stream, GameMode.TeamInfo instance, GameMode.TeamInfo previous) { }

	// RVA: 0x1D6B510 Offset: 0x1D69B10 VA: 0x181D6B510
	public static void Serialize(Stream stream, GameMode.TeamInfo instance) { }

	// RVA: 0x1D6B5E0 Offset: 0x1D69BE0 VA: 0x181D6B5E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D6B5F0 Offset: 0x1D69BF0 VA: 0x181D6B5F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1D6B360 Offset: 0x1D69960 VA: 0x181D6B360
	public static byte[] SerializeToBytes(GameMode.TeamInfo instance) { }

	// RVA: 0x1D6B2B0 Offset: 0x1D698B0 VA: 0x181D6B2B0
	public static void SerializeLengthDelimited(Stream stream, GameMode.TeamInfo instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class GameMode.ScoreColumn : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6401
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string name; // 0x18

	// Methods

	// RVA: 0x1D68970 Offset: 0x1D66F70 VA: 0x181D68970
	public static void ResetToPool(GameMode.ScoreColumn instance) { }

	// RVA: 0x1D688E0 Offset: 0x1D66EE0 VA: 0x181D688E0
	public void ResetToPool() { }

	// RVA: 0x1D68820 Offset: 0x1D66E20 VA: 0x181D68820 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D67E50 Offset: 0x1D66450 VA: 0x181D67E50
	public void CopyTo(GameMode.ScoreColumn instance) { }

	// RVA: 0x1D67E80 Offset: 0x1D66480 VA: 0x181D67E80
	public GameMode.ScoreColumn Copy() { }

	// RVA: 0x1D68530 Offset: 0x1D66B30 VA: 0x181D68530
	public static GameMode.ScoreColumn Deserialize(Stream stream) { }

	// RVA: 0x1D67F00 Offset: 0x1D66500 VA: 0x181D67F00
	public static GameMode.ScoreColumn DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D683A0 Offset: 0x1D669A0 VA: 0x181D683A0
	public static GameMode.ScoreColumn DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D68700 Offset: 0x1D66D00 VA: 0x181D68700
	public static GameMode.ScoreColumn Deserialize(byte[] buffer) { }

	// RVA: 0x1D688A0 Offset: 0x1D66EA0 VA: 0x181D688A0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D68E60 Offset: 0x1D67460 VA: 0x181D68E60 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D68E80 Offset: 0x1D67480 VA: 0x181D68E80 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, GameMode.ScoreColumn previous) { }

	// RVA: 0x1D688C0 Offset: 0x1D66EC0 VA: 0x181D688C0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D68430 Offset: 0x1D66A30 VA: 0x181D68430
	public static GameMode.ScoreColumn Deserialize(byte[] buffer, GameMode.ScoreColumn instance, bool isDelta = False) { }

	// RVA: 0x1D685B0 Offset: 0x1D66BB0 VA: 0x181D685B0
	public static GameMode.ScoreColumn Deserialize(Stream stream, GameMode.ScoreColumn instance, bool isDelta) { }

	// RVA: 0x1D67F80 Offset: 0x1D66580 VA: 0x181D67F80
	public static GameMode.ScoreColumn DeserializeLengthDelimited(Stream stream, GameMode.ScoreColumn instance, bool isDelta) { }

	// RVA: 0x1D681A0 Offset: 0x1D667A0 VA: 0x181D681A0
	public static GameMode.ScoreColumn DeserializeLength(Stream stream, int length, GameMode.ScoreColumn instance, bool isDelta) { }

	// RVA: 0x1D68A00 Offset: 0x1D67000 VA: 0x181D68A00
	public static void SerializeDelta(Stream stream, GameMode.ScoreColumn instance, GameMode.ScoreColumn previous) { }

	// RVA: 0x1D68D20 Offset: 0x1D67320 VA: 0x181D68D20
	public static void Serialize(Stream stream, GameMode.ScoreColumn instance) { }

	// RVA: 0x1D68E50 Offset: 0x1D67450 VA: 0x181D68E50
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D68E60 Offset: 0x1D67460 VA: 0x181D68E60
	public void ToProto(Stream stream) { }

	// RVA: 0x1D68C10 Offset: 0x1D67210 VA: 0x181D68C10
	public static byte[] SerializeToBytes(GameMode.ScoreColumn instance) { }

	// RVA: 0x1D68B60 Offset: 0x1D67160 VA: 0x181D68B60
	public static void SerializeLengthDelimited(Stream stream, GameMode.ScoreColumn instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x1D67610 Offset: 0x1D65C10 VA: 0x181D67610
	public static void ResetToPool(GameMode.PlayerScore instance) { }

	// RVA: 0x1D674E0 Offset: 0x1D65AE0 VA: 0x181D674E0
	public void ResetToPool() { }

	// RVA: 0x1D671B0 Offset: 0x1D657B0 VA: 0x181D671B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D65B50 Offset: 0x1D64150 VA: 0x181D65B50
	public void CopyTo(GameMode.PlayerScore instance) { }

	// RVA: 0x1D65C80 Offset: 0x1D64280 VA: 0x181D65C80
	public GameMode.PlayerScore Copy() { }

	// RVA: 0x1D665B0 Offset: 0x1D64BB0 VA: 0x181D665B0
	public static GameMode.PlayerScore Deserialize(Stream stream) { }

	// RVA: 0x1D66160 Offset: 0x1D64760 VA: 0x181D66160
	public static GameMode.PlayerScore DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D661E0 Offset: 0x1D647E0 VA: 0x181D661E0
	public static GameMode.PlayerScore DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D66860 Offset: 0x1D64E60 VA: 0x181D66860
	public static GameMode.PlayerScore Deserialize(byte[] buffer) { }

	// RVA: 0x1D67230 Offset: 0x1D65830 VA: 0x181D67230
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D67E10 Offset: 0x1D66410 VA: 0x181D67E10 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D67E30 Offset: 0x1D66430 VA: 0x181D67E30 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, GameMode.PlayerScore previous) { }

	// RVA: 0x1D674C0 Offset: 0x1D65AC0 VA: 0x181D674C0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D66E40 Offset: 0x1D65440 VA: 0x181D66E40
	public static GameMode.PlayerScore Deserialize(byte[] buffer, GameMode.PlayerScore instance, bool isDelta = False) { }

	// RVA: 0x1D66BB0 Offset: 0x1D651B0 VA: 0x181D66BB0
	public static GameMode.PlayerScore Deserialize(Stream stream, GameMode.PlayerScore instance, bool isDelta) { }

	// RVA: 0x1D65E00 Offset: 0x1D64400 VA: 0x181D65E00
	public static GameMode.PlayerScore DeserializeLengthDelimited(Stream stream, GameMode.PlayerScore instance, bool isDelta) { }

	// RVA: 0x1D66270 Offset: 0x1D64870 VA: 0x181D66270
	public static GameMode.PlayerScore DeserializeLength(Stream stream, int length, GameMode.PlayerScore instance, bool isDelta) { }

	// RVA: 0x1D67740 Offset: 0x1D65D40 VA: 0x181D67740
	public static void SerializeDelta(Stream stream, GameMode.PlayerScore instance, GameMode.PlayerScore previous) { }

	// RVA: 0x1D67BC0 Offset: 0x1D661C0 VA: 0x181D67BC0
	public static void Serialize(Stream stream, GameMode.PlayerScore instance) { }

	// RVA: 0x1D67E00 Offset: 0x1D66400 VA: 0x181D67E00
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D67E10 Offset: 0x1D66410 VA: 0x181D67E10
	public void ToProto(Stream stream) { }

	// RVA: 0x1D67AB0 Offset: 0x1D660B0 VA: 0x181D67AB0
	public static byte[] SerializeToBytes(GameMode.PlayerScore instance) { }

	// RVA: 0x1D67A00 Offset: 0x1D66000 VA: 0x181D67A00
	public static void SerializeLengthDelimited(Stream stream, GameMode.PlayerScore instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class gamemode : ConsoleSystem // TypeDefIndex: 11924
{	// Methods

	// RVA: 0x372500 Offset: 0x370B00 VA: 0x180372500
	public void .ctor() { }

}

