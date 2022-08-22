public class Profile // TypeDefIndex: 9376
{	// Fields
	public Stopwatch watch; // 0x10
	public string category; // 0x18
	public string name; // 0x20
	public float warnTime; // 0x28

	// Methods

	// RVA: 0x6921D0 Offset: 0x6907D0 VA: 0x1806921D0
	public void .ctor(string cat, string nam, float WarnTime = 1) { }

	// RVA: 0x691E30 Offset: 0x690430 VA: 0x180691E30
	public void Start() { }

	// RVA: 0x691E70 Offset: 0x690470 VA: 0x180691E70
	public void Stop() { }

}

public class Profile : ConsoleSystem // TypeDefIndex: 11957
{	// Methods

	// RVA: 0x36A4A0 Offset: 0x368AA0 VA: 0x18036A4A0
	private static void NeedProfileFolder() { }

	[ClientVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	[ServerVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void start(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void stop(ConsoleSystem.Arg arg) { }

	// RVA: 0x36A4F0 Offset: 0x368AF0 VA: 0x18036A4F0
	public void .ctor() { }

}

