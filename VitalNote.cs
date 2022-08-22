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

	// RVA: 0x800280 Offset: 0x7FE880 VA: 0x180800280
	private void Awake() { }

	// RVA: 0x801540 Offset: 0x7FFB40 VA: 0x180801540 Slot: 4
	public void Refresh() { }

	// RVA: 0x801890 Offset: 0x7FFE90 VA: 0x180801890
	private void UpdateShow(float value, string format) { }

	// RVA: 0x8002B0 Offset: 0x7FE8B0 VA: 0x1808002B0
	private void Hide() { }

	// RVA: 0x800E60 Offset: 0x7FF460 VA: 0x180800E60 Slot: 6
	protected virtual void Show() { }

	// RVA: 0x8014F0 Offset: 0x7FFAF0 VA: 0x1808014F0
	private void ClientConnected() { }

	// RVA: 0x768AC0 Offset: 0x7670C0 VA: 0x180768AC0 Slot: 5
	public bool get_IsActive() { }

	// RVA: 0x801A70 Offset: 0x800070 VA: 0x180801A70
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

