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

	// RVA: 0x7D3CE0 Offset: 0x7D22E0 VA: 0x1807D3CE0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7D6230 Offset: 0x7D4830 VA: 0x1807D6230 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7D4540 Offset: 0x7D2B40 VA: 0x1807D4540 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7D40F0 Offset: 0x7D26F0 VA: 0x1807D40F0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7D6160 Offset: 0x7D4760 VA: 0x1807D6160 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x7D5ED0 Offset: 0x7D44D0 VA: 0x1807D5ED0
	public void SpawnGame() { }

	// RVA: 0x7D40D0 Offset: 0x7D26D0 VA: 0x1807D40D0 Slot: 28
	public override void InitShared() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D3110 Offset: 0x7D1710 VA: 0x1807D3110
	public void BeginHosting(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D36E0 Offset: 0x7D1CE0 VA: 0x1807D36E0
	public void EndHosting(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D44B0 Offset: 0x7D2AB0 VA: 0x1807D44B0
	public void NoHost(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D3BA0 Offset: 0x7D21A0 VA: 0x1807D3BA0
	public void GetEntityMessage(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7D32C0 Offset: 0x7D18C0 VA: 0x1807D32C0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x7D37D0 Offset: 0x7D1DD0 VA: 0x1807D37D0
	public void FixedUpdate() { }

	// RVA: 0x7D3990 Offset: 0x7D1F90 VA: 0x1807D3990
	public void GameVisibilityChanged(bool isVisible) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D32D0 Offset: 0x7D18D0 VA: 0x1807D32D0
	public void DestroyEntity(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D3FF0 Offset: 0x7D25F0 VA: 0x1807D3FF0
	public void GetSnapshotFromServer(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7D5E10 Offset: 0x7D4410 VA: 0x1807D5E10
	public void SendSnapshotToServer() { }

	// RVA: 0x7D3610 Offset: 0x7D1C10 VA: 0x1807D3610
	public void DoClientInput() { }

	// RVA: 0x7D3550 Offset: 0x7D1B50 VA: 0x1807D3550 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x7D5C90 Offset: 0x7D4290 VA: 0x1807D5C90 Slot: 194
	public virtual void PlayerClientInput(InputState inputState) { }

	// RVA: 0x7D5DC0 Offset: 0x7D43C0 VA: 0x1807D5DC0
	public void SendDestroyMessage(uint entityID) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 184
	public override bool MountMenuVisible(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB4830 Offset: 0xB3C30 VA: 0x1800B4830
	[BaseEntity.Menu.Description] // RVA: 0xB4830 Offset: 0xB3C30 VA: 0x1800B4830
	[BaseEntity.Menu.Icon] // RVA: 0xB4830 Offset: 0xB3C30 VA: 0x1800B4830
	[BaseEntity.Menu.ShowIf] // RVA: 0xB4830 Offset: 0xB3C30 VA: 0x1800B4830
	// RVA: 0x7D4470 Offset: 0x7D2A70 VA: 0x1807D4470
	public void Menu_Play(BasePlayer player) { }

	// RVA: 0x7D4370 Offset: 0x7D2970 VA: 0x1807D4370
	public bool Menu_PlayGame_ShowIf(BasePlayer player) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 192
	protected override bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0x7D6170 Offset: 0x7D4770 VA: 0x1807D6170
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

