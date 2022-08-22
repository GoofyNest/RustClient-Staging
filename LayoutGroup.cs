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

	// RVA: 0x17120A0 Offset: 0x17106A0 VA: 0x1817120A0
	public void set_padding(RectOffset value) { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public TextAnchor get_childAlignment() { }

	// RVA: 0x1712050 Offset: 0x1710650 VA: 0x181712050
	public void set_childAlignment(TextAnchor value) { }

	// RVA: 0x1711FB0 Offset: 0x17105B0 VA: 0x181711FB0
	protected RectTransform get_rectTransform() { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	protected List<RectTransform> get_rectChildren() { }

	// RVA: 0x1710ED0 Offset: 0x170F4D0 VA: 0x181710ED0 Slot: 28
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void CalculateLayoutInputVertical();

	// RVA: 0x1711F80 Offset: 0x1710580 VA: 0x181711F80 Slot: 30
	public virtual float get_minWidth() { }

	// RVA: 0x1711FA0 Offset: 0x17105A0 VA: 0x181711FA0 Slot: 31
	public virtual float get_preferredWidth() { }

	// RVA: 0x1711E30 Offset: 0x1710430 VA: 0x181711E30 Slot: 32
	public virtual float get_flexibleWidth() { }

	// RVA: 0x1711F70 Offset: 0x1710570 VA: 0x181711F70 Slot: 33
	public virtual float get_minHeight() { }

	// RVA: 0x1711F90 Offset: 0x1710590 VA: 0x181711F90 Slot: 34
	public virtual float get_preferredHeight() { }

	// RVA: 0x1711E20 Offset: 0x1710420 VA: 0x181711E20 Slot: 35
	public virtual float get_flexibleHeight() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 36
	public virtual int get_layoutPriority() { }

	// RVA: -1 Offset: -1 Slot: 37
	public abstract void SetLayoutHorizontal();

	// RVA: -1 Offset: -1 Slot: 38
	public abstract void SetLayoutVertical();

	// RVA: 0x1711CC0 Offset: 0x17102C0 VA: 0x181711CC0
	protected void .ctor() { }

	// RVA: 0x1711450 Offset: 0x170FA50 VA: 0x181711450 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x17113D0 Offset: 0x170F9D0 VA: 0x1817113D0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x17113C0 Offset: 0x170F9C0 VA: 0x1817113C0 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x17113A0 Offset: 0x170F9A0 VA: 0x1817113A0
	protected float GetTotalMinSize(int axis) { }

	// RVA: 0x17113B0 Offset: 0x170F9B0 VA: 0x1817113B0
	protected float GetTotalPreferredSize(int axis) { }

	// RVA: 0x1711390 Offset: 0x170F990 VA: 0x181711390
	protected float GetTotalFlexibleSize(int axis) { }

	// RVA: 0x1711260 Offset: 0x170F860 VA: 0x181711260
	protected float GetStartOffset(int axis, float requiredSpaceWithoutPadding) { }

	// RVA: 0x1711210 Offset: 0x170F810 VA: 0x181711210
	protected float GetAlignmentOnAxis(int axis) { }

	// RVA: 0x1711C50 Offset: 0x1710250 VA: 0x181711C50
	protected void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis) { }

	// RVA: 0x1711A70 Offset: 0x1710070 VA: 0x181711A70
	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos) { }

	// RVA: 0x17117A0 Offset: 0x170FDA0 VA: 0x1817117A0
	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float scaleFactor) { }

	// RVA: 0x17119B0 Offset: 0x170FFB0 VA: 0x1817119B0
	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size) { }

	// RVA: 0x17115B0 Offset: 0x170FBB0 VA: 0x1817115B0
	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float size, float scaleFactor) { }

	// RVA: 0x1711E40 Offset: 0x1710440 VA: 0x181711E40
	private bool get_isRootLayoutGroup() { }

	// RVA: 0x1711470 Offset: 0x170FA70 VA: 0x181711470 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x17113C0 Offset: 0x170F9C0 VA: 0x1817113C0 Slot: 39
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

	// RVA: 0x1711B20 Offset: 0x1710120 VA: 0x181711B20
	protected void SetDirty() { }

	[IteratorStateMachineAttribute] // RVA: 0x725B0 Offset: 0x719B0 VA: 0x1800725B0
	// RVA: 0x17111A0 Offset: 0x170F7A0 VA: 0x1817111A0
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

	// RVA: 0x1727270 Offset: 0x1725870 VA: 0x181727270 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1727310 Offset: 0x1725910 VA: 0x181727310 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

