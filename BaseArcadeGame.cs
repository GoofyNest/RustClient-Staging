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

	// RVA: 0x7D2A90 Offset: 0x7D1090 VA: 0x1807D2A90
	public void SendArcadeEntityMessage(ArcadeEntity ent, string msg) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	public virtual void OnNoHost() { }

	// RVA: 0x7D2350 Offset: 0x7D0950 VA: 0x1807D2350
	public bool IsGameAuthorative() { }

	// RVA: 0x7D2B70 Offset: 0x7D1170 VA: 0x1807D2B70
	public void SetGameAuthorative(bool wants) { }

	// RVA: 0x7D2100 Offset: 0x7D0700 VA: 0x1807D2100
	public Sprite GetSprite(uint index) { }

	// RVA: 0x7D2010 Offset: 0x7D0610 VA: 0x1807D2010
	public uint GetSpriteIndex(Sprite sprite) { }

	// RVA: 0x7D1AA0 Offset: 0x7D00A0 VA: 0x1807D1AA0
	public ArcadeEntityController CreateEntityViaController(ArcadeEntityController controllerPrefab, Vector3 pos, Vector3 heading) { }

	// RVA: 0x7D1340 Offset: 0x7CF940 VA: 0x1807D1340
	public float ClampMouseDelta(float delta) { }

	// RVA: 0x7D2690 Offset: 0x7D0C90 VA: 0x1807D2690
	public void RenderGame() { }

	// RVA: 0x7D23C0 Offset: 0x7D09C0 VA: 0x1807D23C0
	public void OnDisable() { }

	// RVA: 0x7D1F90 Offset: 0x7D0590 VA: 0x1807D1F90
	public ArcadeEntity GetByID(uint id) { }

	// RVA: 0x7D1E70 Offset: 0x7D0470 VA: 0x1807D1E70
	public int GetArcadeEntityManifestIndex(ArcadeEntity source) { }

	// RVA: 0x7D25F0 Offset: 0x7D0BF0 VA: 0x1807D25F0
	public void RegisterArcadeEntity(ArcadeEntity ent, bool onHost = False, uint idOverride = 0) { }

	// RVA: 0x7D1910 Offset: 0x7CFF10 VA: 0x1807D1910
	public ArcadeEntity CreateArcadeEntity(ArcadeEntity source, bool onHost = False, uint idOverride = 0) { }

	// RVA: 0x7D13B0 Offset: 0x7CF9B0 VA: 0x1807D13B0
	public ArcadeEntity CreateArcadeEntity(uint prefabIndex, bool onHost = False, uint idOverride = 0) { }

	// RVA: 0x7D1C50 Offset: 0x7D0250 VA: 0x1807D1C50
	public void DestroyEntity(uint entityID) { }

	// RVA: 0x7D27F0 Offset: 0x7D0DF0 VA: 0x1807D27F0
	public void Retire(ArcadeEntity toRetire) { }

	// RVA: 0x7D2520 Offset: 0x7D0B20 VA: 0x1807D2520
	public void OnGameVisibilityChanged(bool isVisible) { }

	// RVA: 0x7D2140 Offset: 0x7D0740 VA: 0x1807D2140 Slot: 7
	public virtual void Initialize() { }

	// RVA: 0x7D23C0 Offset: 0x7D09C0 VA: 0x1807D23C0
	public void Shutdown() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public virtual void MenuAction(string message) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	public virtual void PlayerInput(InputState inputState, BasePlayer player, int playerIndex = 0, bool clientside = False) { }

	// RVA: 0x7D2890 Offset: 0x7D0E90 VA: 0x1807D2890
	public ArcadeGame SaveSnapshot(bool force = True) { }

	// RVA: 0x7D1DF0 Offset: 0x7D03F0 VA: 0x1807D1DF0
	public ArcadeEntity GetArcadeEntityFromCollider(Collider hitCol) { }

	// RVA: 0x7D2C90 Offset: 0x7D1290 VA: 0x1807D2C90 Slot: 10
	public virtual void UpdateGameFromSnapshot(ArcadeGame game) { }

	// RVA: 0x7D2F80 Offset: 0x7D1580 VA: 0x1807D2F80
	public void .ctor() { }

	// RVA: 0x7D2F00 Offset: 0x7D1500 VA: 0x1807D2F00
	private static void .cctor() { }

}

