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

	// RVA: 0x1F7B930 Offset: 0x1F79F30 VA: 0x181F7B930
	public static void ResetToPool(CardTable instance) { }

	// RVA: 0x1F7BB80 Offset: 0x1F7A180 VA: 0x181F7BB80
	public void ResetToPool() { }

	// RVA: 0x1F7B4F0 Offset: 0x1F79AF0 VA: 0x181F7B4F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F79760 Offset: 0x1F77D60 VA: 0x181F79760
	public void CopyTo(CardTable instance) { }

	// RVA: 0x1F79AF0 Offset: 0x1F780F0 VA: 0x181F79AF0
	public CardTable Copy() { }

	// RVA: 0x1F7A8D0 Offset: 0x1F78ED0 VA: 0x181F7A8D0
	public static CardTable Deserialize(Stream stream) { }

	// RVA: 0x1F79B70 Offset: 0x1F78170 VA: 0x181F79B70
	public static CardTable DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F7A060 Offset: 0x1F78660 VA: 0x181F7A060
	public static CardTable DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F7B0D0 Offset: 0x1F796D0 VA: 0x181F7B0D0
	public static CardTable Deserialize(byte[] buffer) { }

	// RVA: 0x1F7B570 Offset: 0x1F79B70 VA: 0x181F7B570
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F7C7F0 Offset: 0x1F7ADF0 VA: 0x181F7C7F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F7C810 Offset: 0x1F7AE10 VA: 0x181F7C810 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CardTable previous) { }

	// RVA: 0x1F7B910 Offset: 0x1F79F10 VA: 0x181F7B910 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F7AC60 Offset: 0x1F79260 VA: 0x181F7AC60
	public static CardTable Deserialize(byte[] buffer, CardTable instance, bool isDelta = False) { }

	// RVA: 0x1F7A530 Offset: 0x1F78B30 VA: 0x181F7A530
	public static CardTable Deserialize(Stream stream, CardTable instance, bool isDelta) { }

	// RVA: 0x1F79BF0 Offset: 0x1F781F0 VA: 0x181F79BF0
	public static CardTable DeserializeLengthDelimited(Stream stream, CardTable instance, bool isDelta) { }

	// RVA: 0x1F7A0F0 Offset: 0x1F786F0 VA: 0x181F7A0F0
	public static CardTable DeserializeLength(Stream stream, int length, CardTable instance, bool isDelta) { }

	// RVA: 0x1F7BDD0 Offset: 0x1F7A3D0 VA: 0x181F7BDD0
	public static void SerializeDelta(Stream stream, CardTable instance, CardTable previous) { }

	// RVA: 0x1F7C420 Offset: 0x1F7AA20 VA: 0x181F7C420
	public static void Serialize(Stream stream, CardTable instance) { }

	// RVA: 0x1F7C7E0 Offset: 0x1F7ADE0 VA: 0x181F7C7E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F7C7F0 Offset: 0x1F7ADF0 VA: 0x181F7C7F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F7C310 Offset: 0x1F7A910 VA: 0x181F7C310
	public static byte[] SerializeToBytes(CardTable instance) { }

	// RVA: 0x1F7C260 Offset: 0x1F7A860 VA: 0x181F7C260
	public static void SerializeLengthDelimited(Stream stream, CardTable instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x1F78B80 Offset: 0x1F77180 VA: 0x181F78B80
	public static void ResetToPool(CardTable.CardPlayer instance) { }

	// RVA: 0x1F78CE0 Offset: 0x1F772E0 VA: 0x181F78CE0
	public void ResetToPool() { }

	// RVA: 0x1F78AC0 Offset: 0x1F770C0 VA: 0x181F78AC0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F77660 Offset: 0x1F75C60 VA: 0x181F77660
	public void CopyTo(CardTable.CardPlayer instance) { }

	// RVA: 0x1F777C0 Offset: 0x1F75DC0 VA: 0x181F777C0
	public CardTable.CardPlayer Copy() { }

	// RVA: 0x1F78630 Offset: 0x1F76C30 VA: 0x181F78630
	public static CardTable.CardPlayer Deserialize(Stream stream) { }

	// RVA: 0x1F77960 Offset: 0x1F75F60 VA: 0x181F77960
	public static CardTable.CardPlayer DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F77EC0 Offset: 0x1F764C0 VA: 0x181F77EC0
	public static CardTable.CardPlayer DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F78510 Offset: 0x1F76B10 VA: 0x181F78510
	public static CardTable.CardPlayer Deserialize(byte[] buffer) { }

	// RVA: 0x1F78B40 Offset: 0x1F77140 VA: 0x181F78B40
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F79720 Offset: 0x1F77D20 VA: 0x181F79720 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F79740 Offset: 0x1F77D40 VA: 0x181F79740 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CardTable.CardPlayer previous) { }

	// RVA: 0x1F78B60 Offset: 0x1F77160 VA: 0x181F78B60 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F78410 Offset: 0x1F76A10 VA: 0x181F78410
	public static CardTable.CardPlayer Deserialize(byte[] buffer, CardTable.CardPlayer instance, bool isDelta = False) { }

	// RVA: 0x1F786B0 Offset: 0x1F76CB0 VA: 0x181F786B0
	public static CardTable.CardPlayer Deserialize(Stream stream, CardTable.CardPlayer instance, bool isDelta) { }

	// RVA: 0x1F779E0 Offset: 0x1F75FE0 VA: 0x181F779E0
	public static CardTable.CardPlayer DeserializeLengthDelimited(Stream stream, CardTable.CardPlayer instance, bool isDelta) { }

	// RVA: 0x1F77F50 Offset: 0x1F76550 VA: 0x181F77F50
	public static CardTable.CardPlayer DeserializeLength(Stream stream, int length, CardTable.CardPlayer instance, bool isDelta) { }

	// RVA: 0x1F78E40 Offset: 0x1F77440 VA: 0x181F78E40
	public static void SerializeDelta(Stream stream, CardTable.CardPlayer instance, CardTable.CardPlayer previous) { }

	// RVA: 0x1F79440 Offset: 0x1F77A40 VA: 0x181F79440
	public static void Serialize(Stream stream, CardTable.CardPlayer instance) { }

	// RVA: 0x1F79710 Offset: 0x1F77D10 VA: 0x181F79710
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F79720 Offset: 0x1F77D20 VA: 0x181F79720
	public void ToProto(Stream stream) { }

	// RVA: 0x1F79330 Offset: 0x1F77930 VA: 0x181F79330
	public static byte[] SerializeToBytes(CardTable.CardPlayer instance) { }

	// RVA: 0x1F79280 Offset: 0x1F77880 VA: 0x181F79280
	public static void SerializeLengthDelimited(Stream stream, CardTable.CardPlayer instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x1F7F6E0 Offset: 0x1F7DCE0 VA: 0x181F7F6E0
	public static void ResetToPool(CardTable.TexasHoldEm instance) { }

	// RVA: 0x1F7F5E0 Offset: 0x1F7DBE0 VA: 0x181F7F5E0
	public void ResetToPool() { }

	// RVA: 0x1F7F2C0 Offset: 0x1F7D8C0 VA: 0x181F7F2C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F7DDD0 Offset: 0x1F7C3D0 VA: 0x181F7DDD0
	public void CopyTo(CardTable.TexasHoldEm instance) { }

	// RVA: 0x1F7DF00 Offset: 0x1F7C500 VA: 0x181F7DF00
	public CardTable.TexasHoldEm Copy() { }

	// RVA: 0x1F7E710 Offset: 0x1F7CD10 VA: 0x181F7E710
	public static CardTable.TexasHoldEm Deserialize(Stream stream) { }

	// RVA: 0x1F7E2D0 Offset: 0x1F7C8D0 VA: 0x181F7E2D0
	public static CardTable.TexasHoldEm DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F7E350 Offset: 0x1F7C950 VA: 0x181F7E350
	public static CardTable.TexasHoldEm DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F7ED00 Offset: 0x1F7D300 VA: 0x181F7ED00
	public static CardTable.TexasHoldEm Deserialize(byte[] buffer) { }

	// RVA: 0x1F7F340 Offset: 0x1F7D940 VA: 0x181F7F340
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F7FE10 Offset: 0x1F7E410 VA: 0x181F7FE10 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F7FE30 Offset: 0x1F7E430 VA: 0x181F7FE30 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CardTable.TexasHoldEm previous) { }

	// RVA: 0x1F7F5C0 Offset: 0x1F7DBC0 VA: 0x181F7F5C0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F7E9B0 Offset: 0x1F7CFB0 VA: 0x181F7E9B0
	public static CardTable.TexasHoldEm Deserialize(byte[] buffer, CardTable.TexasHoldEm instance, bool isDelta = False) { }

	// RVA: 0x1F7F040 Offset: 0x1F7D640 VA: 0x181F7F040
	public static CardTable.TexasHoldEm Deserialize(Stream stream, CardTable.TexasHoldEm instance, bool isDelta) { }

	// RVA: 0x1F7DF80 Offset: 0x1F7C580 VA: 0x181F7DF80
	public static CardTable.TexasHoldEm DeserializeLengthDelimited(Stream stream, CardTable.TexasHoldEm instance, bool isDelta) { }

	// RVA: 0x1F7E3E0 Offset: 0x1F7C9E0 VA: 0x181F7E3E0
	public static CardTable.TexasHoldEm DeserializeLength(Stream stream, int length, CardTable.TexasHoldEm instance, bool isDelta) { }

	// RVA: 0x1F7F7E0 Offset: 0x1F7DDE0 VA: 0x181F7F7E0
	public static void SerializeDelta(Stream stream, CardTable.TexasHoldEm instance, CardTable.TexasHoldEm previous) { }

	// RVA: 0x1F7FC10 Offset: 0x1F7E210 VA: 0x181F7FC10
	public static void Serialize(Stream stream, CardTable.TexasHoldEm instance) { }

	// RVA: 0x1F7FE00 Offset: 0x1F7E400 VA: 0x181F7FE00
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F7FE10 Offset: 0x1F7E410 VA: 0x181F7FE10
	public void ToProto(Stream stream) { }

	// RVA: 0x1F7FB00 Offset: 0x1F7E100 VA: 0x181F7FB00
	public static byte[] SerializeToBytes(CardTable.TexasHoldEm instance) { }

	// RVA: 0x1F7FA50 Offset: 0x1F7E050 VA: 0x181F7FA50
	public static void SerializeLengthDelimited(Stream stream, CardTable.TexasHoldEm instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class CardTable.WinnerBreakdown : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6410
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<CardTable.WinnerBreakdown.Winner> winners; // 0x18
	public int winningScore; // 0x20

	// Methods

	// RVA: 0x1F80F70 Offset: 0x1F7F570 VA: 0x181F80F70
	public static void ResetToPool(CardTable.WinnerBreakdown instance) { }

	// RVA: 0x1F81150 Offset: 0x1F7F750 VA: 0x181F81150
	public void ResetToPool() { }

	// RVA: 0x1F80EB0 Offset: 0x1F7F4B0 VA: 0x181F80EB0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F7FE50 Offset: 0x1F7E450 VA: 0x181F7FE50
	public void CopyTo(CardTable.WinnerBreakdown instance) { }

	// RVA: 0x1F7FF80 Offset: 0x1F7E580 VA: 0x181F7FF80
	public CardTable.WinnerBreakdown Copy() { }

	// RVA: 0x1F80910 Offset: 0x1F7EF10 VA: 0x181F80910
	public static CardTable.WinnerBreakdown Deserialize(Stream stream) { }

	// RVA: 0x1F80100 Offset: 0x1F7E700 VA: 0x181F80100
	public static CardTable.WinnerBreakdown DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F80420 Offset: 0x1F7EA20 VA: 0x181F80420
	public static CardTable.WinnerBreakdown DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F80B10 Offset: 0x1F7F110 VA: 0x181F80B10
	public static CardTable.WinnerBreakdown Deserialize(byte[] buffer) { }

	// RVA: 0x1F80F30 Offset: 0x1F7F530 VA: 0x181F80F30
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F81980 Offset: 0x1F7FF80 VA: 0x181F81980 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F819A0 Offset: 0x1F7FFA0 VA: 0x181F819A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CardTable.WinnerBreakdown previous) { }

	// RVA: 0x1F80F50 Offset: 0x1F7F550 VA: 0x181F80F50 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F80DB0 Offset: 0x1F7F3B0 VA: 0x181F80DB0
	public static CardTable.WinnerBreakdown Deserialize(byte[] buffer, CardTable.WinnerBreakdown instance, bool isDelta = False) { }

	// RVA: 0x1F80740 Offset: 0x1F7ED40 VA: 0x181F80740
	public static CardTable.WinnerBreakdown Deserialize(Stream stream, CardTable.WinnerBreakdown instance, bool isDelta) { }

	// RVA: 0x1F80180 Offset: 0x1F7E780 VA: 0x181F80180
	public static CardTable.WinnerBreakdown DeserializeLengthDelimited(Stream stream, CardTable.WinnerBreakdown instance, bool isDelta) { }

	// RVA: 0x1F804B0 Offset: 0x1F7EAB0 VA: 0x181F804B0
	public static CardTable.WinnerBreakdown DeserializeLength(Stream stream, int length, CardTable.WinnerBreakdown instance, bool isDelta) { }

	// RVA: 0x1F81330 Offset: 0x1F7F930 VA: 0x181F81330
	public static void SerializeDelta(Stream stream, CardTable.WinnerBreakdown instance, CardTable.WinnerBreakdown previous) { }

	// RVA: 0x1F81740 Offset: 0x1F7FD40 VA: 0x181F81740
	public static void Serialize(Stream stream, CardTable.WinnerBreakdown instance) { }

	// RVA: 0x1F81970 Offset: 0x1F7FF70 VA: 0x181F81970
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F81980 Offset: 0x1F7FF80 VA: 0x181F81980
	public void ToProto(Stream stream) { }

	// RVA: 0x1F81630 Offset: 0x1F7FC30 VA: 0x181F81630
	public static byte[] SerializeToBytes(CardTable.WinnerBreakdown instance) { }

	// RVA: 0x1F81580 Offset: 0x1F7FB80 VA: 0x181F81580
	public static void SerializeLengthDelimited(Stream stream, CardTable.WinnerBreakdown instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x20C0830 Offset: 0x20BEE30 VA: 0x1820C0830
	public static void ResetToPool(CardTable.WinnerBreakdown.Winner instance) { }

	// RVA: 0x20C07A0 Offset: 0x20BEDA0 VA: 0x1820C07A0
	public void ResetToPool() { }

	// RVA: 0x20C04C0 Offset: 0x20BEAC0 VA: 0x1820C04C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20BF540 Offset: 0x20BDB40 VA: 0x1820BF540
	public void CopyTo(CardTable.WinnerBreakdown.Winner instance) { }

	// RVA: 0x20BF570 Offset: 0x20BDB70 VA: 0x1820BF570
	public CardTable.WinnerBreakdown.Winner Copy() { }

	// RVA: 0x20C0120 Offset: 0x20BE720 VA: 0x1820C0120
	public static CardTable.WinnerBreakdown.Winner Deserialize(Stream stream) { }

	// RVA: 0x20BF870 Offset: 0x20BDE70 VA: 0x1820BF870
	public static CardTable.WinnerBreakdown.Winner DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20BFB50 Offset: 0x20BE150 VA: 0x1820BFB50
	public static CardTable.WinnerBreakdown.Winner DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20BFBE0 Offset: 0x20BE1E0 VA: 0x1820BFBE0
	public static CardTable.WinnerBreakdown.Winner Deserialize(byte[] buffer) { }

	// RVA: 0x20C05D0 Offset: 0x20BEBD0 VA: 0x1820C05D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20C0D70 Offset: 0x20BF370 VA: 0x1820C0D70 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20C0D90 Offset: 0x20BF390 VA: 0x1820C0D90 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CardTable.WinnerBreakdown.Winner previous) { }

	// RVA: 0x20C0780 Offset: 0x20BED80 VA: 0x1820C0780 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20BFE90 Offset: 0x20BE490 VA: 0x1820BFE90
	public static CardTable.WinnerBreakdown.Winner Deserialize(byte[] buffer, CardTable.WinnerBreakdown.Winner instance, bool isDelta = False) { }

	// RVA: 0x20C0310 Offset: 0x20BE910 VA: 0x1820C0310
	public static CardTable.WinnerBreakdown.Winner Deserialize(Stream stream, CardTable.WinnerBreakdown.Winner instance, bool isDelta) { }

	// RVA: 0x20BF5F0 Offset: 0x20BDBF0 VA: 0x1820BF5F0
	public static CardTable.WinnerBreakdown.Winner DeserializeLengthDelimited(Stream stream, CardTable.WinnerBreakdown.Winner instance, bool isDelta) { }

	// RVA: 0x20BF8F0 Offset: 0x20BDEF0 VA: 0x1820BF8F0
	public static CardTable.WinnerBreakdown.Winner DeserializeLength(Stream stream, int length, CardTable.WinnerBreakdown.Winner instance, bool isDelta) { }

	// RVA: 0x20C08C0 Offset: 0x20BEEC0 VA: 0x1820C08C0
	public static void SerializeDelta(Stream stream, CardTable.WinnerBreakdown.Winner instance, CardTable.WinnerBreakdown.Winner previous) { }

	// RVA: 0x20C0C40 Offset: 0x20BF240 VA: 0x1820C0C40
	public static void Serialize(Stream stream, CardTable.WinnerBreakdown.Winner instance) { }

	// RVA: 0x20C0D60 Offset: 0x20BF360 VA: 0x1820C0D60
	public byte[] ToProtoBytes() { }

	// RVA: 0x20C0D70 Offset: 0x20BF370 VA: 0x1820C0D70
	public void ToProto(Stream stream) { }

	// RVA: 0x20C0B30 Offset: 0x20BF130 VA: 0x1820C0B30
	public static byte[] SerializeToBytes(CardTable.WinnerBreakdown.Winner instance) { }

	// RVA: 0x20C0A80 Offset: 0x20BF080 VA: 0x1820C0A80
	public static void SerializeLengthDelimited(Stream stream, CardTable.WinnerBreakdown.Winner instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class CardTable.CardList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6412
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<int> cards; // 0x18

	// Methods

	// RVA: 0x1F76F90 Offset: 0x1F75590 VA: 0x181F76F90
	public static void ResetToPool(CardTable.CardList instance) { }

	// RVA: 0x1F76EB0 Offset: 0x1F754B0 VA: 0x181F76EB0
	public void ResetToPool() { }

	// RVA: 0x1F76D20 Offset: 0x1F75320 VA: 0x181F76D20 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F76030 Offset: 0x1F74630 VA: 0x181F76030
	public void CopyTo(CardTable.CardList instance) { }

	// RVA: 0x1F76150 Offset: 0x1F74750 VA: 0x181F76150
	public CardTable.CardList Copy() { }

	// RVA: 0x1F76B80 Offset: 0x1F75180 VA: 0x181F76B80
	public static CardTable.CardList Deserialize(Stream stream) { }

	// RVA: 0x1F76540 Offset: 0x1F74B40 VA: 0x181F76540
	public static CardTable.CardList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F76830 Offset: 0x1F74E30 VA: 0x181F76830
	public static CardTable.CardList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F76C00 Offset: 0x1F75200 VA: 0x181F76C00
	public static CardTable.CardList Deserialize(byte[] buffer) { }

	// RVA: 0x1F76E70 Offset: 0x1F75470 VA: 0x181F76E70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F774E0 Offset: 0x1F75AE0 VA: 0x181F774E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F77500 Offset: 0x1F75B00 VA: 0x181F77500 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CardTable.CardList previous) { }

	// RVA: 0x1F76E90 Offset: 0x1F75490 VA: 0x181F76E90 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F76A80 Offset: 0x1F75080 VA: 0x181F76A80
	public static CardTable.CardList Deserialize(byte[] buffer, CardTable.CardList instance, bool isDelta = False) { }

	// RVA: 0x1F768C0 Offset: 0x1F74EC0 VA: 0x181F768C0
	public static CardTable.CardList Deserialize(Stream stream, CardTable.CardList instance, bool isDelta) { }

	// RVA: 0x1F762B0 Offset: 0x1F748B0 VA: 0x181F762B0
	public static CardTable.CardList DeserializeLengthDelimited(Stream stream, CardTable.CardList instance, bool isDelta) { }

	// RVA: 0x1F765C0 Offset: 0x1F74BC0 VA: 0x181F765C0
	public static CardTable.CardList DeserializeLength(Stream stream, int length, CardTable.CardList instance, bool isDelta) { }

	// RVA: 0x1F77070 Offset: 0x1F75670 VA: 0x181F77070
	public static void SerializeDelta(Stream stream, CardTable.CardList instance, CardTable.CardList previous) { }

	// RVA: 0x1F77380 Offset: 0x1F75980 VA: 0x181F77380
	public static void Serialize(Stream stream, CardTable.CardList instance) { }

	// RVA: 0x1F774D0 Offset: 0x1F75AD0 VA: 0x181F774D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F774E0 Offset: 0x1F75AE0 VA: 0x181F774E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F77270 Offset: 0x1F75870 VA: 0x181F77270
	public static byte[] SerializeToBytes(CardTable.CardList instance) { }

	// RVA: 0x1F771C0 Offset: 0x1F757C0 VA: 0x181F771C0
	public static void SerializeLengthDelimited(Stream stream, CardTable.CardList instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x702120 Offset: 0x700720 VA: 0x180702120 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x704D00 Offset: 0x703300 VA: 0x180704D00 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x702D30 Offset: 0x701330 VA: 0x180702D30 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x704E50 Offset: 0x703450 VA: 0x180704E50
	public static bool get_LocalPlayerInCardsUI() { }

	// RVA: 0x704F00 Offset: 0x703500 VA: 0x180704F00
	public bool get_ShowTakeWinningsTip() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x704F30 Offset: 0x703530 VA: 0x180704F30
	public string get_recentlyLeftPlayerName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x704F40 Offset: 0x703540 VA: 0x180704F40
	private void set_recentlyLeftPlayerName(string value) { }

	// RVA: 0x701960 Offset: 0x6FFF60 VA: 0x180701960 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x704230 Offset: 0x702830 VA: 0x180704230
	public void RefreshLocalPlayer(CardPlayerData localPlayerData) { }

	// RVA: 0x704B60 Offset: 0x703160 VA: 0x180704B60
	public void UIClosed() { }

	// RVA: 0x702680 Offset: 0x700C80 VA: 0x180702680
	public CardTableUI.UIState GetUIGameState(CardPlayerData localPlayerData) { }

	// RVA: 0x701F90 Offset: 0x700590 VA: 0x180701F90
	public void GetAvailableInputs(CardPlayerData localPlayerData, List<CardTableUI.KeycodeWithAction> targetList) { }

	[BaseEntity.Menu] // RVA: 0xD0FA0 Offset: 0xD03A0 VA: 0x1800D0FA0
	[BaseEntity.Menu.Description] // RVA: 0xD0FA0 Offset: 0xD03A0 VA: 0x1800D0FA0
	[BaseEntity.Menu.Icon] // RVA: 0xD0FA0 Offset: 0xD03A0 VA: 0x1800D0FA0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD0FA0 Offset: 0xD03A0 VA: 0x1800D0FA0
	// RVA: 0x702CF0 Offset: 0x7012F0 VA: 0x180702CF0
	public void Menu_Play(BasePlayer player) { }

	// RVA: 0x702C40 Offset: 0x701240 VA: 0x180702C40
	public bool Menu_Play_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	[BaseEntity.Menu.Description] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	[BaseEntity.Menu.Icon] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	[BaseEntity.Menu.ShowIf] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	// RVA: 0x702C00 Offset: 0x701200 VA: 0x180702C00
	public void Menu_Open(BasePlayer player) { }

	// RVA: 0x702A60 Offset: 0x701060 VA: 0x180702A60
	public bool Menu_Open_ShowIf(BasePlayer player) { }

	// RVA: 0x704060 Offset: 0x702660 VA: 0x180704060
	public void PlayerClosedUI(BasePlayer player) { }

	// RVA: 0x701E30 Offset: 0x700430 VA: 0x180701E30
	private void DelayedViewModelDeploy(float timeDelay) { }

	// RVA: 0x701ED0 Offset: 0x7004D0 VA: 0x180701ED0
	private void DeployViewModel() { }

	// RVA: 0x7028B0 Offset: 0x700EB0 VA: 0x1807028B0
	private void HolsterViewmodel() { }

	// RVA: 0x7045F0 Offset: 0x702BF0 VA: 0x1807045F0
	public bool RefreshPlayerCards() { }

	// RVA: 0x704740 Offset: 0x702D40 VA: 0x180704740
	private void RefreshTableVisuals(List<PlayingCard> cards, int scrap) { }

	// RVA: 0x702030 Offset: 0x700630 VA: 0x180702030
	private static Sprite GetImage(int cardIndex) { }

	// RVA: 0x704A20 Offset: 0x703020 VA: 0x180704A20
	private void ShowStack(CardTable.ChipStack stack, ref int remainingScrap) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x703F60 Offset: 0x702560 VA: 0x180703F60
	private void OnWinnersDeclared(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7040A0 Offset: 0x7026A0 VA: 0x1807040A0
	private void ReceiveCardsForPlayer(BaseEntity.RPCMessage msg) { }

	// RVA: 0x701BB0 Offset: 0x7001B0 VA: 0x180701BB0
	public void ClientInput(int inputType, int inputValue = 0) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x701D70 Offset: 0x700370 VA: 0x180701D70
	private void ClientPlaySound(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x701DD0 Offset: 0x7003D0 VA: 0x180701DD0
	private void ClientStartTurnTimer(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x701C20 Offset: 0x700220 VA: 0x180701C20
	private void ClientOnPlayerLeft(BaseEntity.RPCMessage msg) { }

	// RVA: 0x701910 Offset: 0x6FFF10 VA: 0x180701910
	private void ClearRecentlyLeftPlayer() { }

	// RVA: 0x704EE0 Offset: 0x7034E0 VA: 0x180704EE0
	public int get_ScrapItemID() { }

	// RVA: 0x704C60 Offset: 0x703260 VA: 0x180704C60
	public CardGameController get_GameController() { }

	// RVA: 0x701F50 Offset: 0x700550 VA: 0x180701F50 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x701FD0 Offset: 0x7005D0 VA: 0x180701FD0
	private CardGameController GetGameController() { }

	// RVA: 0x702990 Offset: 0x700F90 VA: 0x180702990 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x704C50 Offset: 0x703250 VA: 0x180704C50
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

public class CardTable.ChipStack : IComparable<CardTable.ChipStack> // TypeDefIndex: 8368
{	// Fields
	public int chipValue; // 0x10
	public GameObject[] chips; // 0x18

	// Methods

	// RVA: 0x704F50 Offset: 0x703550 VA: 0x180704F50 Slot: 4
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

