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

	// RVA: 0x752D60 Offset: 0x751360 VA: 0x180752D60
	public void Refresh(List<ItemDefinition> items, FrankensteinTable table) { }

	// RVA: 0x752A00 Offset: 0x751000 VA: 0x180752A00
	private void DisableAllReadyFX() { }

	// RVA: 0x7530C0 Offset: 0x7516C0 VA: 0x1807530C0
	private void SetReadyFX(bool ready) { }

	// RVA: 0x752670 Offset: 0x750C70 VA: 0x180752670
	public void Clear() { }

	// RVA: 0x752800 Offset: 0x750E00 VA: 0x180752800
	private void DestroyAnchorChildren(Transform t) { }

	// RVA: 0x752A40 Offset: 0x751040 VA: 0x180752A40
	public void DisplayItem(ItemDefinition item, FrankensteinTable table) { }

	// RVA: 0x752BA0 Offset: 0x7511A0 VA: 0x180752BA0
	public void DisplayItem(ItemDefinition item, Transform anchor) { }

	// RVA: 0x753190 Offset: 0x751790 VA: 0x180753190
	public void StartWaking() { }

	[IteratorStateMachineAttribute] // RVA: 0xBBC80 Offset: 0xBB080 VA: 0x1800BBC80
	// RVA: 0x753200 Offset: 0x751800 VA: 0x180753200
	private IEnumerator Wake() { }

	// RVA: 0x753110 Offset: 0x751710 VA: 0x180753110
	private void SetTableUp(bool flag) { }

	// RVA: 0x753040 Offset: 0x751640 VA: 0x180753040
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x764900 Offset: 0x762F00 VA: 0x180764900 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x764B90 Offset: 0x763190 VA: 0x180764B90 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

