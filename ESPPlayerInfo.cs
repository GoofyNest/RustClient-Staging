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

	// RVA: 0x783C90 Offset: 0x782290 VA: 0x180783C90
	public void Clear() { }

	// RVA: 0x783F70 Offset: 0x782570 VA: 0x180783F70
	internal void Init(BasePlayer entity) { }

	// RVA: 0x785C20 Offset: 0x784220 VA: 0x180785C20
	private void UpdateText(BasePlayer entity) { }

	// RVA: 0x784A40 Offset: 0x783040 VA: 0x180784A40
	private void SetColor(Color color) { }

	// RVA: 0x785E10 Offset: 0x784410 VA: 0x180785E10
	private void Update() { }

	// RVA: 0x784500 Offset: 0x782B00 VA: 0x180784500
	private void LateQueuedUpdate() { }

	// RVA: 0x783DA0 Offset: 0x7823A0 VA: 0x180783DA0
	public Vector3 GetVisCheckPosition() { }

	// RVA: 0x785EE0 Offset: 0x7844E0 VA: 0x180785EE0
	public void VisCheckPosition() { }

	// RVA: 0x7842D0 Offset: 0x7828D0 VA: 0x1807842D0
	public bool IsTeamMember() { }

	// RVA: 0x784B50 Offset: 0x783150 VA: 0x180784B50
	public void SetTextEnabled(bool wantsOn) { }

	// RVA: 0x7840B0 Offset: 0x7826B0 VA: 0x1807840B0
	private bool IsAlly() { }

	// RVA: 0x7841B0 Offset: 0x7827B0 VA: 0x1807841B0
	private bool IsEnemy() { }

	// RVA: 0x784B70 Offset: 0x783170 VA: 0x180784B70
	private void UpdateColor() { }

	// RVA: 0x7845F0 Offset: 0x782BF0 VA: 0x1807845F0
	private void Position() { }

	// RVA: 0x786030 Offset: 0x784630 VA: 0x180786030
	public void .ctor() { }

	// RVA: 0x785FA0 Offset: 0x7845A0 VA: 0x180785FA0
	private static void .cctor() { }

}

public class ESPPlayerInfo.ESPWorkQueue : ObjectWorkQueue<ESPPlayerInfo> // TypeDefIndex: 12007
{	// Methods

	// RVA: 0x786070 Offset: 0x784670 VA: 0x180786070 Slot: 6
	protected override void RunJob(ESPPlayerInfo entity) { }

	// RVA: 0x786180 Offset: 0x784780 VA: 0x180786180 Slot: 5
	protected override bool ShouldAdd(ESPPlayerInfo entity) { }

	// RVA: 0x786220 Offset: 0x784820 VA: 0x180786220
	public void .ctor() { }

}

