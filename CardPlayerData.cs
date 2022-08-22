public class CardPlayerData : IDisposable // TypeDefIndex: 12012
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ulong <UserID>k__BackingField; // 0x10
	public List<PlayingCard> Cards; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private CardPlayerData.CardPlayerState <State>k__BackingField; // 0x20
	public readonly int mountIndex; // 0x24
	private readonly bool isServer; // 0x28
	public int availableInputs; // 0x2C
	public int betThisRound; // 0x30
	public int betThisTurn; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <LeftRoundEarly>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <SendCardDetails>k__BackingField; // 0x39
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <TrueCardCount>k__BackingField; // 0x3C
	private int clientScrap; // 0x40

	// Properties
	public ulong UserID { get; set; }
	public CardPlayerData.CardPlayerState State { get; set; }
	public bool HasUser { get; }
	public bool HasUserInGame { get; }
	public bool HasUserInCurrentRound { get; }
	public bool HasAvailableInputs { get; }
	private bool IsClient { get; }
	public bool LeftRoundEarly { get; set; }
	public bool SendCardDetails { get; set; }
	public int TrueCardCount { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public ulong get_UserID() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C16A0 Offset: 0x8BFCA0 VA: 0x1808C16A0
	private void set_UserID(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	public CardPlayerData.CardPlayerState get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D6C0 Offset: 0x69BCC0 VA: 0x18069D6C0
	private void set_State(CardPlayerData.CardPlayerState value) { }

	// RVA: 0x8C1640 Offset: 0x8BFC40 VA: 0x1808C1640
	public bool get_HasUser() { }

	// RVA: 0x8C1630 Offset: 0x8BFC30 VA: 0x1808C1630
	public bool get_HasUserInGame() { }

	// RVA: 0x8C1620 Offset: 0x8BFC20 VA: 0x1808C1620
	public bool get_HasUserInCurrentRound() { }

	// RVA: 0x8C1610 Offset: 0x8BFC10 VA: 0x1808C1610
	public bool get_HasAvailableInputs() { }

	// RVA: 0x8C1650 Offset: 0x8BFC50 VA: 0x1808C1650
	private bool get_IsClient() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1660 Offset: 0x8BFC60 VA: 0x1808C1660
	public bool get_LeftRoundEarly() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x78E190 Offset: 0x78C790 VA: 0x18078E190
	private void set_LeftRoundEarly(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1670 Offset: 0x8BFC70 VA: 0x1808C1670
	public bool get_SendCardDetails() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1680 Offset: 0x8BFC80 VA: 0x1808C1680
	private void set_SendCardDetails(bool value) { }

	// RVA: 0x8C1580 Offset: 0x8BFB80 VA: 0x1808C1580
	public void .ctor(int mountIndex, bool isServer) { }

	// RVA: 0x8C1330 Offset: 0x8BF930 VA: 0x1808C1330 Slot: 4
	public void Dispose() { }

	// RVA: 0x8C1390 Offset: 0x8BF990 VA: 0x1808C1390
	public int GetScrapAmount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5E2EE0 Offset: 0x5E14E0 VA: 0x1805E2EE0
	public int get_TrueCardCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1690 Offset: 0x8BFC90 VA: 0x1808C1690
	private void set_TrueCardCount(int value) { }

	// RVA: 0x8C13B0 Offset: 0x8BF9B0 VA: 0x1808C13B0
	public void Load(CardTable.CardPlayer msg) { }

}

public enum CardPlayerData.CardPlayerState // TypeDefIndex: 12013
{	// Fields
	public int value__; // 0x0
	public const CardPlayerData.CardPlayerState None = 0;
	public const CardPlayerData.CardPlayerState WantsToPlay = 1;
	public const CardPlayerData.CardPlayerState InGame = 2;
	public const CardPlayerData.CardPlayerState InCurrentRound = 3;

}

