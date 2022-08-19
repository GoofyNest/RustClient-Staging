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

	// RVA: 0x537D50 Offset: 0x536350 VA: 0x180537D50 Slot: 7
	public override void Initialize() { }

	// RVA: 0x537FD0 Offset: 0x5365D0 VA: 0x180537FD0 Slot: 6
	public override void OnNoHost() { }

	// RVA: 0x537920 Offset: 0x535F20 VA: 0x180537920
	public void DestroyNonMapEntites() { }

	// RVA: 0x537D70 Offset: 0x536370 VA: 0x180537D70
	public void MainMenu() { }

	// RVA: 0x538C40 Offset: 0x537240 VA: 0x180538C40
	public void SetLevel(int newLevel) { }

	// RVA: 0x5394C0 Offset: 0x537AC0 VA: 0x1805394C0
	public void StartGame() { }

	// RVA: 0x537880 Offset: 0x535E80 VA: 0x180537880
	public void BossKilled(ChippyBoss killed) { }

	// RVA: 0x539180 Offset: 0x537780 VA: 0x180539180
	public void SpawnEnemies() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void FixedUpdate() { }

	// RVA: 0x537C90 Offset: 0x536290 VA: 0x180537C90
	public void GameOver() { }

	// RVA: 0x538CC0 Offset: 0x5372C0 VA: 0x180538CC0
	public void SetMenuVisible(bool isVisible) { }

	// RVA: 0x537F50 Offset: 0x536550 VA: 0x180537F50 Slot: 8
	public override void MenuAction(string message) { }

	// RVA: 0x539690 Offset: 0x537C90 VA: 0x180539690
	public void UpdateMenuButtons() { }

	// RVA: 0x538BA0 Offset: 0x5371A0 VA: 0x180538BA0
	public void SelectNextButton(int dir) { }

	// RVA: 0x538DD0 Offset: 0x5373D0 VA: 0x180538DD0
	public void SetScoresVisible(bool wantsVis) { }

	// RVA: 0x538040 Offset: 0x536640 VA: 0x180538040 Slot: 9
	public override void PlayerInput(InputState inputState, BasePlayer player, int playerIndex = 0, bool clientside = False) { }

	// RVA: 0x539720 Offset: 0x537D20 VA: 0x180539720
	public void .ctor() { }

}

