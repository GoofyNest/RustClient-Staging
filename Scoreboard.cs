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

	// RVA: 0x4A1130 Offset: 0x49F730 VA: 0x1804A1130
	private void Awake() { }

	// RVA: 0x4A13D0 Offset: 0x49F9D0 VA: 0x1804A13D0
	public static void ForceScoreboardUpdate() { }

	// RVA: 0x4A1FE0 Offset: 0x4A05E0 VA: 0x1804A1FE0
	public static void UpdateScoreboard() { }

	// RVA: 0x4A15A0 Offset: 0x49FBA0 VA: 0x1804A15A0
	public void OnToggle(bool isShowing) { }

	// RVA: 0x4A14C0 Offset: 0x49FAC0 VA: 0x1804A14C0
	private static void OnDisconnected() { }

	// RVA: 0x4A12C0 Offset: 0x49F8C0 VA: 0x1804A12C0
	public void ClearTeamContents() { }

	// RVA: 0x4A1620 Offset: 0x49FC20 VA: 0x1804A1620
	public void RebuildScoreboard() { }

	// RVA: 0x4A2150 Offset: 0x4A0750 VA: 0x1804A2150
	public void UpdateScoreboard(bool rebuild = False) { }

	// RVA: 0x4A29A0 Offset: 0x4A0FA0 VA: 0x1804A29A0
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

