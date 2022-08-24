public class SynchronizedClock // TypeDefIndex: 11407
{	public List<SynchronizedClock.TimedEvent> events; // 0x10

	private static float CurrentTime { get; }


	private static float get_CurrentTime() { }

	public void Add(float delta, float variance, Action<uint> action) { }

	public void Tick() { }

	public void .ctor() { }

}

public struct SynchronizedClock.TimedEvent // TypeDefIndex: 11408
{	public float time; // 0x0
	public float delta; // 0x4
	public float variance; // 0x8
	public Action<uint> action; // 0x10

}

