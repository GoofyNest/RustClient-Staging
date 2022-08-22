public class BaseBulb : MonoBehaviour // TypeDefIndex: 8824
{	// Fields
	public Renderer bulbRenderer; // 0x18
	private static readonly int timeOffsetHash; // 0x0
	private static readonly int bulbIndexHash; // 0x4
	private static readonly int modeHash; // 0x8
	private AdvancedChristmasLights.AnimationType currentAnimationType; // 0x20
	private float timeOffset; // 0x24
	private int bulbIndex; // 0x28
	private bool isOn; // 0x2C
	private MaterialPropertyBlock materialPropertyBlock; // 0x30

	// Methods

	// RVA: 0x7D6B50 Offset: 0x7D5150 VA: 0x1807D6B50 Slot: 4
	public virtual void SetOn(bool wantsOn) { }

	// RVA: 0x7D6B60 Offset: 0x7D5160 VA: 0x1807D6B60 Slot: 5
	public virtual void SetSpacingIndex(float timeOffset, int bulbIndex) { }

	// RVA: 0x7D6B40 Offset: 0x7D5140 VA: 0x1807D6B40 Slot: 6
	public virtual void SetBulbAnimation(AdvancedChristmasLights.AnimationType type) { }

	// RVA: 0x7D6B70 Offset: 0x7D5170 VA: 0x1807D6B70
	private void UpdateMaterialProperties() { }

	// RVA: 0x7D6D30 Offset: 0x7D5330 VA: 0x1807D6D30
	public void .ctor() { }

	// RVA: 0x7D6CB0 Offset: 0x7D52B0 VA: 0x1807D6CB0
	private static void .cctor() { }

}

