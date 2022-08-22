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

	// RVA: 0x7D3BD0 Offset: 0x7D21D0 VA: 0x1807D3BD0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7D6120 Offset: 0x7D4720 VA: 0x1807D6120 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7D4430 Offset: 0x7D2A30 VA: 0x1807D4430 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7D3FE0 Offset: 0x7D25E0 VA: 0x1807D3FE0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7D6050 Offset: 0x7D4650 VA: 0x1807D6050 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x7D5DC0 Offset: 0x7D43C0 VA: 0x1807D5DC0
	public void SpawnGame() { }

	// RVA: 0x7D3FC0 Offset: 0x7D25C0 VA: 0x1807D3FC0 Slot: 28
	public override void InitShared() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D3000 Offset: 0x7D1600 VA: 0x1807D3000
	public void BeginHosting(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D35D0 Offset: 0x7D1BD0 VA: 0x1807D35D0
	public void EndHosting(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D43A0 Offset: 0x7D29A0 VA: 0x1807D43A0
	public void NoHost(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D3A90 Offset: 0x7D2090 VA: 0x1807D3A90
	public void GetEntityMessage(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7D31B0 Offset: 0x7D17B0 VA: 0x1807D31B0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x7D36C0 Offset: 0x7D1CC0 VA: 0x1807D36C0
	public void FixedUpdate() { }

	// RVA: 0x7D3880 Offset: 0x7D1E80 VA: 0x1807D3880
	public void GameVisibilityChanged(bool isVisible) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D31C0 Offset: 0x7D17C0 VA: 0x1807D31C0
	public void DestroyEntity(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D3EE0 Offset: 0x7D24E0 VA: 0x1807D3EE0
	public void GetSnapshotFromServer(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7D5D00 Offset: 0x7D4300 VA: 0x1807D5D00
	public void SendSnapshotToServer() { }

	// RVA: 0x7D3500 Offset: 0x7D1B00 VA: 0x1807D3500
	public void DoClientInput() { }

	// RVA: 0x7D3440 Offset: 0x7D1A40 VA: 0x1807D3440 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x7D5B80 Offset: 0x7D4180 VA: 0x1807D5B80 Slot: 194
	public virtual void PlayerClientInput(InputState inputState) { }

	// RVA: 0x7D5CB0 Offset: 0x7D42B0 VA: 0x1807D5CB0
	public void SendDestroyMessage(uint entityID) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 184
	public override bool MountMenuVisible(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB4830 Offset: 0xB3C30 VA: 0x1800B4830
	[BaseEntity.Menu.Description] // RVA: 0xB4830 Offset: 0xB3C30 VA: 0x1800B4830
	[BaseEntity.Menu.Icon] // RVA: 0xB4830 Offset: 0xB3C30 VA: 0x1800B4830
	[BaseEntity.Menu.ShowIf] // RVA: 0xB4830 Offset: 0xB3C30 VA: 0x1800B4830
	// RVA: 0x7D4360 Offset: 0x7D2960 VA: 0x1807D4360
	public void Menu_Play(BasePlayer player) { }

	// RVA: 0x7D4260 Offset: 0x7D2860 VA: 0x1807D4260
	public bool Menu_PlayGame_ShowIf(BasePlayer player) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 192
	protected override bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0x7D6060 Offset: 0x7D4660 VA: 0x1807D6060
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

