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
	// RVA: 0x10B5AE0 Offset: 0x10B40E0 VA: 0x1810B5AE0
	public Vector2 get_moveVector() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE74290 Offset: 0xE72890 VA: 0x180E74290
	public void set_moveVector(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	public MoveDirection get_moveDir() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0D60 Offset: 0x7CF360 VA: 0x1807D0D60
	public void set_moveDir(MoveDirection value) { }

	// RVA: 0x10B5A40 Offset: 0x10B4040 VA: 0x1810B5A40
	public void .ctor(EventSystem eventSystem) { }

}

public abstract class AbstractEventData // TypeDefIndex: 5047
{	// Fields
	protected bool m_Used; // 0x10

	// Properties
	public virtual bool used { get; }

	// Methods

	// RVA: 0x10B5280 Offset: 0x10B3880 VA: 0x1810B5280 Slot: 4
	public virtual void Reset() { }

	// RVA: 0x1020D30 Offset: 0x101F330 VA: 0x181020D30 Slot: 5
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

	// RVA: 0x10B5B00 Offset: 0x10B4100 VA: 0x1810B5B00
	public void .ctor(EventSystem eventSystem) { }

	// RVA: 0xE572D0 Offset: 0xE558D0 VA: 0x180E572D0
	public BaseInputModule get_currentInputModule() { }

	// RVA: 0xE572F0 Offset: 0xE558F0 VA: 0x180E572F0
	public GameObject get_selectedObject() { }

