public class MusicChangeIntensity : MonoBehaviour // TypeDefIndex: 8999
{	// Fields
	public float raiseTo; // 0x18
	public List<MusicChangeIntensity.DistanceIntensity> distanceIntensities; // 0x20
	public float tickInterval; // 0x28
	private float lastTick; // 0x2C

	// Methods

	// RVA: 0x7BD4E0 Offset: 0x7BBAE0 VA: 0x1807BD4E0
	private void OnEnable() { }

	// RVA: 0x7BD850 Offset: 0x7BBE50 VA: 0x1807BD850
	private void Update() { }

	// RVA: 0x7BD510 Offset: 0x7BBB10 VA: 0x1807BD510
	private void Tick() { }

	// RVA: 0x7BD8A0 Offset: 0x7BBEA0 VA: 0x1807BD8A0
	public void .ctor() { }

}

public class MusicChangeIntensity.DistanceIntensity // TypeDefIndex: 9000
{	// Fields
	public float distance; // 0x10
	public float raiseTo; // 0x14
	public bool forceStartMusicInSuppressedMusicZones; // 0x18

	// Methods

	// RVA: 0x7B56F0 Offset: 0x7B3CF0 VA: 0x1807B56F0
	public void .ctor() { }

}

