public class DropMe : MonoBehaviour, IDropHandler, IEventSystemHandler // TypeDefIndex: 11274
{	// Fields
	public string[] droppableTypes; // 0x18

	// Methods

	// RVA: 0xAB1AB0 Offset: 0xAB00B0 VA: 0x180AB1AB0
	public bool Accepts(DragMe drag) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void StopHighlight() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void StartHighlight() { }

	// RVA: 0xAB1D30 Offset: 0xAB0330 VA: 0x180AB1D30 Slot: 5
	public virtual void OnDrop(PointerEventData eventData) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}
