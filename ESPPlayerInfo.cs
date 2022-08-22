public class ESPPlayerInfo : MonoBehaviour // TypeDefIndex: 12006
{	// Fields
	public Vector3 WorldOffset; // 0x18
	public TextMeshProUGUI Text; // 0x28
	public TextMeshProUGUI Image; // 0x30
	public CanvasGroup group; // 0x38
	public Gradient gradientNormal; // 0x40
	public Gradient gradientTeam; // 0x48
	public Color TeamColor; // 0x50
	public Color AllyColor; // 0x60
	public Color EnemyColor; // 0x70
	public QueryVis visCheck; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private BasePlayer <Entity>k__BackingField; // 0x88
	[ClientVar] // RVA: 0xCBEB0 Offset: 0xCB2B0 VA: 0x1800CBEB0
	[HelpAttribute] // RVA: 0xCBEB0 Offset: 0xCB2B0 VA: 0x1800CBEB0
	public static float framebudgetms; // 0x0
	private bool inQueue; // 0x90
	public static ESPPlayerInfo.ESPWorkQueue workQueue; // 0x8
	private int numFramesVisible; // 0x94
	private float distanceFromCamera; // 0x98
	private TimeSince lastHealthUpdate; // 0x9C

	// Properties
	public BasePlayer Entity { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574300 Offset: 0x572900 VA: 0x180574300
	public BasePlayer get_Entity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574390 Offset: 0x572990 VA: 0x180574390
	public void set_Entity(BasePlayer value) { }

	// RVA: 0x783CF0 Offset: 0x7822F0 VA: 0x180783CF0
	public void Clear() { }

	// RVA: 0x783FD0 Offset: 0x7825D0 VA: 0x180783FD0
	internal void Init(BasePlayer entity) { }

	// RVA: 0x785C80 Offset: 0x784280 VA: 0x180785C80
	private void UpdateText(BasePlayer entity) { }

	// RVA: 0x784AA0 Offset: 0x7830A0 VA: 0x180784AA0
	private void SetColor(Color color) { }

	// RVA: 0x785E70 Offset: 0x784470 VA: 0x180785E70
	private void Update() { }

	// RVA: 0x784560 Offset: 0x782B60 VA: 0x180784560
	private void LateQueuedUpdate() { }

	// RVA: 0x783E00 Offset: 0x782400 VA: 0x180783E00
	public Vector3 GetVisCheckPosition() { }

	// RVA: 0x785F40 Offset: 0x784540 VA: 0x180785F40
	public void VisCheckPosition() { }

	// RVA: 0x784330 Offset: 0x782930 VA: 0x180784330
	public bool IsTeamMember() { }

	// RVA: 0x784BB0 Offset: 0x7831B0 VA: 0x180784BB0
	public void SetTextEnabled(bool wantsOn) { }

	// RVA: 0x784110 Offset: 0x782710 VA: 0x180784110
	private bool IsAlly() { }

	// RVA: 0x784210 Offset: 0x782810 VA: 0x180784210
	private bool IsEnemy() { }

	// RVA: 0x784BD0 Offset: 0x7831D0 VA: 0x180784BD0
	private void UpdateColor() { }

	// RVA: 0x784650 Offset: 0x782C50 VA: 0x180784650
	private void Position() { }

	// RVA: 0x786090 Offset: 0x784690 VA: 0x180786090
	public void .ctor() { }

	// RVA: 0x786000 Offset: 0x784600 VA: 0x180786000
	private static void .cctor() { }

}

public class ESPPlayerInfo.ESPWorkQueue : ObjectWorkQueue<ESPPlayerInfo> // TypeDefIndex: 12007
{	// Methods

	// RVA: 0x7860D0 Offset: 0x7846D0 VA: 0x1807860D0 Slot: 6
	protected override void RunJob(ESPPlayerInfo entity) { }

	// RVA: 0x7861E0 Offset: 0x7847E0 VA: 0x1807861E0 Slot: 5
	protected override bool ShouldAdd(ESPPlayerInfo entity) { }

	// RVA: 0x786280 Offset: 0x784880 VA: 0x180786280
	public void .ctor() { }

}

