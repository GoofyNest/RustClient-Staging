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

	// RVA: 0x1F7B010 Offset: 0x1F79610 VA: 0x181F7B010
	public static void ResetToPool(CardTable instance) { }

	// RVA: 0x1F7B260 Offset: 0x1F79860 VA: 0x181F7B260
	public void ResetToPool() { }

	// RVA: 0x1F7ABD0 Offset: 0x1F791D0 VA: 0x181F7ABD0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F78E40 Offset: 0x1F77440 VA: 0x181F78E40
	public void CopyTo(CardTable instance) { }

	// RVA: 0x1F791D0 Offset: 0x1F777D0 VA: 0x181F791D0
	public CardTable Copy() { }

	// RVA: 0x1F79FB0 Offset: 0x1F785B0 VA: 0x181F79FB0
	public static CardTable Deserialize(Stream stream) { }

	// RVA: 0x1F79250 Offset: 0x1F77850 VA: 0x181F79250
	public static CardTable DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F79740 Offset: 0x1F77D40 VA: 0x181F79740
	public static CardTable DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F7A7B0 Offset: 0x1F78DB0 VA: 0x181F7A7B0
	public static CardTable Deserialize(byte[] buffer) { }

	// RVA: 0x1F7AC50 Offset: 0x1F79250 VA: 0x181F7AC50
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F7BED0 Offset: 0x1F7A4D0 VA: 0x181F7BED0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F7BEF0 Offset: 0x1F7A4F0 VA: 0x181F7BEF0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CardTable previous) { }

	// RVA: 0x1F7AFF0 Offset: 0x1F795F0 VA: 0x181F7AFF0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F7A340 Offset: 0x1F78940 VA: 0x181F7A340
	public static CardTable Deserialize(byte[] buffer, CardTable instance, bool isDelta = False) { }

	// RVA: 0x1F79C10 Offset: 0x1F78210 VA: 0x181F79C10
	public static CardTable Deserialize(Stream stream, CardTable instance, bool isDelta) { }

	// RVA: 0x1F792D0 Offset: 0x1F778D0 VA: 0x181F792D0
	public static CardTable DeserializeLengthDelimited(Stream stream, CardTable instance, bool isDelta) { }

	// RVA: 0x1F797D0 Offset: 0x1F77DD0 VA: 0x181F797D0
	public static CardTable DeserializeLength(Stream stream, int length, CardTable instance, bool isDelta) { }

	// RVA: 0x1F7B4B0 Offset: 0x1F79AB0 VA: 0x181F7B4B0
	public static void SerializeDelta(Stream stream, CardTable instance, CardTable previous) { }

	// RVA: 0x1F7BB00 Offset: 0x1F7A100 VA: 0x181F7BB00
	public static void Serialize(Stream stream, CardTable instance) { }

	// RVA: 0x1F7BEC0 Offset: 0x1F7A4C0 VA: 0x181F7BEC0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F7BED0 Offset: 0x1F7A4D0 VA: 0x181F7BED0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F7B9F0 Offset: 0x1F79FF0 VA: 0x181F7B9F0
	public static byte[] SerializeToBytes(CardTable instance) { }

	// RVA: 0x1F7B940 Offset: 0x1F79F40 VA: 0x181F7B940
	public static void SerializeLengthDelimited(Stream stream, CardTable instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x1F78260 Offset: 0x1F76860 VA: 0x181F78260
	public static void ResetToPool(CardTable.CardPlayer instance) { }

	// RVA: 0x1F783C0 Offset: 0x1F769C0 VA: 0x181F783C0
	public void ResetToPool() { }

	// RVA: 0x1F781A0 Offset: 0x1F767A0 VA: 0x181F781A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F76D40 Offset: 0x1F75340 VA: 0x181F76D40
	public void CopyTo(CardTable.CardPlayer instance) { }

	// RVA: 0x1F76EA0 Offset: 0x1F754A0 VA: 0x181F76EA0
	public CardTable.CardPlayer Copy() { }

	// RVA: 0x1F77D10 Offset: 0x1F76310 VA: 0x181F77D10
	public static CardTable.CardPlayer Deserialize(Stream stream) { }

	// RVA: 0x1F77040 Offset: 0x1F75640 VA: 0x181F77040
	public static CardTable.CardPlayer DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F775A0 Offset: 0x1F75BA0 VA: 0x181F775A0
	public static CardTable.CardPlayer DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F77BF0 Offset: 0x1F761F0 VA: 0x181F77BF0
	public static CardTable.CardPlayer Deserialize(byte[] buffer) { }

	// RVA: 0x1F78220 Offset: 0x1F76820 VA: 0x181F78220
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F78E00 Offset: 0x1F77400 VA: 0x181F78E00 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F78E20 Offset: 0x1F77420 VA: 0x181F78E20 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CardTable.CardPlayer previous) { }

	// RVA: 0x1F78240 Offset: 0x1F76840 VA: 0x181F78240 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F77AF0 Offset: 0x1F760F0 VA: 0x181F77AF0
	public static CardTable.CardPlayer Deserialize(byte[] buffer, CardTable.CardPlayer instance, bool isDelta = False) { }

	// RVA: 0x1F77D90 Offset: 0x1F76390 VA: 0x181F77D90
	public static CardTable.CardPlayer Deserialize(Stream stream, CardTable.CardPlayer instance, bool isDelta) { }

	// RVA: 0x1F770C0 Offset: 0x1F756C0 VA: 0x181F770C0
	public static CardTable.CardPlayer DeserializeLengthDelimited(Stream stream, CardTable.CardPlayer instance, bool isDelta) { }

	// RVA: 0x1F77630 Offset: 0x1F75C30 VA: 0x181F77630
	public static CardTable.CardPlayer DeserializeLength(Stream stream, int length, CardTable.CardPlayer instance, bool isDelta) { }

	// RVA: 0x1F78520 Offset: 0x1F76B20 VA: 0x181F78520
	public static void SerializeDelta(Stream stream, CardTable.CardPlayer instance, CardTable.CardPlayer previous) { }

	// RVA: 0x1F78B20 Offset: 0x1F77120 VA: 0x181F78B20
	public static void Serialize(Stream stream, CardTable.CardPlayer instance) { }

	// RVA: 0x1F78DF0 Offset: 0x1F773F0 VA: 0x181F78DF0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F78E00 Offset: 0x1F77400 VA: 0x181F78E00
	public void ToProto(Stream stream) { }

	// RVA: 0x1F78A10 Offset: 0x1F77010 VA: 0x181F78A10
	public static byte[] SerializeToBytes(CardTable.CardPlayer instance) { }

	// RVA: 0x1F78960 Offset: 0x1F76F60 VA: 0x181F78960
	public static void SerializeLengthDelimited(Stream stream, CardTable.CardPlayer instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x1F7EDC0 Offset: 0x1F7D3C0 VA: 0x181F7EDC0
	public static void ResetToPool(CardTable.TexasHoldEm instance) { }

	// RVA: 0x1F7ECC0 Offset: 0x1F7D2C0 VA: 0x181F7ECC0
	public void ResetToPool() { }

	// RVA: 0x1F7E9A0 Offset: 0x1F7CFA0 VA: 0x181F7E9A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F7D4B0 Offset: 0x1F7BAB0 VA: 0x181F7D4B0
	public void CopyTo(CardTable.TexasHoldEm instance) { }

	// RVA: 0x1F7D5E0 Offset: 0x1F7BBE0 VA: 0x181F7D5E0
	public CardTable.TexasHoldEm Copy() { }

	// RVA: 0x1F7DDF0 Offset: 0x1F7C3F0 VA: 0x181F7DDF0
	public static CardTable.TexasHoldEm Deserialize(Stream stream) { }

	// RVA: 0x1F7D9B0 Offset: 0x1F7BFB0 VA: 0x181F7D9B0
	public static CardTable.TexasHoldEm DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F7DA30 Offset: 0x1F7C030 VA: 0x181F7DA30
	public static CardTable.TexasHoldEm DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F7E3E0 Offset: 0x1F7C9E0 VA: 0x181F7E3E0
	public static CardTable.TexasHoldEm Deserialize(byte[] buffer) { }

	// RVA: 0x1F7EA20 Offset: 0x1F7D020 VA: 0x181F7EA20
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F7F4F0 Offset: 0x1F7DAF0 VA: 0x181F7F4F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F7F510 Offset: 0x1F7DB10 VA: 0x181F7F510 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CardTable.TexasHoldEm previous) { }

	// RVA: 0x1F7ECA0 Offset: 0x1F7D2A0 VA: 0x181F7ECA0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F7E090 Offset: 0x1F7C690 VA: 0x181F7E090
	public static CardTable.TexasHoldEm Deserialize(byte[] buffer, CardTable.TexasHoldEm instance, bool isDelta = False) { }

	// RVA: 0x1F7E720 Offset: 0x1F7CD20 VA: 0x181F7E720
	public static CardTable.TexasHoldEm Deserialize(Stream stream, CardTable.TexasHoldEm instance, bool isDelta) { }

	// RVA: 0x1F7D660 Offset: 0x1F7BC60 VA: 0x181F7D660
	public static CardTable.TexasHoldEm DeserializeLengthDelimited(Stream stream, CardTable.TexasHoldEm instance, bool isDelta) { }

	// RVA: 0x1F7DAC0 Offset: 0x1F7C0C0 VA: 0x181F7DAC0
	public static CardTable.TexasHoldEm DeserializeLength(Stream stream, int length, CardTable.TexasHoldEm instance, bool isDelta) { }

	// RVA: 0x1F7EEC0 Offset: 0x1F7D4C0 VA: 0x181F7EEC0
	public static void SerializeDelta(Stream stream, CardTable.TexasHoldEm instance, CardTable.TexasHoldEm previous) { }

	// RVA: 0x1F7F2F0 Offset: 0x1F7D8F0 VA: 0x181F7F2F0
	public static void Serialize(Stream stream, CardTable.TexasHoldEm instance) { }

	// RVA: 0x1F7F4E0 Offset: 0x1F7DAE0 VA: 0x181F7F4E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F7F4F0 Offset: 0x1F7DAF0 VA: 0x181F7F4F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F7F1E0 Offset: 0x1F7D7E0 VA: 0x181F7F1E0
	public static byte[] SerializeToBytes(CardTable.TexasHoldEm instance) { }

	// RVA: 0x1F7F130 Offset: 0x1F7D730 VA: 0x181F7F130
	public static void SerializeLengthDelimited(Stream stream, CardTable.TexasHoldEm instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class CardTable.WinnerBreakdown : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6410
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<CardTable.WinnerBreakdown.Winner> winners; // 0x18
	public int winningScore; // 0x20

	// Methods

	// RVA: 0x1F80650 Offset: 0x1F7EC50 VA: 0x181F80650
	public static void ResetToPool(CardTable.WinnerBreakdown instance) { }

	// RVA: 0x1F80830 Offset: 0x1F7EE30 VA: 0x181F80830
	public void ResetToPool() { }

	// RVA: 0x1F80590 Offset: 0x1F7EB90 VA: 0x181F80590 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F7F530 Offset: 0x1F7DB30 VA: 0x181F7F530
	public void CopyTo(CardTable.WinnerBreakdown instance) { }

	// RVA: 0x1F7F660 Offset: 0x1F7DC60 VA: 0x181F7F660
	public CardTable.WinnerBreakdown Copy() { }

	// RVA: 0x1F7FFF0 Offset: 0x1F7E5F0 VA: 0x181F7FFF0
	public static CardTable.WinnerBreakdown Deserialize(Stream stream) { }

	// RVA: 0x1F7F7E0 Offset: 0x1F7DDE0 VA: 0x181F7F7E0
	public static CardTable.WinnerBreakdown DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F7FB00 Offset: 0x1F7E100 VA: 0x181F7FB00
	public static CardTable.WinnerBreakdown DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F801F0 Offset: 0x1F7E7F0 VA: 0x181F801F0
	public static CardTable.WinnerBreakdown Deserialize(byte[] buffer) { }

	// RVA: 0x1F80610 Offset: 0x1F7EC10 VA: 0x181F80610
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F81060 Offset: 0x1F7F660 VA: 0x181F81060 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F81080 Offset: 0x1F7F680 VA: 0x181F81080 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CardTable.WinnerBreakdown previous) { }

	// RVA: 0x1F80630 Offset: 0x1F7EC30 VA: 0x181F80630 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F80490 Offset: 0x1F7EA90 VA: 0x181F80490
	public static CardTable.WinnerBreakdown Deserialize(byte[] buffer, CardTable.WinnerBreakdown instance, bool isDelta = False) { }

	// RVA: 0x1F7FE20 Offset: 0x1F7E420 VA: 0x181F7FE20
	public static CardTable.WinnerBreakdown Deserialize(Stream stream, CardTable.WinnerBreakdown instance, bool isDelta) { }

	// RVA: 0x1F7F860 Offset: 0x1F7DE60 VA: 0x181F7F860
	public static CardTable.WinnerBreakdown DeserializeLengthDelimited(Stream stream, CardTable.WinnerBreakdown instance, bool isDelta) { }

	// RVA: 0x1F7FB90 Offset: 0x1F7E190 VA: 0x181F7FB90
	public static CardTable.WinnerBreakdown DeserializeLength(Stream stream, int length, CardTable.WinnerBreakdown instance, bool isDelta) { }

	// RVA: 0x1F80A10 Offset: 0x1F7F010 VA: 0x181F80A10
	public static void SerializeDelta(Stream stream, CardTable.WinnerBreakdown instance, CardTable.WinnerBreakdown previous) { }

	// RVA: 0x1F80E20 Offset: 0x1F7F420 VA: 0x181F80E20
	public static void Serialize(Stream stream, CardTable.WinnerBreakdown instance) { }

	// RVA: 0x1F81050 Offset: 0x1F7F650 VA: 0x181F81050
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F81060 Offset: 0x1F7F660 VA: 0x181F81060
	public void ToProto(Stream stream) { }

	// RVA: 0x1F80D10 Offset: 0x1F7F310 VA: 0x181F80D10
	public static byte[] SerializeToBytes(CardTable.WinnerBreakdown instance) { }

	// RVA: 0x1F80C60 Offset: 0x1F7F260 VA: 0x181F80C60
	public static void SerializeLengthDelimited(Stream stream, CardTable.WinnerBreakdown instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x20BFF10 Offset: 0x20BE510 VA: 0x1820BFF10
	public static void ResetToPool(CardTable.WinnerBreakdown.Winner instance) { }

	// RVA: 0x20BFE80 Offset: 0x20BE480 VA: 0x1820BFE80
	public void ResetToPool() { }

	// RVA: 0x20BFBA0 Offset: 0x20BE1A0 VA: 0x1820BFBA0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20BEC20 Offset: 0x20BD220 VA: 0x1820BEC20
	public void CopyTo(CardTable.WinnerBreakdown.Winner instance) { }

	// RVA: 0x20BEC50 Offset: 0x20BD250 VA: 0x1820BEC50
	public CardTable.WinnerBreakdown.Winner Copy() { }

	// RVA: 0x20BF800 Offset: 0x20BDE00 VA: 0x1820BF800
	public static CardTable.WinnerBreakdown.Winner Deserialize(Stream stream) { }

	// RVA: 0x20BEF50 Offset: 0x20BD550 VA: 0x1820BEF50
	public static CardTable.WinnerBreakdown.Winner DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20BF230 Offset: 0x20BD830 VA: 0x1820BF230
	public static CardTable.WinnerBreakdown.Winner DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20BF2C0 Offset: 0x20BD8C0 VA: 0x1820BF2C0
	public static CardTable.WinnerBreakdown.Winner Deserialize(byte[] buffer) { }

	// RVA: 0x20BFCB0 Offset: 0x20BE2B0 VA: 0x1820BFCB0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20C0450 Offset: 0x20BEA50 VA: 0x1820C0450 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20C0470 Offset: 0x20BEA70 VA: 0x1820C0470 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CardTable.WinnerBreakdown.Winner previous) { }

	// RVA: 0x20BFE60 Offset: 0x20BE460 VA: 0x1820BFE60 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20BF570 Offset: 0x20BDB70 VA: 0x1820BF570
	public static CardTable.WinnerBreakdown.Winner Deserialize(byte[] buffer, CardTable.WinnerBreakdown.Winner instance, bool isDelta = False) { }

	// RVA: 0x20BF9F0 Offset: 0x20BDFF0 VA: 0x1820BF9F0
	public static CardTable.WinnerBreakdown.Winner Deserialize(Stream stream, CardTable.WinnerBreakdown.Winner instance, bool isDelta) { }

	// RVA: 0x20BECD0 Offset: 0x20BD2D0 VA: 0x1820BECD0
	public static CardTable.WinnerBreakdown.Winner DeserializeLengthDelimited(Stream stream, CardTable.WinnerBreakdown.Winner instance, bool isDelta) { }

	// RVA: 0x20BEFD0 Offset: 0x20BD5D0 VA: 0x1820BEFD0
	public static CardTable.WinnerBreakdown.Winner DeserializeLength(Stream stream, int length, CardTable.WinnerBreakdown.Winner instance, bool isDelta) { }

	// RVA: 0x20BFFA0 Offset: 0x20BE5A0 VA: 0x1820BFFA0
	public static void SerializeDelta(Stream stream, CardTable.WinnerBreakdown.Winner instance, CardTable.WinnerBreakdown.Winner previous) { }

	// RVA: 0x20C0320 Offset: 0x20BE920 VA: 0x1820C0320
	public static void Serialize(Stream stream, CardTable.WinnerBreakdown.Winner instance) { }

	// RVA: 0x20C0440 Offset: 0x20BEA40 VA: 0x1820C0440
	public byte[] ToProtoBytes() { }

	// RVA: 0x20C0450 Offset: 0x20BEA50 VA: 0x1820C0450
	public void ToProto(Stream stream) { }

	// RVA: 0x20C0210 Offset: 0x20BE810 VA: 0x1820C0210
	public static byte[] SerializeToBytes(CardTable.WinnerBreakdown.Winner instance) { }

	// RVA: 0x20C0160 Offset: 0x20BE760 VA: 0x1820C0160
	public static void SerializeLengthDelimited(Stream stream, CardTable.WinnerBreakdown.Winner instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class CardTable.CardList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6412
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<int> cards; // 0x18

	// Methods

	// RVA: 0x1F76670 Offset: 0x1F74C70 VA: 0x181F76670
	public static void ResetToPool(CardTable.CardList instance) { }

	// RVA: 0x1F76590 Offset: 0x1F74B90 VA: 0x181F76590
	public void ResetToPool() { }

	// RVA: 0x1F76400 Offset: 0x1F74A00 VA: 0x181F76400 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F75710 Offset: 0x1F73D10 VA: 0x181F75710
	public void CopyTo(CardTable.CardList instance) { }

	// RVA: 0x1F75830 Offset: 0x1F73E30 VA: 0x181F75830
	public CardTable.CardList Copy() { }

	// RVA: 0x1F76260 Offset: 0x1F74860 VA: 0x181F76260
	public static CardTable.CardList Deserialize(Stream stream) { }

	// RVA: 0x1F75C20 Offset: 0x1F74220 VA: 0x181F75C20
	public static CardTable.CardList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F75F10 Offset: 0x1F74510 VA: 0x181F75F10
	public static CardTable.CardList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F762E0 Offset: 0x1F748E0 VA: 0x181F762E0
	public static CardTable.CardList Deserialize(byte[] buffer) { }

	// RVA: 0x1F76550 Offset: 0x1F74B50 VA: 0x181F76550
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F76BC0 Offset: 0x1F751C0 VA: 0x181F76BC0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F76BE0 Offset: 0x1F751E0 VA: 0x181F76BE0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CardTable.CardList previous) { }

	// RVA: 0x1F76570 Offset: 0x1F74B70 VA: 0x181F76570 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F76160 Offset: 0x1F74760 VA: 0x181F76160
	public static CardTable.CardList Deserialize(byte[] buffer, CardTable.CardList instance, bool isDelta = False) { }

	// RVA: 0x1F75FA0 Offset: 0x1F745A0 VA: 0x181F75FA0
	public static CardTable.CardList Deserialize(Stream stream, CardTable.CardList instance, bool isDelta) { }

	// RVA: 0x1F75990 Offset: 0x1F73F90 VA: 0x181F75990
	public static CardTable.CardList DeserializeLengthDelimited(Stream stream, CardTable.CardList instance, bool isDelta) { }

	// RVA: 0x1F75CA0 Offset: 0x1F742A0 VA: 0x181F75CA0
	public static CardTable.CardList DeserializeLength(Stream stream, int length, CardTable.CardList instance, bool isDelta) { }

	// RVA: 0x1F76750 Offset: 0x1F74D50 VA: 0x181F76750
	public static void SerializeDelta(Stream stream, CardTable.CardList instance, CardTable.CardList previous) { }

	// RVA: 0x1F76A60 Offset: 0x1F75060 VA: 0x181F76A60
	public static void Serialize(Stream stream, CardTable.CardList instance) { }

	// RVA: 0x1F76BB0 Offset: 0x1F751B0 VA: 0x181F76BB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F76BC0 Offset: 0x1F751C0 VA: 0x181F76BC0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F76950 Offset: 0x1F74F50 VA: 0x181F76950
	public static byte[] SerializeToBytes(CardTable.CardList instance) { }

	// RVA: 0x1F768A0 Offset: 0x1F74EA0 VA: 0x181F768A0
	public static void SerializeLengthDelimited(Stream stream, CardTable.CardList instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private string <recentlyLeftPlayerName>k__BackingField; // 0x478
	[HeaderAttribute] // RVA: 0x80FD0 Offset: 0x803D0 VA: 0x180080FD0
	[SerializeField] // RVA: 0x80FD0 Offset: 0x803D0 VA: 0x180080FD0
	private GameObjectRef uiPrefab; // 0x480
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GameObjectRef playerStoragePrefab; // 0x488
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GameObjectRef potPrefab; // 0x490
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ViewModel viewModel; // 0x498
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private CardTableUI.PlayingCardImage[] tableCards; // 0x4A0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Renderer[] tableCardBackings; // 0x4A8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Canvas cardUICanvas; // 0x4B0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Image[] tableCardImages; // 0x4B8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Sprite blankCard; // 0x4C0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform chipStacksParent; // 0x4C8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private CardTable.ChipStack[] chipStacks; // 0x4D0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x7020C0 Offset: 0x7006C0 VA: 0x1807020C0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x704CA0 Offset: 0x7032A0 VA: 0x180704CA0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x702CD0 Offset: 0x7012D0 VA: 0x180702CD0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x704DF0 Offset: 0x7033F0 VA: 0x180704DF0
	public static bool get_LocalPlayerInCardsUI() { }

	// RVA: 0x704EA0 Offset: 0x7034A0 VA: 0x180704EA0
	public bool get_ShowTakeWinningsTip() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x704ED0 Offset: 0x7034D0 VA: 0x180704ED0
	public string get_recentlyLeftPlayerName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x704EE0 Offset: 0x7034E0 VA: 0x180704EE0
	private void set_recentlyLeftPlayerName(string value) { }

	// RVA: 0x701900 Offset: 0x6FFF00 VA: 0x180701900 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x7041D0 Offset: 0x7027D0 VA: 0x1807041D0
	public void RefreshLocalPlayer(CardPlayerData localPlayerData) { }

	// RVA: 0x704B00 Offset: 0x703100 VA: 0x180704B00
	public void UIClosed() { }

	// RVA: 0x702620 Offset: 0x700C20 VA: 0x180702620
	public CardTableUI.UIState GetUIGameState(CardPlayerData localPlayerData) { }

	// RVA: 0x701F30 Offset: 0x700530 VA: 0x180701F30
	public void GetAvailableInputs(CardPlayerData localPlayerData, List<CardTableUI.KeycodeWithAction> targetList) { }

	[BaseEntity.Menu] // RVA: 0xD0F10 Offset: 0xD0310 VA: 0x1800D0F10
	[BaseEntity.Menu.Description] // RVA: 0xD0F10 Offset: 0xD0310 VA: 0x1800D0F10
	[BaseEntity.Menu.Icon] // RVA: 0xD0F10 Offset: 0xD0310 VA: 0x1800D0F10
	[BaseEntity.Menu.ShowIf] // RVA: 0xD0F10 Offset: 0xD0310 VA: 0x1800D0F10
	// RVA: 0x702C90 Offset: 0x701290 VA: 0x180702C90
	public void Menu_Play(BasePlayer player) { }

	// RVA: 0x702BE0 Offset: 0x7011E0 VA: 0x180702BE0
	public bool Menu_Play_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8E020 Offset: 0x8D420 VA: 0x18008E020
	[BaseEntity.Menu.Description] // RVA: 0x8E020 Offset: 0x8D420 VA: 0x18008E020
	[BaseEntity.Menu.Icon] // RVA: 0x8E020 Offset: 0x8D420 VA: 0x18008E020
	[BaseEntity.Menu.ShowIf] // RVA: 0x8E020 Offset: 0x8D420 VA: 0x18008E020
	// RVA: 0x702BA0 Offset: 0x7011A0 VA: 0x180702BA0
	public void Menu_Open(BasePlayer player) { }

	// RVA: 0x702A00 Offset: 0x701000 VA: 0x180702A00
	public bool Menu_Open_ShowIf(BasePlayer player) { }

	// RVA: 0x704000 Offset: 0x702600 VA: 0x180704000
	public void PlayerClosedUI(BasePlayer player) { }

	// RVA: 0x701DD0 Offset: 0x7003D0 VA: 0x180701DD0
	private void DelayedViewModelDeploy(float timeDelay) { }

	// RVA: 0x701E70 Offset: 0x700470 VA: 0x180701E70
	private void DeployViewModel() { }

	// RVA: 0x702850 Offset: 0x700E50 VA: 0x180702850
	private void HolsterViewmodel() { }

	// RVA: 0x704590 Offset: 0x702B90 VA: 0x180704590
	public bool RefreshPlayerCards() { }

	// RVA: 0x7046E0 Offset: 0x702CE0 VA: 0x1807046E0
	private void RefreshTableVisuals(List<PlayingCard> cards, int scrap) { }

	// RVA: 0x701FD0 Offset: 0x7005D0 VA: 0x180701FD0
	private static Sprite GetImage(int cardIndex) { }

	// RVA: 0x7049C0 Offset: 0x702FC0 VA: 0x1807049C0
	private void ShowStack(CardTable.ChipStack stack, ref int remainingScrap) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x703F00 Offset: 0x702500 VA: 0x180703F00
	private void OnWinnersDeclared(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x704040 Offset: 0x702640 VA: 0x180704040
	private void ReceiveCardsForPlayer(BaseEntity.RPCMessage msg) { }

	// RVA: 0x701B50 Offset: 0x700150 VA: 0x180701B50
	public void ClientInput(int inputType, int inputValue = 0) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x701D10 Offset: 0x700310 VA: 0x180701D10
	private void ClientPlaySound(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x701D70 Offset: 0x700370 VA: 0x180701D70
	private void ClientStartTurnTimer(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x701BC0 Offset: 0x7001C0 VA: 0x180701BC0
	private void ClientOnPlayerLeft(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7018B0 Offset: 0x6FFEB0 VA: 0x1807018B0
	private void ClearRecentlyLeftPlayer() { }

	// RVA: 0x704E80 Offset: 0x703480 VA: 0x180704E80
	public int get_ScrapItemID() { }

	// RVA: 0x704C00 Offset: 0x703200 VA: 0x180704C00
	public CardGameController get_GameController() { }

	// RVA: 0x701EF0 Offset: 0x7004F0 VA: 0x180701EF0 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x701F70 Offset: 0x700570 VA: 0x180701F70
	private CardGameController GetGameController() { }

	// RVA: 0x702930 Offset: 0x700F30 VA: 0x180702930 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x704BF0 Offset: 0x7031F0 VA: 0x180704BF0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

public class CardTable.ChipStack : IComparable<CardTable.ChipStack> // TypeDefIndex: 8368
{	// Fields
	public int chipValue; // 0x10
	public GameObject[] chips; // 0x18

	// Methods

	// RVA: 0x704EF0 Offset: 0x7034F0 VA: 0x180704EF0 Slot: 4
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

