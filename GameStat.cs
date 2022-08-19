public class GameStat : MonoBehaviour // TypeDefIndex: 10930
{	// Fields
	public float refreshTime; // 0x18
	public Text title; // 0x20
	public Text globalStat; // 0x28
	public Text localStat; // 0x30
	private long globalValue; // 0x38
	private long localValue; // 0x40
	private float secondsSinceRefresh; // 0x48
	private float secondsUntilUpdate; // 0x4C
	private float secondsUntilChange; // 0x50
	public GameStat.Stat[] stats; // 0x58
	private GameStat.Stat[] unshownStats; // 0x60
	private GameStat.Stat stat; // 0x68

	// Methods

	// RVA: 0x75CAD0 Offset: 0x75B0D0 VA: 0x18075CAD0
	private void Awake() { }

	// RVA: 0x75CB10 Offset: 0x75B110 VA: 0x18075CB10
	public void Refresh() { }

	// RVA: 0x75CAE0 Offset: 0x75B0E0 VA: 0x18075CAE0
	public void ForceUpdate() { }

	// RVA: 0x75CE70 Offset: 0x75B470 VA: 0x18075CE70
	public void UpdateText() { }

	// RVA: 0x75CF50 Offset: 0x75B550 VA: 0x18075CF50
	private void Update() { }

	// RVA: 0x75CFD0 Offset: 0x75B5D0 VA: 0x18075CFD0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x75CE50 Offset: 0x75B450 VA: 0x18075CE50
	private bool <Refresh>b__14_0(GameStat.Stat x) { }

}

public struct GameStat.Stat // TypeDefIndex: 10931
{	// Fields
	public string statName; // 0x0
	public string statTitle; // 0x8

}

