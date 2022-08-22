protected internal struct EventSource.EventData // TypeDefIndex: 1581
{	// Fields
	internal long m_Ptr; // 0x0
	internal int m_Size; // 0x8
	internal int m_Reserved; // 0xC

	// Properties
	public IntPtr DataPointer { get; set; }
	public int Size { set; }

	// Methods

	// RVA: 0x19F530 Offset: 0x19E930 VA: 0x18019F530
	public IntPtr get_DataPointer() { }

	// RVA: 0x19F540 Offset: 0x19E940 VA: 0x18019F540
	public void set_DataPointer(IntPtr value) { }

	// RVA: 0x19DF50 Offset: 0x19D350 VA: 0x18019DF50
	public void set_Size(int value) { }

	// RVA: 0x19F4A0 Offset: 0x19E8A0 VA: 0x18019F4A0
	internal void SetMetadata(byte* pointer, int size, int reserved) { }

}

protected class XmlSerializationReader.CollectionFixup // TypeDefIndex: 2098
{	// Fields
	private XmlSerializationCollectionFixupCallback callback; // 0x10
	private object collection; // 0x18
	private object collectionItems; // 0x20
	private string id; // 0x28

	// Properties
	public XmlSerializationCollectionFixupCallback Callback { get; }
	public object Collection { get; }
	internal object Id { get; }
	public object CollectionItems { get; set; }

	// Methods

	// RVA: 0x16880F0 Offset: 0x16866F0 VA: 0x1816880F0
	internal void .ctor(object collection, XmlSerializationCollectionFixupCallback callback, string id) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public XmlSerializationCollectionFixupCallback get_Callback() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public object get_Collection() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	internal object get_Id() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public object get_CollectionItems() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	internal void set_CollectionItems(object value) { }

}

protected class XmlSerializationReader.Fixup // TypeDefIndex: 2099
{	// Fields
	private object source; // 0x10
	private string[] ids; // 0x18
	private XmlSerializationFixupCallback callback; // 0x20

	// Properties
	public XmlSerializationFixupCallback Callback { get; }
	public string[] Ids { get; }
	public object Source { get; }

	// Methods

	// RVA: 0x16881A0 Offset: 0x16867A0 VA: 0x1816881A0
	public void .ctor(object o, XmlSerializationFixupCallback callback, int count) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public XmlSerializationFixupCallback get_Callback() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string[] get_Ids() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public object get_Source() { }

}

protected abstract class TypeConverter.SimplePropertyDescriptor : PropertyDescriptor // TypeDefIndex: 2752
{	// Fields
	private Type componentType; // 0x88
	private Type propertyType; // 0x90

	// Properties
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }

	// Methods

	// RVA: 0x1734190 Offset: 0x1732790 VA: 0x181734190
	protected void .ctor(Type componentType, string name, Type propertyType, Attribute[] attributes) { }

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x17341F0 Offset: 0x17327F0 VA: 0x1817341F0 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 20
	public override bool ShouldSerializeValue(object component) { }

}

