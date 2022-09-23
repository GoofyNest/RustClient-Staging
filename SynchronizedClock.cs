public class SynchronizedClock // TypeDefIndex: 13130
{
	public List<SynchronizedClock.TimedEvent> events; 

	private static float CurrentTime { get; }


	private static float get_CurrentTime() { }

	public void Add(float delta, float variance, Action<uint> action) { }

	public void Tick() { }

	public void .ctor() { }

}

public struct SynchronizedClock.TimedEvent // TypeDefIndex: 13131
{
	public float time; 
	public float delta; 
	public float variance; 
	public Action<uint> action; 

}