	// RVA: 0x10B5B30 Offset: 0x10B4130 VA: 0x1810B5B30
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
	// RVA: 0x6AD6C0 Offset: 0x6ABCC0 VA: 0x1806AD6C0
	public void set_rawPointerPress(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public GameObject get_pointerDrag() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	public void set_pointerDrag(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C8040 Offset: 0x10C6640 VA: 0x1810C8040
	public RaycastResult get_pointerCurrentRaycast() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C8230 Offset: 0x10C6830 VA: 0x1810C8230
	public void set_pointerCurrentRaycast(RaycastResult value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C8070 Offset: 0x10C6670 VA: 0x1810C8070
	public RaycastResult get_pointerPressRaycast() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C8270 Offset: 0x10C6870 VA: 0x1810C8270
	public void set_pointerPressRaycast(RaycastResult value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C7F90 Offset: 0x10C6590 VA: 0x1810C7F90
	public bool get_eligibleForClick() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C8220 Offset: 0x10C6820 VA: 0x1810C8220
	public void set_eligibleForClick(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107A0A0 Offset: 0x10786A0 VA: 0x18107A0A0
	public int get_pointerId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107A1E0 Offset: 0x10787E0 VA: 0x18107A1E0
	public void set_pointerId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C80B0 Offset: 0x10C66B0 VA: 0x1810C80B0
	public Vector2 get_position() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C8350 Offset: 0x10C6950 VA: 0x1810C8350
	public void set_position(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C7F60 Offset: 0x10C6560 VA: 0x1810C7F60
	public Vector2 get_delta() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C8200 Offset: 0x10C6800 VA: 0x1810C8200
	public void set_delta(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C8170 Offset: 0x10C6770 VA: 0x1810C8170
	public Vector2 get_pressPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C8360 Offset: 0x10C6960 VA: 0x1810C8360
	public void set_pressPosition(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C81D0 Offset: 0x10C67D0 VA: 0x1810C81D0
	public Vector3 get_worldPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C83B0 Offset: 0x10C69B0 VA: 0x1810C83B0
	public void set_worldPosition(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C81B0 Offset: 0x10C67B0 VA: 0x1810C81B0
	public Vector3 get_worldNormal() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C8390 Offset: 0x10C6990 VA: 0x1810C8390
	public void set_worldNormal(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C7F50 Offset: 0x10C6550 VA: 0x1810C7F50
	public float get_clickTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C81F0 Offset: 0x10C67F0 VA: 0x1810C81F0
	public void set_clickTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107A180 Offset: 0x1078780 VA: 0x18107A180
	public int get_clickCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107A320 Offset: 0x1078920 VA: 0x18107A320
	public void set_clickCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C8190 Offset: 0x10C6790 VA: 0x1810C8190
	public Vector2 get_scrollDelta() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C8370 Offset: 0x10C6970 VA: 0x1810C8370
	public void set_scrollDelta(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE66890 Offset: 0xE64E90 VA: 0x180E66890
	public bool get_useDragThreshold() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C8380 Offset: 0x10C6980 VA: 0x1810C8380
	public void set_useDragThreshold(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C7F80 Offset: 0x10C6580 VA: 0x1810C7F80
	public bool get_dragging() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C8210 Offset: 0x10C6810 VA: 0x1810C8210
	public void set_dragging(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC83130 Offset: 0xC81730 VA: 0x180C83130
	public PointerEventData.InputButton get_button() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107A350 Offset: 0x1078950 VA: 0x18107A350
	public void set_button(PointerEventData.InputButton value) { }

	// RVA: 0x10C7DE0 Offset: 0x10C63E0 VA: 0x1810C7DE0
	public void .ctor(EventSystem eventSystem) { }

	// RVA: 0x10C7AB0 Offset: 0x10C60B0 VA: 0x1810C7AB0
	public bool IsPointerMoving() { }

	// RVA: 0x10C7AE0 Offset: 0x10C60E0 VA: 0x1810C7AE0
	public bool IsScrolling() { }

	// RVA: 0x10C7FA0 Offset: 0x10C65A0 VA: 0x1810C7FA0
	public Camera get_enterEventCamera() { }

	// RVA: 0x10C80D0 Offset: 0x10C66D0 VA: 0x1810C80D0
	public Camera get_pressEventCamera() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public GameObject get_pointerPress() { }

	// RVA: 0x10C82B0 Offset: 0x10C68B0 VA: 0x1810C82B0
	public void set_pointerPress(GameObject value) { }

	// RVA: 0x10C7B10 Offset: 0x10C6110 VA: 0x1810C7B10 Slot: 3
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

	// RVA: 0x1EEF150 Offset: 0x1EED750 VA: 0x181EEF150
	public static void ResetToPool(TimerAIEventData instance) { }

	// RVA: 0x1EEF1D0 Offset: 0x1EED7D0 VA: 0x181EEF1D0
	public void ResetToPool() { }

	// RVA: 0x1EEEEB0 Offset: 0x1EED4B0 VA: 0x181EEEEB0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBEBA0 Offset: 0x1DBD1A0 VA: 0x181DBEBA0
	public void CopyTo(TimerAIEventData instance) { }

	// RVA: 0x1EEE0B0 Offset: 0x1EEC6B0 VA: 0x181EEE0B0
	public TimerAIEventData Copy() { }

	// RVA: 0x1EEE6B0 Offset: 0x1EECCB0 VA: 0x181EEE6B0
	public static TimerAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1EEE120 Offset: 0x1EEC720 VA: 0x181EEE120
	public static TimerAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EEE3F0 Offset: 0x1EEC9F0 VA: 0x181EEE3F0
	public static TimerAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EEE870 Offset: 0x1EECE70 VA: 0x181EEE870
	public static TimerAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1EEEFB0 Offset: 0x1EED5B0 VA: 0x181EEEFB0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EEF6A0 Offset: 0x1EEDCA0 VA: 0x181EEF6A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EEF6C0 Offset: 0x1EEDCC0 VA: 0x181EEF6C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, TimerAIEventData previous) { }

	// RVA: 0x1EEF130 Offset: 0x1EED730 VA: 0x181EEF130 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EEEAE0 Offset: 0x1EED0E0 VA: 0x181EEEAE0
	public static TimerAIEventData Deserialize(byte[] buffer, TimerAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1EEED30 Offset: 0x1EED330 VA: 0x181EEED30
	public static TimerAIEventData Deserialize(Stream stream, TimerAIEventData instance, bool isDelta) { }

	// RVA: 0x1EEE1A0 Offset: 0x1EEC7A0 VA: 0x181EEE1A0
	public static TimerAIEventData DeserializeLengthDelimited(Stream stream, TimerAIEventData instance, bool isDelta) { }

	// RVA: 0x1EEE480 Offset: 0x1EECA80 VA: 0x181EEE480
	public static TimerAIEventData DeserializeLength(Stream stream, int length, TimerAIEventData instance, bool isDelta) { }

	// RVA: 0x1EEF250 Offset: 0x1EED850 VA: 0x181EEF250
	public static void SerializeDelta(Stream stream, TimerAIEventData instance, TimerAIEventData previous) { }

	// RVA: 0x1EEF590 Offset: 0x1EEDB90 VA: 0x181EEF590
	public static void Serialize(Stream stream, TimerAIEventData instance) { }

	// RVA: 0x1EEF690 Offset: 0x1EEDC90 VA: 0x181EEF690
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EEF6A0 Offset: 0x1EEDCA0 VA: 0x181EEF6A0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EEF480 Offset: 0x1EEDA80 VA: 0x181EEF480
	public static byte[] SerializeToBytes(TimerAIEventData instance) { }

	// RVA: 0x1EEF3D0 Offset: 0x1EED9D0 VA: 0x181EEF3D0
	public static void SerializeLengthDelimited(Stream stream, TimerAIEventData instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class HealthBelowAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6545
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float healthFraction; // 0x14

	// Methods

	// RVA: 0x1D642A0 Offset: 0x1D628A0 VA: 0x181D642A0
	public static void ResetToPool(HealthBelowAIEventData instance) { }

	// RVA: 0x1D64320 Offset: 0x1D62920 VA: 0x181D64320
	public void ResetToPool() { }

	// RVA: 0x1D64170 Offset: 0x1D62770 VA: 0x181D64170 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE790 Offset: 0x1BFCD90 VA: 0x181BFE790
	public void CopyTo(HealthBelowAIEventData instance) { }

	// RVA: 0x1D637E0 Offset: 0x1D61DE0 VA: 0x181D637E0
	public HealthBelowAIEventData Copy() { }

	// RVA: 0x1D63D80 Offset: 0x1D62380 VA: 0x181D63D80
	public static HealthBelowAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1D63850 Offset: 0x1D61E50 VA: 0x181D63850
	public static HealthBelowAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D63AF0 Offset: 0x1D620F0 VA: 0x181D63AF0
	public static HealthBelowAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D63F50 Offset: 0x1D62550 VA: 0x181D63F50
	public static HealthBelowAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1D64260 Offset: 0x1D62860 VA: 0x181D64260
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D64770 Offset: 0x1D62D70 VA: 0x181D64770 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D64790 Offset: 0x1D62D90 VA: 0x181D64790 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, HealthBelowAIEventData previous) { }

	// RVA: 0x1D64280 Offset: 0x1D62880 VA: 0x181D64280 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D64070 Offset: 0x1D62670 VA: 0x181D64070
	public static HealthBelowAIEventData Deserialize(byte[] buffer, HealthBelowAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1D63E00 Offset: 0x1D62400 VA: 0x181D63E00
	public static HealthBelowAIEventData Deserialize(Stream stream, HealthBelowAIEventData instance, bool isDelta) { }

	// RVA: 0x1D638D0 Offset: 0x1D61ED0 VA: 0x181D638D0
	public static HealthBelowAIEventData DeserializeLengthDelimited(Stream stream, HealthBelowAIEventData instance, bool isDelta) { }

	// RVA: 0x1D63B80 Offset: 0x1D62180 VA: 0x181D63B80
	public static HealthBelowAIEventData DeserializeLength(Stream stream, int length, HealthBelowAIEventData instance, bool isDelta) { }

	// RVA: 0x1D643A0 Offset: 0x1D629A0 VA: 0x181D643A0
	public static void SerializeDelta(Stream stream, HealthBelowAIEventData instance, HealthBelowAIEventData previous) { }

	// RVA: 0x1D64680 Offset: 0x1D62C80 VA: 0x181D64680
	public static void Serialize(Stream stream, HealthBelowAIEventData instance) { }

	// RVA: 0x1D64760 Offset: 0x1D62D60 VA: 0x181D64760
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D64770 Offset: 0x1D62D70 VA: 0x181D64770
	public void ToProto(Stream stream) { }

	// RVA: 0x1D64570 Offset: 0x1D62B70 VA: 0x181D64570
	public static byte[] SerializeToBytes(HealthBelowAIEventData instance) { }

	// RVA: 0x1D644C0 Offset: 0x1D62AC0 VA: 0x181D644C0
	public static void SerializeLengthDelimited(Stream stream, HealthBelowAIEventData instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class InRangeAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6546
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float range; // 0x14

	// Methods

	// RVA: 0x1C05BC0 Offset: 0x1C041C0 VA: 0x181C05BC0
	public static void ResetToPool(InRangeAIEventData instance) { }

	// RVA: 0x1C05C40 Offset: 0x1C04240 VA: 0x181C05C40
	public void ResetToPool() { }

	// RVA: 0x1C05A90 Offset: 0x1C04090 VA: 0x181C05A90 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE790 Offset: 0x1BFCD90 VA: 0x181BFE790
	public void CopyTo(InRangeAIEventData instance) { }

	// RVA: 0x1C05100 Offset: 0x1C03700 VA: 0x181C05100
	public InRangeAIEventData Copy() { }

	// RVA: 0x1C056A0 Offset: 0x1C03CA0 VA: 0x181C056A0
	public static InRangeAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1C05170 Offset: 0x1C03770 VA: 0x181C05170
	public static InRangeAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C05610 Offset: 0x1C03C10 VA: 0x181C05610
	public static InRangeAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C05970 Offset: 0x1C03F70 VA: 0x181C05970
	public static InRangeAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1C05B80 Offset: 0x1C04180 VA: 0x181C05B80
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C06090 Offset: 0x1C04690 VA: 0x181C06090 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C060B0 Offset: 0x1C046B0 VA: 0x181C060B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, InRangeAIEventData previous) { }

	// RVA: 0x1C05BA0 Offset: 0x1C041A0 VA: 0x181C05BA0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C05720 Offset: 0x1C03D20 VA: 0x181C05720
	public static InRangeAIEventData Deserialize(byte[] buffer, InRangeAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1C05820 Offset: 0x1C03E20 VA: 0x181C05820
	public static InRangeAIEventData Deserialize(Stream stream, InRangeAIEventData instance, bool isDelta) { }

	// RVA: 0x1C051F0 Offset: 0x1C037F0 VA: 0x181C051F0
	public static InRangeAIEventData DeserializeLengthDelimited(Stream stream, InRangeAIEventData instance, bool isDelta) { }

	// RVA: 0x1C05410 Offset: 0x1C03A10 VA: 0x181C05410
	public static InRangeAIEventData DeserializeLength(Stream stream, int length, InRangeAIEventData instance, bool isDelta) { }

	// RVA: 0x1C05CC0 Offset: 0x1C042C0 VA: 0x181C05CC0
	public static void SerializeDelta(Stream stream, InRangeAIEventData instance, InRangeAIEventData previous) { }

	// RVA: 0x1C05FA0 Offset: 0x1C045A0 VA: 0x181C05FA0
	public static void Serialize(Stream stream, InRangeAIEventData instance) { }

	// RVA: 0x1C06080 Offset: 0x1C04680 VA: 0x181C06080
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C06090 Offset: 0x1C04690 VA: 0x181C06090
	public void ToProto(Stream stream) { }

	// RVA: 0x1C05E90 Offset: 0x1C04490 VA: 0x181C05E90
	public static byte[] SerializeToBytes(InRangeAIEventData instance) { }

	// RVA: 0x1C05DE0 Offset: 0x1C043E0 VA: 0x181C05DE0
	public static void SerializeLengthDelimited(Stream stream, InRangeAIEventData instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class HungerAboveAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6547
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float value; // 0x14

	// Methods

	// RVA: 0x1BFF270 Offset: 0x1BFD870 VA: 0x181BFF270
	public static void ResetToPool(HungerAboveAIEventData instance) { }

	// RVA: 0x1BFF2F0 Offset: 0x1BFD8F0 VA: 0x181BFF2F0
	public void ResetToPool() { }

	// RVA: 0x1BFF140 Offset: 0x1BFD740 VA: 0x181BFF140 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE790 Offset: 0x1BFCD90 VA: 0x181BFE790
	public void CopyTo(HungerAboveAIEventData instance) { }

	// RVA: 0x1BFE7B0 Offset: 0x1BFCDB0 VA: 0x181BFE7B0
	public HungerAboveAIEventData Copy() { }

	// RVA: 0x1BFED50 Offset: 0x1BFD350 VA: 0x181BFED50
	public static HungerAboveAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1BFE820 Offset: 0x1BFCE20 VA: 0x181BFE820
	public static HungerAboveAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1BFEAC0 Offset: 0x1BFD0C0 VA: 0x181BFEAC0
	public static HungerAboveAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1BFF020 Offset: 0x1BFD620 VA: 0x181BFF020
	public static HungerAboveAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1BFF230 Offset: 0x1BFD830 VA: 0x181BFF230
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1BFF740 Offset: 0x1BFDD40 VA: 0x181BFF740 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1BFF760 Offset: 0x1BFDD60 VA: 0x181BFF760 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, HungerAboveAIEventData previous) { }

	// RVA: 0x1BFF250 Offset: 0x1BFD850 VA: 0x181BFF250 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1BFEF20 Offset: 0x1BFD520 VA: 0x181BFEF20
	public static HungerAboveAIEventData Deserialize(byte[] buffer, HungerAboveAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1BFEDD0 Offset: 0x1BFD3D0 VA: 0x181BFEDD0
	public static HungerAboveAIEventData Deserialize(Stream stream, HungerAboveAIEventData instance, bool isDelta) { }

	// RVA: 0x1BFE8A0 Offset: 0x1BFCEA0 VA: 0x181BFE8A0
	public static HungerAboveAIEventData DeserializeLengthDelimited(Stream stream, HungerAboveAIEventData instance, bool isDelta) { }

	// RVA: 0x1BFEB50 Offset: 0x1BFD150 VA: 0x181BFEB50
	public static HungerAboveAIEventData DeserializeLength(Stream stream, int length, HungerAboveAIEventData instance, bool isDelta) { }

	// RVA: 0x1BFF370 Offset: 0x1BFD970 VA: 0x181BFF370
	public static void SerializeDelta(Stream stream, HungerAboveAIEventData instance, HungerAboveAIEventData previous) { }

	// RVA: 0x1BFF650 Offset: 0x1BFDC50 VA: 0x181BFF650
	public static void Serialize(Stream stream, HungerAboveAIEventData instance) { }

	// RVA: 0x1BFF730 Offset: 0x1BFDD30 VA: 0x181BFF730
	public byte[] ToProtoBytes() { }

	// RVA: 0x1BFF740 Offset: 0x1BFDD40 VA: 0x181BFF740
	public void ToProto(Stream stream) { }

	// RVA: 0x1BFF540 Offset: 0x1BFDB40 VA: 0x181BFF540
	public static byte[] SerializeToBytes(HungerAboveAIEventData instance) { }

	// RVA: 0x1BFF490 Offset: 0x1BFDA90 VA: 0x181BFF490
	public static void SerializeLengthDelimited(Stream stream, HungerAboveAIEventData instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class TirednessAboveAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6548
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float value; // 0x14

	// Methods

	// RVA: 0x1EF0310 Offset: 0x1EEE910 VA: 0x181EF0310
	public static void ResetToPool(TirednessAboveAIEventData instance) { }

	// RVA: 0x1EF0390 Offset: 0x1EEE990 VA: 0x181EF0390
	public void ResetToPool() { }

	// RVA: 0x1EF01E0 Offset: 0x1EEE7E0 VA: 0x181EF01E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE790 Offset: 0x1BFCD90 VA: 0x181BFE790
	public void CopyTo(TirednessAboveAIEventData instance) { }

	// RVA: 0x1EEF850 Offset: 0x1EEDE50 VA: 0x181EEF850
	public TirednessAboveAIEventData Copy() { }

	// RVA: 0x1EEFF40 Offset: 0x1EEE540 VA: 0x181EEFF40
	public static TirednessAboveAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1EEFAE0 Offset: 0x1EEE0E0 VA: 0x181EEFAE0
	public static TirednessAboveAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EEFD60 Offset: 0x1EEE360 VA: 0x181EEFD60
	public static TirednessAboveAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EEFFC0 Offset: 0x1EEE5C0 VA: 0x181EEFFC0
	public static TirednessAboveAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1EF02D0 Offset: 0x1EEE8D0 VA: 0x181EF02D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EF07E0 Offset: 0x1EEEDE0 VA: 0x181EF07E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EF0800 Offset: 0x1EEEE00 VA: 0x181EF0800 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, TirednessAboveAIEventData previous) { }

	// RVA: 0x1EF02F0 Offset: 0x1EEE8F0 VA: 0x181EF02F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EF00E0 Offset: 0x1EEE6E0 VA: 0x181EF00E0
	public static TirednessAboveAIEventData Deserialize(byte[] buffer, TirednessAboveAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1EEFDF0 Offset: 0x1EEE3F0 VA: 0x181EEFDF0
	public static TirednessAboveAIEventData Deserialize(Stream stream, TirednessAboveAIEventData instance, bool isDelta) { }

	// RVA: 0x1EEF8C0 Offset: 0x1EEDEC0 VA: 0x181EEF8C0
	public static TirednessAboveAIEventData DeserializeLengthDelimited(Stream stream, TirednessAboveAIEventData instance, bool isDelta) { }

	// RVA: 0x1EEFB60 Offset: 0x1EEE160 VA: 0x181EEFB60
	public static TirednessAboveAIEventData DeserializeLength(Stream stream, int length, TirednessAboveAIEventData instance, bool isDelta) { }

	// RVA: 0x1EF0410 Offset: 0x1EEEA10 VA: 0x181EF0410
	public static void SerializeDelta(Stream stream, TirednessAboveAIEventData instance, TirednessAboveAIEventData previous) { }

	// RVA: 0x1EF06F0 Offset: 0x1EEECF0 VA: 0x181EF06F0
	public static void Serialize(Stream stream, TirednessAboveAIEventData instance) { }

	// RVA: 0x1EF07D0 Offset: 0x1EEEDD0 VA: 0x181EF07D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EF07E0 Offset: 0x1EEEDE0 VA: 0x181EF07E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EF05E0 Offset: 0x1EEEBE0 VA: 0x181EF05E0
	public static byte[] SerializeToBytes(TirednessAboveAIEventData instance) { }

	// RVA: 0x1EF0530 Offset: 0x1EEEB30 VA: 0x181EF0530
	public static void SerializeLengthDelimited(Stream stream, TirednessAboveAIEventData instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class AmmoBelowAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6549
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float value; // 0x14

	// Methods

	// RVA: 0x20142D0 Offset: 0x20128D0 VA: 0x1820142D0
	public static void ResetToPool(AmmoBelowAIEventData instance) { }

	// RVA: 0x2014250 Offset: 0x2012850 VA: 0x182014250
	public void ResetToPool() { }

	// RVA: 0x2014190 Offset: 0x2012790 VA: 0x182014190 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE790 Offset: 0x1BFCD90 VA: 0x181BFE790
	public void CopyTo(AmmoBelowAIEventData instance) { }

	// RVA: 0x2013800 Offset: 0x2011E00 VA: 0x182013800
	public AmmoBelowAIEventData Copy() { }

	// RVA: 0x2013FC0 Offset: 0x20125C0 VA: 0x182013FC0
	public static AmmoBelowAIEventData Deserialize(Stream stream) { }

	// RVA: 0x2013870 Offset: 0x2011E70 VA: 0x182013870
	public static AmmoBelowAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2013D10 Offset: 0x2012310 VA: 0x182013D10
	public static AmmoBelowAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2013EA0 Offset: 0x20124A0 VA: 0x182013EA0
	public static AmmoBelowAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x2014210 Offset: 0x2012810 VA: 0x182014210
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2014720 Offset: 0x2012D20 VA: 0x182014720 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2014740 Offset: 0x2012D40 VA: 0x182014740 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AmmoBelowAIEventData previous) { }

	// RVA: 0x2014230 Offset: 0x2012830 VA: 0x182014230 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2013DA0 Offset: 0x20123A0 VA: 0x182013DA0
	public static AmmoBelowAIEventData Deserialize(byte[] buffer, AmmoBelowAIEventData instance, bool isDelta = False) { }

	// RVA: 0x2014040 Offset: 0x2012640 VA: 0x182014040
	public static AmmoBelowAIEventData Deserialize(Stream stream, AmmoBelowAIEventData instance, bool isDelta) { }

	// RVA: 0x20138F0 Offset: 0x2011EF0 VA: 0x1820138F0
	public static AmmoBelowAIEventData DeserializeLengthDelimited(Stream stream, AmmoBelowAIEventData instance, bool isDelta) { }

	// RVA: 0x2013B10 Offset: 0x2012110 VA: 0x182013B10
	public static AmmoBelowAIEventData DeserializeLength(Stream stream, int length, AmmoBelowAIEventData instance, bool isDelta) { }

	// RVA: 0x2014350 Offset: 0x2012950 VA: 0x182014350
	public static void SerializeDelta(Stream stream, AmmoBelowAIEventData instance, AmmoBelowAIEventData previous) { }

	// RVA: 0x2014630 Offset: 0x2012C30 VA: 0x182014630
	public static void Serialize(Stream stream, AmmoBelowAIEventData instance) { }

	// RVA: 0x2014710 Offset: 0x2012D10 VA: 0x182014710
	public byte[] ToProtoBytes() { }

	// RVA: 0x2014720 Offset: 0x2012D20 VA: 0x182014720
	public void ToProto(Stream stream) { }

	// RVA: 0x2014520 Offset: 0x2012B20 VA: 0x182014520
	public static byte[] SerializeToBytes(AmmoBelowAIEventData instance) { }

	// RVA: 0x2014470 Offset: 0x2012A70 VA: 0x182014470
	public static void SerializeLengthDelimited(Stream stream, AmmoBelowAIEventData instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class ThreatDetectedAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6550
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float range; // 0x14

	// Methods

	// RVA: 0x1EECA10 Offset: 0x1EEB010 VA: 0x181EECA10
	public static void ResetToPool(ThreatDetectedAIEventData instance) { }

	// RVA: 0x1EEC990 Offset: 0x1EEAF90 VA: 0x181EEC990
	public void ResetToPool() { }

	// RVA: 0x1EEC860 Offset: 0x1EEAE60 VA: 0x181EEC860 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE790 Offset: 0x1BFCD90 VA: 0x181BFE790
	public void CopyTo(ThreatDetectedAIEventData instance) { }

	// RVA: 0x1EEBED0 Offset: 0x1EEA4D0 VA: 0x181EEBED0
	public ThreatDetectedAIEventData Copy() { }

	// RVA: 0x1EEC7E0 Offset: 0x1EEADE0 VA: 0x181EEC7E0
	public static ThreatDetectedAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1EEBF40 Offset: 0x1EEA540 VA: 0x181EEBF40
	public static ThreatDetectedAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EEC1E0 Offset: 0x1EEA7E0 VA: 0x181EEC1E0
	public static ThreatDetectedAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EEC570 Offset: 0x1EEAB70 VA: 0x181EEC570
	public static ThreatDetectedAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1EEC950 Offset: 0x1EEAF50 VA: 0x181EEC950
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EECE60 Offset: 0x1EEB460 VA: 0x181EECE60 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EECE80 Offset: 0x1EEB480 VA: 0x181EECE80 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ThreatDetectedAIEventData previous) { }

	// RVA: 0x1EEC970 Offset: 0x1EEAF70 VA: 0x181EEC970 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EEC470 Offset: 0x1EEAA70 VA: 0x181EEC470
	public static ThreatDetectedAIEventData Deserialize(byte[] buffer, ThreatDetectedAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1EEC690 Offset: 0x1EEAC90 VA: 0x181EEC690
	public static ThreatDetectedAIEventData Deserialize(Stream stream, ThreatDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1EEBFC0 Offset: 0x1EEA5C0 VA: 0x181EEBFC0
	public static ThreatDetectedAIEventData DeserializeLengthDelimited(Stream stream, ThreatDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1EEC270 Offset: 0x1EEA870 VA: 0x181EEC270
	public static ThreatDetectedAIEventData DeserializeLength(Stream stream, int length, ThreatDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1EECA90 Offset: 0x1EEB090 VA: 0x181EECA90
	public static void SerializeDelta(Stream stream, ThreatDetectedAIEventData instance, ThreatDetectedAIEventData previous) { }

	// RVA: 0x1EECD70 Offset: 0x1EEB370 VA: 0x181EECD70
	public static void Serialize(Stream stream, ThreatDetectedAIEventData instance) { }

	// RVA: 0x1EECE50 Offset: 0x1EEB450 VA: 0x181EECE50
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EECE60 Offset: 0x1EEB460 VA: 0x181EECE60
	public void ToProto(Stream stream) { }

	// RVA: 0x1EECC60 Offset: 0x1EEB260 VA: 0x181EECC60
	public static byte[] SerializeToBytes(ThreatDetectedAIEventData instance) { }

	// RVA: 0x1EECBB0 Offset: 0x1EEB1B0 VA: 0x181EECBB0
	public static void SerializeLengthDelimited(Stream stream, ThreatDetectedAIEventData instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class TargetDetectedAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6551
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float range; // 0x14

	// Methods

	// RVA: 0x1DC7A70 Offset: 0x1DC6070 VA: 0x181DC7A70
	public static void ResetToPool(TargetDetectedAIEventData instance) { }

	// RVA: 0x1DC79F0 Offset: 0x1DC5FF0 VA: 0x181DC79F0
	public void ResetToPool() { }

	// RVA: 0x1DC78C0 Offset: 0x1DC5EC0 VA: 0x181DC78C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE790 Offset: 0x1BFCD90 VA: 0x181BFE790
	public void CopyTo(TargetDetectedAIEventData instance) { }

	// RVA: 0x1DC6F30 Offset: 0x1DC5530 VA: 0x181DC6F30
	public TargetDetectedAIEventData Copy() { }

	// RVA: 0x1DC74D0 Offset: 0x1DC5AD0 VA: 0x181DC74D0
	public static TargetDetectedAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1DC6FA0 Offset: 0x1DC55A0 VA: 0x181DC6FA0
	public static TargetDetectedAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DC7240 Offset: 0x1DC5840 VA: 0x181DC7240
	public static TargetDetectedAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DC7650 Offset: 0x1DC5C50 VA: 0x181DC7650
	public static TargetDetectedAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1DC79B0 Offset: 0x1DC5FB0 VA: 0x181DC79B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DC7EC0 Offset: 0x1DC64C0 VA: 0x181DC7EC0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DC7EE0 Offset: 0x1DC64E0 VA: 0x181DC7EE0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, TargetDetectedAIEventData previous) { }

	// RVA: 0x1DC79D0 Offset: 0x1DC5FD0 VA: 0x181DC79D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DC7550 Offset: 0x1DC5B50 VA: 0x181DC7550
	public static TargetDetectedAIEventData Deserialize(byte[] buffer, TargetDetectedAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1DC7770 Offset: 0x1DC5D70 VA: 0x181DC7770
	public static TargetDetectedAIEventData Deserialize(Stream stream, TargetDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1DC7020 Offset: 0x1DC5620 VA: 0x181DC7020
	public static TargetDetectedAIEventData DeserializeLengthDelimited(Stream stream, TargetDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1DC72D0 Offset: 0x1DC58D0 VA: 0x181DC72D0
	public static TargetDetectedAIEventData DeserializeLength(Stream stream, int length, TargetDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1DC7AF0 Offset: 0x1DC60F0 VA: 0x181DC7AF0
	public static void SerializeDelta(Stream stream, TargetDetectedAIEventData instance, TargetDetectedAIEventData previous) { }

	// RVA: 0x1DC7DD0 Offset: 0x1DC63D0 VA: 0x181DC7DD0
	public static void Serialize(Stream stream, TargetDetectedAIEventData instance) { }

	// RVA: 0x1DC7EB0 Offset: 0x1DC64B0 VA: 0x181DC7EB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DC7EC0 Offset: 0x1DC64C0 VA: 0x181DC7EC0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DC7CC0 Offset: 0x1DC62C0 VA: 0x181DC7CC0
	public static byte[] SerializeToBytes(TargetDetectedAIEventData instance) { }

	// RVA: 0x1DC7C10 Offset: 0x1DC6210 VA: 0x181DC7C10
	public static void SerializeLengthDelimited(Stream stream, TargetDetectedAIEventData instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class ChanceAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6552
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float value; // 0x14

	// Methods

	// RVA: 0x20A94E0 Offset: 0x20A7AE0 VA: 0x1820A94E0
	public static void ResetToPool(ChanceAIEventData instance) { }

	// RVA: 0x20A9560 Offset: 0x20A7B60 VA: 0x1820A9560
	public void ResetToPool() { }

	// RVA: 0x20A93B0 Offset: 0x20A79B0 VA: 0x1820A93B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE790 Offset: 0x1BFCD90 VA: 0x181BFE790
	public void CopyTo(ChanceAIEventData instance) { }

	// RVA: 0x20A8A20 Offset: 0x20A7020 VA: 0x1820A8A20
	public ChanceAIEventData Copy() { }

	// RVA: 0x20A91E0 Offset: 0x20A77E0 VA: 0x1820A91E0
	public static ChanceAIEventData Deserialize(Stream stream) { }

	// RVA: 0x20A8CB0 Offset: 0x20A72B0 VA: 0x1820A8CB0
	public static ChanceAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20A8D30 Offset: 0x20A7330 VA: 0x1820A8D30
	public static ChanceAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20A8FC0 Offset: 0x20A75C0 VA: 0x1820A8FC0
	public static ChanceAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x20A94A0 Offset: 0x20A7AA0 VA: 0x1820A94A0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20A99B0 Offset: 0x20A7FB0 VA: 0x1820A99B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20A99D0 Offset: 0x20A7FD0 VA: 0x1820A99D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ChanceAIEventData previous) { }

	// RVA: 0x20A94C0 Offset: 0x20A7AC0 VA: 0x1820A94C0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20A90E0 Offset: 0x20A76E0 VA: 0x1820A90E0
	public static ChanceAIEventData Deserialize(byte[] buffer, ChanceAIEventData instance, bool isDelta = False) { }

	// RVA: 0x20A9260 Offset: 0x20A7860 VA: 0x1820A9260
	public static ChanceAIEventData Deserialize(Stream stream, ChanceAIEventData instance, bool isDelta) { }

	// RVA: 0x20A8A90 Offset: 0x20A7090 VA: 0x1820A8A90
	public static ChanceAIEventData DeserializeLengthDelimited(Stream stream, ChanceAIEventData instance, bool isDelta) { }

	// RVA: 0x20A8DC0 Offset: 0x20A73C0 VA: 0x1820A8DC0
	public static ChanceAIEventData DeserializeLength(Stream stream, int length, ChanceAIEventData instance, bool isDelta) { }

	// RVA: 0x20A95E0 Offset: 0x20A7BE0 VA: 0x1820A95E0
	public static void SerializeDelta(Stream stream, ChanceAIEventData instance, ChanceAIEventData previous) { }

	// RVA: 0x20A98C0 Offset: 0x20A7EC0 VA: 0x1820A98C0
	public static void Serialize(Stream stream, ChanceAIEventData instance) { }

	// RVA: 0x20A99A0 Offset: 0x20A7FA0 VA: 0x1820A99A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20A99B0 Offset: 0x20A7FB0 VA: 0x1820A99B0
	public void ToProto(Stream stream) { }

	// RVA: 0x20A97B0 Offset: 0x20A7DB0 VA: 0x1820A97B0
	public static byte[] SerializeToBytes(ChanceAIEventData instance) { }

	// RVA: 0x20A9700 Offset: 0x20A7D00 VA: 0x1820A9700
	public static void SerializeLengthDelimited(Stream stream, ChanceAIEventData instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class TimeSinceThreatAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6553
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float value; // 0x14

	// Methods

	// RVA: 0x1EEDB00 Offset: 0x1EEC100 VA: 0x181EEDB00
	public static void ResetToPool(TimeSinceThreatAIEventData instance) { }

	// RVA: 0x1EEDA80 Offset: 0x1EEC080 VA: 0x181EEDA80
	public void ResetToPool() { }

	// RVA: 0x1EED950 Offset: 0x1EEBF50 VA: 0x181EED950 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE790 Offset: 0x1BFCD90 VA: 0x181BFE790
	public void CopyTo(TimeSinceThreatAIEventData instance) { }

	// RVA: 0x1EECFC0 Offset: 0x1EEB5C0 VA: 0x181EECFC0
	public TimeSinceThreatAIEventData Copy() { }

	// RVA: 0x1EED660 Offset: 0x1EEBC60 VA: 0x181EED660
	public static TimeSinceThreatAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1EED030 Offset: 0x1EEB630 VA: 0x181EED030
	public static TimeSinceThreatAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EED2D0 Offset: 0x1EEB8D0 VA: 0x181EED2D0
	public static TimeSinceThreatAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EED6E0 Offset: 0x1EEBCE0 VA: 0x181EED6E0
	public static TimeSinceThreatAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1EEDA40 Offset: 0x1EEC040 VA: 0x181EEDA40
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EEDF50 Offset: 0x1EEC550 VA: 0x181EEDF50 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EEDF70 Offset: 0x1EEC570 VA: 0x181EEDF70 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, TimeSinceThreatAIEventData previous) { }

	// RVA: 0x1EEDA60 Offset: 0x1EEC060 VA: 0x181EEDA60 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EED560 Offset: 0x1EEBB60 VA: 0x181EED560
	public static TimeSinceThreatAIEventData Deserialize(byte[] buffer, TimeSinceThreatAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1EED800 Offset: 0x1EEBE00 VA: 0x181EED800
	public static TimeSinceThreatAIEventData Deserialize(Stream stream, TimeSinceThreatAIEventData instance, bool isDelta) { }

	// RVA: 0x1EED0B0 Offset: 0x1EEB6B0 VA: 0x181EED0B0
	public static TimeSinceThreatAIEventData DeserializeLengthDelimited(Stream stream, TimeSinceThreatAIEventData instance, bool isDelta) { }

	// RVA: 0x1EED360 Offset: 0x1EEB960 VA: 0x181EED360
	public static TimeSinceThreatAIEventData DeserializeLength(Stream stream, int length, TimeSinceThreatAIEventData instance, bool isDelta) { }

	// RVA: 0x1EEDB80 Offset: 0x1EEC180 VA: 0x181EEDB80
	public static void SerializeDelta(Stream stream, TimeSinceThreatAIEventData instance, TimeSinceThreatAIEventData previous) { }

	// RVA: 0x1EEDE60 Offset: 0x1EEC460 VA: 0x181EEDE60
	public static void Serialize(Stream stream, TimeSinceThreatAIEventData instance) { }

	// RVA: 0x1EEDF40 Offset: 0x1EEC540 VA: 0x181EEDF40
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EEDF50 Offset: 0x1EEC550 VA: 0x181EEDF50
	public void ToProto(Stream stream) { }

	// RVA: 0x1EEDD50 Offset: 0x1EEC350 VA: 0x181EEDD50
	public static byte[] SerializeToBytes(TimeSinceThreatAIEventData instance) { }

	// RVA: 0x1EEDCA0 Offset: 0x1EEC2A0 VA: 0x181EEDCA0
	public static void SerializeLengthDelimited(Stream stream, TimeSinceThreatAIEventData instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class AggressionTimerAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6554
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float value; // 0x14

	// Methods

	// RVA: 0x20132F0 Offset: 0x20118F0 VA: 0x1820132F0
	public static void ResetToPool(AggressionTimerAIEventData instance) { }

	// RVA: 0x2013370 Offset: 0x2011970 VA: 0x182013370
	public void ResetToPool() { }

	// RVA: 0x2013230 Offset: 0x2011830 VA: 0x182013230 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE790 Offset: 0x1BFCD90 VA: 0x181BFE790
	public void CopyTo(AggressionTimerAIEventData instance) { }

	// RVA: 0x20128A0 Offset: 0x2010EA0 VA: 0x1820128A0
	public AggressionTimerAIEventData Copy() { }

	// RVA: 0x20131B0 Offset: 0x20117B0 VA: 0x1820131B0
	public static AggressionTimerAIEventData Deserialize(Stream stream) { }

	// RVA: 0x2012B30 Offset: 0x2011130 VA: 0x182012B30
	public static AggressionTimerAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2012BB0 Offset: 0x20111B0 VA: 0x182012BB0
	public static AggressionTimerAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2013090 Offset: 0x2011690 VA: 0x182013090
	public static AggressionTimerAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x20132B0 Offset: 0x20118B0 VA: 0x1820132B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20137C0 Offset: 0x2011DC0 VA: 0x1820137C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20137E0 Offset: 0x2011DE0 VA: 0x1820137E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AggressionTimerAIEventData previous) { }

	// RVA: 0x20132D0 Offset: 0x20118D0 VA: 0x1820132D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2012E40 Offset: 0x2011440 VA: 0x182012E40
	public static AggressionTimerAIEventData Deserialize(byte[] buffer, AggressionTimerAIEventData instance, bool isDelta = False) { }

	// RVA: 0x2012F40 Offset: 0x2011540 VA: 0x182012F40
	public static AggressionTimerAIEventData Deserialize(Stream stream, AggressionTimerAIEventData instance, bool isDelta) { }

	// RVA: 0x2012910 Offset: 0x2010F10 VA: 0x182012910
	public static AggressionTimerAIEventData DeserializeLengthDelimited(Stream stream, AggressionTimerAIEventData instance, bool isDelta) { }

	// RVA: 0x2012C40 Offset: 0x2011240 VA: 0x182012C40
	public static AggressionTimerAIEventData DeserializeLength(Stream stream, int length, AggressionTimerAIEventData instance, bool isDelta) { }

	// RVA: 0x20133F0 Offset: 0x20119F0 VA: 0x1820133F0
	public static void SerializeDelta(Stream stream, AggressionTimerAIEventData instance, AggressionTimerAIEventData previous) { }

	// RVA: 0x20136D0 Offset: 0x2011CD0 VA: 0x1820136D0
	public static void Serialize(Stream stream, AggressionTimerAIEventData instance) { }

	// RVA: 0x20137B0 Offset: 0x2011DB0 VA: 0x1820137B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20137C0 Offset: 0x2011DC0 VA: 0x1820137C0
	public void ToProto(Stream stream) { }

	// RVA: 0x20135C0 Offset: 0x2011BC0 VA: 0x1820135C0
	public static byte[] SerializeToBytes(AggressionTimerAIEventData instance) { }

	// RVA: 0x2013510 Offset: 0x2011B10 VA: 0x182013510
	public static void SerializeLengthDelimited(Stream stream, AggressionTimerAIEventData instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class InRangeOfHomeAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6556
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float range; // 0x14

	// Methods

	// RVA: 0x1C06D30 Offset: 0x1C05330 VA: 0x181C06D30
	public static void ResetToPool(InRangeOfHomeAIEventData instance) { }

	// RVA: 0x1C06CB0 Offset: 0x1C052B0 VA: 0x181C06CB0
	public void ResetToPool() { }

	// RVA: 0x1C06B80 Offset: 0x1C05180 VA: 0x181C06B80 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE790 Offset: 0x1BFCD90 VA: 0x181BFE790
	public void CopyTo(InRangeOfHomeAIEventData instance) { }

	// RVA: 0x1C061F0 Offset: 0x1C047F0 VA: 0x181C061F0
	public InRangeOfHomeAIEventData Copy() { }

	// RVA: 0x1C06790 Offset: 0x1C04D90 VA: 0x181C06790
	public static InRangeOfHomeAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1C06480 Offset: 0x1C04A80 VA: 0x181C06480
	public static InRangeOfHomeAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C06500 Offset: 0x1C04B00 VA: 0x181C06500
	public static InRangeOfHomeAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C06A60 Offset: 0x1C05060 VA: 0x181C06A60
	public static InRangeOfHomeAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1C06C70 Offset: 0x1C05270 VA: 0x181C06C70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C07180 Offset: 0x1C05780 VA: 0x181C07180 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C071A0 Offset: 0x1C057A0 VA: 0x181C071A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, InRangeOfHomeAIEventData previous) { }

	// RVA: 0x1C06C90 Offset: 0x1C05290 VA: 0x181C06C90 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C06810 Offset: 0x1C04E10 VA: 0x181C06810
	public static InRangeOfHomeAIEventData Deserialize(byte[] buffer, InRangeOfHomeAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1C06910 Offset: 0x1C04F10 VA: 0x181C06910
	public static InRangeOfHomeAIEventData Deserialize(Stream stream, InRangeOfHomeAIEventData instance, bool isDelta) { }

	// RVA: 0x1C06260 Offset: 0x1C04860 VA: 0x181C06260
	public static InRangeOfHomeAIEventData DeserializeLengthDelimited(Stream stream, InRangeOfHomeAIEventData instance, bool isDelta) { }

	// RVA: 0x1C06590 Offset: 0x1C04B90 VA: 0x181C06590
	public static InRangeOfHomeAIEventData DeserializeLength(Stream stream, int length, InRangeOfHomeAIEventData instance, bool isDelta) { }

	// RVA: 0x1C06DB0 Offset: 0x1C053B0 VA: 0x181C06DB0
	public static void SerializeDelta(Stream stream, InRangeOfHomeAIEventData instance, InRangeOfHomeAIEventData previous) { }

	// RVA: 0x1C07090 Offset: 0x1C05690 VA: 0x181C07090
	public static void Serialize(Stream stream, InRangeOfHomeAIEventData instance) { }

	// RVA: 0x1C07170 Offset: 0x1C05770 VA: 0x181C07170
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C07180 Offset: 0x1C05780 VA: 0x181C07180
	public void ToProto(Stream stream) { }

	// RVA: 0x1C06F80 Offset: 0x1C05580 VA: 0x181C06F80
	public static byte[] SerializeToBytes(InRangeOfHomeAIEventData instance) { }

	// RVA: 0x1C06ED0 Offset: 0x1C054D0 VA: 0x181C06ED0
	public static void SerializeLengthDelimited(Stream stream, InRangeOfHomeAIEventData instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

