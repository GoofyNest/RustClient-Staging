public class Tooltip : BaseMonoBehaviour, IClientComponent, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler // TypeDefIndex: 11241
{	public static GameObject Current; // 0x0
	[TextAreaAttribute] // RVA: 0x721B0 Offset: 0x715B0 VA: 0x1800721B0
	public string Text; // 0x18
	public GameObject TooltipObject; // 0x20
	public string token; // 0x28

	public string english { get; }


	public string get_english() { }

	public void OnPointerEnter(PointerEventData eventData) { }

	public void OpenTooltip() { }

	public void OnPointerExit(PointerEventData eventData) { }

	public static void KillTooltip() { }

	private Canvas GetTopMostCanvas() { }

	private void CreateTextTooltip() { }

	private static string ParseTokens(string text) { }

	public void .ctor() { }

}

