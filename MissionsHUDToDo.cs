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

	// RVA: 0x7691F0 Offset: 0x7677F0 VA: 0x1807691F0
	public void MissionsUpdated() { }

	// RVA: 0x769480 Offset: 0x767A80 VA: 0x180769480
	internal void Unlock() { }

	// RVA: 0x768ED0 Offset: 0x7674D0 VA: 0x180768ED0
	internal void Init(BaseMission.MissionObjectiveEntry missionObjective, int newIndex) { }

	// RVA: 0x769440 Offset: 0x767A40 VA: 0x180769440
	internal void Shutdown() { }

	// RVA: 0x769760 Offset: 0x767D60 VA: 0x180769760
	private void UpdateState() { }

	// RVA: 0x769890 Offset: 0x767E90 VA: 0x180769890
	public void .ctor() { }

}

