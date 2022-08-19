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

	// RVA: 0x7684D0 Offset: 0x766AD0 VA: 0x1807684D0
	public void Awake() { }

	// RVA: 0x768CE0 Offset: 0x7672E0 VA: 0x180768CE0
	public void OnDestroy() { }

	// RVA: 0x768A90 Offset: 0x767090 VA: 0x180768A90
	public static void MissionsUpdated() { }

	// RVA: 0x768A60 Offset: 0x767060 VA: 0x180768A60
	public bool IsOpen() { }

	// RVA: 0x768D70 Offset: 0x767370 VA: 0x180768D70
	public void Open() { }

	// RVA: 0x4E63F0 Offset: 0x4E49F0 VA: 0x1804E63F0
	public void Close() { }

	// RVA: 0x768520 Offset: 0x766B20 VA: 0x180768520
	public void Clear() { }

	// RVA: 0x7683C0 Offset: 0x7669C0 VA: 0x1807683C0
	public void AbandonMission() { }

	// RVA: 0x768630 Offset: 0x766C30 VA: 0x180768630
	public void DoUpdate() { }

	// RVA: 0x768EC0 Offset: 0x7674C0 VA: 0x180768EC0
	public void .ctor() { }

}

