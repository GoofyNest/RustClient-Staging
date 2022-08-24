public abstract class LayoutGroup : UIBehaviour, ILayoutElement, ILayoutGroup, ILayoutController // TypeDefIndex: 4977
{	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	protected RectOffset m_Padding; // 0x18
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	protected TextAnchor m_ChildAlignment; // 0x20
	private RectTransform m_Rect; // 0x28
	protected DrivenRectTransformTracker m_Tracker; // 0x30
	private Vector2 m_TotalMinSize; // 0x34
	private Vector2 m_TotalPreferredSize; // 0x3C
	private Vector2 m_TotalFlexibleSize; // 0x44
	private List<RectTransform> m_RectChildren; // 0x50

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


	public RectOffset get_padding() { }

	public void set_padding(RectOffset value) { }

	public TextAnchor get_childAlignment() { }

	public void set_childAlignment(TextAnchor value) { }

	protected RectTransform get_rectTransform() { }

	protected List<RectTransform> get_rectChildren() { }

	public virtual void CalculateLayoutInputHorizontal() { }

	public abstract void CalculateLayoutInputVertical();

	public virtual float get_minWidth() { }

	public virtual float get_preferredWidth() { }

	public virtual float get_flexibleWidth() { }

	public virtual float get_minHeight() { }

	public virtual float get_preferredHeight() { }

	public virtual float get_flexibleHeight() { }

	public virtual int get_layoutPriority() { }

	public abstract void SetLayoutHorizontal();

	public abstract void SetLayoutVertical();

	protected void .ctor() { }

	protected override void OnEnable() { }

	protected override void OnDisable() { }

	protected override void OnDidApplyAnimationProperties() { }

	protected float GetTotalMinSize(int axis) { }

	protected float GetTotalPreferredSize(int axis) { }

	protected float GetTotalFlexibleSize(int axis) { }

	protected float GetStartOffset(int axis, float requiredSpaceWithoutPadding) { }

	protected float GetAlignmentOnAxis(int axis) { }

	protected void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis) { }

	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos) { }

	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float scaleFactor) { }

	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size) { }

	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float size, float scaleFactor) { }

	private bool get_isRootLayoutGroup() { }

	protected override void OnRectTransformDimensionsChange() { }

	protected virtual void OnTransformChildrenChanged() { }

	protected void SetProperty<T>(ref T currentValue, T newValue) { }
	/* GenericInstMethod :
	|
	|-LayoutGroup.SetProperty<bool>
	|
	|-LayoutGroup.SetProperty<int>
	|
	|-LayoutGroup.SetProperty<Int32Enum>
	|-LayoutGroup.SetProperty<TextAnchor>
	|-LayoutGroup.SetProperty<GridLayoutGroup.Axis>
	|-LayoutGroup.SetProperty<GridLayoutGroup.Constraint>
	|-LayoutGroup.SetProperty<GridLayoutGroup.Corner>
	|
	|-LayoutGroup.SetProperty<object>
	|-LayoutGroup.SetProperty<RectOffset>
	|
	|-LayoutGroup.SetProperty<float>
	|
	|-LayoutGroup.SetProperty<Vector2>
	*/

	protected void SetDirty() { }

	[IteratorStateMachineAttribute] // RVA: 0x726D0 Offset: 0x71AD0 VA: 0x1800726D0
	private IEnumerator DelayedSetDirty(RectTransform rectTransform) { }

}

private sealed class LayoutGroup.<DelayedSetDirty>d__56 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 4978
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RectTransform rectTransform; // 0x20

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private object System.Collections.IEnumerator.get_Current() { }

}

