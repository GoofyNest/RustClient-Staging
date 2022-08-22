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

	// RVA: 0xA992C0 Offset: 0xA978C0 VA: 0x180A992C0
	private void Awake() { }

	// RVA: 0xA99520 Offset: 0xA97B20 VA: 0x180A99520
	private void OnAchievementStateChanged(Achievement ach, int currentProgress, int progress) { }

	// RVA: 0xA995E0 Offset: 0xA97BE0 VA: 0x180A995E0
	internal void Unlock() { }

	// RVA: 0xA99330 Offset: 0xA97930 VA: 0x180A99330
	internal void Init(AchievementGroup.AchievementItem item) { }

	// RVA: 0xA998C0 Offset: 0xA97EC0 VA: 0x180A998C0
	private void UpdateState() { }

	// RVA: 0x521BF0 Offset: 0x5201F0 VA: 0x180521BF0
	public void .ctor() { }

}

