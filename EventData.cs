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

	// RVA: 0x57C960 Offset: 0x57AF60 VA: 0x18057C960
	internal EventOpcode get_Opcode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal EventKeywords get_Keywords() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BE590 Offset: 0x4BCB90 VA: 0x1804BE590
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
	// RVA: 0x10B6550 Offset: 0x10B4B50 VA: 0x1810B6550
	public Vector2 get_moveVector() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE74D40 Offset: 0xE73340 VA: 0x180E74D40
	public void set_moveVector(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BE590 Offset: 0x4BCB90 VA: 0x1804BE590
	public MoveDirection get_moveDir() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79C680 Offset: 0x79AC80 VA: 0x18079C680
	public void set_moveDir(MoveDirection value) { }

	// RVA: 0x10B64B0 Offset: 0x10B4AB0 VA: 0x1810B64B0
	public void .ctor(EventSystem eventSystem) { }

}

public abstract class AbstractEventData // TypeDefIndex: 5047
{	// Fields
	protected bool m_Used; // 0x10

	// Properties
	public virtual bool used { get; }

	// Methods

	// RVA: 0x10B5CF0 Offset: 0x10B42F0 VA: 0x1810B5CF0 Slot: 4
	public virtual void Reset() { }

	// RVA: 0x10217D0 Offset: 0x101FDD0 VA: 0x1810217D0 Slot: 5
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

	// RVA: 0x10B6570 Offset: 0x10B4B70 VA: 0x1810B6570
	public void .ctor(EventSystem eventSystem) { }

	// RVA: 0xE57D80 Offset: 0xE56380 VA: 0x180E57D80
	public BaseInputModule get_currentInputModule() { }

	// RVA: 0xE57DA0 Offset: 0xE563A0 VA: 0x180E57DA0
	public GameObject get_selectedObject() { }

