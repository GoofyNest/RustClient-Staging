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

	// RVA: 0x7FFCF0 Offset: 0x7FE2F0 VA: 0x1807FFCF0
	private void Awake() { }

	// RVA: 0x800FB0 Offset: 0x7FF5B0 VA: 0x180800FB0 Slot: 4
	public void Refresh() { }

	// RVA: 0x801300 Offset: 0x7FF900 VA: 0x180801300
	private void UpdateShow(float value, string format) { }

	// RVA: 0x7FFD20 Offset: 0x7FE320 VA: 0x1807FFD20
	private void Hide() { }

	// RVA: 0x8008D0 Offset: 0x7FEED0 VA: 0x1808008D0 Slot: 6
	protected virtual void Show() { }

	// RVA: 0x800F60 Offset: 0x7FF560 VA: 0x180800F60
	private void ClientConnected() { }

	// RVA: 0x768B70 Offset: 0x767170 VA: 0x180768B70 Slot: 5
	public bool get_IsActive() { }

	// RVA: 0x8014E0 Offset: 0x7FFAE0 VA: 0x1808014E0
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

