public class Stopwatch // TypeDefIndex: 2657
{	// Fields
	public static readonly long Frequency; // 0x0
	public static readonly bool IsHighResolution; // 0x8
	private long elapsed; // 0x10
	private long started; // 0x18
	private bool is_running; // 0x20

	// Properties
	public TimeSpan Elapsed { get; }
	public long ElapsedMilliseconds { get; }
	public long ElapsedTicks { get; }

	// Methods

	// RVA: 0x161AD60 Offset: 0x1619360 VA: 0x18161AD60
	public static long GetTimestamp() { }

	// RVA: 0x17346C0 Offset: 0x1732CC0 VA: 0x1817346C0
	public static Stopwatch StartNew() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1734B10 Offset: 0x1733110 VA: 0x181734B10
	public TimeSpan get_Elapsed() { }

	// RVA: 0x1734890 Offset: 0x1732E90 VA: 0x181734890
	public long get_ElapsedMilliseconds() { }

	// RVA: 0x1734AA0 Offset: 0x17330A0 VA: 0x181734AA0
	public long get_ElapsedTicks() { }

	// RVA: 0x1734650 Offset: 0x1732C50 VA: 0x181734650
	public void Reset() { }

	// RVA: 0x1734760 Offset: 0x1732D60 VA: 0x181734760
	public void Start() { }

	// RVA: 0x17347C0 Offset: 0x1732DC0 VA: 0x1817347C0
	public void Stop() { }

	// RVA: 0x1734660 Offset: 0x1732C60 VA: 0x181734660
	public void Restart() { }

	// RVA: 0x1734840 Offset: 0x1732E40 VA: 0x181734840
	private static void .cctor() { }

}

