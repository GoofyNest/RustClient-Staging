public class MissionsHUDToDo : BaseMonoBehaviour // TypeDefIndex: 11186
{	// Fields
	public Text text; // 0x18
	public RectTransform checkIcon; // 0x20
	public RectTransform checkBox; // 0x28
	public Color AliveColor; // 0x30
	public Color DeadColor; // 0x40
	public Color HighlightColor; // 0x50
	private int index; // 0x60
	internal bool State; // 0x64

	// Methods

	// RVA: 0x769250 Offset: 0x767850 VA: 0x180769250
	public void MissionsUpdated() { }

	// RVA: 0x7694E0 Offset: 0x767AE0 VA: 0x1807694E0
	internal void Unlock() { }

	// RVA: 0x768F30 Offset: 0x767530 VA: 0x180768F30
	internal void Init(BaseMission.MissionObjectiveEntry missionObjective, int newIndex) { }

	// RVA: 0x7694A0 Offset: 0x767AA0 VA: 0x1807694A0
	internal void Shutdown() { }

	// RVA: 0x7697C0 Offset: 0x767DC0 VA: 0x1807697C0
	private void UpdateState() { }

	// RVA: 0x7698F0 Offset: 0x767EF0 VA: 0x1807698F0
	public void .ctor() { }

}

