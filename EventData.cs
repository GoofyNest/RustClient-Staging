public class EventDataAttribute : Attribute // TypeDefIndex: 1515
{	// Fields
	private EventLevel level; // 0x10
	private EventOpcode opcode; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private string <Name>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private EventKeywords <Keywords>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private EventTags <Tags>k__BackingField; // 0x28

	// Properties
	public string Name { get; }
	internal EventLevel Level { get; }
	internal EventOpcode Opcode { get; }
	internal EventKeywords Keywords { get; }
	internal EventTags Tags { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Name() { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	internal EventLevel get_Level() { }

	// RVA: 0x57C9D0 Offset: 0x57AFD0 VA: 0x18057C9D0
	internal EventOpcode get_Opcode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal EventKeywords get_Keywords() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	internal EventTags get_Tags() { }

}

public class AxisEventData : BaseEventData // TypeDefIndex: 5046
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Vector2 <moveVector>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private MoveDirection <moveDir>k__BackingField; // 0x28

	// Properties
	public Vector2 moveVector { get; set; }
	public MoveDirection moveDir { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x10B5820 Offset: 0x10B3E20 VA: 0x1810B5820
	public Vector2 get_moveVector() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xE73FD0 Offset: 0xE725D0 VA: 0x180E73FD0
	public void set_moveVector(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	public MoveDirection get_moveDir() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7D0C50 Offset: 0x7CF250 VA: 0x1807D0C50
	public void set_moveDir(MoveDirection value) { }

	// RVA: 0x10B5780 Offset: 0x10B3D80 VA: 0x1810B5780
	public void .ctor(EventSystem eventSystem) { }

}

public abstract class AbstractEventData // TypeDefIndex: 5047
{	// Fields
	protected bool m_Used; // 0x10

	// Properties
	public virtual bool used { get; }

	// Methods

	// RVA: 0x10B4FC0 Offset: 0x10B35C0 VA: 0x1810B4FC0 Slot: 4
	public virtual void Reset() { }

	// RVA: 0x1020A70 Offset: 0x101F070 VA: 0x181020A70 Slot: 5
	public virtual void Use() { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90 Slot: 6
	public virtual bool get_used() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

public class BaseEventData : AbstractEventData // TypeDefIndex: 5048
{	// Fields
	private readonly EventSystem m_EventSystem; // 0x18

	// Properties
	public BaseInputModule currentInputModule { get; }
	public GameObject selectedObject { get; set; }

	// Methods

	// RVA: 0x10B5840 Offset: 0x10B3E40 VA: 0x1810B5840
	public void .ctor(EventSystem eventSystem) { }

	// RVA: 0xE57010 Offset: 0xE55610 VA: 0x180E57010
	public BaseInputModule get_currentInputModule() { }

	// RVA: 0xE57030 Offset: 0xE55630 VA: 0x180E57030
	public GameObject get_selectedObject() { }

	// RVA: 0x10B5870 Offset: 0x10B3E70 VA: 0x1810B5870
	public void set_selectedObject(GameObject value) { }

}

public class PointerEventData : BaseEventData // TypeDefIndex: 5049
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GameObject <pointerEnter>k__BackingField; // 0x20
	private GameObject m_PointerPress; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GameObject <lastPress>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GameObject <rawPointerPress>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GameObject <pointerDrag>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private RaycastResult <pointerCurrentRaycast>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private RaycastResult <pointerPressRaycast>k__BackingField; // 0x90
	public List<GameObject> hovered; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <eligibleForClick>k__BackingField; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int <pointerId>k__BackingField; // 0xE4
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Vector2 <position>k__BackingField; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Vector2 <delta>k__BackingField; // 0xF0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Vector2 <pressPosition>k__BackingField; // 0xF8
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Vector3 <worldPosition>k__BackingField; // 0x100
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Vector3 <worldNormal>k__BackingField; // 0x10C
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float <clickTime>k__BackingField; // 0x118
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int <clickCount>k__BackingField; // 0x11C
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Vector2 <scrollDelta>k__BackingField; // 0x120
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <useDragThreshold>k__BackingField; // 0x128
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <dragging>k__BackingField; // 0x129
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private PointerEventData.InputButton <button>k__BackingField; // 0x12C

	// Properties
	public GameObject pointerEnter { get; set; }
	public GameObject lastPress { get; set; }
	public GameObject rawPointerPress { get; set; }
	public GameObject pointerDrag { get; set; }
	public RaycastResult pointerCurrentRaycast { get; set; }
	public RaycastResult pointerPressRaycast { get; set; }
	public bool eligibleForClick { get; set; }
	public int pointerId { get; set; }
	public Vector2 position { get; set; }
	public Vector2 delta { get; set; }
	public Vector2 pressPosition { get; set; }
	[ObsoleteAttribute] // RVA: 0x85A90 Offset: 0x84E90 VA: 0x180085A90
	public Vector3 worldPosition { get; set; }
	[ObsoleteAttribute] // RVA: 0x85B50 Offset: 0x84F50 VA: 0x180085B50
	public Vector3 worldNormal { get; set; }
	public float clickTime { get; set; }
	public int clickCount { get; set; }
	public Vector2 scrollDelta { get; set; }
	public bool useDragThreshold { get; set; }
	public bool dragging { get; set; }
	public PointerEventData.InputButton button { get; set; }
	public Camera enterEventCamera { get; }
	public Camera pressEventCamera { get; }
	public GameObject pointerPress { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public GameObject get_pointerEnter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_pointerEnter(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public GameObject get_lastPress() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	private void set_lastPress(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public GameObject get_rawPointerPress() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x6AD5B0 Offset: 0x6ABBB0 VA: 0x1806AD5B0
	public void set_rawPointerPress(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public GameObject get_pointerDrag() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	public void set_pointerDrag(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x10C7D80 Offset: 0x10C6380 VA: 0x1810C7D80
	public RaycastResult get_pointerCurrentRaycast() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x10C7F70 Offset: 0x10C6570 VA: 0x1810C7F70
	public void set_pointerCurrentRaycast(RaycastResult value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x10C7DB0 Offset: 0x10C63B0 VA: 0x1810C7DB0
	public RaycastResult get_pointerPressRaycast() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x10C7FB0 Offset: 0x10C65B0 VA: 0x1810C7FB0
	public void set_pointerPressRaycast(RaycastResult value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x10C7CD0 Offset: 0x10C62D0 VA: 0x1810C7CD0
	public bool get_eligibleForClick() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x10C7F60 Offset: 0x10C6560 VA: 0x1810C7F60
	public void set_eligibleForClick(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1079DE0 Offset: 0x10783E0 VA: 0x181079DE0
	public int get_pointerId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1079F20 Offset: 0x1078520 VA: 0x181079F20
	public void set_pointerId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x10C7DF0 Offset: 0x10C63F0 VA: 0x1810C7DF0
	public Vector2 get_position() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x10C8090 Offset: 0x10C6690 VA: 0x1810C8090
	public void set_position(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x10C7CA0 Offset: 0x10C62A0 VA: 0x1810C7CA0
	public Vector2 get_delta() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x10C7F40 Offset: 0x10C6540 VA: 0x1810C7F40
	public void set_delta(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x10C7EB0 Offset: 0x10C64B0 VA: 0x1810C7EB0
	public Vector2 get_pressPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x10C80A0 Offset: 0x10C66A0 VA: 0x1810C80A0
	public void set_pressPosition(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x10C7F10 Offset: 0x10C6510 VA: 0x1810C7F10
	public Vector3 get_worldPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x10C80F0 Offset: 0x10C66F0 VA: 0x1810C80F0
	public void set_worldPosition(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x10C7EF0 Offset: 0x10C64F0 VA: 0x1810C7EF0
	public Vector3 get_worldNormal() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x10C80D0 Offset: 0x10C66D0 VA: 0x1810C80D0
	public void set_worldNormal(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x10C7C90 Offset: 0x10C6290 VA: 0x1810C7C90
	public float get_clickTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x10C7F30 Offset: 0x10C6530 VA: 0x1810C7F30
	public void set_clickTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1079EC0 Offset: 0x10784C0 VA: 0x181079EC0
	public int get_clickCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x107A060 Offset: 0x1078660 VA: 0x18107A060
	public void set_clickCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x10C7ED0 Offset: 0x10C64D0 VA: 0x1810C7ED0
	public Vector2 get_scrollDelta() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x10C80B0 Offset: 0x10C66B0 VA: 0x1810C80B0
	public void set_scrollDelta(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xE665D0 Offset: 0xE64BD0 VA: 0x180E665D0
	public bool get_useDragThreshold() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x10C80C0 Offset: 0x10C66C0 VA: 0x1810C80C0
	public void set_useDragThreshold(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x10C7CC0 Offset: 0x10C62C0 VA: 0x1810C7CC0
	public bool get_dragging() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x10C7F50 Offset: 0x10C6550 VA: 0x1810C7F50
	public void set_dragging(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xC82E70 Offset: 0xC81470 VA: 0x180C82E70
	public PointerEventData.InputButton get_button() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x107A090 Offset: 0x1078690 VA: 0x18107A090
	public void set_button(PointerEventData.InputButton value) { }

	// RVA: 0x10C7B20 Offset: 0x10C6120 VA: 0x1810C7B20
	public void .ctor(EventSystem eventSystem) { }

	// RVA: 0x10C77F0 Offset: 0x10C5DF0 VA: 0x1810C77F0
	public bool IsPointerMoving() { }

	// RVA: 0x10C7820 Offset: 0x10C5E20 VA: 0x1810C7820
	public bool IsScrolling() { }

	// RVA: 0x10C7CE0 Offset: 0x10C62E0 VA: 0x1810C7CE0
	public Camera get_enterEventCamera() { }

	// RVA: 0x10C7E10 Offset: 0x10C6410 VA: 0x1810C7E10
	public Camera get_pressEventCamera() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public GameObject get_pointerPress() { }

	// RVA: 0x10C7FF0 Offset: 0x10C65F0 VA: 0x1810C7FF0
	public void set_pointerPress(GameObject value) { }

	// RVA: 0x10C7850 Offset: 0x10C5E50 VA: 0x1810C7850 Slot: 3
	public override string ToString() { }

}

public enum PointerEventData.InputButton // TypeDefIndex: 5050
{	// Fields
	public int value__; // 0x0
	public const PointerEventData.InputButton Left = 0;
	public const PointerEventData.InputButton Right = 1;
	public const PointerEventData.InputButton Middle = 2;

}

public enum PointerEventData.FramePressState // TypeDefIndex: 5051
{	// Fields
	public int value__; // 0x0
	public const PointerEventData.FramePressState Pressed = 0;
	public const PointerEventData.FramePressState Released = 1;
	public const PointerEventData.FramePressState PressedAndReleased = 2;
	public const PointerEventData.FramePressState NotChanged = 3;

}

public class TimerAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6543
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float duration; // 0x14
	public float durationMax; // 0x18

	// Methods

	// RVA: 0x1EEF050 Offset: 0x1EED650 VA: 0x181EEF050
	public static void ResetToPool(TimerAIEventData instance) { }

	// RVA: 0x1EEF0D0 Offset: 0x1EED6D0 VA: 0x181EEF0D0
	public void ResetToPool() { }

	// RVA: 0x1EEEDB0 Offset: 0x1EED3B0 VA: 0x181EEEDB0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBEAA0 Offset: 0x1DBD0A0 VA: 0x181DBEAA0
	public void CopyTo(TimerAIEventData instance) { }

	// RVA: 0x1EEDFB0 Offset: 0x1EEC5B0 VA: 0x181EEDFB0
	public TimerAIEventData Copy() { }

	// RVA: 0x1EEE5B0 Offset: 0x1EECBB0 VA: 0x181EEE5B0
	public static TimerAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1EEE020 Offset: 0x1EEC620 VA: 0x181EEE020
	public static TimerAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EEE2F0 Offset: 0x1EEC8F0 VA: 0x181EEE2F0
	public static TimerAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EEE770 Offset: 0x1EECD70 VA: 0x181EEE770
	public static TimerAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1EEEEB0 Offset: 0x1EED4B0 VA: 0x181EEEEB0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EEF5A0 Offset: 0x1EEDBA0 VA: 0x181EEF5A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EEF5C0 Offset: 0x1EEDBC0 VA: 0x181EEF5C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, TimerAIEventData previous) { }

	// RVA: 0x1EEF030 Offset: 0x1EED630 VA: 0x181EEF030 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EEE9E0 Offset: 0x1EECFE0 VA: 0x181EEE9E0
	public static TimerAIEventData Deserialize(byte[] buffer, TimerAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1EEEC30 Offset: 0x1EED230 VA: 0x181EEEC30
	public static TimerAIEventData Deserialize(Stream stream, TimerAIEventData instance, bool isDelta) { }

	// RVA: 0x1EEE0A0 Offset: 0x1EEC6A0 VA: 0x181EEE0A0
	public static TimerAIEventData DeserializeLengthDelimited(Stream stream, TimerAIEventData instance, bool isDelta) { }

	// RVA: 0x1EEE380 Offset: 0x1EEC980 VA: 0x181EEE380
	public static TimerAIEventData DeserializeLength(Stream stream, int length, TimerAIEventData instance, bool isDelta) { }

	// RVA: 0x1EEF150 Offset: 0x1EED750 VA: 0x181EEF150
	public static void SerializeDelta(Stream stream, TimerAIEventData instance, TimerAIEventData previous) { }

	// RVA: 0x1EEF490 Offset: 0x1EEDA90 VA: 0x181EEF490
	public static void Serialize(Stream stream, TimerAIEventData instance) { }

	// RVA: 0x1EEF590 Offset: 0x1EEDB90 VA: 0x181EEF590
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EEF5A0 Offset: 0x1EEDBA0 VA: 0x181EEF5A0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EEF380 Offset: 0x1EED980 VA: 0x181EEF380
	public static byte[] SerializeToBytes(TimerAIEventData instance) { }

	// RVA: 0x1EEF2D0 Offset: 0x1EED8D0 VA: 0x181EEF2D0
	public static void SerializeLengthDelimited(Stream stream, TimerAIEventData instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class HealthBelowAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6545
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float healthFraction; // 0x14

	// Methods

	// RVA: 0x1D641A0 Offset: 0x1D627A0 VA: 0x181D641A0
	public static void ResetToPool(HealthBelowAIEventData instance) { }

	// RVA: 0x1D64220 Offset: 0x1D62820 VA: 0x181D64220
	public void ResetToPool() { }

	// RVA: 0x1D64070 Offset: 0x1D62670 VA: 0x181D64070 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE690 Offset: 0x1BFCC90 VA: 0x181BFE690
	public void CopyTo(HealthBelowAIEventData instance) { }

	// RVA: 0x1D636E0 Offset: 0x1D61CE0 VA: 0x181D636E0
	public HealthBelowAIEventData Copy() { }

	// RVA: 0x1D63C80 Offset: 0x1D62280 VA: 0x181D63C80
	public static HealthBelowAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1D63750 Offset: 0x1D61D50 VA: 0x181D63750
	public static HealthBelowAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D639F0 Offset: 0x1D61FF0 VA: 0x181D639F0
	public static HealthBelowAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D63E50 Offset: 0x1D62450 VA: 0x181D63E50
	public static HealthBelowAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1D64160 Offset: 0x1D62760 VA: 0x181D64160
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D64670 Offset: 0x1D62C70 VA: 0x181D64670 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D64690 Offset: 0x1D62C90 VA: 0x181D64690 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, HealthBelowAIEventData previous) { }

	// RVA: 0x1D64180 Offset: 0x1D62780 VA: 0x181D64180 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D63F70 Offset: 0x1D62570 VA: 0x181D63F70
	public static HealthBelowAIEventData Deserialize(byte[] buffer, HealthBelowAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1D63D00 Offset: 0x1D62300 VA: 0x181D63D00
	public static HealthBelowAIEventData Deserialize(Stream stream, HealthBelowAIEventData instance, bool isDelta) { }

	// RVA: 0x1D637D0 Offset: 0x1D61DD0 VA: 0x181D637D0
	public static HealthBelowAIEventData DeserializeLengthDelimited(Stream stream, HealthBelowAIEventData instance, bool isDelta) { }

	// RVA: 0x1D63A80 Offset: 0x1D62080 VA: 0x181D63A80
	public static HealthBelowAIEventData DeserializeLength(Stream stream, int length, HealthBelowAIEventData instance, bool isDelta) { }

	// RVA: 0x1D642A0 Offset: 0x1D628A0 VA: 0x181D642A0
	public static void SerializeDelta(Stream stream, HealthBelowAIEventData instance, HealthBelowAIEventData previous) { }

	// RVA: 0x1D64580 Offset: 0x1D62B80 VA: 0x181D64580
	public static void Serialize(Stream stream, HealthBelowAIEventData instance) { }

	// RVA: 0x1D64660 Offset: 0x1D62C60 VA: 0x181D64660
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D64670 Offset: 0x1D62C70 VA: 0x181D64670
	public void ToProto(Stream stream) { }

	// RVA: 0x1D64470 Offset: 0x1D62A70 VA: 0x181D64470
	public static byte[] SerializeToBytes(HealthBelowAIEventData instance) { }

	// RVA: 0x1D643C0 Offset: 0x1D629C0 VA: 0x181D643C0
	public static void SerializeLengthDelimited(Stream stream, HealthBelowAIEventData instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class InRangeAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6546
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float range; // 0x14

	// Methods

	// RVA: 0x1C05AC0 Offset: 0x1C040C0 VA: 0x181C05AC0
	public static void ResetToPool(InRangeAIEventData instance) { }

	// RVA: 0x1C05B40 Offset: 0x1C04140 VA: 0x181C05B40
	public void ResetToPool() { }

	// RVA: 0x1C05990 Offset: 0x1C03F90 VA: 0x181C05990 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE690 Offset: 0x1BFCC90 VA: 0x181BFE690
	public void CopyTo(InRangeAIEventData instance) { }

	// RVA: 0x1C05000 Offset: 0x1C03600 VA: 0x181C05000
	public InRangeAIEventData Copy() { }

	// RVA: 0x1C055A0 Offset: 0x1C03BA0 VA: 0x181C055A0
	public static InRangeAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1C05070 Offset: 0x1C03670 VA: 0x181C05070
	public static InRangeAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C05510 Offset: 0x1C03B10 VA: 0x181C05510
	public static InRangeAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C05870 Offset: 0x1C03E70 VA: 0x181C05870
	public static InRangeAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1C05A80 Offset: 0x1C04080 VA: 0x181C05A80
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C05F90 Offset: 0x1C04590 VA: 0x181C05F90 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C05FB0 Offset: 0x1C045B0 VA: 0x181C05FB0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, InRangeAIEventData previous) { }

	// RVA: 0x1C05AA0 Offset: 0x1C040A0 VA: 0x181C05AA0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C05620 Offset: 0x1C03C20 VA: 0x181C05620
	public static InRangeAIEventData Deserialize(byte[] buffer, InRangeAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1C05720 Offset: 0x1C03D20 VA: 0x181C05720
	public static InRangeAIEventData Deserialize(Stream stream, InRangeAIEventData instance, bool isDelta) { }

	// RVA: 0x1C050F0 Offset: 0x1C036F0 VA: 0x181C050F0
	public static InRangeAIEventData DeserializeLengthDelimited(Stream stream, InRangeAIEventData instance, bool isDelta) { }

	// RVA: 0x1C05310 Offset: 0x1C03910 VA: 0x181C05310
	public static InRangeAIEventData DeserializeLength(Stream stream, int length, InRangeAIEventData instance, bool isDelta) { }

	// RVA: 0x1C05BC0 Offset: 0x1C041C0 VA: 0x181C05BC0
	public static void SerializeDelta(Stream stream, InRangeAIEventData instance, InRangeAIEventData previous) { }

	// RVA: 0x1C05EA0 Offset: 0x1C044A0 VA: 0x181C05EA0
	public static void Serialize(Stream stream, InRangeAIEventData instance) { }

	// RVA: 0x1C05F80 Offset: 0x1C04580 VA: 0x181C05F80
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C05F90 Offset: 0x1C04590 VA: 0x181C05F90
	public void ToProto(Stream stream) { }

	// RVA: 0x1C05D90 Offset: 0x1C04390 VA: 0x181C05D90
	public static byte[] SerializeToBytes(InRangeAIEventData instance) { }

	// RVA: 0x1C05CE0 Offset: 0x1C042E0 VA: 0x181C05CE0
	public static void SerializeLengthDelimited(Stream stream, InRangeAIEventData instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class HungerAboveAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6547
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float value; // 0x14

	// Methods

	// RVA: 0x1BFF170 Offset: 0x1BFD770 VA: 0x181BFF170
	public static void ResetToPool(HungerAboveAIEventData instance) { }

	// RVA: 0x1BFF1F0 Offset: 0x1BFD7F0 VA: 0x181BFF1F0
	public void ResetToPool() { }

	// RVA: 0x1BFF040 Offset: 0x1BFD640 VA: 0x181BFF040 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE690 Offset: 0x1BFCC90 VA: 0x181BFE690
	public void CopyTo(HungerAboveAIEventData instance) { }

	// RVA: 0x1BFE6B0 Offset: 0x1BFCCB0 VA: 0x181BFE6B0
	public HungerAboveAIEventData Copy() { }

	// RVA: 0x1BFEC50 Offset: 0x1BFD250 VA: 0x181BFEC50
	public static HungerAboveAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1BFE720 Offset: 0x1BFCD20 VA: 0x181BFE720
	public static HungerAboveAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1BFE9C0 Offset: 0x1BFCFC0 VA: 0x181BFE9C0
	public static HungerAboveAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1BFEF20 Offset: 0x1BFD520 VA: 0x181BFEF20
	public static HungerAboveAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1BFF130 Offset: 0x1BFD730 VA: 0x181BFF130
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1BFF640 Offset: 0x1BFDC40 VA: 0x181BFF640 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1BFF660 Offset: 0x1BFDC60 VA: 0x181BFF660 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, HungerAboveAIEventData previous) { }

	// RVA: 0x1BFF150 Offset: 0x1BFD750 VA: 0x181BFF150 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1BFEE20 Offset: 0x1BFD420 VA: 0x181BFEE20
	public static HungerAboveAIEventData Deserialize(byte[] buffer, HungerAboveAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1BFECD0 Offset: 0x1BFD2D0 VA: 0x181BFECD0
	public static HungerAboveAIEventData Deserialize(Stream stream, HungerAboveAIEventData instance, bool isDelta) { }

	// RVA: 0x1BFE7A0 Offset: 0x1BFCDA0 VA: 0x181BFE7A0
	public static HungerAboveAIEventData DeserializeLengthDelimited(Stream stream, HungerAboveAIEventData instance, bool isDelta) { }

	// RVA: 0x1BFEA50 Offset: 0x1BFD050 VA: 0x181BFEA50
	public static HungerAboveAIEventData DeserializeLength(Stream stream, int length, HungerAboveAIEventData instance, bool isDelta) { }

	// RVA: 0x1BFF270 Offset: 0x1BFD870 VA: 0x181BFF270
	public static void SerializeDelta(Stream stream, HungerAboveAIEventData instance, HungerAboveAIEventData previous) { }

	// RVA: 0x1BFF550 Offset: 0x1BFDB50 VA: 0x181BFF550
	public static void Serialize(Stream stream, HungerAboveAIEventData instance) { }

	// RVA: 0x1BFF630 Offset: 0x1BFDC30 VA: 0x181BFF630
	public byte[] ToProtoBytes() { }

	// RVA: 0x1BFF640 Offset: 0x1BFDC40 VA: 0x181BFF640
	public void ToProto(Stream stream) { }

	// RVA: 0x1BFF440 Offset: 0x1BFDA40 VA: 0x181BFF440
	public static byte[] SerializeToBytes(HungerAboveAIEventData instance) { }

	// RVA: 0x1BFF390 Offset: 0x1BFD990 VA: 0x181BFF390
	public static void SerializeLengthDelimited(Stream stream, HungerAboveAIEventData instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class TirednessAboveAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6548
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float value; // 0x14

	// Methods

	// RVA: 0x1EF0210 Offset: 0x1EEE810 VA: 0x181EF0210
	public static void ResetToPool(TirednessAboveAIEventData instance) { }

	// RVA: 0x1EF0290 Offset: 0x1EEE890 VA: 0x181EF0290
	public void ResetToPool() { }

	// RVA: 0x1EF00E0 Offset: 0x1EEE6E0 VA: 0x181EF00E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE690 Offset: 0x1BFCC90 VA: 0x181BFE690
	public void CopyTo(TirednessAboveAIEventData instance) { }

	// RVA: 0x1EEF750 Offset: 0x1EEDD50 VA: 0x181EEF750
	public TirednessAboveAIEventData Copy() { }

	// RVA: 0x1EEFE40 Offset: 0x1EEE440 VA: 0x181EEFE40
	public static TirednessAboveAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1EEF9E0 Offset: 0x1EEDFE0 VA: 0x181EEF9E0
	public static TirednessAboveAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EEFC60 Offset: 0x1EEE260 VA: 0x181EEFC60
	public static TirednessAboveAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EEFEC0 Offset: 0x1EEE4C0 VA: 0x181EEFEC0
	public static TirednessAboveAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1EF01D0 Offset: 0x1EEE7D0 VA: 0x181EF01D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EF06E0 Offset: 0x1EEECE0 VA: 0x181EF06E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EF0700 Offset: 0x1EEED00 VA: 0x181EF0700 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, TirednessAboveAIEventData previous) { }

	// RVA: 0x1EF01F0 Offset: 0x1EEE7F0 VA: 0x181EF01F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EEFFE0 Offset: 0x1EEE5E0 VA: 0x181EEFFE0
	public static TirednessAboveAIEventData Deserialize(byte[] buffer, TirednessAboveAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1EEFCF0 Offset: 0x1EEE2F0 VA: 0x181EEFCF0
	public static TirednessAboveAIEventData Deserialize(Stream stream, TirednessAboveAIEventData instance, bool isDelta) { }

	// RVA: 0x1EEF7C0 Offset: 0x1EEDDC0 VA: 0x181EEF7C0
	public static TirednessAboveAIEventData DeserializeLengthDelimited(Stream stream, TirednessAboveAIEventData instance, bool isDelta) { }

	// RVA: 0x1EEFA60 Offset: 0x1EEE060 VA: 0x181EEFA60
	public static TirednessAboveAIEventData DeserializeLength(Stream stream, int length, TirednessAboveAIEventData instance, bool isDelta) { }

	// RVA: 0x1EF0310 Offset: 0x1EEE910 VA: 0x181EF0310
	public static void SerializeDelta(Stream stream, TirednessAboveAIEventData instance, TirednessAboveAIEventData previous) { }

	// RVA: 0x1EF05F0 Offset: 0x1EEEBF0 VA: 0x181EF05F0
	public static void Serialize(Stream stream, TirednessAboveAIEventData instance) { }

	// RVA: 0x1EF06D0 Offset: 0x1EEECD0 VA: 0x181EF06D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EF06E0 Offset: 0x1EEECE0 VA: 0x181EF06E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EF04E0 Offset: 0x1EEEAE0 VA: 0x181EF04E0
	public static byte[] SerializeToBytes(TirednessAboveAIEventData instance) { }

	// RVA: 0x1EF0430 Offset: 0x1EEEA30 VA: 0x181EF0430
	public static void SerializeLengthDelimited(Stream stream, TirednessAboveAIEventData instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class AmmoBelowAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6549
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float value; // 0x14

	// Methods

	// RVA: 0x20141D0 Offset: 0x20127D0 VA: 0x1820141D0
	public static void ResetToPool(AmmoBelowAIEventData instance) { }

	// RVA: 0x2014150 Offset: 0x2012750 VA: 0x182014150
	public void ResetToPool() { }

	// RVA: 0x2014090 Offset: 0x2012690 VA: 0x182014090 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE690 Offset: 0x1BFCC90 VA: 0x181BFE690
	public void CopyTo(AmmoBelowAIEventData instance) { }

	// RVA: 0x2013700 Offset: 0x2011D00 VA: 0x182013700
	public AmmoBelowAIEventData Copy() { }

	// RVA: 0x2013EC0 Offset: 0x20124C0 VA: 0x182013EC0
	public static AmmoBelowAIEventData Deserialize(Stream stream) { }

	// RVA: 0x2013770 Offset: 0x2011D70 VA: 0x182013770
	public static AmmoBelowAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2013C10 Offset: 0x2012210 VA: 0x182013C10
	public static AmmoBelowAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2013DA0 Offset: 0x20123A0 VA: 0x182013DA0
	public static AmmoBelowAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x2014110 Offset: 0x2012710 VA: 0x182014110
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2014620 Offset: 0x2012C20 VA: 0x182014620 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2014640 Offset: 0x2012C40 VA: 0x182014640 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AmmoBelowAIEventData previous) { }

	// RVA: 0x2014130 Offset: 0x2012730 VA: 0x182014130 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2013CA0 Offset: 0x20122A0 VA: 0x182013CA0
	public static AmmoBelowAIEventData Deserialize(byte[] buffer, AmmoBelowAIEventData instance, bool isDelta = False) { }

	// RVA: 0x2013F40 Offset: 0x2012540 VA: 0x182013F40
	public static AmmoBelowAIEventData Deserialize(Stream stream, AmmoBelowAIEventData instance, bool isDelta) { }

	// RVA: 0x20137F0 Offset: 0x2011DF0 VA: 0x1820137F0
	public static AmmoBelowAIEventData DeserializeLengthDelimited(Stream stream, AmmoBelowAIEventData instance, bool isDelta) { }

	// RVA: 0x2013A10 Offset: 0x2012010 VA: 0x182013A10
	public static AmmoBelowAIEventData DeserializeLength(Stream stream, int length, AmmoBelowAIEventData instance, bool isDelta) { }

	// RVA: 0x2014250 Offset: 0x2012850 VA: 0x182014250
	public static void SerializeDelta(Stream stream, AmmoBelowAIEventData instance, AmmoBelowAIEventData previous) { }

	// RVA: 0x2014530 Offset: 0x2012B30 VA: 0x182014530
	public static void Serialize(Stream stream, AmmoBelowAIEventData instance) { }

	// RVA: 0x2014610 Offset: 0x2012C10 VA: 0x182014610
	public byte[] ToProtoBytes() { }

	// RVA: 0x2014620 Offset: 0x2012C20 VA: 0x182014620
	public void ToProto(Stream stream) { }

	// RVA: 0x2014420 Offset: 0x2012A20 VA: 0x182014420
	public static byte[] SerializeToBytes(AmmoBelowAIEventData instance) { }

	// RVA: 0x2014370 Offset: 0x2012970 VA: 0x182014370
	public static void SerializeLengthDelimited(Stream stream, AmmoBelowAIEventData instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class ThreatDetectedAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6550
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float range; // 0x14

	// Methods

	// RVA: 0x1EEC910 Offset: 0x1EEAF10 VA: 0x181EEC910
	public static void ResetToPool(ThreatDetectedAIEventData instance) { }

	// RVA: 0x1EEC890 Offset: 0x1EEAE90 VA: 0x181EEC890
	public void ResetToPool() { }

	// RVA: 0x1EEC760 Offset: 0x1EEAD60 VA: 0x181EEC760 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE690 Offset: 0x1BFCC90 VA: 0x181BFE690
	public void CopyTo(ThreatDetectedAIEventData instance) { }

	// RVA: 0x1EEBDD0 Offset: 0x1EEA3D0 VA: 0x181EEBDD0
	public ThreatDetectedAIEventData Copy() { }

	// RVA: 0x1EEC6E0 Offset: 0x1EEACE0 VA: 0x181EEC6E0
	public static ThreatDetectedAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1EEBE40 Offset: 0x1EEA440 VA: 0x181EEBE40
	public static ThreatDetectedAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EEC0E0 Offset: 0x1EEA6E0 VA: 0x181EEC0E0
	public static ThreatDetectedAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EEC470 Offset: 0x1EEAA70 VA: 0x181EEC470
	public static ThreatDetectedAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1EEC850 Offset: 0x1EEAE50 VA: 0x181EEC850
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EECD60 Offset: 0x1EEB360 VA: 0x181EECD60 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EECD80 Offset: 0x1EEB380 VA: 0x181EECD80 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ThreatDetectedAIEventData previous) { }

	// RVA: 0x1EEC870 Offset: 0x1EEAE70 VA: 0x181EEC870 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EEC370 Offset: 0x1EEA970 VA: 0x181EEC370
	public static ThreatDetectedAIEventData Deserialize(byte[] buffer, ThreatDetectedAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1EEC590 Offset: 0x1EEAB90 VA: 0x181EEC590
	public static ThreatDetectedAIEventData Deserialize(Stream stream, ThreatDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1EEBEC0 Offset: 0x1EEA4C0 VA: 0x181EEBEC0
	public static ThreatDetectedAIEventData DeserializeLengthDelimited(Stream stream, ThreatDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1EEC170 Offset: 0x1EEA770 VA: 0x181EEC170
	public static ThreatDetectedAIEventData DeserializeLength(Stream stream, int length, ThreatDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1EEC990 Offset: 0x1EEAF90 VA: 0x181EEC990
	public static void SerializeDelta(Stream stream, ThreatDetectedAIEventData instance, ThreatDetectedAIEventData previous) { }

	// RVA: 0x1EECC70 Offset: 0x1EEB270 VA: 0x181EECC70
	public static void Serialize(Stream stream, ThreatDetectedAIEventData instance) { }

	// RVA: 0x1EECD50 Offset: 0x1EEB350 VA: 0x181EECD50
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EECD60 Offset: 0x1EEB360 VA: 0x181EECD60
	public void ToProto(Stream stream) { }

	// RVA: 0x1EECB60 Offset: 0x1EEB160 VA: 0x181EECB60
	public static byte[] SerializeToBytes(ThreatDetectedAIEventData instance) { }

	// RVA: 0x1EECAB0 Offset: 0x1EEB0B0 VA: 0x181EECAB0
	public static void SerializeLengthDelimited(Stream stream, ThreatDetectedAIEventData instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class TargetDetectedAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6551
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float range; // 0x14

	// Methods

	// RVA: 0x1DC7970 Offset: 0x1DC5F70 VA: 0x181DC7970
	public static void ResetToPool(TargetDetectedAIEventData instance) { }

	// RVA: 0x1DC78F0 Offset: 0x1DC5EF0 VA: 0x181DC78F0
	public void ResetToPool() { }

	// RVA: 0x1DC77C0 Offset: 0x1DC5DC0 VA: 0x181DC77C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE690 Offset: 0x1BFCC90 VA: 0x181BFE690
	public void CopyTo(TargetDetectedAIEventData instance) { }

	// RVA: 0x1DC6E30 Offset: 0x1DC5430 VA: 0x181DC6E30
	public TargetDetectedAIEventData Copy() { }

	// RVA: 0x1DC73D0 Offset: 0x1DC59D0 VA: 0x181DC73D0
	public static TargetDetectedAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1DC6EA0 Offset: 0x1DC54A0 VA: 0x181DC6EA0
	public static TargetDetectedAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DC7140 Offset: 0x1DC5740 VA: 0x181DC7140
	public static TargetDetectedAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DC7550 Offset: 0x1DC5B50 VA: 0x181DC7550
	public static TargetDetectedAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1DC78B0 Offset: 0x1DC5EB0 VA: 0x181DC78B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DC7DC0 Offset: 0x1DC63C0 VA: 0x181DC7DC0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DC7DE0 Offset: 0x1DC63E0 VA: 0x181DC7DE0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, TargetDetectedAIEventData previous) { }

	// RVA: 0x1DC78D0 Offset: 0x1DC5ED0 VA: 0x181DC78D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DC7450 Offset: 0x1DC5A50 VA: 0x181DC7450
	public static TargetDetectedAIEventData Deserialize(byte[] buffer, TargetDetectedAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1DC7670 Offset: 0x1DC5C70 VA: 0x181DC7670
	public static TargetDetectedAIEventData Deserialize(Stream stream, TargetDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1DC6F20 Offset: 0x1DC5520 VA: 0x181DC6F20
	public static TargetDetectedAIEventData DeserializeLengthDelimited(Stream stream, TargetDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1DC71D0 Offset: 0x1DC57D0 VA: 0x181DC71D0
	public static TargetDetectedAIEventData DeserializeLength(Stream stream, int length, TargetDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1DC79F0 Offset: 0x1DC5FF0 VA: 0x181DC79F0
	public static void SerializeDelta(Stream stream, TargetDetectedAIEventData instance, TargetDetectedAIEventData previous) { }

	// RVA: 0x1DC7CD0 Offset: 0x1DC62D0 VA: 0x181DC7CD0
	public static void Serialize(Stream stream, TargetDetectedAIEventData instance) { }

	// RVA: 0x1DC7DB0 Offset: 0x1DC63B0 VA: 0x181DC7DB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DC7DC0 Offset: 0x1DC63C0 VA: 0x181DC7DC0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DC7BC0 Offset: 0x1DC61C0 VA: 0x181DC7BC0
	public static byte[] SerializeToBytes(TargetDetectedAIEventData instance) { }

	// RVA: 0x1DC7B10 Offset: 0x1DC6110 VA: 0x181DC7B10
	public static void SerializeLengthDelimited(Stream stream, TargetDetectedAIEventData instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class ChanceAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6552
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float value; // 0x14

	// Methods

	// RVA: 0x20A93E0 Offset: 0x20A79E0 VA: 0x1820A93E0
	public static void ResetToPool(ChanceAIEventData instance) { }

	// RVA: 0x20A9460 Offset: 0x20A7A60 VA: 0x1820A9460
	public void ResetToPool() { }

	// RVA: 0x20A92B0 Offset: 0x20A78B0 VA: 0x1820A92B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE690 Offset: 0x1BFCC90 VA: 0x181BFE690
	public void CopyTo(ChanceAIEventData instance) { }

	// RVA: 0x20A8920 Offset: 0x20A6F20 VA: 0x1820A8920
	public ChanceAIEventData Copy() { }

	// RVA: 0x20A90E0 Offset: 0x20A76E0 VA: 0x1820A90E0
	public static ChanceAIEventData Deserialize(Stream stream) { }

	// RVA: 0x20A8BB0 Offset: 0x20A71B0 VA: 0x1820A8BB0
	public static ChanceAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20A8C30 Offset: 0x20A7230 VA: 0x1820A8C30
	public static ChanceAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20A8EC0 Offset: 0x20A74C0 VA: 0x1820A8EC0
	public static ChanceAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x20A93A0 Offset: 0x20A79A0 VA: 0x1820A93A0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20A98B0 Offset: 0x20A7EB0 VA: 0x1820A98B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20A98D0 Offset: 0x20A7ED0 VA: 0x1820A98D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ChanceAIEventData previous) { }

	// RVA: 0x20A93C0 Offset: 0x20A79C0 VA: 0x1820A93C0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20A8FE0 Offset: 0x20A75E0 VA: 0x1820A8FE0
	public static ChanceAIEventData Deserialize(byte[] buffer, ChanceAIEventData instance, bool isDelta = False) { }

	// RVA: 0x20A9160 Offset: 0x20A7760 VA: 0x1820A9160
	public static ChanceAIEventData Deserialize(Stream stream, ChanceAIEventData instance, bool isDelta) { }

	// RVA: 0x20A8990 Offset: 0x20A6F90 VA: 0x1820A8990
	public static ChanceAIEventData DeserializeLengthDelimited(Stream stream, ChanceAIEventData instance, bool isDelta) { }

	// RVA: 0x20A8CC0 Offset: 0x20A72C0 VA: 0x1820A8CC0
	public static ChanceAIEventData DeserializeLength(Stream stream, int length, ChanceAIEventData instance, bool isDelta) { }

	// RVA: 0x20A94E0 Offset: 0x20A7AE0 VA: 0x1820A94E0
	public static void SerializeDelta(Stream stream, ChanceAIEventData instance, ChanceAIEventData previous) { }

	// RVA: 0x20A97C0 Offset: 0x20A7DC0 VA: 0x1820A97C0
	public static void Serialize(Stream stream, ChanceAIEventData instance) { }

	// RVA: 0x20A98A0 Offset: 0x20A7EA0 VA: 0x1820A98A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20A98B0 Offset: 0x20A7EB0 VA: 0x1820A98B0
	public void ToProto(Stream stream) { }

	// RVA: 0x20A96B0 Offset: 0x20A7CB0 VA: 0x1820A96B0
	public static byte[] SerializeToBytes(ChanceAIEventData instance) { }

	// RVA: 0x20A9600 Offset: 0x20A7C00 VA: 0x1820A9600
	public static void SerializeLengthDelimited(Stream stream, ChanceAIEventData instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class TimeSinceThreatAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6553
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float value; // 0x14

	// Methods

	// RVA: 0x1EEDA00 Offset: 0x1EEC000 VA: 0x181EEDA00
	public static void ResetToPool(TimeSinceThreatAIEventData instance) { }

	// RVA: 0x1EED980 Offset: 0x1EEBF80 VA: 0x181EED980
	public void ResetToPool() { }

	// RVA: 0x1EED850 Offset: 0x1EEBE50 VA: 0x181EED850 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE690 Offset: 0x1BFCC90 VA: 0x181BFE690
	public void CopyTo(TimeSinceThreatAIEventData instance) { }

	// RVA: 0x1EECEC0 Offset: 0x1EEB4C0 VA: 0x181EECEC0
	public TimeSinceThreatAIEventData Copy() { }

	// RVA: 0x1EED560 Offset: 0x1EEBB60 VA: 0x181EED560
	public static TimeSinceThreatAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1EECF30 Offset: 0x1EEB530 VA: 0x181EECF30
	public static TimeSinceThreatAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EED1D0 Offset: 0x1EEB7D0 VA: 0x181EED1D0
	public static TimeSinceThreatAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EED5E0 Offset: 0x1EEBBE0 VA: 0x181EED5E0
	public static TimeSinceThreatAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1EED940 Offset: 0x1EEBF40 VA: 0x181EED940
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EEDE50 Offset: 0x1EEC450 VA: 0x181EEDE50 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EEDE70 Offset: 0x1EEC470 VA: 0x181EEDE70 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, TimeSinceThreatAIEventData previous) { }

	// RVA: 0x1EED960 Offset: 0x1EEBF60 VA: 0x181EED960 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EED460 Offset: 0x1EEBA60 VA: 0x181EED460
	public static TimeSinceThreatAIEventData Deserialize(byte[] buffer, TimeSinceThreatAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1EED700 Offset: 0x1EEBD00 VA: 0x181EED700
	public static TimeSinceThreatAIEventData Deserialize(Stream stream, TimeSinceThreatAIEventData instance, bool isDelta) { }

	// RVA: 0x1EECFB0 Offset: 0x1EEB5B0 VA: 0x181EECFB0
	public static TimeSinceThreatAIEventData DeserializeLengthDelimited(Stream stream, TimeSinceThreatAIEventData instance, bool isDelta) { }

	// RVA: 0x1EED260 Offset: 0x1EEB860 VA: 0x181EED260
	public static TimeSinceThreatAIEventData DeserializeLength(Stream stream, int length, TimeSinceThreatAIEventData instance, bool isDelta) { }

	// RVA: 0x1EEDA80 Offset: 0x1EEC080 VA: 0x181EEDA80
	public static void SerializeDelta(Stream stream, TimeSinceThreatAIEventData instance, TimeSinceThreatAIEventData previous) { }

	// RVA: 0x1EEDD60 Offset: 0x1EEC360 VA: 0x181EEDD60
	public static void Serialize(Stream stream, TimeSinceThreatAIEventData instance) { }

	// RVA: 0x1EEDE40 Offset: 0x1EEC440 VA: 0x181EEDE40
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EEDE50 Offset: 0x1EEC450 VA: 0x181EEDE50
	public void ToProto(Stream stream) { }

	// RVA: 0x1EEDC50 Offset: 0x1EEC250 VA: 0x181EEDC50
	public static byte[] SerializeToBytes(TimeSinceThreatAIEventData instance) { }

	// RVA: 0x1EEDBA0 Offset: 0x1EEC1A0 VA: 0x181EEDBA0
	public static void SerializeLengthDelimited(Stream stream, TimeSinceThreatAIEventData instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class AggressionTimerAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6554
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float value; // 0x14

	// Methods

	// RVA: 0x20131F0 Offset: 0x20117F0 VA: 0x1820131F0
	public static void ResetToPool(AggressionTimerAIEventData instance) { }

	// RVA: 0x2013270 Offset: 0x2011870 VA: 0x182013270
	public void ResetToPool() { }

	// RVA: 0x2013130 Offset: 0x2011730 VA: 0x182013130 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE690 Offset: 0x1BFCC90 VA: 0x181BFE690
	public void CopyTo(AggressionTimerAIEventData instance) { }

	// RVA: 0x20127A0 Offset: 0x2010DA0 VA: 0x1820127A0
	public AggressionTimerAIEventData Copy() { }

	// RVA: 0x20130B0 Offset: 0x20116B0 VA: 0x1820130B0
	public static AggressionTimerAIEventData Deserialize(Stream stream) { }

	// RVA: 0x2012A30 Offset: 0x2011030 VA: 0x182012A30
	public static AggressionTimerAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2012AB0 Offset: 0x20110B0 VA: 0x182012AB0
	public static AggressionTimerAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2012F90 Offset: 0x2011590 VA: 0x182012F90
	public static AggressionTimerAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x20131B0 Offset: 0x20117B0 VA: 0x1820131B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20136C0 Offset: 0x2011CC0 VA: 0x1820136C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20136E0 Offset: 0x2011CE0 VA: 0x1820136E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AggressionTimerAIEventData previous) { }

	// RVA: 0x20131D0 Offset: 0x20117D0 VA: 0x1820131D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2012D40 Offset: 0x2011340 VA: 0x182012D40
	public static AggressionTimerAIEventData Deserialize(byte[] buffer, AggressionTimerAIEventData instance, bool isDelta = False) { }

	// RVA: 0x2012E40 Offset: 0x2011440 VA: 0x182012E40
	public static AggressionTimerAIEventData Deserialize(Stream stream, AggressionTimerAIEventData instance, bool isDelta) { }

	// RVA: 0x2012810 Offset: 0x2010E10 VA: 0x182012810
	public static AggressionTimerAIEventData DeserializeLengthDelimited(Stream stream, AggressionTimerAIEventData instance, bool isDelta) { }

	// RVA: 0x2012B40 Offset: 0x2011140 VA: 0x182012B40
	public static AggressionTimerAIEventData DeserializeLength(Stream stream, int length, AggressionTimerAIEventData instance, bool isDelta) { }

	// RVA: 0x20132F0 Offset: 0x20118F0 VA: 0x1820132F0
	public static void SerializeDelta(Stream stream, AggressionTimerAIEventData instance, AggressionTimerAIEventData previous) { }

	// RVA: 0x20135D0 Offset: 0x2011BD0 VA: 0x1820135D0
	public static void Serialize(Stream stream, AggressionTimerAIEventData instance) { }

	// RVA: 0x20136B0 Offset: 0x2011CB0 VA: 0x1820136B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20136C0 Offset: 0x2011CC0 VA: 0x1820136C0
	public void ToProto(Stream stream) { }

	// RVA: 0x20134C0 Offset: 0x2011AC0 VA: 0x1820134C0
	public static byte[] SerializeToBytes(AggressionTimerAIEventData instance) { }

	// RVA: 0x2013410 Offset: 0x2011A10 VA: 0x182013410
	public static void SerializeLengthDelimited(Stream stream, AggressionTimerAIEventData instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class InRangeOfHomeAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6556
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float range; // 0x14

	// Methods

	// RVA: 0x1C06C30 Offset: 0x1C05230 VA: 0x181C06C30
	public static void ResetToPool(InRangeOfHomeAIEventData instance) { }

	// RVA: 0x1C06BB0 Offset: 0x1C051B0 VA: 0x181C06BB0
	public void ResetToPool() { }

	// RVA: 0x1C06A80 Offset: 0x1C05080 VA: 0x181C06A80 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE690 Offset: 0x1BFCC90 VA: 0x181BFE690
	public void CopyTo(InRangeOfHomeAIEventData instance) { }

	// RVA: 0x1C060F0 Offset: 0x1C046F0 VA: 0x181C060F0
	public InRangeOfHomeAIEventData Copy() { }

	// RVA: 0x1C06690 Offset: 0x1C04C90 VA: 0x181C06690
	public static InRangeOfHomeAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1C06380 Offset: 0x1C04980 VA: 0x181C06380
	public static InRangeOfHomeAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C06400 Offset: 0x1C04A00 VA: 0x181C06400
	public static InRangeOfHomeAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C06960 Offset: 0x1C04F60 VA: 0x181C06960
	public static InRangeOfHomeAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1C06B70 Offset: 0x1C05170 VA: 0x181C06B70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C07080 Offset: 0x1C05680 VA: 0x181C07080 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C070A0 Offset: 0x1C056A0 VA: 0x181C070A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, InRangeOfHomeAIEventData previous) { }

	// RVA: 0x1C06B90 Offset: 0x1C05190 VA: 0x181C06B90 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C06710 Offset: 0x1C04D10 VA: 0x181C06710
	public static InRangeOfHomeAIEventData Deserialize(byte[] buffer, InRangeOfHomeAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1C06810 Offset: 0x1C04E10 VA: 0x181C06810
	public static InRangeOfHomeAIEventData Deserialize(Stream stream, InRangeOfHomeAIEventData instance, bool isDelta) { }

	// RVA: 0x1C06160 Offset: 0x1C04760 VA: 0x181C06160
	public static InRangeOfHomeAIEventData DeserializeLengthDelimited(Stream stream, InRangeOfHomeAIEventData instance, bool isDelta) { }

	// RVA: 0x1C06490 Offset: 0x1C04A90 VA: 0x181C06490
	public static InRangeOfHomeAIEventData DeserializeLength(Stream stream, int length, InRangeOfHomeAIEventData instance, bool isDelta) { }

	// RVA: 0x1C06CB0 Offset: 0x1C052B0 VA: 0x181C06CB0
	public static void SerializeDelta(Stream stream, InRangeOfHomeAIEventData instance, InRangeOfHomeAIEventData previous) { }

	// RVA: 0x1C06F90 Offset: 0x1C05590 VA: 0x181C06F90
	public static void Serialize(Stream stream, InRangeOfHomeAIEventData instance) { }

	// RVA: 0x1C07070 Offset: 0x1C05670 VA: 0x181C07070
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C07080 Offset: 0x1C05680 VA: 0x181C07080
	public void ToProto(Stream stream) { }

	// RVA: 0x1C06E80 Offset: 0x1C05480 VA: 0x181C06E80
	public static byte[] SerializeToBytes(InRangeOfHomeAIEventData instance) { }

	// RVA: 0x1C06DD0 Offset: 0x1C053D0 VA: 0x181C06DD0
	public static void SerializeLengthDelimited(Stream stream, InRangeOfHomeAIEventData instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

internal struct ColorEventData // TypeDefIndex: 7701
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float <Value>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ColorEventFrame <Frame>k__BackingField; // 0x4

	// Properties
	[JsonPropertyAttribute] // RVA: 0xBE760 Offset: 0xBDB60 VA: 0x1800BE760
	public float Value { get; set; }
	[JsonPropertyAttribute] // RVA: 0xBE8E0 Offset: 0xBDCE0 VA: 0x1800BE8E0
	public ColorEventFrame Frame { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF2400 Offset: 0xF1800 VA: 0x1800F2400
	public float get_Value() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF2410 Offset: 0xF1810 VA: 0x1800F2410
	public void set_Value(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x236DF0 Offset: 0x2361F0 VA: 0x180236DF0
	public ColorEventFrame get_Frame() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x236E10 Offset: 0x236210 VA: 0x180236E10
	public void set_Frame(ColorEventFrame value) { }

}

internal struct EmptyEventData // TypeDefIndex: 7704
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int <Value>k__BackingField; // 0x0

	// Properties
	[JsonPropertyAttribute] // RVA: 0xBE760 Offset: 0xBDB60 VA: 0x1800BE760
	public int Value { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF37A0 Offset: 0xF2BA0 VA: 0x1800F37A0
	public int get_Value() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF38D0 Offset: 0xF2CD0 VA: 0x1800F38D0
	public void set_Value(int value) { }

}

