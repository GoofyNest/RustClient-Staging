public class GameStat : MonoBehaviour // TypeDefIndex: 10934
{	public float refreshTime; // 0x18
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


	private void Awake() { }

	public void Refresh() { }

	public void ForceUpdate() { }

	public void UpdateText() { }

	private void Update() { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private bool <Refresh>b__14_0(GameStat.Stat x) { }

}

public struct GameStat.Stat // TypeDefIndex: 10935
{	public string statName; // 0x0
	public string statTitle; // 0x8

}

