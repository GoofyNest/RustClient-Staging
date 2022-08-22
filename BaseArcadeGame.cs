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

	// RVA: 0x79E4C0 Offset: 0x79CAC0 VA: 0x18079E4C0
	public void SendArcadeEntityMessage(ArcadeEntity ent, string msg) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	public virtual void OnNoHost() { }

	// RVA: 0x79DD80 Offset: 0x79C380 VA: 0x18079DD80
	public bool IsGameAuthorative() { }

	// RVA: 0x79E5A0 Offset: 0x79CBA0 VA: 0x18079E5A0
	public void SetGameAuthorative(bool wants) { }

	// RVA: 0x79DB30 Offset: 0x79C130 VA: 0x18079DB30
	public Sprite GetSprite(uint index) { }

	// RVA: 0x79DA40 Offset: 0x79C040 VA: 0x18079DA40
	public uint GetSpriteIndex(Sprite sprite) { }

	// RVA: 0x79D4D0 Offset: 0x79BAD0 VA: 0x18079D4D0
	public ArcadeEntityController CreateEntityViaController(ArcadeEntityController controllerPrefab, Vector3 pos, Vector3 heading) { }

	// RVA: 0x79CD70 Offset: 0x79B370 VA: 0x18079CD70
	public float ClampMouseDelta(float delta) { }

	// RVA: 0x79E0C0 Offset: 0x79C6C0 VA: 0x18079E0C0
	public void RenderGame() { }

	// RVA: 0x79DDF0 Offset: 0x79C3F0 VA: 0x18079DDF0
	public void OnDisable() { }

	// RVA: 0x79D9C0 Offset: 0x79BFC0 VA: 0x18079D9C0
	public ArcadeEntity GetByID(uint id) { }

	// RVA: 0x79D8A0 Offset: 0x79BEA0 VA: 0x18079D8A0
	public int GetArcadeEntityManifestIndex(ArcadeEntity source) { }

	// RVA: 0x79E020 Offset: 0x79C620 VA: 0x18079E020
	public void RegisterArcadeEntity(ArcadeEntity ent, bool onHost = False, uint idOverride = 0) { }

	// RVA: 0x79D340 Offset: 0x79B940 VA: 0x18079D340
	public ArcadeEntity CreateArcadeEntity(ArcadeEntity source, bool onHost = False, uint idOverride = 0) { }

	// RVA: 0x79CDE0 Offset: 0x79B3E0 VA: 0x18079CDE0
	public ArcadeEntity CreateArcadeEntity(uint prefabIndex, bool onHost = False, uint idOverride = 0) { }

	// RVA: 0x79D680 Offset: 0x79BC80 VA: 0x18079D680
	public void DestroyEntity(uint entityID) { }

	// RVA: 0x79E220 Offset: 0x79C820 VA: 0x18079E220
	public void Retire(ArcadeEntity toRetire) { }

	// RVA: 0x79DF50 Offset: 0x79C550 VA: 0x18079DF50
	public void OnGameVisibilityChanged(bool isVisible) { }

	// RVA: 0x79DB70 Offset: 0x79C170 VA: 0x18079DB70 Slot: 7
	public virtual void Initialize() { }

	// RVA: 0x79DDF0 Offset: 0x79C3F0 VA: 0x18079DDF0
	public void Shutdown() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public virtual void MenuAction(string message) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	public virtual void PlayerInput(InputState inputState, BasePlayer player, int playerIndex = 0, bool clientside = False) { }

	// RVA: 0x79E2C0 Offset: 0x79C8C0 VA: 0x18079E2C0
	public ArcadeGame SaveSnapshot(bool force = True) { }

	// RVA: 0x79D820 Offset: 0x79BE20 VA: 0x18079D820
	public ArcadeEntity GetArcadeEntityFromCollider(Collider hitCol) { }

	// RVA: 0x79E6C0 Offset: 0x79CCC0 VA: 0x18079E6C0 Slot: 10
	public virtual void UpdateGameFromSnapshot(ArcadeGame game) { }

	// RVA: 0x79E9B0 Offset: 0x79CFB0 VA: 0x18079E9B0
	public void .ctor() { }

	// RVA: 0x79E930 Offset: 0x79CF30 VA: 0x18079E930
	private static void .cctor() { }

}

