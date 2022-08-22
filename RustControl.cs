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

	// RVA: 0xFCC910 Offset: 0xFCAF10 VA: 0x180FCC910 Slot: 20
	public virtual void set_Styles(StyleAsset value) { }

	// RVA: 0xFCC620 Offset: 0xFCAC20 VA: 0x180FCC620 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0xFCC8B0 Offset: 0xFCAEB0 VA: 0x180FCC8B0
	public RectTransform get_rectTransform() { }

	// RVA: 0xFCC650 Offset: 0xFCAC50 VA: 0x180FCC650 Slot: 21
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0xFCC670 Offset: 0xFCAC70 VA: 0x180FCC670 Slot: 22
	public virtual void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0xFCC690 Offset: 0xFCAC90 VA: 0x180FCC690 Slot: 23
	public virtual void SetDisabled(bool value) { }

	// RVA: 0xFCC6F0 Offset: 0xFCACF0 VA: 0x180FCC6F0 Slot: 24
	public virtual void SetPressed(bool value) { }

	// RVA: 0xFCC880 Offset: 0xFCAE80 VA: 0x180FCC880 Slot: 25
	public virtual bool get_IsDisabled() { }

	// RVA: 0xFCC8A0 Offset: 0xFCAEA0 VA: 0x180FCC8A0 Slot: 26
	public virtual bool get_IsPressed() { }

	// RVA: 0xFCC890 Offset: 0xFCAE90 VA: 0x180FCC890 Slot: 27
	public virtual bool get_IsHovered() { }

	// RVA: 0xFCC750 Offset: 0xFCAD50 VA: 0x180FCC750 Slot: 28
	public virtual StyleAsset.Group get_CurrentStyleCollection() { }

	// RVA: 0xFCC570 Offset: 0xFCAB70 VA: 0x180FCC570 Slot: 29
	public virtual void ApplyStyles() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 30
	protected virtual void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0x4BAE40 Offset: 0x4B9440 VA: 0x1804BAE40
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

