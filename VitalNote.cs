public class VitalNote : MonoBehaviour, IClientComponent, IVitalNotice // TypeDefIndex: 11285
{	// Fields
	public VitalNote.Vital VitalType; // 0x18
	public FloatConditions showIf; // 0x20
	public TextMeshProUGUI valueText; // 0x28
	private float lastValue; // 0x30
	private float lastPrintedValue; // 0x34
	protected bool show; // 0x38

	// Properties
	public bool IsActive { get; }

	// Methods

	// RVA: 0x7FFBE0 Offset: 0x7FE1E0 VA: 0x1807FFBE0
	private void Awake() { }

	// RVA: 0x800EA0 Offset: 0x7FF4A0 VA: 0x180800EA0 Slot: 4
	public void Refresh() { }

	// RVA: 0x8011F0 Offset: 0x7FF7F0 VA: 0x1808011F0
	private void UpdateShow(float value, string format) { }

	// RVA: 0x7FFC10 Offset: 0x7FE210 VA: 0x1807FFC10
	private void Hide() { }

	// RVA: 0x8007C0 Offset: 0x7FEDC0 VA: 0x1808007C0 Slot: 6
	protected virtual void Show() { }

	// RVA: 0x800E50 Offset: 0x7FF450 VA: 0x180800E50
	private void ClientConnected() { }

	// RVA: 0x768A60 Offset: 0x767060 VA: 0x180768A60 Slot: 5
	public bool get_IsActive() { }

	// RVA: 0x8013D0 Offset: 0x7FF9D0 VA: 0x1808013D0
	public void .ctor() { }

}

public enum VitalNote.Vital // TypeDefIndex: 11286
{	// Fields
	public int value__; // 0x0
	public const VitalNote.Vital Comfort = 0;
	public const VitalNote.Vital Radiation = 1;
	public const VitalNote.Vital Poison = 2;
	public const VitalNote.Vital Cold = 3;
	public const VitalNote.Vital Bleeding = 4;
	public const VitalNote.Vital Hot = 5;
	public const VitalNote.Vital Oxygen = 6;
	public const VitalNote.Vital Wet = 7;
	public const VitalNote.Vital Hygiene = 8;
	public const VitalNote.Vital Starving = 9;
	public const VitalNote.Vital Dehydration = 10;

}

