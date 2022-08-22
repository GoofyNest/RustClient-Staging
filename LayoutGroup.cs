public abstract class LayoutGroup : UIBehaviour, ILayoutElement, ILayoutGroup, ILayoutController // TypeDefIndex: 4977
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected RectOffset m_Padding; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected TextAnchor m_ChildAlignment; // 0x20
	private RectTransform m_Rect; // 0x28
	protected DrivenRectTransformTracker m_Tracker; // 0x30
	private Vector2 m_TotalMinSize; // 0x34
	private Vector2 m_TotalPreferredSize; // 0x3C
	private Vector2 m_TotalFlexibleSize; // 0x44
	private List<RectTransform> m_RectChildren; // 0x50

	// Properties
	public RectOffset padding { get; set; }
	public TextAnchor childAlignment { get; set; }
	protected RectTransform rectTransform { get; }
	protected List<RectTransform> rectChildren { get; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }
	private bool isRootLayoutGroup { get; }

	// Methods

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public RectOffset get_padding() { }

	// RVA: 0x170B4F0 Offset: 0x1709AF0 VA: 0x18170B4F0
	public void set_padding(RectOffset value) { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	public TextAnchor get_childAlignment() { }

	// RVA: 0x170B4A0 Offset: 0x1709AA0 VA: 0x18170B4A0
	public void set_childAlignment(TextAnchor value) { }

	// RVA: 0x170B400 Offset: 0x1709A00 VA: 0x18170B400
	protected RectTransform get_rectTransform() { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	protected List<RectTransform> get_rectChildren() { }

	// RVA: 0x170A320 Offset: 0x1708920 VA: 0x18170A320 Slot: 28
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void CalculateLayoutInputVertical();

	// RVA: 0x170B3D0 Offset: 0x17099D0 VA: 0x18170B3D0 Slot: 30
	public virtual float get_minWidth() { }

	// RVA: 0x170B3F0 Offset: 0x17099F0 VA: 0x18170B3F0 Slot: 31
	public virtual float get_preferredWidth() { }

	// RVA: 0x170B280 Offset: 0x1709880 VA: 0x18170B280 Slot: 32
	public virtual float get_flexibleWidth() { }

	// RVA: 0x170B3C0 Offset: 0x17099C0 VA: 0x18170B3C0 Slot: 33
	public virtual float get_minHeight() { }

	// RVA: 0x170B3E0 Offset: 0x17099E0 VA: 0x18170B3E0 Slot: 34
	public virtual float get_preferredHeight() { }

	// RVA: 0x170B270 Offset: 0x1709870 VA: 0x18170B270 Slot: 35
	public virtual float get_flexibleHeight() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 36
	public virtual int get_layoutPriority() { }

	// RVA: -1 Offset: -1 Slot: 37
	public abstract void SetLayoutHorizontal();

	// RVA: -1 Offset: -1 Slot: 38
	public abstract void SetLayoutVertical();

	// RVA: 0x170B110 Offset: 0x1709710 VA: 0x18170B110
	protected void .ctor() { }

	// RVA: 0x170A8A0 Offset: 0x1708EA0 VA: 0x18170A8A0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x170A820 Offset: 0x1708E20 VA: 0x18170A820 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x170A810 Offset: 0x1708E10 VA: 0x18170A810 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x170A7F0 Offset: 0x1708DF0 VA: 0x18170A7F0
	protected float GetTotalMinSize(int axis) { }

	// RVA: 0x170A800 Offset: 0x1708E00 VA: 0x18170A800
	protected float GetTotalPreferredSize(int axis) { }

	// RVA: 0x170A7E0 Offset: 0x1708DE0 VA: 0x18170A7E0
	protected float GetTotalFlexibleSize(int axis) { }

	// RVA: 0x170A6B0 Offset: 0x1708CB0 VA: 0x18170A6B0
	protected float GetStartOffset(int axis, float requiredSpaceWithoutPadding) { }

	// RVA: 0x170A660 Offset: 0x1708C60 VA: 0x18170A660
	protected float GetAlignmentOnAxis(int axis) { }

	// RVA: 0x170B0A0 Offset: 0x17096A0 VA: 0x18170B0A0
	protected void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis) { }

	// RVA: 0x170AEC0 Offset: 0x17094C0 VA: 0x18170AEC0
	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos) { }

	// RVA: 0x170ABF0 Offset: 0x17091F0 VA: 0x18170ABF0
	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float scaleFactor) { }

	// RVA: 0x170AE00 Offset: 0x1709400 VA: 0x18170AE00
	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size) { }

	// RVA: 0x170AA00 Offset: 0x1709000 VA: 0x18170AA00
	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float size, float scaleFactor) { }

	// RVA: 0x170B290 Offset: 0x1709890 VA: 0x18170B290
	private bool get_isRootLayoutGroup() { }

	// RVA: 0x170A8C0 Offset: 0x1708EC0 VA: 0x18170A8C0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x170A810 Offset: 0x1708E10 VA: 0x18170A810 Slot: 39
	protected virtual void OnTransformChildrenChanged() { }

	// RVA: -1 Offset: -1
	protected void SetProperty<T>(ref T currentValue, T newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1310 Offset: 0x5CF910 VA: 0x1805D1310
	|-LayoutGroup.SetProperty<bool>
	|
	|-RVA: 0x5D1470 Offset: 0x5CFA70 VA: 0x1805D1470
	|-LayoutGroup.SetProperty<int>
	|
	|-RVA: 0x5D13A0 Offset: 0x5CF9A0 VA: 0x1805D13A0
	|-LayoutGroup.SetProperty<Int32Enum>
	|-LayoutGroup.SetProperty<TextAnchor>
	|-LayoutGroup.SetProperty<GridLayoutGroup.Axis>
	|-LayoutGroup.SetProperty<GridLayoutGroup.Constraint>
	|-LayoutGroup.SetProperty<GridLayoutGroup.Corner>
	|
	|-RVA: 0x5D1500 Offset: 0x5CFB00 VA: 0x1805D1500
	|-LayoutGroup.SetProperty<object>
	|-LayoutGroup.SetProperty<RectOffset>
	|
	|-RVA: 0x5D1580 Offset: 0x5CFB80 VA: 0x1805D1580
	|-LayoutGroup.SetProperty<float>
	|
	|-RVA: 0x5D1610 Offset: 0x5CFC10 VA: 0x1805D1610
	|-LayoutGroup.SetProperty<Vector2>
	*/

	// RVA: 0x170AF70 Offset: 0x1709570 VA: 0x18170AF70
	protected void SetDirty() { }

	[IteratorStateMachineAttribute] // RVA: 0x725B0 Offset: 0x719B0 VA: 0x1800725B0
	// RVA: 0x170A5F0 Offset: 0x1708BF0 VA: 0x18170A5F0
	private IEnumerator DelayedSetDirty(RectTransform rectTransform) { }

}

private sealed class LayoutGroup.<DelayedSetDirty>d__56 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 4978
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RectTransform rectTransform; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1720690 Offset: 0x171EC90 VA: 0x181720690 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1720730 Offset: 0x171ED30 VA: 0x181720730 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

