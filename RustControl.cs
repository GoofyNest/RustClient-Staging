public class RustControl : UIBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler // TypeDefIndex: 7017
{	// Fields
	protected static bool IsDragging; // 0x0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected StyleAsset _styles; // 0x18
	public RustWrapper FormField; // 0x20
	[InspectorFlagsAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public RustControl.State CurrentState; // 0x28

	// Properties
	public virtual StyleAsset Styles { get; set; }
	public RectTransform rectTransform { get; }
	public virtual bool IsDisabled { get; }
	public virtual bool IsPressed { get; }
	public virtual bool IsHovered { get; }
	public virtual StyleAsset.Group CurrentStyleCollection { get; }

	// Methods

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 19
	public virtual StyleAsset get_Styles() { }

	// RVA: 0xFCBE70 Offset: 0xFCA470 VA: 0x180FCBE70 Slot: 20
	public virtual void set_Styles(StyleAsset value) { }

	// RVA: 0xFCBB80 Offset: 0xFCA180 VA: 0x180FCBB80 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0xFCBE10 Offset: 0xFCA410 VA: 0x180FCBE10
	public RectTransform get_rectTransform() { }

	// RVA: 0xFCBBB0 Offset: 0xFCA1B0 VA: 0x180FCBBB0 Slot: 21
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0xFCBBD0 Offset: 0xFCA1D0 VA: 0x180FCBBD0 Slot: 22
	public virtual void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0xFCBBF0 Offset: 0xFCA1F0 VA: 0x180FCBBF0 Slot: 23
	public virtual void SetDisabled(bool value) { }

	// RVA: 0xFCBC50 Offset: 0xFCA250 VA: 0x180FCBC50 Slot: 24
	public virtual void SetPressed(bool value) { }

	// RVA: 0xFCBDE0 Offset: 0xFCA3E0 VA: 0x180FCBDE0 Slot: 25
	public virtual bool get_IsDisabled() { }

	// RVA: 0xFCBE00 Offset: 0xFCA400 VA: 0x180FCBE00 Slot: 26
	public virtual bool get_IsPressed() { }

	// RVA: 0xFCBDF0 Offset: 0xFCA3F0 VA: 0x180FCBDF0 Slot: 27
	public virtual bool get_IsHovered() { }

	// RVA: 0xFCBCB0 Offset: 0xFCA2B0 VA: 0x180FCBCB0 Slot: 28
	public virtual StyleAsset.Group get_CurrentStyleCollection() { }

	// RVA: 0xFCBAD0 Offset: 0xFCA0D0 VA: 0x180FCBAD0 Slot: 29
	public virtual void ApplyStyles() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 30
	protected virtual void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

public enum RustControl.State // TypeDefIndex: 7018
{	// Fields
	public int value__; // 0x0
	public const RustControl.State Normal = 1;
	public const RustControl.State Hovered = 2;
	public const RustControl.State Pressed = 4;
	public const RustControl.State Active = 8;
	public const RustControl.State Disabled = 16;

}

