public class SynchronizedClock // TypeDefIndex: 11403
{	// Fields
	public List<SynchronizedClock.TimedEvent> events; // 0x10

	// Properties
	private static float CurrentTime { get; }

	// Methods

	// RVA: 0x7C5740 Offset: 0x7C3D40 VA: 0x1807C5740
	private static float get_CurrentTime() { }

	// RVA: 0x7C5310 Offset: 0x7C3910 VA: 0x1807C5310
	public void Add(float delta, float variance, Action<uint> action) { }

	// RVA: 0x7C5410 Offset: 0x7C3A10 VA: 0x1807C5410
	public void Tick() { }

	// RVA: 0x7C56D0 Offset: 0x7C3CD0 VA: 0x1807C56D0
	public void .ctor() { }

}

public struct SynchronizedClock.TimedEvent // TypeDefIndex: 11404
{	// Fields
	public float time; // 0x0
	public float delta; // 0x4
	public float variance; // 0x8
	public Action<uint> action; // 0x10

}

