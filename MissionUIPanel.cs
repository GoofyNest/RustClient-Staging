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

	// RVA: 0x7685E0 Offset: 0x766BE0 VA: 0x1807685E0
	public void Awake() { }

	// RVA: 0x768DF0 Offset: 0x7673F0 VA: 0x180768DF0
	public void OnDestroy() { }

	// RVA: 0x768BA0 Offset: 0x7671A0 VA: 0x180768BA0
	public static void MissionsUpdated() { }

	// RVA: 0x768B70 Offset: 0x767170 VA: 0x180768B70
	public bool IsOpen() { }

	// RVA: 0x768E80 Offset: 0x767480 VA: 0x180768E80
	public void Open() { }

	// RVA: 0x4E63F0 Offset: 0x4E49F0 VA: 0x1804E63F0
	public void Close() { }

	// RVA: 0x768630 Offset: 0x766C30 VA: 0x180768630
	public void Clear() { }

	// RVA: 0x7684D0 Offset: 0x766AD0 VA: 0x1807684D0
	public void AbandonMission() { }

	// RVA: 0x768740 Offset: 0x766D40 VA: 0x180768740
	public void DoUpdate() { }

	// RVA: 0x768FD0 Offset: 0x7675D0 VA: 0x180768FD0
	public void .ctor() { }

}

