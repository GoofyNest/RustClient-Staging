internal class TplEtwProvider : EventSource // TypeDefIndex: 1594
{	// Fields
	public static TplEtwProvider Log; // 0x13EE0

	// Properties
	public bool Debug { get; }

	// Methods

	// RVA: 0x10E7CD0 Offset: 0x10E62D0 VA: 0x1810E7CD0
	public bool get_Debug() { }

	// RVA: 0x10E7AC0 Offset: 0x10E60C0 VA: 0x1810E7AC0
	public void DebugFacilityMessage(string Facility, string Message) { }

	// RVA: 0x10E7A90 Offset: 0x10E6090 VA: 0x1810E7A90
	public void DebugFacilityMessage1(string Facility, string Message, string Arg) { }

	// RVA: 0x10E7AF0 Offset: 0x10E60F0 VA: 0x1810E7AF0
	public void SetActivityId(Guid Id) { }

	// RVA: 0x10E7C70 Offset: 0x10E6270 VA: 0x1810E7C70
	public void .ctor() { }

	// RVA: 0x10E7BD0 Offset: 0x10E61D0 VA: 0x1810E7BD0
	private static void .cctor() { }

}

public class TplEtwProvider.Keywords // TypeDefIndex: 1595
{	// Fields
	public const EventKeywords Debug = 1;

}

