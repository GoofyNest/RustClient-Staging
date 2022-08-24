public class SynchronizedClock // TypeDefIndex: 11407
{
	public List<SynchronizedClock.TimedEvent> events; 

private static float CurrentTime { get; }


private static float get_CurrentTime() { }

public void Add(float delta, float variance, Action<uint> action) { }

public void Tick() { }

public void .ctor() { }

}

public struct SynchronizedClock.TimedEvent // TypeDefIndex: 11408
{
	public float time; 
	public float delta; 
	public float variance; 
	public Action<uint> action; 

}

