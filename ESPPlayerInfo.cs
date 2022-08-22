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
	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	public BasePlayer get_Entity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574400 Offset: 0x572A00 VA: 0x180574400
	public void set_Entity(BasePlayer value) { }

	// RVA: 0x783DA0 Offset: 0x7823A0 VA: 0x180783DA0
	public void Clear() { }

	// RVA: 0x784080 Offset: 0x782680 VA: 0x180784080
	internal void Init(BasePlayer entity) { }

	// RVA: 0x785D30 Offset: 0x784330 VA: 0x180785D30
	private void UpdateText(BasePlayer entity) { }

	// RVA: 0x784B50 Offset: 0x783150 VA: 0x180784B50
	private void SetColor(Color color) { }

	// RVA: 0x785F20 Offset: 0x784520 VA: 0x180785F20
	private void Update() { }

	// RVA: 0x784610 Offset: 0x782C10 VA: 0x180784610
	private void LateQueuedUpdate() { }

	// RVA: 0x783EB0 Offset: 0x7824B0 VA: 0x180783EB0
	public Vector3 GetVisCheckPosition() { }

	// RVA: 0x785FF0 Offset: 0x7845F0 VA: 0x180785FF0
	public void VisCheckPosition() { }

	// RVA: 0x7843E0 Offset: 0x7829E0 VA: 0x1807843E0
	public bool IsTeamMember() { }

	// RVA: 0x784C60 Offset: 0x783260 VA: 0x180784C60
	public void SetTextEnabled(bool wantsOn) { }

	// RVA: 0x7841C0 Offset: 0x7827C0 VA: 0x1807841C0
	private bool IsAlly() { }

	// RVA: 0x7842C0 Offset: 0x7828C0 VA: 0x1807842C0
	private bool IsEnemy() { }

	// RVA: 0x784C80 Offset: 0x783280 VA: 0x180784C80
	private void UpdateColor() { }

	// RVA: 0x784700 Offset: 0x782D00 VA: 0x180784700
	private void Position() { }

	// RVA: 0x786140 Offset: 0x784740 VA: 0x180786140
	public void .ctor() { }

	// RVA: 0x7860B0 Offset: 0x7846B0 VA: 0x1807860B0
	private static void .cctor() { }

}

public class ESPPlayerInfo.ESPWorkQueue : ObjectWorkQueue<ESPPlayerInfo> // TypeDefIndex: 12007
{	// Methods

	// RVA: 0x786180 Offset: 0x784780 VA: 0x180786180 Slot: 6
	protected override void RunJob(ESPPlayerInfo entity) { }

	// RVA: 0x786290 Offset: 0x784890 VA: 0x180786290 Slot: 5
	protected override bool ShouldAdd(ESPPlayerInfo entity) { }

	// RVA: 0x786330 Offset: 0x784930 VA: 0x180786330
	public void .ctor() { }

}

