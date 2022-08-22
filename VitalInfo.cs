public class VitalInfo : MonoBehaviour, IClientComponent, IVitalNotice // TypeDefIndex: 11282
{	// Fields
	public HudElement Element; // 0x18
	public Image InfoImage; // 0x20
	public VitalInfo.Vital VitalType; // 0x28
	public TextMeshProUGUI text; // 0x30
	private bool show; // 0x38

	// Properties
	public bool IsActive { get; }

	// Methods

	// RVA: 0x7FFBE0 Offset: 0x7FE1E0 VA: 0x1807FFBE0
	private void Awake() { }

	// RVA: 0x7FFCE0 Offset: 0x7FE2E0 VA: 0x1807FFCE0 Slot: 4
	public void Refresh() { }

	[IteratorStateMachineAttribute] // RVA: 0xA2F10 Offset: 0xA2310 VA: 0x1800A2F10
	// RVA: 0x7FFC50 Offset: 0x7FE250 VA: 0x1807FFC50
	private IEnumerator FlashInfoIcon(int count, float interval) { }

	// RVA: 0x7FFC10 Offset: 0x7FE210 VA: 0x1807FFC10
	private void Hide() { }

	// RVA: 0x8007C0 Offset: 0x7FEDC0 VA: 0x1808007C0
	private void Show() { }

	// RVA: 0x7FFC10 Offset: 0x7FE210 VA: 0x1807FFC10
	private void ClientConnected() { }

	// RVA: 0x768A60 Offset: 0x767060 VA: 0x180768A60 Slot: 5
	public bool get_IsActive() { }

	// RVA: 0x800800 Offset: 0x7FEE00 VA: 0x180800800
	public void .ctor() { }

}

public enum VitalInfo.Vital // TypeDefIndex: 11283
{	// Fields
	public int value__; // 0x0
	public const VitalInfo.Vital BuildingBlocked = 0;
	public const VitalInfo.Vital CanBuild = 1;
	public const VitalInfo.Vital Crafting = 2;
	public const VitalInfo.Vital CraftLevel1 = 3;
	public const VitalInfo.Vital CraftLevel2 = 4;
	public const VitalInfo.Vital CraftLevel3 = 5;
	public const VitalInfo.Vital DecayProtected = 6;
	public const VitalInfo.Vital Decaying = 7;
	public const VitalInfo.Vital SafeZone = 8;
	public const VitalInfo.Vital Buffed = 9;
	public const VitalInfo.Vital Pet = 10;

}

private sealed class VitalInfo.<FlashInfoIcon>d__7 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11284
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public VitalInfo <>4__this; // 0x20
	public float interval; // 0x28
	public int count; // 0x2C
	private int <i>5__2; // 0x30

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

	// RVA: 0x7EFC60 Offset: 0x7EE260 VA: 0x1807EFC60 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EFDD0 Offset: 0x7EE3D0 VA: 0x1807EFDD0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

