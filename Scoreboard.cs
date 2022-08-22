public class Scoreboard : MonoBehaviour, IClientComponent // TypeDefIndex: 11216
{	// Fields
	public static Scoreboard instance; // 0x0
	public RustText scoreboardTitle; // 0x18
	public RectTransform scoreboardRootContents; // 0x20
	public RustText scoreLimitText; // 0x28
	public GameObject teamPrefab; // 0x30
	public GameObject columnPrefab; // 0x38
	public GameObject dividerPrefab; // 0x40
	public Color localPlayerColor; // 0x48
	public Color otherPlayerColor; // 0x58
	public Scoreboard.TeamColumn[] teamColumns; // 0x68
	public GameObject[] TeamPanels; // 0x70
	private GameObject divider; // 0x78
	private bool dirty; // 0x80

	// Methods

	// RVA: 0x4A10C0 Offset: 0x49F6C0 VA: 0x1804A10C0
	private void Awake() { }

	// RVA: 0x4A1360 Offset: 0x49F960 VA: 0x1804A1360
	public static void ForceScoreboardUpdate() { }

	// RVA: 0x4A1F70 Offset: 0x4A0570 VA: 0x1804A1F70
	public static void UpdateScoreboard() { }

	// RVA: 0x4A1530 Offset: 0x49FB30 VA: 0x1804A1530
	public void OnToggle(bool isShowing) { }

	// RVA: 0x4A1450 Offset: 0x49FA50 VA: 0x1804A1450
	private static void OnDisconnected() { }

	// RVA: 0x4A1250 Offset: 0x49F850 VA: 0x1804A1250
	public void ClearTeamContents() { }

	// RVA: 0x4A15B0 Offset: 0x49FBB0 VA: 0x1804A15B0
	public void RebuildScoreboard() { }

	// RVA: 0x4A20E0 Offset: 0x4A06E0 VA: 0x1804A20E0
	public void UpdateScoreboard(bool rebuild = False) { }

	// RVA: 0x4A2930 Offset: 0x4A0F30 VA: 0x1804A2930
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

public class Scoreboard.TeamColumn // TypeDefIndex: 11217
{	// Fields
	public GameObject nameColumn; // 0x10
	public GameObject[] activeColumns; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

