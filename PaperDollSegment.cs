public class PaperDollSegment : BaseMonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler // TypeDefIndex: 11042
{	// Fields
	public static HitArea selectedAreas; // 0x0
	[InspectorFlagsAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public HitArea area; // 0x18
	public Image overlayImg; // 0x20

	// Methods

	// RVA: 0x85C010 Offset: 0x85A610 VA: 0x18085C010 Slot: 6
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x85C0E0 Offset: 0x85A6E0 VA: 0x18085C0E0 Slot: 7
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x85C1B0 Offset: 0x85A7B0 VA: 0x18085C1B0
	public void SetSegmentVisible(bool vis) { }

	// RVA: 0x521BF0 Offset: 0x5201F0 VA: 0x180521BF0
	public void .ctor() { }

}

