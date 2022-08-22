public class EventDataAttribute : Attribute // TypeDefIndex: 1515
{	// Fields
	private EventLevel level; // 0x10
	private EventOpcode opcode; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Name>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private EventKeywords <Keywords>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private EventTags <Tags>k__BackingField; // 0x28

	// Properties
	public string Name { get; }
	internal EventLevel Level { get; }
	internal EventOpcode Opcode { get; }
	internal EventKeywords Keywords { get; }
	internal EventTags Tags { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Name() { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	internal EventLevel get_Level() { }

	// RVA: 0x57C9D0 Offset: 0x57AFD0 VA: 0x18057C9D0
	internal EventOpcode get_Opcode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal EventKeywords get_Keywords() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	internal EventTags get_Tags() { }

}

public class AxisEventData : BaseEventData // TypeDefIndex: 5046
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector2 <moveVector>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MoveDirection <moveDir>k__BackingField; // 0x28

	// Properties
	public Vector2 moveVector { get; set; }
	public MoveDirection moveDir { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10B5820 Offset: 0x10B3E20 VA: 0x1810B5820
	public Vector2 get_moveVector() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE73FD0 Offset: 0xE725D0 VA: 0x180E73FD0
	public void set_moveVector(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	public MoveDirection get_moveDir() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObject <pointerEnter>k__BackingField; // 0x20
	private GameObject m_PointerPress; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObject <lastPress>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObject <rawPointerPress>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObject <pointerDrag>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RaycastResult <pointerCurrentRaycast>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RaycastResult <pointerPressRaycast>k__BackingField; // 0x90
	public List<GameObject> hovered; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <eligibleForClick>k__BackingField; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <pointerId>k__BackingField; // 0xE4
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector2 <position>k__BackingField; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector2 <delta>k__BackingField; // 0xF0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector2 <pressPosition>k__BackingField; // 0xF8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 <worldPosition>k__BackingField; // 0x100
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 <worldNormal>k__BackingField; // 0x10C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <clickTime>k__BackingField; // 0x118
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <clickCount>k__BackingField; // 0x11C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector2 <scrollDelta>k__BackingField; // 0x120
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <useDragThreshold>k__BackingField; // 0x128
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <dragging>k__BackingField; // 0x129
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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
	[ObsoleteAttribute] // RVA: 0x85B00 Offset: 0x84F00 VA: 0x180085B00
	public Vector3 worldPosition { get; set; }
	[ObsoleteAttribute] // RVA: 0x85BC0 Offset: 0x84FC0 VA: 0x180085BC0
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

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public GameObject get_pointerEnter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_pointerEnter(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public GameObject get_lastPress() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	private void set_lastPress(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public GameObject get_rawPointerPress() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6AD5B0 Offset: 0x6ABBB0 VA: 0x1806AD5B0
	public void set_rawPointerPress(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public GameObject get_pointerDrag() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	public void set_pointerDrag(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C7D80 Offset: 0x10C6380 VA: 0x1810C7D80
	public RaycastResult get_pointerCurrentRaycast() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C7F70 Offset: 0x10C6570 VA: 0x1810C7F70
	public void set_pointerCurrentRaycast(RaycastResult value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C7DB0 Offset: 0x10C63B0 VA: 0x1810C7DB0
	public RaycastResult get_pointerPressRaycast() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C7FB0 Offset: 0x10C65B0 VA: 0x1810C7FB0
	public void set_pointerPressRaycast(RaycastResult value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C7CD0 Offset: 0x10C62D0 VA: 0x1810C7CD0
	public bool get_eligibleForClick() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C7F60 Offset: 0x10C6560 VA: 0x1810C7F60
	public void set_eligibleForClick(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079DE0 Offset: 0x10783E0 VA: 0x181079DE0
	public int get_pointerId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079F20 Offset: 0x1078520 VA: 0x181079F20
	public void set_pointerId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C7DF0 Offset: 0x10C63F0 VA: 0x1810C7DF0
	public Vector2 get_position() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C8090 Offset: 0x10C6690 VA: 0x1810C8090
	public void set_position(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C7CA0 Offset: 0x10C62A0 VA: 0x1810C7CA0
	public Vector2 get_delta() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C7F40 Offset: 0x10C6540 VA: 0x1810C7F40
	public void set_delta(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C7EB0 Offset: 0x10C64B0 VA: 0x1810C7EB0
	public Vector2 get_pressPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C80A0 Offset: 0x10C66A0 VA: 0x1810C80A0
	public void set_pressPosition(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C7F10 Offset: 0x10C6510 VA: 0x1810C7F10
	public Vector3 get_worldPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C80F0 Offset: 0x10C66F0 VA: 0x1810C80F0
	public void set_worldPosition(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C7EF0 Offset: 0x10C64F0 VA: 0x1810C7EF0
	public Vector3 get_worldNormal() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C80D0 Offset: 0x10C66D0 VA: 0x1810C80D0
	public void set_worldNormal(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C7C90 Offset: 0x10C6290 VA: 0x1810C7C90
	public float get_clickTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C7F30 Offset: 0x10C6530 VA: 0x1810C7F30
	public void set_clickTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079EC0 Offset: 0x10784C0 VA: 0x181079EC0
	public int get_clickCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107A060 Offset: 0x1078660 VA: 0x18107A060
	public void set_clickCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C7ED0 Offset: 0x10C64D0 VA: 0x1810C7ED0
	public Vector2 get_scrollDelta() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C80B0 Offset: 0x10C66B0 VA: 0x1810C80B0
	public void set_scrollDelta(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE665D0 Offset: 0xE64BD0 VA: 0x180E665D0
	public bool get_useDragThreshold() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C80C0 Offset: 0x10C66C0 VA: 0x1810C80C0
	public void set_useDragThreshold(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C7CC0 Offset: 0x10C62C0 VA: 0x1810C7CC0
	public bool get_dragging() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C7F50 Offset: 0x10C6550 VA: 0x1810C7F50
	public void set_dragging(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC82E70 Offset: 0xC81470 VA: 0x180C82E70
	public PointerEventData.InputButton get_button() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	// RVA: 0x1EEEE90 Offset: 0x1EED490 VA: 0x181EEEE90
	public static void ResetToPool(TimerAIEventData instance) { }

	// RVA: 0x1EEEF10 Offset: 0x1EED510 VA: 0x181EEEF10
	public void ResetToPool() { }

	// RVA: 0x1EEEBF0 Offset: 0x1EED1F0 VA: 0x181EEEBF0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBE8E0 Offset: 0x1DBCEE0 VA: 0x181DBE8E0
	public void CopyTo(TimerAIEventData instance) { }

	// RVA: 0x1EEDDF0 Offset: 0x1EEC3F0 VA: 0x181EEDDF0
	public TimerAIEventData Copy() { }

	// RVA: 0x1EEE3F0 Offset: 0x1EEC9F0 VA: 0x181EEE3F0
	public static TimerAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1EEDE60 Offset: 0x1EEC460 VA: 0x181EEDE60
	public static TimerAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EEE130 Offset: 0x1EEC730 VA: 0x181EEE130
	public static TimerAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EEE5B0 Offset: 0x1EECBB0 VA: 0x181EEE5B0
	public static TimerAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1EEECF0 Offset: 0x1EED2F0 VA: 0x181EEECF0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EEF3E0 Offset: 0x1EED9E0 VA: 0x181EEF3E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EEF400 Offset: 0x1EEDA00 VA: 0x181EEF400 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, TimerAIEventData previous) { }

	// RVA: 0x1EEEE70 Offset: 0x1EED470 VA: 0x181EEEE70 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EEE820 Offset: 0x1EECE20 VA: 0x181EEE820
	public static TimerAIEventData Deserialize(byte[] buffer, TimerAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1EEEA70 Offset: 0x1EED070 VA: 0x181EEEA70
	public static TimerAIEventData Deserialize(Stream stream, TimerAIEventData instance, bool isDelta) { }

	// RVA: 0x1EEDEE0 Offset: 0x1EEC4E0 VA: 0x181EEDEE0
	public static TimerAIEventData DeserializeLengthDelimited(Stream stream, TimerAIEventData instance, bool isDelta) { }

	// RVA: 0x1EEE1C0 Offset: 0x1EEC7C0 VA: 0x181EEE1C0
	public static TimerAIEventData DeserializeLength(Stream stream, int length, TimerAIEventData instance, bool isDelta) { }

	// RVA: 0x1EEEF90 Offset: 0x1EED590 VA: 0x181EEEF90
	public static void SerializeDelta(Stream stream, TimerAIEventData instance, TimerAIEventData previous) { }

	// RVA: 0x1EEF2D0 Offset: 0x1EED8D0 VA: 0x181EEF2D0
	public static void Serialize(Stream stream, TimerAIEventData instance) { }

	// RVA: 0x1EEF3D0 Offset: 0x1EED9D0 VA: 0x181EEF3D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EEF3E0 Offset: 0x1EED9E0 VA: 0x181EEF3E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EEF1C0 Offset: 0x1EED7C0 VA: 0x181EEF1C0
	public static byte[] SerializeToBytes(TimerAIEventData instance) { }

	// RVA: 0x1EEF110 Offset: 0x1EED710 VA: 0x181EEF110
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

	// RVA: 0x1D63FE0 Offset: 0x1D625E0 VA: 0x181D63FE0
	public static void ResetToPool(HealthBelowAIEventData instance) { }

	// RVA: 0x1D64060 Offset: 0x1D62660 VA: 0x181D64060
	public void ResetToPool() { }

	// RVA: 0x1D63EB0 Offset: 0x1D624B0 VA: 0x181D63EB0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE4D0 Offset: 0x1BFCAD0 VA: 0x181BFE4D0
	public void CopyTo(HealthBelowAIEventData instance) { }

	// RVA: 0x1D63520 Offset: 0x1D61B20 VA: 0x181D63520
	public HealthBelowAIEventData Copy() { }

	// RVA: 0x1D63AC0 Offset: 0x1D620C0 VA: 0x181D63AC0
	public static HealthBelowAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1D63590 Offset: 0x1D61B90 VA: 0x181D63590
	public static HealthBelowAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D63830 Offset: 0x1D61E30 VA: 0x181D63830
	public static HealthBelowAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D63C90 Offset: 0x1D62290 VA: 0x181D63C90
	public static HealthBelowAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1D63FA0 Offset: 0x1D625A0 VA: 0x181D63FA0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D644B0 Offset: 0x1D62AB0 VA: 0x181D644B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D644D0 Offset: 0x1D62AD0 VA: 0x181D644D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, HealthBelowAIEventData previous) { }

	// RVA: 0x1D63FC0 Offset: 0x1D625C0 VA: 0x181D63FC0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D63DB0 Offset: 0x1D623B0 VA: 0x181D63DB0
	public static HealthBelowAIEventData Deserialize(byte[] buffer, HealthBelowAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1D63B40 Offset: 0x1D62140 VA: 0x181D63B40
	public static HealthBelowAIEventData Deserialize(Stream stream, HealthBelowAIEventData instance, bool isDelta) { }

	// RVA: 0x1D63610 Offset: 0x1D61C10 VA: 0x181D63610
	public static HealthBelowAIEventData DeserializeLengthDelimited(Stream stream, HealthBelowAIEventData instance, bool isDelta) { }

	// RVA: 0x1D638C0 Offset: 0x1D61EC0 VA: 0x181D638C0
	public static HealthBelowAIEventData DeserializeLength(Stream stream, int length, HealthBelowAIEventData instance, bool isDelta) { }

	// RVA: 0x1D640E0 Offset: 0x1D626E0 VA: 0x181D640E0
	public static void SerializeDelta(Stream stream, HealthBelowAIEventData instance, HealthBelowAIEventData previous) { }

	// RVA: 0x1D643C0 Offset: 0x1D629C0 VA: 0x181D643C0
	public static void Serialize(Stream stream, HealthBelowAIEventData instance) { }

	// RVA: 0x1D644A0 Offset: 0x1D62AA0 VA: 0x181D644A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D644B0 Offset: 0x1D62AB0 VA: 0x181D644B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1D642B0 Offset: 0x1D628B0 VA: 0x181D642B0
	public static byte[] SerializeToBytes(HealthBelowAIEventData instance) { }

	// RVA: 0x1D64200 Offset: 0x1D62800 VA: 0x181D64200
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

	// RVA: 0x1C05900 Offset: 0x1C03F00 VA: 0x181C05900
	public static void ResetToPool(InRangeAIEventData instance) { }

	// RVA: 0x1C05980 Offset: 0x1C03F80 VA: 0x181C05980
	public void ResetToPool() { }

	// RVA: 0x1C057D0 Offset: 0x1C03DD0 VA: 0x181C057D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE4D0 Offset: 0x1BFCAD0 VA: 0x181BFE4D0
	public void CopyTo(InRangeAIEventData instance) { }

	// RVA: 0x1C04E40 Offset: 0x1C03440 VA: 0x181C04E40
	public InRangeAIEventData Copy() { }

	// RVA: 0x1C053E0 Offset: 0x1C039E0 VA: 0x181C053E0
	public static InRangeAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1C04EB0 Offset: 0x1C034B0 VA: 0x181C04EB0
	public static InRangeAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C05350 Offset: 0x1C03950 VA: 0x181C05350
	public static InRangeAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C056B0 Offset: 0x1C03CB0 VA: 0x181C056B0
	public static InRangeAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1C058C0 Offset: 0x1C03EC0 VA: 0x181C058C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C05DD0 Offset: 0x1C043D0 VA: 0x181C05DD0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C05DF0 Offset: 0x1C043F0 VA: 0x181C05DF0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, InRangeAIEventData previous) { }

	// RVA: 0x1C058E0 Offset: 0x1C03EE0 VA: 0x181C058E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C05460 Offset: 0x1C03A60 VA: 0x181C05460
	public static InRangeAIEventData Deserialize(byte[] buffer, InRangeAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1C05560 Offset: 0x1C03B60 VA: 0x181C05560
	public static InRangeAIEventData Deserialize(Stream stream, InRangeAIEventData instance, bool isDelta) { }

	// RVA: 0x1C04F30 Offset: 0x1C03530 VA: 0x181C04F30
	public static InRangeAIEventData DeserializeLengthDelimited(Stream stream, InRangeAIEventData instance, bool isDelta) { }

	// RVA: 0x1C05150 Offset: 0x1C03750 VA: 0x181C05150
	public static InRangeAIEventData DeserializeLength(Stream stream, int length, InRangeAIEventData instance, bool isDelta) { }

	// RVA: 0x1C05A00 Offset: 0x1C04000 VA: 0x181C05A00
	public static void SerializeDelta(Stream stream, InRangeAIEventData instance, InRangeAIEventData previous) { }

	// RVA: 0x1C05CE0 Offset: 0x1C042E0 VA: 0x181C05CE0
	public static void Serialize(Stream stream, InRangeAIEventData instance) { }

	// RVA: 0x1C05DC0 Offset: 0x1C043C0 VA: 0x181C05DC0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C05DD0 Offset: 0x1C043D0 VA: 0x181C05DD0
	public void ToProto(Stream stream) { }

	// RVA: 0x1C05BD0 Offset: 0x1C041D0 VA: 0x181C05BD0
	public static byte[] SerializeToBytes(InRangeAIEventData instance) { }

	// RVA: 0x1C05B20 Offset: 0x1C04120 VA: 0x181C05B20
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

	// RVA: 0x1BFEFB0 Offset: 0x1BFD5B0 VA: 0x181BFEFB0
	public static void ResetToPool(HungerAboveAIEventData instance) { }

	// RVA: 0x1BFF030 Offset: 0x1BFD630 VA: 0x181BFF030
	public void ResetToPool() { }

	// RVA: 0x1BFEE80 Offset: 0x1BFD480 VA: 0x181BFEE80 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE4D0 Offset: 0x1BFCAD0 VA: 0x181BFE4D0
	public void CopyTo(HungerAboveAIEventData instance) { }

	// RVA: 0x1BFE4F0 Offset: 0x1BFCAF0 VA: 0x181BFE4F0
	public HungerAboveAIEventData Copy() { }

	// RVA: 0x1BFEA90 Offset: 0x1BFD090 VA: 0x181BFEA90
	public static HungerAboveAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1BFE560 Offset: 0x1BFCB60 VA: 0x181BFE560
	public static HungerAboveAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1BFE800 Offset: 0x1BFCE00 VA: 0x181BFE800
	public static HungerAboveAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1BFED60 Offset: 0x1BFD360 VA: 0x181BFED60
	public static HungerAboveAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1BFEF70 Offset: 0x1BFD570 VA: 0x181BFEF70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1BFF480 Offset: 0x1BFDA80 VA: 0x181BFF480 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1BFF4A0 Offset: 0x1BFDAA0 VA: 0x181BFF4A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, HungerAboveAIEventData previous) { }

	// RVA: 0x1BFEF90 Offset: 0x1BFD590 VA: 0x181BFEF90 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1BFEC60 Offset: 0x1BFD260 VA: 0x181BFEC60
	public static HungerAboveAIEventData Deserialize(byte[] buffer, HungerAboveAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1BFEB10 Offset: 0x1BFD110 VA: 0x181BFEB10
	public static HungerAboveAIEventData Deserialize(Stream stream, HungerAboveAIEventData instance, bool isDelta) { }

	// RVA: 0x1BFE5E0 Offset: 0x1BFCBE0 VA: 0x181BFE5E0
	public static HungerAboveAIEventData DeserializeLengthDelimited(Stream stream, HungerAboveAIEventData instance, bool isDelta) { }

	// RVA: 0x1BFE890 Offset: 0x1BFCE90 VA: 0x181BFE890
	public static HungerAboveAIEventData DeserializeLength(Stream stream, int length, HungerAboveAIEventData instance, bool isDelta) { }

	// RVA: 0x1BFF0B0 Offset: 0x1BFD6B0 VA: 0x181BFF0B0
	public static void SerializeDelta(Stream stream, HungerAboveAIEventData instance, HungerAboveAIEventData previous) { }

	// RVA: 0x1BFF390 Offset: 0x1BFD990 VA: 0x181BFF390
	public static void Serialize(Stream stream, HungerAboveAIEventData instance) { }

	// RVA: 0x1BFF470 Offset: 0x1BFDA70 VA: 0x181BFF470
	public byte[] ToProtoBytes() { }

	// RVA: 0x1BFF480 Offset: 0x1BFDA80 VA: 0x181BFF480
	public void ToProto(Stream stream) { }

	// RVA: 0x1BFF280 Offset: 0x1BFD880 VA: 0x181BFF280
	public static byte[] SerializeToBytes(HungerAboveAIEventData instance) { }

	// RVA: 0x1BFF1D0 Offset: 0x1BFD7D0 VA: 0x181BFF1D0
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

	// RVA: 0x1EF0050 Offset: 0x1EEE650 VA: 0x181EF0050
	public static void ResetToPool(TirednessAboveAIEventData instance) { }

	// RVA: 0x1EF00D0 Offset: 0x1EEE6D0 VA: 0x181EF00D0
	public void ResetToPool() { }

	// RVA: 0x1EEFF20 Offset: 0x1EEE520 VA: 0x181EEFF20 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE4D0 Offset: 0x1BFCAD0 VA: 0x181BFE4D0
	public void CopyTo(TirednessAboveAIEventData instance) { }

	// RVA: 0x1EEF590 Offset: 0x1EEDB90 VA: 0x181EEF590
	public TirednessAboveAIEventData Copy() { }

	// RVA: 0x1EEFC80 Offset: 0x1EEE280 VA: 0x181EEFC80
	public static TirednessAboveAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1EEF820 Offset: 0x1EEDE20 VA: 0x181EEF820
	public static TirednessAboveAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EEFAA0 Offset: 0x1EEE0A0 VA: 0x181EEFAA0
	public static TirednessAboveAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EEFD00 Offset: 0x1EEE300 VA: 0x181EEFD00
	public static TirednessAboveAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1EF0010 Offset: 0x1EEE610 VA: 0x181EF0010
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EF0520 Offset: 0x1EEEB20 VA: 0x181EF0520 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EF0540 Offset: 0x1EEEB40 VA: 0x181EF0540 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, TirednessAboveAIEventData previous) { }

	// RVA: 0x1EF0030 Offset: 0x1EEE630 VA: 0x181EF0030 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EEFE20 Offset: 0x1EEE420 VA: 0x181EEFE20
	public static TirednessAboveAIEventData Deserialize(byte[] buffer, TirednessAboveAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1EEFB30 Offset: 0x1EEE130 VA: 0x181EEFB30
	public static TirednessAboveAIEventData Deserialize(Stream stream, TirednessAboveAIEventData instance, bool isDelta) { }

	// RVA: 0x1EEF600 Offset: 0x1EEDC00 VA: 0x181EEF600
	public static TirednessAboveAIEventData DeserializeLengthDelimited(Stream stream, TirednessAboveAIEventData instance, bool isDelta) { }

	// RVA: 0x1EEF8A0 Offset: 0x1EEDEA0 VA: 0x181EEF8A0
	public static TirednessAboveAIEventData DeserializeLength(Stream stream, int length, TirednessAboveAIEventData instance, bool isDelta) { }

	// RVA: 0x1EF0150 Offset: 0x1EEE750 VA: 0x181EF0150
	public static void SerializeDelta(Stream stream, TirednessAboveAIEventData instance, TirednessAboveAIEventData previous) { }

	// RVA: 0x1EF0430 Offset: 0x1EEEA30 VA: 0x181EF0430
	public static void Serialize(Stream stream, TirednessAboveAIEventData instance) { }

	// RVA: 0x1EF0510 Offset: 0x1EEEB10 VA: 0x181EF0510
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EF0520 Offset: 0x1EEEB20 VA: 0x181EF0520
	public void ToProto(Stream stream) { }

	// RVA: 0x1EF0320 Offset: 0x1EEE920 VA: 0x181EF0320
	public static byte[] SerializeToBytes(TirednessAboveAIEventData instance) { }

	// RVA: 0x1EF0270 Offset: 0x1EEE870 VA: 0x181EF0270
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

	// RVA: 0x2014010 Offset: 0x2012610 VA: 0x182014010
	public static void ResetToPool(AmmoBelowAIEventData instance) { }

	// RVA: 0x2013F90 Offset: 0x2012590 VA: 0x182013F90
	public void ResetToPool() { }

	// RVA: 0x2013ED0 Offset: 0x20124D0 VA: 0x182013ED0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE4D0 Offset: 0x1BFCAD0 VA: 0x181BFE4D0
	public void CopyTo(AmmoBelowAIEventData instance) { }

	// RVA: 0x2013540 Offset: 0x2011B40 VA: 0x182013540
	public AmmoBelowAIEventData Copy() { }

	// RVA: 0x2013D00 Offset: 0x2012300 VA: 0x182013D00
	public static AmmoBelowAIEventData Deserialize(Stream stream) { }

	// RVA: 0x20135B0 Offset: 0x2011BB0 VA: 0x1820135B0
	public static AmmoBelowAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2013A50 Offset: 0x2012050 VA: 0x182013A50
	public static AmmoBelowAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2013BE0 Offset: 0x20121E0 VA: 0x182013BE0
	public static AmmoBelowAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x2013F50 Offset: 0x2012550 VA: 0x182013F50
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2014460 Offset: 0x2012A60 VA: 0x182014460 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2014480 Offset: 0x2012A80 VA: 0x182014480 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AmmoBelowAIEventData previous) { }

	// RVA: 0x2013F70 Offset: 0x2012570 VA: 0x182013F70 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2013AE0 Offset: 0x20120E0 VA: 0x182013AE0
	public static AmmoBelowAIEventData Deserialize(byte[] buffer, AmmoBelowAIEventData instance, bool isDelta = False) { }

	// RVA: 0x2013D80 Offset: 0x2012380 VA: 0x182013D80
	public static AmmoBelowAIEventData Deserialize(Stream stream, AmmoBelowAIEventData instance, bool isDelta) { }

	// RVA: 0x2013630 Offset: 0x2011C30 VA: 0x182013630
	public static AmmoBelowAIEventData DeserializeLengthDelimited(Stream stream, AmmoBelowAIEventData instance, bool isDelta) { }

	// RVA: 0x2013850 Offset: 0x2011E50 VA: 0x182013850
	public static AmmoBelowAIEventData DeserializeLength(Stream stream, int length, AmmoBelowAIEventData instance, bool isDelta) { }

	// RVA: 0x2014090 Offset: 0x2012690 VA: 0x182014090
	public static void SerializeDelta(Stream stream, AmmoBelowAIEventData instance, AmmoBelowAIEventData previous) { }

	// RVA: 0x2014370 Offset: 0x2012970 VA: 0x182014370
	public static void Serialize(Stream stream, AmmoBelowAIEventData instance) { }

	// RVA: 0x2014450 Offset: 0x2012A50 VA: 0x182014450
	public byte[] ToProtoBytes() { }

	// RVA: 0x2014460 Offset: 0x2012A60 VA: 0x182014460
	public void ToProto(Stream stream) { }

	// RVA: 0x2014260 Offset: 0x2012860 VA: 0x182014260
	public static byte[] SerializeToBytes(AmmoBelowAIEventData instance) { }

	// RVA: 0x20141B0 Offset: 0x20127B0 VA: 0x1820141B0
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

	// RVA: 0x1EEC750 Offset: 0x1EEAD50 VA: 0x181EEC750
	public static void ResetToPool(ThreatDetectedAIEventData instance) { }

	// RVA: 0x1EEC6D0 Offset: 0x1EEACD0 VA: 0x181EEC6D0
	public void ResetToPool() { }

	// RVA: 0x1EEC5A0 Offset: 0x1EEABA0 VA: 0x181EEC5A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE4D0 Offset: 0x1BFCAD0 VA: 0x181BFE4D0
	public void CopyTo(ThreatDetectedAIEventData instance) { }

	// RVA: 0x1EEBC10 Offset: 0x1EEA210 VA: 0x181EEBC10
	public ThreatDetectedAIEventData Copy() { }

	// RVA: 0x1EEC520 Offset: 0x1EEAB20 VA: 0x181EEC520
	public static ThreatDetectedAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1EEBC80 Offset: 0x1EEA280 VA: 0x181EEBC80
	public static ThreatDetectedAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EEBF20 Offset: 0x1EEA520 VA: 0x181EEBF20
	public static ThreatDetectedAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EEC2B0 Offset: 0x1EEA8B0 VA: 0x181EEC2B0
	public static ThreatDetectedAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1EEC690 Offset: 0x1EEAC90 VA: 0x181EEC690
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EECBA0 Offset: 0x1EEB1A0 VA: 0x181EECBA0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EECBC0 Offset: 0x1EEB1C0 VA: 0x181EECBC0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ThreatDetectedAIEventData previous) { }

	// RVA: 0x1EEC6B0 Offset: 0x1EEACB0 VA: 0x181EEC6B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EEC1B0 Offset: 0x1EEA7B0 VA: 0x181EEC1B0
	public static ThreatDetectedAIEventData Deserialize(byte[] buffer, ThreatDetectedAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1EEC3D0 Offset: 0x1EEA9D0 VA: 0x181EEC3D0
	public static ThreatDetectedAIEventData Deserialize(Stream stream, ThreatDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1EEBD00 Offset: 0x1EEA300 VA: 0x181EEBD00
	public static ThreatDetectedAIEventData DeserializeLengthDelimited(Stream stream, ThreatDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1EEBFB0 Offset: 0x1EEA5B0 VA: 0x181EEBFB0
	public static ThreatDetectedAIEventData DeserializeLength(Stream stream, int length, ThreatDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1EEC7D0 Offset: 0x1EEADD0 VA: 0x181EEC7D0
	public static void SerializeDelta(Stream stream, ThreatDetectedAIEventData instance, ThreatDetectedAIEventData previous) { }

	// RVA: 0x1EECAB0 Offset: 0x1EEB0B0 VA: 0x181EECAB0
	public static void Serialize(Stream stream, ThreatDetectedAIEventData instance) { }

	// RVA: 0x1EECB90 Offset: 0x1EEB190 VA: 0x181EECB90
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EECBA0 Offset: 0x1EEB1A0 VA: 0x181EECBA0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EEC9A0 Offset: 0x1EEAFA0 VA: 0x181EEC9A0
	public static byte[] SerializeToBytes(ThreatDetectedAIEventData instance) { }

	// RVA: 0x1EEC8F0 Offset: 0x1EEAEF0 VA: 0x181EEC8F0
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

	// RVA: 0x1DC77B0 Offset: 0x1DC5DB0 VA: 0x181DC77B0
	public static void ResetToPool(TargetDetectedAIEventData instance) { }

	// RVA: 0x1DC7730 Offset: 0x1DC5D30 VA: 0x181DC7730
	public void ResetToPool() { }

	// RVA: 0x1DC7600 Offset: 0x1DC5C00 VA: 0x181DC7600 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE4D0 Offset: 0x1BFCAD0 VA: 0x181BFE4D0
	public void CopyTo(TargetDetectedAIEventData instance) { }

	// RVA: 0x1DC6C70 Offset: 0x1DC5270 VA: 0x181DC6C70
	public TargetDetectedAIEventData Copy() { }

	// RVA: 0x1DC7210 Offset: 0x1DC5810 VA: 0x181DC7210
	public static TargetDetectedAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1DC6CE0 Offset: 0x1DC52E0 VA: 0x181DC6CE0
	public static TargetDetectedAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DC6F80 Offset: 0x1DC5580 VA: 0x181DC6F80
	public static TargetDetectedAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DC7390 Offset: 0x1DC5990 VA: 0x181DC7390
	public static TargetDetectedAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1DC76F0 Offset: 0x1DC5CF0 VA: 0x181DC76F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DC7C00 Offset: 0x1DC6200 VA: 0x181DC7C00 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DC7C20 Offset: 0x1DC6220 VA: 0x181DC7C20 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, TargetDetectedAIEventData previous) { }

	// RVA: 0x1DC7710 Offset: 0x1DC5D10 VA: 0x181DC7710 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DC7290 Offset: 0x1DC5890 VA: 0x181DC7290
	public static TargetDetectedAIEventData Deserialize(byte[] buffer, TargetDetectedAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1DC74B0 Offset: 0x1DC5AB0 VA: 0x181DC74B0
	public static TargetDetectedAIEventData Deserialize(Stream stream, TargetDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1DC6D60 Offset: 0x1DC5360 VA: 0x181DC6D60
	public static TargetDetectedAIEventData DeserializeLengthDelimited(Stream stream, TargetDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1DC7010 Offset: 0x1DC5610 VA: 0x181DC7010
	public static TargetDetectedAIEventData DeserializeLength(Stream stream, int length, TargetDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1DC7830 Offset: 0x1DC5E30 VA: 0x181DC7830
	public static void SerializeDelta(Stream stream, TargetDetectedAIEventData instance, TargetDetectedAIEventData previous) { }

	// RVA: 0x1DC7B10 Offset: 0x1DC6110 VA: 0x181DC7B10
	public static void Serialize(Stream stream, TargetDetectedAIEventData instance) { }

	// RVA: 0x1DC7BF0 Offset: 0x1DC61F0 VA: 0x181DC7BF0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DC7C00 Offset: 0x1DC6200 VA: 0x181DC7C00
	public void ToProto(Stream stream) { }

	// RVA: 0x1DC7A00 Offset: 0x1DC6000 VA: 0x181DC7A00
	public static byte[] SerializeToBytes(TargetDetectedAIEventData instance) { }

	// RVA: 0x1DC7950 Offset: 0x1DC5F50 VA: 0x181DC7950
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

	// RVA: 0x20A9220 Offset: 0x20A7820 VA: 0x1820A9220
	public static void ResetToPool(ChanceAIEventData instance) { }

	// RVA: 0x20A92A0 Offset: 0x20A78A0 VA: 0x1820A92A0
	public void ResetToPool() { }

	// RVA: 0x20A90F0 Offset: 0x20A76F0 VA: 0x1820A90F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE4D0 Offset: 0x1BFCAD0 VA: 0x181BFE4D0
	public void CopyTo(ChanceAIEventData instance) { }

	// RVA: 0x20A8760 Offset: 0x20A6D60 VA: 0x1820A8760
	public ChanceAIEventData Copy() { }

	// RVA: 0x20A8F20 Offset: 0x20A7520 VA: 0x1820A8F20
	public static ChanceAIEventData Deserialize(Stream stream) { }

	// RVA: 0x20A89F0 Offset: 0x20A6FF0 VA: 0x1820A89F0
	public static ChanceAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20A8A70 Offset: 0x20A7070 VA: 0x1820A8A70
	public static ChanceAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20A8D00 Offset: 0x20A7300 VA: 0x1820A8D00
	public static ChanceAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x20A91E0 Offset: 0x20A77E0 VA: 0x1820A91E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20A96F0 Offset: 0x20A7CF0 VA: 0x1820A96F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20A9710 Offset: 0x20A7D10 VA: 0x1820A9710 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ChanceAIEventData previous) { }

	// RVA: 0x20A9200 Offset: 0x20A7800 VA: 0x1820A9200 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20A8E20 Offset: 0x20A7420 VA: 0x1820A8E20
	public static ChanceAIEventData Deserialize(byte[] buffer, ChanceAIEventData instance, bool isDelta = False) { }

	// RVA: 0x20A8FA0 Offset: 0x20A75A0 VA: 0x1820A8FA0
	public static ChanceAIEventData Deserialize(Stream stream, ChanceAIEventData instance, bool isDelta) { }

	// RVA: 0x20A87D0 Offset: 0x20A6DD0 VA: 0x1820A87D0
	public static ChanceAIEventData DeserializeLengthDelimited(Stream stream, ChanceAIEventData instance, bool isDelta) { }

	// RVA: 0x20A8B00 Offset: 0x20A7100 VA: 0x1820A8B00
	public static ChanceAIEventData DeserializeLength(Stream stream, int length, ChanceAIEventData instance, bool isDelta) { }

	// RVA: 0x20A9320 Offset: 0x20A7920 VA: 0x1820A9320
	public static void SerializeDelta(Stream stream, ChanceAIEventData instance, ChanceAIEventData previous) { }

	// RVA: 0x20A9600 Offset: 0x20A7C00 VA: 0x1820A9600
	public static void Serialize(Stream stream, ChanceAIEventData instance) { }

	// RVA: 0x20A96E0 Offset: 0x20A7CE0 VA: 0x1820A96E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20A96F0 Offset: 0x20A7CF0 VA: 0x1820A96F0
	public void ToProto(Stream stream) { }

	// RVA: 0x20A94F0 Offset: 0x20A7AF0 VA: 0x1820A94F0
	public static byte[] SerializeToBytes(ChanceAIEventData instance) { }

	// RVA: 0x20A9440 Offset: 0x20A7A40 VA: 0x1820A9440
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

	// RVA: 0x1EED840 Offset: 0x1EEBE40 VA: 0x181EED840
	public static void ResetToPool(TimeSinceThreatAIEventData instance) { }

	// RVA: 0x1EED7C0 Offset: 0x1EEBDC0 VA: 0x181EED7C0
	public void ResetToPool() { }

	// RVA: 0x1EED690 Offset: 0x1EEBC90 VA: 0x181EED690 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE4D0 Offset: 0x1BFCAD0 VA: 0x181BFE4D0
	public void CopyTo(TimeSinceThreatAIEventData instance) { }

	// RVA: 0x1EECD00 Offset: 0x1EEB300 VA: 0x181EECD00
	public TimeSinceThreatAIEventData Copy() { }

	// RVA: 0x1EED3A0 Offset: 0x1EEB9A0 VA: 0x181EED3A0
	public static TimeSinceThreatAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1EECD70 Offset: 0x1EEB370 VA: 0x181EECD70
	public static TimeSinceThreatAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EED010 Offset: 0x1EEB610 VA: 0x181EED010
	public static TimeSinceThreatAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EED420 Offset: 0x1EEBA20 VA: 0x181EED420
	public static TimeSinceThreatAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1EED780 Offset: 0x1EEBD80 VA: 0x181EED780
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EEDC90 Offset: 0x1EEC290 VA: 0x181EEDC90 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EEDCB0 Offset: 0x1EEC2B0 VA: 0x181EEDCB0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, TimeSinceThreatAIEventData previous) { }

	// RVA: 0x1EED7A0 Offset: 0x1EEBDA0 VA: 0x181EED7A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EED2A0 Offset: 0x1EEB8A0 VA: 0x181EED2A0
	public static TimeSinceThreatAIEventData Deserialize(byte[] buffer, TimeSinceThreatAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1EED540 Offset: 0x1EEBB40 VA: 0x181EED540
	public static TimeSinceThreatAIEventData Deserialize(Stream stream, TimeSinceThreatAIEventData instance, bool isDelta) { }

	// RVA: 0x1EECDF0 Offset: 0x1EEB3F0 VA: 0x181EECDF0
	public static TimeSinceThreatAIEventData DeserializeLengthDelimited(Stream stream, TimeSinceThreatAIEventData instance, bool isDelta) { }

	// RVA: 0x1EED0A0 Offset: 0x1EEB6A0 VA: 0x181EED0A0
	public static TimeSinceThreatAIEventData DeserializeLength(Stream stream, int length, TimeSinceThreatAIEventData instance, bool isDelta) { }

	// RVA: 0x1EED8C0 Offset: 0x1EEBEC0 VA: 0x181EED8C0
	public static void SerializeDelta(Stream stream, TimeSinceThreatAIEventData instance, TimeSinceThreatAIEventData previous) { }

	// RVA: 0x1EEDBA0 Offset: 0x1EEC1A0 VA: 0x181EEDBA0
	public static void Serialize(Stream stream, TimeSinceThreatAIEventData instance) { }

	// RVA: 0x1EEDC80 Offset: 0x1EEC280 VA: 0x181EEDC80
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EEDC90 Offset: 0x1EEC290 VA: 0x181EEDC90
	public void ToProto(Stream stream) { }

	// RVA: 0x1EEDA90 Offset: 0x1EEC090 VA: 0x181EEDA90
	public static byte[] SerializeToBytes(TimeSinceThreatAIEventData instance) { }

	// RVA: 0x1EED9E0 Offset: 0x1EEBFE0 VA: 0x181EED9E0
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

	// RVA: 0x2013030 Offset: 0x2011630 VA: 0x182013030
	public static void ResetToPool(AggressionTimerAIEventData instance) { }

	// RVA: 0x20130B0 Offset: 0x20116B0 VA: 0x1820130B0
	public void ResetToPool() { }

	// RVA: 0x2012F70 Offset: 0x2011570 VA: 0x182012F70 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE4D0 Offset: 0x1BFCAD0 VA: 0x181BFE4D0
	public void CopyTo(AggressionTimerAIEventData instance) { }

	// RVA: 0x20125E0 Offset: 0x2010BE0 VA: 0x1820125E0
	public AggressionTimerAIEventData Copy() { }

	// RVA: 0x2012EF0 Offset: 0x20114F0 VA: 0x182012EF0
	public static AggressionTimerAIEventData Deserialize(Stream stream) { }

	// RVA: 0x2012870 Offset: 0x2010E70 VA: 0x182012870
	public static AggressionTimerAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20128F0 Offset: 0x2010EF0 VA: 0x1820128F0
	public static AggressionTimerAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2012DD0 Offset: 0x20113D0 VA: 0x182012DD0
	public static AggressionTimerAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x2012FF0 Offset: 0x20115F0 VA: 0x182012FF0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2013500 Offset: 0x2011B00 VA: 0x182013500 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2013520 Offset: 0x2011B20 VA: 0x182013520 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AggressionTimerAIEventData previous) { }

	// RVA: 0x2013010 Offset: 0x2011610 VA: 0x182013010 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2012B80 Offset: 0x2011180 VA: 0x182012B80
	public static AggressionTimerAIEventData Deserialize(byte[] buffer, AggressionTimerAIEventData instance, bool isDelta = False) { }

	// RVA: 0x2012C80 Offset: 0x2011280 VA: 0x182012C80
	public static AggressionTimerAIEventData Deserialize(Stream stream, AggressionTimerAIEventData instance, bool isDelta) { }

	// RVA: 0x2012650 Offset: 0x2010C50 VA: 0x182012650
	public static AggressionTimerAIEventData DeserializeLengthDelimited(Stream stream, AggressionTimerAIEventData instance, bool isDelta) { }

	// RVA: 0x2012980 Offset: 0x2010F80 VA: 0x182012980
	public static AggressionTimerAIEventData DeserializeLength(Stream stream, int length, AggressionTimerAIEventData instance, bool isDelta) { }

	// RVA: 0x2013130 Offset: 0x2011730 VA: 0x182013130
	public static void SerializeDelta(Stream stream, AggressionTimerAIEventData instance, AggressionTimerAIEventData previous) { }

	// RVA: 0x2013410 Offset: 0x2011A10 VA: 0x182013410
	public static void Serialize(Stream stream, AggressionTimerAIEventData instance) { }

	// RVA: 0x20134F0 Offset: 0x2011AF0 VA: 0x1820134F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x2013500 Offset: 0x2011B00 VA: 0x182013500
	public void ToProto(Stream stream) { }

	// RVA: 0x2013300 Offset: 0x2011900 VA: 0x182013300
	public static byte[] SerializeToBytes(AggressionTimerAIEventData instance) { }

	// RVA: 0x2013250 Offset: 0x2011850 VA: 0x182013250
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

	// RVA: 0x1C06A70 Offset: 0x1C05070 VA: 0x181C06A70
	public static void ResetToPool(InRangeOfHomeAIEventData instance) { }

	// RVA: 0x1C069F0 Offset: 0x1C04FF0 VA: 0x181C069F0
	public void ResetToPool() { }

	// RVA: 0x1C068C0 Offset: 0x1C04EC0 VA: 0x181C068C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE4D0 Offset: 0x1BFCAD0 VA: 0x181BFE4D0
	public void CopyTo(InRangeOfHomeAIEventData instance) { }

	// RVA: 0x1C05F30 Offset: 0x1C04530 VA: 0x181C05F30
	public InRangeOfHomeAIEventData Copy() { }

	// RVA: 0x1C064D0 Offset: 0x1C04AD0 VA: 0x181C064D0
	public static InRangeOfHomeAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1C061C0 Offset: 0x1C047C0 VA: 0x181C061C0
	public static InRangeOfHomeAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C06240 Offset: 0x1C04840 VA: 0x181C06240
	public static InRangeOfHomeAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C067A0 Offset: 0x1C04DA0 VA: 0x181C067A0
	public static InRangeOfHomeAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1C069B0 Offset: 0x1C04FB0 VA: 0x181C069B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C06EC0 Offset: 0x1C054C0 VA: 0x181C06EC0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C06EE0 Offset: 0x1C054E0 VA: 0x181C06EE0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, InRangeOfHomeAIEventData previous) { }

	// RVA: 0x1C069D0 Offset: 0x1C04FD0 VA: 0x181C069D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C06550 Offset: 0x1C04B50 VA: 0x181C06550
	public static InRangeOfHomeAIEventData Deserialize(byte[] buffer, InRangeOfHomeAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1C06650 Offset: 0x1C04C50 VA: 0x181C06650
	public static InRangeOfHomeAIEventData Deserialize(Stream stream, InRangeOfHomeAIEventData instance, bool isDelta) { }

	// RVA: 0x1C05FA0 Offset: 0x1C045A0 VA: 0x181C05FA0
	public static InRangeOfHomeAIEventData DeserializeLengthDelimited(Stream stream, InRangeOfHomeAIEventData instance, bool isDelta) { }

	// RVA: 0x1C062D0 Offset: 0x1C048D0 VA: 0x181C062D0
	public static InRangeOfHomeAIEventData DeserializeLength(Stream stream, int length, InRangeOfHomeAIEventData instance, bool isDelta) { }

	// RVA: 0x1C06AF0 Offset: 0x1C050F0 VA: 0x181C06AF0
	public static void SerializeDelta(Stream stream, InRangeOfHomeAIEventData instance, InRangeOfHomeAIEventData previous) { }

	// RVA: 0x1C06DD0 Offset: 0x1C053D0 VA: 0x181C06DD0
	public static void Serialize(Stream stream, InRangeOfHomeAIEventData instance) { }

	// RVA: 0x1C06EB0 Offset: 0x1C054B0 VA: 0x181C06EB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C06EC0 Offset: 0x1C054C0 VA: 0x181C06EC0
	public void ToProto(Stream stream) { }

	// RVA: 0x1C06CC0 Offset: 0x1C052C0 VA: 0x181C06CC0
	public static byte[] SerializeToBytes(InRangeOfHomeAIEventData instance) { }

	// RVA: 0x1C06C10 Offset: 0x1C05210 VA: 0x181C06C10
	public static void SerializeLengthDelimited(Stream stream, InRangeOfHomeAIEventData instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

internal struct ColorEventData // TypeDefIndex: 7701
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <Value>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ColorEventFrame <Frame>k__BackingField; // 0x4

	// Properties
	[JsonPropertyAttribute] // RVA: 0xBE8A0 Offset: 0xBDCA0 VA: 0x1800BE8A0
	public float Value { get; set; }
	[JsonPropertyAttribute] // RVA: 0xBE980 Offset: 0xBDD80 VA: 0x1800BE980
	public ColorEventFrame Frame { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2380 Offset: 0xF1780 VA: 0x1800F2380
	public float get_Value() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2390 Offset: 0xF1790 VA: 0x1800F2390
	public void set_Value(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x236D70 Offset: 0x236170 VA: 0x180236D70
	public ColorEventFrame get_Frame() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x236D90 Offset: 0x236190 VA: 0x180236D90
	public void set_Frame(ColorEventFrame value) { }

}

internal struct EmptyEventData // TypeDefIndex: 7704
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <Value>k__BackingField; // 0x0

	// Properties
	[JsonPropertyAttribute] // RVA: 0xBE8A0 Offset: 0xBDCA0 VA: 0x1800BE8A0
	public int Value { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3720 Offset: 0xF2B20 VA: 0x1800F3720
	public int get_Value() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850
	public void set_Value(int value) { }

}

