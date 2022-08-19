public class GameMode : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6399
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<GameMode.TeamInfo> teams; // 0x18
	public List<GameMode.ScoreColumn> scoreColumns; // 0x20
	public List<GameMode.PlayerScore> playerScores; // 0x28

	// Methods

	// RVA: 0x1D5D330 Offset: 0x1D5B930 VA: 0x181D5D330
	public static void ResetToPool(GameMode instance) { }

	// RVA: 0x1D5CF10 Offset: 0x1D5B510 VA: 0x181D5CF10
	public void ResetToPool() { }

	// RVA: 0x1D5CE50 Offset: 0x1D5B450 VA: 0x181D5CE50 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D5B8C0 Offset: 0x1D59EC0 VA: 0x181D5B8C0
	public void CopyTo(GameMode instance) { }

	// RVA: 0x1D5BDC0 Offset: 0x1D5A3C0 VA: 0x181D5BDC0
	public GameMode Copy() { }

	// RVA: 0x1D5C930 Offset: 0x1D5AF30 VA: 0x181D5C930
	public static GameMode Deserialize(Stream stream) { }

	// RVA: 0x1D5C2B0 Offset: 0x1D5A8B0 VA: 0x181D5C2B0
	public static GameMode DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D5C330 Offset: 0x1D5A930 VA: 0x181D5C330
	public static GameMode DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D5C810 Offset: 0x1D5AE10 VA: 0x181D5C810
	public static GameMode Deserialize(byte[] buffer) { }

	// RVA: 0x1D5CED0 Offset: 0x1D5B4D0 VA: 0x181D5CED0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D5E2E0 Offset: 0x1D5C8E0 VA: 0x181D5E2E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D5E300 Offset: 0x1D5C900 VA: 0x181D5E300 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, GameMode previous) { }

	// RVA: 0x1D5CEF0 Offset: 0x1D5B4F0 VA: 0x181D5CEF0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D5C9B0 Offset: 0x1D5AFB0 VA: 0x181D5C9B0
	public static GameMode Deserialize(byte[] buffer, GameMode instance, bool isDelta = False) { }

	// RVA: 0x1D5CAB0 Offset: 0x1D5B0B0 VA: 0x181D5CAB0
	public static GameMode Deserialize(Stream stream, GameMode instance, bool isDelta) { }

	// RVA: 0x1D5BE40 Offset: 0x1D5A440 VA: 0x181D5BE40
	public static GameMode DeserializeLengthDelimited(Stream stream, GameMode instance, bool isDelta) { }

	// RVA: 0x1D5C3C0 Offset: 0x1D5A9C0 VA: 0x181D5C3C0
	public static GameMode DeserializeLength(Stream stream, int length, GameMode instance, bool isDelta) { }

	// RVA: 0x1D5D750 Offset: 0x1D5BD50 VA: 0x181D5D750
	public static void SerializeDelta(Stream stream, GameMode instance, GameMode previous) { }

	// RVA: 0x1D5DDD0 Offset: 0x1D5C3D0 VA: 0x181D5DDD0
	public static void Serialize(Stream stream, GameMode instance) { }

	// RVA: 0x1D5E2D0 Offset: 0x1D5C8D0 VA: 0x181D5E2D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D5E2E0 Offset: 0x1D5C8E0 VA: 0x181D5E2E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1D5DCC0 Offset: 0x1D5C2C0 VA: 0x181D5DCC0
	public static byte[] SerializeToBytes(GameMode instance) { }

	// RVA: 0x1D5DC10 Offset: 0x1D5C210 VA: 0x181D5DC10
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

	// RVA: 0x1D6B020 Offset: 0x1D69620 VA: 0x181D6B020
	public static void ResetToPool(GameMode.TeamInfo instance) { }

	// RVA: 0x1D6AFA0 Offset: 0x1D695A0 VA: 0x181D6AFA0
	public void ResetToPool() { }

	// RVA: 0x1D6AEE0 Offset: 0x1D694E0 VA: 0x181D6AEE0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE690 Offset: 0x1BFCC90 VA: 0x181BFE690
	public void CopyTo(GameMode.TeamInfo instance) { }

	// RVA: 0x1D6A560 Offset: 0x1D68B60 VA: 0x181D6A560
	public GameMode.TeamInfo Copy() { }

	// RVA: 0x1D6AD40 Offset: 0x1D69340 VA: 0x181D6AD40
	public static GameMode.TeamInfo Deserialize(Stream stream) { }

	// RVA: 0x1D6A5D0 Offset: 0x1D68BD0 VA: 0x181D6A5D0
	public static GameMode.TeamInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D6AA70 Offset: 0x1D69070 VA: 0x181D6AA70
	public static GameMode.TeamInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D6ADC0 Offset: 0x1D693C0 VA: 0x181D6ADC0
	public static GameMode.TeamInfo Deserialize(byte[] buffer) { }

	// RVA: 0x1D6AF60 Offset: 0x1D69560 VA: 0x181D6AF60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D6B4F0 Offset: 0x1D69AF0 VA: 0x181D6B4F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D6B5C0 Offset: 0x1D69BC0 VA: 0x181D6B5C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, GameMode.TeamInfo previous) { }

	// RVA: 0x1D6AF80 Offset: 0x1D69580 VA: 0x181D6AF80 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D6AC40 Offset: 0x1D69240 VA: 0x181D6AC40
	public static GameMode.TeamInfo Deserialize(byte[] buffer, GameMode.TeamInfo instance, bool isDelta = False) { }

	// RVA: 0x1D6AB00 Offset: 0x1D69100 VA: 0x181D6AB00
	public static GameMode.TeamInfo Deserialize(Stream stream, GameMode.TeamInfo instance, bool isDelta) { }

	// RVA: 0x1D6A650 Offset: 0x1D68C50 VA: 0x181D6A650
	public static GameMode.TeamInfo DeserializeLengthDelimited(Stream stream, GameMode.TeamInfo instance, bool isDelta) { }

	// RVA: 0x1D6A870 Offset: 0x1D68E70 VA: 0x181D6A870
	public static GameMode.TeamInfo DeserializeLength(Stream stream, int length, GameMode.TeamInfo instance, bool isDelta) { }

	// RVA: 0x1D6B0A0 Offset: 0x1D696A0 VA: 0x181D6B0A0
	public static void SerializeDelta(Stream stream, GameMode.TeamInfo instance, GameMode.TeamInfo previous) { }

	// RVA: 0x1D6B410 Offset: 0x1D69A10 VA: 0x181D6B410
	public static void Serialize(Stream stream, GameMode.TeamInfo instance) { }

	// RVA: 0x1D6B4E0 Offset: 0x1D69AE0 VA: 0x181D6B4E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D6B4F0 Offset: 0x1D69AF0 VA: 0x181D6B4F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1D6B260 Offset: 0x1D69860 VA: 0x181D6B260
	public static byte[] SerializeToBytes(GameMode.TeamInfo instance) { }

	// RVA: 0x1D6B1B0 Offset: 0x1D697B0 VA: 0x181D6B1B0
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

	// RVA: 0x1D68870 Offset: 0x1D66E70 VA: 0x181D68870
	public static void ResetToPool(GameMode.ScoreColumn instance) { }

	// RVA: 0x1D687E0 Offset: 0x1D66DE0 VA: 0x181D687E0
	public void ResetToPool() { }

	// RVA: 0x1D68720 Offset: 0x1D66D20 VA: 0x181D68720 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D67D50 Offset: 0x1D66350 VA: 0x181D67D50
	public void CopyTo(GameMode.ScoreColumn instance) { }

	// RVA: 0x1D67D80 Offset: 0x1D66380 VA: 0x181D67D80
	public GameMode.ScoreColumn Copy() { }

	// RVA: 0x1D68430 Offset: 0x1D66A30 VA: 0x181D68430
	public static GameMode.ScoreColumn Deserialize(Stream stream) { }

	// RVA: 0x1D67E00 Offset: 0x1D66400 VA: 0x181D67E00
	public static GameMode.ScoreColumn DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D682A0 Offset: 0x1D668A0 VA: 0x181D682A0
	public static GameMode.ScoreColumn DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D68600 Offset: 0x1D66C00 VA: 0x181D68600
	public static GameMode.ScoreColumn Deserialize(byte[] buffer) { }

	// RVA: 0x1D687A0 Offset: 0x1D66DA0 VA: 0x181D687A0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D68D60 Offset: 0x1D67360 VA: 0x181D68D60 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D68D80 Offset: 0x1D67380 VA: 0x181D68D80 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, GameMode.ScoreColumn previous) { }

	// RVA: 0x1D687C0 Offset: 0x1D66DC0 VA: 0x181D687C0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D68330 Offset: 0x1D66930 VA: 0x181D68330
	public static GameMode.ScoreColumn Deserialize(byte[] buffer, GameMode.ScoreColumn instance, bool isDelta = False) { }

	// RVA: 0x1D684B0 Offset: 0x1D66AB0 VA: 0x181D684B0
	public static GameMode.ScoreColumn Deserialize(Stream stream, GameMode.ScoreColumn instance, bool isDelta) { }

	// RVA: 0x1D67E80 Offset: 0x1D66480 VA: 0x181D67E80
	public static GameMode.ScoreColumn DeserializeLengthDelimited(Stream stream, GameMode.ScoreColumn instance, bool isDelta) { }

	// RVA: 0x1D680A0 Offset: 0x1D666A0 VA: 0x181D680A0
	public static GameMode.ScoreColumn DeserializeLength(Stream stream, int length, GameMode.ScoreColumn instance, bool isDelta) { }

	// RVA: 0x1D68900 Offset: 0x1D66F00 VA: 0x181D68900
	public static void SerializeDelta(Stream stream, GameMode.ScoreColumn instance, GameMode.ScoreColumn previous) { }

	// RVA: 0x1D68C20 Offset: 0x1D67220 VA: 0x181D68C20
	public static void Serialize(Stream stream, GameMode.ScoreColumn instance) { }

	// RVA: 0x1D68D50 Offset: 0x1D67350 VA: 0x181D68D50
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D68D60 Offset: 0x1D67360 VA: 0x181D68D60
	public void ToProto(Stream stream) { }

	// RVA: 0x1D68B10 Offset: 0x1D67110 VA: 0x181D68B10
	public static byte[] SerializeToBytes(GameMode.ScoreColumn instance) { }

	// RVA: 0x1D68A60 Offset: 0x1D67060 VA: 0x181D68A60
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

	// RVA: 0x1D67510 Offset: 0x1D65B10 VA: 0x181D67510
	public static void ResetToPool(GameMode.PlayerScore instance) { }

	// RVA: 0x1D673E0 Offset: 0x1D659E0 VA: 0x181D673E0
	public void ResetToPool() { }

	// RVA: 0x1D670B0 Offset: 0x1D656B0 VA: 0x181D670B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D65A50 Offset: 0x1D64050 VA: 0x181D65A50
	public void CopyTo(GameMode.PlayerScore instance) { }

	// RVA: 0x1D65B80 Offset: 0x1D64180 VA: 0x181D65B80
	public GameMode.PlayerScore Copy() { }

	// RVA: 0x1D664B0 Offset: 0x1D64AB0 VA: 0x181D664B0
	public static GameMode.PlayerScore Deserialize(Stream stream) { }

	// RVA: 0x1D66060 Offset: 0x1D64660 VA: 0x181D66060
	public static GameMode.PlayerScore DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D660E0 Offset: 0x1D646E0 VA: 0x181D660E0
	public static GameMode.PlayerScore DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D66760 Offset: 0x1D64D60 VA: 0x181D66760
	public static GameMode.PlayerScore Deserialize(byte[] buffer) { }

	// RVA: 0x1D67130 Offset: 0x1D65730 VA: 0x181D67130
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D67D10 Offset: 0x1D66310 VA: 0x181D67D10 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D67D30 Offset: 0x1D66330 VA: 0x181D67D30 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, GameMode.PlayerScore previous) { }

	// RVA: 0x1D673C0 Offset: 0x1D659C0 VA: 0x181D673C0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D66D40 Offset: 0x1D65340 VA: 0x181D66D40
	public static GameMode.PlayerScore Deserialize(byte[] buffer, GameMode.PlayerScore instance, bool isDelta = False) { }

	// RVA: 0x1D66AB0 Offset: 0x1D650B0 VA: 0x181D66AB0
	public static GameMode.PlayerScore Deserialize(Stream stream, GameMode.PlayerScore instance, bool isDelta) { }

	// RVA: 0x1D65D00 Offset: 0x1D64300 VA: 0x181D65D00
	public static GameMode.PlayerScore DeserializeLengthDelimited(Stream stream, GameMode.PlayerScore instance, bool isDelta) { }

	// RVA: 0x1D66170 Offset: 0x1D64770 VA: 0x181D66170
	public static GameMode.PlayerScore DeserializeLength(Stream stream, int length, GameMode.PlayerScore instance, bool isDelta) { }

	// RVA: 0x1D67640 Offset: 0x1D65C40 VA: 0x181D67640
	public static void SerializeDelta(Stream stream, GameMode.PlayerScore instance, GameMode.PlayerScore previous) { }

	// RVA: 0x1D67AC0 Offset: 0x1D660C0 VA: 0x181D67AC0
	public static void Serialize(Stream stream, GameMode.PlayerScore instance) { }

	// RVA: 0x1D67D00 Offset: 0x1D66300 VA: 0x181D67D00
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D67D10 Offset: 0x1D66310 VA: 0x181D67D10
	public void ToProto(Stream stream) { }

	// RVA: 0x1D679B0 Offset: 0x1D65FB0 VA: 0x181D679B0
	public static byte[] SerializeToBytes(GameMode.PlayerScore instance) { }

	// RVA: 0x1D67900 Offset: 0x1D65F00 VA: 0x181D67900
	public static void SerializeLengthDelimited(Stream stream, GameMode.PlayerScore instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class gamemode : ConsoleSystem // TypeDefIndex: 11924
{	// Methods

	// RVA: 0x372500 Offset: 0x370B00 VA: 0x180372500
	public void .ctor() { }

}

