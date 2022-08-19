public class LocalClock // TypeDefIndex: 11386
{	// Fields
	public List<LocalClock.TimedEvent> events; // 0x10

	// Methods

	// RVA: 0x4FACD0 Offset: 0x4F92D0 VA: 0x1804FACD0
	public void Add(float delta, float variance, Action action) { }

	// RVA: 0x4FADC0 Offset: 0x4F93C0 VA: 0x1804FADC0
	public void Tick() { }

	// RVA: 0x4FAF50 Offset: 0x4F9550 VA: 0x1804FAF50
	public void .ctor() { }

}

public struct LocalClock.TimedEvent // TypeDefIndex: 11387
{	// Fields
	public float time; // 0x0
	public float delta; // 0x4
	public float variance; // 0x8
	public Action action; // 0x10

}

