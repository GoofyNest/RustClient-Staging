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

	// RVA: 0x752E10 Offset: 0x751410 VA: 0x180752E10
	public void Refresh(List<ItemDefinition> items, FrankensteinTable table) { }

	// RVA: 0x752AB0 Offset: 0x7510B0 VA: 0x180752AB0
	private void DisableAllReadyFX() { }

	// RVA: 0x753170 Offset: 0x751770 VA: 0x180753170
	private void SetReadyFX(bool ready) { }

	// RVA: 0x752720 Offset: 0x750D20 VA: 0x180752720
	public void Clear() { }

	// RVA: 0x7528B0 Offset: 0x750EB0 VA: 0x1807528B0
	private void DestroyAnchorChildren(Transform t) { }

	// RVA: 0x752AF0 Offset: 0x7510F0 VA: 0x180752AF0
	public void DisplayItem(ItemDefinition item, FrankensteinTable table) { }

	// RVA: 0x752C50 Offset: 0x751250 VA: 0x180752C50
	public void DisplayItem(ItemDefinition item, Transform anchor) { }

	// RVA: 0x753240 Offset: 0x751840 VA: 0x180753240
	public void StartWaking() { }

	[IteratorStateMachineAttribute] // RVA: 0xBBC80 Offset: 0xBB080 VA: 0x1800BBC80
	// RVA: 0x7532B0 Offset: 0x7518B0 VA: 0x1807532B0
	private IEnumerator Wake() { }

	// RVA: 0x7531C0 Offset: 0x7517C0 VA: 0x1807531C0
	private void SetTableUp(bool flag) { }

	// RVA: 0x7530F0 Offset: 0x7516F0 VA: 0x1807530F0
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

	// RVA: 0x7649B0 Offset: 0x762FB0 VA: 0x1807649B0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x764C40 Offset: 0x763240 VA: 0x180764C40 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

