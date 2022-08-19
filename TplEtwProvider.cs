internal class TplEtwProvider : EventSource // TypeDefIndex: 1594
{	// Fields
	public static TplEtwProvider Log; // 0x1415A

	// Properties
	public bool Debug { get; }

	// Methods

	// RVA: 0x10E6FA0 Offset: 0x10E55A0 VA: 0x1810E6FA0
	public bool get_Debug() { }

	// RVA: 0x10E6D90 Offset: 0x10E5390 VA: 0x1810E6D90
	public void DebugFacilityMessage(string Facility, string Message) { }

	// RVA: 0x10E6D60 Offset: 0x10E5360 VA: 0x1810E6D60
	public void DebugFacilityMessage1(string Facility, string Message, string Arg) { }

	// RVA: 0x10E6DC0 Offset: 0x10E53C0 VA: 0x1810E6DC0
	public void SetActivityId(Guid Id) { }

	// RVA: 0x10E6F40 Offset: 0x10E5540 VA: 0x1810E6F40
	public void .ctor() { }

	// RVA: 0x10E6EA0 Offset: 0x10E54A0 VA: 0x1810E6EA0
	private static void .cctor() { }

}

public class TplEtwProvider.Keywords // TypeDefIndex: 1595
{	// Fields
	public const EventKeywords Debug = 1;

}

