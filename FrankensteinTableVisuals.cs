public class FrankensteinTableVisuals : MonoBehaviour // TypeDefIndex: 8695
{	// Fields
	public GameObject FXReady; // 0x18
	public GameObject FXNotReady; // 0x20
	public GameObject FXWake; // 0x28
	public Transform HeadVisualAnchor; // 0x30
	public Transform TorsoVisualAnchor; // 0x38
	public Transform LegsVisualAnchor; // 0x40
	public Animator Animator; // 0x48

	// Methods

	// RVA: 0x752D00 Offset: 0x751300 VA: 0x180752D00
	public void Refresh(List<ItemDefinition> items, FrankensteinTable table) { }

	// RVA: 0x7529A0 Offset: 0x750FA0 VA: 0x1807529A0
	private void DisableAllReadyFX() { }

	// RVA: 0x753060 Offset: 0x751660 VA: 0x180753060
	private void SetReadyFX(bool ready) { }

	// RVA: 0x752610 Offset: 0x750C10 VA: 0x180752610
	public void Clear() { }

	// RVA: 0x7527A0 Offset: 0x750DA0 VA: 0x1807527A0
	private void DestroyAnchorChildren(Transform t) { }

	// RVA: 0x7529E0 Offset: 0x750FE0 VA: 0x1807529E0
	public void DisplayItem(ItemDefinition item, FrankensteinTable table) { }

	// RVA: 0x752B40 Offset: 0x751140 VA: 0x180752B40
	public void DisplayItem(ItemDefinition item, Transform anchor) { }

	// RVA: 0x753130 Offset: 0x751730 VA: 0x180753130
	public void StartWaking() { }

	[IteratorStateMachineAttribute] // RVA: 0xBBBF0 Offset: 0xBAFF0 VA: 0x1800BBBF0
	// RVA: 0x7531A0 Offset: 0x7517A0 VA: 0x1807531A0
	private IEnumerator Wake() { }

	// RVA: 0x7530B0 Offset: 0x7516B0 VA: 0x1807530B0
	private void SetTableUp(bool flag) { }

	// RVA: 0x752FE0 Offset: 0x7515E0 VA: 0x180752FE0
	private void SetLeverUp(bool flag) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

private sealed class FrankensteinTableVisuals.<Wake>d__15 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 8696
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FrankensteinTableVisuals <>4__this; // 0x20

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

	// RVA: 0x7648A0 Offset: 0x762EA0 VA: 0x1807648A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x764B30 Offset: 0x763130 VA: 0x180764B30 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

