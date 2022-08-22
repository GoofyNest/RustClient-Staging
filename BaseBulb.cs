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

	// RVA: 0x7A2470 Offset: 0x7A0A70 VA: 0x1807A2470 Slot: 4
	public virtual void SetOn(bool wantsOn) { }

	// RVA: 0x7A2480 Offset: 0x7A0A80 VA: 0x1807A2480 Slot: 5
	public virtual void SetSpacingIndex(float timeOffset, int bulbIndex) { }

	// RVA: 0x7A2460 Offset: 0x7A0A60 VA: 0x1807A2460 Slot: 6
	public virtual void SetBulbAnimation(AdvancedChristmasLights.AnimationType type) { }

	// RVA: 0x7A2490 Offset: 0x7A0A90 VA: 0x1807A2490
	private void UpdateMaterialProperties() { }

	// RVA: 0x7A2650 Offset: 0x7A0C50 VA: 0x1807A2650
	public void .ctor() { }

	// RVA: 0x7A25D0 Offset: 0x7A0BD0 VA: 0x1807A25D0
	private static void .cctor() { }

}

