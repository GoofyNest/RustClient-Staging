public class SynchronizedClock // TypeDefIndex: 11403
{	// Fields
	public List<SynchronizedClock.TimedEvent> events; // 0x10

	// Properties
	private static float CurrentTime { get; }

	// Methods

	// RVA: 0x7A7230 Offset: 0x7A5830 VA: 0x1807A7230
	private static float get_CurrentTime() { }

	// RVA: 0x7A6E00 Offset: 0x7A5400 VA: 0x1807A6E00
	public void Add(float delta, float variance, Action<uint> action) { }

	// RVA: 0x7A6F00 Offset: 0x7A5500 VA: 0x1807A6F00
	public void Tick() { }

	// RVA: 0x7A71C0 Offset: 0x7A57C0 VA: 0x1807A71C0
	public void .ctor() { }

}

public struct SynchronizedClock.TimedEvent // TypeDefIndex: 11404
{	// Fields
	public float time; // 0x0
	public float delta; // 0x4
	public float variance; // 0x8
	public Action<uint> action; // 0x10

}

