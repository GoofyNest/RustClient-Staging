public abstract class LayoutGroup : UIBehaviour, ILayoutElement, ILayoutGroup, ILayoutController // TypeDefIndex: 4977
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected RectOffset m_Padding; // 0x18
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x1711DE0 Offset: 0x17103E0 VA: 0x181711DE0
	public void set_padding(RectOffset value) { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public TextAnchor get_childAlignment() { }

	// RVA: 0x1711D90 Offset: 0x1710390 VA: 0x181711D90
	public void set_childAlignment(TextAnchor value) { }

	// RVA: 0x1711CF0 Offset: 0x17102F0 VA: 0x181711CF0
	protected RectTransform get_rectTransform() { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	protected List<RectTransform> get_rectChildren() { }

	// RVA: 0x1710C10 Offset: 0x170F210 VA: 0x181710C10 Slot: 28
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void CalculateLayoutInputVertical();

	// RVA: 0x1711CC0 Offset: 0x17102C0 VA: 0x181711CC0 Slot: 30
	public virtual float get_minWidth() { }

	// RVA: 0x1711CE0 Offset: 0x17102E0 VA: 0x181711CE0 Slot: 31
	public virtual float get_preferredWidth() { }

	// RVA: 0x1711B70 Offset: 0x1710170 VA: 0x181711B70 Slot: 32
	public virtual float get_flexibleWidth() { }

	// RVA: 0x1711CB0 Offset: 0x17102B0 VA: 0x181711CB0 Slot: 33
	public virtual float get_minHeight() { }

	// RVA: 0x1711CD0 Offset: 0x17102D0 VA: 0x181711CD0 Slot: 34
	public virtual float get_preferredHeight() { }

	// RVA: 0x1711B60 Offset: 0x1710160 VA: 0x181711B60 Slot: 35
	public virtual float get_flexibleHeight() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 36
	public virtual int get_layoutPriority() { }

	// RVA: -1 Offset: -1 Slot: 37
	public abstract void SetLayoutHorizontal();

	// RVA: -1 Offset: -1 Slot: 38
	public abstract void SetLayoutVertical();

	// RVA: 0x1711A00 Offset: 0x1710000 VA: 0x181711A00
	protected void .ctor() { }

	// RVA: 0x1711190 Offset: 0x170F790 VA: 0x181711190 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1711110 Offset: 0x170F710 VA: 0x181711110 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1711100 Offset: 0x170F700 VA: 0x181711100 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x17110E0 Offset: 0x170F6E0 VA: 0x1817110E0
	protected float GetTotalMinSize(int axis) { }

	// RVA: 0x17110F0 Offset: 0x170F6F0 VA: 0x1817110F0
	protected float GetTotalPreferredSize(int axis) { }

	// RVA: 0x17110D0 Offset: 0x170F6D0 VA: 0x1817110D0
	protected float GetTotalFlexibleSize(int axis) { }

	// RVA: 0x1710FA0 Offset: 0x170F5A0 VA: 0x181710FA0
	protected float GetStartOffset(int axis, float requiredSpaceWithoutPadding) { }

	// RVA: 0x1710F50 Offset: 0x170F550 VA: 0x181710F50
	protected float GetAlignmentOnAxis(int axis) { }

	// RVA: 0x1711990 Offset: 0x170FF90 VA: 0x181711990
	protected void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis) { }

	// RVA: 0x17117B0 Offset: 0x170FDB0 VA: 0x1817117B0
	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos) { }

	// RVA: 0x17114E0 Offset: 0x170FAE0 VA: 0x1817114E0
	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float scaleFactor) { }

	// RVA: 0x17116F0 Offset: 0x170FCF0 VA: 0x1817116F0
	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size) { }

	// RVA: 0x17112F0 Offset: 0x170F8F0 VA: 0x1817112F0
	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float size, float scaleFactor) { }

	// RVA: 0x1711B80 Offset: 0x1710180 VA: 0x181711B80
	private bool get_isRootLayoutGroup() { }

	// RVA: 0x17111B0 Offset: 0x170F7B0 VA: 0x1817111B0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1711100 Offset: 0x170F700 VA: 0x181711100 Slot: 39
	protected virtual void OnTransformChildrenChanged() { }

	// RVA: -1 Offset: -1
	protected void SetProperty<T>(ref T currentValue, T newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1380 Offset: 0x5CF980 VA: 0x1805D1380
	|-LayoutGroup.SetProperty<bool>
	|
	|-RVA: 0x5D14E0 Offset: 0x5CFAE0 VA: 0x1805D14E0
	|-LayoutGroup.SetProperty<int>
	|
	|-RVA: 0x5D1410 Offset: 0x5CFA10 VA: 0x1805D1410
	|-LayoutGroup.SetProperty<Int32Enum>
	|-LayoutGroup.SetProperty<TextAnchor>
	|-LayoutGroup.SetProperty<GridLayoutGroup.Axis>
	|-LayoutGroup.SetProperty<GridLayoutGroup.Constraint>
	|-LayoutGroup.SetProperty<GridLayoutGroup.Corner>
	|
	|-RVA: 0x5D1570 Offset: 0x5CFB70 VA: 0x1805D1570
	|-LayoutGroup.SetProperty<object>
	|-LayoutGroup.SetProperty<RectOffset>
	|
	|-RVA: 0x5D15F0 Offset: 0x5CFBF0 VA: 0x1805D15F0
	|-LayoutGroup.SetProperty<float>
	|
	|-RVA: 0x5D1680 Offset: 0x5CFC80 VA: 0x1805D1680
	|-LayoutGroup.SetProperty<Vector2>
	*/

	// RVA: 0x1711860 Offset: 0x170FE60 VA: 0x181711860
	protected void SetDirty() { }

	[IteratorStateMachineAttribute] // RVA: 0x724F0 Offset: 0x718F0 VA: 0x1800724F0
	// RVA: 0x1710EE0 Offset: 0x170F4E0 VA: 0x181710EE0
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1726FB0 Offset: 0x17255B0 VA: 0x181726FB0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1727050 Offset: 0x1725650 VA: 0x181727050 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

