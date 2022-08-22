internal class TplEtwProvider : EventSource // TypeDefIndex: 1594
{	// Fields
	public static TplEtwProvider Log; // 0x1415A

	// Properties
	public bool Debug { get; }

	// Methods

	// RVA: 0x10E7260 Offset: 0x10E5860 VA: 0x1810E7260
	public bool get_Debug() { }

	// RVA: 0x10E7050 Offset: 0x10E5650 VA: 0x1810E7050
	public void DebugFacilityMessage(string Facility, string Message) { }

	// RVA: 0x10E7020 Offset: 0x10E5620 VA: 0x1810E7020
	public void DebugFacilityMessage1(string Facility, string Message, string Arg) { }

	// RVA: 0x10E7080 Offset: 0x10E5680 VA: 0x1810E7080
	public void SetActivityId(Guid Id) { }

	// RVA: 0x10E7200 Offset: 0x10E5800 VA: 0x1810E7200
	public void .ctor() { }

	// RVA: 0x10E7160 Offset: 0x10E5760 VA: 0x1810E7160
	private static void .cctor() { }

}

public class TplEtwProvider.Keywords // TypeDefIndex: 1595
{	// Fields
	public const EventKeywords Debug = 1;

}

