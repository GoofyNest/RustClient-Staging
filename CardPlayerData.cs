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
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public ulong get_UserID() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1190 Offset: 0x8BF790 VA: 0x1808C1190
	private void set_UserID(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public CardPlayerData.CardPlayerState get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D730 Offset: 0x69BD30 VA: 0x18069D730
	private void set_State(CardPlayerData.CardPlayerState value) { }

	// RVA: 0x8C1130 Offset: 0x8BF730 VA: 0x1808C1130
	public bool get_HasUser() { }

	// RVA: 0x8C1120 Offset: 0x8BF720 VA: 0x1808C1120
	public bool get_HasUserInGame() { }

	// RVA: 0x8C1110 Offset: 0x8BF710 VA: 0x1808C1110
	public bool get_HasUserInCurrentRound() { }

	// RVA: 0x8C1100 Offset: 0x8BF700 VA: 0x1808C1100
	public bool get_HasAvailableInputs() { }

	// RVA: 0x8C1140 Offset: 0x8BF740 VA: 0x1808C1140
	private bool get_IsClient() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1150 Offset: 0x8BF750 VA: 0x1808C1150
	public bool get_LeftRoundEarly() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x78E280 Offset: 0x78C880 VA: 0x18078E280
	private void set_LeftRoundEarly(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1160 Offset: 0x8BF760 VA: 0x1808C1160
	public bool get_SendCardDetails() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1170 Offset: 0x8BF770 VA: 0x1808C1170
	private void set_SendCardDetails(bool value) { }

	// RVA: 0x8C1070 Offset: 0x8BF670 VA: 0x1808C1070
	public void .ctor(int mountIndex, bool isServer) { }

	// RVA: 0x8C0E20 Offset: 0x8BF420 VA: 0x1808C0E20 Slot: 4
	public void Dispose() { }

	// RVA: 0x8C0E80 Offset: 0x8BF480 VA: 0x1808C0E80
	public int GetScrapAmount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5E2F50 Offset: 0x5E1550 VA: 0x1805E2F50
	public int get_TrueCardCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1180 Offset: 0x8BF780 VA: 0x1808C1180
	private void set_TrueCardCount(int value) { }

	// RVA: 0x8C0EA0 Offset: 0x8BF4A0 VA: 0x1808C0EA0
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

