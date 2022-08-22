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

	// RVA: 0x75CB30 Offset: 0x75B130 VA: 0x18075CB30
	private void Awake() { }

	// RVA: 0x75CB70 Offset: 0x75B170 VA: 0x18075CB70
	public void Refresh() { }

	// RVA: 0x75CB40 Offset: 0x75B140 VA: 0x18075CB40
	public void ForceUpdate() { }

	// RVA: 0x75CED0 Offset: 0x75B4D0 VA: 0x18075CED0
	public void UpdateText() { }

	// RVA: 0x75CFB0 Offset: 0x75B5B0 VA: 0x18075CFB0
	private void Update() { }

	// RVA: 0x75D030 Offset: 0x75B630 VA: 0x18075D030
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x75CEB0 Offset: 0x75B4B0 VA: 0x18075CEB0
	private bool <Refresh>b__14_0(GameStat.Stat x) { }

}

public struct GameStat.Stat // TypeDefIndex: 10931
{	// Fields
	public string statName; // 0x0
	public string statTitle; // 0x8

}

