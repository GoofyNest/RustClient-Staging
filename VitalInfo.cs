public class VitalInfo : MonoBehaviour, IClientComponent, IVitalNotice // TypeDefIndex: 11286
{	public HudElement Element; // 0x18
	public Image InfoImage; // 0x20
	public VitalInfo.Vital VitalType; // 0x28
	public TextMeshProUGUI text; // 0x30
	private bool show; // 0x38

	public bool IsActive { get; }


	private void Awake() { }

	public void Refresh() { }

	[IteratorStateMachineAttribute] // RVA: 0xA30B0 Offset: 0xA24B0 VA: 0x1800A30B0
	private IEnumerator FlashInfoIcon(int count, float interval) { }

	private void Hide() { }

	private void Show() { }

	private void ClientConnected() { }

	public bool get_IsActive() { }

	public void .ctor() { }

}

public enum VitalInfo.Vital // TypeDefIndex: 11287
{	public int value__; // 0x0
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

private sealed class VitalInfo.<FlashInfoIcon>d__7 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11288
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public VitalInfo <>4__this; // 0x20
	public float interval; // 0x28
	public int count; // 0x2C
	private int <i>5__2; // 0x30

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

