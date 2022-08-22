public class SynchronizedClock // TypeDefIndex: 11403
{	// Fields
	public List<SynchronizedClock.TimedEvent> events; // 0x10

	// Properties
	private static float CurrentTime { get; }

	// Methods

	// RVA: 0x7A7340 Offset: 0x7A5940 VA: 0x1807A7340
	private static float get_CurrentTime() { }

	// RVA: 0x7A6F10 Offset: 0x7A5510 VA: 0x1807A6F10
	public void Add(float delta, float variance, Action<uint> action) { }

	// RVA: 0x7A7010 Offset: 0x7A5610 VA: 0x1807A7010
	public void Tick() { }

	// RVA: 0x7A72D0 Offset: 0x7A58D0 VA: 0x1807A72D0
	public void .ctor() { }

}

public struct SynchronizedClock.TimedEvent // TypeDefIndex: 11404
{	// Fields
	public float time; // 0x0
	public float delta; // 0x4
	public float variance; // 0x8
	public Action<uint> action; // 0x10

}

