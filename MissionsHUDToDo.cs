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

	// RVA: 0x769300 Offset: 0x767900 VA: 0x180769300
	public void MissionsUpdated() { }

	// RVA: 0x769590 Offset: 0x767B90 VA: 0x180769590
	internal void Unlock() { }

	// RVA: 0x768FE0 Offset: 0x7675E0 VA: 0x180768FE0
	internal void Init(BaseMission.MissionObjectiveEntry missionObjective, int newIndex) { }

	// RVA: 0x769550 Offset: 0x767B50 VA: 0x180769550
	internal void Shutdown() { }

	// RVA: 0x769870 Offset: 0x767E70 VA: 0x180769870
	private void UpdateState() { }

	// RVA: 0x7699A0 Offset: 0x767FA0 VA: 0x1807699A0
	public void .ctor() { }

}

