public class LocalClock // TypeDefIndex: 11386
{	// Fields
	public List<LocalClock.TimedEvent> events; // 0x10

	// Methods

	// RVA: 0x4FAC60 Offset: 0x4F9260 VA: 0x1804FAC60
	public void Add(float delta, float variance, Action action) { }

	// RVA: 0x4FAD50 Offset: 0x4F9350 VA: 0x1804FAD50
	public void Tick() { }

	// RVA: 0x4FAEE0 Offset: 0x4F94E0 VA: 0x1804FAEE0
	public void .ctor() { }

}

public struct LocalClock.TimedEvent // TypeDefIndex: 11387
{	// Fields
	public float time; // 0x0
	public float delta; // 0x4
	public float variance; // 0x8
	public Action action; // 0x10

}