	// RVA: 0x10B65A0 Offset: 0x10B4BA0 VA: 0x1810B65A0
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
	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public GameObject get_lastPress() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	private void set_lastPress(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public GameObject get_rawPointerPress() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6AD650 Offset: 0x6ABC50 VA: 0x1806AD650
	public void set_rawPointerPress(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public GameObject get_pointerDrag() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5A0 Offset: 0x4BABA0 VA: 0x1804BC5A0
	public void set_pointerDrag(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C8AB0 Offset: 0x10C70B0 VA: 0x1810C8AB0
	public RaycastResult get_pointerCurrentRaycast() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C8CA0 Offset: 0x10C72A0 VA: 0x1810C8CA0
	public void set_pointerCurrentRaycast(RaycastResult value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C8AE0 Offset: 0x10C70E0 VA: 0x1810C8AE0
	public RaycastResult get_pointerPressRaycast() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C8CE0 Offset: 0x10C72E0 VA: 0x1810C8CE0
	public void set_pointerPressRaycast(RaycastResult value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C8A00 Offset: 0x10C7000 VA: 0x1810C8A00
	public bool get_eligibleForClick() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C8C90 Offset: 0x10C7290 VA: 0x1810C8C90
	public void set_eligibleForClick(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AB10 Offset: 0x1079110 VA: 0x18107AB10
	public int get_pointerId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AC50 Offset: 0x1079250 VA: 0x18107AC50
	public void set_pointerId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C8B20 Offset: 0x10C7120 VA: 0x1810C8B20
	public Vector2 get_position() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C8DC0 Offset: 0x10C73C0 VA: 0x1810C8DC0
	public void set_position(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C89D0 Offset: 0x10C6FD0 VA: 0x1810C89D0
	public Vector2 get_delta() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C8C70 Offset: 0x10C7270 VA: 0x1810C8C70
	public void set_delta(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C8BE0 Offset: 0x10C71E0 VA: 0x1810C8BE0
	public Vector2 get_pressPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C8DD0 Offset: 0x10C73D0 VA: 0x1810C8DD0
	public void set_pressPosition(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C8C40 Offset: 0x10C7240 VA: 0x1810C8C40
	public Vector3 get_worldPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C8E20 Offset: 0x10C7420 VA: 0x1810C8E20
	public void set_worldPosition(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C8C20 Offset: 0x10C7220 VA: 0x1810C8C20
	public Vector3 get_worldNormal() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C8E00 Offset: 0x10C7400 VA: 0x1810C8E00
	public void set_worldNormal(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C89C0 Offset: 0x10C6FC0 VA: 0x1810C89C0
	public float get_clickTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C8C60 Offset: 0x10C7260 VA: 0x1810C8C60
	public void set_clickTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107ABF0 Offset: 0x10791F0 VA: 0x18107ABF0
	public int get_clickCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AD90 Offset: 0x1079390 VA: 0x18107AD90
	public void set_clickCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C8C00 Offset: 0x10C7200 VA: 0x1810C8C00
	public Vector2 get_scrollDelta() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C8DE0 Offset: 0x10C73E0 VA: 0x1810C8DE0
	public void set_scrollDelta(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE67340 Offset: 0xE65940 VA: 0x180E67340
	public bool get_useDragThreshold() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C8DF0 Offset: 0x10C73F0 VA: 0x1810C8DF0
	public void set_useDragThreshold(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C89F0 Offset: 0x10C6FF0 VA: 0x1810C89F0
	public bool get_dragging() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10C8C80 Offset: 0x10C7280 VA: 0x1810C8C80
	public void set_dragging(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC835D0 Offset: 0xC81BD0 VA: 0x180C835D0
	public PointerEventData.InputButton get_button() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107ADC0 Offset: 0x10793C0 VA: 0x18107ADC0
	public void set_button(PointerEventData.InputButton value) { }

	// RVA: 0x10C8850 Offset: 0x10C6E50 VA: 0x1810C8850
	public void .ctor(EventSystem eventSystem) { }

	// RVA: 0x10C8520 Offset: 0x10C6B20 VA: 0x1810C8520
	public bool IsPointerMoving() { }

	// RVA: 0x10C8550 Offset: 0x10C6B50 VA: 0x1810C8550
	public bool IsScrolling() { }

	// RVA: 0x10C8A10 Offset: 0x10C7010 VA: 0x1810C8A10
	public Camera get_enterEventCamera() { }

	// RVA: 0x10C8B40 Offset: 0x10C7140 VA: 0x1810C8B40
	public Camera get_pressEventCamera() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public GameObject get_pointerPress() { }

	// RVA: 0x10C8D20 Offset: 0x10C7320 VA: 0x1810C8D20
	public void set_pointerPress(GameObject value) { }

	// RVA: 0x10C8580 Offset: 0x10C6B80 VA: 0x1810C8580 Slot: 3
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

	// RVA: 0x1EEF970 Offset: 0x1EEDF70 VA: 0x181EEF970
	public static void ResetToPool(TimerAIEventData instance) { }

	// RVA: 0x1EEF9F0 Offset: 0x1EEDFF0 VA: 0x181EEF9F0
	public void ResetToPool() { }

	// RVA: 0x1EEF6D0 Offset: 0x1EEDCD0 VA: 0x181EEF6D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBF390 Offset: 0x1DBD990 VA: 0x181DBF390
	public void CopyTo(TimerAIEventData instance) { }

	// RVA: 0x1EEE8D0 Offset: 0x1EECED0 VA: 0x181EEE8D0
	public TimerAIEventData Copy() { }

	// RVA: 0x1EEEED0 Offset: 0x1EED4D0 VA: 0x181EEEED0
	public static TimerAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1EEE940 Offset: 0x1EECF40 VA: 0x181EEE940
	public static TimerAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EEEC10 Offset: 0x1EED210 VA: 0x181EEEC10
	public static TimerAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EEF090 Offset: 0x1EED690 VA: 0x181EEF090
	public static TimerAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1EEF7D0 Offset: 0x1EEDDD0 VA: 0x181EEF7D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EEFEC0 Offset: 0x1EEE4C0 VA: 0x181EEFEC0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EEFEE0 Offset: 0x1EEE4E0 VA: 0x181EEFEE0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, TimerAIEventData previous) { }

	// RVA: 0x1EEF950 Offset: 0x1EEDF50 VA: 0x181EEF950 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EEF300 Offset: 0x1EED900 VA: 0x181EEF300
	public static TimerAIEventData Deserialize(byte[] buffer, TimerAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1EEF550 Offset: 0x1EEDB50 VA: 0x181EEF550
	public static TimerAIEventData Deserialize(Stream stream, TimerAIEventData instance, bool isDelta) { }

	// RVA: 0x1EEE9C0 Offset: 0x1EECFC0 VA: 0x181EEE9C0
	public static TimerAIEventData DeserializeLengthDelimited(Stream stream, TimerAIEventData instance, bool isDelta) { }

	// RVA: 0x1EEECA0 Offset: 0x1EED2A0 VA: 0x181EEECA0
	public static TimerAIEventData DeserializeLength(Stream stream, int length, TimerAIEventData instance, bool isDelta) { }

	// RVA: 0x1EEFA70 Offset: 0x1EEE070 VA: 0x181EEFA70
	public static void SerializeDelta(Stream stream, TimerAIEventData instance, TimerAIEventData previous) { }

	// RVA: 0x1EEFDB0 Offset: 0x1EEE3B0 VA: 0x181EEFDB0
	public static void Serialize(Stream stream, TimerAIEventData instance) { }

	// RVA: 0x1EEFEB0 Offset: 0x1EEE4B0 VA: 0x181EEFEB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EEFEC0 Offset: 0x1EEE4C0 VA: 0x181EEFEC0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EEFCA0 Offset: 0x1EEE2A0 VA: 0x181EEFCA0
	public static byte[] SerializeToBytes(TimerAIEventData instance) { }

	// RVA: 0x1EEFBF0 Offset: 0x1EEE1F0 VA: 0x181EEFBF0
	public static void SerializeLengthDelimited(Stream stream, TimerAIEventData instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class HealthBelowAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6545
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float healthFraction; // 0x14

	// Methods

	// RVA: 0x1D64A90 Offset: 0x1D63090 VA: 0x181D64A90
	public static void ResetToPool(HealthBelowAIEventData instance) { }

	// RVA: 0x1D64B10 Offset: 0x1D63110 VA: 0x181D64B10
	public void ResetToPool() { }

	// RVA: 0x1D64960 Offset: 0x1D62F60 VA: 0x181D64960 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFEF80 Offset: 0x1BFD580 VA: 0x181BFEF80
	public void CopyTo(HealthBelowAIEventData instance) { }

	// RVA: 0x1D63FD0 Offset: 0x1D625D0 VA: 0x181D63FD0
	public HealthBelowAIEventData Copy() { }

	// RVA: 0x1D64570 Offset: 0x1D62B70 VA: 0x181D64570
	public static HealthBelowAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1D64040 Offset: 0x1D62640 VA: 0x181D64040
	public static HealthBelowAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D642E0 Offset: 0x1D628E0 VA: 0x181D642E0
	public static HealthBelowAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D64740 Offset: 0x1D62D40 VA: 0x181D64740
	public static HealthBelowAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1D64A50 Offset: 0x1D63050 VA: 0x181D64A50
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D64F60 Offset: 0x1D63560 VA: 0x181D64F60 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D64F80 Offset: 0x1D63580 VA: 0x181D64F80 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, HealthBelowAIEventData previous) { }

	// RVA: 0x1D64A70 Offset: 0x1D63070 VA: 0x181D64A70 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D64860 Offset: 0x1D62E60 VA: 0x181D64860
	public static HealthBelowAIEventData Deserialize(byte[] buffer, HealthBelowAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1D645F0 Offset: 0x1D62BF0 VA: 0x181D645F0
	public static HealthBelowAIEventData Deserialize(Stream stream, HealthBelowAIEventData instance, bool isDelta) { }

	// RVA: 0x1D640C0 Offset: 0x1D626C0 VA: 0x181D640C0
	public static HealthBelowAIEventData DeserializeLengthDelimited(Stream stream, HealthBelowAIEventData instance, bool isDelta) { }

	// RVA: 0x1D64370 Offset: 0x1D62970 VA: 0x181D64370
	public static HealthBelowAIEventData DeserializeLength(Stream stream, int length, HealthBelowAIEventData instance, bool isDelta) { }

	// RVA: 0x1D64B90 Offset: 0x1D63190 VA: 0x181D64B90
	public static void SerializeDelta(Stream stream, HealthBelowAIEventData instance, HealthBelowAIEventData previous) { }

	// RVA: 0x1D64E70 Offset: 0x1D63470 VA: 0x181D64E70
	public static void Serialize(Stream stream, HealthBelowAIEventData instance) { }

	// RVA: 0x1D64F50 Offset: 0x1D63550 VA: 0x181D64F50
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D64F60 Offset: 0x1D63560 VA: 0x181D64F60
	public void ToProto(Stream stream) { }

	// RVA: 0x1D64D60 Offset: 0x1D63360 VA: 0x181D64D60
	public static byte[] SerializeToBytes(HealthBelowAIEventData instance) { }

	// RVA: 0x1D64CB0 Offset: 0x1D632B0 VA: 0x181D64CB0
	public static void SerializeLengthDelimited(Stream stream, HealthBelowAIEventData instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class InRangeAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6546
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float range; // 0x14

	// Methods

	// RVA: 0x1C063B0 Offset: 0x1C049B0 VA: 0x181C063B0
	public static void ResetToPool(InRangeAIEventData instance) { }

	// RVA: 0x1C06430 Offset: 0x1C04A30 VA: 0x181C06430
	public void ResetToPool() { }

	// RVA: 0x1C06280 Offset: 0x1C04880 VA: 0x181C06280 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFEF80 Offset: 0x1BFD580 VA: 0x181BFEF80
	public void CopyTo(InRangeAIEventData instance) { }

	// RVA: 0x1C058F0 Offset: 0x1C03EF0 VA: 0x181C058F0
	public InRangeAIEventData Copy() { }

	// RVA: 0x1C05E90 Offset: 0x1C04490 VA: 0x181C05E90
	public static InRangeAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1C05960 Offset: 0x1C03F60 VA: 0x181C05960
	public static InRangeAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C05E00 Offset: 0x1C04400 VA: 0x181C05E00
	public static InRangeAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C06160 Offset: 0x1C04760 VA: 0x181C06160
	public static InRangeAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1C06370 Offset: 0x1C04970 VA: 0x181C06370
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C06880 Offset: 0x1C04E80 VA: 0x181C06880 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C068A0 Offset: 0x1C04EA0 VA: 0x181C068A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, InRangeAIEventData previous) { }

	// RVA: 0x1C06390 Offset: 0x1C04990 VA: 0x181C06390 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C05F10 Offset: 0x1C04510 VA: 0x181C05F10
	public static InRangeAIEventData Deserialize(byte[] buffer, InRangeAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1C06010 Offset: 0x1C04610 VA: 0x181C06010
	public static InRangeAIEventData Deserialize(Stream stream, InRangeAIEventData instance, bool isDelta) { }

	// RVA: 0x1C059E0 Offset: 0x1C03FE0 VA: 0x181C059E0
	public static InRangeAIEventData DeserializeLengthDelimited(Stream stream, InRangeAIEventData instance, bool isDelta) { }

	// RVA: 0x1C05C00 Offset: 0x1C04200 VA: 0x181C05C00
	public static InRangeAIEventData DeserializeLength(Stream stream, int length, InRangeAIEventData instance, bool isDelta) { }

	// RVA: 0x1C064B0 Offset: 0x1C04AB0 VA: 0x181C064B0
	public static void SerializeDelta(Stream stream, InRangeAIEventData instance, InRangeAIEventData previous) { }

	// RVA: 0x1C06790 Offset: 0x1C04D90 VA: 0x181C06790
	public static void Serialize(Stream stream, InRangeAIEventData instance) { }

	// RVA: 0x1C06870 Offset: 0x1C04E70 VA: 0x181C06870
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C06880 Offset: 0x1C04E80 VA: 0x181C06880
	public void ToProto(Stream stream) { }

	// RVA: 0x1C06680 Offset: 0x1C04C80 VA: 0x181C06680
	public static byte[] SerializeToBytes(InRangeAIEventData instance) { }

	// RVA: 0x1C065D0 Offset: 0x1C04BD0 VA: 0x181C065D0
	public static void SerializeLengthDelimited(Stream stream, InRangeAIEventData instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class HungerAboveAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6547
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float value; // 0x14

	// Methods

	// RVA: 0x1BFFA60 Offset: 0x1BFE060 VA: 0x181BFFA60
	public static void ResetToPool(HungerAboveAIEventData instance) { }

	// RVA: 0x1BFFAE0 Offset: 0x1BFE0E0 VA: 0x181BFFAE0
	public void ResetToPool() { }

	// RVA: 0x1BFF930 Offset: 0x1BFDF30 VA: 0x181BFF930 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFEF80 Offset: 0x1BFD580 VA: 0x181BFEF80
	public void CopyTo(HungerAboveAIEventData instance) { }

	// RVA: 0x1BFEFA0 Offset: 0x1BFD5A0 VA: 0x181BFEFA0
	public HungerAboveAIEventData Copy() { }

	// RVA: 0x1BFF540 Offset: 0x1BFDB40 VA: 0x181BFF540
	public static HungerAboveAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1BFF010 Offset: 0x1BFD610 VA: 0x181BFF010
	public static HungerAboveAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1BFF2B0 Offset: 0x1BFD8B0 VA: 0x181BFF2B0
	public static HungerAboveAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1BFF810 Offset: 0x1BFDE10 VA: 0x181BFF810
	public static HungerAboveAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1BFFA20 Offset: 0x1BFE020 VA: 0x181BFFA20
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1BFFF30 Offset: 0x1BFE530 VA: 0x181BFFF30 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1BFFF50 Offset: 0x1BFE550 VA: 0x181BFFF50 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, HungerAboveAIEventData previous) { }

	// RVA: 0x1BFFA40 Offset: 0x1BFE040 VA: 0x181BFFA40 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1BFF710 Offset: 0x1BFDD10 VA: 0x181BFF710
	public static HungerAboveAIEventData Deserialize(byte[] buffer, HungerAboveAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1BFF5C0 Offset: 0x1BFDBC0 VA: 0x181BFF5C0
	public static HungerAboveAIEventData Deserialize(Stream stream, HungerAboveAIEventData instance, bool isDelta) { }

	// RVA: 0x1BFF090 Offset: 0x1BFD690 VA: 0x181BFF090
	public static HungerAboveAIEventData DeserializeLengthDelimited(Stream stream, HungerAboveAIEventData instance, bool isDelta) { }

	// RVA: 0x1BFF340 Offset: 0x1BFD940 VA: 0x181BFF340
	public static HungerAboveAIEventData DeserializeLength(Stream stream, int length, HungerAboveAIEventData instance, bool isDelta) { }

	// RVA: 0x1BFFB60 Offset: 0x1BFE160 VA: 0x181BFFB60
	public static void SerializeDelta(Stream stream, HungerAboveAIEventData instance, HungerAboveAIEventData previous) { }

	// RVA: 0x1BFFE40 Offset: 0x1BFE440 VA: 0x181BFFE40
	public static void Serialize(Stream stream, HungerAboveAIEventData instance) { }

	// RVA: 0x1BFFF20 Offset: 0x1BFE520 VA: 0x181BFFF20
	public byte[] ToProtoBytes() { }

	// RVA: 0x1BFFF30 Offset: 0x1BFE530 VA: 0x181BFFF30
	public void ToProto(Stream stream) { }

	// RVA: 0x1BFFD30 Offset: 0x1BFE330 VA: 0x181BFFD30
	public static byte[] SerializeToBytes(HungerAboveAIEventData instance) { }

	// RVA: 0x1BFFC80 Offset: 0x1BFE280 VA: 0x181BFFC80
	public static void SerializeLengthDelimited(Stream stream, HungerAboveAIEventData instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class TirednessAboveAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6548
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float value; // 0x14

	// Methods

	// RVA: 0x1EF0B30 Offset: 0x1EEF130 VA: 0x181EF0B30
	public static void ResetToPool(TirednessAboveAIEventData instance) { }

	// RVA: 0x1EF0BB0 Offset: 0x1EEF1B0 VA: 0x181EF0BB0
	public void ResetToPool() { }

	// RVA: 0x1EF0A00 Offset: 0x1EEF000 VA: 0x181EF0A00 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFEF80 Offset: 0x1BFD580 VA: 0x181BFEF80
	public void CopyTo(TirednessAboveAIEventData instance) { }

	// RVA: 0x1EF0070 Offset: 0x1EEE670 VA: 0x181EF0070
	public TirednessAboveAIEventData Copy() { }

	// RVA: 0x1EF0760 Offset: 0x1EEED60 VA: 0x181EF0760
	public static TirednessAboveAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1EF0300 Offset: 0x1EEE900 VA: 0x181EF0300
	public static TirednessAboveAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EF0580 Offset: 0x1EEEB80 VA: 0x181EF0580
	public static TirednessAboveAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EF07E0 Offset: 0x1EEEDE0 VA: 0x181EF07E0
	public static TirednessAboveAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1EF0AF0 Offset: 0x1EEF0F0 VA: 0x181EF0AF0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EF1000 Offset: 0x1EEF600 VA: 0x181EF1000 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EF1020 Offset: 0x1EEF620 VA: 0x181EF1020 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, TirednessAboveAIEventData previous) { }

	// RVA: 0x1EF0B10 Offset: 0x1EEF110 VA: 0x181EF0B10 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EF0900 Offset: 0x1EEEF00 VA: 0x181EF0900
	public static TirednessAboveAIEventData Deserialize(byte[] buffer, TirednessAboveAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1EF0610 Offset: 0x1EEEC10 VA: 0x181EF0610
	public static TirednessAboveAIEventData Deserialize(Stream stream, TirednessAboveAIEventData instance, bool isDelta) { }

	// RVA: 0x1EF00E0 Offset: 0x1EEE6E0 VA: 0x181EF00E0
	public static TirednessAboveAIEventData DeserializeLengthDelimited(Stream stream, TirednessAboveAIEventData instance, bool isDelta) { }

	// RVA: 0x1EF0380 Offset: 0x1EEE980 VA: 0x181EF0380
	public static TirednessAboveAIEventData DeserializeLength(Stream stream, int length, TirednessAboveAIEventData instance, bool isDelta) { }

	// RVA: 0x1EF0C30 Offset: 0x1EEF230 VA: 0x181EF0C30
	public static void SerializeDelta(Stream stream, TirednessAboveAIEventData instance, TirednessAboveAIEventData previous) { }

	// RVA: 0x1EF0F10 Offset: 0x1EEF510 VA: 0x181EF0F10
	public static void Serialize(Stream stream, TirednessAboveAIEventData instance) { }

	// RVA: 0x1EF0FF0 Offset: 0x1EEF5F0 VA: 0x181EF0FF0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EF1000 Offset: 0x1EEF600 VA: 0x181EF1000
	public void ToProto(Stream stream) { }

	// RVA: 0x1EF0E00 Offset: 0x1EEF400 VA: 0x181EF0E00
	public static byte[] SerializeToBytes(TirednessAboveAIEventData instance) { }

	// RVA: 0x1EF0D50 Offset: 0x1EEF350 VA: 0x181EF0D50
	public static void SerializeLengthDelimited(Stream stream, TirednessAboveAIEventData instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class AmmoBelowAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6549
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float value; // 0x14

	// Methods

	// RVA: 0x2014AF0 Offset: 0x20130F0 VA: 0x182014AF0
	public static void ResetToPool(AmmoBelowAIEventData instance) { }

	// RVA: 0x2014A70 Offset: 0x2013070 VA: 0x182014A70
	public void ResetToPool() { }

	// RVA: 0x20149B0 Offset: 0x2012FB0 VA: 0x1820149B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFEF80 Offset: 0x1BFD580 VA: 0x181BFEF80
	public void CopyTo(AmmoBelowAIEventData instance) { }

	// RVA: 0x2014020 Offset: 0x2012620 VA: 0x182014020
	public AmmoBelowAIEventData Copy() { }

	// RVA: 0x20147E0 Offset: 0x2012DE0 VA: 0x1820147E0
	public static AmmoBelowAIEventData Deserialize(Stream stream) { }

	// RVA: 0x2014090 Offset: 0x2012690 VA: 0x182014090
	public static AmmoBelowAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2014530 Offset: 0x2012B30 VA: 0x182014530
	public static AmmoBelowAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20146C0 Offset: 0x2012CC0 VA: 0x1820146C0
	public static AmmoBelowAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x2014A30 Offset: 0x2013030 VA: 0x182014A30
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2014F40 Offset: 0x2013540 VA: 0x182014F40 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2014F60 Offset: 0x2013560 VA: 0x182014F60 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AmmoBelowAIEventData previous) { }

	// RVA: 0x2014A50 Offset: 0x2013050 VA: 0x182014A50 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20145C0 Offset: 0x2012BC0 VA: 0x1820145C0
	public static AmmoBelowAIEventData Deserialize(byte[] buffer, AmmoBelowAIEventData instance, bool isDelta = False) { }

	// RVA: 0x2014860 Offset: 0x2012E60 VA: 0x182014860
	public static AmmoBelowAIEventData Deserialize(Stream stream, AmmoBelowAIEventData instance, bool isDelta) { }

	// RVA: 0x2014110 Offset: 0x2012710 VA: 0x182014110
	public static AmmoBelowAIEventData DeserializeLengthDelimited(Stream stream, AmmoBelowAIEventData instance, bool isDelta) { }

	// RVA: 0x2014330 Offset: 0x2012930 VA: 0x182014330
	public static AmmoBelowAIEventData DeserializeLength(Stream stream, int length, AmmoBelowAIEventData instance, bool isDelta) { }

	// RVA: 0x2014B70 Offset: 0x2013170 VA: 0x182014B70
	public static void SerializeDelta(Stream stream, AmmoBelowAIEventData instance, AmmoBelowAIEventData previous) { }

	// RVA: 0x2014E50 Offset: 0x2013450 VA: 0x182014E50
	public static void Serialize(Stream stream, AmmoBelowAIEventData instance) { }

	// RVA: 0x2014F30 Offset: 0x2013530 VA: 0x182014F30
	public byte[] ToProtoBytes() { }

	// RVA: 0x2014F40 Offset: 0x2013540 VA: 0x182014F40
	public void ToProto(Stream stream) { }

	// RVA: 0x2014D40 Offset: 0x2013340 VA: 0x182014D40
	public static byte[] SerializeToBytes(AmmoBelowAIEventData instance) { }

	// RVA: 0x2014C90 Offset: 0x2013290 VA: 0x182014C90
	public static void SerializeLengthDelimited(Stream stream, AmmoBelowAIEventData instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class ThreatDetectedAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6550
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float range; // 0x14

	// Methods

	// RVA: 0x1EED230 Offset: 0x1EEB830 VA: 0x181EED230
	public static void ResetToPool(ThreatDetectedAIEventData instance) { }

	// RVA: 0x1EED1B0 Offset: 0x1EEB7B0 VA: 0x181EED1B0
	public void ResetToPool() { }

	// RVA: 0x1EED080 Offset: 0x1EEB680 VA: 0x181EED080 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFEF80 Offset: 0x1BFD580 VA: 0x181BFEF80
	public void CopyTo(ThreatDetectedAIEventData instance) { }

	// RVA: 0x1EEC6F0 Offset: 0x1EEACF0 VA: 0x181EEC6F0
	public ThreatDetectedAIEventData Copy() { }

	// RVA: 0x1EED000 Offset: 0x1EEB600 VA: 0x181EED000
	public static ThreatDetectedAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1EEC760 Offset: 0x1EEAD60 VA: 0x181EEC760
	public static ThreatDetectedAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EECA00 Offset: 0x1EEB000 VA: 0x181EECA00
	public static ThreatDetectedAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EECD90 Offset: 0x1EEB390 VA: 0x181EECD90
	public static ThreatDetectedAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1EED170 Offset: 0x1EEB770 VA: 0x181EED170
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EED680 Offset: 0x1EEBC80 VA: 0x181EED680 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EED6A0 Offset: 0x1EEBCA0 VA: 0x181EED6A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ThreatDetectedAIEventData previous) { }

	// RVA: 0x1EED190 Offset: 0x1EEB790 VA: 0x181EED190 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EECC90 Offset: 0x1EEB290 VA: 0x181EECC90
	public static ThreatDetectedAIEventData Deserialize(byte[] buffer, ThreatDetectedAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1EECEB0 Offset: 0x1EEB4B0 VA: 0x181EECEB0
	public static ThreatDetectedAIEventData Deserialize(Stream stream, ThreatDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1EEC7E0 Offset: 0x1EEADE0 VA: 0x181EEC7E0
	public static ThreatDetectedAIEventData DeserializeLengthDelimited(Stream stream, ThreatDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1EECA90 Offset: 0x1EEB090 VA: 0x181EECA90
	public static ThreatDetectedAIEventData DeserializeLength(Stream stream, int length, ThreatDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1EED2B0 Offset: 0x1EEB8B0 VA: 0x181EED2B0
	public static void SerializeDelta(Stream stream, ThreatDetectedAIEventData instance, ThreatDetectedAIEventData previous) { }

	// RVA: 0x1EED590 Offset: 0x1EEBB90 VA: 0x181EED590
	public static void Serialize(Stream stream, ThreatDetectedAIEventData instance) { }

	// RVA: 0x1EED670 Offset: 0x1EEBC70 VA: 0x181EED670
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EED680 Offset: 0x1EEBC80 VA: 0x181EED680
	public void ToProto(Stream stream) { }

	// RVA: 0x1EED480 Offset: 0x1EEBA80 VA: 0x181EED480
	public static byte[] SerializeToBytes(ThreatDetectedAIEventData instance) { }

	// RVA: 0x1EED3D0 Offset: 0x1EEB9D0 VA: 0x181EED3D0
	public static void SerializeLengthDelimited(Stream stream, ThreatDetectedAIEventData instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class TargetDetectedAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6551
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float range; // 0x14

	// Methods

	// RVA: 0x1DC8260 Offset: 0x1DC6860 VA: 0x181DC8260
	public static void ResetToPool(TargetDetectedAIEventData instance) { }

	// RVA: 0x1DC81E0 Offset: 0x1DC67E0 VA: 0x181DC81E0
	public void ResetToPool() { }

	// RVA: 0x1DC80B0 Offset: 0x1DC66B0 VA: 0x181DC80B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFEF80 Offset: 0x1BFD580 VA: 0x181BFEF80
	public void CopyTo(TargetDetectedAIEventData instance) { }

	// RVA: 0x1DC7720 Offset: 0x1DC5D20 VA: 0x181DC7720
	public TargetDetectedAIEventData Copy() { }

	// RVA: 0x1DC7CC0 Offset: 0x1DC62C0 VA: 0x181DC7CC0
	public static TargetDetectedAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1DC7790 Offset: 0x1DC5D90 VA: 0x181DC7790
	public static TargetDetectedAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DC7A30 Offset: 0x1DC6030 VA: 0x181DC7A30
	public static TargetDetectedAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DC7E40 Offset: 0x1DC6440 VA: 0x181DC7E40
	public static TargetDetectedAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1DC81A0 Offset: 0x1DC67A0 VA: 0x181DC81A0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DC86B0 Offset: 0x1DC6CB0 VA: 0x181DC86B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DC86D0 Offset: 0x1DC6CD0 VA: 0x181DC86D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, TargetDetectedAIEventData previous) { }

	// RVA: 0x1DC81C0 Offset: 0x1DC67C0 VA: 0x181DC81C0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DC7D40 Offset: 0x1DC6340 VA: 0x181DC7D40
	public static TargetDetectedAIEventData Deserialize(byte[] buffer, TargetDetectedAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1DC7F60 Offset: 0x1DC6560 VA: 0x181DC7F60
	public static TargetDetectedAIEventData Deserialize(Stream stream, TargetDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1DC7810 Offset: 0x1DC5E10 VA: 0x181DC7810
	public static TargetDetectedAIEventData DeserializeLengthDelimited(Stream stream, TargetDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1DC7AC0 Offset: 0x1DC60C0 VA: 0x181DC7AC0
	public static TargetDetectedAIEventData DeserializeLength(Stream stream, int length, TargetDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1DC82E0 Offset: 0x1DC68E0 VA: 0x181DC82E0
	public static void SerializeDelta(Stream stream, TargetDetectedAIEventData instance, TargetDetectedAIEventData previous) { }

	// RVA: 0x1DC85C0 Offset: 0x1DC6BC0 VA: 0x181DC85C0
	public static void Serialize(Stream stream, TargetDetectedAIEventData instance) { }

	// RVA: 0x1DC86A0 Offset: 0x1DC6CA0 VA: 0x181DC86A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DC86B0 Offset: 0x1DC6CB0 VA: 0x181DC86B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DC84B0 Offset: 0x1DC6AB0 VA: 0x181DC84B0
	public static byte[] SerializeToBytes(TargetDetectedAIEventData instance) { }

	// RVA: 0x1DC8400 Offset: 0x1DC6A00 VA: 0x181DC8400
	public static void SerializeLengthDelimited(Stream stream, TargetDetectedAIEventData instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class ChanceAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6552
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float value; // 0x14

	// Methods

	// RVA: 0x20A9D00 Offset: 0x20A8300 VA: 0x1820A9D00
	public static void ResetToPool(ChanceAIEventData instance) { }

	// RVA: 0x20A9D80 Offset: 0x20A8380 VA: 0x1820A9D80
	public void ResetToPool() { }

	// RVA: 0x20A9BD0 Offset: 0x20A81D0 VA: 0x1820A9BD0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFEF80 Offset: 0x1BFD580 VA: 0x181BFEF80
	public void CopyTo(ChanceAIEventData instance) { }

	// RVA: 0x20A9240 Offset: 0x20A7840 VA: 0x1820A9240
	public ChanceAIEventData Copy() { }

	// RVA: 0x20A9A00 Offset: 0x20A8000 VA: 0x1820A9A00
	public static ChanceAIEventData Deserialize(Stream stream) { }

	// RVA: 0x20A94D0 Offset: 0x20A7AD0 VA: 0x1820A94D0
	public static ChanceAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20A9550 Offset: 0x20A7B50 VA: 0x1820A9550
	public static ChanceAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20A97E0 Offset: 0x20A7DE0 VA: 0x1820A97E0
	public static ChanceAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x20A9CC0 Offset: 0x20A82C0 VA: 0x1820A9CC0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20AA1D0 Offset: 0x20A87D0 VA: 0x1820AA1D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20AA1F0 Offset: 0x20A87F0 VA: 0x1820AA1F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ChanceAIEventData previous) { }

	// RVA: 0x20A9CE0 Offset: 0x20A82E0 VA: 0x1820A9CE0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20A9900 Offset: 0x20A7F00 VA: 0x1820A9900
	public static ChanceAIEventData Deserialize(byte[] buffer, ChanceAIEventData instance, bool isDelta = False) { }

	// RVA: 0x20A9A80 Offset: 0x20A8080 VA: 0x1820A9A80
	public static ChanceAIEventData Deserialize(Stream stream, ChanceAIEventData instance, bool isDelta) { }

	// RVA: 0x20A92B0 Offset: 0x20A78B0 VA: 0x1820A92B0
	public static ChanceAIEventData DeserializeLengthDelimited(Stream stream, ChanceAIEventData instance, bool isDelta) { }

	// RVA: 0x20A95E0 Offset: 0x20A7BE0 VA: 0x1820A95E0
	public static ChanceAIEventData DeserializeLength(Stream stream, int length, ChanceAIEventData instance, bool isDelta) { }

	// RVA: 0x20A9E00 Offset: 0x20A8400 VA: 0x1820A9E00
	public static void SerializeDelta(Stream stream, ChanceAIEventData instance, ChanceAIEventData previous) { }

	// RVA: 0x20AA0E0 Offset: 0x20A86E0 VA: 0x1820AA0E0
	public static void Serialize(Stream stream, ChanceAIEventData instance) { }

	// RVA: 0x20AA1C0 Offset: 0x20A87C0 VA: 0x1820AA1C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20AA1D0 Offset: 0x20A87D0 VA: 0x1820AA1D0
	public void ToProto(Stream stream) { }

	// RVA: 0x20A9FD0 Offset: 0x20A85D0 VA: 0x1820A9FD0
	public static byte[] SerializeToBytes(ChanceAIEventData instance) { }

	// RVA: 0x20A9F20 Offset: 0x20A8520 VA: 0x1820A9F20
	public static void SerializeLengthDelimited(Stream stream, ChanceAIEventData instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class TimeSinceThreatAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6553
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float value; // 0x14

	// Methods

	// RVA: 0x1EEE320 Offset: 0x1EEC920 VA: 0x181EEE320
	public static void ResetToPool(TimeSinceThreatAIEventData instance) { }

	// RVA: 0x1EEE2A0 Offset: 0x1EEC8A0 VA: 0x181EEE2A0
	public void ResetToPool() { }

	// RVA: 0x1EEE170 Offset: 0x1EEC770 VA: 0x181EEE170 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFEF80 Offset: 0x1BFD580 VA: 0x181BFEF80
	public void CopyTo(TimeSinceThreatAIEventData instance) { }

	// RVA: 0x1EED7E0 Offset: 0x1EEBDE0 VA: 0x181EED7E0
	public TimeSinceThreatAIEventData Copy() { }

	// RVA: 0x1EEDE80 Offset: 0x1EEC480 VA: 0x181EEDE80
	public static TimeSinceThreatAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1EED850 Offset: 0x1EEBE50 VA: 0x181EED850
	public static TimeSinceThreatAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EEDAF0 Offset: 0x1EEC0F0 VA: 0x181EEDAF0
	public static TimeSinceThreatAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EEDF00 Offset: 0x1EEC500 VA: 0x181EEDF00
	public static TimeSinceThreatAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1EEE260 Offset: 0x1EEC860 VA: 0x181EEE260
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EEE770 Offset: 0x1EECD70 VA: 0x181EEE770 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EEE790 Offset: 0x1EECD90 VA: 0x181EEE790 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, TimeSinceThreatAIEventData previous) { }

	// RVA: 0x1EEE280 Offset: 0x1EEC880 VA: 0x181EEE280 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EEDD80 Offset: 0x1EEC380 VA: 0x181EEDD80
	public static TimeSinceThreatAIEventData Deserialize(byte[] buffer, TimeSinceThreatAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1EEE020 Offset: 0x1EEC620 VA: 0x181EEE020
	public static TimeSinceThreatAIEventData Deserialize(Stream stream, TimeSinceThreatAIEventData instance, bool isDelta) { }

	// RVA: 0x1EED8D0 Offset: 0x1EEBED0 VA: 0x181EED8D0
	public static TimeSinceThreatAIEventData DeserializeLengthDelimited(Stream stream, TimeSinceThreatAIEventData instance, bool isDelta) { }

	// RVA: 0x1EEDB80 Offset: 0x1EEC180 VA: 0x181EEDB80
	public static TimeSinceThreatAIEventData DeserializeLength(Stream stream, int length, TimeSinceThreatAIEventData instance, bool isDelta) { }

	// RVA: 0x1EEE3A0 Offset: 0x1EEC9A0 VA: 0x181EEE3A0
	public static void SerializeDelta(Stream stream, TimeSinceThreatAIEventData instance, TimeSinceThreatAIEventData previous) { }

	// RVA: 0x1EEE680 Offset: 0x1EECC80 VA: 0x181EEE680
	public static void Serialize(Stream stream, TimeSinceThreatAIEventData instance) { }

	// RVA: 0x1EEE760 Offset: 0x1EECD60 VA: 0x181EEE760
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EEE770 Offset: 0x1EECD70 VA: 0x181EEE770
	public void ToProto(Stream stream) { }

	// RVA: 0x1EEE570 Offset: 0x1EECB70 VA: 0x181EEE570
	public static byte[] SerializeToBytes(TimeSinceThreatAIEventData instance) { }

	// RVA: 0x1EEE4C0 Offset: 0x1EECAC0 VA: 0x181EEE4C0
	public static void SerializeLengthDelimited(Stream stream, TimeSinceThreatAIEventData instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class AggressionTimerAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6554
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float value; // 0x14

	// Methods

	// RVA: 0x2013B10 Offset: 0x2012110 VA: 0x182013B10
	public static void ResetToPool(AggressionTimerAIEventData instance) { }

	// RVA: 0x2013B90 Offset: 0x2012190 VA: 0x182013B90
	public void ResetToPool() { }

	// RVA: 0x2013A50 Offset: 0x2012050 VA: 0x182013A50 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFEF80 Offset: 0x1BFD580 VA: 0x181BFEF80
	public void CopyTo(AggressionTimerAIEventData instance) { }

	// RVA: 0x20130C0 Offset: 0x20116C0 VA: 0x1820130C0
	public AggressionTimerAIEventData Copy() { }

	// RVA: 0x20139D0 Offset: 0x2011FD0 VA: 0x1820139D0
	public static AggressionTimerAIEventData Deserialize(Stream stream) { }

	// RVA: 0x2013350 Offset: 0x2011950 VA: 0x182013350
	public static AggressionTimerAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20133D0 Offset: 0x20119D0 VA: 0x1820133D0
	public static AggressionTimerAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20138B0 Offset: 0x2011EB0 VA: 0x1820138B0
	public static AggressionTimerAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x2013AD0 Offset: 0x20120D0 VA: 0x182013AD0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2013FE0 Offset: 0x20125E0 VA: 0x182013FE0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2014000 Offset: 0x2012600 VA: 0x182014000 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AggressionTimerAIEventData previous) { }

	// RVA: 0x2013AF0 Offset: 0x20120F0 VA: 0x182013AF0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2013660 Offset: 0x2011C60 VA: 0x182013660
	public static AggressionTimerAIEventData Deserialize(byte[] buffer, AggressionTimerAIEventData instance, bool isDelta = False) { }

	// RVA: 0x2013760 Offset: 0x2011D60 VA: 0x182013760
	public static AggressionTimerAIEventData Deserialize(Stream stream, AggressionTimerAIEventData instance, bool isDelta) { }

	// RVA: 0x2013130 Offset: 0x2011730 VA: 0x182013130
	public static AggressionTimerAIEventData DeserializeLengthDelimited(Stream stream, AggressionTimerAIEventData instance, bool isDelta) { }

	// RVA: 0x2013460 Offset: 0x2011A60 VA: 0x182013460
	public static AggressionTimerAIEventData DeserializeLength(Stream stream, int length, AggressionTimerAIEventData instance, bool isDelta) { }

	// RVA: 0x2013C10 Offset: 0x2012210 VA: 0x182013C10
	public static void SerializeDelta(Stream stream, AggressionTimerAIEventData instance, AggressionTimerAIEventData previous) { }

	// RVA: 0x2013EF0 Offset: 0x20124F0 VA: 0x182013EF0
	public static void Serialize(Stream stream, AggressionTimerAIEventData instance) { }

	// RVA: 0x2013FD0 Offset: 0x20125D0 VA: 0x182013FD0
	public byte[] ToProtoBytes() { }

	// RVA: 0x2013FE0 Offset: 0x20125E0 VA: 0x182013FE0
	public void ToProto(Stream stream) { }

	// RVA: 0x2013DE0 Offset: 0x20123E0 VA: 0x182013DE0
	public static byte[] SerializeToBytes(AggressionTimerAIEventData instance) { }

	// RVA: 0x2013D30 Offset: 0x2012330 VA: 0x182013D30
	public static void SerializeLengthDelimited(Stream stream, AggressionTimerAIEventData instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class InRangeOfHomeAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6556
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float range; // 0x14

	// Methods

	// RVA: 0x1C07520 Offset: 0x1C05B20 VA: 0x181C07520
	public static void ResetToPool(InRangeOfHomeAIEventData instance) { }

	// RVA: 0x1C074A0 Offset: 0x1C05AA0 VA: 0x181C074A0
	public void ResetToPool() { }

	// RVA: 0x1C07370 Offset: 0x1C05970 VA: 0x181C07370 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFEF80 Offset: 0x1BFD580 VA: 0x181BFEF80
	public void CopyTo(InRangeOfHomeAIEventData instance) { }

	// RVA: 0x1C069E0 Offset: 0x1C04FE0 VA: 0x181C069E0
	public InRangeOfHomeAIEventData Copy() { }

	// RVA: 0x1C06F80 Offset: 0x1C05580 VA: 0x181C06F80
	public static InRangeOfHomeAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1C06C70 Offset: 0x1C05270 VA: 0x181C06C70
	public static InRangeOfHomeAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C06CF0 Offset: 0x1C052F0 VA: 0x181C06CF0
	public static InRangeOfHomeAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C07250 Offset: 0x1C05850 VA: 0x181C07250
	public static InRangeOfHomeAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1C07460 Offset: 0x1C05A60 VA: 0x181C07460
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C07970 Offset: 0x1C05F70 VA: 0x181C07970 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C07990 Offset: 0x1C05F90 VA: 0x181C07990 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, InRangeOfHomeAIEventData previous) { }

	// RVA: 0x1C07480 Offset: 0x1C05A80 VA: 0x181C07480 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C07000 Offset: 0x1C05600 VA: 0x181C07000
	public static InRangeOfHomeAIEventData Deserialize(byte[] buffer, InRangeOfHomeAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1C07100 Offset: 0x1C05700 VA: 0x181C07100
	public static InRangeOfHomeAIEventData Deserialize(Stream stream, InRangeOfHomeAIEventData instance, bool isDelta) { }

	// RVA: 0x1C06A50 Offset: 0x1C05050 VA: 0x181C06A50
	public static InRangeOfHomeAIEventData DeserializeLengthDelimited(Stream stream, InRangeOfHomeAIEventData instance, bool isDelta) { }

	// RVA: 0x1C06D80 Offset: 0x1C05380 VA: 0x181C06D80
	public static InRangeOfHomeAIEventData DeserializeLength(Stream stream, int length, InRangeOfHomeAIEventData instance, bool isDelta) { }

	// RVA: 0x1C075A0 Offset: 0x1C05BA0 VA: 0x181C075A0
	public static void SerializeDelta(Stream stream, InRangeOfHomeAIEventData instance, InRangeOfHomeAIEventData previous) { }

	// RVA: 0x1C07880 Offset: 0x1C05E80 VA: 0x181C07880
	public static void Serialize(Stream stream, InRangeOfHomeAIEventData instance) { }

	// RVA: 0x1C07960 Offset: 0x1C05F60 VA: 0x181C07960
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C07970 Offset: 0x1C05F70 VA: 0x181C07970
	public void ToProto(Stream stream) { }

	// RVA: 0x1C07770 Offset: 0x1C05D70 VA: 0x181C07770
	public static byte[] SerializeToBytes(InRangeOfHomeAIEventData instance) { }

	// RVA: 0x1C076C0 Offset: 0x1C05CC0 VA: 0x181C076C0
	public static void SerializeLengthDelimited(Stream stream, InRangeOfHomeAIEventData instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

