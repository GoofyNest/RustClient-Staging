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

	// RVA: 0x1608080 Offset: 0x1606680 VA: 0x181608080
	public static long GetTimestamp() { }

	// RVA: 0x1732280 Offset: 0x1730880 VA: 0x181732280
	public static Stopwatch StartNew() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x17326D0 Offset: 0x1730CD0 VA: 0x1817326D0
	public TimeSpan get_Elapsed() { }

	// RVA: 0x1732450 Offset: 0x1730A50 VA: 0x181732450
	public long get_ElapsedMilliseconds() { }

	// RVA: 0x1732660 Offset: 0x1730C60 VA: 0x181732660
	public long get_ElapsedTicks() { }

	// RVA: 0x1732210 Offset: 0x1730810 VA: 0x181732210
	public void Reset() { }

	// RVA: 0x1732320 Offset: 0x1730920 VA: 0x181732320
	public void Start() { }

	// RVA: 0x1732380 Offset: 0x1730980 VA: 0x181732380
	public void Stop() { }

	// RVA: 0x1732220 Offset: 0x1730820 VA: 0x181732220
	public void Restart() { }

	// RVA: 0x1732400 Offset: 0x1730A00 VA: 0x181732400
	private static void .cctor() { }

}

