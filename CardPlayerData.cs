public class CardPlayerData : IDisposable // TypeDefIndex: 12012
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ulong <UserID>k__BackingField; // 0x10
	public List<PlayingCard> Cards; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private CardPlayerData.CardPlayerState <State>k__BackingField; // 0x20
	public readonly int mountIndex; // 0x24
	private readonly bool isServer; // 0x28
	public int availableInputs; // 0x2C
	public int betThisRound; // 0x30
	public int betThisTurn; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <LeftRoundEarly>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <SendCardDetails>k__BackingField; // 0x39
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public ulong get_UserID() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x8C1080 Offset: 0x8BF680 VA: 0x1808C1080
	private void set_UserID(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public CardPlayerData.CardPlayerState get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x69D620 Offset: 0x69BC20 VA: 0x18069D620
	private void set_State(CardPlayerData.CardPlayerState value) { }

	// RVA: 0x8C1020 Offset: 0x8BF620 VA: 0x1808C1020
	public bool get_HasUser() { }

	// RVA: 0x8C1010 Offset: 0x8BF610 VA: 0x1808C1010
	public bool get_HasUserInGame() { }

	// RVA: 0x8C1000 Offset: 0x8BF600 VA: 0x1808C1000
	public bool get_HasUserInCurrentRound() { }

	// RVA: 0x8C0FF0 Offset: 0x8BF5F0 VA: 0x1808C0FF0
	public bool get_HasAvailableInputs() { }

	// RVA: 0x8C1030 Offset: 0x8BF630 VA: 0x1808C1030
	private bool get_IsClient() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x8C1040 Offset: 0x8BF640 VA: 0x1808C1040
	public bool get_LeftRoundEarly() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x78E170 Offset: 0x78C770 VA: 0x18078E170
	private void set_LeftRoundEarly(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x8C1050 Offset: 0x8BF650 VA: 0x1808C1050
	public bool get_SendCardDetails() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x8C1060 Offset: 0x8BF660 VA: 0x1808C1060
	private void set_SendCardDetails(bool value) { }

	// RVA: 0x8C0F60 Offset: 0x8BF560 VA: 0x1808C0F60
	public void .ctor(int mountIndex, bool isServer) { }

	// RVA: 0x8C0D10 Offset: 0x8BF310 VA: 0x1808C0D10 Slot: 4
	public void Dispose() { }

	// RVA: 0x8C0D70 Offset: 0x8BF370 VA: 0x1808C0D70
	public int GetScrapAmount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x5E2F50 Offset: 0x5E1550 VA: 0x1805E2F50
	public int get_TrueCardCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x8C1070 Offset: 0x8BF670 VA: 0x1808C1070
	private void set_TrueCardCount(int value) { }

	// RVA: 0x8C0D90 Offset: 0x8BF390 VA: 0x1808C0D90
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

