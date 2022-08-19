public class Tooltip : BaseMonoBehaviour, IClientComponent, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler // TypeDefIndex: 11241
{	// Fields
	public static GameObject Current; // 0x0
	[TextAreaAttribute] // RVA: 0x72110 Offset: 0x71510 VA: 0x180072110
	public string Text; // 0x18
	public GameObject TooltipObject; // 0x20
	public string token; // 0x28

	// Properties
	public string english { get; }

	// Methods

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_english() { }

	// RVA: 0xA09BD0 Offset: 0xA081D0 VA: 0x180A09BD0 Slot: 6
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0xA09CE0 Offset: 0xA082E0 VA: 0x180A09CE0
	public void OpenTooltip() { }

	// RVA: 0xA09C70 Offset: 0xA08270 VA: 0x180A09C70 Slot: 7
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0xA09AF0 Offset: 0xA080F0 VA: 0x180A09AF0
	public static void KillTooltip() { }

	// RVA: 0xA099A0 Offset: 0xA07FA0 VA: 0x180A099A0
	private Canvas GetTopMostCanvas() { }

	// RVA: 0xA09610 Offset: 0xA07C10 VA: 0x180A09610
	private void CreateTextTooltip() { }

	// RVA: 0xA09D00 Offset: 0xA08300 VA: 0x180A09D00
	private static string ParseTokens(string text) { }

	// RVA: 0xA0A060 Offset: 0xA08660 VA: 0x180A0A060
	public void .ctor() { }

}

