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

	// RVA: 0xA99790 Offset: 0xA97D90 VA: 0x180A99790
	private void Awake() { }

	// RVA: 0xA999F0 Offset: 0xA97FF0 VA: 0x180A999F0
	private void OnAchievementStateChanged(Achievement ach, int currentProgress, int progress) { }

	// RVA: 0xA99AB0 Offset: 0xA980B0 VA: 0x180A99AB0
	internal void Unlock() { }

	// RVA: 0xA99800 Offset: 0xA97E00 VA: 0x180A99800
	internal void Init(AchievementGroup.AchievementItem item) { }

	// RVA: 0xA99D90 Offset: 0xA98390 VA: 0x180A99D90
	private void UpdateState() { }

	// RVA: 0x521B80 Offset: 0x520180 VA: 0x180521B80
	public void .ctor() { }

}

