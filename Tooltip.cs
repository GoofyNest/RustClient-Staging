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

	// RVA: 0xA09E90 Offset: 0xA08490 VA: 0x180A09E90 Slot: 6
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0xA09FA0 Offset: 0xA085A0 VA: 0x180A09FA0
	public void OpenTooltip() { }

	// RVA: 0xA09F30 Offset: 0xA08530 VA: 0x180A09F30 Slot: 7
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0xA09DB0 Offset: 0xA083B0 VA: 0x180A09DB0
	public static void KillTooltip() { }

	// RVA: 0xA09C60 Offset: 0xA08260 VA: 0x180A09C60
	private Canvas GetTopMostCanvas() { }

	// RVA: 0xA098D0 Offset: 0xA07ED0 VA: 0x180A098D0
	private void CreateTextTooltip() { }

	// RVA: 0xA09FC0 Offset: 0xA085C0 VA: 0x180A09FC0
	private static string ParseTokens(string text) { }

	// RVA: 0xA0A320 Offset: 0xA08920 VA: 0x180A0A320
	public void .ctor() { }

}

