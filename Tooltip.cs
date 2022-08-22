public class Tooltip : BaseMonoBehaviour, IClientComponent, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler // TypeDefIndex: 11241
{	// Fields
	public static GameObject Current; // 0x0
	[TextAreaAttribute] // RVA: 0x721B0 Offset: 0x715B0 VA: 0x1800721B0
	public string Text; // 0x18
	public GameObject TooltipObject; // 0x20
	public string token; // 0x28

	// Properties
	public string english { get; }

	// Methods

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_english() { }

	// RVA: 0xA0A380 Offset: 0xA08980 VA: 0x180A0A380 Slot: 6
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0xA0A490 Offset: 0xA08A90 VA: 0x180A0A490
	public void OpenTooltip() { }

	// RVA: 0xA0A420 Offset: 0xA08A20 VA: 0x180A0A420 Slot: 7
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0xA0A2A0 Offset: 0xA088A0 VA: 0x180A0A2A0
	public static void KillTooltip() { }

	// RVA: 0xA0A150 Offset: 0xA08750 VA: 0x180A0A150
	private Canvas GetTopMostCanvas() { }

	// RVA: 0xA09DC0 Offset: 0xA083C0 VA: 0x180A09DC0
	private void CreateTextTooltip() { }

	// RVA: 0xA0A4B0 Offset: 0xA08AB0 VA: 0x180A0A4B0
	private static string ParseTokens(string text) { }

	// RVA: 0xA0A810 Offset: 0xA08E10 VA: 0x180A0A810
	public void .ctor() { }

}

