public class CardTable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6407
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<CardTable.CardPlayer> players; // 0x18
	public int pot; // 0x20
	public CardTable.TexasHoldEm texasHoldEm; // 0x28
	public int lastActionId; // 0x30
	public ulong lastActionTarget; // 0x38
	public int lastActionValue; // 0x40
	public uint potRef; // 0x44

	// Methods

	// RVA: 0x1F7B110 Offset: 0x1F79710 VA: 0x181F7B110
	public static void ResetToPool(CardTable instance) { }

	// RVA: 0x1F7B360 Offset: 0x1F79960 VA: 0x181F7B360
	public void ResetToPool() { }

	// RVA: 0x1F7ACD0 Offset: 0x1F792D0 VA: 0x181F7ACD0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F78F40 Offset: 0x1F77540 VA: 0x181F78F40
	public void CopyTo(CardTable instance) { }

	// RVA: 0x1F792D0 Offset: 0x1F778D0 VA: 0x181F792D0
	public CardTable Copy() { }

	// RVA: 0x1F7A0B0 Offset: 0x1F786B0 VA: 0x181F7A0B0
	public static CardTable Deserialize(Stream stream) { }

	// RVA: 0x1F79350 Offset: 0x1F77950 VA: 0x181F79350
	public static CardTable DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F79840 Offset: 0x1F77E40 VA: 0x181F79840
	public static CardTable DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F7A8B0 Offset: 0x1F78EB0 VA: 0x181F7A8B0
	public static CardTable Deserialize(byte[] buffer) { }

	// RVA: 0x1F7AD50 Offset: 0x1F79350 VA: 0x181F7AD50
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F7BFD0 Offset: 0x1F7A5D0 VA: 0x181F7BFD0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F7BFF0 Offset: 0x1F7A5F0 VA: 0x181F7BFF0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CardTable previous) { }

	// RVA: 0x1F7B0F0 Offset: 0x1F796F0 VA: 0x181F7B0F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F7A440 Offset: 0x1F78A40 VA: 0x181F7A440
	public static CardTable Deserialize(byte[] buffer, CardTable instance, bool isDelta = False) { }

	// RVA: 0x1F79D10 Offset: 0x1F78310 VA: 0x181F79D10
	public static CardTable Deserialize(Stream stream, CardTable instance, bool isDelta) { }

	// RVA: 0x1F793D0 Offset: 0x1F779D0 VA: 0x181F793D0
	public static CardTable DeserializeLengthDelimited(Stream stream, CardTable instance, bool isDelta) { }

	// RVA: 0x1F798D0 Offset: 0x1F77ED0 VA: 0x181F798D0
	public static CardTable DeserializeLength(Stream stream, int length, CardTable instance, bool isDelta) { }

	// RVA: 0x1F7B5B0 Offset: 0x1F79BB0 VA: 0x181F7B5B0
	public static void SerializeDelta(Stream stream, CardTable instance, CardTable previous) { }

	// RVA: 0x1F7BC00 Offset: 0x1F7A200 VA: 0x181F7BC00
	public static void Serialize(Stream stream, CardTable instance) { }

	// RVA: 0x1F7BFC0 Offset: 0x1F7A5C0 VA: 0x181F7BFC0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F7BFD0 Offset: 0x1F7A5D0 VA: 0x181F7BFD0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F7BAF0 Offset: 0x1F7A0F0 VA: 0x181F7BAF0
	public static byte[] SerializeToBytes(CardTable instance) { }

	// RVA: 0x1F7BA40 Offset: 0x1F7A040 VA: 0x181F7BA40
	public static void SerializeLengthDelimited(Stream stream, CardTable instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class CardTable.CardPlayer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6408
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong userid; // 0x18
	public List<int> cards; // 0x20
	public int scrap; // 0x28
	public int state; // 0x2C
	public int availableInputs; // 0x30
	public int betThisRound; // 0x34
	public int betThisTurn; // 0x38
	public int trueCardCount; // 0x3C
	public bool leftRoundEarly; // 0x40
	public bool sendCardDetails; // 0x41

	// Methods

	// RVA: 0x1F78360 Offset: 0x1F76960 VA: 0x181F78360
	public static void ResetToPool(CardTable.CardPlayer instance) { }

	// RVA: 0x1F784C0 Offset: 0x1F76AC0 VA: 0x181F784C0
	public void ResetToPool() { }

	// RVA: 0x1F782A0 Offset: 0x1F768A0 VA: 0x181F782A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F76E40 Offset: 0x1F75440 VA: 0x181F76E40
	public void CopyTo(CardTable.CardPlayer instance) { }

	// RVA: 0x1F76FA0 Offset: 0x1F755A0 VA: 0x181F76FA0
	public CardTable.CardPlayer Copy() { }

	// RVA: 0x1F77E10 Offset: 0x1F76410 VA: 0x181F77E10
	public static CardTable.CardPlayer Deserialize(Stream stream) { }

	// RVA: 0x1F77140 Offset: 0x1F75740 VA: 0x181F77140
	public static CardTable.CardPlayer DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F776A0 Offset: 0x1F75CA0 VA: 0x181F776A0
	public static CardTable.CardPlayer DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F77CF0 Offset: 0x1F762F0 VA: 0x181F77CF0
	public static CardTable.CardPlayer Deserialize(byte[] buffer) { }

	// RVA: 0x1F78320 Offset: 0x1F76920 VA: 0x181F78320
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F78F00 Offset: 0x1F77500 VA: 0x181F78F00 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F78F20 Offset: 0x1F77520 VA: 0x181F78F20 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CardTable.CardPlayer previous) { }

	// RVA: 0x1F78340 Offset: 0x1F76940 VA: 0x181F78340 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F77BF0 Offset: 0x1F761F0 VA: 0x181F77BF0
	public static CardTable.CardPlayer Deserialize(byte[] buffer, CardTable.CardPlayer instance, bool isDelta = False) { }

	// RVA: 0x1F77E90 Offset: 0x1F76490 VA: 0x181F77E90
	public static CardTable.CardPlayer Deserialize(Stream stream, CardTable.CardPlayer instance, bool isDelta) { }

	// RVA: 0x1F771C0 Offset: 0x1F757C0 VA: 0x181F771C0
	public static CardTable.CardPlayer DeserializeLengthDelimited(Stream stream, CardTable.CardPlayer instance, bool isDelta) { }

	// RVA: 0x1F77730 Offset: 0x1F75D30 VA: 0x181F77730
	public static CardTable.CardPlayer DeserializeLength(Stream stream, int length, CardTable.CardPlayer instance, bool isDelta) { }

	// RVA: 0x1F78620 Offset: 0x1F76C20 VA: 0x181F78620
	public static void SerializeDelta(Stream stream, CardTable.CardPlayer instance, CardTable.CardPlayer previous) { }

	// RVA: 0x1F78C20 Offset: 0x1F77220 VA: 0x181F78C20
	public static void Serialize(Stream stream, CardTable.CardPlayer instance) { }

	// RVA: 0x1F78EF0 Offset: 0x1F774F0 VA: 0x181F78EF0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F78F00 Offset: 0x1F77500 VA: 0x181F78F00
	public void ToProto(Stream stream) { }

	// RVA: 0x1F78B10 Offset: 0x1F77110 VA: 0x181F78B10
	public static byte[] SerializeToBytes(CardTable.CardPlayer instance) { }

	// RVA: 0x1F78A60 Offset: 0x1F77060 VA: 0x181F78A60
	public static void SerializeLengthDelimited(Stream stream, CardTable.CardPlayer instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class CardTable.TexasHoldEm : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6409
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int dealerIndex; // 0x14
	public List<int> communityCards; // 0x18
	public int activePlayerIndex; // 0x20
	public int biggestRaiseThisTurn; // 0x24

	// Methods

	// RVA: 0x1F7EEC0 Offset: 0x1F7D4C0 VA: 0x181F7EEC0
	public static void ResetToPool(CardTable.TexasHoldEm instance) { }

	// RVA: 0x1F7EDC0 Offset: 0x1F7D3C0 VA: 0x181F7EDC0
	public void ResetToPool() { }

	// RVA: 0x1F7EAA0 Offset: 0x1F7D0A0 VA: 0x181F7EAA0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F7D5B0 Offset: 0x1F7BBB0 VA: 0x181F7D5B0
	public void CopyTo(CardTable.TexasHoldEm instance) { }

	// RVA: 0x1F7D6E0 Offset: 0x1F7BCE0 VA: 0x181F7D6E0
	public CardTable.TexasHoldEm Copy() { }

	// RVA: 0x1F7DEF0 Offset: 0x1F7C4F0 VA: 0x181F7DEF0
	public static CardTable.TexasHoldEm Deserialize(Stream stream) { }

	// RVA: 0x1F7DAB0 Offset: 0x1F7C0B0 VA: 0x181F7DAB0
	public static CardTable.TexasHoldEm DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F7DB30 Offset: 0x1F7C130 VA: 0x181F7DB30
	public static CardTable.TexasHoldEm DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F7E4E0 Offset: 0x1F7CAE0 VA: 0x181F7E4E0
	public static CardTable.TexasHoldEm Deserialize(byte[] buffer) { }

	// RVA: 0x1F7EB20 Offset: 0x1F7D120 VA: 0x181F7EB20
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F7F5F0 Offset: 0x1F7DBF0 VA: 0x181F7F5F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F7F610 Offset: 0x1F7DC10 VA: 0x181F7F610 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CardTable.TexasHoldEm previous) { }

	// RVA: 0x1F7EDA0 Offset: 0x1F7D3A0 VA: 0x181F7EDA0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F7E190 Offset: 0x1F7C790 VA: 0x181F7E190
	public static CardTable.TexasHoldEm Deserialize(byte[] buffer, CardTable.TexasHoldEm instance, bool isDelta = False) { }

	// RVA: 0x1F7E820 Offset: 0x1F7CE20 VA: 0x181F7E820
	public static CardTable.TexasHoldEm Deserialize(Stream stream, CardTable.TexasHoldEm instance, bool isDelta) { }

	// RVA: 0x1F7D760 Offset: 0x1F7BD60 VA: 0x181F7D760
	public static CardTable.TexasHoldEm DeserializeLengthDelimited(Stream stream, CardTable.TexasHoldEm instance, bool isDelta) { }

	// RVA: 0x1F7DBC0 Offset: 0x1F7C1C0 VA: 0x181F7DBC0
	public static CardTable.TexasHoldEm DeserializeLength(Stream stream, int length, CardTable.TexasHoldEm instance, bool isDelta) { }

	// RVA: 0x1F7EFC0 Offset: 0x1F7D5C0 VA: 0x181F7EFC0
	public static void SerializeDelta(Stream stream, CardTable.TexasHoldEm instance, CardTable.TexasHoldEm previous) { }

	// RVA: 0x1F7F3F0 Offset: 0x1F7D9F0 VA: 0x181F7F3F0
	public static void Serialize(Stream stream, CardTable.TexasHoldEm instance) { }

	// RVA: 0x1F7F5E0 Offset: 0x1F7DBE0 VA: 0x181F7F5E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F7F5F0 Offset: 0x1F7DBF0 VA: 0x181F7F5F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F7F2E0 Offset: 0x1F7D8E0 VA: 0x181F7F2E0
	public static byte[] SerializeToBytes(CardTable.TexasHoldEm instance) { }

	// RVA: 0x1F7F230 Offset: 0x1F7D830 VA: 0x181F7F230
	public static void SerializeLengthDelimited(Stream stream, CardTable.TexasHoldEm instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class CardTable.WinnerBreakdown : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6410
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<CardTable.WinnerBreakdown.Winner> winners; // 0x18
	public int winningScore; // 0x20

	// Methods

	// RVA: 0x1F80750 Offset: 0x1F7ED50 VA: 0x181F80750
	public static void ResetToPool(CardTable.WinnerBreakdown instance) { }

	// RVA: 0x1F80930 Offset: 0x1F7EF30 VA: 0x181F80930
	public void ResetToPool() { }

	// RVA: 0x1F80690 Offset: 0x1F7EC90 VA: 0x181F80690 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F7F630 Offset: 0x1F7DC30 VA: 0x181F7F630
	public void CopyTo(CardTable.WinnerBreakdown instance) { }

	// RVA: 0x1F7F760 Offset: 0x1F7DD60 VA: 0x181F7F760
	public CardTable.WinnerBreakdown Copy() { }

	// RVA: 0x1F800F0 Offset: 0x1F7E6F0 VA: 0x181F800F0
	public static CardTable.WinnerBreakdown Deserialize(Stream stream) { }

	// RVA: 0x1F7F8E0 Offset: 0x1F7DEE0 VA: 0x181F7F8E0
	public static CardTable.WinnerBreakdown DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F7FC00 Offset: 0x1F7E200 VA: 0x181F7FC00
	public static CardTable.WinnerBreakdown DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F802F0 Offset: 0x1F7E8F0 VA: 0x181F802F0
	public static CardTable.WinnerBreakdown Deserialize(byte[] buffer) { }

	// RVA: 0x1F80710 Offset: 0x1F7ED10 VA: 0x181F80710
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F81160 Offset: 0x1F7F760 VA: 0x181F81160 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F81180 Offset: 0x1F7F780 VA: 0x181F81180 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CardTable.WinnerBreakdown previous) { }

	// RVA: 0x1F80730 Offset: 0x1F7ED30 VA: 0x181F80730 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F80590 Offset: 0x1F7EB90 VA: 0x181F80590
	public static CardTable.WinnerBreakdown Deserialize(byte[] buffer, CardTable.WinnerBreakdown instance, bool isDelta = False) { }

	// RVA: 0x1F7FF20 Offset: 0x1F7E520 VA: 0x181F7FF20
	public static CardTable.WinnerBreakdown Deserialize(Stream stream, CardTable.WinnerBreakdown instance, bool isDelta) { }

	// RVA: 0x1F7F960 Offset: 0x1F7DF60 VA: 0x181F7F960
	public static CardTable.WinnerBreakdown DeserializeLengthDelimited(Stream stream, CardTable.WinnerBreakdown instance, bool isDelta) { }

	// RVA: 0x1F7FC90 Offset: 0x1F7E290 VA: 0x181F7FC90
	public static CardTable.WinnerBreakdown DeserializeLength(Stream stream, int length, CardTable.WinnerBreakdown instance, bool isDelta) { }

	// RVA: 0x1F80B10 Offset: 0x1F7F110 VA: 0x181F80B10
	public static void SerializeDelta(Stream stream, CardTable.WinnerBreakdown instance, CardTable.WinnerBreakdown previous) { }

	// RVA: 0x1F80F20 Offset: 0x1F7F520 VA: 0x181F80F20
	public static void Serialize(Stream stream, CardTable.WinnerBreakdown instance) { }

	// RVA: 0x1F81150 Offset: 0x1F7F750 VA: 0x181F81150
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F81160 Offset: 0x1F7F760 VA: 0x181F81160
	public void ToProto(Stream stream) { }

	// RVA: 0x1F80E10 Offset: 0x1F7F410 VA: 0x181F80E10
	public static byte[] SerializeToBytes(CardTable.WinnerBreakdown instance) { }

	// RVA: 0x1F80D60 Offset: 0x1F7F360 VA: 0x181F80D60
	public static void SerializeLengthDelimited(Stream stream, CardTable.WinnerBreakdown instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class CardTable.WinnerBreakdown.Winner : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6411
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong ID; // 0x18
	public int winnings; // 0x20
	public bool primaryWinner; // 0x24

	// Methods

	// RVA: 0x20C0010 Offset: 0x20BE610 VA: 0x1820C0010
	public static void ResetToPool(CardTable.WinnerBreakdown.Winner instance) { }

	// RVA: 0x20BFF80 Offset: 0x20BE580 VA: 0x1820BFF80
	public void ResetToPool() { }

	// RVA: 0x20BFCA0 Offset: 0x20BE2A0 VA: 0x1820BFCA0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20BED20 Offset: 0x20BD320 VA: 0x1820BED20
	public void CopyTo(CardTable.WinnerBreakdown.Winner instance) { }

	// RVA: 0x20BED50 Offset: 0x20BD350 VA: 0x1820BED50
	public CardTable.WinnerBreakdown.Winner Copy() { }

	// RVA: 0x20BF900 Offset: 0x20BDF00 VA: 0x1820BF900
	public static CardTable.WinnerBreakdown.Winner Deserialize(Stream stream) { }

	// RVA: 0x20BF050 Offset: 0x20BD650 VA: 0x1820BF050
	public static CardTable.WinnerBreakdown.Winner DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20BF330 Offset: 0x20BD930 VA: 0x1820BF330
	public static CardTable.WinnerBreakdown.Winner DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20BF3C0 Offset: 0x20BD9C0 VA: 0x1820BF3C0
	public static CardTable.WinnerBreakdown.Winner Deserialize(byte[] buffer) { }

	// RVA: 0x20BFDB0 Offset: 0x20BE3B0 VA: 0x1820BFDB0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20C0550 Offset: 0x20BEB50 VA: 0x1820C0550 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20C0570 Offset: 0x20BEB70 VA: 0x1820C0570 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CardTable.WinnerBreakdown.Winner previous) { }

	// RVA: 0x20BFF60 Offset: 0x20BE560 VA: 0x1820BFF60 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20BF670 Offset: 0x20BDC70 VA: 0x1820BF670
	public static CardTable.WinnerBreakdown.Winner Deserialize(byte[] buffer, CardTable.WinnerBreakdown.Winner instance, bool isDelta = False) { }

	// RVA: 0x20BFAF0 Offset: 0x20BE0F0 VA: 0x1820BFAF0
	public static CardTable.WinnerBreakdown.Winner Deserialize(Stream stream, CardTable.WinnerBreakdown.Winner instance, bool isDelta) { }

	// RVA: 0x20BEDD0 Offset: 0x20BD3D0 VA: 0x1820BEDD0
	public static CardTable.WinnerBreakdown.Winner DeserializeLengthDelimited(Stream stream, CardTable.WinnerBreakdown.Winner instance, bool isDelta) { }

	// RVA: 0x20BF0D0 Offset: 0x20BD6D0 VA: 0x1820BF0D0
	public static CardTable.WinnerBreakdown.Winner DeserializeLength(Stream stream, int length, CardTable.WinnerBreakdown.Winner instance, bool isDelta) { }

	// RVA: 0x20C00A0 Offset: 0x20BE6A0 VA: 0x1820C00A0
	public static void SerializeDelta(Stream stream, CardTable.WinnerBreakdown.Winner instance, CardTable.WinnerBreakdown.Winner previous) { }

	// RVA: 0x20C0420 Offset: 0x20BEA20 VA: 0x1820C0420
	public static void Serialize(Stream stream, CardTable.WinnerBreakdown.Winner instance) { }

	// RVA: 0x20C0540 Offset: 0x20BEB40 VA: 0x1820C0540
	public byte[] ToProtoBytes() { }

	// RVA: 0x20C0550 Offset: 0x20BEB50 VA: 0x1820C0550
	public void ToProto(Stream stream) { }

	// RVA: 0x20C0310 Offset: 0x20BE910 VA: 0x1820C0310
	public static byte[] SerializeToBytes(CardTable.WinnerBreakdown.Winner instance) { }

	// RVA: 0x20C0260 Offset: 0x20BE860 VA: 0x1820C0260
	public static void SerializeLengthDelimited(Stream stream, CardTable.WinnerBreakdown.Winner instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class CardTable.CardList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6412
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<int> cards; // 0x18

	// Methods

	// RVA: 0x1F76770 Offset: 0x1F74D70 VA: 0x181F76770
	public static void ResetToPool(CardTable.CardList instance) { }

	// RVA: 0x1F76690 Offset: 0x1F74C90 VA: 0x181F76690
	public void ResetToPool() { }

	// RVA: 0x1F76500 Offset: 0x1F74B00 VA: 0x181F76500 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F75810 Offset: 0x1F73E10 VA: 0x181F75810
	public void CopyTo(CardTable.CardList instance) { }

	// RVA: 0x1F75930 Offset: 0x1F73F30 VA: 0x181F75930
	public CardTable.CardList Copy() { }

	// RVA: 0x1F76360 Offset: 0x1F74960 VA: 0x181F76360
	public static CardTable.CardList Deserialize(Stream stream) { }

	// RVA: 0x1F75D20 Offset: 0x1F74320 VA: 0x181F75D20
	public static CardTable.CardList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F76010 Offset: 0x1F74610 VA: 0x181F76010
	public static CardTable.CardList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F763E0 Offset: 0x1F749E0 VA: 0x181F763E0
	public static CardTable.CardList Deserialize(byte[] buffer) { }

	// RVA: 0x1F76650 Offset: 0x1F74C50 VA: 0x181F76650
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F76CC0 Offset: 0x1F752C0 VA: 0x181F76CC0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F76CE0 Offset: 0x1F752E0 VA: 0x181F76CE0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CardTable.CardList previous) { }

	// RVA: 0x1F76670 Offset: 0x1F74C70 VA: 0x181F76670 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F76260 Offset: 0x1F74860 VA: 0x181F76260
	public static CardTable.CardList Deserialize(byte[] buffer, CardTable.CardList instance, bool isDelta = False) { }

	// RVA: 0x1F760A0 Offset: 0x1F746A0 VA: 0x181F760A0
	public static CardTable.CardList Deserialize(Stream stream, CardTable.CardList instance, bool isDelta) { }

	// RVA: 0x1F75A90 Offset: 0x1F74090 VA: 0x181F75A90
	public static CardTable.CardList DeserializeLengthDelimited(Stream stream, CardTable.CardList instance, bool isDelta) { }

	// RVA: 0x1F75DA0 Offset: 0x1F743A0 VA: 0x181F75DA0
	public static CardTable.CardList DeserializeLength(Stream stream, int length, CardTable.CardList instance, bool isDelta) { }

	// RVA: 0x1F76850 Offset: 0x1F74E50 VA: 0x181F76850
	public static void SerializeDelta(Stream stream, CardTable.CardList instance, CardTable.CardList previous) { }

	// RVA: 0x1F76B60 Offset: 0x1F75160 VA: 0x181F76B60
	public static void Serialize(Stream stream, CardTable.CardList instance) { }

	// RVA: 0x1F76CB0 Offset: 0x1F752B0 VA: 0x181F76CB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F76CC0 Offset: 0x1F752C0 VA: 0x181F76CC0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F76A50 Offset: 0x1F75050 VA: 0x181F76A50
	public static byte[] SerializeToBytes(CardTable.CardList instance) { }

	// RVA: 0x1F769A0 Offset: 0x1F74FA0 VA: 0x181F769A0
	public static void SerializeLengthDelimited(Stream stream, CardTable.CardList instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class CardTable : BaseVehicle // TypeDefIndex: 8367
{	// Fields
	private Option __menuOption_Menu_Open; // 0x3B8
	private Option __menuOption_Menu_Play; // 0x410
	public static CardTableUI clientUI; // 0x0
	private TimeSince showWinningsTipFor; // 0x468
	private Nullable<bool> localWasHoldingCards; // 0x46C
	private int lastVisualScrap; // 0x470
	private static Dictionary<int, Sprite> tableCardImageDict; // 0x8
	private static Sprite blankCardStatic; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <recentlyLeftPlayerName>k__BackingField; // 0x478
	[HeaderAttribute] // RVA: 0x81110 Offset: 0x80510 VA: 0x180081110
	[SerializeField] // RVA: 0x81110 Offset: 0x80510 VA: 0x180081110
	private GameObjectRef uiPrefab; // 0x480
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObjectRef playerStoragePrefab; // 0x488
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObjectRef potPrefab; // 0x490
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ViewModel viewModel; // 0x498
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private CardTableUI.PlayingCardImage[] tableCards; // 0x4A0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Renderer[] tableCardBackings; // 0x4A8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Canvas cardUICanvas; // 0x4B0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Image[] tableCardImages; // 0x4B8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Sprite blankCard; // 0x4C0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform chipStacksParent; // 0x4C8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private CardTable.ChipStack[] chipStacks; // 0x4D0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private CardTable.ChipStack[] fillerStacks; // 0x4D8
	public ItemDefinition scrapItemDef; // 0x4E0
	public CardTable.PlayerStorageInfo[] playerStoragePoints; // 0x4E8
	public CardTable.CardGameOption gameOption; // 0x4F0
	private CardGameController _gameCont; // 0x4F8
	private const float MAX_STORAGE_INTERACTION_DIST = 1;

	// Properties
	public override bool HasMenuOptions { get; }
	public static bool LocalPlayerInCardsUI { get; }
	public bool ShowTakeWinningsTip { get; }
	public string recentlyLeftPlayerName { get; set; }
	public int ScrapItemID { get; }
	public CardGameController GameController { get; }

	// Methods

	// RVA: 0x7021D0 Offset: 0x7007D0 VA: 0x1807021D0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x704DB0 Offset: 0x7033B0 VA: 0x180704DB0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x702DE0 Offset: 0x7013E0 VA: 0x180702DE0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x704F00 Offset: 0x703500 VA: 0x180704F00
	public static bool get_LocalPlayerInCardsUI() { }

	// RVA: 0x704FB0 Offset: 0x7035B0 VA: 0x180704FB0
	public bool get_ShowTakeWinningsTip() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x704FE0 Offset: 0x7035E0 VA: 0x180704FE0
	public string get_recentlyLeftPlayerName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x704FF0 Offset: 0x7035F0 VA: 0x180704FF0
	private void set_recentlyLeftPlayerName(string value) { }

	// RVA: 0x701A10 Offset: 0x700010 VA: 0x180701A10 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x7042E0 Offset: 0x7028E0 VA: 0x1807042E0
	public void RefreshLocalPlayer(CardPlayerData localPlayerData) { }

	// RVA: 0x704C10 Offset: 0x703210 VA: 0x180704C10
	public void UIClosed() { }

	// RVA: 0x702730 Offset: 0x700D30 VA: 0x180702730
	public CardTableUI.UIState GetUIGameState(CardPlayerData localPlayerData) { }

	// RVA: 0x702040 Offset: 0x700640 VA: 0x180702040
	public void GetAvailableInputs(CardPlayerData localPlayerData, List<CardTableUI.KeycodeWithAction> targetList) { }

	[BaseEntity.Menu] // RVA: 0xD0FA0 Offset: 0xD03A0 VA: 0x1800D0FA0
	[BaseEntity.Menu.Description] // RVA: 0xD0FA0 Offset: 0xD03A0 VA: 0x1800D0FA0
	[BaseEntity.Menu.Icon] // RVA: 0xD0FA0 Offset: 0xD03A0 VA: 0x1800D0FA0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD0FA0 Offset: 0xD03A0 VA: 0x1800D0FA0
	// RVA: 0x702DA0 Offset: 0x7013A0 VA: 0x180702DA0
	public void Menu_Play(BasePlayer player) { }

	// RVA: 0x702CF0 Offset: 0x7012F0 VA: 0x180702CF0
	public bool Menu_Play_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	[BaseEntity.Menu.Description] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	[BaseEntity.Menu.Icon] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	[BaseEntity.Menu.ShowIf] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	// RVA: 0x702CB0 Offset: 0x7012B0 VA: 0x180702CB0
	public void Menu_Open(BasePlayer player) { }

	// RVA: 0x702B10 Offset: 0x701110 VA: 0x180702B10
	public bool Menu_Open_ShowIf(BasePlayer player) { }

	// RVA: 0x704110 Offset: 0x702710 VA: 0x180704110
	public void PlayerClosedUI(BasePlayer player) { }

	// RVA: 0x701EE0 Offset: 0x7004E0 VA: 0x180701EE0
	private void DelayedViewModelDeploy(float timeDelay) { }

	// RVA: 0x701F80 Offset: 0x700580 VA: 0x180701F80
	private void DeployViewModel() { }

	// RVA: 0x702960 Offset: 0x700F60 VA: 0x180702960
	private void HolsterViewmodel() { }

	// RVA: 0x7046A0 Offset: 0x702CA0 VA: 0x1807046A0
	public bool RefreshPlayerCards() { }

	// RVA: 0x7047F0 Offset: 0x702DF0 VA: 0x1807047F0
	private void RefreshTableVisuals(List<PlayingCard> cards, int scrap) { }

	// RVA: 0x7020E0 Offset: 0x7006E0 VA: 0x1807020E0
	private static Sprite GetImage(int cardIndex) { }

	// RVA: 0x704AD0 Offset: 0x7030D0 VA: 0x180704AD0
	private void ShowStack(CardTable.ChipStack stack, ref int remainingScrap) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x704010 Offset: 0x702610 VA: 0x180704010
	private void OnWinnersDeclared(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x704150 Offset: 0x702750 VA: 0x180704150
	private void ReceiveCardsForPlayer(BaseEntity.RPCMessage msg) { }

	// RVA: 0x701C60 Offset: 0x700260 VA: 0x180701C60
	public void ClientInput(int inputType, int inputValue = 0) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x701E20 Offset: 0x700420 VA: 0x180701E20
	private void ClientPlaySound(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x701E80 Offset: 0x700480 VA: 0x180701E80
	private void ClientStartTurnTimer(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x701CD0 Offset: 0x7002D0 VA: 0x180701CD0
	private void ClientOnPlayerLeft(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7019C0 Offset: 0x6FFFC0 VA: 0x1807019C0
	private void ClearRecentlyLeftPlayer() { }

	// RVA: 0x704F90 Offset: 0x703590 VA: 0x180704F90
	public int get_ScrapItemID() { }

	// RVA: 0x704D10 Offset: 0x703310 VA: 0x180704D10
	public CardGameController get_GameController() { }

	// RVA: 0x702000 Offset: 0x700600 VA: 0x180702000 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x702080 Offset: 0x700680 VA: 0x180702080
	private CardGameController GetGameController() { }

	// RVA: 0x702A40 Offset: 0x701040 VA: 0x180702A40 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x704D00 Offset: 0x703300 VA: 0x180704D00
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

public class CardTable.ChipStack : IComparable<CardTable.ChipStack> // TypeDefIndex: 8368
{	// Fields
	public int chipValue; // 0x10
	public GameObject[] chips; // 0x18

	// Methods

	// RVA: 0x705000 Offset: 0x703600 VA: 0x180705000 Slot: 4
	public int CompareTo(CardTable.ChipStack other) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public enum CardTable.CardGameOption // TypeDefIndex: 8369
{	// Fields
	public int value__; // 0x0
	public const CardTable.CardGameOption TexasHoldEm = 0;

}

public class CardTable.PlayerStorageInfo // TypeDefIndex: 8370
{	// Fields
	public Transform storagePos; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

