public class MusicChangeIntensity : MonoBehaviour // TypeDefIndex: 8999
{	// Fields
	public float raiseTo; // 0x18
	public List<MusicChangeIntensity.DistanceIntensity> distanceIntensities; // 0x20
	public float tickInterval; // 0x28
	private float lastTick; // 0x2C

	// Methods

	// RVA: 0x7DB9E0 Offset: 0x7D9FE0 VA: 0x1807DB9E0
	private void OnEnable() { }

	// RVA: 0x7DBD50 Offset: 0x7DA350 VA: 0x1807DBD50
	private void Update() { }

	// RVA: 0x7DBA10 Offset: 0x7DA010 VA: 0x1807DBA10
	private void Tick() { }

	// RVA: 0x7DBDA0 Offset: 0x7DA3A0 VA: 0x1807DBDA0
	public void .ctor() { }

}

public class MusicChangeIntensity.DistanceIntensity // TypeDefIndex: 9000
{	// Fields
	public float distance; // 0x10
	public float raiseTo; // 0x14
	public bool forceStartMusicInSuppressedMusicZones; // 0x18

	// Methods

	// RVA: 0x7D3BF0 Offset: 0x7D21F0 VA: 0x1807D3BF0
	public void .ctor() { }

}

