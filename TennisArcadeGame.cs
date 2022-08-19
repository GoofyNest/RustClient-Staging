public class TennisArcadeGame : BaseArcadeGame // TypeDefIndex: 8775
{	// Fields
	public ArcadeEntity paddle1; // 0x90
	public ArcadeEntity paddle2; // 0x98
	public ArcadeEntity ball; // 0xA0
	public Transform paddle1Origin; // 0xA8
	public Transform paddle2Origin; // 0xB0
	public Transform paddle1Goal; // 0xB8
	public Transform paddle2Goal; // 0xC0
	public Transform ballSpawn; // 0xC8
	public float maxScore; // 0xD0
	public ArcadeEntity[] paddle1ScoreNodes; // 0xD8
	public ArcadeEntity[] paddle2ScoreNodes; // 0xE0
	public int paddle1Score; // 0xE8
	public int paddle2Score; // 0xEC
	public float sensitivity; // 0xF0
	public ArcadeEntity logo; // 0xF8
	public bool OnMainMenu; // 0x100
	public bool GameActive; // 0x101
	private float paddleMoveSpeed; // 0x104
	private float lastInputTime; // 0x108
	private float lastHeight; // 0x10C
	private float lastAIHeight; // 0x110

	// Methods

	// RVA: 0x1135750 Offset: 0x1133D50 VA: 0x181135750 Slot: 6
	public override void OnNoHost() { }

	// RVA: 0x11354C0 Offset: 0x1133AC0 VA: 0x1811354C0
	public void MainMenu() { }

	// RVA: 0x1134EF0 Offset: 0x11334F0 VA: 0x181134EF0
	public void FixedUpdate() { }

	// RVA: 0x1135D20 Offset: 0x1134320 VA: 0x181135D20
	public void UpdateScoreNodes() { }

	// RVA: 0x11353C0 Offset: 0x11339C0 VA: 0x1811353C0 Slot: 7
	public override void Initialize() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void PaddleInput(float amount, int paddleIndex) { }

	// RVA: 0x11351D0 Offset: 0x11337D0 VA: 0x1811351D0
	public void GameStart() { }

	// RVA: 0x1135BA0 Offset: 0x11341A0 VA: 0x181135BA0
	public void RoundStart() { }

	// RVA: 0x11357F0 Offset: 0x1133DF0 VA: 0x1811357F0 Slot: 9
	public override void PlayerInput(InputState inputState, BasePlayer player, int playerIndex = 0, bool clientside = False) { }

	// RVA: 0x1135E40 Offset: 0x1134440 VA: 0x181135E40
	public void .ctor() { }

}

