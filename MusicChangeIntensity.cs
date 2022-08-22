public class MusicChangeIntensity : MonoBehaviour // TypeDefIndex: 8999
{	// Fields
	public float raiseTo; // 0x18
	public List<MusicChangeIntensity.DistanceIntensity> distanceIntensities; // 0x20
	public float tickInterval; // 0x28
	private float lastTick; // 0x2C

	// Methods

	// RVA: 0x7BD5F0 Offset: 0x7BBBF0 VA: 0x1807BD5F0
	private void OnEnable() { }

	// RVA: 0x7BD960 Offset: 0x7BBF60 VA: 0x1807BD960
	private void Update() { }

	// RVA: 0x7BD620 Offset: 0x7BBC20 VA: 0x1807BD620
	private void Tick() { }

	// RVA: 0x7BD9B0 Offset: 0x7BBFB0 VA: 0x1807BD9B0
	public void .ctor() { }

}

public class MusicChangeIntensity.DistanceIntensity // TypeDefIndex: 9000
{	// Fields
	public float distance; // 0x10
	public float raiseTo; // 0x14
	public bool forceStartMusicInSuppressedMusicZones; // 0x18

	// Methods

	// RVA: 0x7B5800 Offset: 0x7B3E00 VA: 0x1807B5800
	public void .ctor() { }

}

