public class BaseArcadeMachine : BaseVehicle // TypeDefIndex: 8316
{	// Fields
	private Option __menuOption_Menu_Play; // 0x3B8
	public BaseArcadeGame arcadeGamePrefab; // 0x410
	public BaseArcadeGame activeGame; // 0x418
	public ArcadeNetworkTrigger networkTrigger; // 0x420
	public float broadcastRadius; // 0x428
	public Transform gameScreen; // 0x430
	public RawImage RTImage; // 0x438
	public Transform leftJoystick; // 0x440
	public Transform rightJoystick; // 0x448
	public SoundPlayer musicPlayer; // 0x450
	public const BaseEntity.Flags Flag_P1 = 32768;
	public const BaseEntity.Flags Flag_P2 = 65536;
	public List<BaseArcadeMachine.ScoreEntry> scores; // 0x458
	private const int inputFrameRate = 60;
	private const int snapshotFrameRate = 15;
	private Vector3 arcadeWorldOffset; // 0x460
	private bool clientScreeenActive; // 0x46C

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x79F600 Offset: 0x79DC00 VA: 0x18079F600 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7A1B50 Offset: 0x7A0150 VA: 0x1807A1B50 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x79FE60 Offset: 0x79E460 VA: 0x18079FE60 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x79FA10 Offset: 0x79E010 VA: 0x18079FA10 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7A1A80 Offset: 0x7A0080 VA: 0x1807A1A80 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x7A17F0 Offset: 0x79FDF0 VA: 0x1807A17F0
	public void SpawnGame() { }

	// RVA: 0x79F9F0 Offset: 0x79DFF0 VA: 0x18079F9F0 Slot: 28
	public override void InitShared() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79EA30 Offset: 0x79D030 VA: 0x18079EA30
	public void BeginHosting(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79F000 Offset: 0x79D600 VA: 0x18079F000
	public void EndHosting(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79FDD0 Offset: 0x79E3D0 VA: 0x18079FDD0
	public void NoHost(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79F4C0 Offset: 0x79DAC0 VA: 0x18079F4C0
	public void GetEntityMessage(BaseEntity.RPCMessage msg) { }

	// RVA: 0x79EBE0 Offset: 0x79D1E0 VA: 0x18079EBE0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x79F0F0 Offset: 0x79D6F0 VA: 0x18079F0F0
	public void FixedUpdate() { }

	// RVA: 0x79F2B0 Offset: 0x79D8B0 VA: 0x18079F2B0
	public void GameVisibilityChanged(bool isVisible) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79EBF0 Offset: 0x79D1F0 VA: 0x18079EBF0
	public void DestroyEntity(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79F910 Offset: 0x79DF10 VA: 0x18079F910
	public void GetSnapshotFromServer(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7A1730 Offset: 0x79FD30 VA: 0x1807A1730
	public void SendSnapshotToServer() { }

	// RVA: 0x79EF30 Offset: 0x79D530 VA: 0x18079EF30
	public void DoClientInput() { }

	// RVA: 0x79EE70 Offset: 0x79D470 VA: 0x18079EE70 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x7A15B0 Offset: 0x79FBB0 VA: 0x1807A15B0 Slot: 194
	public virtual void PlayerClientInput(InputState inputState) { }

	// RVA: 0x7A16E0 Offset: 0x79FCE0 VA: 0x1807A16E0
	public void SendDestroyMessage(uint entityID) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 184
	public override bool MountMenuVisible(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB4830 Offset: 0xB3C30 VA: 0x1800B4830
	[BaseEntity.Menu.Description] // RVA: 0xB4830 Offset: 0xB3C30 VA: 0x1800B4830
	[BaseEntity.Menu.Icon] // RVA: 0xB4830 Offset: 0xB3C30 VA: 0x1800B4830
	[BaseEntity.Menu.ShowIf] // RVA: 0xB4830 Offset: 0xB3C30 VA: 0x1800B4830
	// RVA: 0x79FD90 Offset: 0x79E390 VA: 0x18079FD90
	public void Menu_Play(BasePlayer player) { }

	// RVA: 0x79FC90 Offset: 0x79E290 VA: 0x18079FC90
	public bool Menu_PlayGame_ShowIf(BasePlayer player) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 192
	protected override bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0x7A1A90 Offset: 0x7A0090 VA: 0x1807A1A90
	public void .ctor() { }

}

public class BaseArcadeMachine.ScoreEntry // TypeDefIndex: 8317
{	// Fields
	public ulong playerID; // 0x10
	public int score; // 0x18
	public string displayName; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

