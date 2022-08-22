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

	// RVA: 0x1135A10 Offset: 0x1134010 VA: 0x181135A10 Slot: 6
	public override void OnNoHost() { }

	// RVA: 0x1135780 Offset: 0x1133D80 VA: 0x181135780
	public void MainMenu() { }

	// RVA: 0x11351B0 Offset: 0x11337B0 VA: 0x1811351B0
	public void FixedUpdate() { }

	// RVA: 0x1135FE0 Offset: 0x11345E0 VA: 0x181135FE0
	public void UpdateScoreNodes() { }

	// RVA: 0x1135680 Offset: 0x1133C80 VA: 0x181135680 Slot: 7
	public override void Initialize() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void PaddleInput(float amount, int paddleIndex) { }

	// RVA: 0x1135490 Offset: 0x1133A90 VA: 0x181135490
	public void GameStart() { }

	// RVA: 0x1135E60 Offset: 0x1134460 VA: 0x181135E60
	public void RoundStart() { }

	// RVA: 0x1135AB0 Offset: 0x11340B0 VA: 0x181135AB0 Slot: 9
	public override void PlayerInput(InputState inputState, BasePlayer player, int playerIndex = 0, bool clientside = False) { }

	// RVA: 0x1136100 Offset: 0x1134700 VA: 0x181136100
	public void .ctor() { }

}

