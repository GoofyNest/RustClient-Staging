public class ChippyArcadeGame : BaseArcadeGame // TypeDefIndex: 8765
{	// Fields
	public ChippyMainCharacter mainChar; // 0x90
	public SpriteArcadeEntity mainCharAim; // 0x98
	public ChippyBoss currentBoss; // 0xA0
	public ChippyBoss[] bossPrefabs; // 0xA8
	public SpriteArcadeEntity mainMenuLogo; // 0xB0
	public Transform respawnPoint; // 0xB8
	public Vector2 mouseAim; // 0xC0
	public TextArcadeEntity levelIndicator; // 0xC8
	public TextArcadeEntity gameOverIndicator; // 0xD0
	public TextArcadeEntity playGameButton; // 0xD8
	public TextArcadeEntity highScoresButton; // 0xE0
	public bool OnMainMenu; // 0xE8
	public bool GameActive; // 0xE9
	public int level; // 0xEC
	public TextArcadeEntity[] scoreDisplays; // 0xF0
	public MenuButtonArcadeEntity[] mainMenuButtons; // 0xF8
	public int selectedButtonIndex; // 0x100
	public bool OnHighScores; // 0x104
	private float lastInputTime; // 0x108
	private float nextFireTime; // 0x10C
	private float nextClickTime; // 0x110

	// Methods

	// RVA: 0x537CE0 Offset: 0x5362E0 VA: 0x180537CE0 Slot: 7
	public override void Initialize() { }

	// RVA: 0x537F60 Offset: 0x536560 VA: 0x180537F60 Slot: 6
	public override void OnNoHost() { }

	// RVA: 0x5378B0 Offset: 0x535EB0 VA: 0x1805378B0
	public void DestroyNonMapEntites() { }

	// RVA: 0x537D00 Offset: 0x536300 VA: 0x180537D00
	public void MainMenu() { }

	// RVA: 0x538BD0 Offset: 0x5371D0 VA: 0x180538BD0
	public void SetLevel(int newLevel) { }

	// RVA: 0x539450 Offset: 0x537A50 VA: 0x180539450
	public void StartGame() { }

	// RVA: 0x537810 Offset: 0x535E10 VA: 0x180537810
	public void BossKilled(ChippyBoss killed) { }

	// RVA: 0x539110 Offset: 0x537710 VA: 0x180539110
	public void SpawnEnemies() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void FixedUpdate() { }

	// RVA: 0x537C20 Offset: 0x536220 VA: 0x180537C20
	public void GameOver() { }

	// RVA: 0x538C50 Offset: 0x537250 VA: 0x180538C50
	public void SetMenuVisible(bool isVisible) { }

	// RVA: 0x537EE0 Offset: 0x5364E0 VA: 0x180537EE0 Slot: 8
	public override void MenuAction(string message) { }

	// RVA: 0x539620 Offset: 0x537C20 VA: 0x180539620
	public void UpdateMenuButtons() { }

	// RVA: 0x538B30 Offset: 0x537130 VA: 0x180538B30
	public void SelectNextButton(int dir) { }

	// RVA: 0x538D60 Offset: 0x537360 VA: 0x180538D60
	public void SetScoresVisible(bool wantsVis) { }

	// RVA: 0x537FD0 Offset: 0x5365D0 VA: 0x180537FD0 Slot: 9
	public override void PlayerInput(InputState inputState, BasePlayer player, int playerIndex = 0, bool clientside = False) { }

	// RVA: 0x5396B0 Offset: 0x537CB0 VA: 0x1805396B0
	public void .ctor() { }

}

