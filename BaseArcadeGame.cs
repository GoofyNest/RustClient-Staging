public class BaseArcadeGame : BaseMonoBehaviour // TypeDefIndex: 8762
{	// Fields
	public static List<BaseArcadeGame> globalActiveGames; // 0x0
	public Camera cameraToRender; // 0x18
	public RenderTexture renderTexture; // 0x20
	public Texture2D distantTexture; // 0x28
	public Transform center; // 0x30
	public int frameRate; // 0x38
	public Dictionary<uint, ArcadeEntity> activeArcadeEntities; // 0x40
	public Sprite[] spriteManifest; // 0x48
	public ArcadeEntity[] entityManifest; // 0x50
	public bool clientside; // 0x58
	public bool clientsideInput; // 0x59
	public const int spriteIndexInvisible = 1555;
	public GameObject arcadeEntityPrefab; // 0x60
	public BaseArcadeMachine ownerMachine; // 0x68
	public static int gameOffsetIndex; // 0x8
	private bool isAuthorative; // 0x70
	public Canvas canvas; // 0x78
	private float lastFrameRate; // 0x80
	private uint lastEntityID; // 0x84
	private bool currentGameVisibility; // 0x88
	private float lastSnapshotTime; // 0x8C

	// Methods

	// RVA: 0x7D2BA0 Offset: 0x7D11A0 VA: 0x1807D2BA0
	public void SendArcadeEntityMessage(ArcadeEntity ent, string msg) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	public virtual void OnNoHost() { }

	// RVA: 0x7D2460 Offset: 0x7D0A60 VA: 0x1807D2460
	public bool IsGameAuthorative() { }

	// RVA: 0x7D2C80 Offset: 0x7D1280 VA: 0x1807D2C80
	public void SetGameAuthorative(bool wants) { }

	// RVA: 0x7D2210 Offset: 0x7D0810 VA: 0x1807D2210
	public Sprite GetSprite(uint index) { }

	// RVA: 0x7D2120 Offset: 0x7D0720 VA: 0x1807D2120
	public uint GetSpriteIndex(Sprite sprite) { }

	// RVA: 0x7D1BB0 Offset: 0x7D01B0 VA: 0x1807D1BB0
	public ArcadeEntityController CreateEntityViaController(ArcadeEntityController controllerPrefab, Vector3 pos, Vector3 heading) { }

	// RVA: 0x7D1450 Offset: 0x7CFA50 VA: 0x1807D1450
	public float ClampMouseDelta(float delta) { }

	// RVA: 0x7D27A0 Offset: 0x7D0DA0 VA: 0x1807D27A0
	public void RenderGame() { }

	// RVA: 0x7D24D0 Offset: 0x7D0AD0 VA: 0x1807D24D0
	public void OnDisable() { }

	// RVA: 0x7D20A0 Offset: 0x7D06A0 VA: 0x1807D20A0
	public ArcadeEntity GetByID(uint id) { }

	// RVA: 0x7D1F80 Offset: 0x7D0580 VA: 0x1807D1F80
	public int GetArcadeEntityManifestIndex(ArcadeEntity source) { }

	// RVA: 0x7D2700 Offset: 0x7D0D00 VA: 0x1807D2700
	public void RegisterArcadeEntity(ArcadeEntity ent, bool onHost = False, uint idOverride = 0) { }

	// RVA: 0x7D1A20 Offset: 0x7D0020 VA: 0x1807D1A20
	public ArcadeEntity CreateArcadeEntity(ArcadeEntity source, bool onHost = False, uint idOverride = 0) { }

	// RVA: 0x7D14C0 Offset: 0x7CFAC0 VA: 0x1807D14C0
	public ArcadeEntity CreateArcadeEntity(uint prefabIndex, bool onHost = False, uint idOverride = 0) { }

	// RVA: 0x7D1D60 Offset: 0x7D0360 VA: 0x1807D1D60
	public void DestroyEntity(uint entityID) { }

	// RVA: 0x7D2900 Offset: 0x7D0F00 VA: 0x1807D2900
	public void Retire(ArcadeEntity toRetire) { }

	// RVA: 0x7D2630 Offset: 0x7D0C30 VA: 0x1807D2630
	public void OnGameVisibilityChanged(bool isVisible) { }

	// RVA: 0x7D2250 Offset: 0x7D0850 VA: 0x1807D2250 Slot: 7
	public virtual void Initialize() { }

	// RVA: 0x7D24D0 Offset: 0x7D0AD0 VA: 0x1807D24D0
	public void Shutdown() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public virtual void MenuAction(string message) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	public virtual void PlayerInput(InputState inputState, BasePlayer player, int playerIndex = 0, bool clientside = False) { }

	// RVA: 0x7D29A0 Offset: 0x7D0FA0 VA: 0x1807D29A0
	public ArcadeGame SaveSnapshot(bool force = True) { }

	// RVA: 0x7D1F00 Offset: 0x7D0500 VA: 0x1807D1F00
	public ArcadeEntity GetArcadeEntityFromCollider(Collider hitCol) { }

	// RVA: 0x7D2DA0 Offset: 0x7D13A0 VA: 0x1807D2DA0 Slot: 10
	public virtual void UpdateGameFromSnapshot(ArcadeGame game) { }

	// RVA: 0x7D3090 Offset: 0x7D1690 VA: 0x1807D3090
	public void .ctor() { }

	// RVA: 0x7D3010 Offset: 0x7D1610 VA: 0x1807D3010
	private static void .cctor() { }

}

