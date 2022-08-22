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

	// RVA: 0x75CBE0 Offset: 0x75B1E0 VA: 0x18075CBE0
	private void Awake() { }

	// RVA: 0x75CC20 Offset: 0x75B220 VA: 0x18075CC20
	public void Refresh() { }

	// RVA: 0x75CBF0 Offset: 0x75B1F0 VA: 0x18075CBF0
	public void ForceUpdate() { }

	// RVA: 0x75CF80 Offset: 0x75B580 VA: 0x18075CF80
	public void UpdateText() { }

	// RVA: 0x75D060 Offset: 0x75B660 VA: 0x18075D060
	private void Update() { }

	// RVA: 0x75D0E0 Offset: 0x75B6E0 VA: 0x18075D0E0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x75CF60 Offset: 0x75B560 VA: 0x18075CF60
	private bool <Refresh>b__14_0(GameStat.Stat x) { }

}

public struct GameStat.Stat // TypeDefIndex: 10931
{	// Fields
	public string statName; // 0x0
	public string statTitle; // 0x8

}

