public class AchievementTodo : BaseMonoBehaviour // TypeDefIndex: 10822
{	// Fields
	public Text text; // 0x18
	public RectTransform checkIcon; // 0x20
	public RectTransform checkBox; // 0x28
	public Color AliveColor; // 0x30
	public Color DeadColor; // 0x40
	public Color HighlightColor; // 0x50
	private AchievementGroup.AchievementItem Item; // 0x60
	internal bool State; // 0x68

	// Methods

	// RVA: 0xA99000 Offset: 0xA97600 VA: 0x180A99000
	private void Awake() { }

	// RVA: 0xA99260 Offset: 0xA97860 VA: 0x180A99260
	private void OnAchievementStateChanged(Achievement ach, int currentProgress, int progress) { }

	// RVA: 0xA99320 Offset: 0xA97920 VA: 0x180A99320
	internal void Unlock() { }

	// RVA: 0xA99070 Offset: 0xA97670 VA: 0x180A99070
	internal void Init(AchievementGroup.AchievementItem item) { }

	// RVA: 0xA99600 Offset: 0xA97C00 VA: 0x180A99600
	private void UpdateState() { }

	// RVA: 0x521BF0 Offset: 0x5201F0 VA: 0x180521BF0
	public void .ctor() { }

}

