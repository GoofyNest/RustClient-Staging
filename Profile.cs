public class Profile // TypeDefIndex: 9376
{	public Stopwatch watch; // 0x10
	public string category; // 0x18
	public string name; // 0x20
	public float warnTime; // 0x28


	public void .ctor(string cat, string nam, float WarnTime = 1) { }

	public void Start() { }

	public void Stop() { }

}

public class Profile : ConsoleSystem // TypeDefIndex: 11957
{
	private static void NeedProfileFolder() { }

	[ClientVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	[ServerVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	public static void start(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	public static void stop(ConsoleSystem.Arg arg) { }

	public void .ctor() { }

}

