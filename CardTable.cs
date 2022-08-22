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

	// RVA: 0x1F7AE50 Offset: 0x1F79450 VA: 0x181F7AE50
	public static void ResetToPool(CardTable instance) { }

	// RVA: 0x1F7B0A0 Offset: 0x1F796A0 VA: 0x181F7B0A0
	public void ResetToPool() { }

	// RVA: 0x1F7AA10 Offset: 0x1F79010 VA: 0x181F7AA10 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F78C80 Offset: 0x1F77280 VA: 0x181F78C80
	public void CopyTo(CardTable instance) { }

	// RVA: 0x1F79010 Offset: 0x1F77610 VA: 0x181F79010
	public CardTable Copy() { }

	// RVA: 0x1F79DF0 Offset: 0x1F783F0 VA: 0x181F79DF0
	public static CardTable Deserialize(Stream stream) { }

	// RVA: 0x1F79090 Offset: 0x1F77690 VA: 0x181F79090
	public static CardTable DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F79580 Offset: 0x1F77B80 VA: 0x181F79580
	public static CardTable DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F7A5F0 Offset: 0x1F78BF0 VA: 0x181F7A5F0
	public static CardTable Deserialize(byte[] buffer) { }

	// RVA: 0x1F7AA90 Offset: 0x1F79090 VA: 0x181F7AA90
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F7BD10 Offset: 0x1F7A310 VA: 0x181F7BD10 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F7BD30 Offset: 0x1F7A330 VA: 0x181F7BD30 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CardTable previous) { }

	// RVA: 0x1F7AE30 Offset: 0x1F79430 VA: 0x181F7AE30 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F7A180 Offset: 0x1F78780 VA: 0x181F7A180
	public static CardTable Deserialize(byte[] buffer, CardTable instance, bool isDelta = False) { }

	// RVA: 0x1F79A50 Offset: 0x1F78050 VA: 0x181F79A50
	public static CardTable Deserialize(Stream stream, CardTable instance, bool isDelta) { }

	// RVA: 0x1F79110 Offset: 0x1F77710 VA: 0x181F79110
	public static CardTable DeserializeLengthDelimited(Stream stream, CardTable instance, bool isDelta) { }

	// RVA: 0x1F79610 Offset: 0x1F77C10 VA: 0x181F79610
	public static CardTable DeserializeLength(Stream stream, int length, CardTable instance, bool isDelta) { }

	// RVA: 0x1F7B2F0 Offset: 0x1F798F0 VA: 0x181F7B2F0
	public static void SerializeDelta(Stream stream, CardTable instance, CardTable previous) { }

	// RVA: 0x1F7B940 Offset: 0x1F79F40 VA: 0x181F7B940
	public static void Serialize(Stream stream, CardTable instance) { }

	// RVA: 0x1F7BD00 Offset: 0x1F7A300 VA: 0x181F7BD00
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F7BD10 Offset: 0x1F7A310 VA: 0x181F7BD10
	public void ToProto(Stream stream) { }

	// RVA: 0x1F7B830 Offset: 0x1F79E30 VA: 0x181F7B830
	public static byte[] SerializeToBytes(CardTable instance) { }

	// RVA: 0x1F7B780 Offset: 0x1F79D80 VA: 0x181F7B780
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

	// RVA: 0x1F780A0 Offset: 0x1F766A0 VA: 0x181F780A0
	public static void ResetToPool(CardTable.CardPlayer instance) { }

	// RVA: 0x1F78200 Offset: 0x1F76800 VA: 0x181F78200
	public void ResetToPool() { }

	// RVA: 0x1F77FE0 Offset: 0x1F765E0 VA: 0x181F77FE0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F76B80 Offset: 0x1F75180 VA: 0x181F76B80
	public void CopyTo(CardTable.CardPlayer instance) { }

	// RVA: 0x1F76CE0 Offset: 0x1F752E0 VA: 0x181F76CE0
	public CardTable.CardPlayer Copy() { }

	// RVA: 0x1F77B50 Offset: 0x1F76150 VA: 0x181F77B50
	public static CardTable.CardPlayer Deserialize(Stream stream) { }

	// RVA: 0x1F76E80 Offset: 0x1F75480 VA: 0x181F76E80
	public static CardTable.CardPlayer DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F773E0 Offset: 0x1F759E0 VA: 0x181F773E0
	public static CardTable.CardPlayer DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F77A30 Offset: 0x1F76030 VA: 0x181F77A30
	public static CardTable.CardPlayer Deserialize(byte[] buffer) { }

	// RVA: 0x1F78060 Offset: 0x1F76660 VA: 0x181F78060
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F78C40 Offset: 0x1F77240 VA: 0x181F78C40 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F78C60 Offset: 0x1F77260 VA: 0x181F78C60 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CardTable.CardPlayer previous) { }

	// RVA: 0x1F78080 Offset: 0x1F76680 VA: 0x181F78080 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F77930 Offset: 0x1F75F30 VA: 0x181F77930
	public static CardTable.CardPlayer Deserialize(byte[] buffer, CardTable.CardPlayer instance, bool isDelta = False) { }

	// RVA: 0x1F77BD0 Offset: 0x1F761D0 VA: 0x181F77BD0
	public static CardTable.CardPlayer Deserialize(Stream stream, CardTable.CardPlayer instance, bool isDelta) { }

	// RVA: 0x1F76F00 Offset: 0x1F75500 VA: 0x181F76F00
	public static CardTable.CardPlayer DeserializeLengthDelimited(Stream stream, CardTable.CardPlayer instance, bool isDelta) { }

	// RVA: 0x1F77470 Offset: 0x1F75A70 VA: 0x181F77470
	public static CardTable.CardPlayer DeserializeLength(Stream stream, int length, CardTable.CardPlayer instance, bool isDelta) { }

	// RVA: 0x1F78360 Offset: 0x1F76960 VA: 0x181F78360
	public static void SerializeDelta(Stream stream, CardTable.CardPlayer instance, CardTable.CardPlayer previous) { }

	// RVA: 0x1F78960 Offset: 0x1F76F60 VA: 0x181F78960
	public static void Serialize(Stream stream, CardTable.CardPlayer instance) { }

	// RVA: 0x1F78C30 Offset: 0x1F77230 VA: 0x181F78C30
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F78C40 Offset: 0x1F77240 VA: 0x181F78C40
	public void ToProto(Stream stream) { }

	// RVA: 0x1F78850 Offset: 0x1F76E50 VA: 0x181F78850
	public static byte[] SerializeToBytes(CardTable.CardPlayer instance) { }

	// RVA: 0x1F787A0 Offset: 0x1F76DA0 VA: 0x181F787A0
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

	// RVA: 0x1F7EC00 Offset: 0x1F7D200 VA: 0x181F7EC00
	public static void ResetToPool(CardTable.TexasHoldEm instance) { }

	// RVA: 0x1F7EB00 Offset: 0x1F7D100 VA: 0x181F7EB00
	public void ResetToPool() { }

	// RVA: 0x1F7E7E0 Offset: 0x1F7CDE0 VA: 0x181F7E7E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F7D2F0 Offset: 0x1F7B8F0 VA: 0x181F7D2F0
	public void CopyTo(CardTable.TexasHoldEm instance) { }

	// RVA: 0x1F7D420 Offset: 0x1F7BA20 VA: 0x181F7D420
	public CardTable.TexasHoldEm Copy() { }

	// RVA: 0x1F7DC30 Offset: 0x1F7C230 VA: 0x181F7DC30
	public static CardTable.TexasHoldEm Deserialize(Stream stream) { }

	// RVA: 0x1F7D7F0 Offset: 0x1F7BDF0 VA: 0x181F7D7F0
	public static CardTable.TexasHoldEm DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F7D870 Offset: 0x1F7BE70 VA: 0x181F7D870
	public static CardTable.TexasHoldEm DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F7E220 Offset: 0x1F7C820 VA: 0x181F7E220
	public static CardTable.TexasHoldEm Deserialize(byte[] buffer) { }

	// RVA: 0x1F7E860 Offset: 0x1F7CE60 VA: 0x181F7E860
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F7F330 Offset: 0x1F7D930 VA: 0x181F7F330 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F7F350 Offset: 0x1F7D950 VA: 0x181F7F350 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CardTable.TexasHoldEm previous) { }

	// RVA: 0x1F7EAE0 Offset: 0x1F7D0E0 VA: 0x181F7EAE0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F7DED0 Offset: 0x1F7C4D0 VA: 0x181F7DED0
	public static CardTable.TexasHoldEm Deserialize(byte[] buffer, CardTable.TexasHoldEm instance, bool isDelta = False) { }

	// RVA: 0x1F7E560 Offset: 0x1F7CB60 VA: 0x181F7E560
	public static CardTable.TexasHoldEm Deserialize(Stream stream, CardTable.TexasHoldEm instance, bool isDelta) { }

	// RVA: 0x1F7D4A0 Offset: 0x1F7BAA0 VA: 0x181F7D4A0
	public static CardTable.TexasHoldEm DeserializeLengthDelimited(Stream stream, CardTable.TexasHoldEm instance, bool isDelta) { }

	// RVA: 0x1F7D900 Offset: 0x1F7BF00 VA: 0x181F7D900
	public static CardTable.TexasHoldEm DeserializeLength(Stream stream, int length, CardTable.TexasHoldEm instance, bool isDelta) { }

	// RVA: 0x1F7ED00 Offset: 0x1F7D300 VA: 0x181F7ED00
	public static void SerializeDelta(Stream stream, CardTable.TexasHoldEm instance, CardTable.TexasHoldEm previous) { }

	// RVA: 0x1F7F130 Offset: 0x1F7D730 VA: 0x181F7F130
	public static void Serialize(Stream stream, CardTable.TexasHoldEm instance) { }

	// RVA: 0x1F7F320 Offset: 0x1F7D920 VA: 0x181F7F320
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F7F330 Offset: 0x1F7D930 VA: 0x181F7F330
	public void ToProto(Stream stream) { }

	// RVA: 0x1F7F020 Offset: 0x1F7D620 VA: 0x181F7F020
	public static byte[] SerializeToBytes(CardTable.TexasHoldEm instance) { }

	// RVA: 0x1F7EF70 Offset: 0x1F7D570 VA: 0x181F7EF70
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

	// RVA: 0x1F80490 Offset: 0x1F7EA90 VA: 0x181F80490
	public static void ResetToPool(CardTable.WinnerBreakdown instance) { }

	// RVA: 0x1F80670 Offset: 0x1F7EC70 VA: 0x181F80670
	public void ResetToPool() { }

	// RVA: 0x1F803D0 Offset: 0x1F7E9D0 VA: 0x181F803D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F7F370 Offset: 0x1F7D970 VA: 0x181F7F370
	public void CopyTo(CardTable.WinnerBreakdown instance) { }

	// RVA: 0x1F7F4A0 Offset: 0x1F7DAA0 VA: 0x181F7F4A0
	public CardTable.WinnerBreakdown Copy() { }

	// RVA: 0x1F7FE30 Offset: 0x1F7E430 VA: 0x181F7FE30
	public static CardTable.WinnerBreakdown Deserialize(Stream stream) { }

	// RVA: 0x1F7F620 Offset: 0x1F7DC20 VA: 0x181F7F620
	public static CardTable.WinnerBreakdown DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F7F940 Offset: 0x1F7DF40 VA: 0x181F7F940
	public static CardTable.WinnerBreakdown DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F80030 Offset: 0x1F7E630 VA: 0x181F80030
	public static CardTable.WinnerBreakdown Deserialize(byte[] buffer) { }

	// RVA: 0x1F80450 Offset: 0x1F7EA50 VA: 0x181F80450
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F80EA0 Offset: 0x1F7F4A0 VA: 0x181F80EA0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F80EC0 Offset: 0x1F7F4C0 VA: 0x181F80EC0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CardTable.WinnerBreakdown previous) { }

	// RVA: 0x1F80470 Offset: 0x1F7EA70 VA: 0x181F80470 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F802D0 Offset: 0x1F7E8D0 VA: 0x181F802D0
	public static CardTable.WinnerBreakdown Deserialize(byte[] buffer, CardTable.WinnerBreakdown instance, bool isDelta = False) { }

	// RVA: 0x1F7FC60 Offset: 0x1F7E260 VA: 0x181F7FC60
	public static CardTable.WinnerBreakdown Deserialize(Stream stream, CardTable.WinnerBreakdown instance, bool isDelta) { }

	// RVA: 0x1F7F6A0 Offset: 0x1F7DCA0 VA: 0x181F7F6A0
	public static CardTable.WinnerBreakdown DeserializeLengthDelimited(Stream stream, CardTable.WinnerBreakdown instance, bool isDelta) { }

	// RVA: 0x1F7F9D0 Offset: 0x1F7DFD0 VA: 0x181F7F9D0
	public static CardTable.WinnerBreakdown DeserializeLength(Stream stream, int length, CardTable.WinnerBreakdown instance, bool isDelta) { }

	// RVA: 0x1F80850 Offset: 0x1F7EE50 VA: 0x181F80850
	public static void SerializeDelta(Stream stream, CardTable.WinnerBreakdown instance, CardTable.WinnerBreakdown previous) { }

	// RVA: 0x1F80C60 Offset: 0x1F7F260 VA: 0x181F80C60
	public static void Serialize(Stream stream, CardTable.WinnerBreakdown instance) { }

	// RVA: 0x1F80E90 Offset: 0x1F7F490 VA: 0x181F80E90
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F80EA0 Offset: 0x1F7F4A0 VA: 0x181F80EA0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F80B50 Offset: 0x1F7F150 VA: 0x181F80B50
	public static byte[] SerializeToBytes(CardTable.WinnerBreakdown instance) { }

	// RVA: 0x1F80AA0 Offset: 0x1F7F0A0 VA: 0x181F80AA0
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

	// RVA: 0x20BFD50 Offset: 0x20BE350 VA: 0x1820BFD50
	public static void ResetToPool(CardTable.WinnerBreakdown.Winner instance) { }

	// RVA: 0x20BFCC0 Offset: 0x20BE2C0 VA: 0x1820BFCC0
	public void ResetToPool() { }

	// RVA: 0x20BF9E0 Offset: 0x20BDFE0 VA: 0x1820BF9E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20BEA60 Offset: 0x20BD060 VA: 0x1820BEA60
	public void CopyTo(CardTable.WinnerBreakdown.Winner instance) { }

	// RVA: 0x20BEA90 Offset: 0x20BD090 VA: 0x1820BEA90
	public CardTable.WinnerBreakdown.Winner Copy() { }

	// RVA: 0x20BF640 Offset: 0x20BDC40 VA: 0x1820BF640
	public static CardTable.WinnerBreakdown.Winner Deserialize(Stream stream) { }

	// RVA: 0x20BED90 Offset: 0x20BD390 VA: 0x1820BED90
	public static CardTable.WinnerBreakdown.Winner DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20BF070 Offset: 0x20BD670 VA: 0x1820BF070
	public static CardTable.WinnerBreakdown.Winner DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20BF100 Offset: 0x20BD700 VA: 0x1820BF100
	public static CardTable.WinnerBreakdown.Winner Deserialize(byte[] buffer) { }

	// RVA: 0x20BFAF0 Offset: 0x20BE0F0 VA: 0x1820BFAF0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20C0290 Offset: 0x20BE890 VA: 0x1820C0290 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20C02B0 Offset: 0x20BE8B0 VA: 0x1820C02B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CardTable.WinnerBreakdown.Winner previous) { }

	// RVA: 0x20BFCA0 Offset: 0x20BE2A0 VA: 0x1820BFCA0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20BF3B0 Offset: 0x20BD9B0 VA: 0x1820BF3B0
	public static CardTable.WinnerBreakdown.Winner Deserialize(byte[] buffer, CardTable.WinnerBreakdown.Winner instance, bool isDelta = False) { }

	// RVA: 0x20BF830 Offset: 0x20BDE30 VA: 0x1820BF830
	public static CardTable.WinnerBreakdown.Winner Deserialize(Stream stream, CardTable.WinnerBreakdown.Winner instance, bool isDelta) { }

	// RVA: 0x20BEB10 Offset: 0x20BD110 VA: 0x1820BEB10
	public static CardTable.WinnerBreakdown.Winner DeserializeLengthDelimited(Stream stream, CardTable.WinnerBreakdown.Winner instance, bool isDelta) { }

	// RVA: 0x20BEE10 Offset: 0x20BD410 VA: 0x1820BEE10
	public static CardTable.WinnerBreakdown.Winner DeserializeLength(Stream stream, int length, CardTable.WinnerBreakdown.Winner instance, bool isDelta) { }

	// RVA: 0x20BFDE0 Offset: 0x20BE3E0 VA: 0x1820BFDE0
	public static void SerializeDelta(Stream stream, CardTable.WinnerBreakdown.Winner instance, CardTable.WinnerBreakdown.Winner previous) { }

	// RVA: 0x20C0160 Offset: 0x20BE760 VA: 0x1820C0160
	public static void Serialize(Stream stream, CardTable.WinnerBreakdown.Winner instance) { }

	// RVA: 0x20C0280 Offset: 0x20BE880 VA: 0x1820C0280
	public byte[] ToProtoBytes() { }

	// RVA: 0x20C0290 Offset: 0x20BE890 VA: 0x1820C0290
	public void ToProto(Stream stream) { }

	// RVA: 0x20C0050 Offset: 0x20BE650 VA: 0x1820C0050
	public static byte[] SerializeToBytes(CardTable.WinnerBreakdown.Winner instance) { }

	// RVA: 0x20BFFA0 Offset: 0x20BE5A0 VA: 0x1820BFFA0
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

	// RVA: 0x1F764B0 Offset: 0x1F74AB0 VA: 0x181F764B0
	public static void ResetToPool(CardTable.CardList instance) { }

	// RVA: 0x1F763D0 Offset: 0x1F749D0 VA: 0x181F763D0
	public void ResetToPool() { }

	// RVA: 0x1F76240 Offset: 0x1F74840 VA: 0x181F76240 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F75550 Offset: 0x1F73B50 VA: 0x181F75550
	public void CopyTo(CardTable.CardList instance) { }

	// RVA: 0x1F75670 Offset: 0x1F73C70 VA: 0x181F75670
	public CardTable.CardList Copy() { }

	// RVA: 0x1F760A0 Offset: 0x1F746A0 VA: 0x181F760A0
	public static CardTable.CardList Deserialize(Stream stream) { }

	// RVA: 0x1F75A60 Offset: 0x1F74060 VA: 0x181F75A60
	public static CardTable.CardList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F75D50 Offset: 0x1F74350 VA: 0x181F75D50
	public static CardTable.CardList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F76120 Offset: 0x1F74720 VA: 0x181F76120
	public static CardTable.CardList Deserialize(byte[] buffer) { }

	// RVA: 0x1F76390 Offset: 0x1F74990 VA: 0x181F76390
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F76A00 Offset: 0x1F75000 VA: 0x181F76A00 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F76A20 Offset: 0x1F75020 VA: 0x181F76A20 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CardTable.CardList previous) { }

	// RVA: 0x1F763B0 Offset: 0x1F749B0 VA: 0x181F763B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F75FA0 Offset: 0x1F745A0 VA: 0x181F75FA0
	public static CardTable.CardList Deserialize(byte[] buffer, CardTable.CardList instance, bool isDelta = False) { }

	// RVA: 0x1F75DE0 Offset: 0x1F743E0 VA: 0x181F75DE0
	public static CardTable.CardList Deserialize(Stream stream, CardTable.CardList instance, bool isDelta) { }

	// RVA: 0x1F757D0 Offset: 0x1F73DD0 VA: 0x181F757D0
	public static CardTable.CardList DeserializeLengthDelimited(Stream stream, CardTable.CardList instance, bool isDelta) { }

	// RVA: 0x1F75AE0 Offset: 0x1F740E0 VA: 0x181F75AE0
	public static CardTable.CardList DeserializeLength(Stream stream, int length, CardTable.CardList instance, bool isDelta) { }

	// RVA: 0x1F76590 Offset: 0x1F74B90 VA: 0x181F76590
	public static void SerializeDelta(Stream stream, CardTable.CardList instance, CardTable.CardList previous) { }

	// RVA: 0x1F768A0 Offset: 0x1F74EA0 VA: 0x181F768A0
	public static void Serialize(Stream stream, CardTable.CardList instance) { }

	// RVA: 0x1F769F0 Offset: 0x1F74FF0 VA: 0x181F769F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F76A00 Offset: 0x1F75000 VA: 0x181F76A00
	public void ToProto(Stream stream) { }

	// RVA: 0x1F76790 Offset: 0x1F74D90 VA: 0x181F76790
	public static byte[] SerializeToBytes(CardTable.CardList instance) { }

	// RVA: 0x1F766E0 Offset: 0x1F74CE0 VA: 0x181F766E0
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

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x704ED0 Offset: 0x7034D0 VA: 0x180704ED0
	public string get_recentlyLeftPlayerName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	[BaseEntity.Menu] // RVA: 0xD0FA0 Offset: 0xD03A0 VA: 0x1800D0FA0
	[BaseEntity.Menu.Description] // RVA: 0xD0FA0 Offset: 0xD03A0 VA: 0x1800D0FA0
	[BaseEntity.Menu.Icon] // RVA: 0xD0FA0 Offset: 0xD03A0 VA: 0x1800D0FA0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD0FA0 Offset: 0xD03A0 VA: 0x1800D0FA0
	// RVA: 0x702C90 Offset: 0x701290 VA: 0x180702C90
	public void Menu_Play(BasePlayer player) { }

	// RVA: 0x702BE0 Offset: 0x7011E0 VA: 0x180702BE0
	public bool Menu_Play_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	[BaseEntity.Menu.Description] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	[BaseEntity.Menu.Icon] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	[BaseEntity.Menu.ShowIf] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
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

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x703F00 Offset: 0x702500 VA: 0x180703F00
	private void OnWinnersDeclared(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x704040 Offset: 0x702640 VA: 0x180704040
	private void ReceiveCardsForPlayer(BaseEntity.RPCMessage msg) { }

	// RVA: 0x701B50 Offset: 0x700150 VA: 0x180701B50
	public void ClientInput(int inputType, int inputValue = 0) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x701D10 Offset: 0x700310 VA: 0x180701D10
	private void ClientPlaySound(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x701D70 Offset: 0x700370 VA: 0x180701D70
	private void ClientStartTurnTimer(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

