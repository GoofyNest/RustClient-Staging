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

	// RVA: 0x1136480 Offset: 0x1134A80 VA: 0x181136480 Slot: 6
	public override void OnNoHost() { }

	// RVA: 0x11361F0 Offset: 0x11347F0 VA: 0x1811361F0
	public void MainMenu() { }

	// RVA: 0x1135C20 Offset: 0x1134220 VA: 0x181135C20
	public void FixedUpdate() { }

	// RVA: 0x1136A50 Offset: 0x1135050 VA: 0x181136A50
	public void UpdateScoreNodes() { }

	// RVA: 0x11360F0 Offset: 0x11346F0 VA: 0x1811360F0 Slot: 7
	public override void Initialize() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void PaddleInput(float amount, int paddleIndex) { }

	// RVA: 0x1135F00 Offset: 0x1134500 VA: 0x181135F00
	public void GameStart() { }

	// RVA: 0x11368D0 Offset: 0x1134ED0 VA: 0x1811368D0
	public void RoundStart() { }

	// RVA: 0x1136520 Offset: 0x1134B20 VA: 0x181136520 Slot: 9
	public override void PlayerInput(InputState inputState, BasePlayer player, int playerIndex = 0, bool clientside = False) { }

	// RVA: 0x1136B70 Offset: 0x1135170 VA: 0x181136B70
	public void .ctor() { }

}

