public class Profile // TypeDefIndex: 9376
{	public Stopwatch watch; // 0x10
	public string category; // 0x18
	public string name; // 0x20
	public float warnTime; // 0x28


	public void .ctor(string cat, string nam, float WarnTime = 1) { }

	public void Start() { }

	public void Stop() { }

}

public class Profile : ConsoleSystem // TypeDefIndex: 11961
{
	private static void NeedProfileFolder() { }

	[ClientVar] // RVA: 0x93230 Offset: 0x92630 VA: 0x180093230
	[ServerVar] // RVA: 0x93230 Offset: 0x92630 VA: 0x180093230
	public static void start(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	[ClientVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	public static void stop(ConsoleSystem.Arg arg) { }

	public void .ctor() { }

}