protected internal class Dropdown.DropdownItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, ICancelHandler // TypeDefIndex: 4922
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Text m_Text; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Image m_Image; // 0x20
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RectTransform m_RectTransform; // 0x28
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Toggle m_Toggle; // 0x30

	// Properties
	public Text text { get; set; }
	public Image image { get; set; }
	public RectTransform rectTransform { get; set; }
	public Toggle toggle { get; set; }

	// Methods

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Text get_text() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_text(Text value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public Image get_image() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_image(Image value) { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public RectTransform get_rectTransform() { }

	// RVA: 0x7EE450 Offset: 0x7ECA50 VA: 0x1807EE450
	public void set_rectTransform(RectTransform value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public Toggle get_toggle() { }

	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	public void set_toggle(Toggle value) { }

	// RVA: 0x15EA9A0 Offset: 0x15E8FA0 VA: 0x1815EA9A0 Slot: 6
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x15EA910 Offset: 0x15E8F10 VA: 0x1815EA910 Slot: 7
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

protected enum InputField.EditState // TypeDefIndex: 4954
{	// Fields
	public int value__; // 0x0
	public const InputField.EditState Continue = 0;
	public const InputField.EditState Finish = 1;

}

protected enum Selectable.SelectionState // TypeDefIndex: 5005
{	// Fields
	public int value__; // 0x0
	public const Selectable.SelectionState Normal = 0;
	public const Selectable.SelectionState Highlighted = 1;
	public const Selectable.SelectionState Pressed = 2;
	public const Selectable.SelectionState Selected = 3;
	public const Selectable.SelectionState Disabled = 4;

}

protected class PointerInputModule.ButtonState // TypeDefIndex: 5082
{	// Fields
	private PointerEventData.InputButton m_Button; // 0x10
	private PointerInputModule.MouseButtonEventData m_EventData; // 0x18

	// Properties
	public PointerInputModule.MouseButtonEventData eventData { get; set; }
	public PointerEventData.InputButton button { get; set; }

	// Methods

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public PointerInputModule.MouseButtonEventData get_eventData() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_eventData(PointerInputModule.MouseButtonEventData value) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public PointerEventData.InputButton get_button() { }

	// RVA: 0x57C9E0 Offset: 0x57AFE0 VA: 0x18057C9E0
	public void set_button(PointerEventData.InputButton value) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

protected class PointerInputModule.MouseState // TypeDefIndex: 5083
{	// Fields
	private List<PointerInputModule.ButtonState> m_TrackedButtons; // 0x10

	// Methods

	// RVA: 0x10C6530 Offset: 0x10C4B30 VA: 0x1810C6530
	public bool AnyPressesThisFrame() { }

	// RVA: 0x10C65F0 Offset: 0x10C4BF0 VA: 0x1810C65F0
	public bool AnyReleasesThisFrame() { }

	// RVA: 0x10C66B0 Offset: 0x10C4CB0 VA: 0x1810C66B0
	public PointerInputModule.ButtonState GetButtonState(PointerEventData.InputButton button) { }

	// RVA: 0x10C6800 Offset: 0x10C4E00 VA: 0x1810C6800
	public void SetButtonState(PointerEventData.InputButton button, PointerEventData.FramePressState stateForMouseButton, PointerEventData data) { }

	// RVA: 0x10C6860 Offset: 0x10C4E60 VA: 0x1810C6860
	public void .ctor() { }

}

protected internal enum JsonReader.State // TypeDefIndex: 5903
{	// Fields
	public int value__; // 0x0
	public const JsonReader.State Start = 0;
	public const JsonReader.State Complete = 1;
	public const JsonReader.State Property = 2;
	public const JsonReader.State ObjectStart = 3;
	public const JsonReader.State Object = 4;
	public const JsonReader.State ArrayStart = 5;
	public const JsonReader.State Array = 6;
	public const JsonReader.State Closed = 7;
	public const JsonReader.State PostValue = 8;
	public const JsonReader.State ConstructorStart = 9;
	public const JsonReader.State Constructor = 10;
	public const JsonReader.State Error = 11;
	public const JsonReader.State Finished = 12;

}

protected enum TMP_InputField.EditState // TypeDefIndex: 6794
{	// Fields
	public int value__; // 0x0
	public const TMP_InputField.EditState Continue = 0;
	public const TMP_InputField.EditState Finish = 1;

}

protected struct TMP_Text.UnicodeChar // TypeDefIndex: 6838
{	// Fields
	public int unicode; // 0x0
	public int stringIndex; // 0x4
	public int length; // 0x8

}

protected static class AnimalAnimation.Params // TypeDefIndex: 9114
{	// Fields
	public static int WalkSpeed; // 0x0
	public static int Sleeping; // 0x4

	// Methods

	// RVA: 0x83C910 Offset: 0x83AF10 VA: 0x18083C910
	private static void .cctor() { }

}

protected class ViewShake.ShakeParameters // TypeDefIndex: 9253
{	// Fields
	public float endTime; // 0x10
	public float duration; // 0x14
	public float amplitude; // 0x18
	public float frequency; // 0x1C
	public float nextShake; // 0x20
	public float angle; // 0x24
	public Vector3 offset; // 0x28
	public bool infinite; // 0x34

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

protected struct BaseFootstepEffect.GroundInfo // TypeDefIndex: 9328
{	// Fields
	public string surface; // 0x0
	public Vector3 position; // 0x8
	public Quaternion rotation; // 0x14

	// Methods

	// RVA: 0xFB960 Offset: 0xFAD60 VA: 0x1800FB960
	public GameObject SpawnDecal(string effectType) { }

	// RVA: 0xFBB40 Offset: 0xFAF40 VA: 0x1800FBB40
	public GameObject SpawnEffect(string effectType) { }

	// RVA: 0xFBA50 Offset: 0xFAE50 VA: 0x1800FBA50
	public GameObject SpawnDisplacement(string effectType) { }

}

protected enum VehicleChassisVisuals.ExtensionMode<T> // TypeDefIndex: 9784
{	// Fields
	public int value__; // 0x0
	public const VehicleChassisVisuals.ExtensionMode<T> RestingIsMinExtension = 0;
	public const VehicleChassisVisuals.ExtensionMode<T> RestingIsMaxExtension = 1;

}

