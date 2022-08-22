public class MissionUIPanel : MonoBehaviour // TypeDefIndex: 10218
{	// Fields
	public GameObject activeMissionParent; // 0x18
	public RustText missionTitleText; // 0x20
	public RustText missionDescText; // 0x28
	public VirtualItemIcon[] rewardIcons; // 0x30
	public Translate.Phrase noMissionText; // 0x38
	private static MissionUIPanel instance; // 0x0
	private bool dirty; // 0x40

	// Methods

	// RVA: 0x768530 Offset: 0x766B30 VA: 0x180768530
	public void Awake() { }

	// RVA: 0x768D40 Offset: 0x767340 VA: 0x180768D40
	public void OnDestroy() { }

	// RVA: 0x768AF0 Offset: 0x7670F0 VA: 0x180768AF0
	public static void MissionsUpdated() { }

	// RVA: 0x768AC0 Offset: 0x7670C0 VA: 0x180768AC0
	public bool IsOpen() { }

	// RVA: 0x768DD0 Offset: 0x7673D0 VA: 0x180768DD0
	public void Open() { }

	// RVA: 0x4E6380 Offset: 0x4E4980 VA: 0x1804E6380
	public void Close() { }

	// RVA: 0x768580 Offset: 0x766B80 VA: 0x180768580
	public void Clear() { }

	// RVA: 0x768420 Offset: 0x766A20 VA: 0x180768420
	public void AbandonMission() { }

	// RVA: 0x768690 Offset: 0x766C90 VA: 0x180768690
	public void DoUpdate() { }

	// RVA: 0x768F20 Offset: 0x767520 VA: 0x180768F20
	public void .ctor() { }

}

