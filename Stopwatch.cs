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

	// RVA: 0x161AAA0 Offset: 0x16190A0 VA: 0x18161AAA0
	public static long GetTimestamp() { }

	// RVA: 0x1734400 Offset: 0x1732A00 VA: 0x181734400
	public static Stopwatch StartNew() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1734850 Offset: 0x1732E50 VA: 0x181734850
	public TimeSpan get_Elapsed() { }

	// RVA: 0x17345D0 Offset: 0x1732BD0 VA: 0x1817345D0
	public long get_ElapsedMilliseconds() { }

	// RVA: 0x17347E0 Offset: 0x1732DE0 VA: 0x1817347E0
	public long get_ElapsedTicks() { }

	// RVA: 0x1734390 Offset: 0x1732990 VA: 0x181734390
	public void Reset() { }

	// RVA: 0x17344A0 Offset: 0x1732AA0 VA: 0x1817344A0
	public void Start() { }

	// RVA: 0x1734500 Offset: 0x1732B00 VA: 0x181734500
	public void Stop() { }

	// RVA: 0x17343A0 Offset: 0x17329A0 VA: 0x1817343A0
	public void Restart() { }

	// RVA: 0x1734580 Offset: 0x1732B80 VA: 0x181734580
	private static void .cctor() { }

}

